using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data
{
    public class WholeAppDB : IdentityDbContext<WholeAppUser>
    {
        public WholeAppDB(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // you can rename the ASP.NET Identity table names and more.
            // Add customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Wisdom> Wisdom { get; set; }
    }
}
