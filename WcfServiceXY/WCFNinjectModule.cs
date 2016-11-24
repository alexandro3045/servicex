using Model;
using Ninject.Modules;
using Repositorio;

namespace WcfServiceXY
{
    public class WCFNinjectModule : NinjectModule
    {
        public override void Load()
        {
            //Injects the constructors of all DI-ed objects 
            //with a LinqToSQL implementation of IRepository
            Bind<IRepository>().To<TipoTelefoneRepository>().InSingletonScope();//.InSingletonScope();
            //Bind<IRepository<TipoTelefone>>();
        }
    }
}
