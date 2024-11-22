using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IAutoRepository
    {
        Task<IEnumerable<Auto>> GetAllAsync();
        Task<Auto> GetByIdAsync(int id);
        Task AddAsync(Auto auto);
        Task<int> UpdateAsync(Auto auto);
        Task DeleteAsync(int id);
    }
}