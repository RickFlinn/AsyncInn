using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsyncInn.Data;
using Microsoft.EntityFrameworkCore;

namespace AsyncInn.Controllers
{
    public class HomeController : Controller
    {

        private readonly AsyncInnDbContext _context;

        public HomeController(AsyncInnDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        public async Task<IActionResult> Hotels()
        {

            return View(await _context.HotelLocations.ToListAsync());
        }

        public async Task<IActionResult> Amenities()
        {
            return View(await _context.Amenities.ToListAsync());
        }

        public async Task<IActionResult> Rooms()
        {
            return View(await _context.Rooms.ToListAsync());
        }

        
        public async Task<IActionResult> AssignRooms()
        {
            
            return View(new { HotelLocations = await _context.HotelLocations.ToListAsync(), Rooms = await _context.Rooms.ToListAsync() });
        }

        public async Task<IActionResult> AssignAmenities()
        {
            return View( new { Amenities = await _context.Amenities.ToListAsync(), Rooms = await _context.Amenities.ToListAsync() });
        }

        // 
        [HttpPost]
        public IActionResult Rooms(int roomID)
        {
            // query db for room and render to page
            return View();
        }
    }
}
