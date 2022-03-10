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
    public class Org : BaseDateEntity
    {
        [Key]
        [StringLength(30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public String ID { get; set; }
        [Required]
        [Display(Name = "Organization Name")]
        [StringLength(100, ErrorMessage = "Organization Name cannot be longer than 100 characters.")]
        public String OrgName { get; set; }
        [Display(Name = "Organization Code")]
        [StringLength(50, ErrorMessage = "Organization Code cannot be longer than 50 characters.")]
        public String? OrgCode { get; set; }
        [DataType(DataType.Text)]
        public String? Description { get; set; }
        [Required]
        [StringLength(30)]
        public String ParentID { get; set; }
        [Required]
        [Display(Name = "Sort")]
        public int OrgSort { get; set; }
        [ValidateNever]
        [Required]
        [Display(Name = "Branch")]
        public int BranchID { get; set; }
        [ForeignKey("BranchID")]
        [ValidateNever]
        public Branch Branch { get; set; }
    }
}
