using Model;
using Repositorio;
using System.ServiceModel;
using Wcf_ServiceX.Generic;

namespace Wcf_ServiceX.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISvcTipoTelefone" in both code and config file together.
    [ServiceContract(Namespace = "https://Wcf-ServiceX/services/ISvcTipoTelefone/",SessionMode =SessionMode.NotAllowed)]
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
