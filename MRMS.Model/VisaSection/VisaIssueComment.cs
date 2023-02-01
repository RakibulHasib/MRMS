using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MRMS.Model.VisaSection
{
    public class VisaIssueComment
    {
        public int VisaIssueCommentId { get; set; }

        [ForeignKey("VisaIssue")]
        public int VisaIssueId { get; set; }

        public string? Comment { get; set; }


        //Navigation
        [JsonIgnore]
        public virtual VisaIssue? VisaIssue { get; set; }
    }
}
