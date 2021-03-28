using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnimeTracker.Models;

namespace AnimeTracker.Controllers
{
    [Route("Anime")]
    public class AnimeController : Controller
    {
        private DataContext db = new DataContext();

        [Route("")]
        [Route("anime")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.Anime = db.Animes.ToList();
            return View();
        }

        [HttpGet]
        [Route("getall")]
        public IActionResult AllAnime()
        {
            ViewBag.Anime = db.Animes.ToList();
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
    }
}