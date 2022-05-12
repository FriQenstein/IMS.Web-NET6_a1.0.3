#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IMS.Web.Data;
using AutoMapper;
using IMS.Web.Models;

namespace IMS.Web.Controllers
{
    public class OutboundInvoicesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public OutboundInvoicesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: OutboundInvoices
        public async Task<IActionResult> Index()
        {
            var outboundInvoices = mapper.Map<List<OutboundInvoiceVM>>(await _context.OutboundInvoices.ToListAsync());
            return View(outboundInvoices);
        }

        // GET: OutboundInvoices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outboundInvoice = await _context.OutboundInvoices.FindAsync(id);
            if (outboundInvoice == null)
            {
                return NotFound();
            }

            var outbountInvoiceVM = mapper.Map<OutboundInvoiceVM>(outboundInvoice);
            return View(outbountInvoiceVM);
        }

        // GET: OutboundInvoices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OutboundInvoices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(OutboundInvoiceVM outboundInvoiceVM)
        {
            if (ModelState.IsValid)
            {
                var outboundInvoice = mapper.Map<OutboundInvoice>(outboundInvoiceVM);
                _context.Add(outboundInvoice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(outboundInvoiceVM);
        }

        // GET: OutboundInvoices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outboundInvoice = await _context.OutboundInvoices.FindAsync(id);
            if (outboundInvoice == null)
            {
                return NotFound();
            }

            var outboundInvoiceVM = mapper.Map<OutboundInvoiceVM>(outboundInvoice);
            return View(outboundInvoiceVM);
        }

        // POST: OutboundInvoices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, OutboundInvoiceVM outboundInvoiceVM)
        {
            if (id != outboundInvoiceVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var outboundInvoice = mapper.Map<OutboundInvoice>(outboundInvoiceVM);
                    _context.Update(outboundInvoice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OutboundInvoiceExists(outboundInvoiceVM.Id))
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
            return View(outboundInvoiceVM);
        }

        // GET: OutboundInvoices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outboundInvoice = await _context.OutboundInvoices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (outboundInvoice == null)
            {
                return NotFound();
            }

            return View(outboundInvoice);
        }

        // POST: OutboundInvoices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var outboundInvoice = await _context.OutboundInvoices.FindAsync(id);
            _context.OutboundInvoices.Remove(outboundInvoice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OutboundInvoiceExists(int id)
        {
            return _context.OutboundInvoices.Any(e => e.Id == id);
        }
    }
}
