using MRMS.Model.ApplicationSection;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MRMS.Model.AgencySection
{
    public class Agency
    {
        public int AgencyId { get; set; }


        [Required(ErrorMessage = "Please enter agent name")]
        [StringLength(50, ErrorMessage = "Please do not enter values over 50 characters")]
        [Display(Name = "Name")]
        public string Name { get; set; } = default!;

        [Required(ErrorMessage = "Please enter Recruiting License No")]
        [StringLength(10, ErrorMessage = "Please do not enter values over 10 characters")]
        [Display(Name = "RL No")]
        public string RL { get; set; } = default!;


        [Required(ErrorMessage = "Please enter address")]
        [StringLength(250, ErrorMessage = "Please do not enter values over 250 characters")]
        [Display(Name = "Address")]
        public string Address { get; set; } = default!;


        [Required(ErrorMessage = "Please enter contact no")]
        [Display(Name = "Contact No")]
        public string ContactNo { get; set; } = default!;


        [StringLength(50, ErrorMessage = "Please do not enter values over 50 characters")]
        [Display(Name = "Manager")]
        public string? Manager { get; set; }


        [StringLength(50, ErrorMessage = "Please do not enter values over 50 characters")]
        [Display(Name = "Accountant")]
        public string? Accountant { get; set; }

        //Navigation
        [JsonIgnore]
        public virtual AgencySyndicate? AgencySyndicate { get; set; }
        [JsonIgnore]
        public virtual ICollection<Application>? Applications { get; set; } = new HashSet<Application>();
    }
}
