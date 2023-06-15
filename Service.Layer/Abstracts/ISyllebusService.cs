using Entities.DTOs.SyllabusDtos;
using Entities.Models;

namespace Service.Abstracts
{
    public interface ISyllabusService
    {
        Task<IEnumerable<SyllabusDto>> GetSyllabusAsyncByUserIdAsync(int userId, bool trackChanges);
    }
}
