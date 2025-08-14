using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vera.Infrastructure.Database;
using Vera.Infrastructure.Interfaces;

namespace Vera.Infrastructure.Repositories
{
    public class UnitOfWork(AppDbContext context) : IUnitOfWork
    { 
        public IReservationRepository ReservationRepository => new ReservationRepository(context);

        public async Task<int> CommitAsync() => await context.SaveChangesAsync();
        
    }
}
