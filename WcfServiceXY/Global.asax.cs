using Ninject;
using Ninject.Extensions.Wcf;

namespace WcfServiceXY
{
    public class Global : NinjectWcfApplication
    {

        protected override IKernel CreateKernel()
        {
            return new StandardKernel(new WCFNinjectModule());//(new NinjectDependencyResolver());
        }
    }
}