using MRMS.Model.AgencySection;
using MRMS.Model.ApplicantSection;
using MRMS.Model.CommonSection;
using MRMS.Model.DemandSection;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MRMS.Model.MedicalSection
{
    public class MedicalRecord
    {
        public int MedicalRecordId { get; set; }

        [ForeignKey("Demand")]
        public int DemandId { get; set; }

        [ForeignKey("Applicant")]
        public int ApplicantId { get; set; }

        [ForeignKey("MedicalCenter")]
        public int MedicalCenterId { get; set; }

        [ForeignKey("AgencySyndicate")]
        public int AgencySyndicateId { get; set; }

        [EnumDataType(typeof(MedicalStatus))]
        public MedicalStatus MedicalStatus { get; set; }


        [Required(ErrorMessage = "Please enter slip issue date")]
        [Column(TypeName = "date"),
        Display(Name = "Slip Issue Date"),
        DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        public DateTime SlipIssueDate { get; set; }


        [Required(ErrorMessage = "Please enter medical date")]
        [Column(TypeName = "date"),
        Display(Name = "Medical Date"),
        DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        public DateTime MedicalDate { get; set; }


        [Required(ErrorMessage = "Please enter expiry date")]
        [Column(TypeName = "date"),
        Display(Name = "Expiry Date"),
        DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        public DateTime ExpiryDate { get; set; }


        //Navigation
        [JsonIgnore]
        public virtual Demand? Demand { get; set; }
        [JsonIgnore]
        public virtual Applicant? Applicant { get; set; }
        [JsonIgnore]
        public virtual MedicalCenter? MedicalCenter { get; set; }
        [JsonIgnore]
        public virtual AgencySyndicate? AgencySyndicate { get; set; }
        [JsonIgnore]
        public virtual ICollection<MedicalIssue>? MedicalIssues { get; set; } = new List<MedicalIssue>();
        [JsonIgnore]
        public virtual ICollection<MedicalFile>? MedicalFiles { get; set; } = new List<MedicalFile>();
    }
}

