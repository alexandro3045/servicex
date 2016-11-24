//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using Infraestrutura;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Servico : Entity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servico()
        {
            this.Agendamentos = new HashSet<Agendamento>();
        }
        
        public string Nome { get; set; }
        public string tipoServico { get; set; }
        public System.DateTime TempoExecucao { get; set; }
        public string descricao { get; set; }
        public Nullable<decimal> valor { get; set; }
        public string observacoes { get; set; }
        public int cod_profissional { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agendamento> Agendamentos { get; set; }
        public virtual Profissional Profissional { get; set; }
    }
}