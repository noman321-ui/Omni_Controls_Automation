using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Index(nameof(UserName), IsUnique = true)]
    public  class User
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="please enter a valid userName")]  
        public string UserName { get; set; }
        [Required(ErrorMessage = "please enter a valid userName")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Company { get; set; }
        public string Role { get; set; }
        public DateTime? DOB { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public string Nid { get; set; }
        public string Passport { get; set; }
        public string Password { get; set; }
        public string SystemPassword { get; set; }
        public string Address { get; set; }
        public bool MobileVerified { get; set; }
        public bool EmailVerified { get; set; }
        public DateTime? CreatedOn { get; set; }

        public ICollection<CompanyAdmin> CompanyAdmins { get; set; }


    }
}
