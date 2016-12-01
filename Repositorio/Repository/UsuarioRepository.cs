using Infraestrutura;
using Model;
using Repositorio.Generic.Utils;
using System;

namespace Repositorio
{

    public class UsuarioRepository : Repository<Usuario, int>, IRepository
    {
        #region singleton Instance
        private static UsuarioRepository _instance;

        public static new UsuarioRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UsuarioRepository();

                return _instance;
            }
        }


        #endregion
    }
}
