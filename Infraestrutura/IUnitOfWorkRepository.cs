using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura
{
    
    public interface IUnitOfWorkRepository
    {
        void InsertPersistente(Entity entidade);
        void UpdatePersistente(Entity entidade);
        void DeletePersistente(Entity entidade);

    }
    
    /*
    public interface IUnitOfWorkRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        IQueryable<T> Query();
    }
    */
}
