using Ninject.Modules;
using Repositorio;

namespace wcf_ninject.DI
{
    public class WCFNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository>().To<TipoTelefoneRepository>();
            Bind<IRepository>().To<UsuarioRepository>();
            Bind<IRepository>().To<TelefonesProfRepository>();
            Bind<IRepository>().To<TelefonesCliRepository>();
            Bind<IRepository>().To<TelaRepository>();
            Bind<IRepository>().To<ServicoRepository>();
            Bind<IRepository>().To<ProfissionalRepository>();
            Bind<IRepository>().To<PerfilRepository>();
            Bind<IRepository>().To<PerfilAcessoRepository>();
            Bind<IRepository>().To<EspecialidadeRepository>();
            Bind<IRepository>().To<ClienteRepository>();
            Bind<IRepository>().To<AgendamentoRepository>();
        }
    }
}