using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApiServiceX.SvcTipoTelefone;

namespace WebApiServiceX.Controllers
{

    //[RoutePrefix("servicex/tipotelefone")]

    //[Authorize]
    public class TipoTelefoneController : ApiController
    {
        private readonly ISvcTipoTelefone _service;

        public TipoTelefoneController(SvcTipoTelefoneClient service)
        {
            _service = service;// new SvcTipoTelefoneClient();
        }

        //[HttpGet]
        //[Route("tipotelefones/{Id}/orders")]
        [HttpGet]
        public IHttpActionResult GetTipoTelefones(int pageIndex =1, int pageSize = 25)
        {
            PaginateResponse re = _service.Paginate(new PaginateRequest(pageIndex, pageSize));
            
            return Ok(re.PaginateResult);
        }

    }
}
