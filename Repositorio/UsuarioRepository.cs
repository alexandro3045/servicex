﻿using Infraestrutura;
using Model;

namespace Repositorio
{

    public class UsuarioRepository : Repository<Usuario, int>
    {
        #region singleton Instance
        private static UsuarioRepository _instance;

        public static UsuarioRepository Instance
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
