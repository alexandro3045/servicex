using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApiServiceX.Web.Services;

namespace WebApiServiceX.Services
{
    public class TipoTelefoneControllerSelector : ControllerSelector
    {
        public TipoTelefoneControllerSelector(HttpConfiguration config) : base(config)
        {
        }
    }
}