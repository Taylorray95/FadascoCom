using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FadascoCom.Models;

namespace FadascoCom.Data
{
    public class FadascoComContext : DbContext
    {
      

        public FadascoComContext (DbContextOptions<FadascoComContext> options)
            : base(options)
        {
            
            
        }

        public DbSet<FadascoCom.Models.Users> Users { get; set; } = default!;


        
    }
}
