using MRMS.Model.CommonSection;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MRMS.Model.ApplicationSection
{
    public class ApplicationFileTransfer
    {
        public int ApplicationFileTransferId { get; set; }

        [ForeignKey("Application")]
        public int ApplicationId { get; set; }

        [ForeignKey("FileType")]
        public int FileTypeId { get; set; }

        [Column(TypeName = "date"),
        Display(Name = "Transfer Date"),
        DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        public DateTime TransferDate { get; set; }

        [StringLength(50, ErrorMessage = "Please do not enter values over 50 characters")]
        [Display(Name = "From")]
        public string? From { get; set; }

        [StringLength(50, ErrorMessage = "Please do not enter values over 50 characters")]
        [Display(Name = "To")]
        public string? To { get; set; }

        [StringLength(250, ErrorMessage = "Please do not enter values over 250 characters")]
        [Display(Name = "Note")]
        public string? Note { get; set; }

        //Navigation
        [JsonIgnore]
        public virtual Application? Application { get; set; }
        [JsonIgnore]
        public virtual FileType? FileType { get; set; }
    }
}
