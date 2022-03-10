using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.Models
{
    public class RiskCtg
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Risk Category Name")]
        [StringLength(100, ErrorMessage = "Risk Category Name cannot be longer than 100 characters.")]
        public String RiskCtgName { get; set; }
        public String? Description { get; set; }
    }
}
