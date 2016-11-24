using Ninject.Extensions.Wcf;
using System;
using Ninject;
using wcf_ninject.DI;
using Ninject.Web.Common;
using Repositorio;
using Model;

namespace WcfServiceX
{
    public class Global : NinjectWcfApplication
    {
        protected override IKernel CreateKernel()
        {
            IKernel kernel = new StandardKernel();

            // Vendor Briefs. 
            kernel.Bind<TipoTelefoneRepository<TipoTelefone,int>>();//.To<TipoTelefoneRepository>().InRequestScope();
           // kernel.Bind<IRepository<TipoTelefone>>().To<TipoTelefoneRepository>().InRequestScope();

            return kernel;

        }
    }
}