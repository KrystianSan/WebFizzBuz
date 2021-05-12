using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFizzBuzz.Form;

namespace WebFizzBuzz.Data
{
    public class Numbers : DbContext
    {
        public Numbers(DbContextOptions options) : base(options) { }
        public DbSet<Address> Address { get; set; }
    }
}
