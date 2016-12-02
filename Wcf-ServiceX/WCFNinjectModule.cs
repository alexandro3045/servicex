using Model;
using Ninject.Modules;
using Repositorio;
using Repositorio.Interface;
using Wcf_ServiceX.Generic;

namespace WcfServiceXY
{
    public class WCFNinjectModule : NinjectModule
    {
        public override void Load()
        {
            //Injects the constructors of all DI-ed objects 
            //with a LinqToSQL implementation of IRepository
            Bind<ITipoTelefoneRepository>().To<TipoTelefoneRepository>().InSingletonScope();//.InSingletonScope();
            Bind<IGenericService<TipoTelefone>>().To<GenericService<TipoTelefone>>().InSingletonScope();//.InSingletonScope();

            //Bind<IRepository<TipoTelefone>>();
        }
    }
}
