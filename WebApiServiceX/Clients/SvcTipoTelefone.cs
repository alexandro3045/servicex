using System;
using System.Threading.Tasks;
using ModelService;
using Wcf_ServiceX.ServiceEvents;
using WebApiServiceX.Clients;
using WebApiServiceX.Clients.ClientBase;

[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("WebApiServiceX.Clients", ClrNamespace = "WebApiServiceX.Clients")]

namespace WebApiServiceX.Clients
{
    

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="IEntityOfint", Namespace="WebApiServiceX.Clients", IsReference=true)]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WebApiServiceX.Clients.Entity))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(TelsClients))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Cliente))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Agendamento))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Profissional))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Especialidade))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Servico))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(TelsProfissionals))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WebApiServiceX.Clients.TipoTelefone))]
    public partial class IEntityOfint : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private byte[] ConcurrencyTokenField;
        
        private int codField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] ConcurrencyToken
        {
            get
            {
                return this.ConcurrencyTokenField;
            }
            set
            {
                this.ConcurrencyTokenField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int cod
        {
            get
            {
                return this.codField;
            }
            set
            {
                this.codField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Entity", Namespace="WebApiServiceX.Clients", IsReference=true)]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(TelsClients))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Cliente))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Agendamento))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Profissional))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Especialidade))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Servico))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(TelsProfissionals))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WebApiServiceX.Clients.TipoTelefone))]
    public partial class Entity : IEntityOfint
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TipoTelefone", Namespace="WebApiServiceX.Clients", IsReference=true)]
    public partial class TipoTelefone : Entity
    {
        
        private TelsClients[] TelsClientsField;
        
        private TelsProfissionals[] TelsProfissionalsField;
        
        private string desc_tipo_telefoneField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TelsClients[] TelsClients
        {
            get
            {
                return this.TelsClientsField;
            }
            set
            {
                this.TelsClientsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TelsProfissionals[] TelsProfissionals
        {
            get
            {
                return this.TelsProfissionalsField;
            }
            set
            {
                this.TelsProfissionalsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string desc_tipo_telefone
        {
            get
            {
                return this.desc_tipo_telefoneField;
            }
            set
            {
                this.desc_tipo_telefoneField = value;
            }
        }
    }
}
namespace ModelService
{


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TelsClients", Namespace="http://schemas.datacontract.org/2004/07/Model", IsReference=true)]
    public partial class TelsClients : WebApiServiceX.Clients.Entity
    {
        
        private Cliente ClienteField;
        
        private System.Nullable<int> DDDField;
        
        private WebApiServiceX.Clients.TipoTelefone TipoTelefoneField;
        
        private System.Nullable<int> cod_clienteField;
        
        private System.Nullable<int> cod_tipo_telefoneField;
        
        private System.Nullable<int> numeroField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Cliente Cliente
        {
            get
            {
                return this.ClienteField;
            }
            set
            {
                this.ClienteField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> DDD
        {
            get
            {
                return this.DDDField;
            }
            set
            {
                this.DDDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebApiServiceX.Clients.TipoTelefone TipoTelefone
        {
            get
            {
                return this.TipoTelefoneField;
            }
            set
            {
                this.TipoTelefoneField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> cod_cliente
        {
            get
            {
                return this.cod_clienteField;
            }
            set
            {
                this.cod_clienteField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> cod_tipo_telefone
        {
            get
            {
                return this.cod_tipo_telefoneField;
            }
            set
            {
                this.cod_tipo_telefoneField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/Model", IsReference=true)]
    public partial class Cliente : WebApiServiceX.Clients.Entity
    {
        
        private Agendamento[] AgendamentosField;
        
        private System.Nullable<int> CEPField;
        
        private string CPFField;
        
        private string NomeField;
        
        private TelsClients[] TelsClientsField;
        
        private string bairroField;
        
        private string celularField;
        
        private string cidadeField;
        
        private System.Nullable<System.DateTime> data_nascimentoField;
        
        private string emailField;
        
        private string enderecoField;
        
        private string estadoField;
        
        private string estado_civilField;
        
        private System.Nullable<int> numero_endField;
        
        private string observacoesField;
        
        private string sexoField;
        
        private string telefoneField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Agendamento[] Agendamentos
        {
            get
            {
                return this.AgendamentosField;
            }
            set
            {
                this.AgendamentosField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> CEP
        {
            get
            {
                return this.CEPField;
            }
            set
            {
                this.CEPField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CPF
        {
            get
            {
                return this.CPFField;
            }
            set
            {
                this.CPFField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome
        {
            get
            {
                return this.NomeField;
            }
            set
            {
                this.NomeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TelsClients[] TelsClients
        {
            get
            {
                return this.TelsClientsField;
            }
            set
            {
                this.TelsClientsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string bairro
        {
            get
            {
                return this.bairroField;
            }
            set
            {
                this.bairroField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string celular
        {
            get
            {
                return this.celularField;
            }
            set
            {
                this.celularField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cidade
        {
            get
            {
                return this.cidadeField;
            }
            set
            {
                this.cidadeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> data_nascimento
        {
            get
            {
                return this.data_nascimentoField;
            }
            set
            {
                this.data_nascimentoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string endereco
        {
            get
            {
                return this.enderecoField;
            }
            set
            {
                this.enderecoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string estado
        {
            get
            {
                return this.estadoField;
            }
            set
            {
                this.estadoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string estado_civil
        {
            get
            {
                return this.estado_civilField;
            }
            set
            {
                this.estado_civilField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> numero_end
        {
            get
            {
                return this.numero_endField;
            }
            set
            {
                this.numero_endField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string observacoes
        {
            get
            {
                return this.observacoesField;
            }
            set
            {
                this.observacoesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string sexo
        {
            get
            {
                return this.sexoField;
            }
            set
            {
                this.sexoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string telefone
        {
            get
            {
                return this.telefoneField;
            }
            set
            {
                this.telefoneField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Agendamento", Namespace="http://schemas.datacontract.org/2004/07/Model", IsReference=true)]
    public partial class Agendamento : WebApiServiceX.Clients.Entity
    {
        
        private Cliente ClienteField;
        
        private Profissional ProfissionalField;
        
        private Servico ServicoField;
        
        private int cod_clienteField;
        
        private int cod_profissionalField;
        
        private int cod_servicoField;
        
        private System.DateTime data_agendamentoField;
        
        private System.DateTime horario_agendamentoField;
        
        private string observacoesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Cliente Cliente
        {
            get
            {
                return this.ClienteField;
            }
            set
            {
                this.ClienteField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Profissional Profissional
        {
            get
            {
                return this.ProfissionalField;
            }
            set
            {
                this.ProfissionalField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Servico Servico
        {
            get
            {
                return this.ServicoField;
            }
            set
            {
                this.ServicoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int cod_cliente
        {
            get
            {
                return this.cod_clienteField;
            }
            set
            {
                this.cod_clienteField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int cod_profissional
        {
            get
            {
                return this.cod_profissionalField;
            }
            set
            {
                this.cod_profissionalField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int cod_servico
        {
            get
            {
                return this.cod_servicoField;
            }
            set
            {
                this.cod_servicoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime data_agendamento
        {
            get
            {
                return this.data_agendamentoField;
            }
            set
            {
                this.data_agendamentoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime horario_agendamento
        {
            get
            {
                return this.horario_agendamentoField;
            }
            set
            {
                this.horario_agendamentoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string observacoes
        {
            get
            {
                return this.observacoesField;
            }
            set
            {
                this.observacoesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Profissional", Namespace="http://schemas.datacontract.org/2004/07/Model", IsReference=true)]
    public partial class Profissional : WebApiServiceX.Clients.Entity
    {
        
        private Agendamento[] AgendamentoesField;
        
        private string CEPField;
        
        private string CPFField;
        
        private Especialidade EspecialidadeField;
        
        private string NomeField;
        
        private Servico[] ServicoesField;
        
        private TelsProfissionals[] TelsProfissionalsField;
        
        private string bairroField;
        
        private string celularField;
        
        private string cidadeField;
        
        private int cod_especialidadeField;
        
        private System.Nullable<System.DateTime> data_nascimentoField;
        
        private string emailField;
        
        private string enderecoField;
        
        private string estadoField;
        
        private System.Nullable<int> numero_endField;
        
        private string observacoesField;
        
        private string sexoField;
        
        private string telefoneField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Agendamento[] Agendamentoes
        {
            get
            {
                return this.AgendamentoesField;
            }
            set
            {
                this.AgendamentoesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CEP
        {
            get
            {
                return this.CEPField;
            }
            set
            {
                this.CEPField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CPF
        {
            get
            {
                return this.CPFField;
            }
            set
            {
                this.CPFField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Especialidade Especialidade
        {
            get
            {
                return this.EspecialidadeField;
            }
            set
            {
                this.EspecialidadeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome
        {
            get
            {
                return this.NomeField;
            }
            set
            {
                this.NomeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Servico[] Servicoes
        {
            get
            {
                return this.ServicoesField;
            }
            set
            {
                this.ServicoesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TelsProfissionals[] TelsProfissionals
        {
            get
            {
                return this.TelsProfissionalsField;
            }
            set
            {
                this.TelsProfissionalsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string bairro
        {
            get
            {
                return this.bairroField;
            }
            set
            {
                this.bairroField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string celular
        {
            get
            {
                return this.celularField;
            }
            set
            {
                this.celularField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cidade
        {
            get
            {
                return this.cidadeField;
            }
            set
            {
                this.cidadeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int cod_especialidade
        {
            get
            {
                return this.cod_especialidadeField;
            }
            set
            {
                this.cod_especialidadeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> data_nascimento
        {
            get
            {
                return this.data_nascimentoField;
            }
            set
            {
                this.data_nascimentoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string endereco
        {
            get
            {
                return this.enderecoField;
            }
            set
            {
                this.enderecoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string estado
        {
            get
            {
                return this.estadoField;
            }
            set
            {
                this.estadoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> numero_end
        {
            get
            {
                return this.numero_endField;
            }
            set
            {
                this.numero_endField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string observacoes
        {
            get
            {
                return this.observacoesField;
            }
            set
            {
                this.observacoesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string sexo
        {
            get
            {
                return this.sexoField;
            }
            set
            {
                this.sexoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string telefone
        {
            get
            {
                return this.telefoneField;
            }
            set
            {
                this.telefoneField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Especialidade", Namespace="http://schemas.datacontract.org/2004/07/Model", IsReference=true)]
    public partial class Especialidade : WebApiServiceX.Clients.Entity
    {
        
        private string DescricaoField;
        
        private Profissional[] ProfissionalsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao
        {
            get
            {
                return this.DescricaoField;
            }
            set
            {
                this.DescricaoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Profissional[] Profissionals
        {
            get
            {
                return this.ProfissionalsField;
            }
            set
            {
                this.ProfissionalsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Servico", Namespace="http://schemas.datacontract.org/2004/07/Model", IsReference=true)]
    public partial class Servico : WebApiServiceX.Clients.Entity
    {
        
        private Agendamento[] AgendamentosField;
        
        private string NomeField;
        
        private Profissional ProfissionalField;
        
        private System.DateTime TempoExecucaoField;
        
        private int cod_profissionalField;
        
        private string descricaoField;
        
        private string observacoesField;
        
        private string tipoServicoField;
        
        private System.Nullable<decimal> valorField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Agendamento[] Agendamentos
        {
            get
            {
                return this.AgendamentosField;
            }
            set
            {
                this.AgendamentosField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome
        {
            get
            {
                return this.NomeField;
            }
            set
            {
                this.NomeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Profissional Profissional
        {
            get
            {
                return this.ProfissionalField;
            }
            set
            {
                this.ProfissionalField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TempoExecucao
        {
            get
            {
                return this.TempoExecucaoField;
            }
            set
            {
                this.TempoExecucaoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int cod_profissional
        {
            get
            {
                return this.cod_profissionalField;
            }
            set
            {
                this.cod_profissionalField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string observacoes
        {
            get
            {
                return this.observacoesField;
            }
            set
            {
                this.observacoesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tipoServico
        {
            get
            {
                return this.tipoServicoField;
            }
            set
            {
                this.tipoServicoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TelsProfissionals", Namespace="http://schemas.datacontract.org/2004/07/Model", IsReference=true)]
    public partial class TelsProfissionals : WebApiServiceX.Clients.Entity
    {
        
        private System.Nullable<int> DDDField;
        
        private Profissional ProfissionalField;
        
        private WebApiServiceX.Clients.TipoTelefone TipoTelefoneField;
        
        private System.Nullable<int> cod_profissionalField;
        
        private System.Nullable<int> cod_tipo_telefoneField;
        
        private System.Nullable<int> numeroField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> DDD
        {
            get
            {
                return this.DDDField;
            }
            set
            {
                this.DDDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Profissional Profissional
        {
            get
            {
                return this.ProfissionalField;
            }
            set
            {
                this.ProfissionalField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebApiServiceX.Clients.TipoTelefone TipoTelefone
        {
            get
            {
                return this.TipoTelefoneField;
            }
            set
            {
                this.TipoTelefoneField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> cod_profissional
        {
            get
            {
                return this.cod_profissionalField;
            }
            set
            {
                this.cod_profissionalField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> cod_tipo_telefone
        {
            get
            {
                return this.cod_tipo_telefoneField;
            }
            set
            {
                this.cod_tipo_telefoneField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
            }
        }
    }
}

namespace Wcf_ServiceX.Generic
{


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ObjectContract", Namespace="http://schemas.datacontract.org/2004/07/Wcf_ServiceX.Generic")]
    public partial class ObjectContract : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private WebApiServiceX.Clients.TipoTelefone[] PaginatedListField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebApiServiceX.Clients.TipoTelefone[] PaginatedList
        {
            get
            {
                return this.PaginatedListField;
            }
            set
            {
                this.PaginatedListField = value;
            }
        }
    }
}

//namespace Wcf_ServiceX.ServiceEvents.Base
//{
//    [GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
//    [ServiceContract(Namespace = "https://Wcf-ServiceX/services/ServiceClientBase/", ConfigurationName = "SvcTipoTelefone.ServiceClientBase")]

//    public interface ServiceClientBase
//    {
//        // CODEGEN: Generating message contract since the wrapper namespace (http://tempuri.org/) of message CompleteRequest does not match the default value (https://Wcf-ServiceX/services/ISvcTipoTelefone/)
//        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Complete" +
//            "", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Complete" +
//            "Response")]
//        WebApiServiceX.SvcTipoTelefone.
//        CompleteResponse Complete(WebApiServiceX.SvcTipoTelefone.CompleteRequest request);

//        // CODEGEN: Generating message contract since the wrapper namespace (http://tempuri.org/) of message AddRequest does not match the default value (https://Wcf-ServiceX/services/ISvcTipoTelefone/)
//        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Add", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/AddRespo" +
//            "nse")]
//        WebApiServiceX.SvcTipoTelefone.
//        AddResponse Add(WebApiServiceX.SvcTipoTelefone.AddRequest request);

//        // CODEGEN: Generating message contract since the wrapper namespace (http://tempuri.org/) of message UpdateRequest does not match the default value (https://Wcf-ServiceX/services/ISvcTipoTelefone/)
//        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Update", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/UpdateRe" +
//            "sponse")]
//        new WebApiServiceX.SvcTipoTelefone.
//            UpdateResponse Update(WebApiServiceX.SvcTipoTelefone.UpdateRequest request);

//        //// CODEGEN: Generating message contract since the wrapper namespace (http://tempuri.org/) of message RemoveRequest does not match the default value (https://Wcf-ServiceX/services/ISvcTipoTelefone/)
//        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Remove", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/RemoveRe" +
//            "sponse")]
//        WebApiServiceX.SvcTipoTelefone.
//        RemoveResponse Remove(WebApiServiceX.SvcTipoTelefone.RemoveRequest request);

//        // CODEGEN: Generating message contract since the wrapper namespace (http://tempuri.org/) of message PaginateRequest does not match the default value (https://Wcf-ServiceX/services/ISvcTipoTelefone/)
//        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Paginate" +
//            "", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Paginate" +
//            "Response")]
//        WebApiServiceX.SvcTipoTelefone.
//        PaginateResponse Paginate(WebApiServiceX.SvcTipoTelefone.PaginateRequest request);

//        // CODEGEN: Generating message contract since the wrapper namespace (http://tempuri.org/) of message PaginateEntityRequest does not match the default value (https://Wcf-ServiceX/services/ISvcTipoTelefone/)
//        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Paginate" +
//            "Entity", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Paginate" +
//            "EntityResponse")]
//        // WebApiServiceX.SvcTipoTelefone.

//        PaginateEntityResponse PaginateEntity(PaginateEntityRequest request);
//        // PaginateEntityResponse PaginateEntity(/*WebApiServiceX.SvcTipoTelefone.*/PaginateEntityRequest request);


//    }
//}

namespace Wcf_ServiceX.ServiceEvents
{

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "https://Wcf-ServiceX/services/ISvcTipoTelefone/", ConfigurationName = "ISvcTipoTelefone")]
    public interface ISvcTipoTelefone
    {

        // CODEGEN: Gerando contrato de mensagem porque o namespace do conteúdo (http://tempuri.org/) da mensagem CompleteRequest não corresponde ao valor padrão (https://Wcf-ServiceX/services/ISvcTipoTelefone/)
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Complete" +
            "", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Complete" +
            "Response")]
        CompleteResponse Complete(CompleteRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Complete" +
            "", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Complete" +
            "Response")]
        System.Threading.Tasks.Task<CompleteResponse> CompleteAsync(CompleteRequest request);

        // CODEGEN: Gerando contrato de mensagem porque o namespace do conteúdo (http://tempuri.org/) da mensagem AddRequest não corresponde ao valor padrão (https://Wcf-ServiceX/services/ISvcTipoTelefone/)
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Add", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/AddRespo" +
            "nse")]
        AddResponse Add(AddRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Add", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/AddRespo" +
            "nse")]
        System.Threading.Tasks.Task<AddResponse> AddAsync(AddRequest request);

        // CODEGEN: Gerando contrato de mensagem porque o namespace do conteúdo (http://tempuri.org/) da mensagem UpdateRequest não corresponde ao valor padrão (https://Wcf-ServiceX/services/ISvcTipoTelefone/)
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Update", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/UpdateRe" +
            "sponse")]
        UpdateResponse Update(UpdateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Update", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/UpdateRe" +
            "sponse")]
        System.Threading.Tasks.Task<UpdateResponse> UpdateAsync(UpdateRequest request);

        // CODEGEN: Gerando contrato de mensagem porque o namespace do conteúdo (http://tempuri.org/) da mensagem RemoveRequest não corresponde ao valor padrão (https://Wcf-ServiceX/services/ISvcTipoTelefone/)
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Remove", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/RemoveRe" +
            "sponse")]
        RemoveResponse Remove(RemoveRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Remove", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/RemoveRe" +
            "sponse")]
        System.Threading.Tasks.Task<RemoveResponse> RemoveAsync(RemoveRequest request);

        // CODEGEN: Gerando contrato de mensagem porque o namespace do conteúdo (http://tempuri.org/) da mensagem PaginateRequest não corresponde ao valor padrão (https://Wcf-ServiceX/services/ISvcTipoTelefone/)
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Paginate" +
            "", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Paginate" +
            "Response")]
        PaginateResponse Paginate(PaginateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Paginate" +
            "", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Paginate" +
            "Response")]
        System.Threading.Tasks.Task<PaginateResponse> PaginateAsync(PaginateRequest request);

        // CODEGEN: Gerando contrato de mensagem porque o namespace do conteúdo (http://tempuri.org/) da mensagem PaginateEntityRequest não corresponde ao valor padrão (https://Wcf-ServiceX/services/ISvcTipoTelefone/)
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Paginate" +
            "Entity", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Paginate" +
            "EntityResponse")]
        PaginateEntityResponse PaginateEntity(PaginateEntityRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Paginate" +
            "Entity", ReplyAction = "http://tempuri.org/IGenericServiceOf_TipoTelefoneRepository_TipoTelefone/Paginate" +
            "EntityResponse")]
        System.Threading.Tasks.Task<PaginateEntityResponse> PaginateEntityAsync(PaginateEntityRequest request);
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "Complete", WrapperNamespace = "http://tempuri.org/", IsWrapped = true)]
    public class CompleteRequest
    {

        public CompleteRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "CompleteResponse", WrapperNamespace = "http://tempuri.org/", IsWrapped = true)]
    public class CompleteResponse
    {

        public CompleteResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "Add", WrapperNamespace = "http://tempuri.org/", IsWrapped = true)]
    public class AddRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://tempuri.org/", Order = 0)]
        public WebApiServiceX.Clients.TipoTelefone param;

        public AddRequest()
        {
        }

        public AddRequest(WebApiServiceX.Clients.TipoTelefone param)
        {
            this.param = param;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "AddResponse", WrapperNamespace = "http://tempuri.org/", IsWrapped = true)]
    public class AddResponse
    {

        public AddResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "Update", WrapperNamespace = "http://tempuri.org/", IsWrapped = true)]
    public class UpdateRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://tempuri.org/", Order = 0)]
        public WebApiServiceX.Clients.TipoTelefone param;

        public UpdateRequest()
        {
        }

        public UpdateRequest(WebApiServiceX.Clients.TipoTelefone param)
        {
            this.param = param;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "UpdateResponse", WrapperNamespace = "http://tempuri.org/", IsWrapped = true)]
    public class UpdateResponse
    {

        public UpdateResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "Remove", WrapperNamespace = "http://tempuri.org/", IsWrapped = true)]
    public class RemoveRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://tempuri.org/", Order = 0)]
        public WebApiServiceX.Clients.TipoTelefone param;

        public RemoveRequest()
        {
        }

        public RemoveRequest(WebApiServiceX.Clients.TipoTelefone param)
        {
            this.param = param;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "RemoveResponse", WrapperNamespace = "http://tempuri.org/", IsWrapped = true)]
    public class RemoveResponse
    {

        public RemoveResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "Paginate", WrapperNamespace = "http://tempuri.org/", IsWrapped = true)]
    public class PaginateRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://tempuri.org/", Order = 0)]
        public int pageIndex;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://tempuri.org/", Order = 1)]
        public int pageSize;

        public PaginateRequest()
        {
        }

        public PaginateRequest(int pageIndex, int pageSize)
        {
            this.pageIndex = pageIndex;
            this.pageSize = pageSize;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "PaginateResponse", WrapperNamespace = "http://tempuri.org/", IsWrapped = true)]
    public class PaginateResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://tempuri.org/", Order = 0)]
        public WebApiServiceX.Clients.Entity[] PaginateResult;

        public PaginateResponse()
        {
        }

        public PaginateResponse(WebApiServiceX.Clients.Entity[] PaginateResult)
        {
            this.PaginateResult = PaginateResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "PaginateEntity", WrapperNamespace = "http://tempuri.org/", IsWrapped = true)]
    public class PaginateEntityRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://tempuri.org/", Order = 0)]
        public int pageIndex;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://tempuri.org/", Order = 1)]
        public int pageSize;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://tempuri.org/", Order = 2)]
        public string orderby;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://tempuri.org/", Order = 3)]
        public bool desc;

        public PaginateEntityRequest()
        {
        }

        public PaginateEntityRequest(int pageIndex, int pageSize, string orderby, bool desc)
        {
            this.pageIndex = pageIndex;
            this.pageSize = pageSize;
            this.orderby = orderby;
            this.desc = desc;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "PaginateEntityResponse", WrapperNamespace = "http://tempuri.org/", IsWrapped = true)]
    public class PaginateEntityResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://tempuri.org/", Order = 0)]
        public Wcf_ServiceX.Generic.ObjectContract PaginateEntityResult;

        public PaginateEntityResponse()
        {
        }

        public PaginateEntityResponse(Wcf_ServiceX.Generic.ObjectContract PaginateEntityResult)
        {
            this.PaginateEntityResult = PaginateEntityResult;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ISvcTipoTelefoneChannel : ISvcTipoTelefone, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public class SvcTipoTelefoneClient : System.ServiceModel.ClientBase<ServiceBase>, ISvcTipoTelefone
{

    public SvcTipoTelefoneClient()
    {
    }

    public SvcTipoTelefoneClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
    {
    }

    public SvcTipoTelefoneClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public SvcTipoTelefoneClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public SvcTipoTelefoneClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
    {
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    CompleteResponse Complete(CompleteRequest request)
    {
        return base.Channel.Complete(request);
    }

    public void Complete()
    {
        CompleteRequest inValue = new CompleteRequest();
        CompleteResponse retVal = ((ISvcTipoTelefone)(this)).Complete(inValue);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    AddResponse ISvcTipoTelefone.Add(AddRequest request)
    {
        return base.Channel.Add(request);
    }

    public void Add(TipoTelefone param)
    {
        AddRequest inValue = new AddRequest();
        inValue.param = param;
        AddResponse retVal = ((ISvcTipoTelefone)(this)).Add(inValue);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    UpdateResponse Update(UpdateRequest request)
    {
        return base.Channel.Update(request);
    }

    public void Update(TipoTelefone param)
    {
        UpdateRequest inValue = new UpdateRequest();
        inValue.param = param;
        UpdateResponse retVal = ((ISvcTipoTelefone)(this)).Update(inValue);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    RemoveResponse Remove(RemoveRequest request)
    {
        return base.Channel.Remove(request);
    }

    public void Remove(TipoTelefone param)
    {
        RemoveRequest inValue = new RemoveRequest();
        inValue.param = param;
        RemoveResponse retVal = ((ISvcTipoTelefone)(this)).Remove(inValue);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    PaginateResponse Paginate(PaginateRequest request)
    {
        return base.Channel.Paginate(request);
    }

    public Entity[] Paginate(int pageIndex, int pageSize)
    {
        PaginateRequest inValue = new PaginateRequest();
        inValue.pageIndex = pageIndex;
        inValue.pageSize = pageSize;
        PaginateResponse retVal = ((ISvcTipoTelefone)(this)).Paginate(inValue);
        return retVal.PaginateResult;
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    PaginateEntityResponse PaginateEntity(PaginateEntityRequest request)
    {
        return Channel.PaginateEntity(request);
    }

    public Wcf_ServiceX.Generic.ObjectContract PaginateEntity(int pageIndex, int pageSize, string orderby, bool desc)
    {
        PaginateEntityRequest inValue = new PaginateEntityRequest();
        inValue.pageIndex = pageIndex;
        inValue.pageSize = pageSize;
        inValue.orderby = orderby;
        inValue.desc = desc;
        PaginateEntityResponse retVal = ((ISvcTipoTelefone)(this)).PaginateEntity(inValue);
        return retVal.PaginateEntityResult;
    }

    #region métodos asyncronos

    CompleteResponse ISvcTipoTelefone.Complete(CompleteRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<CompleteResponse> CompleteAsync(CompleteRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<AddResponse> AddAsync(AddRequest request)
    {
        throw new NotImplementedException();
    }

    UpdateResponse ISvcTipoTelefone.Update(UpdateRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<UpdateResponse> UpdateAsync(UpdateRequest request)
    {
        throw new NotImplementedException();
    }

    RemoveResponse ISvcTipoTelefone.Remove(RemoveRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<RemoveResponse> RemoveAsync(RemoveRequest request)
    {
        throw new NotImplementedException();
    }

    PaginateResponse ISvcTipoTelefone.Paginate(PaginateRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<PaginateResponse> PaginateAsync(PaginateRequest request)
    {
        throw new NotImplementedException();
    }

    PaginateEntityResponse ISvcTipoTelefone.PaginateEntity(PaginateEntityRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<PaginateEntityResponse> PaginateEntityAsync(PaginateEntityRequest request)
    {
        throw new NotImplementedException();
    }
    #endregion
}
