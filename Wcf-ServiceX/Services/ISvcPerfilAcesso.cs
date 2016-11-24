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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISvcPerfilAcesso" in both code and config file together.
    [ServiceContract]
    public interface ISvcPerfilAcesso : IGenericService<PerfilAcessoRepository>
    {
        [OperationContract]
        [EfDataContractSerializer]
        void SetAddEntity(PerfilAcesso param);

        [OperationContract]
        [EfDataContractSerializer]
        void SetAddUpdateEntity(PerfilAcesso param);

        [OperationContract]
        [EfDataContractSerializer]
        void SetAddRemoveEntity(PerfilAcesso param);
    }
}
