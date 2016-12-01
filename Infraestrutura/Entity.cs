using Domain;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Infraestrutura
{
    //[Serializable]
    [DataContract(Name = "Entity", Namespace = DomainConstants.DataContractNamespace, IsReference = false)]
    public  class IEntity<TId>
      where TId : struct
    {
        [Key]
        [DataMember]
        public virtual TId cod { get; protected set; }

        [DataMember]
        public virtual byte[] ConcurrencyToken { get; set; }
    }

    //[Serializable]
    //[DataContract(Namespace = DomainConstants.DataContractNamespace, IsReference = false)]
    public class Entity : IEntity<int> { }
}
