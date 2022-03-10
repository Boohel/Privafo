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
    public class Address
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Address 1")]
        [StringLength(300, ErrorMessage = "Address 1 cannot be longer than 300 characters.")]
        public String Add1 { get; set; }
        [Display(Name = "Address 2")]
        [StringLength(150, ErrorMessage = "Address 2 cannot be longer than 150 characters.")]
        public String Add2 { get; set; }
        [Display(Name = "Address 3")]
        [StringLength(150, ErrorMessage = "Address 3 cannot be longer than 150 characters.")]
        public String Add3 { get; set; }
        [ValidateNever]
        [Required]
        [Display(Name = "City")]
        public int CityID { get; set; }
        [ForeignKey("CityID")]
        [ValidateNever]
        public City City { get; set; }
        [Display(Name = "Postal Code")]
        [StringLength(10, ErrorMessage = "Postal Code cannot be longer than 10 characters.")]
        public String? PostCode { get; set; }
        [StringLength(100, ErrorMessage = "Latitude cannot be longer than 100 characters.")]
        public String? Latitude { get; set; }
        [StringLength(100, ErrorMessage = "Longitude cannot be longer than 100 characters.")]
        public String? Longitude { get; set; }

    }
}
