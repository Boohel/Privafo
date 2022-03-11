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
    public class DPIATemplate : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public string TemplateName { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string Welcome { get; set; }
        public string QuestionJSON { get; set; }
    }

    public class DPIAAsset : BaseDateEntity
    {
        [Key]
        public int ID { get; set; }

        [ValidateNever]
        public int TemplateID { get; set; }
        [ForeignKey("TemplateID")]
        [ValidateNever]
        public DPIATemplate DPIATemplate { get; set; }


        [ValidateNever]
        public int  AssetID { get; set; }
        [ForeignKey("AssetID")]
        [ValidateNever]
        public Asset Asset { get; set; }


    }
}
