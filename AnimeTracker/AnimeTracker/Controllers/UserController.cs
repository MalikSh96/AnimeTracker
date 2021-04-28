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
                return RedirectToAction(nameof(Users));
            }
            else
            {
                throw new ArgumentException("The entered password was incorrect!");
            }
        }

        //[HttpPost]
        //public async Task<IActionResult> Logout()
        //{
        //    await signInManager.SignOutAsync();
        //    return RedirectToAction("Index", "Home");
        //}

        //[HttpGet]
        //[Route("allusers")]
        public IActionResult Users()
        {
            ViewBag.User = db.User.ToList();
            return View();
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