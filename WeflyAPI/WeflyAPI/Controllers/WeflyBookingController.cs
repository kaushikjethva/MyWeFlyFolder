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
    public class WeflyBookingController : ControllerBase
    {
        private IBookingRepository bookingRepo;

        public WeflyBookingController(IBookingRepository _bookingRepo)
        {
            this.bookingRepo = _bookingRepo;
        }

        [HttpPost("saveBookingDetails")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<clsBookingDetails> saveBookingDetailsRoute([FromBody]clsBookingDetails clsBookingDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                var result = bookingRepo.saveBookingDetails(clsBookingDetails);
                return Created("", result);
            }
        }
    }
}