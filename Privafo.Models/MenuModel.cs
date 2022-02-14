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
    public class Menu
    {
        [Key]
        public String MenuID { get; set; }
        [Required]
        [Display(Name = "Menu Name")]
        public String MenuName { get; set; }
        [Required]
        [Display(Name = "Controller Name")]
        public String ControllerName { get; set; }
        [Required]
        [Display(Name = "Action Name")]
        public String ActionName { get; set; }
        [Required]
        [Display(Name = "Sort")]
        public int MenuSort { get; set; }
        [Required]
        [Display(Name = "Image Class")]
        public String MenuImageClass { get; set; }
        [Display(Name = "Menu Group")]
        public String MenuGroup { get; set; }
        [Display(Name = "Menu Key")]
        public String MenuKey { get; set; }
        [Required]
        public String ParentID { get; set; }      

        [Required]
        [Display(Name = "Module")]
        public int ModuleID { get; set; }
        [ForeignKey("ModuleID")]
        [ValidateNever]
        public Module Module { get; set; }
    }
}
