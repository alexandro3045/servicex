using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfServiceXY;
using WcfServiceXY.Generic;
using Infraestrutura;
using Repositorio.Generic.Utils;

namespace WcfServiceXY.Generic
{

    public abstract class ServiceX<TEntity, TId> : IServiceX
        where TEntity : IEntity<TId>
        where TId : struct
    {

        public IRepository _repo;

        public void Commit()
        {
            _repo.Commit();
        }

        public void Salvar(Entity cls)
        {
            _repo.Salvar(cls);
        }

        public void Adicionar(Entity cls)
        {
            _repo.Adicionar(cls);
        }

        public void Remover(Entity cls)
        {
            _repo.Remover(cls);
        }

        PaginatedList<Entity> IServiceX.Paginate(int pageIndex, int pageSize)
        {
            return _repo.Paginate(pageIndex, pageSize);
        }

    }
}