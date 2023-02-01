using MRMS.Model.CommonSection;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MRMS.Model.ApplicantSection
{
    public class ApplicantIssue
    {
        public int ApplicantIssueId { get; set; }

        [ForeignKey("Applicant")]
        public int ApplicantId { get; set; }


        [Required(ErrorMessage = "Please enter title name")]
        [StringLength(150, ErrorMessage = "Please do not enter values over 150 characters")]
        [Display(Name = "Title")]
        public string Title { get; set; } = default!;


        [Display(Name = "Description")]
        public string? Description { get; set; }


        [EnumDataType(typeof(IssueStatus))]
        public IssueStatus Status { get; set; }


        [Required(ErrorMessage = "Please enter issue date")]
        [Column(TypeName = "date"),
        Display(Name = "Issue Date"),
        DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        public DateTime IssueDate { get; set; }


        [Column(TypeName = "date"),
        Display(Name = "Resolve Date"),
        DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        public DateTime? ResolveDate { get; set; }

        //Navigation
        [JsonIgnore]
        public Applicant? Applicant { get; set; }
        [JsonIgnore]
        public ICollection<ApplicantIssueComment>? ApplicantIssueComments { get; set; } = new HashSet<ApplicantIssueComment>();
    }
}
