using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Interfaces.IGenericRepository;

namespace Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int Save();
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class;
    }

}
