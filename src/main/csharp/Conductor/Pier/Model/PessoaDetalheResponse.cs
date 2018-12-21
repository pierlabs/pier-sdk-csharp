using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Conductor.Pier.Model
{
    /// <summary>
    /// PersonDetailResponse
    /// </summary>
    [DataContract]
    public partial class PessoaDetalheResponse :  IEquatable<PessoaDetalheResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaDetalheResponse" /> class.
        /// Initializes a new instance of the <see cref="PessoaDetalheResponse" />class.
        /// </summary>
        /// <param name="IdPessoa">Identifier Code of the Person.</param>
        /// <param name="NomeMae">Show the name of the mother of the physical person.</param>
        /// <param name="IdEstadoCivil">Id Marital status of the physical person.</param>
        /// <param name="IdProfissao">Physical Person Occupation.</param>
        /// <param name="IdNaturezaOcupacao">Physical Person Occupation.</param>
        /// <param name="IdNacionalidade">Id Nationality of the physical person.</param>
        /// <param name="NumeroBanco">Bank Number.</param>
        /// <param name="NumeroAgencia">Agency Number.</param>
        /// <param name="NumeroContaCorrente">Current Account number.</param>
        /// <param name="Email">Physical Person Email.</param>
        /// <param name="NomeEmpresa">Name that must be printed on the card.</param>
        /// <param name="NomeReferencia1">Name Reference 1.</param>
        /// <param name="EnderecoReferencia1">Reference Address 1.</param>
        /// <param name="NomeReferencia2">Name Reference 2.</param>
        /// <param name="EnderecoReferencia2">Reference Address 2.</param>
        /// <param name="Salario">Salary.</param>
        /// <param name="ImpedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64).</param>
        /// <param name="NaturalidadeCidade">Displays the name of the birth city of the individual.</param>
        /// <param name="NaturalidadeEstado">Presents the acronym of the person&#39;s state of birth.</param>
        /// <param name="GrauInstrucao">It shows the degree of instruction of the individual.</param>
        /// <param name="NumeroDependentes">Displays the number of dependents of the individual.</param>
        /// <param name="NomePai">Displays the name of the parent of the individual.</param>
        /// <param name="ChequeEspecial">Indicates whether individual person joins the overdraft.</param>

        public PessoaDetalheResponse(long? IdPessoa = null, string NomeMae = null, long? IdEstadoCivil = null, string IdProfissao = null, long? IdNaturezaOcupacao = null, long? IdNacionalidade = null, int? NumeroBanco = null, int? NumeroAgencia = null, string NumeroContaCorrente = null, string Email = null, string NomeEmpresa = null, string NomeReferencia1 = null, string EnderecoReferencia1 = null, string NomeReferencia2 = null, string EnderecoReferencia2 = null, double? Salario = null, bool? ImpedidoFinanciamento = null, string NaturalidadeCidade = null, string NaturalidadeEstado = null, int? GrauInstrucao = null, int? NumeroDependentes = null, string NomePai = null, int? ChequeEspecial = null)
        {
            this.IdPessoa = IdPessoa;
            this.NomeMae = NomeMae;
            this.IdEstadoCivil = IdEstadoCivil;
            this.IdProfissao = IdProfissao;
            this.IdNaturezaOcupacao = IdNaturezaOcupacao;
            this.IdNacionalidade = IdNacionalidade;
            this.NumeroBanco = NumeroBanco;
            this.NumeroAgencia = NumeroAgencia;
            this.NumeroContaCorrente = NumeroContaCorrente;
            this.Email = Email;
            this.NomeEmpresa = NomeEmpresa;
            this.NomeReferencia1 = NomeReferencia1;
            this.EnderecoReferencia1 = EnderecoReferencia1;
            this.NomeReferencia2 = NomeReferencia2;
            this.EnderecoReferencia2 = EnderecoReferencia2;
            this.Salario = Salario;
            this.ImpedidoFinanciamento = ImpedidoFinanciamento;
            this.NaturalidadeCidade = NaturalidadeCidade;
            this.NaturalidadeEstado = NaturalidadeEstado;
            this.GrauInstrucao = GrauInstrucao;
            this.NumeroDependentes = NumeroDependentes;
            this.NomePai = NomePai;
            this.ChequeEspecial = ChequeEspecial;
            
        }
        
    
        /// <summary>
        /// Identifier Code of the Person
        /// </summary>
        /// <value>Identifier Code of the Person</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Show the name of the mother of the physical person
        /// </summary>
        /// <value>Show the name of the mother of the physical person</value>
        [DataMember(Name="nomeMae", EmitDefaultValue=false)]
        public string NomeMae { get; set; }
    
        /// <summary>
        /// Id Marital status of the physical person
        /// </summary>
        /// <value>Id Marital status of the physical person</value>
        [DataMember(Name="idEstadoCivil", EmitDefaultValue=false)]
        public long? IdEstadoCivil { get; set; }
    
        /// <summary>
        /// Physical Person Occupation
        /// </summary>
        /// <value>Physical Person Occupation</value>
        [DataMember(Name="idProfissao", EmitDefaultValue=false)]
        public string IdProfissao { get; set; }
    
        /// <summary>
        /// Physical Person Occupation
        /// </summary>
        /// <value>Physical Person Occupation</value>
        [DataMember(Name="idNaturezaOcupacao", EmitDefaultValue=false)]
        public long? IdNaturezaOcupacao { get; set; }
    
        /// <summary>
        /// Id Nationality of the physical person
        /// </summary>
        /// <value>Id Nationality of the physical person</value>
        [DataMember(Name="idNacionalidade", EmitDefaultValue=false)]
        public long? IdNacionalidade { get; set; }
    
        /// <summary>
        /// Bank Number
        /// </summary>
        /// <value>Bank Number</value>
        [DataMember(Name="numeroBanco", EmitDefaultValue=false)]
        public int? NumeroBanco { get; set; }
    
        /// <summary>
        /// Agency Number
        /// </summary>
        /// <value>Agency Number</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public int? NumeroAgencia { get; set; }
    
        /// <summary>
        /// Current Account number
        /// </summary>
        /// <value>Current Account number</value>
        [DataMember(Name="numeroContaCorrente", EmitDefaultValue=false)]
        public string NumeroContaCorrente { get; set; }
    
        /// <summary>
        /// Physical Person Email
        /// </summary>
        /// <value>Physical Person Email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Name that must be printed on the card
        /// </summary>
        /// <value>Name that must be printed on the card</value>
        [DataMember(Name="nomeEmpresa", EmitDefaultValue=false)]
        public string NomeEmpresa { get; set; }
    
        /// <summary>
        /// Name Reference 1
        /// </summary>
        /// <value>Name Reference 1</value>
        [DataMember(Name="nomeReferencia1", EmitDefaultValue=false)]
        public string NomeReferencia1 { get; set; }
    
        /// <summary>
        /// Reference Address 1
        /// </summary>
        /// <value>Reference Address 1</value>
        [DataMember(Name="enderecoReferencia1", EmitDefaultValue=false)]
        public string EnderecoReferencia1 { get; set; }
    
        /// <summary>
        /// Name Reference 2
        /// </summary>
        /// <value>Name Reference 2</value>
        [DataMember(Name="nomeReferencia2", EmitDefaultValue=false)]
        public string NomeReferencia2 { get; set; }
    
        /// <summary>
        /// Reference Address 2
        /// </summary>
        /// <value>Reference Address 2</value>
        [DataMember(Name="enderecoReferencia2", EmitDefaultValue=false)]
        public string EnderecoReferencia2 { get; set; }
    
        /// <summary>
        /// Salary
        /// </summary>
        /// <value>Salary</value>
        [DataMember(Name="salario", EmitDefaultValue=false)]
        public double? Salario { get; set; }
    
        /// <summary>
        /// Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64)
        /// </summary>
        /// <value>Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64)</value>
        [DataMember(Name="impedidoFinanciamento", EmitDefaultValue=false)]
        public bool? ImpedidoFinanciamento { get; set; }
    
        /// <summary>
        /// Displays the name of the birth city of the individual
        /// </summary>
        /// <value>Displays the name of the birth city of the individual</value>
        [DataMember(Name="naturalidadeCidade", EmitDefaultValue=false)]
        public string NaturalidadeCidade { get; set; }
    
        /// <summary>
        /// Presents the acronym of the person&#39;s state of birth
        /// </summary>
        /// <value>Presents the acronym of the person&#39;s state of birth</value>
        [DataMember(Name="naturalidadeEstado", EmitDefaultValue=false)]
        public string NaturalidadeEstado { get; set; }
    
        /// <summary>
        /// It shows the degree of instruction of the individual
        /// </summary>
        /// <value>It shows the degree of instruction of the individual</value>
        [DataMember(Name="grauInstrucao", EmitDefaultValue=false)]
        public int? GrauInstrucao { get; set; }
    
        /// <summary>
        /// Displays the number of dependents of the individual
        /// </summary>
        /// <value>Displays the number of dependents of the individual</value>
        [DataMember(Name="numeroDependentes", EmitDefaultValue=false)]
        public int? NumeroDependentes { get; set; }
    
        /// <summary>
        /// Displays the name of the parent of the individual
        /// </summary>
        /// <value>Displays the name of the parent of the individual</value>
        [DataMember(Name="nomePai", EmitDefaultValue=false)]
        public string NomePai { get; set; }
    
        /// <summary>
        /// Indicates whether individual person joins the overdraft
        /// </summary>
        /// <value>Indicates whether individual person joins the overdraft</value>
        [DataMember(Name="chequeEspecial", EmitDefaultValue=false)]
        public int? ChequeEspecial { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PessoaDetalheResponse {\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  NomeMae: ").Append(NomeMae).Append("\n");
            sb.Append("  IdEstadoCivil: ").Append(IdEstadoCivil).Append("\n");
            sb.Append("  IdProfissao: ").Append(IdProfissao).Append("\n");
            sb.Append("  IdNaturezaOcupacao: ").Append(IdNaturezaOcupacao).Append("\n");
            sb.Append("  IdNacionalidade: ").Append(IdNacionalidade).Append("\n");
            sb.Append("  NumeroBanco: ").Append(NumeroBanco).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  NumeroContaCorrente: ").Append(NumeroContaCorrente).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  NomeEmpresa: ").Append(NomeEmpresa).Append("\n");
            sb.Append("  NomeReferencia1: ").Append(NomeReferencia1).Append("\n");
            sb.Append("  EnderecoReferencia1: ").Append(EnderecoReferencia1).Append("\n");
            sb.Append("  NomeReferencia2: ").Append(NomeReferencia2).Append("\n");
            sb.Append("  EnderecoReferencia2: ").Append(EnderecoReferencia2).Append("\n");
            sb.Append("  Salario: ").Append(Salario).Append("\n");
            sb.Append("  ImpedidoFinanciamento: ").Append(ImpedidoFinanciamento).Append("\n");
            sb.Append("  NaturalidadeCidade: ").Append(NaturalidadeCidade).Append("\n");
            sb.Append("  NaturalidadeEstado: ").Append(NaturalidadeEstado).Append("\n");
            sb.Append("  GrauInstrucao: ").Append(GrauInstrucao).Append("\n");
            sb.Append("  NumeroDependentes: ").Append(NumeroDependentes).Append("\n");
            sb.Append("  NomePai: ").Append(NomePai).Append("\n");
            sb.Append("  ChequeEspecial: ").Append(ChequeEspecial).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PessoaDetalheResponse);
        }

        /// <summary>
        /// Returns true if PessoaDetalheResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PessoaDetalheResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PessoaDetalheResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.NomeMae == other.NomeMae ||
                    this.NomeMae != null &&
                    this.NomeMae.Equals(other.NomeMae)
                ) && 
                (
                    this.IdEstadoCivil == other.IdEstadoCivil ||
                    this.IdEstadoCivil != null &&
                    this.IdEstadoCivil.Equals(other.IdEstadoCivil)
                ) && 
                (
                    this.IdProfissao == other.IdProfissao ||
                    this.IdProfissao != null &&
                    this.IdProfissao.Equals(other.IdProfissao)
                ) && 
                (
                    this.IdNaturezaOcupacao == other.IdNaturezaOcupacao ||
                    this.IdNaturezaOcupacao != null &&
                    this.IdNaturezaOcupacao.Equals(other.IdNaturezaOcupacao)
                ) && 
                (
                    this.IdNacionalidade == other.IdNacionalidade ||
                    this.IdNacionalidade != null &&
                    this.IdNacionalidade.Equals(other.IdNacionalidade)
                ) && 
                (
                    this.NumeroBanco == other.NumeroBanco ||
                    this.NumeroBanco != null &&
                    this.NumeroBanco.Equals(other.NumeroBanco)
                ) && 
                (
                    this.NumeroAgencia == other.NumeroAgencia ||
                    this.NumeroAgencia != null &&
                    this.NumeroAgencia.Equals(other.NumeroAgencia)
                ) && 
                (
                    this.NumeroContaCorrente == other.NumeroContaCorrente ||
                    this.NumeroContaCorrente != null &&
                    this.NumeroContaCorrente.Equals(other.NumeroContaCorrente)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.NomeEmpresa == other.NomeEmpresa ||
                    this.NomeEmpresa != null &&
                    this.NomeEmpresa.Equals(other.NomeEmpresa)
                ) && 
                (
                    this.NomeReferencia1 == other.NomeReferencia1 ||
                    this.NomeReferencia1 != null &&
                    this.NomeReferencia1.Equals(other.NomeReferencia1)
                ) && 
                (
                    this.EnderecoReferencia1 == other.EnderecoReferencia1 ||
                    this.EnderecoReferencia1 != null &&
                    this.EnderecoReferencia1.Equals(other.EnderecoReferencia1)
                ) && 
                (
                    this.NomeReferencia2 == other.NomeReferencia2 ||
                    this.NomeReferencia2 != null &&
                    this.NomeReferencia2.Equals(other.NomeReferencia2)
                ) && 
                (
                    this.EnderecoReferencia2 == other.EnderecoReferencia2 ||
                    this.EnderecoReferencia2 != null &&
                    this.EnderecoReferencia2.Equals(other.EnderecoReferencia2)
                ) && 
                (
                    this.Salario == other.Salario ||
                    this.Salario != null &&
                    this.Salario.Equals(other.Salario)
                ) && 
                (
                    this.ImpedidoFinanciamento == other.ImpedidoFinanciamento ||
                    this.ImpedidoFinanciamento != null &&
                    this.ImpedidoFinanciamento.Equals(other.ImpedidoFinanciamento)
                ) && 
                (
                    this.NaturalidadeCidade == other.NaturalidadeCidade ||
                    this.NaturalidadeCidade != null &&
                    this.NaturalidadeCidade.Equals(other.NaturalidadeCidade)
                ) && 
                (
                    this.NaturalidadeEstado == other.NaturalidadeEstado ||
                    this.NaturalidadeEstado != null &&
                    this.NaturalidadeEstado.Equals(other.NaturalidadeEstado)
                ) && 
                (
                    this.GrauInstrucao == other.GrauInstrucao ||
                    this.GrauInstrucao != null &&
                    this.GrauInstrucao.Equals(other.GrauInstrucao)
                ) && 
                (
                    this.NumeroDependentes == other.NumeroDependentes ||
                    this.NumeroDependentes != null &&
                    this.NumeroDependentes.Equals(other.NumeroDependentes)
                ) && 
                (
                    this.NomePai == other.NomePai ||
                    this.NomePai != null &&
                    this.NomePai.Equals(other.NomePai)
                ) && 
                (
                    this.ChequeEspecial == other.ChequeEspecial ||
                    this.ChequeEspecial != null &&
                    this.ChequeEspecial.Equals(other.ChequeEspecial)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.NomeMae != null)
                    hash = hash * 59 + this.NomeMae.GetHashCode();
                
                if (this.IdEstadoCivil != null)
                    hash = hash * 59 + this.IdEstadoCivil.GetHashCode();
                
                if (this.IdProfissao != null)
                    hash = hash * 59 + this.IdProfissao.GetHashCode();
                
                if (this.IdNaturezaOcupacao != null)
                    hash = hash * 59 + this.IdNaturezaOcupacao.GetHashCode();
                
                if (this.IdNacionalidade != null)
                    hash = hash * 59 + this.IdNacionalidade.GetHashCode();
                
                if (this.NumeroBanco != null)
                    hash = hash * 59 + this.NumeroBanco.GetHashCode();
                
                if (this.NumeroAgencia != null)
                    hash = hash * 59 + this.NumeroAgencia.GetHashCode();
                
                if (this.NumeroContaCorrente != null)
                    hash = hash * 59 + this.NumeroContaCorrente.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.NomeEmpresa != null)
                    hash = hash * 59 + this.NomeEmpresa.GetHashCode();
                
                if (this.NomeReferencia1 != null)
                    hash = hash * 59 + this.NomeReferencia1.GetHashCode();
                
                if (this.EnderecoReferencia1 != null)
                    hash = hash * 59 + this.EnderecoReferencia1.GetHashCode();
                
                if (this.NomeReferencia2 != null)
                    hash = hash * 59 + this.NomeReferencia2.GetHashCode();
                
                if (this.EnderecoReferencia2 != null)
                    hash = hash * 59 + this.EnderecoReferencia2.GetHashCode();
                
                if (this.Salario != null)
                    hash = hash * 59 + this.Salario.GetHashCode();
                
                if (this.ImpedidoFinanciamento != null)
                    hash = hash * 59 + this.ImpedidoFinanciamento.GetHashCode();
                
                if (this.NaturalidadeCidade != null)
                    hash = hash * 59 + this.NaturalidadeCidade.GetHashCode();
                
                if (this.NaturalidadeEstado != null)
                    hash = hash * 59 + this.NaturalidadeEstado.GetHashCode();
                
                if (this.GrauInstrucao != null)
                    hash = hash * 59 + this.GrauInstrucao.GetHashCode();
                
                if (this.NumeroDependentes != null)
                    hash = hash * 59 + this.NumeroDependentes.GetHashCode();
                
                if (this.NomePai != null)
                    hash = hash * 59 + this.NomePai.GetHashCode();
                
                if (this.ChequeEspecial != null)
                    hash = hash * 59 + this.ChequeEspecial.GetHashCode();
                
                return hash;
            }
        }

    }
}
