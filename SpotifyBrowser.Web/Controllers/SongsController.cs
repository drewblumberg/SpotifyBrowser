using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SpotifyBrowser.Data;
using SpotifyBrowser.Models;

namespace SpotifyBrowser.Controllers
{
    public class SongsController : Controller
    {
        private readonly SpotifyBrowserContext _context;

        public SongsController(SpotifyBrowserContext context)
        {
            _context = context;
        }

        // GET: Songs
        public async Task<IActionResult> Index()
        {
            var spotifyBrowserContext = _context.Songs.Include(s => s.Artist);
            return View(await spotifyBrowserContext.ToListAsync());
        }
    }
}
