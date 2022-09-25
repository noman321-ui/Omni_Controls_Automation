using Application.Interface;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistence.Context;
using Persistence.JwtAuthentication;
using Persistence.SystemService;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        ApplicationDbContext _context;
        IJwtTokenService _jwtTokenService;
        private readonly IToken _token;
        public ValuesController(ApplicationDbContext context, IJwtTokenService jwtTokenService, IToken token)
        {
                _context   = context;
            _jwtTokenService = jwtTokenService;
            _token = token; 
        }
        [HttpPost("TestAction")]
        public  ActionResult<string> TestAction()
        {
            AccessToken accessToken=new AccessToken();
            accessToken.UserName = "noman";

           //var i= _jwtTokenService.CreateJwt(accessToken);

            return Ok("good");

        }
       //[Authorize]
        [HttpGet("TestAction1"),Authorize]
        public ActionResult<AccessToken> TestAction1()
        {
           var i = _jwtTokenService.GetCookie();

            //var i= _jwtTokenService.CreateJwt(accessToken);

            return Ok(i);

        }
    }
}
