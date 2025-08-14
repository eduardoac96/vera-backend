using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vera.Infrastructure.Models
{
    public class Notification 
    {
        public string Id { get; set; }

        // We can use an enum for type safety
        public NotificationType Type { get; set; }

        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; } // ISO string → DateTime in C#

        public bool Read { get; set; }

        public string? ReservationId { get; set; } // Optional in TS → nullable in C#

        public object? Data { get; set; } // "any" in TS → object in C#
    }

    public enum NotificationType
    {
        Reservation,
        Review,
        Message,
        System
    }
}
