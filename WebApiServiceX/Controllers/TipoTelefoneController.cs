using System.Collections.Generic;
using System.Web.Http;
using WebApiServiceX.SvcTipoTelefone;

namespace WebApiServiceX.Controllers
{
    [Route("ServiceX/TipoTelefones")]
    public class TipoTelefoneController : ApiController
    {
        private readonly ISvcTipoTelefone service;
        public TipoTelefoneController(ISvcTipoTelefone _service)
        {
            this.service = _service;
        }

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
