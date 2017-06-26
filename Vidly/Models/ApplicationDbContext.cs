using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Vidly.Models
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MemberShipType> MemberShipTypes { get; set; }
    }
}