using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Digiturno.web.Data;
using Digiturno.web.Data.Entities;

namespace Digiturno.web.Controllers
{
    public class AffiliateController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AffiliateController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Affiliate
        public async Task<IActionResult> Index()
        {
            return View(await _context.Afiliados.ToListAsync());
        }

        // GET: Affiliate/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliate = await _context.Afiliados
                .FirstOrDefaultAsync(m => m.id == id);
            if (affiliate == null)
            {
                return NotFound();
            }

            return View(affiliate);
        }

        // GET: Affiliate/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Affiliate/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,direccion,Nombre,Documento,Telefono")] Affiliate affiliate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(affiliate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(affiliate);
        }

        // GET: Affiliate/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliate = await _context.Afiliados.FindAsync(id);
            if (affiliate == null)
            {
                return NotFound();
            }
            return View(affiliate);
        }

        // POST: Affiliate/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,direccion,Nombre,Documento,Telefono")] Affiliate affiliate)
        {
            if (id != affiliate.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(affiliate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AffiliateExists(affiliate.id))
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
            return View(affiliate);
        }

        // GET: Affiliate/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliate = await _context.Afiliados
                .FirstOrDefaultAsync(m => m.id == id);
            if (affiliate == null)
            {
                return NotFound();
            }

            return View(affiliate);
        }

        // POST: Affiliate/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var affiliate = await _context.Afiliados.FindAsync(id);
            if (affiliate != null)
            {
                _context.Afiliados.Remove(affiliate);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AffiliateExists(int id)
        {
            return _context.Afiliados.Any(e => e.id == id);
        }
    }
}
