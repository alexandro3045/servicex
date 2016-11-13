using Infraestrutura;

namespace Repositorio
{
    public class TelefonesProfRepository<TEntity> : Repository<TEntity, int>
       where TEntity : Entity
    {
        #region singleton Instance
        private static TelefonesProfRepository<TEntity> _instance;

        public static TelefonesProfRepository<TEntity> Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TelefonesProfRepository<TEntity>();

                return _instance;
            }
        }
        #endregion
    }
}
