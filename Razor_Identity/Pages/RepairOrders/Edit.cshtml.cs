using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Razor_Identity.Data;
using Razor_Identity.Models;

namespace Razor_Identity.Pages.RepairOrders
{
    public class EditModel : PageModel
    {
        private readonly Razor_Identity.Data.ApplicationDbContext _context;

        public EditModel(Razor_Identity.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public RepairOrder RepairOrder { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RepairOrder = await _context.RepairOrders.FirstOrDefaultAsync(m => m.Id == id);

            if (RepairOrder == null)
            {
                return NotFound();
            }

            ViewData["PartID"] = new SelectList(_context.Parts, "Id", "Name");
            ViewData["Statussen"] = new SelectList(Enum.GetValues<Status>());
            ViewData["BeginDates"] = new SelectList(_context.RepairOrders, "Id", "BeginDate");
            ViewData["EndDates"] = new SelectList(_context.RepairOrders, "Id", "EndDate");
            ViewData["HoursWorked"] = new SelectList(_context.RepairOrders, "Id", "HoursWorked");

            /*
            ViewData["CustomerID"] = new SelectList(_context.Customers, "ID", "Name");
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "EmployeeID", "Name");
            */

            //~~~~~~  Maak dit logischer en kleiner  ~~~~~~
            if (RepairOrder.PartID1 != null)
            {
                var RepairOrderPartID1 = RepairOrder.PartID1;
                var PartID1 = (from p in _context.Parts where p.Id == RepairOrderPartID1 select p.Name).ToList();
                foreach (string str in PartID1)
                {
                    ViewData["PartID1"] = str;
                }
            }
            if (RepairOrder.PartID2 != null)
            {
                var RepairOrderPartID2 = RepairOrder.PartID2;
                var PartID2 = (from p in _context.Parts where p.Id == RepairOrderPartID2 select p.Name).ToList();
                foreach (string str in PartID2)
                {
                    ViewData["PartID2"] = str;
                }
            }
            if (RepairOrder.PartID3 != null)
            {
                var RepairOrderPartID3 = RepairOrder.PartID3;
                var PartID3 = (from p in _context.Parts where p.Id == RepairOrderPartID3 select p.Name).ToList();
                foreach (string str in PartID3)
                {
                    ViewData["PartID3"] = str;
                }
            }
            if (RepairOrder.PartID4 != null)
            {
                var RepairOrderPartID4 = RepairOrder.PartID4;
                var PartID4 = (from p in _context.Parts where p.Id == RepairOrderPartID4 select p.Name).ToList();
                foreach (string str in PartID4)
                {
                    ViewData["PartID4"] = str;
                }
            }
            if (RepairOrder.PartID5 != null)
            {
                var RepairOrderPartID5 = RepairOrder.PartID5;
                var PartID5 = (from p in _context.Parts where p.Id == RepairOrderPartID5 select p.Name).ToList();
                foreach (string str in PartID5)
                {
                    ViewData["PartID5"] = str;
                }
            }
            if (RepairOrder.PartID6 != null)
            {
                var RepairOrderPartID6 = RepairOrder.PartID6;
                var PartID6 = (from p in _context.Parts where p.Id == RepairOrderPartID6 select p.Name).ToList();
                foreach (string str in PartID6)
                {
                    ViewData["PartID6"] = str;
                }
            }
            if (RepairOrder.PartID7 != null)
            {
                var RepairOrderPartID7 = RepairOrder.PartID7;
                var PartID7 = (from p in _context.Parts where p.Id == RepairOrderPartID7 select p.Name).ToList();
                foreach (string str in PartID7)
                {
                    ViewData["PartID7"] = str;
                }
            }
            if (RepairOrder.PartID8 != null)
            {
                var RepairOrderPartID8 = RepairOrder.PartID8;
                var PartID8 = (from p in _context.Parts where p.Id == RepairOrderPartID8 select p.Name).ToList();
                foreach (string str in PartID8)
                {
                    ViewData["PartID8"] = str;
                }
            }

            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(RepairOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RepairOrderExists(RepairOrder.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RepairOrderExists(int id)
        {
            return _context.RepairOrders.Any(e => e.Id == id);
        }
    }
}
