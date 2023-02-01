using MRMS.Model.DemandSection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MRMS.Model.ApplicationSection
{
    public class ApplicationIssueComment
    {
        public int ApplicationIssueCommentId { get; set; }

        [ForeignKey("ApplicationIssue")]
        public int ApplicationIssueId { get; set; }

        public string? Comment { get; set; }


        //Navigation
        [JsonIgnore]
        public virtual ApplicationIssue? ApplicationIssue { get; set; }
    }
}
