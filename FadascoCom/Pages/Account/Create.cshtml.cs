using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FadascoCom.Data;
using FadascoCom.Models;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using System.Collections.Immutable;
using Microsoft.AspNetCore.Razor.TagHelpers;


namespace FadascoCom.Pages.Account
{
    public class CreateModel : PageModel 
    {
        private readonly FadascoCom.Data.FadascoComContext _context;
        [BindProperty]
        public Users Users { get; set; }

        //[BindProperty]
        //public string Password2 { get; set; }

        //[BindProperty]
        //public string PasswordHash { get; set; }

        

    




        public CreateModel(FadascoCom.Data.FadascoComContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {   



            return Page();
        }




        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            Users.lastLogIn = DateTime.Now.Date;
            Users.sysDate = DateTime.Now.Date;


            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            Users.passwordHash = Users.hashPass(Users.passwordHash);
            _context.Users.Add(Users);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
