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
    public partial class Perfil : EntityContracts
    {
        public Perfil()
        {
            this.PerfilAcessos = new HashSet<PerfilAcesso>();
            this.Usuarios = new HashSet<Usuario>();
        }
        
        public string nome { get; set; }

        [DataMember]
        public virtual ICollection<PerfilAcesso> PerfilAcessos { get; set; }

        [DataMember]
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
