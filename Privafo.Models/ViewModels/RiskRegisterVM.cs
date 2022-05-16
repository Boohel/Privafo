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
        [ValidateNever]
        public IEnumerable<SelectListItem> RiskCtgList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> RiskTypeList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> OrganizationList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> OwnerList { get; set; }

        [Display(Name = "Select a Risk")]
        [ValidateNever]
        public IEnumerable<SelectListItem> RiskLibraryList { get; set; }
    }

}
