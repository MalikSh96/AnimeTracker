using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnimeTracker.Models;
using PagedList.Core;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.Extensions.FileProviders;

namespace AnimeTracker.Controllers
{
    [Route("Anime")]
    public class AnimeController : Controller
    {
        private DataContext db = new DataContext();
        private IHostingEnvironment Environment;
        public List<string> ImageList { get; set; }
        public Anime a { get; }

        public AnimeController(IHostingEnvironment _environment)
        {
            Environment = _environment;
        }

        [Route("")]
        [Route("anime")]
        [Route("~/")]
        public IActionResult Index(/*int page = 1, int pagesize = 5*/)
        {
            //ViewBag.Anime = db.Animes.OrderBy(_ => _.animename).ToList();
            ViewBag.Anime = db.Animes.ToList();

            //Logic to display pagination -- the commented parts in this function
            //PagedList<Anime> model = new PagedList<Anime>(db.Animes, page, pagesize);
            return View(/*model*/);
        }

        [HttpGet]
        [Route("search")]
        public IActionResult Search()
        {
            //ViewBag.Anime = db.Animes.ToList();
            //order the list by animename (a --> z)
            ViewBag.Anime = db.Animes.OrderBy(_ => _.animename).ToList();
            return View();
        }

        [HttpGet]
        [Route("getall")]
        public IActionResult AllAnime()
        {
            //ViewBag.Anime = db.Animes.ToList();
            //order the list by animename (a --> z)
            ViewBag.Anime = db.Animes.OrderBy(_ => _.animename).ToList();
            return View();
        }

        [HttpGet]
        [Route("Add")]
        public IActionResult AddAnime()
        {
            return View("Add");
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult AddAnime(IEnumerable<IFormFile> files, Anime anime)
        {
            //we get the absolute path and store it in env
            string env = Environment.WebRootPath;
            //we make use of the above variable to combine our absolute path with its subfolder
            DirectoryInfo di = new DirectoryInfo(env + "/animeimages");
            //now that we have combined our pathes, we make a subfolder dynamically based on the input
            DirectoryInfo dir = di.CreateSubdirectory(anime.animename);
            /*since dir returns the absolute path, we need to use the relative path
            therefore after we have managed to create that subfolder based on our input
            we can manipulate our path
            */
            //we use relpath to refer to our newly created folder based on the input
            string relpath = anime.animename;

            foreach (var file in files)
            {
                //by using $ before our string, we create an inpolated string
                //An interpolated string expression looks like a template string that contains expressions
                var save = Path.Combine($"wwwroot/animeimages/{relpath}/", file.FileName);
                var stream = new FileStream(save, FileMode.Create);
                file.CopyTo(stream);
                //we save the path of the folder so that we can store it into the database
                anime.img_path = save;
                //we add our anime data
                db.Animes.Add(anime);
            }
            //we save our changes
            db.SaveChanges();

            //we redirect back to frontpage
            return RedirectToAction("Index");
        }

        //[HttpPost]
        //[Route("Add")]
        //public async Task<IActionResult> AddAnime(IFormFile file, Anime anime)
        //{
        //    string extension = Path.GetExtension(file.FileName);
        //    //we get the absolute path and store it in env
        //    string env = Environment.WebRootPath;
        //    //we make use of the above variable to combine our absolute path with its subfolder
        //    DirectoryInfo di = new DirectoryInfo(env + "/animeimages");
        //    //now that we have combined our pathes, we make a subfolder dynamicallt based on the input
        //    DirectoryInfo dir = di.CreateSubdirectory(anime.animename);

        //    /*since dir returns the absolute path, we need to use the relative path
        //    therefore after we have managed to create that subfolder based on our input
        //    we can manipulate our path
        //    */
        //    //we use relpath to refer to our newly created folder based on the input
        //    string relpath = anime.animename;

        //    if (extension == ".jpg" || extension == ".gif" || extension == ".png")
        //    {
        //        //by using $ before our string, we create an inpolated string
        //        //An interpolated string expression looks like a template string that contains expressions
        //        var save = Path.Combine($"wwwroot/animeimages/{relpath}/", file.FileName);
        //        //var save = Path.Combine($"{dir}/", file.FileName);
        //        var stream = new FileStream(save, FileMode.Create);
        //        await file.CopyToAsync(stream);
        //        //file.CopyTo(stream);
        //        anime.img_path = save;
        //        db.Animes.Add(anime);
        //        db.SaveChanges();
        //    }
        //    else
        //    {
        //        ViewData["Message"] = "An error occured";
        //    }
        //    //db.Animes.Add(anime);
        //    //db.SaveChanges();
        //    return RedirectToAction("Index");


        //    /*
        //     *Below code functions well, the code below posts the
        //      images relative path into the database, which makes it easier to use
        //      than the absolute path
        //     */
        //    /*string extension = Path.GetExtension(file.FileName);
        //    if (extension == ".jpg" || extension == ".gif" || extension == ".png")
        //    {
        //        var save = Path.Combine("wwwroot/animeimages/", file.FileName);
        //        var stream = new FileStream(save, FileMode.Create);
        //        await file.CopyToAsync(stream);
        //        //file.CopyTo(stream);
        //        anime.img_path = save;
        //        db.Animes.Add(anime);
        //        db.SaveChanges();
        //    }
        //    else
        //    {
        //        ViewData["Message"] = "An error occured";
        //    }
        //    //db.Animes.Add(anime);
        //    //db.SaveChanges();
        //    return RedirectToAction("Index");*/

        //    /*
        //     * The code below works for posting the path into the database
        //     * Issue is that it post the absolute path, which makes it harder to retrieve 
        //       an image on the website, as the domain link and the db path collides wrongly
        //     * 
        //    string extension = Path.GetExtension(file.FileName);
        //    string wwwPath = this.Environment.WebRootPath;
        //    if (extension == ".jpg" || extension == ".gif" || extension == ".png")
        //    {
        //        var save = Path.Combine(wwwPath, "animeimages", file.FileName);
        //        var stream = new FileStream(save, FileMode.Create);
        //        await file.CopyToAsync(stream);
        //        anime.img_path = save;
        //        db.Animes.Add(anime);
        //        db.SaveChanges();
        //    }
        //    else
        //    {
        //        ViewData["Message"] = "An error occured";
        //    }

        //    return RedirectToAction("Index"); 
        //     */
        //}

        [HttpGet]
        [Route("delete/{anime_id}")]
        public IActionResult DeleteAnime(int anime_id)
        {
            db.Animes.Remove(db.Animes.Find(anime_id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{anime_id}")]
        public IActionResult Edit(int anime_id)
        {
            return View("Edit", db.Animes.Find(anime_id));
        }

        [HttpPost]
        [Route("edit/{anime_id}")]
        public IActionResult Edit(int anime_id, Anime anime)
        {
            db.Entry(anime).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("moreinfo/{id}")]
        public IActionResult MoreInfo(int id)
        {
            //https://www.c-sharpcorner.com/UploadFile/3d39b4/displaying-data-on-view-from-controller/
            //https://www.c-sharpcorner.com/article/3-ways-to-return-the-data-from-controller-action-method-in-asp-net-core/
            if (id == 0)
            {
                return NotFound();
            }
            //we find the id of the anime and store it into our anime variable
            var anime = db.Animes.Find(id);

            //we access the name of the anime and store it into our "a" variable
            string a = anime.animename;
            //an extra step to just store the name of "a" into folderpath
            string folderpath = a;
            //The PhysicalFileProvider provides access to the physical file system
            var provider = new PhysicalFileProvider(Environment.WebRootPath);
            //we get the directory needed and combine it with folderpath
            var contents = provider.GetDirectoryContents(Path.Combine("animeimages", folderpath));
            //we order it by last modification
            var objFiles = contents.OrderBy(m => m.LastModified);

            //we instantiate a new ImageList of type List<String>
            ImageList = new List<string>();
            //we loop through and store the items into ImageList
            foreach (var item in objFiles.ToList())
            {
                ImageList.Add(item.Name);
            }
            //We do this to be able to access ImageList in our view (moreinfo.cshtml)
            ViewBag.ImageList = ImageList;

            return View(anime);
            //return View("MoreInfo");
        }
    }
}