using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.Models
{
    public class ModuleCtg : BaseDateEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Module Category Name")]
        [StringLength(50, ErrorMessage = "Module Category Name cannot be longer than 50 characters.")]
        public String ModuleCtgName { get; set; }
        [Required]
        [Display(Name = "Sort")]
        public int ModuleCtgSort { get; set; }
        [Display(Name = "Image Class")]
        [StringLength(50, ErrorMessage = "Image Class cannot be longer than 50 characters.")]
        public String? ModuleCtgImg { get; set; }
    }
}
