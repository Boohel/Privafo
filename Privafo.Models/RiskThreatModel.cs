using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.Models
{
    public class RiskThreat : BaseDateEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Threat Name")]
        [StringLength(200, ErrorMessage = "Threat Name cannot be longer than 200 characters.")]
        public String ThreatName { get; set; }
        public String? Description { get; set; }
    }
}
