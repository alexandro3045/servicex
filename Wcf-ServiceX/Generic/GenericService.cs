using Infraestrutura;
using Model;
using Repositorio;
using Repositorio.Generic.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Description;
using Wcf_ServiceX.Decorator;

namespace Wcf_ServiceX.Generic
{

   public abstract class GenericService<TRep,TEntity> : IGenericService<TRep, TEntity>
        where TRep : IRepository<TEntity,int>
        where TEntity : Entity
    {
        [DataMember]
        public IRepository<TEntity,int> _repo;

        [DataMember]
        public Entity entity;

        [DataMember]
        public List<Entity> EntitiesAdd;

        [DataMember]
        public List<Entity> EntitiesRemove;

        [DataMember]
        public List<Entity> EntitiesUpdate;


       
        public void Initialize(TRep rep)
        {
            if (_repo == null)
                _repo = rep;

            EntitiesAdd = new List<Entity>();
            EntitiesRemove = new List<Entity>();
            EntitiesUpdate = new List<Entity>();
            //paginateList = new PaginatedList<Entity>();
            _repo.InitializeRepository();
        }

        //[DurableOperation(CanCreateInstance = true)]
        //public void InitializeRepository()
        //{
        //    EntitiesAdd = new List<Entity>();
        //    EntitiesRemove = new List<Entity>();
        //    EntitiesUpdate = new List<Entity>();

        //    _repo = Repository<TEntity,int>.Instance;
        //    _repo.InitializeRepository();
        //}



        [DurableOperation()]
        public void Add(TEntity param)
        {
            AddEntity(param);
        }

        [DurableOperation()]
        public void Update(TEntity param)
        {
            AddUpdateEntity(param);
        }

        [DurableOperation()]
        public void Remove(TEntity param)
        {
            AddRemoveEntity(param);
        }

        public PaginatedList<Entity> Paginate(int pageIndex, int pageSize)
        {
            PaginatedList<Entity> ret = _repo.Paginate(pageIndex, pageSize);
            return ret;
        }


        //[DurableOperation()]
        //public PaginatedList<TEntity> PaginateEntity(int pageIndex, int pageSize, string orderby, bool desc)
        //{
        //    return _repo.PaginateEntity(pageIndex, pageSize, orderby, desc); 
        //}

        [DurableOperation()]
        public ObjectContract<TEntity> PaginateEntity(int pageIndex, int pageSize, string orderby, bool desc)
        {
            var pag = _repo.PaginateEntity(pageIndex, pageSize, orderby, desc);

            ObjectContract<TEntity> obj = new ObjectContract<TEntity>() { PaginatedList = pag };

            return obj;
        }

        [DurableOperation(CompletesInstance = true)]
        public void Complete()
        {
            AddEntities();
            RemoveEntities();
            SaveEntities();
            Repository<TEntity, int>.Instance.RepUnitOfWork.Commit();
            Repository<TEntity, int>.Instance.Dispose();
            //_repo.GetUnitOfWork().Commit();
            //_repo.Dispose();
        }


        #region Internal

        internal void AddEntities()
        {
            Repository<TEntity, int>.Instance.Adicionar(this.EntitiesAdd);
            //_repo.Adicionar(this.EntitiesAdd);
        }

        internal void RemoveEntities()
        {
            _repo.Remover(this.EntitiesRemove);
        }

        internal void SaveEntities()
        {
            _repo.Salvar(this.EntitiesUpdate);
        }

        internal void AddEntity(Entity entity)
        {
            if (this.EntitiesAdd == null)
                this.EntitiesAdd = new List<Entity>();

            EntitiesAdd.Add(entity);
        }

        internal void AddUpdateEntity(Entity entity)
        {
            if (this.EntitiesUpdate == null)
                this.EntitiesUpdate = new List<Entity>();

            EntitiesUpdate.Add(entity);
        }

        internal void AddRemoveEntity(Entity entity)
        {
            if (this.EntitiesRemove == null)
                this.EntitiesRemove = new List<Entity>();

            EntitiesRemove.Add(entity);
        }
        #endregion
        
    }

    [DataContract]
    public class ObjectContract<TEntity>
        where TEntity : Entity
    {
        private PaginatedList<TEntity> _PaginatedList;

        [DataMember]
        public PaginatedList<TEntity> PaginatedList
        {

            get { return _PaginatedList; }
            set { _PaginatedList = value; }
        }
    }
}