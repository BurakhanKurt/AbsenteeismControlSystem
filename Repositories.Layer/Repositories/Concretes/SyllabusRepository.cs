using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Repositories.Abstracts;

namespace Repositories.Repositories.Concretes
{
    public class SyllabusRepository : RepositoryBase<Day>, ISyllabusRepository 
    {
        public SyllabusRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Day>> GetSyllabusAsyncByUserIdAsync(int userId, bool trackChanges)
        {
            var days = await GetAll(trackChanges)
                .Where(d => d.CourseCalendars.Any(a => a.Course.UserId == userId))
                .OrderBy(d => d.Id)
                .Include(c => c.CourseCalendars.OrderBy(c => c.StartTime))
                    .ThenInclude(a => a.Course)
                .ToListAsync();
            return days;
        }
    }
}
