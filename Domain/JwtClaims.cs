using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class JwtClaims
    {
        public const string UserId = "UserId";
        public const string UserName = "UserName";
        public const string Propic = "Propic";
        public const string UserType = "UserType";
        public const string UserTypeName = "UserTypeName";
        public const string ExpiresOn = "ExpiresOn";
        public const string IssuedOn = "IssuedOn";
        public const string Role = "Role";
    }
}
