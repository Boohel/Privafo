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
    public class ProcessingActivity : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Process Name")]
        [StringLength(255, ErrorMessage = "Process Name cannot be longer than 255 characters.")]
        public String ProcActName { get; set; }

        public String? Description { get; set; }

        [ValidateNever]
        [Required]
        [Display(Name = "Process Type")]
        public int ProcTypeID { get; set; }
        [ForeignKey("ProcTypeID")]
        [ValidateNever]
        public ProcessType ProcessType { get; set; }

        [ValidateNever]
        [StringLength(450)]
        [Display(Name = "Owner")]
        public string Owner { get; set; }
        [ForeignKey("Owner")]
        [ValidateNever]
        public ApplicationUser UserOwner { get; set; }

        [ValidateNever]
        [Required]
        [Display(Name = "Branch")]
        public int BranchID { get; set; }
        [ForeignKey("BranchID")]
        [ValidateNever]
        public Branch Branch { get; set; }

        [ValidateNever]
        [StringLength(30)]
        [Display(Name = "Organization")]
        public String OrgID { get; set; }
        [ForeignKey("OrgID")]
        [ValidateNever]
        public Organization Org { get; set; }

        [ValidateNever]
        [Display(Name = "Country Utilizing Process")]
        public int? CountryID { get; set; }
        [ForeignKey("CountryID")]
        [ValidateNever]
        public Country? Country { get; set; }

        [ValidateNever]
        [StringLength(30)]
        [Display(Name = "Purpose of Processing")]
        public int ProcPurposeID { get; set; }
        [ForeignKey("ProcPurposeID")]
        [ValidateNever]
        public ProcessPurpose ProcessPurpose { get; set; }

        [ValidateNever]
        [StringLength(30)]
        [Display(Name = "Source Origin")]
        public int? DteSourceOriID { get; set; }
        [ForeignKey("DteSourceOriID")]
        [ValidateNever]
        public DteSource? DteSourceOri { get; set; }

        [ValidateNever]
        [StringLength(30)]
        [Display(Name = "Data Transfer Method (Origin)")]
        public int? DteTransferOriID { get; set; }
        [ForeignKey("DteTransferOriID")]
        [ValidateNever]
        public DteTransfer? DteTransferOri { get; set; }

        [ValidateNever]
        [StringLength(30)]
        [Display(Name = "Source Destination")]
        public int? DteSourceDesID { get; set; }
        [ForeignKey("DteSourceDesID")]
        [ValidateNever]
        public DteSource? DteSourceDes { get; set; }

        [ValidateNever]
        [StringLength(30)]
        [Display(Name = "Data Transfer Method (Destination)")]
        public int? DteTransferDesID { get; set; }
        [ForeignKey("DteTransferDesID")]
        [ValidateNever]
        public DteTransfer? DteTransferDes { get; set; }

        [ValidateNever]
        [StringLength(30)]
        [Display(Name = "Cross Border Transfer Mechanism")]
        public int? DteTransferCrossID { get; set; }
        [ForeignKey("DteTransferCrossID")]
        [ValidateNever]
        public DteTransfer? DteTransferCross { get; set; }

        [ValidateNever]
        [StringLength(30)]
        [Display(Name = "Data Element Volume")]
        public int? DteVolumeID { get; set; }
        [ForeignKey("DteVolumeID")]
        [ValidateNever]
        public DteVolume? DteVolume { get; set; }

        [Display(Name = "Emplacement")]
        [StringLength(255, ErrorMessage = "Emplacement cannot be longer than 100 characters.")]
        public String? Emplacement { get; set; }

        [Display(Name = "Location of Parties (Access/Use Data)")]
        [StringLength(100)]
        public String? LocParties { get; set; }

        [Display(Name = "Data Rentention")]
        [StringLength(50)]
        public String? DataRetention { get; set; }

        [Display(Name = "Controller Contact Information")]
        [StringLength(100)]
        public String? CtrContactInfo { get; set; }

        [Display(Name = "Controllecr's representative & DPO Contact Information")]
        [StringLength(100)]
        public String? CtrRepInfo { get; set; }

        [Display(Name = "Joint Controller Contact Information")]
        [StringLength(100)]
        public String? CtrJoinInfo { get; set; }

        [Display(Name = "Processor's Representative & DPO Contact Information")]
        [StringLength(100)]
        public String? CtrProcInfo { get; set; }

        [Display(Name = "Legal Basic for Processing")]
        [StringLength(100)]
        public String? LegalBasic { get; set; }


    }

    public class ProcessType : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Process Type Name")]
        [StringLength(100, ErrorMessage = "Process Type Name cannot be longer than 100 characters.")]
        public String ProcTypeName { get; set; }

        public String? Description { get; set; }
    }

    public class ProcessPurpose : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Process Purpose Name")]
        [StringLength(200, ErrorMessage = "Process Purpose Name cannot be longer than 200 characters.")]
        public String ProcPurposeName { get; set; }

        public String? Description { get; set; }
    }

}
