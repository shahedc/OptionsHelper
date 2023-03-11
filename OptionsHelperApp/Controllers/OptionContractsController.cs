using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OptionsHelperApp.Data;
using OptionsHelperApp.Models;

namespace OptionsHelperApp.Controllers
{
    public class OptionContractsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OptionContractsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: OptionContracts
        public async Task<IActionResult> Index()
        {
              return _context.OptionContracts != null ? 
                          View(await _context.OptionContracts.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.OptionContracts'  is null.");
        }

        // GET: OptionContracts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.OptionContracts == null)
            {
                return NotFound();
            }

            var optionContract = await _context.OptionContracts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (optionContract == null)
            {
                return NotFound();
            }

            return View(optionContract);
        }

        // GET: OptionContracts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OptionContracts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ContractInfo,Symbol,Quantity,AccountOwner,OptionType,OpenAmount,DateOpened,ClosedAmount,ExpirationDate,ClosingDate,ProfitLoss,ProfitPercentage,DaysToExpiration,Assigned,StrikePrice")] OptionContract optionContract)
        {
            if (ModelState.IsValid)
            {
                _context.Add(optionContract);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(optionContract);
        }

        // GET: OptionContracts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.OptionContracts == null)
            {
                return NotFound();
            }

            var optionContract = await _context.OptionContracts.FindAsync(id);
            if (optionContract == null)
            {
                return NotFound();
            }
            return View(optionContract);
        }

        // POST: OptionContracts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ContractInfo,Symbol,Quantity,AccountOwner,OptionType,OpenAmount,DateOpened,ClosedAmount,ExpirationDate,ClosingDate,ProfitLoss,ProfitPercentage,DaysToExpiration,Assigned,StrikePrice")] OptionContract optionContract)
        {
            if (id != optionContract.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(optionContract);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OptionContractExists(optionContract.Id))
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
            return View(optionContract);
        }

        // GET: OptionContracts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.OptionContracts == null)
            {
                return NotFound();
            }

            var optionContract = await _context.OptionContracts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (optionContract == null)
            {
                return NotFound();
            }

            return View(optionContract);
        }

        // POST: OptionContracts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.OptionContracts == null)
            {
                return Problem("Entity set 'ApplicationDbContext.OptionContracts'  is null.");
            }
            var optionContract = await _context.OptionContracts.FindAsync(id);
            if (optionContract != null)
            {
                _context.OptionContracts.Remove(optionContract);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OptionContractExists(int id)
        {
          return (_context.OptionContracts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
