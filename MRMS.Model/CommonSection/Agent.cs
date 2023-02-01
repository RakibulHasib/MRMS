using MRMS.Model.ApplicantSection;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MRMS.Model.CommonSection
{
    public class Agent
    {
        public int AgentId { get; set; }


        [Required(ErrorMessage = "Please enter agent name")]
        [StringLength(50, ErrorMessage = "Please do not enter values over 50 characters")]
        [Display(Name = "Name")]
        public string Name { get; set; } = default!;


        [StringLength(250, ErrorMessage = "Please do not enter values over 250 characters")]
        [Display(Name = "Address")]
        public string? Address { get; set; }


        [Required(ErrorMessage = "Please enter phone number")]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; } = default!;


        [Required(ErrorMessage = "Please enter agent email")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email format is not valid.")]
        [Display(Name = "Email")]
        public string? Email { get; set; }


        //Navigation
        [JsonIgnore]
        public virtual ICollection<Applicant> Applicants { get; set; } = new HashSet<Applicant>();
    }
}
