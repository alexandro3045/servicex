using System;
using Infraestrutura;
using Model;
using Repositorio.Generic.Utils;
using Repositorio.Interface;
using System.ServiceModel;

namespace Repositorio
{

    public class TipoTelefoneRepository : Repository<TipoTelefone, int>, ITipoTelefoneRepository,IRepository<TipoTelefone>

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

        //public new PaginatedList<Entity> PaginateEntity(int pageSize, int pageIndex, string orderby = "cod", bool desc = false)
        //{
        //    throw new NotImplementedException();
        //}

        //PaginatedList<Entity> IRepository<Entity, int>.Paginate(int pageSize, int pageIndex, string orderby, bool desc)
        //{
        //    throw new NotImplementedException();
        //}




        #endregion
    }
}

