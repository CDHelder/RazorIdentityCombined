using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Razor_Identity.Data;
using Razor_Identity.Models;

namespace Razor_Identity.Pages.RepairOrders
{
    public class CreateModel : PageModel
    {
        private readonly Razor_Identity.Data.ApplicationDbContext _context;

        public CreateModel(Razor_Identity.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {

            ViewData["PartID"] = new SelectList(_context.Parts, "Id", "Name");
            ViewData["Statussen"] = new SelectList(Enum.GetValues<Status>());
            ViewData["BeginDates"] = new SelectList(_context.RepairOrders, "Id", "BeginDate");
            ViewData["EndDates"] = new SelectList(_context.RepairOrders, "Id", "EndDate");
            ViewData["HoursWorked"] = new SelectList(_context.RepairOrders, "Id", "HoursWorked");

            return Page();
        }

        [BindProperty]
        public RepairOrder RepairOrder { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.RepairOrders.Add(RepairOrder);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
