using System;
using System.Collections.Generic;
using System.Web.Http;

namespace WebApiServiceXY.Controllers
{
    public class TestController : ApiController
    {

        readonly IProductRepository repository;
        public TestController(IProductRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public IHttpActionResult Get1()
        {
            return Ok(new List<int>() { 1, 2, 3 ,4, repository.getVal(),9,6,4 });
        }
    }

    public interface IProductRepository
    {
        int getVal();
    }

    public class ProductRepository : IProductRepository
    {
        int IProductRepository.getVal()
        {
            return 5;
        }
        
    }
}
