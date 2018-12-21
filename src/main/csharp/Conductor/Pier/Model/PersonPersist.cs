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
    /// PessoaPersist
    /// </summary>
    [DataContract]
    public partial class PersonPersist :  IEquatable<PersonPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonPersist" /> class.
        /// Initializes a new instance of the <see cref="PersonPersist" />class.
        /// </summary>
        /// <param name="Nome">Show the name of the Partner (required).</param>
        /// <param name="Cpf">Partner CPF number.</param>
        /// <param name="DataNascimento">Birth date of the person, when it is PP, or the Opening date of the Company, when it is LP. This date must be informed in format yyyy-MM-dd.</param>
        /// <param name="Sexo">Partner Gender.</param>
        /// <param name="NumeroIdentidade">Identity number.</param>
        /// <param name="OrgaoExpedidorIdentidade">Issuer organ of the Identity.</param>
        /// <param name="UnidadeFederativaIdentidade">Acronym of the Federal Unity where was issued the Identity.</param>
        /// <param name="DataEmissaoIdentidade">Issue date of the identity.</param>
        /// <param name="EstadoCivil">Marital Status of the partner.</param>
        /// <param name="Profissao">Occupation of the partner.</param>
        /// <param name="Nacionalidade">Nationality of the partner.</param>
        /// <param name="Email">Email of the partner.</param>
        /// <param name="Telefones">Inform the telephones of the partner.</param>

        public PersonPersist(string Nome = null, string Cpf = null, string DataNascimento = null, string Sexo = null, string NumeroIdentidade = null, string OrgaoExpedidorIdentidade = null, string UnidadeFederativaIdentidade = null, string DataEmissaoIdentidade = null, string EstadoCivil = null, string Profissao = null, string Nacionalidade = null, string Email = null, List<TelephonePersonApprovedPersist> Telefones = null)
        {
            // to ensure "Nome" is required (not null)
            if (Nome == null)
            {
                throw new InvalidDataException("Nome is a required property for PersonPersist and cannot be null");
            }
            else
            {
                this.Nome = Nome;
            }
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
        /// Show the name of the Partner
        /// </summary>
        /// <value>Show the name of the Partner</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Partner CPF number
        /// </summary>
        /// <value>Partner CPF number</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// Birth date of the person, when it is PP, or the Opening date of the Company, when it is LP. This date must be informed in format yyyy-MM-dd
        /// </summary>
        /// <value>Birth date of the person, when it is PP, or the Opening date of the Company, when it is LP. This date must be informed in format yyyy-MM-dd</value>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        public string DataNascimento { get; set; }
    
        /// <summary>
        /// Partner Gender
        /// </summary>
        /// <value>Partner Gender</value>
        [DataMember(Name="sexo", EmitDefaultValue=false)]
        public string Sexo { get; set; }
    
        /// <summary>
        /// Identity number
        /// </summary>
        /// <value>Identity number</value>
        [DataMember(Name="numeroIdentidade", EmitDefaultValue=false)]
        public string NumeroIdentidade { get; set; }
    
        /// <summary>
        /// Issuer organ of the Identity
        /// </summary>
        /// <value>Issuer organ of the Identity</value>
        [DataMember(Name="orgaoExpedidorIdentidade", EmitDefaultValue=false)]
        public string OrgaoExpedidorIdentidade { get; set; }
    
        /// <summary>
        /// Acronym of the Federal Unity where was issued the Identity
        /// </summary>
        /// <value>Acronym of the Federal Unity where was issued the Identity</value>
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
        /// Occupation of the partner
        /// </summary>
        /// <value>Occupation of the partner</value>
        [DataMember(Name="profissao", EmitDefaultValue=false)]
        public string Profissao { get; set; }
    
        /// <summary>
        /// Nationality of the partner
        /// </summary>
        /// <value>Nationality of the partner</value>
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
        public List<TelephonePersonApprovedPersist> Telefones { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersonPersist {\n");
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
            return this.Equals(obj as PersonPersist);
        }

        /// <summary>
        /// Returns true if PersonPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of PersonPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
