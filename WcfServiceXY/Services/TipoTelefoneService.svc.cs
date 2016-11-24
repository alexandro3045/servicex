using Repositorio;
using Model;
using System.ServiceModel;

namespace WcfServiceXY.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TipoTelefoneService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TipoTelefoneService.svc or TipoTelefoneService.svc.cs at the Solution Explorer and start debugging.
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class TipoTelefoneService : ServiceXY<TipoTelefone, int>, ITipoTelefoneService
    { 
        public TipoTelefoneService(TipoTelefoneRepository repository) 
        {
            _repo = repository;
        }
    }
}
