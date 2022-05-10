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
    public class ProvinceVM
    {
        public Province province { get; set; }
        [ValidateNever]

        [Display(Name = "Select a Country")]
        public IEnumerable<SelectListItem> countryList { get; set; }
       
    }

}
