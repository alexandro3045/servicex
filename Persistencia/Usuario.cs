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

    public partial class Usuario : Entity
    {
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public int tipoacesso { get; set; }
        public Nullable<int> Perfil_cod { get; set; }
    
        public virtual Perfil Perfil { get; set; }
    }
}
