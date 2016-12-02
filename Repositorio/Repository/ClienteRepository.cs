using Infraestrutura;
using Model;
using System.Reflection;
using Repositorio.Generic.Utils;
using System;

namespace Repositorio
{

    public class ClienteRepository : Repository<Cliente, int>//, IRepository
    {
        #region singleton Instance
        private static ClienteRepository _instance;

        public static new ClienteRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ClienteRepository();

                return _instance;
            }
        }

        #endregion
    }
}
