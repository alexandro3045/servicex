using Infraestrutura;
using Model;

namespace Repositorio
{

    public class TipoTelefoneRepository : Repository<TipoTelefone, int>
    {
        #region singleton Instance
        private static TipoTelefoneRepository _instance;

        public static TipoTelefoneRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TipoTelefoneRepository();

                return _instance;
            }
        }
        #endregion
    }
}

