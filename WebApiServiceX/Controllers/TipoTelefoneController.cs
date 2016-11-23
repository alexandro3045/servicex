using System.Collections.Generic;
using System.Web.Http;
using WebApiServiceX.ServiceXRef;

namespace WebApiServiceX.Controllers
{
    public class TipoTelefoneController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            //ServiceXYClient cliente = new ServiceXYClient();// ServiceXY(ServiceType.TipoTelefoneRepository);
            //DeletePersistenteRequest req = new DeletePersistenteRequest();
            //req.entidade = new object({ id = 0, nome = "a" });
            //cliente.DeletePersistente(req);
            return Ok(new List<int>() { 1, 2, 3 });
        }
    }
}
