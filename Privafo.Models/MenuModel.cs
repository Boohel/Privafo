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
    public class Menu : BaseDateEntity
    {
        [Key]
        [StringLength(30)]
        public String ID { get; set; }
        [Required]
        [Display(Name = "Menu Name")]
        [StringLength(50, ErrorMessage = "Menu Name cannot be longer than 50 characters.")]
        public String MenuName { get; set; }
        [DataType(DataType.Text)]
        public String? Description { get; set; }
        [Required]
        [Display(Name = "Controller Name")]
        [StringLength(50, ErrorMessage = "Controller Name cannot be longer than 50 characters.")]
        public String ControllerName { get; set; }
        [Required]
        [Display(Name = "Action Name")]
        [StringLength(50, ErrorMessage = "Action Name cannot be longer than 50 characters.")]
        public String ActionName { get; set; }
        [Required]
        [Display(Name = "Sort")]
        public int MenuSort { get; set; }
        [Required]
        [Display(Name = "Image Class")]
        [StringLength(50, ErrorMessage = "Image Class cannot be longer than 50 characters.")]
        public String MenuImageClass { get; set; }
        [Display(Name = "Menu Group")]
        [StringLength(50)]
        public String? MenuGroup { get; set; }
        [Display(Name = "Menu Key")]
        [StringLength(50)]
        public String? MenuKey { get; set; }
        [Required]
        [StringLength(30)]
        public String ParentID { get; set; }

        [ValidateNever]
        [Required]
        [Display(Name = "Module")]
        public int ModuleID { get; set; }
        [ForeignKey("ModuleID")]
        [ValidateNever]
        public Module Module { get; set; }
    }
}
