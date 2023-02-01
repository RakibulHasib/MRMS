using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MRMS.Model.ApplicantSection
{
    public class ApplicantIssueComment
    {
        public int ApplicantIssueCommentId { get; set; }

        [ForeignKey("ApplicantIssue")]
        public int ApplicantIssueId { get; set; }

        public string? Comment { get; set; }

        //Navigation
        [JsonIgnore]
        public virtual ApplicantIssue? ApplicantIssue { get; set; }
    }
}
