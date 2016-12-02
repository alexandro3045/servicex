using System.CodeDom.Compiler;
using System.ServiceModel;

namespace WebApiServiceX.Clients.ClientBase
{
    [GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [ServiceContract(Namespace = "https://Wcf-ServiceX/services/ISvcTipoTelefone/", ConfigurationName = "SvcTipoTelefone.ISvcTipoTelefone")]

    public interface ServiceClientBase
    {
        //// CODEGEN: Generating message contract since the wrapper namespace (http://tempuri.org/) of message CompleteRequest does not match the default value (https://Wcf-ServiceX/services/ISvcTipoTelefone/)
        //[System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Complete" +
        //    "", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Complete" +
        //    "Response")]
        ///*WebApiServiceX.SvcTipoTelefone.*/
            CompleteResponse Complete(/*WebApiServiceX.SvcTipoTelefone.*/CompleteRequest request);

        //// CODEGEN: Generating message contract since the wrapper namespace (http://tempuri.org/) of message AddRequest does not match the default value (https://Wcf-ServiceX/services/ISvcTipoTelefone/)
        //[System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Add", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/AddRespo" +
        //    "nse")]
        ///*WebApiServiceX.SvcTipoTelefone.*/
            AddResponse Add(/*WebApiServiceX.SvcTipoTelefone.*/AddRequest request);

        //// CODEGEN: Generating message contract since the wrapper namespace (http://tempuri.org/) of message UpdateRequest does not match the default value (https://Wcf-ServiceX/services/ISvcTipoTelefone/)
        //[System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Update", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/UpdateRe" +
        //    "sponse")]
        //new /*WebApiServiceX.SvcTipoTelefone.*/
            UpdateResponse Update(/*WebApiServiceX.SvcTipoTelefone.*/UpdateRequest request);

        //// CODEGEN: Generating message contract since the wrapper namespace (http://tempuri.org/) of message RemoveRequest does not match the default value (https://Wcf-ServiceX/services/ISvcTipoTelefone/)
        //[System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Remove", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/RemoveRe" +
        //    "sponse")]
        ///*WebApiServiceX.SvcTipoTelefone.*/
            RemoveResponse Remove(/*WebApiServiceX.SvcTipoTelefone.*/RemoveRequest request);

        //// CODEGEN: Generating message contract since the wrapper namespace (http://tempuri.org/) of message PaginateRequest does not match the default value (https://Wcf-ServiceX/services/ISvcTipoTelefone/)
        //[System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Paginate" +
        //    "", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Paginate" +
        //    "Response")]
        ///*WebApiServiceX.SvcTipoTelefone.*/
            PaginateResponse Paginate(/*WebApiServiceX.SvcTipoTelefone.*/PaginateRequest request);

        //// CODEGEN: Generating message contract since the wrapper namespace (http://tempuri.org/) of message PaginateEntityRequest does not match the default value (https://Wcf-ServiceX/services/ISvcTipoTelefone/)
        //[System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Paginate" +
        //    "Entity", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Paginate" +
        //    "EntityResponse")]
        ///*WebApiServiceX.SvcTipoTelefone.*/
            PaginateEntityResponse PaginateEntity(/*WebApiServiceX.SvcTipoTelefone.*/PaginateEntityRequest request);


    }

}