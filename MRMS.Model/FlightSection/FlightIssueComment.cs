using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MRMS.Model.FlightSection
{
    public class FlightIssueComment
    {
        public int FlightIssueCommentId { get; set; }

        [ForeignKey("FlightIssue")]
        public int FlightIssueId { get; set; }

        public string? Comment { get; set; }


        //Navigation
        [JsonIgnore]
        public virtual FlightIssue? FlightIssue { get; set; }
    }
}
