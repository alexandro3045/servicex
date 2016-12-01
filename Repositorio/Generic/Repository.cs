
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
    public class Repository<TEntity, TId>
            : IUnitOfWorkRepository, IRepository<TEntity, TId> 
            where TEntity : IEntity<TId>
            where TId : struct

    {

        private static SERVICEX context;

        private static Repository<TEntity, TId> _instance;
        public static Repository<TEntity, TId> Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Repository<TEntity, TId>();

                return _instance;
            }
        }



        public void InitializeRepository()
        {
            if (_unitOfWork == null)
                _unitOfWork = new UnitOfWork();

            if (context == null)
                 context = new SERVICEX();
        }

        private static IUnitOfWork _unitOfWork;
        public IUnitOfWork RepUnitOfWork
        {
            get
            {
                if (_unitOfWork == null)
                    _unitOfWork = new UnitOfWork();

                return _unitOfWork;
            }
        }

        //public IUnitOfWork RepUnitOfWork()
        //{
        //   if(_unitOfWork == null)
        //    _unitOfWork = new UnitOfWork();

        //   return _unitOfWork;
        //}



        //public IUnitOfWork RepUnitOfWork
        //{
        //    get
        //    {
        //        if (_unitOfWork == null)
        //            _unitOfWork = new UnitOfWork();

        //        return _unitOfWork;
        //    }
        //    set
        //    {
        //        _unitofwork = value;
        //    }
        //}




        //    public Repository()
        //    {

        //        if(context == null)
        //            context = new SERVICEX();
        //    }

        //public Repository(IUnitOfWork unitOfWork)
        //    {

        //        if (context == null)
        //            context = new SERVICEX();
        //    }

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
            context.Set(entidade.GetType()).Add(entidade);
               
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
            _unitOfWork.RegistraAlterado(cls ,this);
        }

        public void Salvar(List<Entity> entities)
        {
            foreach (Entity cls in entities)
            {
                _unitOfWork.RegistraAlterado((Entity)cls, this);
            }
        }

        public void Adicionar(Entity cls)
        {
            _unitOfWork.RegistraNovo(cls, this);
        }

        public void Adicionar(List<Entity> entities)
        {
            foreach (Entity cls in entities)
            {
                _unitOfWork.RegistraNovo(cls, this);
            }
        }

        public void Remover(Entity cls)
        {
            _unitOfWork.RegistraRemovido(cls, this);
        }

        public void Remover(List<Entity> entities)
        {
            foreach (Entity cls in entities)
            {
                _unitOfWork.RegistraRemovido(cls, this);
            }
        }

        public void Commit()
        {
            _unitOfWork.Commit();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
            //context.Dispose();
        }           

        public PaginatedList<Entity> Paginate(int pageIndex, int pageSize,string order = "cod")
        {
            //not implemented yet
            return new PaginatedList<Entity>(GetAll() as IQueryable<Entity>, pageIndex, pageSize,order);
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

        private IQueryable<TEntity> GetAll(
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

        private IQueryable<TEntity> GetAllIncluding(
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


        public IUnitOfWork GetUnitOfWork()
        {
            return RepUnitOfWork;
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
