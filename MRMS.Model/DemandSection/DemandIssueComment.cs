using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MRMS.Model.DemandSection
{
    public class DemandIssueComment
    {
        public int DemandIssueCommentId { get; set; }

        [ForeignKey("DemandIssue")]
        public int DemandIssueId { get; set; }

        public string? Comment { get; set; }


        //Navigation
        [JsonIgnore]
        public virtual DemandIssue? Issue { get; set; }
    }
}
