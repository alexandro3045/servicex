using Infraestrutura;
using Repositorio.Generic.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceX
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceXY" in both code and config file together.
    [ServiceContract]
    public interface IServiceXY
    {
        [OperationContract]
        void Salvar(Entity cls);

        [OperationContract]
        void Adicionar(Entity cls);

        [OperationContract]
        void Remover(Entity cls);

        [OperationContract]
        void Dispose();

        [OperationContract]
        void Commit();

        [OperationContract]
        PaginatedList<Entity> Paginate(int pageIndex, int pageSize);
    }
}
