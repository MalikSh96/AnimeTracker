using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimeTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace AnimeTracker.Controllers
{
    [Route("Users")]
    public class UserController : Controller
    {
        private DataContext db = new DataContext();
        private IHostingEnvironment Environment;

        public UserController(IHostingEnvironment _environment)
        {
            Environment = _environment;
        }

        //[Authorize]
        //[HttpGet]
        //[Route("allusers")]
        public IActionResult Users(User loginUser)
        {
            HttpContext.Session.GetString("username");
            ViewBag.User = db.User.ToList();
            return View();
        }

        //[AllowAnonymous]
        [HttpGet]
        [Route("Register")]
        public IActionResult Create()
        {
            return View("Register");
        }

        // POST: Users/Register
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Register")]
        public IActionResult Register(User user, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (db.User.Any(u => u.username == user.username))
                {
                    throw new ArgumentException("The entered username already exist");
                }
                string env = Environment.WebRootPath;
                DirectoryInfo di = new DirectoryInfo(env + "/userimages");
                DirectoryInfo dir = di.CreateSubdirectory(user.username);

                string relpath = user.username;

                user.password = BCrypt.Net.BCrypt.HashPassword(user.password);

                if (file != null && file.Length > 0)
                {
                    var save = Path.Combine($"wwwroot/userimages/{relpath}/", file.FileName);
                    var stream = new FileStream(save, FileMode.Create);
                    file.CopyTo(stream);
                    user.profilepic_path = save;
                    db.User.Add(user);
                    db.SaveChanges();
                }
                else
                {
                    db.User.Add(user);
                    db.SaveChanges();
                }
                //db.Add(user);
                //await db.SaveChangesAsync();
                //return RedirectToAction(nameof(Users));
            }
            //we redirect back to frontpage
            return RedirectToAction(nameof(Users));
            //return View(user);
        }

        //[AllowAnonymous]
        [HttpGet]
        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(User loginUser)
        {
            //we look for the username in the database
            var user = db.User.FirstOrDefault(u => u.username == loginUser.username);
            //if the user is null, we throw an error
            if (user == null)
            {
                throw new ArgumentException("The entered username does not exist!");
            }

            bool isValidPassword = BCrypt.Net.BCrypt.Verify(loginUser.password, user.password);

            if (isValidPassword)
            {
                //if the user signing in is an admin, we redirect to "admin" page
                //if the user signing in isn't an admin, we redirect to "anime" page
                if (user.admin)
                {
                    HttpContext.Session.SetString("username", user.username);
                    return RedirectToAction(nameof(Users));
                }
                else
                {
                    HttpContext.Session.SetString("username", user.username);
                    return RedirectToAction("getall", "Anime", null);
                }
            }
            else
            {
                throw new ArgumentException("The entered password was incorrect!");
            }
        }

        //[Authorize]
        [Route("Logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction(nameof(Login));
        }

        //[HttpPost]
        //public async Task<IActionResult> Logout()
        //{
        //    await signInManager.SignOutAsync();
        //    return RedirectToAction("Index", "Home");
        //}

        [HttpGet]
        [Route("Edit/{user_id}")]
        public IActionResult Edit(int user_id)
        {
            return View(nameof(Edit), db.User.Find(user_id));
        }

        [HttpPost]
        [Route("Edit/{user_id}")]
        public IActionResult Edit(int user_id, User user, IFormFile file)
        {
            int dbId = user.user_id;
            //We use AsNoTracking, as we only need to read the data and not update it
            var dbuser = db.User.AsNoTracking().FirstOrDefault(u => u.user_id == dbId);
            string username = user.username;

            //we get the absolute path and store it in env
            string env = Environment.WebRootPath;
            string relpath = username;
            //we make use of the above variable to combine our absolute path with its subfolder
            DirectoryInfo di = new DirectoryInfo(env + "/userimages/" + relpath);

            /*
             If the directory corresponding to the updated username, when editing their name, 
             does not exist, we create a folder for
             them and store their picture, when editing, in there.
            */
            if (!di.Exists)
            {
                //now that we have combined our pathes, we make a subfolder dynamically based on the input
                DirectoryInfo dir = di.CreateSubdirectory(user.username);
            }

            string combPath = Path.Combine($"wwwroot/userimages/{relpath}/");
            //we keep track of the users hashed db password
            string pw = dbuser.password;

            if (file != null && file.Length > 0)
            {
                //we combine our database path (path) and combine it with our set string
                var save = Path.Combine(combPath, file.FileName);
                //if the file already exist, we open it, otherwise we create one
                var stream = new FileStream(save, FileMode.OpenOrCreate);
                file.CopyTo(stream);

                //We need to maintain the users password
                user.password = pw;
                //we store our new path to be our "save" 
                user.profilepic_path = save;
                //we start our modification here
                db.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            else
            {
                //We need to maintain the users password
                user.password = pw;
                user.profilepic_path = dbuser.profilepic_path;
                db.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }

            return RedirectToAction(nameof(Users));
        }

        [HttpGet]
        [Route("delete/{user_id}")]
        public IActionResult DeleteUser(int user_id)
        {
            //we need to reference the related username to the id
            var user = db.User.Find(user_id);
            //we store the connected anime name to the id in our string
            string u = user.username;
            //this is just an extra step, but we store our "a" string in our folderpath string
            string folderpath = u;
            //we combine it all into our path dynamically
            string path = Path.Combine($"wwwroot/userimages/{folderpath}/");
            //we create a new instance of our path and store it into info
            DirectoryInfo info = new DirectoryInfo(path);

            //we loop through for each file we have in our given folder
            /*
             we use EnumerateFiles() since it is more efficient than GetFiles(), 
             in case our directory have many files
             because when you use EnumerateFiles() you can start enumerating 
             it before the whole collection is returned, as opposed to GetFiles() where you 
             need to load the entire collection in memory before begin to enumerate it
            */
            foreach (FileInfo file in info.EnumerateFiles())
            {
                file.Delete();
            }
            //The same applies to EnumerateDirectories() and GetDirectories()
            //foreach (DirectoryInfo dir in info.EnumerateDirectories())
            //{
            //    dir.Delete(false);
            //}

            db.User.Remove(db.User.Find(user_id));
            db.SaveChanges();
            //we delete the subfolder related to the removed anime
            Directory.Delete(path, true);
            return RedirectToAction(nameof(Users));
        }

        // GET: Users/CheckUser/id
        //[HttpGet]
        //public IActionResult CheckUser(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var user = db.User
        //        .FirstOrDefault(m => m.user_id == id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(user);
        //}
    }
}