﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.Models.ViewModels
{
    public class ModuleVM
    {
        public Module Module { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> ModuleCtgList { get; set; }
    }
}
