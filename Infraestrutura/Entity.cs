using Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura
{
    [Serializable]
    public  class IEntity<TId>
      where TId : struct
    {
        [Key]
        public virtual TId cod { get; protected set; }
    }

    [Serializable]
    public  class Entity : IEntity<int> { }
}
