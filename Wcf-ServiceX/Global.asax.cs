using Ninject;
using Ninject.Extensions.Wcf;
using wcf_ninject.DI;

namespace Wcf_ServiceX
{
    public class Global : NinjectWcfApplication
    {
        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel(new WCFNinjectModule());
            return kernel;
        }
    }
}