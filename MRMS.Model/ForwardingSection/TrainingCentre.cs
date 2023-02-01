using System.Text.Json.Serialization;

namespace MRMS.Model.ForwardingSection
{
    public class TrainingCentre
    {
        public int TrainingCentreId { get; set; }

        public string Name { get; set; } = default!;

        public string Address { get; set; } = default!;

        public string? Email { get; set; }

        public string Phone { get; set; } = default!;

        //Navigation
        [JsonIgnore]
        public virtual ICollection<Training>? Training { get; set; }

    }
}
