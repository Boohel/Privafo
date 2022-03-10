using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.Models
{
    public class Industry
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Industry Name")]
        [StringLength(100, ErrorMessage = "Industry Name cannot be longer than 100 characters.")]
        public String IndustryName { get; set; }
        public String? Description { get; set; }
    }
}
