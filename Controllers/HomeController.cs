using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SerialKeyGenerate.Models;
using System.Diagnostics;

namespace SerialKeyGenerate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var entries = _context.CustomerActiveDetails.ToList();
            return View(entries);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Entry()
        {
            var entries = _context.CustomerActiveDetails.ToList();
            return View(entries);
        }
        public IActionResult CreateNewCustomer()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateNewCustomer(CustomerActiveDetails model)
        {
            if (ModelState.IsValid)
            {
                // Save the new customer to the database
                _context.CustomerActiveDetails.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Entry");
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> CustomerDetailsEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entry = await _context.CustomerActiveDetails.FindAsync(id);
            if (entry == null)
            {
                return NotFound();
            }
            return View(entry);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CustomerDetailsEdit(int id, [Bind("id,client_name,software_name,db_name,start_date,end_date,print_report,isactive")] CustomerActiveDetails entry)
        {
            if (id != entry.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(entry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntryExists(entry.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Entry));
            }
            return View(entry);
        }
        private bool EntryExists(int id)
        {
            return _context.CustomerActiveDetails.Any(e => e.id == id);
        }
    }
}