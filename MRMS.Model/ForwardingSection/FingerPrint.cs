using MRMS.Model.CommonSection;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MRMS.Model.ForwardingSection
{
    public class FingerPrint
    {
        public int FingerPrintId { get; set; }

        [ForeignKey("Forwarding")]
        public int ForwardingId { get; set; }

        public Status FingerPrintStatus { get; set; }

        //Navigation
        [JsonIgnore]
        public virtual Forwarding? Forwarding { get; set; }

    }
}
