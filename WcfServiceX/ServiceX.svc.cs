using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Repositorio.Generic.Utils;
using System.Linq.Expressions;
using Infraestrutura;
using Ninject;
using Model;

namespace WcfServiceX
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceX : IServiceX
    {
        //[Inject]
        //public Repositorio.TipoTelefoneRepository<TipoTelefone,int> tipoTelefoneRepository { get; set; }

        public string GetData(int value)
        {
            throw new NotImplementedException();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }
        //[System.Runtime.CompilerServices.Dependency("TipoTelefoneRepository")]
        //IRepository<Entity, int> repository = IServiceProvider;

    }
}
