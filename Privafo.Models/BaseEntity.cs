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
    public abstract class BaseEntity
    {
        [ValidateNever]
        [StringLength(450)]
        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }
        [ForeignKey("CreatedBy")]
        [ValidateNever]
        public ApplicationUser UserCreated { get; set; }

        [Display(Name = "Date Created")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [ValidateNever]
        [StringLength(450)]
        [Display(Name = "Modified By")]
        public string? ModifiedBy { get; set; }
        [ForeignKey("ModifiedBy")]
        [ValidateNever]
        public ApplicationUser? UserModified { get; set; }

        [Display(Name = "Date Modified")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateModified { get; set; } = DateTime.Now;


    }
}
