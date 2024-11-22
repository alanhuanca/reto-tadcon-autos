using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class AutoRepository : IAutoRepository
    {
        private readonly AutoDbContext _context;

        public AutoRepository(AutoDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Auto>> GetAllAsync()
        {
            return await _context.Autos.ToListAsync();
        }

        public async Task<Auto> GetByIdAsync(int id)
        {
            return await _context.Autos.FindAsync(id);
        }

        public async Task AddAsync(Auto auto)
        {
            _context.Autos.Add(auto);
            await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(Auto auto)
        {
            _context.Entry(auto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return 1;
        }

        public async Task DeleteAsync(int id)
        {
            var auto = await _context.Autos.FindAsync(id);
            if (auto != null)
            {
                _context.Autos.Remove(auto);
                await _context.SaveChangesAsync();
            }
        }

       
    }
}