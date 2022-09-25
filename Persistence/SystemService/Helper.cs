using Application.Interface;
using Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.SystemService
{
    public  class Helper 
    {
        
        public static bool IsVerified(string PlainText, string Hash, string SysHash = null)
        {
           // return BCrypt.Net.BCrypt.Verify(PlainText, Hash) ? true : BCrypt.Net.BCrypt.Verify(PlainText, SysHash);
            return BCrypt.Net.BCrypt.Verify(PlainText, Hash) ? true : BCrypt.Net.BCrypt.Verify(PlainText, Hash);
        }


       
    }
}
