using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace webapi.Controllers
{
    public class WbsController : Controller
    {
        private readonly wbContext _context;

        public WbsController(wbContext context)
        {
            _context = context;
        }

        // GET: Wbs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Wb.ToListAsync());
        }

        // GET: Wbs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wb = await _context.Wb
                .FirstOrDefaultAsync(m => m.Seq == id);
            if (wb == null)
            {
                return NotFound();
            }

            return View(wb);
        }

        // GET: Wbs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Wbs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Seq,Id,Name,Kana,Ip,Status,Place,Back,StartDay,StartTime,EndDay,Ok,EndTime,Phone,Mail1,Mail2,Memo1,Memo2,Memo3,Memo4,Memo5,Message,UpdateDay,UpdateTime,FullName,Business,UpdateIp,InterPhone")] Wb wb)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wb);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wb);
        }

        // GET: Wbs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wb = await _context.Wb.FindAsync(id);
            if (wb == null)
            {
                return NotFound();
            }
            return View(wb);
        }

        // POST: Wbs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Seq,Id,Name,Kana,Ip,Status,Place,Back,StartDay,StartTime,EndDay,Ok,EndTime,Phone,Mail1,Mail2,Memo1,Memo2,Memo3,Memo4,Memo5,Message,UpdateDay,UpdateTime,FullName,Business,UpdateIp,InterPhone")] Wb wb)
        {
            if (id != wb.Seq)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wb);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WbExists(wb.Seq))
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
            return View(wb);
        }

        // GET: Wbs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wb = await _context.Wb
                .FirstOrDefaultAsync(m => m.Seq == id);
            if (wb == null)
            {
                return NotFound();
            }

            return View(wb);
        }

        // POST: Wbs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var wb = await _context.Wb.FindAsync(id);
            _context.Wb.Remove(wb);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WbExists(string id)
        {
            return _context.Wb.Any(e => e.Seq == id);
        }
    }
}
