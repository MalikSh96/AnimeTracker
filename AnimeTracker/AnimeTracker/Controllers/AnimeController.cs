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
        [Route("Anime")]
        [Route("~/")]

        public IActionResult Index()
        {
            ViewBag.Anime = db.Animes.ToList();
            return View();
        }
    }
}