using System;
using Infraestrutura;
using Model;
using Repositorio.Generic.Utils;
using Repositorio.Interface;
using System.ServiceModel;

namespace Repositorio
{

    public class TipoTelefoneRepository : Repository<TipoTelefone, int>, IRepository

    {
        #region singleton Instance
        private static TipoTelefoneRepository _instance;
        public static new TipoTelefoneRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TipoTelefoneRepository();

                return _instance;
            }
        }




        #endregion
    }
}

