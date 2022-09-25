using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CompanyAdmin
    {
        public int Id { get; set; }
        public string ContactPerson { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        //Foreign key for Standard
        public int UserId { get; set; }
        [Required(ErrorMessage = "please enter a valid userName")]
        public User User { get; set; }
    }
}
