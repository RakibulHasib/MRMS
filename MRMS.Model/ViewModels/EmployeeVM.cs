using System.ComponentModel.DataAnnotations;
using MRMS.Model.CommonSection;
using Microsoft.AspNetCore.Http;

namespace MRMS_Final_Project.ViewModels
{
    public class EmployeeVM
    {
        public int EmployeeId { get; set; }
        public int DesignationId { get; set; }
        public string Name { get; set; } = default!;
        public string FathersName { get; set; } = default!;
        public string MothersName { get; set; } = default!;
        public string? Spouse { get; set; }
        public string? PresentAddress { get; set; }
        public string? PermanentAddress { get; set; }
        public DateTime DateOfBrith { get; set; }
        public string PhoneNumber { get; set; } = default!;
        public string? NID { get; set; }
        public string? BirthCertificateNo { get; set; }

        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email format is not valid.")]
        public string? Email { get; set; }
        public string Nationality { get; set; } = default!;
        public Gender Gender { get; set; }
        public Religion Religion { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public IFormFile Image { get; set; } = default!;
        public string? Picture { get; set; }
        public Education Education { get; set; }
    }
}
