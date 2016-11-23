
using Model;
using Repositorio;
using Wcf_ServiceX.Generic;
using Wcf_ServiceX.Interface;

namespace Wcf_ServiceX.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SvcProfissional" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SvcProfissional.svc or SvcProfissional.svc.cs at the Solution Explorer and start debugging.
    public class SvcProfissional : GenericService<ProfissionalRepository>, ISvcProfissional
    {
        public SvcProfissional(ProfissionalRepository repository)
        {
            Initialize(repository);
            //_repo = repository;
        }

        public void SetAddEntity(Profissional param)
        {
            AddEntity(param);
            AddEntities();
        }

        public void SetAddUpdateEntity(Profissional param)
        {
            AddUpdateEntity(param);
            SalvarEntities();
        }

        public void SetAddRemoveEntity(Profissional param)
        {
            AddRemoveEntity(param);
            RemoveEntities();
        }
    }
}
