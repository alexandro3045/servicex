using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Contracts
{
    [DataContract]
    public class IEntityContracts<TId>
      where TId : struct
    {
        [Key]
        public virtual TId cod { get; protected set; }
    }
    // with most commonly used identity
    [DataContract]
    public class EntityContracts : IEntityContracts<int> {



    }
}
