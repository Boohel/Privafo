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
    public class CityVM
    {
        public City city { get; set; }
        [ValidateNever]

        [Display(Name = "Select a Province")]
        public IEnumerable<SelectListItem> provinceList { get; set; }

    }

}
