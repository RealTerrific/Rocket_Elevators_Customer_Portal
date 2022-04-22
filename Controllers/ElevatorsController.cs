using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CustomerPortal.Models;

namespace CustomerPortal.Controllers
{
    public class ElevatorsController : Controller
    {
        private readonly CustomerPortalContext _context;

        public ElevatorsController(CustomerPortalContext context)
        {
            _context = context;
        }

        // GET: Elevators
        public async Task<IActionResult> Index()
        {
            return View(await _context.Elevator.ToListAsync());
        }

        // GET: Elevators/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var elevator = await _context.Elevator
                .FirstOrDefaultAsync(m => m.Id == id);
            if (elevator == null)
            {
                return NotFound();
            }

            return View(elevator);
        }

        // GET: Elevators/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Elevators/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SerialNumber,Model,BuildingType,Status,CommissionDate,LastInspectionDate,Certificate,Information,Notes,CreatedAt,UpdatedAt")] Elevator elevator)
        {
            if (ModelState.IsValid)
            {
                _context.Add(elevator);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(elevator);
        }

        // GET: Elevators/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var elevator = await _context.Elevator.FindAsync(id);
            if (elevator == null)
            {
                return NotFound();
            }
            return View(elevator);
        }

        // POST: Elevators/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SerialNumber,Model,BuildingType,Status,CommissionDate,LastInspectionDate,Certificate,Information,Notes,CreatedAt,UpdatedAt")] Elevator elevator)
        {
            if (id != elevator.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(elevator);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ElevatorExists(elevator.Id))
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
            return View(elevator);
        }

        // GET: Elevators/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var elevator = await _context.Elevator
                .FirstOrDefaultAsync(m => m.Id == id);
            if (elevator == null)
            {
                return NotFound();
            }

            return View(elevator);
        }

        // POST: Elevators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var elevator = await _context.Elevator.FindAsync(id);
            _context.Elevator.Remove(elevator);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ElevatorExists(int id)
        {
            return _context.Elevator.Any(e => e.Id == id);
        }
    }
}
