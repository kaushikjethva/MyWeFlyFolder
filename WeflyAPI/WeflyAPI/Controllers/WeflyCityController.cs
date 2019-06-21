using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeflyAPI.Repository;
using WeflyAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace WeflyAPI.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class WeflyCityController : ControllerBase
    {
        private ICityReposioty<clsCity> cityRepo;

        public WeflyCityController(ICityReposioty<clsCity> _cityRepo)
        {
            this.cityRepo = _cityRepo;
        }

        [HttpGet("GetCityById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<clsCity> GetCityById(string cityCode)
        {            
            return cityRepo.GetCity(cityCode);                            
        }

        [HttpGet("{id?}", Name = "GetCities")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<clsCity>> GetCities(string cityCode)
        {
            return cityRepo.GetCities(cityCode).ToList();
        }

    }
}