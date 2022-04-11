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
    public class FilterField
    {
        public string type { get; set; }
        public string id { get; set; }
        public string label { get; set; }
        public IEnumerable<FilterListItem> list { get; set; }
    }
    public class FilterListItem
    {
        public string id { get; set; }
        public string label { get; set; }
    }

}
