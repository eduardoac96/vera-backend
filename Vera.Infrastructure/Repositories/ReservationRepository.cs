using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vera.Infrastructure.Database;
using Vera.Infrastructure.Interfaces;
using Vera.Infrastructure.Models;

namespace Vera.Infrastructure.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly AppDbContext _appDbContext;
        public ReservationRepository(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }

        public async Task AddAsync(Reservation reservation)
        {
            await _appDbContext.Reservation.AddAsync(reservation);

        }

        public async Task DeleteAsync(string id)
        {
            var person = await _appDbContext.Reservation.FindAsync(id);
            if (person != null)
            {
                person.IsDeleted = true;
            }
        }
         

        public async Task<List<Reservation>> GetAllAsync()
        {
            return await _appDbContext.Reservation.ToListAsync();
        }

        public async Task<Reservation?> GetByIdAsync(string id)
        {
            return await _appDbContext.Reservation
                 .FirstOrDefaultAsync(p => p.Id == id);
        }

        public Task<Reservation?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
