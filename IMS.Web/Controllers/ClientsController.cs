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
using IMS.Web.Constants;

namespace IMS.Web.Controllers
{
    [Authorize(Roles = "Administrator, User")]
    public class ClientsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public ClientsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: Clients
        public async Task<IActionResult> Index()
        {
            var clients = mapper.Map<List<ClientDisplayVM>>(await _context.Clients.ToListAsync());
            return View(clients);
        }

        // GET: Clients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Clients.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }

            var clientVM = mapper.Map<ClientVM>(client);
            return View(clientVM);
        }


        //ClientList
        public async Task<IActionResult> ClientList(int? id)
        {
            var clients = mapper.Map<List<ClientDisplayVM>>(await _context.Clients.ToListAsync());
            return View(clients);
        }

        // GET: Clients/Create
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Create(ClientVM clientVM)
        {
            if (ModelState.IsValid)
            {
                var client = mapper.Map<Client>(clientVM);
                _context.Add(client);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clientVM);
        }

        // GET: Clients/Edit/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Clients.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }

            var clientVM = mapper.Map<ClientVM>(client);
            return View(clientVM);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int id, ClientVM clientVM)
        {
            if (id != clientVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try                    
                {
                    var client = mapper.Map<Client>(clientVM);
                    _context.Update(client);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientExists(clientVM.Id))
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
            return View(clientVM);
        }

        // GET: Clients/Delete/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Clients
                .FirstOrDefaultAsync(m => m.Id == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientExists(int id)
        {
            return _context.Clients.Any(e => e.Id == id);
        }

        // ***** COMPANY SECTION ***** //
        public async Task<IActionResult> Index_SEISGEAR(int? id)
        {
            var client1 = "Seis Gear";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_PGS(int? id)
        {
            var client1 = "PGS";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_BGP(int? id)
        {
            var client1 = "BGP";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_LDEO(int? id)
        {
            var client1 = "LDEO";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_AXXIS(int? id)
        {
            var client1 = "LDEO";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_CSI(int? id)
        {
            var client1 = "CSI";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_D2C(int? id)
        {
            var client1 = "D2C";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_ECHO(int? id)
        {
            var client1 = "ECHO";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_FAIRFIELD(int? id)
        {
            var client1 = "FAIRFIELD";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_GEODETICSURVEYS(int? id)
        {
            var client1 = "GEODETICSURVEYS";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_GEOMAGNA(int? id)
        {
            var client1 = "GEOMAGNA";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_GEOPARTNERGEOFYZIK(int? id)
        {
            var client1 = "GEOPARTNERGEOFYZIK";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_GMWELD(int? id)
        {
            var client1 = "GMWELD";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_HONGKONGSINO(int? id)
        {
            var client1 = "HONGKONGSINO";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_IONGEO(int? id)
        {
            var client1 = "IONGEO";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_IXBLUE(int? id)
        {
            var client1 = "IXBLUE";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_KRAMAR(int? id)
        {
            var client1 = "KRAMAR";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_MAGE(int? id)
        {
            var client1 = "MAGE";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_MAGSEIS(int? id)
        {
            var client1 = "MAGSEIS";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_MARITIM(int? id)
        {
            var client1 = "MARITIM";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_MITCHAM(int? id)
        {
            var client1 = "MITCHAM";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_NCS(int? id)
        {
            var client1 = "NCS";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_OGF(int? id)
        {
            var client1 = "OGF";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_POLARCUS(int? id)
        {
            var client1 = "POLARCUS";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_PXGEO(int? id)
        {
            var client1 = "PXGEO";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_REM(int? id)
        {
            var client1 = "REM";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_SAE(int? id)
        {
            var client1 = "SAE";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_SALT(int? id)
        {
            var client1 = "SALT";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_SANCOSPIRIT(int? id)
        {
            var client1 = "SANCOSPIRIT";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_SAP(int? id)
        {
            var client1 = "SAP";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_SCF(int? id)
        {
            var client1 = "SCF";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_SEABIRD(int? id)
        {
            var client1 = "SEABIRD";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_SEAMAP(int? id)
        {
            var client1 = "SEAMAP";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }

        public async Task<IActionResult> Index_SEISGADGET(int? id)
        {
            var client1 = "SEISGADGET";
            var itemQuery = mapper.Map<List<InventoryItemVM>>(await _context.InventoryItems
                .Where(p => p.clientName == client1)
                .OrderBy(p => p.serialNumber)
                .ToListAsync());

            return View(itemQuery);
        }
    }
}
