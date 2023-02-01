using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MRMS.Model.CommonSection
{
    public abstract class Person{

        [Required(ErrorMessage = "Please enter applicant name")]
        [StringLength(50, ErrorMessage = "Please do not enter values over 50 characters")]
        [Display(Name = "Applicant Name")]
        public string Name { get; set; } = default!;


        [Required(ErrorMessage = "Please enter father name")]
        [StringLength(50, ErrorMessage = "Please do not enter values over 50 characters")]
        [Display(Name = "Father Name")]
        public string FathersName { get; set; } = default!;


        [Required(ErrorMessage = "Please enter mother name")]
        [StringLength(50, ErrorMessage = "Please do not enter values over 50 characters")]
        [Display(Name = "Mother Name")]
        public string MothersName { get; set; } = default!;


        [StringLength(50, ErrorMessage = "Please do not enter values over 50 characters")]
        [Display(Name = "Spouse")]
        public string? Spouse { get; set; }


        [StringLength(200, ErrorMessage = "Please do not enter values over 200 characters")]
        [Display(Name = "Present Address")]
        public string? PresentAddress { get; set; }


        [StringLength(200, ErrorMessage = "Please do not enter values over 200 characters")]
        [Display(Name = "Permanent Address")]
        public string? PermanentAddress { get; set; }


        [Required(ErrorMessage = "Please enter date of birth")]
        [Column(TypeName = "date"),
        Display(Name = "Date Of Birth"),
        DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        public DateTime DateOfBrith { get; set; }


        [Required(ErrorMessage = "Please enter phone number")]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; } = default!;


        [Required(ErrorMessage = "Please enter NID No")]
        [Display(Name = "NID NO")]
        public string? NID { get; set; }


        [Required(ErrorMessage = "Please enter birth certificate no")]
        [Display(Name = "Birth Certificate")]
        public string? BirthCertificateNo { get; set; }


        [Required(ErrorMessage = "Please enter email")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email format is not valid.")]
        [Display(Name = "Email")]
        public string? Email { get; set; }


        [Required(ErrorMessage = "Please enter nationality")]
        [StringLength(50, ErrorMessage = "Please do not enter values over 50 characters")]
        [Display(Name = "Nationality")]
        public string Nationality { get; set; } = default!;


        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }


        [EnumDataType(typeof(Religion))]
        public Religion Religion { get; set; }


        [EnumDataType(typeof(MaritalStatus))]
        public MaritalStatus MaritalStatus { get; set; }

        [Display(Name = "Image")]
        public string? Picture { get; set; }


        [EnumDataType(typeof(Education))]
        public Education Education { get; set; }
    }
}