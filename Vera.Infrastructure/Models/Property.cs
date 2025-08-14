using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vera.Infrastructure.Models
{
    public class Property
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public User Host { get; set; } // Reference to a nested DTO

        public Location Location { get; set; } // Reference to nested DTO

        public List<Amenity> Amenities { get; set; } = new List<Amenity>();

        public List<Photo> Photos { get; set; } = new List<Photo>();

        public decimal PricePerDay { get; set; }

        public int MaxGuests { get; set; }

        public DateTime CreatedAt { get; set; } // ISO string → DateTime

        public DateTime UpdatedAt { get; set; } // ISO string → DateTime
    }
}
