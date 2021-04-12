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

        [HttpGet]
        [Route("moreinfo/{id}")]
        public IActionResult MoreInfo(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var anime = db.Animes.Find(id);
            return View(anime);
            //return View("MoreInfo");
        }

        /*[HttpGet]
        [Route("moreinfo/{anime_id}")]
        public IActionResult MoreInfo(int anime_id)
        {
            var data = ViewBag.Anime;
            var name = "";
            var description = "";
            var episodes = 0;
            var genre = "";
            var studio = "";
            var source_material = "";
            var rating_pg = "";
            var release = "";


            foreach (var anime in data)
            {
                if (anime.anime_id == 1)
                {
                    name = anime.animename;
                    description = anime.description;
                    episodes = anime.episodes;
                    genre = anime.genre;
                    studio = anime.studio;
                    source_material = anime.anime_source;
                    rating_pg = anime.rating_pg;
                    release = anime.release_date;

                }
                return anime;
            }
            return View("MoreInfo");
        }*/
    }
}