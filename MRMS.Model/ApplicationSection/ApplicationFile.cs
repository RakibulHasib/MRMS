using MRMS.Model.CommonSection;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MRMS.Model.ApplicationSection
{
    public class ApplicationFile
    {
        public int ApplicationFileId { get; set; }

        [ForeignKey("Application")]
        public int ApplicationId { get; set; }

        [ForeignKey("FileType")]
        public int FileTypeId { get; set; }

        [Display(Name = "Description")]
        public string? Description { get; set; }

        public string? Filepath { get; set; }

        [Column(TypeName = "date"),
        Display(Name = "Date"),
        DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }


        //Navigation
        [JsonIgnore]
        public virtual FileType? FileType { get; set; }
        [JsonIgnore]
        public virtual Application? Application { get; set; }
    }
}

