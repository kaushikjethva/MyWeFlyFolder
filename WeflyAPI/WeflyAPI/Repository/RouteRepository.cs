using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeflyAPI.Models;
using Microsoft.EntityFrameworkCore;
using WeflyAPI.Infrastructure;

namespace WeflyAPI.Repository
{
    public class RouteRepository : IRouteRepository
    {
        private clsWeflyDbContext dbContext;

        public RouteRepository(clsWeflyDbContext _db)
        {
            this.dbContext = _db;
        }

        public IEnumerable<clsRouteDetails> GetRouteDetails(string fromCity, string toCity)
        {
            List<clsRouteDetails> lstrouteDetails = new List<clsRouteDetails>();
            var route = dbContext.tblFlightRoute.Where(x => (x.fromCityCode == fromCity && x.toCityCode == toCity));
            if (route != null)
            {
                foreach (var itemRoute in route.AsEnumerable())
                {
                    var schedule = dbContext.tblFlightSchedule.Where(x => x.routeId == itemRoute.Id).ToList();
                    if (schedule != null && schedule.Count() > 0)
                    {
                        foreach (var item in schedule.AsEnumerable())
                        {
                            var planespecification = dbContext.tblPlaneSpecification.Where(x => x.Id == schedule[0].planeId).ToList();

                            if (planespecification != null && planespecification.Count() > 0)
                            {
                                clsRouteDetails routeDetails = new clsRouteDetails();
                                routeDetails.routeId = item.routeId;
                                routeDetails.fromCityCode = itemRoute.fromCityCode;
                                routeDetails.fromCityName = itemRoute.fromCityName;
                                routeDetails.toCityCode = itemRoute.toCityCode;
                                routeDetails.toCityName = itemRoute.toCityName;
                                routeDetails.scheduleId = item.Id;
                                routeDetails.arrivalTimeSource = item.arrivalTimeSource;
                                routeDetails.departTimeSource = item.departTimeSource;
                                routeDetails.arrivalTimeDestination = item.arrivalTimeDestination;
                                routeDetails.noOfStops = item.noOfStops;
                                routeDetails.flightPrice = item.flightPrice;
                                routeDetails.availableSeats = item.availableSeats;
                                routeDetails.flightDuration = item.flightDuration;
                                routeDetails.isMealAvailable = item.isMealAvailable;
                                routeDetails.airlineName = item.airlineName;
                                routeDetails.airlineLogo = item.airlineLogo;
                                routeDetails.planeId = item.planeId;
                                routeDetails.planeManufacturer = planespecification[0].planeManufacturer;
                                routeDetails.planeModel = planespecification[0].planeModel;
                                routeDetails.seats = planespecification[0].seats;
                                routeDetails.legSpace = planespecification[0].legSpace;
                                routeDetails.isWifiAvailable = planespecification[0].isWifiAvailable;
                                routeDetails.isFlightEntertainmentAvailable = planespecification[0].isFlightEntertainmentAvailable;
                                lstrouteDetails.Add(routeDetails);
                            }
                        }
                    }
                }
            }
            return lstrouteDetails;
        }
    }
}
