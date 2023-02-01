using MRMS.Model.DemandSection;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MRMS.Model.CommonSection
{
    public class Company
    {
        public int CompanyId { get; set; }


        [Required(ErrorMessage = "Please enter company name")]
        [StringLength(50, ErrorMessage = "Please do not enter values over 50 characters")]
        [Display(Name = "Company")]
        public string Name { get; set; } = default!;


        [Display(Name = "Company Details")]
        public string? Details { get; set; }
        [Required(ErrorMessage = "Please enter address")]
        [Display(Name = "Address")]
        public string Address { get; set; } = default!;


        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email format is not valid.")]
        [Display(Name = "Email")]
        public string? Email { get; set; }


        [Required(ErrorMessage = "Please enter phone number")]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; } = default!;


        [ForeignKey("Country")]
        public int CountryId { get; set; }


        //Navigation
        [JsonIgnore]
        public virtual Country? Country { get; set; }
        [JsonIgnore]
        public virtual ICollection<Demand> Demands { get; set; } = new HashSet<Demand>();

    }
}
