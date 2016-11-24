using System;
using Model;
using Repositorio;

namespace WcfServiceXY.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SVCTipoTelefone" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SVCTipoTelefone.svc or SVCTipoTelefone.svc.cs at the Solution Explorer and start debugging.
    public class SVCTipoTelefone : Generic.ServiceX<TipoTelefone,int>,ISVCTipoTelefone
    {
        
        public SVCTipoTelefone(IRepository repository)
        {
            this._repo = TipoTelefoneRepository.Instance;
        }

        public void doWork()
        {
            throw new NotImplementedException();
        }
    }
}
