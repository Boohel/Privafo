using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.Models
{
    public class ModuleCtg
    {
        [Key]
        public int ModuleCtgID { get; set; }
        [Required]
        [Display(Name = "Module Category Name")]
        public String ModuleCtgName { get; set; }
        [Required]
        [Display(Name = "Sort")]
        public int ModuleCtgSort { get; set; }
        [Display(Name = "Image Class")]
        public String ModuleCtgImg { get; set; }
    }
}
