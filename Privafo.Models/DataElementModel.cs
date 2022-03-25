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
    public class DataElement : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Active Status Name")]
        [StringLength(100, ErrorMessage = "Active Status Name cannot be longer than 100 characters.")]
        public String DataElementName { get; set; }

        public String? Description { get; set; }

        [ValidateNever]
        [Required]
        [Display(Name = "Data Category")]
        public int DteCtgID { get; set; }
        [ForeignKey("DteCtgID")]
        [ValidateNever]
        public DteCategory DteCategory { get; set; }
    }

    public class DteCategory : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Category Name")]
        [StringLength(100, ErrorMessage = "Category Name cannot be longer than 100 characters.")]
        public String DteCtgName { get; set; }
        public String? Description { get; set; }
    }

    public class DataSubject : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Data Subject Name")]
        [StringLength(100, ErrorMessage = "Data Subject Name cannot be longer than 100 characters.")]
        public String DataSubjectName { get; set; }
        public String? Description { get; set; }
    }

    public class DteDataSubject : BaseDateEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ValidateNever]
        public int DteID { get; set; }
        [ForeignKey("DteID")]
        [ValidateNever]
        public DataElement DataElement { get; set; }

        [Required]
        [ValidateNever]
        public int DataSubjectID { get; set; }
        [ForeignKey("DataSubjectID")]
        [ValidateNever]
        public DataSubject DataSubject { get; set; }
    }

    public class DteSource : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Data Source Name")]
        [StringLength(100, ErrorMessage = "Data Source Name cannot be longer than 100 characters.")]
        public String DteSourceName { get; set; }
        public String? Description { get; set; }
    }

    public class DteTransfer : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Transfer Mode Name")]
        [StringLength(100, ErrorMessage = "Transfer Mode Name cannot be longer than 100 characters.")]
        public String DteTransferName { get; set; }
        public String? Description { get; set; }
    }

    public class DteVolume : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Volume Category Name")]
        [StringLength(100, ErrorMessage = "Volume Category Name cannot be longer than 100 characters.")]
        public String DteVolumeName { get; set; }

        [Required]
        [Display(Name = "Minimum Volume")]
        [Range(0, 100, ErrorMessage = "Minimum must between 0 and 100 only.")]
        public Double MinVol { get; set; }

        [Required]
        [Display(Name = "Maximum Volume")]
        [Range(0, 100, ErrorMessage = "Maximum Volume must between 0 and 100 only.")]
        public Double MaxVol { get; set; }
    }

    public class DteAsset : BaseDateEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ValidateNever]
        public int DteID { get; set; }
        [ForeignKey("DteID")]
        [ValidateNever]
        public DataElement DataElement { get; set; }

        [Required]
        [ValidateNever]
        public int AssetID { get; set; }
        [ForeignKey("AssetID")]
        [ValidateNever]
        public Asset Asset { get; set; }
    }

    public class DteProcess : BaseDateEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ValidateNever]
        public int DteID { get; set; }
        [ForeignKey("DteID")]
        [ValidateNever]
        public DataElement DataElement { get; set; }

        [Required]
        [ValidateNever]
        public int AssetID { get; set; }
        [ForeignKey("AssetID")]
        [ValidateNever]
        public Asset Asset { get; set; }
    }

    public class DteVendor : BaseDateEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ValidateNever]
        public int DteID { get; set; }
        [ForeignKey("DteID")]
        [ValidateNever]
        public DataElement DataElement { get; set; }

        [Required]
        [ValidateNever]
        public int vendorID { get; set; }
        [ForeignKey("vendorID")]
        [ValidateNever]
        public Vendor Vendor { get; set; }
    }

}
