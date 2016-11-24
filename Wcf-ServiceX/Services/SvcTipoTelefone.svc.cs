using Infraestrutura;
using Model;
using Repositorio;
using System.ServiceModel;
using System.ServiceModel.Description;
using Wcf_ServiceX.Generic;
using System;

namespace Wcf_ServiceX.Services
{
    [System.Serializable]
    //[DurableService()]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class SvcTipoTelefone :  GenericService<TipoTelefoneRepository,TipoTelefone>, ISvcTipoTelefone
    {

        public SvcTipoTelefone()
        {
            Initialize(TipoTelefoneRepository.Instance);           
        }


        //public void SetAdd(TipoTelefone param)//(TipoTelefone param)
        //{
        //    AddEntity(param);
        //    AddEntities();
        //}

        //public void SetUpdate(TipoTelefone param)
        //{
        //    AddUpdateEntity(param);
        //    SalvarEntities();
        //}

        //public void SetRemove(TipoTelefone param)
        //{
        //    AddRemoveEntity(param);
        //    RemoveEntities();
        //}

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
