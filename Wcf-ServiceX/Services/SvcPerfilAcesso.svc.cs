
using Model;
using Repositorio;
using Wcf_ServiceX.Generic;

namespace Wcf_ServiceX.Services
{
    public class SvcPerfilAcesso : GenericService<PerfilAcessoRepository>, ISvcPerfilAcesso
    {
        public SvcPerfilAcesso(PerfilAcessoRepository repository)
        {
            Initialize(repository);
        }

        public void SetAddEntity(PerfilAcesso param)
        {
            AddEntity(param);
            AddEntities();
        }

        public void SetAddUpdateEntity(PerfilAcesso param)
        {
            AddUpdateEntity(param);
            SalvarEntities();
        }

        public void SetAddRemoveEntity(PerfilAcesso param)
        {
            AddRemoveEntity(param);
            RemoveEntities();
        }
    }
}
