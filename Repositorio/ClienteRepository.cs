using Infraestrutura;
using Model;
using System.Reflection;

namespace Repositorio
{

    public class ClienteRepository<TEntity> : Repository<TEntity, int>
     where TEntity : Entity
    {
        #region singleton Instance
        private static ClienteRepository<TEntity> _instance;

        public static ClienteRepository<TEntity> Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ClienteRepository<TEntity>();

                return _instance;
            }
        }
        #endregion
    }
}
