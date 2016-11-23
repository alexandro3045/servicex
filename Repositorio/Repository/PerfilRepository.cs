using Infraestrutura;
using Model;

namespace Repositorio
{
    public class PerfilRepository : Repository<Perfil, int>, IRepository
    {
        #region singleton Instance
        private static PerfilRepository _instance;

        public static new PerfilRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PerfilRepository();

                return _instance;
            }
        }
        #endregion
    }
}
