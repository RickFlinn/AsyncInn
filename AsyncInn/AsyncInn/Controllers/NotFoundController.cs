using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsyncInn.Data;
using AsyncInn.Models;
using Microsoft.AspNetCore.Mvc;

namespace AsyncInn.Controllers
{
    public class NotFoundController : Controller
    {
        private readonly AsyncInnDbContext _context;

        public NotFoundController(AsyncInnDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult Index(string origin)
        {
            return View(new NotFoundOrigin(origin));
        }


    }
}
