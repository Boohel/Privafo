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
    public class Province
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Province Name")]
        [StringLength(200, ErrorMessage = "Province Name cannot be longer than 200 characters.")]
        public String ProvinceName { get; set; }
        [Display(Name = "Province Code")]
        [StringLength(30, ErrorMessage = "Province Code cannot be longer than 30 characters.")]
        public String? ProvinceCode { get; set; }
        [ValidateNever]
        [Required]
        [Display(Name = "Country")]
        public int CountryID { get; set; }
        [ForeignKey("CountryID")]
        [ValidateNever]
        public Country Country { get; set; }
    }
}
