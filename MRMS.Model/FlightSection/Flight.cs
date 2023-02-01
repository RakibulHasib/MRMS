using MRMS.Model.VisaSection;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MRMS.Model.FlightSection
{
    public class Flight
    {
        public int FlightId { get; set; }

        [ForeignKey("Visa")]
        public int VisaId { get; set; }

        public string? AirlinesName { get; set; }

        public string? FlightNumber { get; set; }

        public string? DeparturePlace { get; set; }

        public DateTime? DepartureDate { get; set; }

        public string? ArrivalPlace { get; set; }

        public DateTime ArrivalDate { get; set; }

        public string? FlightBy { get; set; }


        //Navigation
        [JsonIgnore]
        public virtual Visa? Visa { get; set; }
        [JsonIgnore]
        public virtual ICollection<FlightFile>? FlightFiles { get; set; } = new HashSet<FlightFile>();
        [JsonIgnore]
        public virtual ICollection<FlightIssue>? FlightIssues { get; set; } = new HashSet<FlightIssue>();
    }
}

