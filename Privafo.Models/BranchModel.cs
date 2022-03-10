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
    public class Branch : BaseDateEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Branch Name")]
        [StringLength(200, ErrorMessage = "Branch Name cannot be longer than 200 characters.")]
        public String BranchName { get; set; }
        [Display(Name = "Branch Code")]
        [StringLength(50, ErrorMessage = "Branch Code cannot be longer than 50 characters.")]
        public String? BranchCode { get; set; }
        [DataType(DataType.Text)]
        public String? Description { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Branch PIC cannot be longer than 50 characters.")]
        public String BranchPIC { get; set; }
        [Display(Name = "Phone Number")]
        [StringLength(100, ErrorMessage = "Phone cannot be longer than 100 characters.")]
        public String? Phone { get; set; }
        [Display(Name = "Mobile Phone Number")]
        [StringLength(100, ErrorMessage = "Mobile Phone cannot be longer than 100 characters.")]
        public String? MobilePhone { get; set; }
        [Display(Name = "Email")]
        [StringLength(200, ErrorMessage = "Email cannot be longer than 200 characters.")]
        public String? Email { get; set; }
        [ValidateNever]
        [Required]
        [Display(Name = "Address")]
        public int AddressID { get; set; }
        [ForeignKey("AddressID")]
        [ValidateNever]
        public Address Address { get; set; }
    }
}
