using Infraestrutura;
using Model;

namespace Repositorio
{
    public class EspecialidadeRepository : Repository<Especialidade, int>, IRepository
    {
        #region singleton Instance
        private static EspecialidadeRepository _instance;

        public static new EspecialidadeRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EspecialidadeRepository();

                return _instance;
            }
        }
        #endregion
    }
}
