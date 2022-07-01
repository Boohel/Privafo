using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.Models.ViewModels
{
    public class EntityVM
    {
        public Entity entity { get; set; }
        [ValidateNever]
        public Address industry { get; set; }
        [ValidateNever]
        [Display(Name = "Select a City")]
        public IEnumerable<SelectListItem> industryList { get; set; }
        public Address address { get; set; }
        [ValidateNever]
        [Display(Name = "Select a City")]
        public IEnumerable<SelectListItem> cityList { get; set; }
        [ValidateNever]
        [Display(Name = "Select a Country")]
        public IEnumerable<SelectListItem> countryList { get; set; }
        [ValidateNever]
        [Display(Name = "Select a Province")]
        public IEnumerable<SelectListItem> provinceList { get; set; }
        [ValidateNever]
        public string cityId { get; set; }
        [ValidateNever]
        public string countryId { get; set; }
        [ValidateNever]
        public string provinceId { get; set; }

    }

}
