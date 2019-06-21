using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeflyAPI.Models
{
    public class clsRouteDetails
    {
        public string routeId { get; set; }
        public string fromCityCode { get; set; }
        public string fromCityName { get; set; }
        public string toCityCode { get; set; }
        public string toCityName { get; set; }
        public string scheduleId { get; set; }
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
        public string planeId { get; set; }
        public string planeManufacturer { get; set; }
        public string planeModel { get; set; }
        public int seats { get; set; }
        public long legSpace { get; set; }
        public bool isWifiAvailable { get; set; }
        public bool isFlightEntertainmentAvailable { get; set; }
    }
}
