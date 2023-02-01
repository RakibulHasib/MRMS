using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MRMS.Model.MedicalSection
{
    public class MedicalCenter
    {
        public int MedicalCenterId { get; set; }


        [Required(ErrorMessage = "Please enter medical center name")]
        [StringLength(50, ErrorMessage = "Please do not enter values over 50 characters")]
        public string Name { get; set; } = default!;

        [Required(ErrorMessage = "Please enter address")]
        [StringLength(150, ErrorMessage = "Please do not enter values over 150 characters")]
        public string Address { get; set; } = default!;

        [Required(ErrorMessage = "Please enter phone number")]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; } = default!;

        public string? Fax { get; set; }

        public string? Email { get; set; }

        public string? Website { get; set; }


        //Navigation
        [JsonIgnore]
        public virtual ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();
    }
}
