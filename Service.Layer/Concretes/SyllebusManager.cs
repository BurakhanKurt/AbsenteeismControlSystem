using Entities.Layer.Models;
using Repositories.Layer.Repositories.Abstracts;
using Service.Layer.Abstracts;

namespace Service.Layer.Concretes
{
    public class SyllebusManager : ISyllebusService
    {
        private readonly IRepositoryManager _manager;

        public SyllebusManager(IRepositoryManager manager)
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
