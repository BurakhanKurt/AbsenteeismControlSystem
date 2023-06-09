using Entities.Layer.DTOs.SyllabusDtos;
using Entities.Layer.Models;

namespace Service.Layer.Abstracts
{
    public interface ISyllabusService
    {
        Task<IEnumerable<SyllabusDto>> GetSyllabusAsyncByUserIdAsync(int userId, bool trackChanges);
    }
}
