using AuthendicationJWTToken.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthendicationJWTToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromForm]AuthendicationRequest authendicationRequest)
        {
         //create the object of jwt authendication manager
         var jwtAuthenticationManager = new JwtAuthenticationManager();
         var authResult = jwtAuthenticationManager.Authenticate(authendicationRequest.UserName, authendicationRequest.Password);
         return Ok(authResult);
        }
    }
}
