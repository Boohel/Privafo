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


        //Administrator
        public DbSet<ModuleCtg> module_ctg { get; set; }
        public DbSet<Module> modules { get; set; }
        public DbSet<Menu> menus { get; set; }
        public DbSet<ApplicationUser> users { get; set; }
        public DbSet<ApplicationRole> roles { get; set; }


        //Organization
        public DbSet<Org> organization { get; set; }
        public DbSet<Branch> branches { get; set; }
        public DbSet<Entity> entities { get; set; }


        //General Address
        public DbSet<Address> address { get; set; }
        public DbSet<Country> countries { get; set; }
        public DbSet<Province> provinces { get; set; }
        public DbSet<City> cities { get; set; }


        //General Data
        public DbSet<Industry> industries { get; set; }
        public DbSet<ActiveStatus> status { get; set; }


        //Risk Management
        public DbSet<RiskLibrary> risk_library { get; set; }
        public DbSet<RiskRegister> risk_register { get; set; }
        public DbSet<RiskType> risk_type { get; set; }
        public DbSet<RiskCtg> risk_ctg { get; set; }
        public DbSet<RiskRegCtg> risk_reg_ctg { get; set; }
        public DbSet<RiskImpact> risk_impact { get; set; }
        public DbSet<RiskProbability> risk_probability { get; set; }
        public DbSet<RiskMatrixScore> risk_matrix_score { get; set; }
        public DbSet<RiskRangeScore> risk_range_score { get; set; }
        public DbSet<RiskVulnerability> risk_vulneries { get; set; }
        public DbSet<RiskThreat> risk_threats { get; set; }
        public DbSet<RiskApprover> risk_approver { get; set; }
        public DbSet<RiskAsset> risk_asset { get; set; }
        public DbSet<RiskVendor> risk_vendor { get; set; }
        public DbSet<RiskProcess> risk_process { get; set; }


        //Asset
        public DbSet<Asset> assets { get; set; }
        public DbSet<AssetType> asset_type { get; set; }
        public DbSet<AssetStorageFormat> asset_storage_format { get; set; }
        public DbSet<AssetDisposal> asset_disposal { get; set; }


        //Vendor
        public DbSet<Vendor> vendors { get; set; }
        public DbSet<VendorLocation> vendor_location { get; set; }
        public DbSet<VendorEngage> vendor_engage { get; set; }
        public DbSet<VendorType> vendor_type { get; set; }
        public DbSet<VendorProduct> vendor_product { get; set; }
        public DbSet<VendorProductCtg> vendor_product_ctg { get; set; }


        //DataElement
        public DbSet<DataElement> data_elements { get; set; }
        public DbSet<DteCategory> dte_ctg { get; set; }
        public DbSet<DataSubject> data_subject { get; set; }
        public DbSet<DteDataSubject> dte_data_subject { get; set; }
        public DbSet<DteSource> dte_source { get; set; }
        public DbSet<DteTransfer> dte_transfer { get; set; }
        public DbSet<DteVolume> dte_volume { get; set; }
        public DbSet<DteAsset> dte_asset { get; set; }
        public DbSet<DteVendor> dte_vendor { get; set; }
        public DbSet<DteProcess> dte_process { get; set; }


        //Control
        public DbSet<ControlLibrary> control_library { get; set; }
        public DbSet<ControlRegister> control_reg { get; set; }
        public DbSet<ControlCtg> control_ctg { get; set; }
        public DbSet<ControlRegCtg> control_reg_ctg { get; set; }
        public DbSet<OrgSecMeasure> org_sec_measure { get; set; }
        public DbSet<ControlSource> control_source { get; set; }
        public DbSet<ControlApprover> control_approver { get; set; }
        public DbSet<ControlAsset> control_asset { get; set; }
        public DbSet<ControlVendor> control_vendor { get; set; }
        public DbSet<ControlProcess> control_process { get; set; }


        //DPIA
        public DbSet<DPIATemplate> dpia_template { get; set; }
        public DbSet<DPIAAsset> dpia_asset { get; set; }


    }
}
