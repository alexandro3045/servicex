using Infraestrutura;

namespace Repositorio
{

    public class TelaRepository<TEntity> : Repository<TEntity, int>
      where TEntity : Entity
    {
        #region singleton Instance
        private static TelaRepository<TEntity> _instance;

        public static TelaRepository<TEntity> Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TelaRepository<TEntity>();

                return _instance;
            }
        }
        #endregion
    }
}
