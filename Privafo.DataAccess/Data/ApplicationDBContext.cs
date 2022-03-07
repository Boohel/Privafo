using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Privafo.Models;

namespace Privafo.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    { 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>().ToTable("users");
            modelBuilder.Entity<ApplicationRole>().ToTable("roles");
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("user_token");
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("user_role");
            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("role_claim");
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("user_claim");
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("user_login");
        }

        public DbSet<ModuleCtg> module_ctg { get; set; }
        public DbSet<Module> modules { get; set; }
        public DbSet<Menu> menus { get; set; }
        public DbSet<ApplicationUser> users { get; set; }
        public DbSet<ApplicationRole> roles { get; set; }

        //Risk Management
        public DbSet<RiskLibrary> risk_library { get; set; }
        public DbSet<RiskRegister> risk_register { get; set; }
        public DbSet<RiskType> risk_type { get; set; }
        public DbSet<RiskImpact> risk_impact { get; set; }
        public DbSet<RiskProbability> risk_probability { get; set; }
        public DbSet<RiskMatrixScore> risk_matrix_score { get; set; }
        public DbSet<RiskRangeScore> risk_range_score { get; set; }
        public DbSet<RiskVulnerability> risk_vulneries { get; set; }
        public DbSet<RiskThreat> risk_threats { get; set; }
    }
}
