using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vera.Infrastructure.Database;
using Vera.Infrastructure.Models;

namespace Vera.Infrastructure.Repositories
{
    public class AmenityRepository
    {
        private readonly AppDbContext _appDbContext;
        public AmenityRepository(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }

        public async Task AddAsync(Amenity amenity)
        {
            await _appDbContext.Amenity.AddAsync(amenity);

        }

        public async Task DeleteAsync(Guid id)
        {
            var person = await _appDbContext.Amenity.FindAsync(id);
            if (person != null)
            {
                person.IsDeleted = true;
            }
        }
         

        public async Task<List<Amenity>> GetAllAsync()
        {
            return await _appDbContext.Amenity.ToListAsync();
        }

        public async Task<Amenity?> GetByIdAsync(string id)
        {
            return await _appDbContext.Amenity
                 .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
