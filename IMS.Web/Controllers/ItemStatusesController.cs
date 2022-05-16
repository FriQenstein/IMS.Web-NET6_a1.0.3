#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IMS.Web.Data;
using IMS.Web.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace IMS.Web.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class ItemStatusesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public ItemStatusesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: ItemStatuses
        public async Task<IActionResult> Index()
        {
            var itemStatuses = mapper.Map<List<ItemStatusVM>>(await _context.ItemStatuses.ToListAsync());
            return View(itemStatuses);
        }

        // GET: ItemStatuses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemStatus = await _context.ItemStatuses.FindAsync(id);
            if (itemStatus == null)
            {
                return NotFound();
            }

            var itemStatusVM = mapper.Map<ItemStatusVM>(itemStatus);
            return View(itemStatusVM);
        }

        // GET: ItemStatuses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItemStatuses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ItemStatusVM itemStatusVM)
        {
            if (ModelState.IsValid)
            {
                var itemStatus = mapper.Map<ItemStatus>(itemStatusVM);
                _context.Add(itemStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itemStatusVM);
        }

        // GET: ItemStatuses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemStatus = await _context.ItemStatuses.FindAsync(id);
            if (itemStatus == null)
            {
                return NotFound();
            }

            var itemStatusVM = mapper.Map<ItemStatusVM>(itemStatus);
            return View(itemStatusVM);
        }

        // POST: ItemStatuses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ItemStatusVM itemStatusVM)
        {
            if (id != itemStatusVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var itemStatus = mapper.Map<ItemStatus>(itemStatusVM);
                    _context.Update(itemStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemStatusExists(itemStatusVM.Id))
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
            return View(itemStatusVM);
        }

        // GET: ItemStatuses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemStatus = await _context.ItemStatuses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itemStatus == null)
            {
                return NotFound();
            }

            return View(itemStatus);
        }

        // POST: ItemStatuses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itemStatus = await _context.ItemStatuses.FindAsync(id);
            _context.ItemStatuses.Remove(itemStatus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemStatusExists(int id)
        {
            return _context.ItemStatuses.Any(e => e.Id == id);
        }
    }
}
