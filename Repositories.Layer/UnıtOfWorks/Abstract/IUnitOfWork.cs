
namespace Repositories.UnıtOfWorks.Abstract
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void Commit();
    }
}

