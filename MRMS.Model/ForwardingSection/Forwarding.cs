using MRMS.Model.ApplicantSection;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MRMS.Model.ForwardingSection
{
    public class Forwarding
    {
        public int ForwardingId { get; set; }

        [ForeignKey("Applicant")]
        public int ApplicantId { get; set; }


        //Navigation
        [JsonIgnore]
        public virtual Applicant? Applicant { get; set; }
        [JsonIgnore]
        public virtual ICollection<ForwardingFile>? ForwardingFiles { get; set; } = new HashSet<ForwardingFile>();
        [JsonIgnore]
        public virtual ICollection<ForwardingFileTransfer>? ForwardingFileTransfers { get; set; } = new HashSet<ForwardingFileTransfer>();
        [JsonIgnore]
        public virtual ICollection<ForwardingIssue>? ForwardingIssues { get; set; } = new HashSet<ForwardingIssue>();
        [JsonIgnore]
        public virtual BMET? BMET { get; set; }
        [JsonIgnore]
        public virtual FingerPrint? FingerPrint { get; set; }
        [JsonIgnore]
        public virtual Training? Training { get; set; }
    }
}
