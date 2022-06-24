using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.Models
{
    public class Asset : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Asset Name")]
        [StringLength(255, ErrorMessage = "Asset Name cannot be longer than 100 characters.")]
        public String AssetName { get; set; }

        public String? Description { get; set; }

        [ValidateNever]
        [Required]
        [Display(Name = "Asset Type")]
        public int AstTypeID { get; set; }
        [ForeignKey("AstTypeID")]
        [ValidateNever]
        public AssetType AssetType { get; set; }

        [ValidateNever]
        [StringLength(450)]
        [Display(Name = "Owner")]
        public string Owner { get; set; }
        [ForeignKey("Owner")]
        [ValidateNever]
        public ApplicationUser UserOwner { get; set; }

        [ValidateNever]
        [Required]
        [Display(Name = "Asset Storage Format")]
        public int AstStorageFormatID { get; set; }
        [ForeignKey("AstStorageFormatID")]
        [ValidateNever]
        public AssetStorageFormat AssetStorageFormat { get; set; }

        [Required]
        [StringLength(50)]
        public String Ownership { get; set; }

        [ValidateNever]
        [StringLength(30)]
        [Display(Name = "Organization")]
        public String? OrgID { get; set; }
        [ForeignKey("OrgID")]
        [ValidateNever]
        public Organization? Org { get; set; }

        [ValidateNever]
        [Display(Name = "Vendor")]
        public int? VendorID { get; set; }
        [ForeignKey("VendorID")]
        [ValidateNever]
        public Vendor? Vendor { get; set; }

        [ValidateNever]
        [Display(Name = "Location")]
        public int? CountryID { get; set; }
        [ForeignKey("CountryID")]
        [ValidateNever]
        public Country Country { get; set; }

        [StringLength(30)]
        public String? HostIPAddress { get; set; }

        [ValidateNever]
        [Display(Name = "Hosting Type")]
        public int? HostingType { get; set; }

        [Display(Name = "Hosting Provider")]
        [StringLength(100, ErrorMessage = "Hosting Provider cannot be longer than 100 characters.")]
        public String? HostingProvider  { get; set; }

        [ValidateNever]
        [StringLength(30)]
        [Display(Name = "Data Element Volume")]
        public int? DteVolumeID { get; set; }
        [ForeignKey("DteVolumeID")]
        [ValidateNever]
        public DteVolume? DteVolume { get; set; }

        [Display(Name = "Emplacement du Site")]
        [StringLength(255, ErrorMessage = "Emplacement du site cannot be longer than 100 characters.")]
        public String? Emplacement { get; set; }

        [ValidateNever]
        [Display(Name = "Technical Security Measure")]
        public int? TechSecMeasureID { get; set; }
        [ForeignKey("TechSecMeasureID")]
        [ValidateNever]
        public TechSecMeasure? TechSecMeasure { get; set; }

        [ValidateNever]
        [Display(Name = "Organizational Security Measure")]
        public int? OrgSecMeasureID { get; set; }
        [ForeignKey("OrgSecMeasureID")]
        [ValidateNever]
        public OrgSecMeasure? OrgSecMeasure { get; set; }

        [Display(Name = "Other Security")]
        public String? OtherSecurity { get; set; }

        [Display(Name = "Data Rentention")]
        [StringLength(50)]
        public String? DataRetention { get; set; }

        [ValidateNever]
        [Display(Name = "Disposal Type")]
        public int? AstDisposalID { get; set; }
        [ForeignKey("AstDisposalID")]
        [ValidateNever]
        public AssetDisposal? AstDisposal { get; set; }

        [ValidateNever]
        [Display(Name = "Aggregate Risk")]
        public int? AggregateRiskMx { get; set; }
        [ForeignKey("AggregateRiskMx")]
        [ValidateNever]
        public RiskMatrixScore AggregateRiskScore { get; set; }

        [ValidateNever]
        [NotMapped]
        [Display(Name = "Aggregate Risk")]
        public string AggregateRiskLvl { get; set; }

        [ValidateNever]
        [Required]
        [Display(Name = "Active Status")]
        public int ActiveStatusID { get; set; }
        [ForeignKey("ActiveStatusID")]
        [ValidateNever]
        public ActiveStatus ActiveStatus { get; set; }

        public Boolean IsMaster { get; set; } = false;

        public Boolean MasterRecord { get; set; } = false;

    }

    public class AssetType
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Asset Type Name")]
        [StringLength(100, ErrorMessage = "Asset Type Name cannot be longer than 100 characters.")]
        public String AstTypeName { get; set; }
        public String? Description { get; set; }
    }

    public class AssetStorageFormat
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Asset Type Name")]
        [StringLength(200, ErrorMessage = "Asset Type Name cannot be longer than 200 characters.")]
        public String AstStorFormatName { get; set; }
        public String? Description { get; set; }
    }

    public class AssetDisposal
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Asset Disposal Name")]
        [StringLength(100, ErrorMessage = "Asset Disposal Name cannot be longer than 100 characters.")]
        public String AstDisposalName { get; set; }
        public String? Description { get; set; }
    }

}
