using Infraestrutura;

namespace Repositorio
{
    public class PerfilAcessoRepository<TEntity> : Repository<TEntity, int>
     where TEntity : Entity
    {
        #region singleton Instance
        private static PerfilAcessoRepository<TEntity> _instance;

        public static PerfilAcessoRepository<TEntity> Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PerfilAcessoRepository<TEntity>();

                return _instance;
            }
        }
        #endregion
    }

}
