using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeflyAPI.Repository;
using WeflyAPI.Models;

namespace WeflyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeflyRouteController : ControllerBase
    {
        private IRouteRepository routeRepo;

        public WeflyRouteController(IRouteRepository _routeRepo)
        {
            this.routeRepo = _routeRepo;
        }

        [HttpGet("GetRoute")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<clsRouteDetails>> GetRoute(string fromCity, string toCity)
        {
            return routeRepo.GetRouteDetails(fromCity, toCity).ToList();
        }
    }
}