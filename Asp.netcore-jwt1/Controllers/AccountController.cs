
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthendicationJWTToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        [Route("Login")]
        //allow user can access this method 
        [AllowAnonymous]
        public IActionResult Login([FromForm]AuthendicationRequest authendicationRequest)
        {
         //create the object of jwt authendication manager
         var jwtAuthenticationManager = new JwtAuthenticationManager();
         var authResult = jwtAuthenticationManager.Authenticate(authendicationRequest.UserName, authendicationRequest.Password);
            if (authResult == null)
                return Unauthorized();
            else 
                return Ok(authResult);
        }
    }
}
