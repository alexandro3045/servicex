using Infraestrutura;

namespace Repositorio
{

    public class UsuarioRepository<TEntity> : Repository<TEntity, int>
       where TEntity : Entity
    {
        #region singleton Instance
        private static UsuarioRepository<TEntity> _instance;

        public static UsuarioRepository<TEntity> Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UsuarioRepository<TEntity>();

                return _instance;
            }
        }
        #endregion
    }
}
