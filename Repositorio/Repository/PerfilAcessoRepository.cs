using Infraestrutura;
using Model;

namespace Repositorio
{
    public class PerfilAcessoRepository : Repository<PerfilAcesso, int>, IRepository
    {
        #region singleton Instance
        private static PerfilAcessoRepository _instance;

        public static new PerfilAcessoRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PerfilAcessoRepository();

                return _instance;
            }
        }
        #endregion
    }

}
