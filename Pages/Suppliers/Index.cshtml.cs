using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EverCleanDbSystem.Data;
using EverCleanDbSystem.Models;

namespace EverCleanDbSystem.Pages.Suppliers
{
    public class IndexModel : PageModel
    {
        private readonly EverCleanDbSystem.Data.EverCleanDbSystemContext _context;

        public IndexModel(EverCleanDbSystem.Data.EverCleanDbSystemContext context)
        {
            _context = context;
        }

        public string CurrentFilter { get; set; }
        public IList<Supplier> Supplier { get;set; } = default!;


        public async Task OnGetAsync(string searchString)
        {
            CurrentFilter= searchString;
            IQueryable<Supplier> suppliersIQ = from s in _context.Supplier
                                             select s;
            if (!String.IsNullOrEmpty(searchString))
            {
               suppliersIQ = suppliersIQ.Where(s => s.Name.Contains(searchString));
            }
            Supplier = await suppliersIQ.ToListAsync();

        }
    }
}
