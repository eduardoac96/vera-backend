using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vera.Infrastructure.Models
{ 
        public class Location
        {
            public string Id { get; set; }
            public string Country { get; set; }
            public string State { get; set; } // Optional in TS -> nullable in C#
            public string City { get; set; }
            public string AddressLine1 { get; set; }
            public string PostalCode { get; set; } // Optional
            public double? Latitude { get; set; }  // Optional -> nullable double
            public double? Longitude { get; set; } // Optional -> nullable double
        } 
}
