using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebLabNew.Data;
using WebLabNew.Entities;

namespace WebLabNew.Areas.Admin.Pages
{
    public class IndexModel : PageModel
    {
        private readonly WebLabNew.Data.ApplicationDbContext _context;

        public IndexModel(WebLabNew.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Dish> Dish { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Dishes != null)
            {
                Dish = await _context.Dishes
                .Include(d => d.Group).ToListAsync();
            }
        }
    }
}
