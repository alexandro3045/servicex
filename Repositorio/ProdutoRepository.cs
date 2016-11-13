using Infraestrutura;

namespace Repositorio
{

    public class ProdutoRepository<TEntity> : Repository<TEntity, int>
      where TEntity : Entity
    {
        #region singleton Instance
        private static ProdutoRepository<TEntity> _instance;

        public static ProdutoRepository<TEntity> Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProdutoRepository<TEntity>();

                return _instance;
            }
        }
        #endregion
    }


}
