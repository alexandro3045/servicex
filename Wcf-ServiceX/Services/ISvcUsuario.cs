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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISvcUsuario" in both code and config file together.
    [ServiceContract]
    public interface ISvcUsuario : IGenericService<UsuarioRepository>
    {
        [OperationContract]
        [EfDataContractSerializer]
        void SetAddEntity(Usuario param);

        [OperationContract]
        [EfDataContractSerializer]
        void SetAddUpdateEntity(Usuario param);

        [OperationContract]
        [EfDataContractSerializer]
        void SetAddRemoveEntity(Usuario param);
    }
}
