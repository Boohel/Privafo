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
    public class RiskRegister : BaseDateEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Risk Register Name")]
        [StringLength(300, ErrorMessage = "Risk Register Name cannot be longer than 300 characters.")]
        public int RiskRegName { get; set; }
        [DataType(DataType.Text)]
        public String? Description { get; set; }

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

        [ValidateNever]
        [StringLength(100)]
        [Display(Name = "Owner")]
        public string Owner { get; set; }
        [ForeignKey("Owner")]
        [ValidateNever]
        public ApplicationUser? UserOwner { get; set; }

        public DateTime? Deadline { get; set; }
        public Boolean Reminder { get; set; } = false;

        [ValidateNever]
        [StringLength(100)]
        [Display(Name = "Owner")]
        public string Approver { get; set; }
        [ForeignKey("Approver")]
        [ValidateNever]
        public ApplicationUser? UserApprover { get; set; }

    }
}
