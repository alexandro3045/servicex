﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System.Data.Entity;

    public partial class SERVICEX : DbContext
    {
        public SERVICEX()
            : base("SERVICEX")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agendamento> Agendamentoes { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Especialidade> Especialidades { get; set; }
        public virtual DbSet<PerfilAcesso> PerfilAcessoes { get; set; }
        public virtual DbSet<Perfil> Perfils { get; set; }
        public virtual DbSet<Profissional> Profissionals { get; set; }
        public virtual DbSet<Servico> Servicoes { get; set; }
        public virtual DbSet<Tela> Telas { get; set; }
        public virtual DbSet<TelsClients> TelsClients { get; set; }
        public virtual DbSet<TelsProfissionals> TelsProfissionals { get; set; }
        public virtual DbSet<TipoTelefone> TipoTelefone { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

    }
}