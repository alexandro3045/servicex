using Infraestrutura;
using Model;
using Repositorio;
using Repositorio.Generic.Utils;
using System.ServiceModel;
using Wcf_ServiceX.Decorator;
using Wcf_ServiceX.Generic;

namespace Wcf_ServiceX.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISvcTipoTelefone" in both code and config file together.
    [ServiceContract(Namespace = "https://Wcf-ServiceX/services/ISvcTipoTelefone/",SessionMode =SessionMode.Allowed)]
    public interface ISvcTipoTelefone : IGenericService<TipoTelefoneRepository, TipoTelefone>
    {

        //[OperationContract]
        //// [EfDataContractSerializer]
        //void InitializeRepository();

        ////[OperationContract]
        ////void Initialize(rep);

        //[OperationContract]
        ////[EfDataContractSerializer]
        //void Complete();

        //[OperationContract]
        ////[EfDataContractSerializer]
        //void Add(TipoTelefone param);

        //[OperationContract]
        ////[EfDataContractSerializer]
        //void Update(TipoTelefone param);

        //[OperationContract]
        ////[EfDataContractSerializer]
        //void Remove(TipoTelefone param);

        ////[OperationContract]
        //////[EfDataContractSerializer]
        //////[ReferencePreservingDataContractFormat]
        ////[ReferencePreservingDataContractFormatAttribute]
        ////PaginatedList<Entity> Paginate(int pageIndex, int pageSize);

        //[OperationContract]
        ////[EfDataContractSerializer]
        ////[ReferencePreservingDataContractFormat]
        //[ReferencePreservingDataContractFormatAttribute]
        //PaginatedList<TipoTelefone> PaginateEntity(int pageIndex, int pageSize, string orderby = "cod", bool desc = false);

    }

}
