using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Index(nameof(Code), IsUnique = true)]
    public class Company
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string Phone { get; set; }
        public string? Address { get; set; }
        public string? Bin { get; set; }
        public string? Tin { get; set; }
        public string Logo { get; set; }
        public string? Website { get; set; }
        public string FbLink { get; set; }
        public string? LinkedInLink { get; set; }
        public string? TwitterLink { get; set; }
        public int? Status { get; set; }
    }
}
