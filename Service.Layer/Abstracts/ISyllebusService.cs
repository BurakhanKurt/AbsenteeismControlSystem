using Entities.Layer.Models;

namespace Service.Layer.Abstracts
{
    public interface ISyllebusService
    {
        Task<IEnumerable<Day>> GetSyllabusAsyncByUserIdAsync(int userId, bool trackChanges);
    }
}
