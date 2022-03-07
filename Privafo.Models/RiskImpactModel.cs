using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.Models
{
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
}
