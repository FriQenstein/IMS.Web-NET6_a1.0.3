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
using Microsoft.AspNetCore.Authorization;

namespace IMS.Web.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class InboundInvoicesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public InboundInvoicesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: InboundInvoices
        public async Task<IActionResult> Index()
        {
            var inboundInvoices = mapper.Map<List<InboundInvoiceVM>>(await _context.InboundInvoices.ToListAsync());
            return View(inboundInvoices);
        }

        // GET: InboundInvoices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inboundInvoice = await _context.InboundInvoices.FindAsync(id);
            if (inboundInvoice == null)
            {
                return NotFound();
            }

            var inboundInvoiceVM = mapper.Map<InboundInvoiceVM>(inboundInvoice);
            return View(inboundInvoiceVM);
        }

        // GET: InboundInvoices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InboundInvoices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(InboundInvoiceVM inboundInvoiceVM)
        {
            if (ModelState.IsValid)
            {
                var inboundInvoice = mapper.Map<InboundInvoice>(inboundInvoiceVM);
                _context.Add(inboundInvoice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(inboundInvoiceVM);
        }

        // GET: InboundInvoices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inboundInvoice = await _context.InboundInvoices.FindAsync(id);
            if (inboundInvoice == null)
            {
                return NotFound();
            }

            var inboundInvoiceVM = mapper.Map<InboundInvoiceVM>(inboundInvoice);
            return View(inboundInvoiceVM);
        }

        // POST: InboundInvoices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, InboundInvoiceVM inboundInvoiceVM)
        {
            if (id != inboundInvoiceVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var inboundInvoice = mapper.Map<InboundInvoice>(inboundInvoiceVM);
                    _context.Update(inboundInvoice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InboundInvoiceExists(inboundInvoiceVM.Id))
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
            return View(inboundInvoiceVM);
        }

        // GET: InboundInvoices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inboundInvoice = await _context.InboundInvoices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inboundInvoice == null)
            {
                return NotFound();
            }

            return View(inboundInvoice);
        }

        // POST: InboundInvoices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inboundInvoice = await _context.InboundInvoices.FindAsync(id);
            _context.InboundInvoices.Remove(inboundInvoice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InboundInvoiceExists(int id)
        {
            return _context.InboundInvoices.Any(e => e.Id == id);
        }
    }
}
