using Infraestrutura;
using Model;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_ServiceX.Decorator;
using Wcf_ServiceX.Generic;

namespace Wcf_ServiceX.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISvcTipoTelefone" in both code and config file together.
    [ServiceContract]
    public interface ISvcTipoTelefone : IGenericService<TipoTelefoneRepository,TipoTelefone>
    {

        //[OperationContract]
        //[EfDataContractSerializer]
        //void SetAdd(T param);

        //[OperationContract]
        //[EfDataContractSerializer]
        //void SetAdd(TipoTelefone param);

        //[OperationContract]
        //[EfDataContractSerializer]
        // void SetUpdate(TipoTelefone param);

        //[OperationContract]
        //[EfDataContractSerializer]
        //void SetRemove(TipoTelefone param);
    }

}
