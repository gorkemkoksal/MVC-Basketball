using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BasketballMVC.Data;
using BasketballMVC.Models;

namespace BasketballMVC.Controllers
{
    public class RaptorsController : Controller
    {
        private readonly BasketballMVCContext _context;

        public RaptorsController(BasketballMVCContext context)
        {
            _context = context;
        }

        // GET: Raptors
        public async Task<IActionResult> Index()
        {
              return _context.Raptors != null ? 
                          View(await _context.Raptors.ToListAsync()) :
                          Problem("Entity set 'BasketballMVCContext.Raptors'  is null.");
        }

        // GET: Raptors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Raptors == null)
            {
                return NotFound();
            }

            var raptors = await _context.Raptors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (raptors == null)
            {
                return NotFound();
            }

            return View(raptors);
        }

        // GET: Raptors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Raptors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PlayerNum,PlayerName,PlayerPosition,PlayerSalary")] Raptors raptors)
        {
            if (ModelState.IsValid)
            {
                _context.Add(raptors);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(raptors);
        }

        // GET: Raptors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Raptors == null)
            {
                return NotFound();
            }

            var raptors = await _context.Raptors.FindAsync(id);
            if (raptors == null)
            {
                return NotFound();
            }
            return View(raptors);
        }

        // POST: Raptors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PlayerNum,PlayerName,PlayerPosition,PlayerSalary")] Raptors raptors)
        {
            if (id != raptors.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(raptors);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RaptorsExists(raptors.Id))
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
            return View(raptors);
        }

        // GET: Raptors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Raptors == null)
            {
                return NotFound();
            }

            var raptors = await _context.Raptors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (raptors == null)
            {
                return NotFound();
            }

            return View(raptors);
        }

        // POST: Raptors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Raptors == null)
            {
                return Problem("Entity set 'BasketballMVCContext.Raptors'  is null.");
            }
            var raptors = await _context.Raptors.FindAsync(id);
            if (raptors != null)
            {
                _context.Raptors.Remove(raptors);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RaptorsExists(int id)
        {
          return (_context.Raptors?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
