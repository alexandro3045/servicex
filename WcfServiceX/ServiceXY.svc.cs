using Infraestrutura;
using Repositorio;
using Repositorio.Generic.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceX
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceXY" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceXY.svc or ServiceXY.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class ServiceXY : IServiceXY
    {
        private IRepository _repo;

        public ServiceXY(IRepository repository)
        {
            _repo = repository;
        }

        public void Adicionar(Entity cls)
        {
            _repo.Adicionar(cls);
        }

        public void DeletePersistente(Entity entidade)
        {
            _repo.DeletePersistente(entidade);
        }

        public void Dispose()
        {
            _repo.Dispose();
        }

        public void Commit()
        {
            _repo.Commit();
        }


        public PaginatedList<Entity> Paginate(int pageIndex, int pageSize)
        {
            return _repo.Paginate(pageIndex, pageSize);
        }

        public void Remover(Entity cls)
        {
            _repo.Remover(cls);
        }

        public void Salvar(Entity cls)
        {
            _repo.Salvar(cls);
        }


    }
}
