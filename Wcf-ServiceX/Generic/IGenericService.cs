using Infraestrutura;
using Model;
using Repositorio;
using Repositorio.Generic.Utils;
using System.ServiceModel;
using Wcf_ServiceX.Decorator;

namespace Wcf_ServiceX.Generic
{
    [ServiceContract]
    public interface IGenericService<TRep, TEntity>
    {
        [OperationContract]
        [EfDataContractSerializer]
        void Initialize();

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

        //[OperationContract]
        //[EfDataContractSerializer]
        //void Salvar(Entity cls);

        //[OperationContract]
        //[EfDataContractSerializer]
        //void SalvarEntities();

        [OperationContract]
        [EfDataContractSerializer]
        void Add(TEntity param);

        [OperationContract]
        [EfDataContractSerializer]
        void Update(TEntity param);

        [OperationContract]
        [EfDataContractSerializer]
        void Remove(TEntity param);

        //[OperationContract]
        //[EfDataContractSerializer]
        //PaginatedList<TEntity> Paginate(int pageIndex, int pageSize);



        //[OperationContract]
        //[EfDataContractSerializer]
        //void Adicionar();

        //[OperationContract]
        //[EfDataContractSerializer]
        //void AddEntities(TEntity clas);

        //[OperationContract]
        //[EfDataContractSerializer]
        //void Remover(Entity cls);

        //[OperationContract]
        //[EfDataContractSerializer]
        //void RemoverEntities();


    }
}
