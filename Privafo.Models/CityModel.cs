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
    public class City
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "City Name")]
        [StringLength(200, ErrorMessage = "City Name cannot be longer than 200 characters.")]
        public String CityName { get; set; }
        [Display(Name = "City Code")]
        [StringLength(30, ErrorMessage = "City Code cannot be longer than 30 characters.")]
        public String? ProvinceCode { get; set; }
        [ValidateNever]
        [Required]
        [Display(Name = "Province")]
        public int ProvinceID { get; set; }
        [ForeignKey("ProvinceID")]
        [ValidateNever]
        public Province Province { get; set; }
    }
}
