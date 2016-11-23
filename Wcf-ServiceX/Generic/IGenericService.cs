using Infraestrutura;
using Model;
using Repositorio;
using Repositorio.Generic.Utils;
using System.ServiceModel;
using Wcf_ServiceX.Decorator;

namespace Wcf_ServiceX.Generic
{
    [ServiceContract]
    public interface IGenericService<TRep>
       where TRep : IRepository
    {
        //[OperationContract]
        //[EfDataContractSerializer]
        //void Initialize<TRep>();

        [OperationContract]
        [EfDataContractSerializer]
        void Complete();

        //[OperationContract]
        //[EfDataContractSerializer]
        //void AddObjectSerialize(Entity _entity);

        //[OperationContract]
        //[EfDataContractSerializer]
        //void AddEntities(Entity _entity);

        //[OperationContract]
        //[EfDataContractSerializer]
        //void Set(Entity _entity);

        [OperationContract]
        [EfDataContractSerializer]
        void Salvar(Entity cls);

        [OperationContract]
        [EfDataContractSerializer]
        void SalvarEntities();

        [OperationContract]
        [EfDataContractSerializer]
        void AdicionarEntity(Entity cls);

        [OperationContract]
        [EfDataContractSerializer]
        void Adicionar();

        //[OperationContract]
        //[EfDataContractSerializer]
        //void AddEntities();

        [OperationContract]
        [EfDataContractSerializer]
        void Remover(Entity cls);

        [OperationContract]
        [EfDataContractSerializer]
        void RemoverEntities();

        [OperationContract]
        [EfDataContractSerializer]
        PaginatedList<Entity> Paginate(int pageIndex, int pageSize);
    }
}
