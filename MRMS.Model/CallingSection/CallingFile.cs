using MRMS.Model.CommonSection;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace MRMS.Model.CallingSection
{
    public class CallingFile
    {
        public int CallingFileId { get; set; }

        [ForeignKey("Calling")]
        public int CallingId { get; set; }

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
        public virtual Calling? Calling { get; set; }
    }
}
