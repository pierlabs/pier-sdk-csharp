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
    /// PersonPersist
    /// </summary>
    [DataContract]
    public partial class SocioAprovadoResponse :  IEquatable<SocioAprovadoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SocioAprovadoResponse" /> class.
        /// Initializes a new instance of the <see cref="SocioAprovadoResponse" />class.
        /// </summary>
        /// <param name="Id">Identification code of the Partner (id).</param>
        /// <param name="Nome">Show the name of the partner.</param>
        /// <param name="Cpf">CPF number, when it is PP.</param>
        /// <param name="DataNascimento">Birth Date of the Person, when it is PP, or the date of the Company Opening, when it is LP. This date must be informed in the format yyyy-MM-dd.</param>
        /// <param name="Sexo">Identification code of the person sex, when it is PP, being: (&#39;M&#39;: Male), (&#39;F&#39;: Female), (&#39;O&#39;: Other), (&#39;N&#39;: Not Specified).</param>
        /// <param name="NumeroIdentidade">Identity Number.</param>
        /// <param name="OrgaoExpedidorIdentidade">Issuer organ of the ID document.</param>
        /// <param name="UnidadeFederativaIdentidade">Acronym Federal Unity where was issued the Identity.</param>
        /// <param name="DataEmissaoIdentidade">Issue date of the identity.</param>
        /// <param name="EstadoCivil">Marital Status of the partner.</param>
        /// <param name="Profissao">Partner occupation.</param>
        /// <param name="Nacionalidade">Partner Nationality.</param>
        /// <param name="Email">Email of the partner.</param>
        /// <param name="Telefones">Inform the telephones of the partner.</param>

        public SocioAprovadoResponse(long? Id = null, string Nome = null, string Cpf = null, string DataNascimento = null, string Sexo = null, string NumeroIdentidade = null, string OrgaoExpedidorIdentidade = null, string UnidadeFederativaIdentidade = null, string DataEmissaoIdentidade = null, string EstadoCivil = null, string Profissao = null, string Nacionalidade = null, string Email = null, List<TelefonePessoaAprovadaResponse> Telefones = null)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.DataNascimento = DataNascimento;
            this.Sexo = Sexo;
            this.NumeroIdentidade = NumeroIdentidade;
            this.OrgaoExpedidorIdentidade = OrgaoExpedidorIdentidade;
            this.UnidadeFederativaIdentidade = UnidadeFederativaIdentidade;
            this.DataEmissaoIdentidade = DataEmissaoIdentidade;
            this.EstadoCivil = EstadoCivil;
            this.Profissao = Profissao;
            this.Nacionalidade = Nacionalidade;
            this.Email = Email;
            this.Telefones = Telefones;
            
        }
        
    
        /// <summary>
        /// Identification code of the Partner (id)
        /// </summary>
        /// <value>Identification code of the Partner (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Show the name of the partner
        /// </summary>
        /// <value>Show the name of the partner</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// CPF number, when it is PP
        /// </summary>
        /// <value>CPF number, when it is PP</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// Birth Date of the Person, when it is PP, or the date of the Company Opening, when it is LP. This date must be informed in the format yyyy-MM-dd
        /// </summary>
        /// <value>Birth Date of the Person, when it is PP, or the date of the Company Opening, when it is LP. This date must be informed in the format yyyy-MM-dd</value>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        public string DataNascimento { get; set; }
    
        /// <summary>
        /// Identification code of the person sex, when it is PP, being: (&#39;M&#39;: Male), (&#39;F&#39;: Female), (&#39;O&#39;: Other), (&#39;N&#39;: Not Specified)
        /// </summary>
        /// <value>Identification code of the person sex, when it is PP, being: (&#39;M&#39;: Male), (&#39;F&#39;: Female), (&#39;O&#39;: Other), (&#39;N&#39;: Not Specified)</value>
        [DataMember(Name="sexo", EmitDefaultValue=false)]
        public string Sexo { get; set; }
    
        /// <summary>
        /// Identity Number
        /// </summary>
        /// <value>Identity Number</value>
        [DataMember(Name="numeroIdentidade", EmitDefaultValue=false)]
        public string NumeroIdentidade { get; set; }
    
        /// <summary>
        /// Issuer organ of the ID document
        /// </summary>
        /// <value>Issuer organ of the ID document</value>
        [DataMember(Name="orgaoExpedidorIdentidade", EmitDefaultValue=false)]
        public string OrgaoExpedidorIdentidade { get; set; }
    
        /// <summary>
        /// Acronym Federal Unity where was issued the Identity
        /// </summary>
        /// <value>Acronym Federal Unity where was issued the Identity</value>
        [DataMember(Name="unidadeFederativaIdentidade", EmitDefaultValue=false)]
        public string UnidadeFederativaIdentidade { get; set; }
    
        /// <summary>
        /// Issue date of the identity
        /// </summary>
        /// <value>Issue date of the identity</value>
        [DataMember(Name="dataEmissaoIdentidade", EmitDefaultValue=false)]
        public string DataEmissaoIdentidade { get; set; }
    
        /// <summary>
        /// Marital Status of the partner
        /// </summary>
        /// <value>Marital Status of the partner</value>
        [DataMember(Name="estadoCivil", EmitDefaultValue=false)]
        public string EstadoCivil { get; set; }
    
        /// <summary>
        /// Partner occupation
        /// </summary>
        /// <value>Partner occupation</value>
        [DataMember(Name="profissao", EmitDefaultValue=false)]
        public string Profissao { get; set; }
    
        /// <summary>
        /// Partner Nationality
        /// </summary>
        /// <value>Partner Nationality</value>
        [DataMember(Name="nacionalidade", EmitDefaultValue=false)]
        public string Nacionalidade { get; set; }
    
        /// <summary>
        /// Email of the partner
        /// </summary>
        /// <value>Email of the partner</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Inform the telephones of the partner
        /// </summary>
        /// <value>Inform the telephones of the partner</value>
        [DataMember(Name="telefones", EmitDefaultValue=false)]
        public List<TelefonePessoaAprovadaResponse> Telefones { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SocioAprovadoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  DataNascimento: ").Append(DataNascimento).Append("\n");
            sb.Append("  Sexo: ").Append(Sexo).Append("\n");
            sb.Append("  NumeroIdentidade: ").Append(NumeroIdentidade).Append("\n");
            sb.Append("  OrgaoExpedidorIdentidade: ").Append(OrgaoExpedidorIdentidade).Append("\n");
            sb.Append("  UnidadeFederativaIdentidade: ").Append(UnidadeFederativaIdentidade).Append("\n");
            sb.Append("  DataEmissaoIdentidade: ").Append(DataEmissaoIdentidade).Append("\n");
            sb.Append("  EstadoCivil: ").Append(EstadoCivil).Append("\n");
            sb.Append("  Profissao: ").Append(Profissao).Append("\n");
            sb.Append("  Nacionalidade: ").Append(Nacionalidade).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Telefones: ").Append(Telefones).Append("\n");
            
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
            return this.Equals(obj as SocioAprovadoResponse);
        }

        /// <summary>
        /// Returns true if SocioAprovadoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SocioAprovadoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SocioAprovadoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
                ) && 
                (
                    this.DataNascimento == other.DataNascimento ||
                    this.DataNascimento != null &&
                    this.DataNascimento.Equals(other.DataNascimento)
                ) && 
                (
                    this.Sexo == other.Sexo ||
                    this.Sexo != null &&
                    this.Sexo.Equals(other.Sexo)
                ) && 
                (
                    this.NumeroIdentidade == other.NumeroIdentidade ||
                    this.NumeroIdentidade != null &&
                    this.NumeroIdentidade.Equals(other.NumeroIdentidade)
                ) && 
                (
                    this.OrgaoExpedidorIdentidade == other.OrgaoExpedidorIdentidade ||
                    this.OrgaoExpedidorIdentidade != null &&
                    this.OrgaoExpedidorIdentidade.Equals(other.OrgaoExpedidorIdentidade)
                ) && 
                (
                    this.UnidadeFederativaIdentidade == other.UnidadeFederativaIdentidade ||
                    this.UnidadeFederativaIdentidade != null &&
                    this.UnidadeFederativaIdentidade.Equals(other.UnidadeFederativaIdentidade)
                ) && 
                (
                    this.DataEmissaoIdentidade == other.DataEmissaoIdentidade ||
                    this.DataEmissaoIdentidade != null &&
                    this.DataEmissaoIdentidade.Equals(other.DataEmissaoIdentidade)
                ) && 
                (
                    this.EstadoCivil == other.EstadoCivil ||
                    this.EstadoCivil != null &&
                    this.EstadoCivil.Equals(other.EstadoCivil)
                ) && 
                (
                    this.Profissao == other.Profissao ||
                    this.Profissao != null &&
                    this.Profissao.Equals(other.Profissao)
                ) && 
                (
                    this.Nacionalidade == other.Nacionalidade ||
                    this.Nacionalidade != null &&
                    this.Nacionalidade.Equals(other.Nacionalidade)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Telefones == other.Telefones ||
                    this.Telefones != null &&
                    this.Telefones.SequenceEqual(other.Telefones)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                if (this.DataNascimento != null)
                    hash = hash * 59 + this.DataNascimento.GetHashCode();
                
                if (this.Sexo != null)
                    hash = hash * 59 + this.Sexo.GetHashCode();
                
                if (this.NumeroIdentidade != null)
                    hash = hash * 59 + this.NumeroIdentidade.GetHashCode();
                
                if (this.OrgaoExpedidorIdentidade != null)
                    hash = hash * 59 + this.OrgaoExpedidorIdentidade.GetHashCode();
                
                if (this.UnidadeFederativaIdentidade != null)
                    hash = hash * 59 + this.UnidadeFederativaIdentidade.GetHashCode();
                
                if (this.DataEmissaoIdentidade != null)
                    hash = hash * 59 + this.DataEmissaoIdentidade.GetHashCode();
                
                if (this.EstadoCivil != null)
                    hash = hash * 59 + this.EstadoCivil.GetHashCode();
                
                if (this.Profissao != null)
                    hash = hash * 59 + this.Profissao.GetHashCode();
                
                if (this.Nacionalidade != null)
                    hash = hash * 59 + this.Nacionalidade.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.Telefones != null)
                    hash = hash * 59 + this.Telefones.GetHashCode();
                
                return hash;
            }
        }

    }
}
