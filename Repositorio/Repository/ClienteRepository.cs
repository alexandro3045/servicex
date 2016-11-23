using Infraestrutura;
using Model;
using System.Reflection;

namespace Repositorio
{

    public class ClienteRepository : Repository<Cliente, int>, IRepository
    {
        #region singleton Instance
        private static ClienteRepository _instance;

        public static new ClienteRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ClienteRepository();

                return _instance;
            }
        }
        #endregion
    }
}
