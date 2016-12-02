using Infraestrutura;
using Model;
using Repositorio;
using System.ServiceModel;
using System.ServiceModel.Description;
using Wcf_ServiceX.Generic;
using System;
using Repositorio.Generic.Utils;

namespace Wcf_ServiceX.Services
{
    //[System.Serializable]
    [DurableService()]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession,Namespace = "https://Wcf-ServiceX/services/SvcTipoTelefone/")]
    public class SvcTipoTelefone : GenericService<TipoTelefoneRepository,TipoTelefone>, ISvcTipoTelefone
    {
        
        public SvcTipoTelefone()
        {
            Iniciar();
        }

        [DurableOperation(CanCreateInstance = true)]
        private void Iniciar()
        {
            Initialize(TipoTelefoneRepository.Instance);
        }
        //private readonly IGenericService<TipoTelefoneRepository, TipoTelefone> _service;
        //public SvcTipoTelefone(GenericService<TipoTelefoneRepository, TipoTelefone> service)
        //{
        //    _service = service;// new GenericService<TipoTelefone>();
        //}


        //[DurableOperation()]
        //public void Add(TipoTelefone param)
        //{
        //    _service.Add(param);
        //}

        //[DurableOperation()]
        //public void Complete()
        //{
        //    _service.Complete();
        //}

        //[DurableOperation()]
        //public void InitializeRepository()
        //{
        //    _service.InitializeRepository();
        //}

        //[DurableOperation()]
        //public PaginatedList<TipoTelefone> PaginateEntity(int pageIndex, int pageSize, string orderby = "cod", bool desc = false)
        //{
        //    var pag = _service.PaginateEntity(pageIndex, pageSize, orderby, desc);
        //    return pag;
        //}


        //[DurableOperation()]
        //public void Remove(TipoTelefone param)
        //{
        //    _service.Remove(param);
        //}

        //[DurableOperation()]
        //public void Update(TipoTelefone param)
        //{
        //    _service.Update(param);
        //}


    }
}
