using Microsoft.AspNetCore.Http;
using MRMS.Model.CommonSection;

namespace MRMS.Model.ViewModels
{
    public class ApplicantVM
    {
        public int ApplicantId { get; set; }
        public string PasssportNo { get; set; } = default!;
        public DateTime PassportExpiry { get; set; }
        public int AgentId { get; set; }
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
        public string? Email { get; set; }
        public string Nationality { get; set; } = default!;
        public decimal Height { get; set; }
        public decimal Weight { get; set; } = default!;
        public string? JobExperience { get; set; }
        public Gender Gender { get; set; }
        public Religion Religion { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public IFormFile Picture { get; set; } = default!;
        public Education Education { get; set; }
    }
}
