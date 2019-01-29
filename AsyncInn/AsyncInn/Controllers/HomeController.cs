using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Hotels()
        {
            return View();
        }

        public IActionResult Amenities()
        {
            return View();
        }

        public IActionResult Rooms()
        {
            return View();
        }

        
        public IActionResult AddARoom()
        {
            
            return View();
        }

        public IActionResult AddAmenities()
        {
            return View();
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
