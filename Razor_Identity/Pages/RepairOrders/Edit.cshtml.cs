﻿using System;
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

            ViewData["PartID"] = new SelectList(_context.Parts, "Id", "PartName");
            ViewData["Statussen"] = new SelectList(Enum.GetValues<Status>());
            ViewData["BeginDates"] = new SelectList(_context.RepairOrders, "Id", "BeginDate");
            ViewData["EndDates"] = new SelectList(_context.RepairOrders, "Id", "EndDate");
            ViewData["HoursWorked"] = new SelectList(_context.RepairOrders, "Id", "HoursWorked");

            /*
            ViewData["CustomerID"] = new SelectList(_context.Customers, "ID", "Name");
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "EmployeeID", "Name");
            */

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
