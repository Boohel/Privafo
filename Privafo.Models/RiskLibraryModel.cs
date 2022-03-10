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
    public class RiskLibrary : BaseDateEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Risk Name")]
        [StringLength(300, ErrorMessage = "Risk Name cannot be longer than 300 characters.")]
        public int RiskRegName { get; set; }
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

        public int TreatmentPlan { get; set; }

    }
}
