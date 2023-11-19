using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AnimalRescueWebsite.Data;
using AnimalRescueWebsite.Models;
using Microsoft.AspNetCore.Authorization;

namespace AnimalRescueWebsite.Controllers
{

    public class DogApplicationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DogApplicationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DogApplications
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Index()
        {
            return _context.Applicants != null ?
                        View(await _context.Applicants.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Applicants'  is null.");
        }

        // GET: DogApplications/Details/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Applicants == null)
            {
                return NotFound();
            }

            var applicant = await _context.Applicants
                .FirstOrDefaultAsync(m => m.ApplicantId == id);
            if (applicant == null)
            {
                return NotFound();
            }

            return View(applicant);
        }

        // GET: DogApplications/Create
        [Authorize(Roles = "WebUser")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: DogApplications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles ="WebUser")]
        public async Task<IActionResult> Create(int id, Applicant applicant)
        {
            applicant.dog = id;

            if (ModelState.IsValid)
            {
                _context.Add(applicant);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Users");
            }
            return View(applicant);
        }

        // GET: DogApplications/Edit/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Applicants == null)
            {
                return NotFound();
            }

            var applicant = await _context.Applicants.FindAsync(id);
            if (applicant == null)
            {
                return NotFound();
            }
            return View(applicant);
        }

        // POST: DogApplications/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles ="Administrator")]
        public async Task<IActionResult> Edit(int id, [Bind("ApplicantId,ApplicantFirstName,ApplicantLastName,DateOfApplication,AddressStreet,AddressCity,AddressState,AddressZip,ApplicantEmail,ApplicantPhone,ApplicantOccupation,NumberOfChildren")] Applicant applicant)
        {
            if (id != applicant.ApplicantId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(applicant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicantExists(applicant.ApplicantId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(applicant);
        }

        // GET: DogApplications/Delete/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Applicants == null)
            {
                return NotFound();
            }

            var applicant = await _context.Applicants
                .FirstOrDefaultAsync(m => m.ApplicantId == id);
            if (applicant == null)
            {
                return NotFound();
            }

            return View(applicant);
        }

        // POST: DogApplications/Delete/5
        [Authorize(Roles = "Administrator")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Applicants == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Applicants'  is null.");
            }
            var applicant = await _context.Applicants.FindAsync(id);
            if (applicant != null)
            {
                _context.Applicants.Remove(applicant);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApplicantExists(int id)
        {
          return (_context.Applicants?.Any(e => e.ApplicantId == id)).GetValueOrDefault();
        }
    }
}
