using AutoMapper;
using Entities.Layer.DTOs.SyllabusDtos;
using Entities.Layer.Models;
using Repositories.Layer.Repositories.Abstracts;
using Service.Layer.Abstracts;

namespace Service.Layer.Concretes
{
    public class SyllabusManager : ISyllabusService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public SyllabusManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager=manager;
            _mapper=mapper;
        }

        public async Task<IEnumerable<SyllabusDto>> GetSyllabusAsyncByUserIdAsync(int userId, bool trackChanges)
        {
            var syllabus = await _manager.Syllabus.GetSyllabusAsyncByUserIdAsync(userId, trackChanges);
            var syllabusDto = _mapper.Map<List<SyllabusDto>>(syllabus);
            return syllabusDto;
        }
    }
}
