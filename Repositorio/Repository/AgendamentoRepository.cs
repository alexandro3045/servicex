using Model;

namespace Repositorio
{
    public class AgendamentoRepository : Repository<Agendamento, int>, IRepository
    {
        #region singleton Instance
        private static AgendamentoRepository _instance;

        public static new AgendamentoRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AgendamentoRepository();

                return _instance;
            }
        }
        #endregion
    }
}
