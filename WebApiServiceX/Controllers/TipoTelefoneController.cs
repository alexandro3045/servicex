using WebApiServiceX.Clients.ClientBase;
using WebApiServiceX.Controllers.ControllerBase;


namespace WebApiServiceX.Controllers
{
    //using WebApiServiceX.Controllers.ControllerBase;

    public class TipoTelefoneController : BaseApiController<SvcTipoTelefoneClient>, ITipoTelefoneController, IBaseApiController
    {

        //public TipoTelefoneController(ServiceBase provider) : base(provider)
        //{
        //    _service = provider;
        //}


        //public TipoTelefoneController(ServiceClientWrapper<SvcTipoTelefoneClient> provider) : base(provider)
        //{
        //    _service = 
        //}

        //private readonly IBaseApiController _controler;
        //public TipoTelefoneController(BaseApiController<WebApiServiceX.Clients.ClientBase.ServiceBase> controler)
        //{
        //    _controler = controler;
        //}



        //public IHttpActionResult GetResult(int pageIndex = 0, int pageSize = 25, string orderby = "cod", bool desc = false)
        //{
        //    //ObjectContractOfTipoTelefonechDCM5K5 objContract = _service.PaginateEntity(pageIndex, pageSize, orderby, desc);// re.PaginateEntityResult;
        //    //_service.Complete();
        //    return Ok(1);
        //}

        //private IHttpActionResult Ok(int v)
        //{
        //    throw new NotImplementedException();
        //}
        public TipoTelefoneController(ServiceBase provider) : base(provider)
        {
        }
    }
}
