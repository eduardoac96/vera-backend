using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vera.Infrastructure.Models;

namespace Vera.Infrastructure.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) 
        {
        }

        public virtual DbSet<Reservation> Reservation{ get; set; }
        public virtual DbSet<Amenity> Amenity { get; set; }

        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<Review> Review { get; set; }

        public virtual DbSet<User> User { get; set; }   
    }
}
