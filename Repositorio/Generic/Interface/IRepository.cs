using Infraestrutura;
using Repositorio.Generic.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repositorio
{
    // bare bones entity class

    // base bones repository interface
    public interface IRepository<TEntity, TId>
        where TEntity : IEntity<TId>
        where TId : struct
    {
        #region methods

        void InitializeRepository();

        void InsertPersistente(TEntity entity);

        void InsertPersistente(Entity entidade);

        Entity FindByID(int id);

        void UpdatePersistente(Entity entidade);

        void DeletePersistente(Entity entidade);

        void Salvar(Entity cls);

        void Salvar(List<Entity> entities);

        void Adicionar(Entity cls);

        void Adicionar(List<Entity> entities);

        void Remover(Entity cls);

        void Remover(List<Entity> entities);

        void Dispose();

        void Commit();

        IUnitOfWork GetUnitOfWork();

        //IQueryable<TEntity> GetAll(
        //   Expression<Func<TEntity, bool>> where = null,
        //   Expression<Func<TEntity, object>> orderBy = null);

        PaginatedList<Entity> Paginate(int pageIndex, int pageSize, string order = "cod");

        //TEntity GetSingle(TId id);

        //IQueryable<TEntity> GetAllIncluding(
        //  Expression<Func<TEntity, bool>> where,
        //  Expression<Func<TEntity, object>> orderBy,
        //  params Expression<Func<TEntity, object>>[] includeProperties);

        //TEntity GetSingleIncluding(TId id, params Expression<Func<TEntity, object>>[] includeProperties);

        #endregion
    }

    // with most commonly used identity
    public interface IRepository<TEntity> : IRepository<TEntity, int>
        where TEntity : Entity
    {
    }

    public interface IRepository : IRepository<Entity>
    {
    }

}
