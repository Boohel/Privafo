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
    public class Entity : BaseDateEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Entity Name")]
        [StringLength(200, ErrorMessage = "Entity Name cannot be longer than 200 characters.")]
        public String EntityName { get; set; }
        [Display(Name = "Brand Name ")]
        [StringLength(200, ErrorMessage = "Brand Name cannot be longer than 200 characters.")]
        public String? BrandName { get; set; }
        [DataType(DataType.Text)]
        public String? Description { get; set; }
        [ValidateNever]
        [Required]
        [Display(Name = "Industry")]
        public int IndustryID { get; set; }
        [ForeignKey("IndustryID")]
        [ValidateNever]
        public City Industry { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Entity PIC cannot be longer than 50 characters.")]
        public String EntityPIC { get; set; }
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
