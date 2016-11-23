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
    [DurableService()]
    //KnownTypeAttribute
    //        [KnownTypeAttribute(typeof(TipoTelefone))]
    //        [KnownType(typeof(TipoTelefone))]
    [ServiceKnownType(typeof(TipoTelefone))]
    public abstract class GenericService<TRep> : IGenericService<TRep>
        where TRep : IRepository
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

       // [DurableOperation(CanCreateInstance = true)]
        internal void Initialize(TRep rep)
        {
            if(_repo == null)
                _repo = rep; 

            _repo.InitializeRepository();
        }

        [DurableOperation(CompletesInstance = true)]
        public void Complete()
        {
            _repo.GetUnitOfWork().Commit();
            //TipoTelefoneRepository.Instance.RepUnitOfWork.Commit();
            //_unitofwork.Commit();
            _repo.Dispose();
        }


        //[DurableOperation()]
        //public void AddObjectSerialize(Entity _entity)
        //{
        //    if (this.entities == null)
        //        this.entities = new List<Entity>();

        //    entities.Add(_entity);
        //}


        //[DurableOperation()]
        //public void AddEntities(Entity _entity)
        //{
        //    if (this.entities == null)
        //        this.entities = new List<Entity>();

        //    this.entities.Add(_entity);
        //}

        //[DurableOperation()]
        //public void Set(Entity _entity)
        //{
        //    this.entity = _entity;
        //}

        [DurableOperation()]
        public void SalvarEntities()
        {
            _repo.Salvar(this.EntitiesUpdate);
        }

        [DurableOperation()]
        public void Salvar(Entity cls)
        {
            _repo.Salvar(cls);

        }

        [DurableOperation()]
        public void AdicionarEntity(Entity cls)
        {
            _repo.Adicionar(cls);

        }

        [DurableOperation()]
        public void Adicionar()
        {
            _repo.Adicionar(entity);
        }

       



        [DurableOperation()]
        public void Remover(Entity cls)
        {
            _repo.Remover(cls);

        }

        [DurableOperation()]
        public void RemoverEntities()
        {
           // _repo.Remover(this.entities);

        }

        [DurableOperation()]
        public PaginatedList<Entity> Paginate(int pageIndex, int pageSize)
        {
            return _repo.Paginate(pageIndex, pageSize);
        }


        #region Internal

        internal void AddEntities()
        {
            _repo.Adicionar(this.EntitiesAdd);
        }

        internal void RemoveEntities()
        {
            _repo.Remover(this.EntitiesAdd);
        }

        internal void SaveEntities()
        {
            _repo.Salvar(this.EntitiesAdd);
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