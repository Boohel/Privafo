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
    public class RiskRegisterVM
    {
        public RiskRegister RiskRegister { get; set; }
        public IEnumerable<SelectListItem> RiskCtgList { get; set; }
        public IEnumerable<SelectListItem> RiskTypeList { get; set; }

        [Display(Name = "Select a Risk")]
        public IEnumerable<SelectListItem> RiskLibrary { get; set; }
    }

}
