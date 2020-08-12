using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP_MVC.Models;

namespace ASP_MVC.Data
{
    public class ASP_MVCDbContext : DbContext
    {
        public ASP_MVCDbContext (DbContextOptions<ASP_MVCDbContext> options)
            : base(options)
        {
        }

        public DbSet<ASP_MVC.Models.ContactListEntry> ContactListEntry { get; set; }
    }
}
