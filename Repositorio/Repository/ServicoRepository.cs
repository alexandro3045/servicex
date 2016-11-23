using Infraestrutura;
using Model;

namespace Repositorio
{

    public class ServicoRepository : Repository<Servico, int>, IRepository
    {
        #region singleton Instance
        private static ServicoRepository _instance;

        public static new ServicoRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ServicoRepository();

                return _instance;
            }
        }
        #endregion
    }
}
