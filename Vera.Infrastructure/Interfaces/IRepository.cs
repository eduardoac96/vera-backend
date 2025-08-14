using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vera.Infrastructure.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(string id);
        Task AddAsync(T entity);
        Task DeleteAsync(string id); //Softdelete
        Task<List<T>> GetAllAsync();
    }
}
