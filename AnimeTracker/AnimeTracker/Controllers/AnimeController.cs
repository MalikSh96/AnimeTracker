using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnimeTracker.Models;
using PagedList.Core;

namespace AnimeTracker.Controllers
{
    [Route("Anime")]
    public class AnimeController : Controller
    {
        private DataContext db = new DataContext();

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
        public IActionResult AddAnime(Anime anime)
        {
            db.Animes.Add(anime);
            db.SaveChanges();
            return RedirectToAction("Index");
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