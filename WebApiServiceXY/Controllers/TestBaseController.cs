using System.Runtime.Remoting.Channels;
using System.ServiceModel;
using WebApiServiceX.Controllers.ControllerBase;
using WebApiServiceXY.SvcTipoTelefone;

namespace WebApiServiceXY.Controllers
{
    public class TestBaseController : BaseApiController<ISvcTipoTelefone>
    {

        public TestBaseController() : base("WSHttpContextBinding_ISvcTipoTelefone")
        {
        }

        //public TestBaseController(ClientBase<ISvcTipoTelefone> serviceType) : base(serviceType)
        //{
        //}

        //  readonly ISvcTipoTelefone _baseService;
        //public TestBaseController(ISvcTipoTelefone baseService) :  base(baseService)
        //{
        //    //_baseService = baseService;
        //    //repository = baseService;
        //    repository = baseService;
        //}

        //public IHttpActionResult Get2()
        //{
        //    //PaginateEntityResponse resp = _baseService.PaginateEntity(new PaginateEntityRequest() { pageIndex = 0, pageSize = 25, orderby = "cod", desc = false });
        //    PaginateEntityResponse resp = PaginateEntity( 0, 25, "cod", false );

        //    return Ok(resp);
        //}

        //private IHttpActionResult Ok(IHttpActionResult httpActionResult)
        //{
        //    return httpActionResult;
        //}

        //readonly IBaseApiController repository;
        //public TestBaseController(IBaseApiController repository)
        //{
        //    this.repository = repository;
        //}
        //[HttpGet]
        //public IHttpActionResult Get2()
        //{
        //    return Ok(repository.Get2());
        //}
        //public TestBaseController(IChannel repository) : base(repository)
        //{
        //}
        //public TestBaseController(ISvcTipoTelefone repository) : base(repository)
        //{
        //}

    }

    // Declare a delegate type for processing a book:
    //public delegate void ProcessBaseApiControllerDelegate(IBaseApiController baseApiController);
}
