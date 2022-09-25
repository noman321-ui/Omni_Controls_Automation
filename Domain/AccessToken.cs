using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class AccessToken
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Propic { get; set; }
        public int UserType { get; set; }
        public string UserTypeName { get; set; }
        public string Token { get; set; }
        public string Password { get; set; }
        public string SysPassword { get; set; }
        public DateTime? IssuedOn { get; set; }
        public DateTime ExpiresOn { get; set; }
    }
}
