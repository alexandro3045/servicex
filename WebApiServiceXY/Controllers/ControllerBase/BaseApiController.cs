using System;
using System.Runtime.Remoting.Channels;
using System.ServiceModel;
using System.Web.Http;
using WebApiServiceXY.Controllers.ServiceBase;
using WebApiServiceXY.ServiceClientHelper;
using WebApiServiceXY.SvcTipoTelefone;

namespace WebApiServiceX.Controllers.ControllerBase
{

    //public class PersonellProxy<T> where T : ISvcTipoTelefone
    //{

    //    public static System.ServiceModel.ClientBase<T> Connection
    //    {
    //        get
    //        {
    //            ClientBase<T> _connection = (T)Activator.CreateInstance(typeof(ClientBase<T>), new NetTcpBinding(), _endpoint);
    //            //_connection.ClientCredentials =    // Common methods on both classes.
    //         return _connection;
    //        }
    //    }
    //}
    public abstract class BaseApiController<Service> : ApiController, IDisposable
        where Service :  ISvcTipoTelefone
    {

        private Service _channel;
        public Service Channel
        {
            get { return _channel; }
        }

        private static ChannelFactory<Service> _channelFactory;

        public BaseApiController(string config)
        {
            //if (_channelFactory == null)
            // Given that the endpoint name is the same as FullName of contract.
            //var _endpoint = new EndpointAddress("http://localhost:2288/Services/SvcTipoTelefone.svc");
            //new 
            ////_channelFactory = new ChannelFactory<Service>(typeof(Service).FullName, _endpoint);
            //_channel = _channelFactory.CreateChannel();
            //_channelFactory.Open();

            _channelFactory = new ChannelFactory<Service>(config);
            var serviceHelper = new ServiceHelper<Service>(_channelFactory);
            _channel = serviceHelper.CreateChannel();
            //_channelFactory.Open();


        }


        public void Dispose()
        {
            try
            {
                _channelFactory.Close();
            }
            catch (Exception e)
            {
                _channelFactory.Abort();
                // TODO: Insert logging
            }
        }

        //[HttpGet]
        //public List<object> PaginateEntity(int pageIndex = 0, int pageSize = 25, string orderby = "cod", bool desc = false )
        //{
            

        //    //MethodInfo method = typeof(ServiceType).GetMethod("PaginateEntity",BindingFlags.Static | BindingFlags.Public);

        //    //Type[] listType = repository.GetType().GetGenericArguments();

        //    //MethodInfo concrete = method.MakeGenericMethod(listType);

        //    //List<object> objectList = (List<object>)concrete.Invoke(null,new object[] { pageIndex = 0, pageSize = 25, orderby = "cod", desc = false });

        //    object[] myList = new object[] { pageIndex = 0, pageSize = 25, orderby = "cod", desc = false };
        //    MethodInfo methods = repository.GetType().GetMethod("PaginateEntity");
        //    List<object> List = (List<object>)methods.Invoke(myList, new object[] { new Func<object[], object>(t => t) });


        //    return List;
        //}

        public void CompleteBase()
        {
            throw new NotImplementedException();
        }

        public void AddBase(object objAdd)
        {
            throw new NotImplementedException();
        }

        public void UpdateBase(object objAdd)
        {
            throw new NotImplementedException();
        }

        public void RemoveBase(object objectRemove)
        {
            throw new NotImplementedException();
        }

        public PaginateEntityResponse PaginateEntityBase(int pageIndex = 1, int pageSize = 25, string orderby = "code", bool desc=false)
        {
            PaginateEntityResponse response;
            using (_channel as IDisposable)
            {
                response = _channel.PaginateEntity(new PaginateEntityRequest() { desc = desc, orderby = orderby, pageIndex = pageIndex, pageSize = pageSize });
            }
           
            return response;

        }
    }

    public interface IServiceRepository<IChannel>
    {

    }

    public class ServiceRepository<IChannel> : /*ClientBase<IChannel>,*/ IServiceRepository<IChannel>
    {

    }

}
