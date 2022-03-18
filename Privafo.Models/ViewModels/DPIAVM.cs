using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.Models.ViewModels
{
    public class DPIAVM
    {
        //public DPIATemplate DPIATemplate { get; set; }
        public DPIATemplate DPIATemplate { get; set; }
        public DPIAAsset DPIAAsset { get; set; }


        //[ValidateNever]
        //public IEnumerable<SelectListItem> ModuleCtgSelectList { get; set; }
    }

}
