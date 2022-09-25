

using Application.Interface;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

using System.Security.Claims;

namespace Persistence.JwtAuthentication
{
    public class JwtTokenService : IJwtTokenService
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public JwtTokenService(IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
        }
        public AccessToken CreateJwt(User user)
        {
                List<Claim> claims = new List<Claim>
            {
                new Claim(JwtClaims.UserName, user.UserName),
                new Claim(JwtClaims.UserType, user.Role)
            };
            var i = _configuration.GetSection("AppSettings:Token").Value.ToString();

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return new AccessToken()
            {
                Token=jwt,  
                UserName=user.UserName,
                UserId=user.Id,
            };
        }
        public AccessToken GetCookie()
        {
            int result = 0;
            if (_httpContextAccessor.HttpContext != null)
            {


            }
            return new AccessToken()
            {
                //Token = TokenValue,
                UserId = Convert.ToInt32(_httpContextAccessor.HttpContext.User.FindFirstValue(JwtClaims.UserId)),
                UserName = _httpContextAccessor.HttpContext.User.FindFirstValue(JwtClaims.UserName).ToString(),
                UserType = Convert.ToInt32(_httpContextAccessor.HttpContext.User.FindFirstValue(JwtClaims.UserType)),
                IssuedOn = Convert.ToDateTime(_httpContextAccessor.HttpContext.User.FindFirstValue(JwtClaims.IssuedOn)),
                ExpiresOn = Convert.ToDateTime(_httpContextAccessor.HttpContext.User.FindFirstValue(JwtClaims.ExpiresOn))
            };
        }




    }
}
