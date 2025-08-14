using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vera.Infrastructure.Models
{
    public class Reservation
    {
        public string Id { get; set; }

        public Property Property { get; set; }

        public User Guest { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public decimal TotalPrice { get; set; }

        public ReservationStatus Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
        public bool IsDeleted { get; internal set; }
    }

    public enum ReservationStatus
    {
        Pendiente,
        Confirmada,
        Cancelada
    }
}
