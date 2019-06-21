using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeFlyAuthentication_API.Models;
using WeFlyAuthentication_API.Services;

namespace WeFlyAuthentication_API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private IIdentityManager idManager;

        public IdentityController(IIdentityManager _idManager)
        {
            this.idManager = _idManager;
        }
        //Register User
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<dynamic>> Register([FromBody]clsUser user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = await idManager.AddUserAsync(user);
            return Created("", result);
        }

        //Login Token Generation
        [HttpPost("token")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<string> Token([FromBody]clsAuthenticate login)
        {
            var token = idManager.ValidateUser(login);
            if (string.IsNullOrEmpty(token))
            {
                return Unauthorized("Ivalid user and password");
            }
            return Ok(token);
        }
    }
}