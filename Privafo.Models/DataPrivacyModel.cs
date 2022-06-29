using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Privafo.Models
{
    public class PrivacyRequest : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        [StringLength(150, ErrorMessage = "Full Name cannot be longer than 150 characters.")]
        public String RequestorName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [StringLength(200, ErrorMessage = "Email cannot be longer than 200 characters.")]
        public String Email { get; set; }

        [Display(Name = "Company")]
        [StringLength(200, ErrorMessage = "Company cannot be longer than 200 characters.")]
        public String? Company { get; set; }

        [ValidateNever]
        [Display(Name = "Location")]
        public int? BranchID { get; set; }
        [ForeignKey("BranchID")]
        [ValidateNever]
        public Branch? Branch { get; set; }

        [ValidateNever]
        [Display(Name = "Country")]
        public int? CountryID { get; set; }
        [ForeignKey("CountryID")]
        [ValidateNever]
        public Country? Country { get; set; }

        [ValidateNever]
        [Required]
        [Display(Name = "Subject Type")]
        public int SubjectTypeID { get; set; }
        [ForeignKey("SubjectTypeID")]
        [ValidateNever]
        public PrivacySubject SubjectType { get; set; }

        [ValidateNever]
        [Required]
        [Display(Name = "Request Type")]
        public int RequestTypeID { get; set; }
        [ForeignKey("RequestTypeID")]
        [ValidateNever]
        public PrivacyReqType RequestType { get; set; }

        [Required]
        [Display(Name = "Request Detail")]
        public String RequestDetail { get; set; }

        public DateTime? Deadline { get; set; }

        [Display(Name = "Completion Date")]
        public DateTime? CompletionDate { get; set; }

        [Display(Name = "Resolution")]
        public String? Resolution { get; set; }
    }

    public class PrivacySubject : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Subject Type Name")]
        [StringLength(100, ErrorMessage = "Subject Type Name cannot be longer than 100 characters.")]
        public String SubjectTypeName { get; set; }

        public String? Description { get; set; }
    }

    public class PrivacyReqType : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Request Type Name")]
        [StringLength(150, ErrorMessage = "Request Type Name cannot be longer than 150 characters.")]
        public String RequestTypeName { get; set; }

        public String? Description { get; set; }
    }

    public class PrivacyReqExtend : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ValidateNever]
        public int PrivacyReqID { get; set; }
        [ForeignKey("PrivacyReqID")]
        [ValidateNever]
        public PrivacyRequest PrivacyRequest { get; set; }

        public int ExtendedDays { get; set; }
    }

    public class PrivacyReqApprover : BaseDateEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ValidateNever]
        public int PrivacyReqID { get; set; }
        [ForeignKey("PrivacyReqID")]
        [ValidateNever]
        public PrivacyRequest PrivacyRequest { get; set; }

        [ValidateNever]
        [StringLength(450)]
        [Display(Name = "Approver")]
        public string Approver { get; set; }
        [ForeignKey("Approver")]
        [ValidateNever]
        public ApplicationUser UserApprover { get; set; }

        public Boolean Approved { get; set; } = false;
    }
}
