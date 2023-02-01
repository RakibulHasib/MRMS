using MRMS.Model.ApplicantSection;
using MRMS.Model.FlightSection;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MRMS.Model.VisaSection
{
    public class Visa
    {
        public int VisaId { get; set; }

        public string VisaNumber { get; set; } = default!;

        public string RefNumber { get; set; } = default!;

        [ForeignKey("Applicant")]
        public int ApplicantId { get; set; } = default!;

        public DateTime IssueDate { get; set; }

        public DateTime ExpiryDate { get; set; }


        //Navigation
        [JsonIgnore]
        public virtual Applicant? Applicant { get; set; }
        [JsonIgnore]
        public virtual ICollection<VisaFile>? VisaFiles { get; set; } = new HashSet<VisaFile>();
        [JsonIgnore]
        public virtual ICollection<VisaFileTransfer>? VisaFileTransfers { get; set; } = new HashSet<VisaFileTransfer>();
        [JsonIgnore]
        public virtual ICollection<VisaIssue>? VisaIssues { get; set; } = new HashSet<VisaIssue>();
        [JsonIgnore]
        public virtual Flight? Flight { get; set; }
    }
}
