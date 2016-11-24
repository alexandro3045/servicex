using Infraestrutura;
using Repositorio.Generic.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceXY.Generic
{
    public interface IServiceX
    {

        [OperationContract]
        void Commit();

        [OperationContract]
        void Salvar(Entity cls);

        [OperationContract]
        void Adicionar(Entity cls);

        [OperationContract]
        void Remover(Entity cls);
      
        [OperationContract]
        PaginatedList<Entity> Paginate(int pageIndex, int pageSize);

    }
}
