
using System.Reflection;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core;
using System.Linq;
using System.Data.Entity.Validation;

#region namespace project
using Infraestrutura;
using Model;
using System;
using System.Linq.Expressions;
using Repositorio.Generic.Utils;
using System.Data.Entity;
using System.Collections.Generic;
#endregion

namespace Repositorio
{
    public  abstract class Repository<TEntity, TId>
            : IUnitOfWorkRepository, IRepository<TEntity, TId>
            where TEntity : IEntity<TId>
            where TId : struct

    {
            private IUnitOfWork unitOfWork;
            private SERVICEX context = new SERVICEX();

            public Repository()
            {
                if (this.unitOfWork == null)
                    this.unitOfWork = new UnitOfWork();
            }

            public Repository(IUnitOfWork unitOfWork)
            {
                this.unitOfWork = unitOfWork;
            }

            public void InsertPersistente(TEntity entity)
            {

                context.Set<TEntity>().Add(entity);

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


            public void InsertPersistente(Entity entidade)
            {
                // context.Set<Entity>().Add(entidade);
                //context.Set(entidade.GetType());
                //new Generic.EntityRepository<TEntity, TId>(context).Add((TEntity)entidade);
                //new Generic.EntityRepository<?,?>();
                //context.SetAsAdded

                //var entityDB = new Generic.EntityRepository(context).Add(entidade);
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

            public Entity FindByID(int id)
            {
                //Perfil cls = (Perfil)entidade;

                string containerName = ((IObjectContextAdapter)context).ObjectContext.DefaultContainerName;
                string setName = ((IObjectContextAdapter)context).ObjectContext.CreateObjectSet<Entity>().EntitySet.Name;

                var entityKey = new EntityKey(containerName + "." + setName, "Id", id);

                Entity dbProd = (Entity)((IObjectContextAdapter)context).ObjectContext.GetObjectByKey(entityKey);

                return dbProd;

            }

            public void UpdatePersistente(Entity entidade)
            {
                //Perfil cls = (Perfil)entidade;

                string containerName = ((IObjectContextAdapter)context).ObjectContext.DefaultContainerName;
                string setName = ((IObjectContextAdapter)context).ObjectContext.CreateObjectSet<Entity>().EntitySet.Name;
                // Build entity key
                PropertyInfo propId = entidade.GetType().GetProperty("id");
                object id = System.Convert.ChangeType(propId.GetValue(propId, null), propId.PropertyType);

                var entityKey = new EntityKey(containerName + "." + setName, "Id", id);

                Entity dbProd = (Entity)((IObjectContextAdapter)context).ObjectContext.GetObjectByKey(entityKey);

                //Entity dbProd = context.Set<Entity>().Find(entidade);

                if (dbProd != null)
                {
                    foreach (PropertyInfo info in entidade.GetType().GetProperties())
                    {
                        PropertyInfo prop = dbProd.GetType().GetProperty(info.Name);
                        prop.SetValue(prop, info.GetValue(info, null), null);
                    }
                }

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

            public void DeletePersistente(Entity entidade)
            {
                //context.SetAsDeleted(entidade);

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

            public void Salvar(Entity cls)
            {
                unitOfWork.RegistraAlterado(cls ,this);
            }

            public void Adicionar(Entity cls)
            {
                unitOfWork.RegistraNovo(cls, this);
            }

            public void Remover(Entity cls)
            {
                unitOfWork.RegistraRemovido(cls, this);
            }

            public void Dispose()
            {
                context.Dispose();
            }

            public IQueryable<TEntity> GetAll(
               Expression<Func<TEntity, bool>> where = null,
               Expression<Func<TEntity, object>> orderBy = null)
            {
                try
                {
                    IQueryable<TEntity> queryable =
                        (where != null) ? context.Set<TEntity>().Where(where)
                        : context.Set<TEntity>();

                    return (orderBy != null) ? queryable.OrderBy(orderBy)
                        : queryable;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public PaginatedList<TEntity> Paginate(int pageIndex, int pageSize)
            {
                //not implemented yet
                return new PaginatedList<TEntity>(GetAll(), pageIndex, pageSize);
            }

            public IQueryable<TEntity> GetAllIncluding(
              Expression<Func<TEntity, bool>> where,
              Expression<Func<TEntity, object>> orderBy,
              params Expression<Func<TEntity, object>>[] includeProperties)
            {
                try
                {
                    IQueryable<TEntity> queryable = GetAll(where, orderBy);
                    foreach (Expression<Func<TEntity, object>> includeProperty in includeProperties)
                    {
                        queryable =
                            queryable.Include<TEntity, object>(includeProperty);
                    }
                    return queryable;
                }
                catch (Exception)
                {
                    throw;
                }
            }


            public TEntity GetSingle(TId id)
            {
                try
                {
                
                    IQueryable<TEntity> entities = GetAll();
                    var p1 = Expression.Parameter(typeof(TId));
                    TEntity entity = Filter<TId>(entities, x => x.cod, id).FirstOrDefault();
                    return entity;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public TEntity GetSingle(
                       Expression<Func<TEntity, bool>> filter = null, 
                params Expression<Func<TEntity, object>>[] includes)
            {
                IQueryable<TEntity> query = GetAll();


                if (filter != null)
                {
                    query = query.Where(filter);
                }


                if (includes != null)
                {
                    query = AddIncludes(query, includes);
                }
                return query.SingleOrDefault();
            }

            public TEntity GetById(TId id, params Expression<Func<TEntity, object>>[] includes)
            {
                var query = AddIncludes(GetAll(), includes);
                return query.SingleOrDefault(i => (object)i.cod == (object)id);
            }


        #region Private

        private IQueryable<TEntity> Filter<TProperty>(
           IQueryable<TEntity> dbSet,
           Expression<Func<TEntity, TProperty>> property, TProperty value)
           where TProperty : struct
        {
            try
            {
                var memberExpression = property.Body as MemberExpression;

                if (memberExpression == null ||
                    !(memberExpression.Member is PropertyInfo))
                    throw new ArgumentException
                        ("Property expected", "property");

                Expression left = property.Body;
                Expression right =
                    Expression.Constant(value, typeof(TProperty));
                Expression searchExpression = Expression.Equal(left, right);

                Expression<Func<TEntity, bool>> lambda =
                    Expression.Lambda<Func<TEntity, bool>>(
                        searchExpression,
                        new ParameterExpression[] { property.Parameters.Single() });

                return dbSet.Where(lambda);
            }
            catch (Exception)
            {
                throw;
            }
        }


        //public TEntity GetSingle(TId id)
        //{
        //    try
        //    {
        //        IQueryable<TEntity> entities = GetAll();
        //        TEntity entity =
        //            Filter<TId>(entities, x => x.cod, id).FirstOrDefault();
        //        return entity;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        //public TEntity GetSingle(int id)
        //{
        //    throw new NotImplementedException();
        //}


        private IQueryable<TEntity> AddIncludes(IQueryable<TEntity> query, IEnumerable<Expression<Func<TEntity, object>>> includes)
        { 
            if (includes != null) 
            { 
                query = includes.Aggregate(query, (current, include) => current.Include(include)); 
            } 
            return query; 
        }

    
        private IQueryable<TEntity> GetQueryable(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params Expression<Func<TEntity, object>>[] includes)
        { 
            IQueryable<TEntity> query = GetAll(); 
 
 
            if (filter != null) 
            { 
                query = query.Where(filter); 
            } 
 
 
            if (includes != null) 
            { 
                query = AddIncludes(query, includes); 
            } 
 
 
            return orderBy != null ? orderBy(query) : query; 
        } 


        //public TEntity GetSingleIncluding(TId id,
        //   params Expression<Func<TEntity, object>>[] includeProperties)
        //{
        //    try
        //    {
        //        IQueryable<TEntity> entities =
        //                GetAllIncluding(null, null, includeProperties);
        //        TEntity entity =
        //            Filter<TId>(entities, x => x.cod, id).FirstOrDefault();
        //        return entity;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}


        private enum OrderByType
        {
            Ascending,
            Descending
        }


        #endregion

    }

}
