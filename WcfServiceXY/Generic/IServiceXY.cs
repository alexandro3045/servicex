using Contracts;
using Infraestrutura;
using Repositorio.Generic.Utils;
using System.Runtime.Serialization;
using System.ServiceModel;


namespace WcfServiceXY
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    //[ServiceContract(SessionMode = SessionMode.Required)]
    public interface IServiceXY<TEntity, TId>
        where TEntity : IEntity<TId>
        where TId : struct
    {
        //[OperationContract]
        //void ServiceXY(RepositoryType rt);

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


    [DataContract]
    public enum DomainType
    {
        [EnumMember]
        Repositorio
    }

        [DataContract]
    public enum RepositoryType
    {
        [EnumMember]
        UsuarioRepository,
        [EnumMember]
        TipoTelefoneRepository,
        [EnumMember]
        TelefonesProfRepository,
        [EnumMember]
        TelefonesCliRepository,
        [EnumMember]
        TelaRepository,
        [EnumMember]
        ServicoRepository,
        [EnumMember]
        ProfissionalRepository,
        [EnumMember]
        PerfilAcessoRepository,
        [EnumMember]
        EspecielidadeRepository,
        [EnumMember]
        ClienteRepository,
        [EnumMember]
        AgendamentoRepository

    }

   
}
