using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence.Context
{
    public  class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
             
        }
        public DbSet<User> Users { get; set; }
        public DbSet<LookUp> LookUps { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyAdmin>  CompanyAdmins { get; set; }


    }
}
