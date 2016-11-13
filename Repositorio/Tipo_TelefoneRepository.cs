using Infraestrutura;

namespace Repositorio
{

    public class Tipo_TelefoneRepository<TEntity> : Repository<TEntity, int>
        where TEntity : Entity
    {
        #region singleton Instance
        private static Tipo_TelefoneRepository<TEntity> _instance;

        public static Tipo_TelefoneRepository<TEntity> Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Tipo_TelefoneRepository<TEntity>();

                return _instance;
            }
        }
        #endregion
    }
}

