using Model;
using System.ServiceModel;


namespace WcfServiceXY.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITipoTelefoneService" in both code and config file together.
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface ITipoTelefoneService : IServiceXY<TipoTelefone, int>
    {
      
    }
}
