using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.Models
{
    public class Country
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Country Name")]
        [StringLength(200, ErrorMessage = "Country Name cannot be longer than 200 characters.")]
        public String CountryName { get; set; }
        [Display(Name = "Country Code")]
        [StringLength(30, ErrorMessage = "Country Code cannot be longer than 30 characters.")]
        public String? CountryCode { get; set; }
    }
}
