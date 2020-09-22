using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication_Domazet.Models;

namespace WebApplication_Domazet.Controllers
{
    public class VideoController : Controller
    {
        private readonly Kazeta _context;

        public VideoController(Kazeta context)
        {
            _context = context;
        }

        // GET: Video
        public async Task<IActionResult> Index()
        {
            return View(await _context.Videos.ToListAsync());
        }

        // GET: Video/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Video());
            else
                return View(_context.Videos.Find(id));
        }

        // POST: Video/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("VideoSifra,VideoNaziv,Ukupno,Zauzeto,Slobodno")] Video video)
        {
            if (ModelState.IsValid)
            {
                if (video.VideoSifra == 0)
                    _context.Add(video);
                else
                    _context.Update(video);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(video);
        }

        // GET: Video/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var video = await _context.Videos.FindAsync(id);
            _context.Videos.Remove(video);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VideoExists(int id)
        {
            return _context.Videos.Any(e => e.VideoSifra == id);
        }
    }
}

