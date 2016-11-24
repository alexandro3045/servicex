using Model;
using Repositorio;
using Wcf_ServiceX.Generic;

namespace Wcf_ServiceX.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SvcUsuario" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SvcUsuario.svc or SvcUsuario.svc.cs at the Solution Explorer and start debugging.
    public class SvcUsuario :  GenericService<UsuarioRepository>, ISvcUsuario
    {
        public SvcUsuario(UsuarioRepository repository)
        {
            Initialize(repository);
            //_repo = repository;
        }

        public void SetAddEntity(Usuario param)
        {
            AddEntity(param);
            AddEntities();
        }

        public void SetAddUpdateEntity(Usuario param)
        {
            AddUpdateEntity(param);
            SalvarEntities();
        }

        public void SetAddRemoveEntity(Usuario param)
        {
            AddRemoveEntity(param);
            RemoveEntities();
        }
    }
}
