using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura
{
    public abstract class IEntity<TId>
      where TId : struct
    {
        [Key]
        public virtual TId cod { get; protected set; }
    }
    // with most commonly used identity
    public abstract class Entity : IEntity<int> { }
}
