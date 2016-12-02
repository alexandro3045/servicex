using System;
using System.Collections.Generic;
using System.ServiceModel.Description;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml;

namespace Wcf_ServiceX.Decorator.JsonSerialization
{
    public class DataContractJsonSerializerOperationBehavior : DataContractSerializerOperationBehavior
    {
        public DataContractJsonSerializerOperationBehavior(OperationDescription operation) : base(operation) { }

        public override XmlObjectSerializer CreateSerializer(Type type, string name, string ns, IList<Type> knownTypes)
        {
            return new DataContractJsonSerializer(type);
        }

        public override XmlObjectSerializer CreateSerializer(Type type, XmlDictionaryString name, XmlDictionaryString ns, IList<Type> knownTypes)
        {
            return new DataContractJsonSerializer(type);
        }
    }
}
