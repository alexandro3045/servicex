using Infraestrutura;
using Model;
using Ninject.Modules;
using Repositorio;

namespace wcf_ninject.DI
{
    public class WCFNinjectModule : NinjectModule
    {
        public override void Load()
        {
            //Injects the constructors of all DI-ed objects 
            //with a LinqToSQL implementation of IRepository
            Bind<IRepository<Entity, int>>();//.To<TipoTelefoneRepository>();
            Bind<IRepository<Entity, int>>().To<TipoTelefoneRepository<TipoTelefone,int>>();
            //Bind<IRepository<Entity, int>>().To<TipoTelefoneRepository>();
        }
    }
}
