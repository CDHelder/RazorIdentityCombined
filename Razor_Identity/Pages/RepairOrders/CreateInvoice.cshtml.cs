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

            //~~~~~~~~ Get value van naam ~~~~~~~~
            if (RepairOrder.PartID1 != null)
            {
                var RepairOrderPartID1 = RepairOrder.PartID1;
                var PartID1 = (from p in _context.Parts where p.Id == RepairOrderPartID1 select p.Name).ToList();
                var PartID1Price = (from p in _context.Parts where p.Id == RepairOrderPartID1 select p.Price).ToList();
                foreach (string str in PartID1)
                {
                    ViewData["PartID1"] = str;
                }
                foreach (var str in PartID1Price)
                {
                    ViewData["PartID1Price"] = str;
                }
            }
            if (RepairOrder.PartID2 != null)
            {
                var RepairOrderPartID2 = RepairOrder.PartID2;
                var PartID2 = (from p in _context.Parts where p.Id == RepairOrderPartID2 select p.Name).ToList();
                var PartID2Price = (from p in _context.Parts where p.Id == RepairOrderPartID2 select p.Price).ToList();
                foreach (string str in PartID2)
                {
                    ViewData["PartID2"] = str;
                }
                foreach (var str in PartID2Price)
                {
                    ViewData["PartID2Price"] = str;
                }
            }
            if (RepairOrder.PartID3 != null)
            {
                var RepairOrderPartID3 = RepairOrder.PartID3;
                var PartID3 = (from p in _context.Parts where p.Id == RepairOrderPartID3 select p.Name).ToList();
                var PartID3Price = (from p in _context.Parts where p.Id == RepairOrderPartID3 select p.Price).ToList();
                foreach (string str in PartID3)
                {
                    ViewData["PartID3"] = str;
                }
                foreach (var str in PartID3Price)
                {
                    ViewData["PartID3Price"] = str;
                }
            }
            if (RepairOrder.PartID4 != null)
            {
                var RepairOrderPartID4 = RepairOrder.PartID4;
                var PartID4 = (from p in _context.Parts where p.Id == RepairOrderPartID4 select p.Name).ToList();
                var PartID4Price = (from p in _context.Parts where p.Id == RepairOrderPartID4 select p.Price).ToList();
                foreach (string str in PartID4)
                {
                    ViewData["PartID4"] = str;
                }
                foreach (var str in PartID4Price)
                {
                    ViewData["PartID4Price"] = str;
                }
            }
            if (RepairOrder.PartID5 != null)
            {
                var RepairOrderPartID5 = RepairOrder.PartID5;
                var PartID5 = (from p in _context.Parts where p.Id == RepairOrderPartID5 select p.Name).ToList();
                var PartID5Price = (from p in _context.Parts where p.Id == RepairOrderPartID5 select p.Price).ToList();
                foreach (string str in PartID5)
                {
                    ViewData["PartID5"] = str;
                }
                foreach (var str in PartID5Price)
                {
                    ViewData["PartID5Price"] = str;
                }
            }
            if (RepairOrder.PartID6 != null)
            {
                var RepairOrderPartID6 = RepairOrder.PartID6;
                var PartID6 = (from p in _context.Parts where p.Id == RepairOrderPartID6 select p.Name).ToList();
                var PartID6Price = (from p in _context.Parts where p.Id == RepairOrderPartID6 select p.Price).ToList();
                foreach (string str in PartID6)
                {
                    ViewData["PartID6"] = str;
                }
                foreach (var str in PartID6Price)
                {
                    ViewData["PartID6Price"] = str;
                }
            }
            if (RepairOrder.PartID7 != null)
            {
                var RepairOrderPartID7 = RepairOrder.PartID7;
                var PartID7 = (from p in _context.Parts where p.Id == RepairOrderPartID7 select p.Name).ToList();
                var PartID7Price = (from p in _context.Parts where p.Id == RepairOrderPartID7 select p.Price).ToList();
                foreach (string str in PartID7)
                {
                    ViewData["PartID7"] = str;
                }
                foreach (var str in PartID7Price)
                {
                    ViewData["PartID7Price"] = str;
                }
            }
            if (RepairOrder.PartID8 != null)
            {
                var RepairOrderPartID8 = RepairOrder.PartID8;
                var PartID8 = (from p in _context.Parts where p.Id == RepairOrderPartID8 select p.Name).ToList();
                var PartID8Price = (from p in _context.Parts where p.Id == RepairOrderPartID8 select p.Price).ToList();
                foreach (string str in PartID8)
                {
                    ViewData["PartID8"] = str;
                }
                foreach (var str in PartID8Price)
                {
                    ViewData["PartID8Price"] = str;
                }
            }

            return Page();
        }
    }
}
