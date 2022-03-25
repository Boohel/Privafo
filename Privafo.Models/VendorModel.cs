using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Privafo.Models
{
    public class Vendor : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Vendor Name")]
        [StringLength(255, ErrorMessage = "Vendor Name cannot be longer than 255 characters.")]
        public String VendorName { get; set; }

        [ValidateNever]
        [Required]
        [Display(Name = "Vendor Type")]
        public int VenTypeID { get; set; }
        [ForeignKey("VenTypeID")]
        [ValidateNever]
        public VendorType VendorType { get; set; }

        public String? Description { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Vendor PIC cannot be longer than 100 characters.")]
        public String VendorPIC { get; set; }

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

        [ValidateNever]
        [Required]
        [Display(Name = "Active Status")]
        public int ActiveStatusID { get; set; }
        [ForeignKey("ActiveStatusID")]
        [ValidateNever]
        public ActiveStatus ActiveStatus { get; set; }
    }

    public class VendorLocation : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [ValidateNever]
        [Required]
        [Display(Name = "Vendor")]
        public int VendorID { get; set; }
        [ForeignKey("VendorID")]
        [ValidateNever]
        public Vendor Vendor { get; set; }

        [Required]
        [Display(Name = "Vendor Location Name")]
        [StringLength(255, ErrorMessage = "Vendor Location Name cannot be longer than 255 characters.")]
        public String VenLocName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Vendor PIC cannot be longer than 100 characters.")]
        public String VendorPIC { get; set; }

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

        [ValidateNever]
        [Required]
        [Display(Name = "Active Status")]
        public int ActiveStatusID { get; set; }
        [ForeignKey("ActiveStatusID")]
        [ValidateNever]
        public ActiveStatus ActiveStatus { get; set; }
    }

    public class VendorEngage : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Vendor Engage Name")]
        [StringLength(255, ErrorMessage = "Vendor Engage Name cannot be longer than 255 characters.")]
        public String VenEngageName { get; set; }

        [ValidateNever]
        [Required]
        [Display(Name = "Vendor")]
        public int VendorID { get; set; }
        [ForeignKey("VendorID")]
        [ValidateNever]
        public Vendor Vendor { get; set; }

        [Required]
        public DateTime VenStartDate { get; set; }

        [Required]
        public DateTime VenEndDate { get; set; }

        public Boolean Reminder { get; set; } = false;

        public String? VenContactDoc { get; set; }

        public String? VenContactFile { get; set; }
    }

    public class VendorType : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Vendor Type Name")]
        [StringLength(200, ErrorMessage = "Vendor Type Name cannot be longer than 100 characters.")]
        public String VenTypeName { get; set; }

        public String? Description { get; set; }
    }

    public class VendorProduct : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        [StringLength(200, ErrorMessage = "Product Name cannot be longer than 200 characters.")]
        public String VenProductName { get; set; }

        public String? Description { get; set; }

        [ValidateNever]
        [Required]
        [Display(Name = "Product Category")]
        public int VenProdCtgID { get; set; }
        [ForeignKey("VenProdCtgID")]
        [ValidateNever]
        public VendorProductCtg VendorProductCtg { get; set; }
    }

    public class VendorProductCtg : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Product Category Name")]
        [StringLength(100, ErrorMessage = "Product Category cannot be longer than 100 characters.")]
        public String VenProdCtgName { get; set; }

        public String? Description { get; set; }
    }

}
