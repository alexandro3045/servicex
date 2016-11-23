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

namespace Wcf_ServiceX.Interface
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISvcCliente" in both code and config file together.
    [ServiceContract]
    public interface ISvcCliente : IGenericService<ClienteRepository>
    {
        [OperationContract]
        [EfDataContractSerializer]
        void SetAddEntity(Cliente param);

        [OperationContract]
        [EfDataContractSerializer]
        void SetAddUpdateEntity(Cliente param);

        [OperationContract]
        [EfDataContractSerializer]
        void SetAddRemoveEntity(Cliente param);
    }
}
