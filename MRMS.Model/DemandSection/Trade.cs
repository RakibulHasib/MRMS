using MRMS.Model.ApplicationSection;
using MRMS.Model.CallingSection;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MRMS.Model.DemandSection
{
    public class Trade
    {
        public int TradeId { get; set; }


        [Required(ErrorMessage = "Please enter JobTitle")]
        [StringLength(150, ErrorMessage = "Please do not enter values over 150 characters")]
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; } = default!;


        [Required(ErrorMessage = "Please enter male quota"), MaxLength(5)]
        [Display(Name = "Male Quota")]
        public int MaleQuota { get; set; }


        [Required(ErrorMessage = "Please enter female quota"), MaxLength(5)]
        [Display(Name = "Female Quota")]
        public int FemaleQuota { get; set; }


        [Required(ErrorMessage = "Please enter age"), MaxLength(3)]
        [Display(Name = "Age")]
        public int Age { get; set; }


        [Column(TypeName = "money")]
        [Display(Name = "Salary")]
        public decimal Salary { get; set; }


        public char? Currency { get; set; }


        [Required(ErrorMessage = "Please enter working hours"), MaxLength(2)]
        [Display(Name = "Working Hours")]
        public int WorkingHours { get; set; }


        [Required(ErrorMessage = "Please enter over time"), MaxLength(2)]
        [Display(Name = "Working Hours")]
        public int OverTime { get; set; }


        [Required(ErrorMessage = "Please enter food info")]   //*****
        [StringLength(50, ErrorMessage = "Please do not enter values over 50 characters")]
        [Display(Name = "Food")]
        public string Food { get; set; } = default!;


        [Required(ErrorMessage = "Please enter accomodation info")]
        [StringLength(50, ErrorMessage = "Please do not enter values over 50 characters")]
        [Display(Name = "Accomodation")]
        public string Accomodation { get; set; } = default!;


        [Required(ErrorMessage = "Please enter contract period")]
        [StringLength(30, ErrorMessage = "Please do not enter values over 30 characters")]
        [Display(Name = "Contract Period")]
        public string ContractPeriod { get; set; } = default!;


        [ForeignKey("Demand")]
        public int DemandId { get; set; }


        //Navigation
        [JsonIgnore]
        public virtual Demand? Demand { get; set; }
        [JsonIgnore]
        public virtual ICollection<Application>? Applications { get; set; } = new HashSet<Application>();
        [JsonIgnore]
        public virtual ICollection<Calling>? Callings { get; set; } = new HashSet<Calling>();
    }
}
