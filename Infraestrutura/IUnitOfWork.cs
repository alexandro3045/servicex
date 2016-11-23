using System;

namespace Infraestrutura
{
    
    public interface IUnitOfWork : IDisposable
    {
        void RegistraAlterado(Entity entidade, IUnitOfWorkRepository unitofWorkRepository);
        void RegistraNovo(Entity entidade, IUnitOfWorkRepository unitofWorkRepository);
        void RegistraRemovido(Entity entidade, IUnitOfWorkRepository unitofWorkRepository); 
        void Commit();
     }
    
    /*
    public interface IUnitOfWork : IDisposable
    {
        void Commit();

        void Rollback();
    }
    */
}
