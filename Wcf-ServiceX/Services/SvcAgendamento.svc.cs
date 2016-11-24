using Model;
using Repositorio;
using Wcf_ServiceX.Generic;

namespace Wcf_ServiceX.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SvcAgendamento" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SvcAgendamento.svc or SvcAgendamento.svc.cs at the Solution Explorer and start debugging.
    public class SvcAgendamento : GenericService<AgendamentoRepository>, ISvcAgendamento
    {
        public SvcAgendamento(AgendamentoRepository repository)
        {
            Initialize(repository);
        }

        public void SetAddEntity(Agendamento param)
        {
            AddEntity(param);
            AddEntities();
        }

        public void SetAddUpdateEntity(Agendamento param)
        {
            AddUpdateEntity(param);
            SalvarEntities();
        }

        public void SetAddRemoveEntity(Agendamento param)
        {
            AddRemoveEntity(param);
            RemoveEntities();
        }
    }
}
