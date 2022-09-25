using Application.Interface;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistence.Context;
using Persistence.SystemService;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        ApplicationDbContext _context;
        IJwtTokenService _jwtTokenService;
        
        public UserController(ApplicationDbContext context, IJwtTokenService jwtTokenService)
        {
            _context = context;
            _jwtTokenService = jwtTokenService;
        }

        [HttpPost("LogIn")]
        public ActionResult<AccessToken> TestAction(LogIn logIn)
        {
            User user = _context.Users.FirstOrDefault(c => c.UserName == logIn.UserName );

            if(user == null || user.UserName != logIn.UserName)
            {
                return NotFound("User not found");
            }
            

            if (!Helper.IsVerified(logIn.Password,user.Password,user.SystemPassword))
            {
                return BadRequest("Incorrect Password");
            }



   

            AccessToken token = _jwtTokenService.CreateJwt(user);

            return Ok(token.Token);

        }
        [HttpGet("TestAction1"),Authorize]
        public ActionResult<AccessToken> TestAction1()
        {
            var i = _jwtTokenService.GetCookie();

            //var i= _jwtTokenService.CreateJwt(accessToken);

            return Ok(i);

        }
    }
}
