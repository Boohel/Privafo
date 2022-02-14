using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Privafo.Models;

namespace Privafo.DataAccess
{
    public class ApplicationDbContext : DbContext
    { 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ModuleCtg> module_ctg { get; set; }
        public DbSet<Module> modules { get; set; }
        public DbSet<Menu> menus { get; set; }
    }
}
