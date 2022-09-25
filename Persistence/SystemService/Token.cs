using Application.Interface;
using Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.SystemService
{
    public class Token : IToken
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public Token(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public AccessToken GetCookie()
        {
            int result = 0;
            if (_httpContextAccessor.HttpContext != null)
            {


            }
            var i=(_httpContextAccessor.HttpContext.User.FindFirst(JwtClaims.UserName)).ToString();
            return new AccessToken()
            {
                //Token = TokenValue,
                UserId = Convert.ToInt32(_httpContextAccessor.HttpContext.User.FindFirst
                (JwtClaims.UserId)),
                UserName = (_httpContextAccessor.HttpContext.User.FindFirst(JwtClaims.UserName)).ToString(),
                UserType = Convert.ToInt32(_httpContextAccessor.HttpContext.User.FindFirst(JwtClaims.UserType)),
                IssuedOn = Convert.ToDateTime(_httpContextAccessor.HttpContext.User.FindFirst(JwtClaims.IssuedOn)),
                ExpiresOn = Convert.ToDateTime(_httpContextAccessor.HttpContext.User.FindFirst(JwtClaims.ExpiresOn))
            };
        }
    }
}
