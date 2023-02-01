using MRMS.Model.AgencySection;
using MRMS.Model.ApplicantSection;
using MRMS.Model.DemandSection;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MRMS.Model.ApplicationSection
{
    public class Application
    {
        public int ApplicationId { get; set; }

        [ForeignKey("Trade")]
        public int TradeId { get; set; }

        [ForeignKey("Applicant")]
        public int ApplicantId { get; set; }

        [ForeignKey("Agency")]
        public int AgencyId { get; set; }

        public DateTime ApplicationDate { get; set; }

        public string? Status { get; set; }


        //Navigation
        [JsonIgnore]
        public virtual Trade? Trade { get; set; }
        [JsonIgnore]
        public virtual Applicant? Applicant { get; set; }
        [JsonIgnore]
        public virtual Agency? Agency { get; set; }
        [JsonIgnore]
        public virtual ICollection<ApplicationFile>? ApplicationFiles { get; set; } = new HashSet<ApplicationFile>();
        [JsonIgnore]
        public virtual ICollection<ApplicationIssue>? ApplicantIssues { get; set; } = new HashSet<ApplicationIssue>();
        [JsonIgnore]
        public virtual ICollection<ApplicationFileTransfer>? ApplicationFileTransfers { get; set; } = new HashSet<ApplicationFileTransfer>();


    }
}
