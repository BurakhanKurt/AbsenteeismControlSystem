using Entities.Layer.Models;

namespace Service.Layer.Abstracts
{
    public interface ISyllabusService
    {
        Task<IEnumerable<Day>> GetSyllabusAsyncByUserIdAsync(int userId, bool trackChanges);
    }
}
