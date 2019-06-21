using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeflyAPI.Models
{
    public class clsFlightSchedule : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("scheduleId")]
        public override string Id { get; set; }
        public string routeId { get; set; }
        public string planeId { get; set; }
        public DateTime arrivalTimeSource { get; set; }
        public DateTime departTimeSource { get; set; }
        public DateTime arrivalTimeDestination { get; set; }
        public int noOfStops { get; set; }
        public long flightPrice { get; set; }
        public int availableSeats { get; set; }
        public long flightDuration { get; set; }
        public bool isMealAvailable { get; set; }
        public string airlineName { get; set; }
        public string airlineLogo { get; set; }
    }
}
