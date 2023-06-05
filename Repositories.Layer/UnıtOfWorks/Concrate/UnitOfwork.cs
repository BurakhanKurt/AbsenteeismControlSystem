using Repositories.Layer.UnıtOfWorks.Abstract;

namespace Repositories.Layer.UnıtOfWorks.Concrate
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void commit()
        {
            _context.SaveChanges();
        }
    }
}
