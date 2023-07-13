using AutoMapper;
using Entities.DTOs.SyllabusDtos;
using Entities.Exceptions.SyllabusException;
using Entities.Models;
using Repositories.Repositories.Abstracts;
using Service.Abstracts;

namespace Service.Concretes
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

            if (syllabus == null)
                throw new SyllabusNotFoundException(userId);

            var syllabusDto = _mapper.Map<List<SyllabusDto>>(syllabus);

            return syllabusDto;
        }
    }
}
