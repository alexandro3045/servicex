using Repositorio;
using System;
using Infraestrutura;
using Repositorio.Generic.Utils;
using Contracts;
using AutoMapper;
using System.Xml.Serialization;
using System.ServiceModel;

namespace WcfServiceXY
{

    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public abstract class ServiceXY<TEntity, TId> : IServiceXY<TEntity, TId>
        where TEntity : IEntity<TId>
        where TId : struct
    {
        //private  Repositorio.IRepository _repo ;
       // private MapperConfiguration config;

        //RepositoryType _rtype;
        //public ServiceXY(RepositoryType rt)
        //{
        //    _rtype = rt;
        //    SetRepositoryType();
        //}

        //private void  SetRepositoryType()
        //{

        //    switch (_rtype)
        //    {
        //        case RepositoryType.TipoTelefoneRepository:
        //            _repo = new TipoTelefoneRepository();
        //            break;
        //        case RepositoryType.UsuarioRepository:
        //            _repo = (IRepository)new UsuarioRepository();
        //            break;
        //        case RepositoryType.TelefonesProfRepository:
        //            _repo = (IRepository)new TelefonesProfRepository();
        //            break;
        //        case RepositoryType.TelefonesCliRepository:
        //            _repo = (IRepository)new TelefonesCliRepository();
        //            break;
        //        case RepositoryType.TelaRepository:
        //            _repo = (IRepository)new TelaRepository();
        //            break;
        //        case RepositoryType.ServicoRepository:
        //            _repo = (IRepository)new ServicoRepository();
        //            break;
        //        case RepositoryType.ProfissionalRepository:
        //            _repo = (IRepository)new ProfissionalRepository();
        //            break;
        //        case RepositoryType.PerfilAcessoRepository:
        //            _repo = (IRepository)new PerfilAcessoRepository();
        //            break;
        //        case RepositoryType.EspecielidadeRepository:
        //            _repo = (IRepository)new EspecielidadeRepository();
        //            break;
        //        case RepositoryType.ClienteRepository:
        //            _repo = (IRepository)new ClienteRepository();
        //            break;
        //        case RepositoryType.AgendamentoRepository:
        //            _repo = (IRepository)new AgendamentoRepository();
        //            break;
        //        default:
        //            throw new InvalidOperationException("Couldn't process operation repository: " + _rtype);
        //    }

        //}

        public IRepository _repo;

        //public ServiceXY(IRepository repository)
        //{
        //    _repo = repository;
        //}


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

        //public Entity FindByID(int id)
        //{
        //    return _repo.FindByID(id);
        //}


        //public void InsertPersistente(Entity entity)
        //{
        //    _repo.InsertPersistente(entity);
        //}

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

        //public void UpdatePersistente(Entity entidade)
        //{
        //    _repo.UpdatePersistente(entidade);
        //}
        //_repo = repository;
    }
 
}
