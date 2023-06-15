

using Entities.Models;

namespace Repositories.Repositories.Abstracts
{
    public interface ISyllabusRepository : IRepositoryBase<Day>
    {
        Task<IEnumerable<Day>> GetSyllabusAsyncByUserIdAsync(int userId, bool trackChanges);
    }
}
