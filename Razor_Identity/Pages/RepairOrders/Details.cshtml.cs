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
    public class DetailsModel : PageModel
    {
        private readonly Razor_Identity.Data.ApplicationDbContext _context;

        public DetailsModel(Razor_Identity.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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

            //Maak dit logischer en kleiner
            var RepairOrderPartID1 = RepairOrder.PartID1;
            var PartID1 = (from p in _context.Parts where p.Id == RepairOrderPartID1 select p.Name).ToList();
            
            foreach (string str in PartID1)
            {
                ViewData["PartID1"] = str;
            }
            //ViewData["PartID1"] = PartID1;

            return Page();
        }
    }
}
