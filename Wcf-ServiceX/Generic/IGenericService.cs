using Infraestrutura;
using Repositorio.Generic.Utils;
using System.ServiceModel;
using Wcf_ServiceX.Decorator;
using Wcf_ServiceX.Decorator.JsonSerialization;

namespace Wcf_ServiceX.Generic
{
    [JsonDataContractBehavior]
    [ServiceContract]
    public interface IGenericService<TRep, TEntity>
        where TEntity : Entity
    {

        [OperationContract]
        //[EfDataContractSerializer]
        void Complete();

        
        [OperationContract]
        //[EfDataContractSerializer]
        void Add(TEntity param);

        [OperationContract]
        //[EfDataContractSerializer]
        void Update(TEntity param);

        [OperationContract]
        //[EfDataContractSerializer]
        void Remove(TEntity param);

        [OperationContract]
        //[EfDataContractSerializer]
        //[ReferencePreservingDataContractFormat]
        [ReferencePreservingDataContractFormatAttribute]
        PaginatedList<Entity> Paginate(int pageIndex, int pageSize);

        [OperationContract]
        //[EfDataContractSerializer]
        //[ReferencePreservingDataContractFormat]
        [ReferencePreservingDataContractFormatAttribute]
        ObjectContract<TEntity> PaginateEntity(int pageIndex, int pageSize, string orderby, bool desc);
        //PaginatedList<TEntity> PaginateEntity(int pageIndex, int pageSize, string orderby = "cod", bool desc = false);

    }
}
