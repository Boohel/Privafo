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
        public string UserID { get; set; }
        [ForeignKey("UserID")]
        [ValidateNever]
        public ApplicationUser? UserApprover { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateModified { get; set; } = DateTime.Now;


    }
}
