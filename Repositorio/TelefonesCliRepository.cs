using Infraestrutura;

namespace Repositorio
{

    public class TelefonesCliRepository<TEntity> : Repository<TEntity, int>
      where TEntity : Entity
    {
        #region singleton Instance
        private static TelefonesCliRepository<TEntity> _instance;

        public static TelefonesCliRepository<TEntity> Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TelefonesCliRepository<TEntity>();

                return _instance;
            }
        }
        #endregion
    }

}
