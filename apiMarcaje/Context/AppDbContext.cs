using apiMarcaje.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiMarcaje.Context
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        
        
       }
        public DbSet<Marcaje> marcaje { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
        

}

