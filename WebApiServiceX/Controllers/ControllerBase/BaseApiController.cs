using System.Web.Http;
using WebApiServiceX.Clients.ClientBase;

namespace WebApiServiceX.Controllers.ControllerBase
{
    public abstract class BaseApiController<TChannel> : ApiController, IBaseApiController
         where TChannel : class
    {
        protected ServiceClientBase _service;
        public BaseApiController(ServiceClientBase provider)
        {
            _service = provider;           
        }


        [HttpGet]
        public IHttpActionResult Get(int pageIndex = 0, int pageSize = 25, string orderby = "cod", bool desc = false)
        {
            //PaginateEntityResponse response = _service.PaginateEntity(new PaginateEntityRequest(pageIndex, pageSize, orderby, desc));// re.PaginateEntityResult;
            //_service.Complete(new CompleteRequest());
            //return Ok(response.PaginateEntityResult);

            var request = new SvcTipoTelefone.PaginateEntityRequest(pageIndex, pageSize, orderby, desc);

            SvcTipoTelefone.PaginateEntityResponse response = _service.PaginateEntity(request);

            _service.Complete(new SvcTipoTelefone.CompleteRequest());

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
