using MRMS.Model.CommonSection;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MRMS.Model.ForwardingSection
{
    public class BMET
    {
        public int BMETId { get; set; }

        [ForeignKey("Forwarding")]
        public int ForwardingId { get; set; }

        public Status Status { get; set; }

        //Navigation
        [JsonIgnore]
        public virtual Forwarding? Forwarding { get; set; }
    }
}
