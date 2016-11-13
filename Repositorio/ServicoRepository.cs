using Infraestrutura;

namespace Repositorio
{

    public class ServicoRepository<TEntity> : Repository<TEntity, int>
     where TEntity : Entity
    {
        #region singleton Instance
        private static ServicoRepository<TEntity> _instance;

        public static ServicoRepository<TEntity> Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ServicoRepository<TEntity>();

                return _instance;
            }
        }
        #endregion
    }
}
