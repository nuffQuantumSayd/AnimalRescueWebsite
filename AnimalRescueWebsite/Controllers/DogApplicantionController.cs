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
    public class DogApplicantionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DogApplicantionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DogApplicantion
        public async Task<IActionResult> Index()
        {
              return _context.Applicants != null ? 
                          View(await _context.Applicants.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Applicants'  is null.");
        }

        // GET: DogApplicantion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Applicants == null)
            {
                return NotFound();
            }

            var applicant = await _context.Applicants
                .FirstOrDefaultAsync(m => m.ApplicationId == id);
            if (applicant == null)
            {
                return NotFound();
            }

            return View(applicant);
        }

        // GET: DogApplicantion/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DogApplicantion/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ApplicationId,ApplicantFirstName,ApplicantLastName,DateOfApplication,AddressStreet,AddressCity,AddressState,AddressZip,ApplicantEmail,ApplicantPhone,ApplicantOccupation,NumberOfChildren")] Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(applicant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(applicant);
        }

        // GET: DogApplicantion/Edit/5
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

        // POST: DogApplicantion/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ApplicationId,ApplicantFirstName,ApplicantLastName,DateOfApplication,AddressStreet,AddressCity,AddressState,AddressZip,ApplicantEmail,ApplicantPhone,ApplicantOccupation,NumberOfChildren")] Applicant applicant)
        {
            if (id != applicant.ApplicationId)
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
                    if (!ApplicantExists(applicant.ApplicationId))
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

        // GET: DogApplicantion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Applicants == null)
            {
                return NotFound();
            }

            var applicant = await _context.Applicants
                .FirstOrDefaultAsync(m => m.ApplicationId == id);
            if (applicant == null)
            {
                return NotFound();
            }

            return View(applicant);
        }

        // POST: DogApplicantion/Delete/5
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
          return (_context.Applicants?.Any(e => e.ApplicationId == id)).GetValueOrDefault();
        }
    }
}
