using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vera.Infrastructure.Interfaces
{
    public interface IUnitOfWork
    {
        IReservationRepository ReservationRepository { get; }
        Task<int> CommitAsync();
    }
}
