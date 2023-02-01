using MRMS.Model.CommonSection;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MRMS.Model.EmployeeSection
{
    public class Employee : Person
    {
        public int EmployeeId { get; set; }


        [ForeignKey("Designation")]
        public int DesignationId { get; set; }

        //Navigation
        [JsonIgnore]
        public Designation? Designation { get; set; }
        [JsonIgnore]
        public virtual ICollection<EmployeeFile> EmployeeFiles { get; set; } = new HashSet<EmployeeFile>();
    }
}
