using Entities.Layer.Models;
using Repositories.Layer.Repositories.Abstracts;
using Service.Layer.Abstracts;

namespace Service.Layer.Concretes
{
    public class SyllabusManager : ISyllabusService
    {
        private readonly IRepositoryManager _manager;

        public SyllabusManager(IRepositoryManager manager)
        {
            _manager=manager;
        }

        public async Task<IEnumerable<Day>> GetSyllabusAsyncByUserIdAsync(int userId, bool trackChanges)
        {
            var syllabuses = await _manager.Syllabus.GetSyllabusAsyncByUserIdAsync(userId, trackChanges);
            return syllabuses;
        }
    }
}
