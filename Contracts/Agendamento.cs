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


    using System.Runtime.Serialization;

    [DataContract]
    public partial class Agendamento : EntityContracts
    {

        [DataMember]
        public System.DateTime data_agendamento { get; set; }

        [DataMember]
        public System.DateTime horario_agendamento { get; set; }

        [DataMember]
        public int cod_cliente { get; set; }

        [DataMember]
        public int cod_profissional { get; set; }

        [DataMember]
        public string observacoes { get; set; }

        [DataMember]
        public int cod_servico { get; set; }

        [DataMember]
        public virtual Cliente Cliente { get; set; }

        [DataMember]
        public virtual Profissional Profissional { get; set; }

        [DataMember]
        public virtual Servico Servico { get; set; }
    }
}
