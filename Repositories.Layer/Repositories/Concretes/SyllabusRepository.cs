using Entities.Layer.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Layer.Repositories.Abstracts;

namespace Repositories.Layer.Repositories.Concretes
{
    public class SyllabusRepository : RepositoryBase<Day>, ISyllabusRepository 
    {
        public SyllabusRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Day>> GetSyllabusAsyncByUserIdAsync(int userId, bool trackChanges)
        {
            var days = await GetAll(trackChanges).OrderBy(d => d.Id)
                .Include(c=> c.CourseCalendars.Select(c => new
                {
                    c.StartTime, c.EndTime, c.Course
                }))
                .ThenInclude(c=> c.Course.CourseName).Where(c=> c.Id == userId)
                .ToListAsync();
            return days;
        }
    }
}
