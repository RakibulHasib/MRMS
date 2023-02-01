using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MRMS.Model.ForwardingSection
{
    public class ForwardingIssueComment
    {
        public int ForwardingIssueCommentId { get; set; }

        [ForeignKey("ForwardingIssue")]
        public int ForwardingIssueId { get; set; }

        public string? Comment { get; set; }

        //Navigation
        [JsonIgnore]
        public virtual ForwardingIssue? ForwardingIssue { get; set; }
    }
}
