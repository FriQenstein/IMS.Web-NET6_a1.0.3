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
    [Authorize(Roles = "Administrator, User")]
    public class InventoryItemsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public InventoryItemsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: InventoryItems
        public async Task<IActionResult> Index()
        {
            var shipped = "Shipped";
            var inventoryItems = mapper.Map<List<InventoryItemDisplayVM>>(await _context.InventoryItems
                                        .Where(q => q.itemQty > 0
                                        && q.itemStatus != shipped)
                                        .ToListAsync());
            return View(inventoryItems);
        }

        // GET: InventoryItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventoryItem = await _context.InventoryItems.FindAsync(id);
            if (inventoryItem == null)
            {
                return NotFound();
            }

            var inventoryItemVM = mapper.Map<InventoryItemVM>(inventoryItem);
            return View(inventoryItemVM);
        }

        // GET: InventoryItems/Create
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: InventoryItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Create(InventoryItemVM inventoryItemVM)
        {
            if (ModelState.IsValid)
            {
                var inventoryItem = mapper.Map<InventoryItem>(inventoryItemVM);
                _context.Add(inventoryItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(inventoryItemVM);
        }

        // GET: InventoryItems/Edit/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventoryItem = await _context.InventoryItems.FindAsync(id);
            if (inventoryItem == null)
            {
                return NotFound();
            }

            var inventoryItemVM = mapper.Map<InventoryItemVM>(inventoryItem);
            return View(inventoryItemVM);
        }

        // POST: InventoryItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int id, InventoryItemVM inventoryItemVM)
        {
            if (id != inventoryItemVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var inventoryItem = mapper.Map<InventoryItem>(inventoryItemVM);
                    _context.Update(inventoryItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventoryItemExists(inventoryItemVM.Id))
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
            return View(inventoryItemVM);
        }

        // GET: InventoryItems/Delete/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventoryItem = await _context.InventoryItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inventoryItem == null)
            {
                return NotFound();
            }

            return View(inventoryItem);
        }

        // POST: InventoryItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inventoryItem = await _context.InventoryItems.FindAsync(id);
            _context.InventoryItems.Remove(inventoryItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InventoryItemExists(int id)
        {
            return _context.InventoryItems.Any(e => e.Id == id);
        }

        public async Task<IActionResult> Q_full_PGS()
        {
            var client1 = "PGS";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Q_PGS_DIGIBIRD1()
        {
            var companyName = "PGS";
            var assetModel = "5011-1";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == companyName
                        && p.itemModel == assetModel)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Q_PGS_DB2()
        {
            var companyName = "PGS";
            var assetStatus = "TBR";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == companyName
                        && p.itemStatus == assetStatus)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }
    }
}
