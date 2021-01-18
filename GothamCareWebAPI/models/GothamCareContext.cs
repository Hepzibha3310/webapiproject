using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace charitableLibrary.Models
{
    public class GothamCareContext : DbContext
    {
        
            public GothamCareContext(DbContextOptions<GothamCareContext> options) : base(options)
            {

            }
            public DbSet<Outlet> outlets { get; set; }
            public DbSet<Volunteer> volunteers { get; set; }

            protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);
            }

            public override int SaveChanges()
            {
                ChangeTracker.DetectChanges();
                return base.SaveChanges();
            }
        }
}
