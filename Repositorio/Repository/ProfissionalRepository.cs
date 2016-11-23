using Infraestrutura;
using Model;

namespace Repositorio
{

    public class ProfissionalRepository: Repository<Profissional, int>, IRepository
    {
        #region singleton Instance
        private static ProfissionalRepository _instance;

        public static new ProfissionalRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProfissionalRepository();

                return _instance;
            }
        }
        #endregion
    }

}
