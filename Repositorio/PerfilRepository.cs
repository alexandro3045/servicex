using Infraestrutura;

namespace Repositorio
{
    public class PerfilRepository<TEntity> : Repository<TEntity, int>
      where TEntity : Entity
    {
        #region singleton Instance
        private static PerfilRepository<TEntity> _instance;

        public static PerfilRepository<TEntity> Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PerfilRepository<TEntity>();

                return _instance;
            }
        }
        #endregion
    }
}
