//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contracts
{
     
    using System.Collections.Generic;

    using System.Runtime.Serialization;

    [DataContract]
    public partial class Especialidade : EntityContracts
    {
        public Especialidade()
        {
            this.Profissionals = new HashSet<Profissional>();
        }

        [DataMember]
        public string Descricao { get; set; }

        [DataMember]
        public virtual ICollection<Profissional> Profissionals { get; set; }
    }
}
