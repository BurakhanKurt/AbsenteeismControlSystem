using Entities.Layer.Models;

namespace Repositories.Layer.Repositories.Abstracts
{
    public interface ISyllabusRepository : IRepositoryBase<Day>
    {
        Task<IEnumerable<Day>> GetSyllabusAsyncByUserId(int userId, bool trackChanges);
    }
}
