
using Model;
using Repositorio;
using Wcf_ServiceX.Generic;
using Wcf_ServiceX.Interface;

namespace Wcf_ServiceX.Services
{
    public class SvcEspecialidade : GenericService<EspecialidadeRepository>, ISvcEspecialidade
    {
        public SvcEspecialidade(EspecialidadeRepository repository)
        {
            Initialize(repository);
        }

        public void SetAddEntity(Especialidade param)
        {
            AddEntity(param);
            AddEntities();
        }

        public void SetAddUpdateEntity(Especialidade param)
        {
            AddUpdateEntity(param);
            SalvarEntities();
        }

        public void SetAddRemoveEntity(Especialidade param)
        {
            AddRemoveEntity(param);
            RemoveEntities();
        }
    }
}
