using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MRMS.Model.CommonSection
{
    public class Country
    {
        public int CountryId { get; set; }


        [Required(ErrorMessage = "Please enter country name")]
        [StringLength(50, ErrorMessage = "Please do not enter values over 50 characters")]
        [Display(Name = "Country")]
        public string Name { get; set; } = default!;

        //Navigation
        [JsonIgnore]
        public virtual ICollection<Company> Companies { get; set; } = new HashSet<Company>();
    }
}
