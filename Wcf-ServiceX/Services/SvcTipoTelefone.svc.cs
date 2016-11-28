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
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession,Namespace = "https://Wcf-ServiceX/services/TipoTelefone/")]
    public class SvcTipoTelefone :  GenericService<TipoTelefoneRepository,TipoTelefone>, ISvcTipoTelefone
    {

        public SvcTipoTelefone()
        {
            Initialize(TipoTelefoneRepository.Instance);           
        }

    }
}
