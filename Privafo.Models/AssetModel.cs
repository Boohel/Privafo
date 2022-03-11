using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.Models
{
    public class Asset:BaseEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Asset Name")]
        [StringLength(100, ErrorMessage = "Asset Name cannot be longer than 100 characters.")]
        public String AssetName { get; set; }
        public String? Description { get; set; }
    }
}
