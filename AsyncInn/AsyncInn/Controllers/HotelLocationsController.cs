using AsyncInn.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using AsyncInn.Models;


namespace AsyncInn.Controllers
{
    public class HotelLocationsController : Controller
    {
        private readonly AsyncInnDbContext _context;

        public HotelLocationsController(AsyncInnDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index ()
        {
            return View(await _context.HotelLocations.ToListAsync());
        }
        
        public async Task<IActionResult> Details (int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            HotelLocation location = await _context.HotelLocations.Where(hl => hl.ID == id).FirstOrDefaultAsync();

            if (location == null)
            {
                return NotFound();
            }

            return View(location);
        }
        
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            HotelLocation location = await _context.HotelLocations.Where(hl => hl.ID == id).FirstOrDefaultAsync();

            if (location == null)
            {
                return NotFound();
            }

            return View(location);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            HotelLocation location = await _context.HotelLocations.Where(hl => hl.ID == id).FirstOrDefaultAsync();

            if (location == null)
            {
                return NotFound();
            }

            return View(location);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("ID, Name, Address, Phone")] HotelLocation location) 
        {
            if (id == null || id != location.ID)
            {
                return NotFound();
            }

            if (!ModelState.IsValid) {
                return View(location);
            }

            try
            {
                 _context.Add(location);
                await _context.SaveChangesAsync();

            } catch (DbUpdateConcurrencyException)
            {
                if (_context.HotelLocations.FirstOrDefault(hl => hl.ID == id) == null)
                {
                    return NotFound();
                } else
                {
                    throw;
                }
            }

            return RedirectToAction("Index");
        }
    }
}
