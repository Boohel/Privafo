using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.Models
{
    public class Module : BaseDateEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Module Name")]
        [StringLength(50, ErrorMessage = "Module Name cannot be longer than 50 characters.")]
        public String ModuleName { get; set; }
        [DataType(DataType.Text)]
        public String? Description { get; set; }
        [Display(Name = "Color")]
        [ValidateNever]
        [StringLength(10)]
        public String? ModuleColor { get; set; }
        [Required]
        [Display(Name = "Sort")]
        public int ModuleSort { get; set; }
        [Required]
        [Display(Name = "Image Class")]
        [StringLength(50, ErrorMessage = "Image Class cannot be longer than 50 characters.")]
        public String ModuleImageClass { get; set; }

        [ValidateNever]
        [Required]
        [Display(Name = "Module Category")]
        public int ModuleCtgID { get; set; }
        [ForeignKey("ModuleCtgID")]
        [ValidateNever]
        public ModuleCtg ModuleCtg { get; set; }
    }
}
