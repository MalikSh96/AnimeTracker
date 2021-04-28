﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AnimeTracker.Models;

namespace AnimeTracker.Controllers
{
    [Route("Users")]
    public class UsersController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Users
        //[Route("")]
        [Route("users")]
        //[Route("~/")]
        public IActionResult AllUsers()
        {
            ViewBag.User = db.User.ToList();
            return View();
        }

        //// GET: Users
        //[Route("users")]
        //public async Task<IActionResult> Index()
        //{
        //    ViewBag.User = await _context.User.ToListAsync();
        //    return View();
        //}

    //    // GET: Users/Details/5
    //    public async Task<IActionResult> Details(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var user = await _context.User
    //            .FirstOrDefaultAsync(m => m.user_id == id);
    //        if (user == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(user);
    //    }

    //    // GET: Users/Create
    //    public IActionResult Create()
    //    {
    //        return View();
    //    }

    //    // POST: Users/Create
    //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Create([Bind("user_id,username,email,firstname,lastname,admin,password,profilepic_path")] User user)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            _context.Add(user);
    //            await _context.SaveChangesAsync();
    //            return RedirectToAction(nameof(Index));
    //        }
    //        return View(user);
    //    }

    //    // GET: Users/Edit/5
    //    public async Task<IActionResult> Edit(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var user = await _context.User.FindAsync(id);
    //        if (user == null)
    //        {
    //            return NotFound();
    //        }
    //        return View(user);
    //    }

    //    // POST: Users/Edit/5
    //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Edit(int id, [Bind("user_id,username,email,firstname,lastname,admin,password,profilepic_path")] User user)
    //    {
    //        if (id != user.user_id)
    //        {
    //            return NotFound();
    //        }

    //        if (ModelState.IsValid)
    //        {
    //            try
    //            {
    //                _context.Update(user);
    //                await _context.SaveChangesAsync();
    //            }
    //            catch (DbUpdateConcurrencyException)
    //            {
    //                if (!UserExists(user.user_id))
    //                {
    //                    return NotFound();
    //                }
    //                else
    //                {
    //                    throw;
    //                }
    //            }
    //            return RedirectToAction(nameof(Index));
    //        }
    //        return View(user);
    //    }

    //    // GET: Users/Delete/5
    //    public async Task<IActionResult> Delete(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var user = await _context.User
    //            .FirstOrDefaultAsync(m => m.user_id == id);
    //        if (user == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(user);
    //    }

    //    // POST: Users/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> DeleteConfirmed(int id)
    //    {
    //        var user = await _context.User.FindAsync(id);
    //        _context.User.Remove(user);
    //        await _context.SaveChangesAsync();
    //        return RedirectToAction(nameof(Index));
    //    }

    //    private bool UserExists(int id)
    //    {
    //        return _context.User.Any(e => e.user_id == id);
    //    }
    }
}
