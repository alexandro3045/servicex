using Domain;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Infraestrutura
{
    [Serializable]
    [DataContract(Namespace = DomainConstants.DataContractNamespace, IsReference = true)]
    public  class IEntity<TId>
      where TId : struct
    {
        [Key]
        [DataMember]
        public virtual TId cod { get; protected set; }

        [DataMember]
        public virtual byte[] ConcurrencyToken { get; set; }
    }

    [Serializable]
    [DataContract(Namespace = DomainConstants.DataContractNamespace, IsReference = true)]
    public class Entity : IEntity<int> { }
}
