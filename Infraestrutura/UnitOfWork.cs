using System;
using System.Collections.Generic;
using System.Transactions;

namespace Infraestrutura
{

    public class UnitOfWork : IUnitOfWork
    {
        private Dictionary<Entity, IUnitOfWorkRepository> entidadesAdicionadas;
        private Dictionary<Entity, IUnitOfWorkRepository> entidadesAlteradas;
        private Dictionary<Entity, IUnitOfWorkRepository> entidadesDeletadas;

        public UnitOfWork()
        {
            entidadesAdicionadas = new Dictionary<Entity, IUnitOfWorkRepository>();
            entidadesAlteradas = new Dictionary<Entity, IUnitOfWorkRepository>();
            entidadesDeletadas = new Dictionary<Entity, IUnitOfWorkRepository>();
        }

        public void RegistraAlterado(Entity entidade, IUnitOfWorkRepository unitofWorkRepository)
        {
            if (!entidadesAlteradas.ContainsKey(entidade))
            {
                entidadesAlteradas.Add(entidade, unitofWorkRepository);
            }
        }

        public void RegistraNovo(Entity entidade, IUnitOfWorkRepository unitofWorkRepository)
        {
            if (!entidadesAdicionadas.ContainsKey(entidade))
            {
                entidadesAdicionadas.Add(entidade, unitofWorkRepository);
            };
        }

        public void RegistraRemovido(Entity entidade, IUnitOfWorkRepository unitofWorkRepository)
        {
            if (!entidadesDeletadas.ContainsKey(entidade))
            {
                entidadesDeletadas.Add(entidade, unitofWorkRepository);
            }
        }

        public void Commit()
        {
            using (TransactionScope escopo = new TransactionScope())
            {
                foreach (Entity entidade in this.entidadesAdicionadas.Keys)
                {
                    this.entidadesAdicionadas[entidade].InsertPersistente(entidade);
                }

                foreach (Entity entidade in this.entidadesAlteradas.Keys)
                {
                    this.entidadesAlteradas[entidade].UpdatePersistente(entidade);
                }

                foreach (Entity entidade in this.entidadesDeletadas.Keys)
                {
                    this.entidadesDeletadas[entidade].DeletePersistente(entidade);
                }

                escopo.Complete();
            }
        }

        void IUnitOfWork.RegistraAlterado(Entity entidade, IUnitOfWorkRepository unitofWorkRepository)
        {
            throw new NotImplementedException();
        }

        void IUnitOfWork.RegistraNovo(Entity entidade, IUnitOfWorkRepository unitofWorkRepository)
        {
            throw new NotImplementedException();
        }

        void IUnitOfWork.RegistraRemovido(Entity entidade, IUnitOfWorkRepository unitofWorkRepository)
        {
            throw new NotImplementedException();
        }

        void IUnitOfWork.Commit()
        {
            throw new NotImplementedException();
        }
    }
    
    /*
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly DbContext context;

        public EFUnitOfWork(DbContext context)
        {
            this.context = context;
        }


        public DbSet<T> GetDbSet<T>()
            where T : class
        {
            return context.Set<T>();
        }

        public void Commit()
        {
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        var a = "Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage;
                    }
                }
            }
        }

        public void Rollback()
        {
            //context.
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
    */
}
