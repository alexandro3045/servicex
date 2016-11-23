using System;
using Infraestrutura;
using Model;
using Repositorio.Generic.Utils;

namespace Repositorio
{
    public class TelefonesProfRepository : Repository<TelsProfissionals,int>, IRepository
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

        PaginatedList<Entity> IRepository<Entity, int>.Paginate(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
