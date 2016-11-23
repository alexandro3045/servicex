
using Model;
using Repositorio;
using Wcf_ServiceX.Generic;
using Wcf_ServiceX.Interface;

namespace Wcf_ServiceX.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SvcPerfil" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SvcPerfil.svc or SvcPerfil.svc.cs at the Solution Explorer and start debugging.
    public class SvcPerfil : GenericService<PerfilRepository>, ISvcPerfil
    {
        public SvcPerfil(PerfilRepository repository)
        {
            Initialize(repository);
            //_repo = repository;
        }

        public void SetAddEntity(Perfil param)
        {
            AddEntity(param);
            AddEntities();
        }

        public void SetAddUpdateEntity(Perfil param)
        {
            AddUpdateEntity(param);
            SalvarEntities();
        }

        public void SetAddRemoveEntity(Perfil param)
        {
            AddRemoveEntity(param);
            RemoveEntities();
        }
    }
}
