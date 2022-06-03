using Microsoft.AspNetCore.Identity;
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
    public class ControlRegister : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Control Register Name")]
        [StringLength(300, ErrorMessage = "Control Register Name cannot be longer than 300 characters.")]
        public int CtrRegName { get; set; }

        public String? Description { get; set; }

        public String? CtrRegStandard { get; set; }

        [ValidateNever]
        [StringLength(450)]
        [Display(Name = "Owner")]
        public string Owner { get; set; }
        [ForeignKey("Owner")]
        [ValidateNever]
        public ApplicationUser UserOwner { get; set; }

        [ValidateNever]
        [StringLength(30)]
        [Display(Name = "Organization")]
        public String? OrgID { get; set; }
        [ForeignKey("OrgID")]
        [ValidateNever]
        public Org? Org { get; set; }

        [ValidateNever]
        [Display(Name = "Source")]
        public int CtrSourceID { get; set; }
        [ForeignKey("CtrSourceID")]
        [ValidateNever]
        public ControlSource ControlSource { get; set; }

        public DateTime? Deadline { get; set; }

        public Boolean Reminder { get; set; } = false;
    }

    public class ControlLibrary : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Control Register Name")]
        [StringLength(300, ErrorMessage = "Control Register Name cannot be longer than 300 characters.")]
        public int CtrRegName { get; set; }

        public String? Description { get; set; }

        [ValidateNever]
        [Required]
        [Display(Name = "Control Category")]
        public int CtrCtgID { get; set; }
        [ForeignKey("ControlCtgID")]
        [ValidateNever]
        public ControlCtg ControlCtg { get; set; }

        public String? CtrRegStandard { get; set; }

        [ValidateNever]
        [Display(Name = "Source")]
        public int CtrSourceID { get; set; }
        [ForeignKey("CtrSourceID")]
        [ValidateNever]
        public ControlSource ControlSource { get; set; }

        [ValidateNever]
        [Required]
        [Display(Name = "Active Status")]
        public int ActiveStatusID { get; set; }
        [ForeignKey("ActiveStatusID")]
        [ValidateNever]
        public ActiveStatus ActiveStatus { get; set; }

    }

    public class ControlCtg : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Control Category Name")]
        [StringLength(100, ErrorMessage = "Control Category Name cannot be longer than 100 characters.")]
        public String CtrCtgName { get; set; }

        public String? Description { get; set; }
    }

    public class ControlRegCtg : BaseDateEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ValidateNever]
        public int ControlID { get; set; }
        [ForeignKey("ControlID")]
        [ValidateNever]
        public ControlRegister ControlRegister { get; set; }

        [Required]
        [ValidateNever]
        public int CtrCtgID { get; set; }
        [ForeignKey("CtrCtgID")]
        [ValidateNever]
        public ControlCtg ControlCtg { get; set; }
    }

    public class OrgSecMeasure : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Organizational Security Measure Name")]
        [StringLength(200, ErrorMessage = "Organizational Security Name cannot be longer than 200 characters.")]
        public String OrgSecMeasureName { get; set; }

        public String? Description { get; set; }
    }

    public class TechSecMeasure : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Technical Security Measure Name")]
        [StringLength(200, ErrorMessage = "Technical Security Name cannot be longer than 200 characters.")]
        public String TechSecMeasureName { get; set; }

        public String? Description { get; set; }
    }

    public class ControlSource : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Control Source Name")]
        [StringLength(200, ErrorMessage = "Control Source Name cannot be longer than 200 characters.")]
        public String CtrSourceName { get; set; }

        public String? Description { get; set; }
    }

    public class ControlApprover : BaseDateEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ValidateNever]
        public int CtrRegID { get; set; }
        [ForeignKey("CtrRegID")]
        [ValidateNever]
        public ControlRegister ControlRegister { get; set; }

        [ValidateNever]
        [StringLength(450)]
        [Display(Name = "Approver")]
        public string Approver { get; set; }
        [ForeignKey("Approver")]
        [ValidateNever]
        public ApplicationUser UserApprover { get; set; }

        public Boolean Approved { get; set; } = false;
    }

    public class ControlAsset : BaseDateEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ValidateNever]
        public int CtrRegID { get; set; }
        [ForeignKey("CtrRegID")]
        [ValidateNever]
        public ControlRegister ControlRegister { get; set; }

        [Required]
        [ValidateNever]
        public int AssetID { get; set; }
        [ForeignKey("AssetID")]
        [ValidateNever]
        public Asset Asset { get; set; }
    }

    public class ControlVendor : BaseDateEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ValidateNever]
        public int ControlRegID { get; set; }
        [ForeignKey("ControlRegID")]
        [ValidateNever]
        public ControlRegister ControlRegister { get; set; }

        [Required]
        [ValidateNever]
        public int VendorID { get; set; }
        [ForeignKey("VendorID")]
        [ValidateNever]
        public Vendor Vendor { get; set; }
    }

    public class ControlProcess : BaseDateEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ValidateNever]
        public int ControlRegID { get; set; }
        [ForeignKey("ControlRegID")]
        [ValidateNever]
        public ControlRegister ControlRegister { get; set; }

        [Required]
        [ValidateNever]
        public int VendorID { get; set; }
        [ForeignKey("VendorID")]
        [ValidateNever]
        public Vendor Vendor { get; set; }
    }
}
