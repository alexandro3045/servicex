using Infraestrutura;

namespace Repositorio
{

    public class ProfissionalRepository<TEntity> : Repository<TEntity, int>
      where TEntity : Entity
    {
        #region singleton Instance
        private static ProfissionalRepository<TEntity> _instance;

        public static ProfissionalRepository<TEntity> Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProfissionalRepository<TEntity>();

                return _instance;
            }
        }
        #endregion
    }

}
