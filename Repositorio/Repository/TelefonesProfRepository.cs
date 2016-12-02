using System;
using Infraestrutura;
using Model;
using Repositorio.Generic.Utils;
using Repositorio.Interface;

namespace Repositorio
{
    public class TelefonesProfRepository : Repository<TelsProfissionals,int>, ITipoTelefoneRepository<TipoTelefone>
    {
        #region singleton Instance
        private static TelefonesProfRepository _instance;

        public static new TelefonesProfRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TelefonesProfRepository();

                return _instance;
            }
        }

        PaginatedList<Entity> IRepository<Entity, int>.Paginate(int pageSize, int pageIndex, string orderby, bool desc)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
