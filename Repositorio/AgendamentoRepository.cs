using Infraestrutura;

namespace Repositorio
{
    public class AgendamentoRepository<TEntity> : Repository<TEntity, int>
     where TEntity : Entity
    {
        #region singleton Instance
        private static AgendamentoRepository<TEntity> _instance;

        public static AgendamentoRepository<TEntity> Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AgendamentoRepository<TEntity>();

                return _instance;
            }
        }
        #endregion
    }
}
