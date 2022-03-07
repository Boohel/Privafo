using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.Models
{
    public class RiskType
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Risk Type Name")]
        [StringLength(100, ErrorMessage = "Risk Type Name cannot be longer than 100 characters.")]
        public String RiskTypeName { get; set; }
        public String? Description { get; set; }
    }
}
