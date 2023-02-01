using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using JsonIgnoreAttribute = System.Text.Json.Serialization.JsonIgnoreAttribute;
using MRMS.Model.CommonSection;
using MRMS.Model.MedicalSection;

namespace MRMS.Model.DemandSection
{
    public class Demand
    {
        public int DemandId { get; set; }


        [Required(ErrorMessage = "Please enter demand title")]
        [StringLength(100, ErrorMessage = "Please do not enter values over 100 characters")]
        [Display(Name = "Demand Title")]
        public string Title { get; set; } = default!;


        [Required(ErrorMessage = "Please enter demand expiry date")]
        [Column(TypeName = "date"),
        Display(Name = "Expiry Date"),
        DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        public DateTime DemandExpiryDate { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }

        //Navigation
        [JsonIgnore]
        public virtual Company? Company { get; set; }
        [JsonIgnore]
        public virtual ICollection<Trade> Trades { get; set; } = new HashSet<Trade>();
        [JsonIgnore]
        public virtual ICollection<DemandFile> DemandFiles { get; set; } = new HashSet<DemandFile>();
        [JsonIgnore]
        public virtual ICollection<DemandIssue> DemandIssues { get; set; } = new HashSet<DemandIssue>();
        [JsonIgnore]
        public virtual ICollection<MedicalRecord> MedicalRecords { get; set; } = new HashSet<MedicalRecord>();
    }
}
