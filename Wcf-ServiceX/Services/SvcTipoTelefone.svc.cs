using Model;
using Repositorio;
using System;
using System.ServiceModel.Description;
using Wcf_ServiceX.Generic;


namespace Wcf_ServiceX.Services
{
    [Serializable]
    [DurableService()]
    public class SvcTipoTelefone : GenericService<TipoTelefoneRepository>, ISvcTipoTelefone
    {
        public SvcTipoTelefone(TipoTelefoneRepository repository)
        {
            Initialize(repository);
        }

        public SvcTipoTelefone()
        {
            Initialize(TipoTelefoneRepository.Instance);           
        }

        public void SetAddEntity(TipoTelefone param)
        {
            AddEntity(param);
            AddEntities();
        }

        public void SetAddUpdateEntity(TipoTelefone param)
        {
            AddUpdateEntity(param);
            SalvarEntities();
        }

        public void SetAddRemoveEntity(TipoTelefone param)
        {
            AddRemoveEntity(param);
            RemoveEntities();
        }

        //[DurableOperation(CanCreateInstance = true)]
        //public void Initialize()
        //{
        //    _repo = TipoTelefoneRepository.Instance;
        //    _repo.InitializeRepository();
        //}

        //[DurableOperation(CompletesInstance = true)]
        //public void Complete()
        //{
        //    _repo.RepUnitOfWork.Commit();
        //    //TipoTelefoneRepository.Instance.RepUnitOfWork.Commit();
        //    //_unitofwork.Commit();
        //    _repo.Dispose();
        //}


    }
}
