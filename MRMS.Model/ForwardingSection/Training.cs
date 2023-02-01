using MRMS.Model.CommonSection;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MRMS.Model.ForwardingSection
{
    public class Training
    {
        public int TrainingId { get; set; }

        [ForeignKey("TrainingCentre")]
        public int TrainingCentreId { get; set; }

        [ForeignKey("Forwarding")]
        public int ForwardingId { get; set; }

        public DateTime TrainingDate { get; set; }

        public Status TrainingStatus { get; set; } = default!;

        public string TrainingDuration { get; set; } = default!;


        //Navigation
        [JsonIgnore]
        public virtual TrainingCentre? TrainingCentre { get; set; }
        [JsonIgnore]
        public virtual Forwarding? Forwarding { get; set; }
    }
}
