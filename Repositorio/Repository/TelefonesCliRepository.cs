using Infraestrutura;
using Model;

namespace Repositorio
{

    public class TelefonesCliRepository : Repository<TelsClients, int>//, IRepository
    {
        #region singleton Instance
        private static TelefonesCliRepository _instance;

        public static new TelefonesCliRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TelefonesCliRepository();

                return _instance;
            }
        }
        #endregion
    }

}
