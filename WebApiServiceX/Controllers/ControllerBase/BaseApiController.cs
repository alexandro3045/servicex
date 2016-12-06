using System.Web.Http;
using Wcf_ServiceX.ServiceEvents;
using WebApiServiceX.Clients.ClientBase;


namespace WebApiServiceX.Controllers.ControllerBase
{
    public   class BaseApiController<TChannel> : ApiController,IBaseApiController
         where TChannel : class
    {
        public ServiceBase _service;
        public BaseApiController(ServiceBase provider)
        {
            _service = provider;
        }


        [HttpGet]
        [Route("servicex/{controller}/{pageIndex}/{pageSize}/{orderby}/{desc}")]
        public IHttpActionResult GetResult(int pageIndex = 0, int pageSize = 25, string orderby = "cod", bool desc = false)
        {
            //PaginateEntityResponse response = _service.PaginateEntity(new PaginateEntityRequest(pageIndex, pageSize, orderby, desc));// re.PaginateEntityResult;
            //_service.Complete(new CompleteRequest());
            //return Ok(response.PaginateEntityResult);
            
            var response = _service.PaginateEntity(new PaginateEntityRequest() { pageIndex = pageIndex,pageSize = pageSize,orderby = orderby,desc= desc});

            _service.Complete(new CompleteRequest());

            return Ok(response.PaginateEntityResult);
        }

        //private ILearningRepository _repo;
        //private ModelFactory _modelFactory;

        //public BaseApiController(ILearningRepository repo)
        //{
        //    _repo = repo;
        //}

        //protected ModelFactory TheModelFactory
        //{
        //    get
        //    {
        //        if (_modelFactory == null)
        //        {
        //            _modelFactory = new ModelFactory(Request, TheRepository);
        //        }
        //        return _modelFactory;
        //    }
        //}

        //protected ILearningRepository TheRepository
        //{
        //    get
        //    {
        //        return _repo;
        //    }
        //}
    }

    
}
