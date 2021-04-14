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

namespace AnimeTracker.Controllers
{
    [Route("Anime")]
    public class AnimeController : Controller
    {
        private DataContext db = new DataContext();
        private IHostingEnvironment Environment;

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
            ViewBag.Anime = db.Animes.OrderBy(_ => _.animename).ToList();
            return View();
        }

        [HttpGet]
        [Route("getall")]
        public IActionResult AllAnime()
        {
            //ViewBag.Anime = db.Animes.ToList();
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
        public async Task<IActionResult> AddAnime(IFormFile file, Anime anime)
        {

            /*
             *Below code functions well, the code below posts the
              images relative path into the database, which makes it easier to use
              than the absolute path
             */
            string extension = Path.GetExtension(file.FileName);
            if (extension == ".jpg" || extension == ".gif" || extension == ".png")
            {
                var save = Path.Combine("wwwroot/animeimages/", file.FileName);
                var stream = new FileStream(save, FileMode.Create);
                await file.CopyToAsync(stream);
                //file.CopyTo(stream);
                anime.img_path = save;
                db.Animes.Add(anime);
                db.SaveChanges();
            }
            else
            {
                ViewData["Message"] = "An error occured";
            }
            //db.Animes.Add(anime);
            //db.SaveChanges();
            return RedirectToAction("Index");

            /*
             * The code below works for posting the path into the database
             * Issue is that it post the absolute path, which makes it harder to retrieve 
               an image on the website, as the domain link and the db path collides wrongly
             * 
            string extension = Path.GetExtension(file.FileName);
            string wwwPath = this.Environment.WebRootPath;
            if (extension == ".jpg" || extension == ".gif" || extension == ".png")
            {
                var save = Path.Combine(wwwPath, "animeimages", file.FileName);
                var stream = new FileStream(save, FileMode.Create);
                await file.CopyToAsync(stream);
                anime.img_path = save;
                db.Animes.Add(anime);
                db.SaveChanges();
            }
            else
            {
                ViewData["Message"] = "An error occured";
            }

            return RedirectToAction("Index"); 
             */
        }

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
            var anime = db.Animes.Find(id);
            return View(anime);
            //return View("MoreInfo");
        }
    }
}