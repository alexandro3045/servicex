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

    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class TelsProfissionals : EntityContracts
    {
        [DataMember]
        public Nullable<int> DDD { get; set; }
        [DataMember]
        public Nullable<int> numero { get; set; }
        [DataMember]
        public Nullable<int> cod_tipo_telefone { get; set; }
        [DataMember]
        public Nullable<int> cod_profissional { get; set; }

        [DataMember]
        public virtual Profissional Profissional { get; set; }
        [DataMember]
        public virtual TipoTelefone TipoTelefone { get; set; }
    }
}