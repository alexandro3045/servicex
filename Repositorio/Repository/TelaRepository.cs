using Infraestrutura;
using Model;

namespace Repositorio
{

    public class TelaRepository : Repository<Tela, int>, IRepository
    {
        #region singleton Instance
        private static TelaRepository _instance;

        public static new TelaRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TelaRepository();

                return _instance;
            }
        }
        #endregion
    }
}
