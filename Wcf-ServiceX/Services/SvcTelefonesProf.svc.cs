using Model;
using Repositorio;
using Wcf_ServiceX.Generic;
using Wcf_ServiceX.Interface;

namespace Wcf_ServiceX.Services
{
    public class SvcTelefonesProf : GenericService<TelefonesProfRepository>, ISvcTelefonesProf
    {
        public SvcTelefonesProf(TelefonesProfRepository repository)
        {
            Initialize(repository);
        }

        public void SetAddEntity(TelsProfissionals param)
        {
            AddEntity(param);
            AddEntities();
        }

        public void SetAddUpdateEntity(TelsProfissionals param)
        {
            AddUpdateEntity(param);
            SalvarEntities();
        }

        public void SetAddRemoveEntity(TelsProfissionals param)
        {
            AddRemoveEntity(param);
            RemoveEntities();
        }
    }
}
