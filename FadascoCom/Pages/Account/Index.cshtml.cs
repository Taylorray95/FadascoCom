using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FadascoCom.Data;
using FadascoCom.Models;

namespace FadascoCom.Pages.Account
{
    public class IndexModel : PageModel
    {
        private readonly FadascoCom.Data.FadascoComContext _context;

        public IndexModel(FadascoCom.Data.FadascoComContext context)
        {
            _context = context;
        }

        public IList<Users> Users { get;set; } = default!;

        public async Task OnGetAsync()

        {
            if (_context.Users != null)
            {
                Users = await _context.Users.ToListAsync();
            }
        }
    }
}
