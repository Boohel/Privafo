using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.Models
{
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
}
