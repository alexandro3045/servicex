using System;
using System.ServiceModel.Description;
using System.Reflection;

namespace Wcf_ServiceX.Decorator.JsonSerialization
{
    public class JsonDataContractBehaviorAttribute : Attribute, IContractBehavior
    {
        public void AddBindingParameters(ContractDescription contractDescription, ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyClientBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime)
        {
            this.ReplaceSerializerOperationBehavior(contractDescription);
        }

        public void ApplyDispatchBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.DispatchRuntime dispatchRuntime)
        {
            this.ReplaceSerializerOperationBehavior(contractDescription);
        }

        public void Validate(ContractDescription contractDescription, ServiceEndpoint endpoint)
        {
            foreach (OperationDescription operation in contractDescription.Operations)
            {
                foreach (MessageDescription message in operation.Messages)
                {
                    this.ValidateMessagePartDescription(message.Body.ReturnValue);
                    foreach (MessagePartDescription part in message.Body.Parts)
                    {
                        this.ValidateMessagePartDescription(part);
                    }

                    foreach (MessageHeaderDescription header in message.Headers)
                    {
                        this.ValidateJsonSerializableType(header.Type);
                    }
                }
            }
        }

        private void ReplaceSerializerOperationBehavior(ContractDescription contract)
        {
            foreach (OperationDescription od in contract.Operations)
            {
                for (int i = 0; i < od.Behaviors.Count; i++)
                {
                    DataContractSerializerOperationBehavior dcsob = od.Behaviors[i] as DataContractSerializerOperationBehavior;
                    if (dcsob != null)
                    {
                        od.Behaviors[i] = new DataContractJsonSerializerOperationBehavior(od);
                    }
                }
            }
        }

        private void ValidateMessagePartDescription(MessagePartDescription part)
        {
            if (part != null)
            {
                this.ValidateJsonSerializableType(part.Type);
            }
        }

        private void ValidateJsonSerializableType(Type type)
        {
            if (type != typeof(void))
            {
                if (!type.IsPublic)
                {
                    throw new InvalidOperationException("Json serialization is supported in public types only");
                }

                ConstructorInfo defaultConstructor = type.GetConstructor(new Type[0]);
                if (defaultConstructor == null && !type.IsPrimitive)
                {
                    throw new InvalidOperationException("Json serializable types must have a public, parameterless constructor");
                }
            }

        }
    }
}
