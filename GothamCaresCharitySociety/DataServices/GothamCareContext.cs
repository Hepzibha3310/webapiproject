using DataServices.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataServices
{
    public class GothamCareContext:DbContext
    {
        public GothamCareContext(DbContextOptions<GothamCareContext> options) : base(options)
        {

        }

        

        public DbSet<Outlet> Outlet { get; set; }
        public DbSet<Volunteer> Volunteer { get; set; }
        public DbSet<Admin> Admin { get; set; }
        

        



       
        

    }
}
