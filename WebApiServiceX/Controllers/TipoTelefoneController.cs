namespace WebApiServiceX.Controllers
{
    using WebApiServiceX.Controllers.ControllerBase;

    public class TipoTelefoneController : BaseApiController<SvcTipoTelefoneClient>
    {

        public TipoTelefoneController(SvcTipoTelefoneClient provider) : base(provider)
        {
            
        }

        //public TipoTelefoneController()
        //{
        //    _service = new ServiceClientWrapper<ClientBase.SvcTipoTelefoneClient>();
        //}

        //public TipoTelefoneController(ServiceClientWrapper<SvcTipoTelefoneClient> provider) : base(provider)
        //{
        //    _service = 
        //}

        //private readonly SvcTipoTelefoneClient _service;


        //public TipoTelefoneController(ServiceClientWrapper<SvcTipoTelefoneClient> provider)
        //{
        //    _service = provider;
        //}


        //[HttpGet]
        //public IHttpActionResult GetTipoTelefones(int pageIndex = 0, int pageSize = 25, string orderby = "cod", bool desc = false)
        //{
        //    ObjectContractOfTipoTelefonechDCM5K5 objContract = _service.PaginateEntity(pageIndex, pageSize, orderby, desc);// re.PaginateEntityResult;
        //    _service.Complete();
        //     return Ok(objContract);
        //}

    }
}
