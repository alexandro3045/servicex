using Ninject;
using wcf_ninject.DI;
using Ninject.Web.Common;

namespace Wcf_ServiceX
{
    public class Global : NinjectHttpApplication
    {
        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel(new WCFNinjectModule());
            return kernel;
        }
    }
}