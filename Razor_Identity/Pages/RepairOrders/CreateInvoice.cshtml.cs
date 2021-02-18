using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_Identity.Data;
using Razor_Identity.Models;

namespace RepairShop_Razor.Pages.RepairOrders
{
    public class CreateInvoice : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateInvoice(ApplicationDbContext context)
        {
            _context = context;
        }

        public RepairOrder RepairOrder { get; set; }
        public Part Part { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            /*
             * De data verwijzing naar de Parts kan door de one to many relatie tussen part, partlist en repairorder kan niet
             * Deze moet volgensm mij via een nieuwe variabele Die ene part part op regel 23 en part = await _contet op regel 38
             */
            RepairOrder = await _context.RepairOrders.FirstOrDefaultAsync(m => m.Id == id);

            Part = await _context.Parts.FirstOrDefaultAsync(m => m.Id == id);

            if (RepairOrder == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
