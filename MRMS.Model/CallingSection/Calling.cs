using MRMS.Model.ApplicantSection;
using MRMS.Model.CommonSection;
using MRMS.Model.DemandSection;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MRMS.Model.CallingSection
{
    public class Calling
    {
        public int CallingId { get; set; }

        [ForeignKey("Applicant")]
        public int ApplicantId { get; set; }

        [ForeignKey("Trade")]
        public int TradeId { get; set; }

        //Enum data
        public CallingStatus CallingStatus { get; set; }

        public string? CallingGroup { get; set; }

        public DateTime CallingIssueDate { get; set; }


        //Navigation
        [JsonIgnore]
        public virtual Applicant? Applicant { get; set; }
        [JsonIgnore]
        public virtual Trade? Trade { get; set; }
        [JsonIgnore]
        public virtual ICollection<CallingFile> CallingFiles { get; set; } = new List<CallingFile>();
        [JsonIgnore]
        public virtual ICollection<CallingIssue> CallingIssues { get; set; } = new List<CallingIssue>();
    }
}
