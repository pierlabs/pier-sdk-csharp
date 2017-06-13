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
    /// PessoaJuridicaAprovadaPersist
    /// </summary>
    [DataContract]
    public partial class PessoaJuridicaAprovadaPersist :  IEquatable<PessoaJuridicaAprovadaPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaJuridicaAprovadaPersist" /> class.
        /// Initializes a new instance of the <see cref="PessoaJuridicaAprovadaPersist" />class.
        /// </summary>
        /// <param name="RazaoSocial">Apresenta o nome completo da raz\u00C3\u00A3o social (nome empresarial)&#39;. (required).</param>
        /// <param name="NomeFantasia">Apresenta o nome fantasia da empresa..</param>
        /// <param name="Cnpj">N\u00C3\u00BAmero do Cadastro Nacional de Pessoa Juridica (CNPJ) (required).</param>
        /// <param name="InscricaoEstadual">N\u00C3\u00BAmero da Inscri\u00C3\u00A7\u00C3\u00A3o Estadual (IE)..</param>
        /// <param name="DataAberturaEmpresa">Data de abertura da empresa, essa data deve ser informada no formato: aaaa-MM-dd. (required).</param>
        /// <param name="IdOrigemComercial">Id da origem comercial (required).</param>
        /// <param name="IdProduto">Id do produto (required).</param>
        /// <param name="NumeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia..</param>
        /// <param name="NumeroContaCorrente">N\u00C3\u00BAmero da conta corrente..</param>
        /// <param name="Email">Email da empresa.</param>
        /// <param name="DiaVencimento">Dia vencimento (required).</param>
        /// <param name="NomeImpresso">Nome que deve ser impresso no cart\u00C3\u00A3o.</param>
        /// <param name="Telefones">Apresenta os telefones da empresa.</param>
        /// <param name="Enderecos">Pode ser informado os seguintes tipos de endere\u00C3\u00A7o: Residencial, Comercial, e Outros (required).</param>
        /// <param name="Socios">Apresenta os dados dos s\u00C3\u00B3cios da empresa, caso exista.</param>

        public PessoaJuridicaAprovadaPersist(string RazaoSocial = null, string NomeFantasia = null, string Cnpj = null, string InscricaoEstadual = null, string DataAberturaEmpresa = null, long? IdOrigemComercial = null, long? IdProduto = null, int? NumeroAgencia = null, string NumeroContaCorrente = null, string Email = null, int? DiaVencimento = null, string NomeImpresso = null, List<TelefonePessoaAprovadaPersist> Telefones = null, List<EnderecoAprovadoPersist> Enderecos = null, List<PessoaPersist> Socios = null)
        {
            // to ensure "RazaoSocial" is required (not null)
            if (RazaoSocial == null)
            {
                throw new InvalidDataException("RazaoSocial is a required property for PessoaJuridicaAprovadaPersist and cannot be null");
            }
            else
            {
                this.RazaoSocial = RazaoSocial;
            }
            // to ensure "Cnpj" is required (not null)
            if (Cnpj == null)
            {
                throw new InvalidDataException("Cnpj is a required property for PessoaJuridicaAprovadaPersist and cannot be null");
            }
            else
            {
                this.Cnpj = Cnpj;
            }
            // to ensure "DataAberturaEmpresa" is required (not null)
            if (DataAberturaEmpresa == null)
            {
                throw new InvalidDataException("DataAberturaEmpresa is a required property for PessoaJuridicaAprovadaPersist and cannot be null");
            }
            else
            {
                this.DataAberturaEmpresa = DataAberturaEmpresa;
            }
            // to ensure "IdOrigemComercial" is required (not null)
            if (IdOrigemComercial == null)
            {
                throw new InvalidDataException("IdOrigemComercial is a required property for PessoaJuridicaAprovadaPersist and cannot be null");
            }
            else
            {
                this.IdOrigemComercial = IdOrigemComercial;
            }
            // to ensure "IdProduto" is required (not null)
            if (IdProduto == null)
            {
                throw new InvalidDataException("IdProduto is a required property for PessoaJuridicaAprovadaPersist and cannot be null");
            }
            else
            {
                this.IdProduto = IdProduto;
            }
            // to ensure "DiaVencimento" is required (not null)
            if (DiaVencimento == null)
            {
                throw new InvalidDataException("DiaVencimento is a required property for PessoaJuridicaAprovadaPersist and cannot be null");
            }
            else
            {
                this.DiaVencimento = DiaVencimento;
            }
            // to ensure "Enderecos" is required (not null)
            if (Enderecos == null)
            {
                throw new InvalidDataException("Enderecos is a required property for PessoaJuridicaAprovadaPersist and cannot be null");
            }
            else
            {
                this.Enderecos = Enderecos;
            }
            this.NomeFantasia = NomeFantasia;
            this.InscricaoEstadual = InscricaoEstadual;
            this.NumeroAgencia = NumeroAgencia;
            this.NumeroContaCorrente = NumeroContaCorrente;
            this.Email = Email;
            this.NomeImpresso = NomeImpresso;
            this.Telefones = Telefones;
            this.Socios = Socios;
            
        }
        
    
        /// <summary>
        /// Apresenta o nome completo da raz\u00C3\u00A3o social (nome empresarial)&#39;.
        /// </summary>
        /// <value>Apresenta o nome completo da raz\u00C3\u00A3o social (nome empresarial)&#39;.</value>
        [DataMember(Name="razaoSocial", EmitDefaultValue=false)]
        public string RazaoSocial { get; set; }
    
        /// <summary>
        /// Apresenta o nome fantasia da empresa.
        /// </summary>
        /// <value>Apresenta o nome fantasia da empresa.</value>
        [DataMember(Name="nomeFantasia", EmitDefaultValue=false)]
        public string NomeFantasia { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero do Cadastro Nacional de Pessoa Juridica (CNPJ)
        /// </summary>
        /// <value>N\u00C3\u00BAmero do Cadastro Nacional de Pessoa Juridica (CNPJ)</value>
        [DataMember(Name="cnpj", EmitDefaultValue=false)]
        public string Cnpj { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero da Inscri\u00C3\u00A7\u00C3\u00A3o Estadual (IE).
        /// </summary>
        /// <value>N\u00C3\u00BAmero da Inscri\u00C3\u00A7\u00C3\u00A3o Estadual (IE).</value>
        [DataMember(Name="inscricaoEstadual", EmitDefaultValue=false)]
        public string InscricaoEstadual { get; set; }
    
        /// <summary>
        /// Data de abertura da empresa, essa data deve ser informada no formato: aaaa-MM-dd.
        /// </summary>
        /// <value>Data de abertura da empresa, essa data deve ser informada no formato: aaaa-MM-dd.</value>
        [DataMember(Name="dataAberturaEmpresa", EmitDefaultValue=false)]
        public string DataAberturaEmpresa { get; set; }
    
        /// <summary>
        /// Id da origem comercial
        /// </summary>
        /// <value>Id da origem comercial</value>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public long? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// Id do produto
        /// </summary>
        /// <value>Id do produto</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero da ag\u00C3\u00AAncia.
        /// </summary>
        /// <value>N\u00C3\u00BAmero da ag\u00C3\u00AAncia.</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public int? NumeroAgencia { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero da conta corrente.
        /// </summary>
        /// <value>N\u00C3\u00BAmero da conta corrente.</value>
        [DataMember(Name="numeroContaCorrente", EmitDefaultValue=false)]
        public string NumeroContaCorrente { get; set; }
    
        /// <summary>
        /// Email da empresa
        /// </summary>
        /// <value>Email da empresa</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Dia vencimento
        /// </summary>
        /// <value>Dia vencimento</value>
        [DataMember(Name="diaVencimento", EmitDefaultValue=false)]
        public int? DiaVencimento { get; set; }
    
        /// <summary>
        /// Nome que deve ser impresso no cart\u00C3\u00A3o
        /// </summary>
        /// <value>Nome que deve ser impresso no cart\u00C3\u00A3o</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// Apresenta os telefones da empresa
        /// </summary>
        /// <value>Apresenta os telefones da empresa</value>
        [DataMember(Name="telefones", EmitDefaultValue=false)]
        public List<TelefonePessoaAprovadaPersist> Telefones { get; set; }
    
        /// <summary>
        /// Pode ser informado os seguintes tipos de endere\u00C3\u00A7o: Residencial, Comercial, e Outros
        /// </summary>
        /// <value>Pode ser informado os seguintes tipos de endere\u00C3\u00A7o: Residencial, Comercial, e Outros</value>
        [DataMember(Name="enderecos", EmitDefaultValue=false)]
        public List<EnderecoAprovadoPersist> Enderecos { get; set; }
    
        /// <summary>
        /// Apresenta os dados dos s\u00C3\u00B3cios da empresa, caso exista
        /// </summary>
        /// <value>Apresenta os dados dos s\u00C3\u00B3cios da empresa, caso exista</value>
        [DataMember(Name="socios", EmitDefaultValue=false)]
        public List<PessoaPersist> Socios { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PessoaJuridicaAprovadaPersist {\n");
            sb.Append("  RazaoSocial: ").Append(RazaoSocial).Append("\n");
            sb.Append("  NomeFantasia: ").Append(NomeFantasia).Append("\n");
            sb.Append("  Cnpj: ").Append(Cnpj).Append("\n");
            sb.Append("  InscricaoEstadual: ").Append(InscricaoEstadual).Append("\n");
            sb.Append("  DataAberturaEmpresa: ").Append(DataAberturaEmpresa).Append("\n");
            sb.Append("  IdOrigemComercial: ").Append(IdOrigemComercial).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  NumeroContaCorrente: ").Append(NumeroContaCorrente).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  DiaVencimento: ").Append(DiaVencimento).Append("\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  Telefones: ").Append(Telefones).Append("\n");
            sb.Append("  Enderecos: ").Append(Enderecos).Append("\n");
            sb.Append("  Socios: ").Append(Socios).Append("\n");
            
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
            return this.Equals(obj as PessoaJuridicaAprovadaPersist);
        }

        /// <summary>
        /// Returns true if PessoaJuridicaAprovadaPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of PessoaJuridicaAprovadaPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PessoaJuridicaAprovadaPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RazaoSocial == other.RazaoSocial ||
                    this.RazaoSocial != null &&
                    this.RazaoSocial.Equals(other.RazaoSocial)
                ) && 
                (
                    this.NomeFantasia == other.NomeFantasia ||
                    this.NomeFantasia != null &&
                    this.NomeFantasia.Equals(other.NomeFantasia)
                ) && 
                (
                    this.Cnpj == other.Cnpj ||
                    this.Cnpj != null &&
                    this.Cnpj.Equals(other.Cnpj)
                ) && 
                (
                    this.InscricaoEstadual == other.InscricaoEstadual ||
                    this.InscricaoEstadual != null &&
                    this.InscricaoEstadual.Equals(other.InscricaoEstadual)
                ) && 
                (
                    this.DataAberturaEmpresa == other.DataAberturaEmpresa ||
                    this.DataAberturaEmpresa != null &&
                    this.DataAberturaEmpresa.Equals(other.DataAberturaEmpresa)
                ) && 
                (
                    this.IdOrigemComercial == other.IdOrigemComercial ||
                    this.IdOrigemComercial != null &&
                    this.IdOrigemComercial.Equals(other.IdOrigemComercial)
                ) && 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
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
                    this.DiaVencimento == other.DiaVencimento ||
                    this.DiaVencimento != null &&
                    this.DiaVencimento.Equals(other.DiaVencimento)
                ) && 
                (
                    this.NomeImpresso == other.NomeImpresso ||
                    this.NomeImpresso != null &&
                    this.NomeImpresso.Equals(other.NomeImpresso)
                ) && 
                (
                    this.Telefones == other.Telefones ||
                    this.Telefones != null &&
                    this.Telefones.SequenceEqual(other.Telefones)
                ) && 
                (
                    this.Enderecos == other.Enderecos ||
                    this.Enderecos != null &&
                    this.Enderecos.SequenceEqual(other.Enderecos)
                ) && 
                (
                    this.Socios == other.Socios ||
                    this.Socios != null &&
                    this.Socios.SequenceEqual(other.Socios)
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
                
                if (this.RazaoSocial != null)
                    hash = hash * 59 + this.RazaoSocial.GetHashCode();
                
                if (this.NomeFantasia != null)
                    hash = hash * 59 + this.NomeFantasia.GetHashCode();
                
                if (this.Cnpj != null)
                    hash = hash * 59 + this.Cnpj.GetHashCode();
                
                if (this.InscricaoEstadual != null)
                    hash = hash * 59 + this.InscricaoEstadual.GetHashCode();
                
                if (this.DataAberturaEmpresa != null)
                    hash = hash * 59 + this.DataAberturaEmpresa.GetHashCode();
                
                if (this.IdOrigemComercial != null)
                    hash = hash * 59 + this.IdOrigemComercial.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.NumeroAgencia != null)
                    hash = hash * 59 + this.NumeroAgencia.GetHashCode();
                
                if (this.NumeroContaCorrente != null)
                    hash = hash * 59 + this.NumeroContaCorrente.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.DiaVencimento != null)
                    hash = hash * 59 + this.DiaVencimento.GetHashCode();
                
                if (this.NomeImpresso != null)
                    hash = hash * 59 + this.NomeImpresso.GetHashCode();
                
                if (this.Telefones != null)
                    hash = hash * 59 + this.Telefones.GetHashCode();
                
                if (this.Enderecos != null)
                    hash = hash * 59 + this.Enderecos.GetHashCode();
                
                if (this.Socios != null)
                    hash = hash * 59 + this.Socios.GetHashCode();
                
                return hash;
            }
        }

    }
}
