using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vera.Application.DTOs;
using Vera.Application.Mappings;
using Vera.Infrastructure.Interfaces;
using Vera.Infrastructure.Models;

namespace Vera.Application.Services
{
    public class ReservationService(IUnitOfWork unitOfWork, ReservationMapper mapper)
    {
        public async Task<List<ReservationDto>> GetAll(string id)
        {
            List<Reservation> reservationsCollection = await unitOfWork.ReservationRepository.GetAllAsync();

            List<ReservationDto> reservationDtoCollection = mapper.ReservationListToReservationDtoList(reservationsCollection);

            return reservationDtoCollection; 
        }

        public async Task<ReservationDto> CreateReservationAsync(ReservationDto reservationDto)
        {

            var reservation = mapper.ReservationDtoToReservation(reservationDto);

            await unitOfWork.ReservationRepository.AddAsync(reservation);
            await unitOfWork.CommitAsync();
            return reservationDto;
        }

        public async Task<ReservationDto> UpdateReservationAsync(ReservationDto reservationDto)
        {
            var existingReservation = await unitOfWork.ReservationRepository.GetByIdAsync(reservationDto.Id);
            if (existingReservation == null) throw new ValidationException("La persona no existe");

        
            existingReservation.CheckInDate = reservationDto.CheckInDate;
            existingReservation.CheckOutDate = reservationDto.CheckOutDate;
            
            await unitOfWork.CommitAsync();
            return mapper.ReservationToReservationDto(existingReservation);
        }
        public async Task DeleteReservation(string id)
        {
            await unitOfWork.ReservationRepository.DeleteAsync(id);
        }
    }
}
