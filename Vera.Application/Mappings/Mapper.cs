using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vera.Application.DTOs;
using Vera.Infrastructure.Models;

namespace Vera.Application.Mappings
{
    [Mapper]
    public partial class ReservationMapper
    {
        public partial ReservationDto ReservationToReservationDto(Reservation reservation);
        public partial Reservation ReservationDtoToReservation(ReservationDto reservationDto);
        public partial List<ReservationDto> ReservationListToReservationDtoList(List<Reservation> reservations);


    }
}
