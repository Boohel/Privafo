using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
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
        public IEnumerable<SelectListItem> ModuleCtgSelectList { get; set; }
    }
    public class NavModuleVM
    {
        [ValidateNever]
        public IEnumerable<Module> ModuleList { get; set; }
        [ValidateNever]
        public IEnumerable<ModuleCtg> ModuleCtgList { get; set; }
    }
    public class NavMenuVM
    {
        public IEnumerable<Menu> MenuLevel1 { get; set; }
        public IEnumerable<Menu> MenuLevel2 { get; set; }
        public IEnumerable<Menu> MenuLevel3 { get; set; }
    }
}
