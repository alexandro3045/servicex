using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApiServiceX.Controllers.ControllerBase
{
    public interface IBaseApiController
    {
        IHttpActionResult GetResult(int pageIndex = 0, int pageSize = 25, string orderby = "cod", bool desc = false);
    }
}