using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AnimalRescueWebsite.Data;
using AnimalRescueWebsite.Models;
using AnimalRescueWebsite.Data.Migrations;

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
            //If there is a success message in the TempData, set the ViewBag to that message
            if (TempData["SuccessMessage"] != null)
            {
                ViewBag.SuccessMessage = TempData["SuccessMessage"];
            }

              return _context.Dogs != null ? 
                          View(await _context.Dogs.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Dogs'  is null.");
        }

        private bool DogExists(int id)
        {
          return (_context.Dogs?.Any(e => e.DogId == id)).GetValueOrDefault();
        }

        
        public async Task<IActionResult> DogDescriptions(int id)
        {
            //Models.DogDescriptions? dogDescriptions =  _context.DogDescriptions.Where(d => d.DogId == id).FirstOrDefault();
            AllDogInformation allDogInformation = new AllDogInformation
            {
                Dog = await _context.Dogs.FindAsync(id),
                DogDescriptions = _context.DogDescriptions.Where(d => d.DogId == id).FirstOrDefault()
            };
            
            if(allDogInformation == null)
            {
                return NotFound();
            }
            
            return View(allDogInformation);
        }
    }
}
