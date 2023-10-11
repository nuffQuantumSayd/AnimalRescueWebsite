using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AnimalRescueWebsite.Data;
using AnimalRescueWebsite.Models;

namespace AnimalRescueWebsite.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
              return _context.Dogs != null ? 
                          View(await _context.Dogs.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Dogs'  is null.");
        }

        private bool DogExists(int id)
        {
          return (_context.Dogs?.Any(e => e.DogId == id)).GetValueOrDefault();
        }
    }
}
