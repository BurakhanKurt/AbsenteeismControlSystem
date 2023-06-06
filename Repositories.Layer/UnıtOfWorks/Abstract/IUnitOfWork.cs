
namespace Repositories.Layer.UnıtOfWorks.Abstract
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void Commit();
    }
}

