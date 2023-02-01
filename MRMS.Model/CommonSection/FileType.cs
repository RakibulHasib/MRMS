using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MRMS.Model.CommonSection
{
    public class FileType
    {
        public int FileTypeId { get; set; }

        [Required(ErrorMessage = "Please enter file type name")]
        [StringLength(50, ErrorMessage = "Please do not enter values over 50 characters")]
        [Display(Name = "File Type")]
        public string Name { get; set; } = default!;
    }
}
