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


namespace Wcf_ServiceX.Generic
{

    [Serializable]
    //[DurableService()]
    //KnownTypeAttribute
    //        [KnownTypeAttribute(typeof(TipoTelefone))]
    //        [KnownType(typeof(TipoTelefone))]
    //[ServiceKnownType(typeof(TipoTelefone))]
    //public abstract class GenericService<TRep> : IGenericService<TRep>
    //    where TRep : IRepository
    public abstract class GenericService<TRep,TEntity> : IGenericService<TRep,TEntity>
        where TRep : IRepository
        where TEntity : Entity
    {
        [DataMember]
        public IRepository<Entity, int> _repo;

        [DataMember]
        public Entity entity;

        [DataMember]
        public List<Entity> EntitiesAdd;

        [DataMember]
        public List<Entity> EntitiesRemove;

        [DataMember]
        public List<Entity> EntitiesUpdate;

        //[DataMember]
        //public PaginatedList<Entity> paginateList;

       // [DurableOperation(CanCreateInstance = true)]
        internal void Initialize(TRep rep)
        {
            if(_repo == null)
                _repo = rep;

            EntitiesAdd = new List<Entity>();
            EntitiesRemove = new List<Entity>();
            EntitiesUpdate = new List<Entity>();
            //paginateList = new PaginatedList<Entity>();
            _repo.InitializeRepository();
        }

        public void Initialize()
        {


            EntitiesAdd = new List<Entity>();
            EntitiesRemove = new List<Entity>();
            EntitiesUpdate = new List<Entity>();

            Repository<TEntity, int>.Instance.InitializeRepository();
        }

        

        //[DurableOperation()]
        public void Add(TEntity param)
        {
            AddEntity(param);
        }

       // [DurableOperation()]
        public void Update(TEntity param)
        {
            AddUpdateEntity(param);
        }

        //[DurableOperation()]
        public void Remove(TEntity param)
        {
            AddRemoveEntity(param);
        }

        //[DurableOperation()]
        public Entity[] Paginate(int pageIndex, int pageSize) 
        {
            Entity[] array = _repo.Paginate(pageIndex, pageSize).ToArray();

            return array;

        }

        //[DurableOperation(CompletesInstance = true)]
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
}