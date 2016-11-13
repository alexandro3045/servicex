using Infraestrutura;

namespace Repositorio
{
    public class EspecielidadeRepository<TEntity> : Repository<TEntity, int>
     where TEntity : Entity
    {


        #region singleton Instance
        private static EspecielidadeRepository<TEntity> _instance;

        public static EspecielidadeRepository<TEntity> Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EspecielidadeRepository<TEntity>();

                return _instance;
            }
        }
        #endregion
    }
}
