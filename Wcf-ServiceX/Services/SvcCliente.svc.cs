using Model;
using Repositorio;
using Wcf_ServiceX.Generic;
using Wcf_ServiceX.Interface;

namespace Wcf_ServiceX.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SvcCliente" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SvcCliente.svc or SvcCliente.svc.cs at the Solution Explorer and start debugging.
    public class SvcCliente : GenericService<ClienteRepository>, ISvcCliente
    {
        public SvcCliente(ClienteRepository repository)
        {
            Initialize(repository);
        }

        public void SetAddEntity(Cliente param)
        {
            AddEntity(param);
            AddEntities();
        }

        public void SetAddUpdateEntity(Cliente param)
        {
            AddUpdateEntity(param);
            SalvarEntities();
        }

        public void SetAddRemoveEntity(Cliente param)
        {
            AddRemoveEntity(param);
            RemoveEntities();
        }
    }
}
