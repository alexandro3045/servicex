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
    public class TipoTelefone : EntityContracts
    {
        public TipoTelefone()
        {
            this.TelsClients = new HashSet<TelsClients>();
            this.TelsProfissionals = new HashSet<TelsProfissionals>();
        }

        [DataMember]
        public string desc_tipo_telefone { get; set; }

        [DataMember]
        public virtual ICollection<TelsClients> TelsClients { get; set; }

        [DataMember]
        public virtual ICollection<TelsProfissionals> TelsProfissionals { get; set; }

    }
}
