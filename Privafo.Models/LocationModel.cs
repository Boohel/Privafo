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
