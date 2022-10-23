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
    public class DetailsModel : PageModel
    {
        private readonly FadascoCom.Data.FadascoComContext _context;

        public DetailsModel(FadascoCom.Data.FadascoComContext context)
        {
            _context = context;
        }

      public Users Users { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var users = await _context.Users.FirstOrDefaultAsync(m => m.userId == id);
            if (users == null)
            {
                return NotFound();
            }
            else 
            {
                Users = users;
            }
            return Page();
        }
    }
}
