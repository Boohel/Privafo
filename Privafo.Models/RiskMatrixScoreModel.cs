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
    public class RiskMatrixScore
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
    }
}
