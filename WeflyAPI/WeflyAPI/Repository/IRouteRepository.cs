using WeflyAPI.Models;
using System.Collections.Generic;

namespace WeflyAPI.Repository
{
    public interface IRouteRepository
    {
        IEnumerable<clsRouteDetails> GetRouteDetails(string fromCity, string toCity);
    }
}
