using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Layer.UnıtOfWorks.Abstract
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void commit();
    }
}

