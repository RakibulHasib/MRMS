using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using MRMS.Model.CommonSection;
using MRMS.Model.ApplicationSection;
using MRMS.Model.MedicalSection;
using MRMS.Model.CallingSection;
using MRMS.Model.ForwardingSection;
using MRMS.Model.RejectSection;

namespace MRMS.Model.ApplicantSection
{
    public class Applicant : Person
    {
        public int ApplicantId { get; set; }


        [Required(ErrorMessage = "Please enter passsport number")]
        [Display(Name = "Passsport No")]
        public string PasssportNo { get; set; } = default!;


        [Required(ErrorMessage = "Please enter passport expiry date")]
        [Column(TypeName = "date"),
        Display(Name = "Expiry Date"),
        DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        public DateTime PassportExpiry { get; set; }


        [Display(Name = "Height"), Column(TypeName = "FLOAT")]
        public decimal Height { get; set; }


        [Display(Name = "Weight"), Column(TypeName = "FLOAT")]
        public decimal Weight { get; set; } = default!;


        [StringLength(300, ErrorMessage = "Please do not enter values over 300 characters")]
        [Display(Name = "Job Experience")]
        public string? JobExperience { get; set; }


        [ForeignKey("Agent")]
        public int AgentId { get; set; }

        //Nav
        [JsonIgnore]
        public virtual Agent? Agent { get; set; }
        [JsonIgnore]
        public virtual Application? Application { get; set; }
        [JsonIgnore]
        public virtual ICollection<ApplicantFile> ApplicantFiles { get; set; } = new HashSet<ApplicantFile>();
        [JsonIgnore]
        public virtual ICollection<ApplicantIssue> ApplicantIssues { get; set; } = new HashSet<ApplicantIssue>();
        [JsonIgnore]
        public virtual MedicalRecord? MedicalRecord { get; set; }
        [JsonIgnore]
        public virtual Calling? Calling { get; set; }
        [JsonIgnore]
        public virtual Training? Training { get; set; }
        [JsonIgnore]
        public virtual RejectedApplicant? RejectedApplicant { get; set; }

    }
}
