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
    public class RiskRegister : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Risk Register Name")]
        [StringLength(300, ErrorMessage = "Risk Register Name cannot be longer than 300 characters.")]
        public String RiskRegName { get; set; }

        public String? Description { get; set; }

        [ValidateNever]
        [Required]
        [Display(Name = "Risk Type")]
        public int RiskTypeID { get; set; }
        [ForeignKey("RiskTypeID")]
        [ValidateNever]
        public RiskType RiskType { get; set; }

        public String Threat { get; set; }
        public String Vulnerability { get; set; }

        [ValidateNever]
        [Required]
        [Display(Name = "Resudual Risk")]
        public int ResidualRiskMx { get; set; }
        [ForeignKey("ResidualRiskMx")]
        [ValidateNever]
        public RiskMatrixScore ResidualRiskScore { get; set; }

        [ValidateNever]
        [NotMapped]
        [Display(Name = "Resudual Risk")]
        public string ResidualRiskLvl { get; set; }

        [NotMapped]
        [ValidateNever]
        public String ResidualRiskColor { get; set; }

        [ValidateNever]
        [Display(Name = "Inherent Risk")]
        public int? InherentRiskMx { get; set; }
        [ForeignKey("InherentRiskMx")]
        [ValidateNever]
        public RiskMatrixScore InherentRiskScore { get; set; }

        [ValidateNever]
        [NotMapped]
        [Display(Name = "Inherent Risk")]
        public string InherentRiskLvl { get; set; }

        [NotMapped]
        [ValidateNever]
        public String InherentRiskColor { get; set; }

        [ValidateNever]
        [Display(Name = "Target Risk")]
        public int? TargetRiskMx { get; set; }
        [ForeignKey("TargetRiskMx")]
        [ValidateNever]
        public RiskMatrixScore TargetRiskScore { get; set; }

        [ValidateNever]
        [NotMapped]
        [Display(Name = "Target Risk")]
        public string TargetRiskLvl { get; set; }

        [NotMapped]
        [ValidateNever]
        public String TargetRiskColor { get; set; }

        [Display(Name = "Treatment Plan")]
        public String TreatmentPlan { get; set; }

        [ValidateNever]
        [StringLength(450)]
        [Display(Name = "Owner")]
        public string Owner { get; set; }
        [ForeignKey("Owner")]
        [ValidateNever]
        public ApplicationUser UserOwner { get; set; }

        [ValidateNever]
        [StringLength(30)]
        [Display(Name = "Organization")]
        public String? OrgID { get; set; }
        [ForeignKey("OrgID")]
        [ValidateNever]
        public Organization? Org { get; set; }

        public DateTime? Deadline { get; set; }

        public Boolean Reminder { get; set; } = false;

        [ForeignKey("Owner")]
        [ValidateNever]
        [NotMapped]
        public RiskLibrary RiskLibrary { get; set; }

        [ValidateNever]
        [Required]
        [Display(Name = "Active Status")]
        public int ActiveStatusID { get; set; }
        [ForeignKey("ActiveStatusID")]
        [ValidateNever]
        public ActiveStatus ActiveStatus { get; set; }

    }

    public class RiskLibrary : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Risk Name")]
        [StringLength(300, ErrorMessage = "Risk Name cannot be longer than 300 characters.")]
        public string RiskLibName { get; set; }

        [DataType(DataType.Text)]
        public String? Description { get; set; }

        [ValidateNever]
        [Required]
        [Display(Name = "Risk Type")]
        public int RiskTypeID { get; set; }
        [ForeignKey("RiskTypeID")]
        [ValidateNever]
        public RiskType RiskType { get; set; }

        [ValidateNever]
        [Required]
        [Display(Name = "Risk Category")]
        public int RiskCtgID { get; set; }
        [ForeignKey("RiskCtgID")]
        [ValidateNever]
        public RiskCtg RiskCtg { get; set; }

        public String Threat { get; set; }
        public String Vulnerability { get; set; }

        [ValidateNever]
        [Required]
        [Display(Name = "Resudual Risk")]
        public int ResidualRiskMx { get; set; }
        [ForeignKey("ResidualRiskMx")]
        [ValidateNever]
        public RiskMatrixScore ResidualRiskScore { get; set; }
        [ValidateNever]
        [Required]
        [Display(Name = "Resudual Risk")]
        public int InherentRiskMx { get; set; }
        [ForeignKey("InherentRiskMx")]
        [ValidateNever]
        public RiskMatrixScore InherentRiskScore { get; set; }
        [ValidateNever]
        [Required]
        [Display(Name = "Target Risk")]
        public int TargetRiskMx { get; set; }
        [ForeignKey("TargetRiskMx")]
        [ValidateNever]
        public RiskMatrixScore TargetRiskScore { get; set; }

        [Display(Name = "Treatment Plan")]
        public String TreatmentPlan { get; set; }

        [ValidateNever]
        [Required]
        [Display(Name = "Active Status")]
        public int ActiveStatusID { get; set; }
        [ForeignKey("ActiveStatusID")]
        [ValidateNever]
        public ActiveStatus ActiveStatus { get; set; }

    }

    public class RiskCtg : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Risk Category Name")]
        [StringLength(100, ErrorMessage = "Risk Category Name cannot be longer than 100 characters.")]
        public String RiskCtgName { get; set; }
        public String? Description { get; set; }
    }

    public class RiskRegCtg : BaseDateEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ValidateNever]
        public int RiskRegID { get; set; }
        [ForeignKey("RiskRegID")]
        [ValidateNever]
        public RiskRegister RiskRegister { get; set; }

        [Required]
        [ValidateNever]
        public int RiskCtgID { get; set; }
        [ForeignKey("RiskCtgID")]
        [ValidateNever]
        public RiskCtg RiskCtg { get; set; }
    }

    public class RiskType : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Risk Type Name")]
        [StringLength(100, ErrorMessage = "Risk Type Name cannot be longer than 100 characters.")]
        public String RiskTypeName { get; set; }
        public String? Description { get; set; }
    }

    public class RiskImpact
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Risk Impact Name")]
        [StringLength(50, ErrorMessage = "Risk Impact Name cannot be longer than 50 characters.")]
        public String RiskImpactName { get; set; }
        public int? LevelSort { get; set; }
    }

    public class RiskProbability
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Risk Probability Name")]
        [StringLength(50, ErrorMessage = "Risk Probability Name cannot be longer than 50 characters.")]
        public String RiskProbabilityName { get; set; }
        public int? LevelSort { get; set; }
    }

    public class RiskMatrixScore : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        [ValidateNever]
        [Required]
        [Display(Name = "Risk Probability")]
        public int RiskProbID { get; set; }
        [ForeignKey("RiskProbID")]
        [ValidateNever]
        public RiskProbability RiskProbability { get; set; }
        [ValidateNever]
        [Required]
        [Display(Name = "Risk Impact")]
        public int RiskImpactID { get; set; }
        [ForeignKey("RiskImpactID")]
        [ValidateNever]
        public RiskImpact RiskImpact { get; set; }
        [Required]
        [Display(Name = "Score")]
        [Range(0, 100, ErrorMessage = "Score must between 0 and 100 only.")]
        public Double Score { get; set; }
        [NotMapped]
        [ValidateNever]
        public String LvlScoreName { get; set; }
        [NotMapped]
        [ValidateNever]
        public String LvlScoreColor { get; set; }
    }

    public class RiskRangeScore : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Min")]
        [Range(0, 100, ErrorMessage = "Score must between 0 and 100 only.")]
        public Double MinRange { get; set; }
        [Required]
        [Display(Name = "Max")]
        [Range(0, 100, ErrorMessage = "Score must between 0 and 100 only.")]
        public Double MaxRange { get; set; }
        [Required]
        [Display(Name = "Risk Level")]
        [StringLength(50, ErrorMessage = "Risk Impact Name cannot be longer than 50 characters.")]
        public String RiskLevel { get; set; }
        [Required]
        [Display(Name = "Color")]
        [StringLength(10)]
        public String RangeColor { get; set; }
    }

    public class RiskThreat : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Threat Name")]
        [StringLength(200, ErrorMessage = "Threat Name cannot be longer than 200 characters.")]
        public String ThreatName { get; set; }
        public String? Description { get; set; }
    }

    public class RiskVulnerability : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Vulnerability Name")]
        [StringLength(200, ErrorMessage = "Vulnerability Name cannot be longer than 200 characters.")]
        public String VulnerabilityName { get; set; }
        public String? Description { get; set; }
    }

    //public class RiskStatus : BaseEntity
    //{
    //    [Key]
    //    public int ID { get; set; }
    //    [Required]
    //    [Display(Name = "Status Name")]
    //    [StringLength(30, ErrorMessage = "Status Name cannot be longer than 30 characters.")]
    //    public String RiskStatusName { get; set; }
    //    public String? Description { get; set; }
    //}

    public class RiskApprover : BaseDateEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ValidateNever]
        public int RiskRegID { get; set; }
        [ForeignKey("RiskRegID")]
        [ValidateNever]
        public RiskRegister RiskRegister { get; set; }

        [ValidateNever]
        [StringLength(450)]
        [Display(Name = "Approver")]
        public string Approver { get; set; }
        [ForeignKey("Approver")]
        [ValidateNever]
        public ApplicationUser UserApprover { get; set; }

        public Boolean Approved { get; set; } = false;
    }

    public class RiskAsset : BaseDateEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ValidateNever]
        public int RiskRegID { get; set; }
        [ForeignKey("RiskRegID")]
        [ValidateNever]
        public RiskRegister RiskRegister { get; set; }

        [Required]
        [ValidateNever]
        public int AssetID { get; set; }
        [ForeignKey("AssetID")]
        [ValidateNever]
        public Asset Asset { get; set; }
    }

    public class RiskVendor : BaseDateEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ValidateNever]
        public int RiskRegID { get; set; }
        [ForeignKey("RiskRegID")]
        [ValidateNever]
        public RiskRegister RiskRegister { get; set; }

        [Required]
        [ValidateNever]
        public int VendorID { get; set; }
        [ForeignKey("VendorID")]
        [ValidateNever]
        public Vendor Vendor { get; set; }
    }

    public class RiskProcess : BaseDateEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ValidateNever]
        public int RiskRegID { get; set; }
        [ForeignKey("RiskRegID")]
        [ValidateNever]
        public RiskRegister RiskRegister { get; set; }

        [Required]
        [ValidateNever]
        public int VendorID { get; set; }
        [ForeignKey("VendorID")]
        [ValidateNever]
        public Vendor Vendor { get; set; }
    }

}
