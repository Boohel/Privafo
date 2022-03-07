using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.Models
{
    public class RiskRangeScore
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
    }
}
