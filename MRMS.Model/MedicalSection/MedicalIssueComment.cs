using System.ComponentModel.DataAnnotations.Schema;

namespace MRMS.Model.MedicalSection
{
    public class MedicalIssueComment
    {
        public int MedicalIssueCommentId { get; set; }

        [ForeignKey("MedicalIssue")]
        public int MedicalIssueId { get; set; }

        public string? Comment { get; set; }

        //Navigation
        public virtual MedicalIssue? MedicalIssue { get; set; }
    }
}
