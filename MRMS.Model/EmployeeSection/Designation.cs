using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MRMS.Model.EmployeeSection
{
    public class Designation
    {
        public int DesignationId { get; set; }


        [Required(ErrorMessage = "Please enter designation name")]
        [StringLength(30, ErrorMessage = "Please do not enter values over 30 characters")]
        [Display(Name = "Designation")]
        public string Name { get; set; } = default!;

        //navigation
        [JsonIgnore]
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
