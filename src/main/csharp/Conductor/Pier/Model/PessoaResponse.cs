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
    /// Person
    /// </summary>
    [DataContract]
    public partial class PessoaResponse :  IEquatable<PessoaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaResponse" /> class.
        /// Initializes a new instance of the <see cref="PessoaResponse" />class.
        /// </summary>
        /// <param name="Id">Identification Code of the Person (id) (required).</param>
        /// <param name="Nome">Show the &#39;Full name of the PP&#39; or the &#39; Full name of the social reason (Business name)&#39; (required).</param>
        /// <param name="Tipo">Identification Code of the Person type, being (&#39;PP&#39;: Physical Person), (&#39;PJ&#39;: Legal Person) (required).</param>
        /// <param name="Cpf">CPF number, when it is PP.</param>
        /// <param name="Cnpj">CNPJ number, when it is LP.</param>
        /// <param name="DataNascimento">Birth date of the person, when it is PP, or the date of the Company Opening, when it is LP.</param>
        /// <param name="NumeroIdentidade">Identity Number.</param>
        /// <param name="OrgaoExpedidorIdentidade">Issuer Organ of the ID.</param>
        /// <param name="Sexo">Identification Code of the Person sex, being: (&#39;M&#39;: Male), (&#39;F&#39;: Female), (&#39;O&#39;: Other), (&#39;N&#39;: Not Specified).</param>
        /// <param name="UnidadeFederativaIdentidade">Acronym of the Federal Unity where was issued the Identity.</param>
        /// <param name="DataEmissaoIdentidade">Issue date of the identity in the format yyyy-MM-dd.</param>

        public PessoaResponse(long? Id = null, string Nome = null, string Tipo = null, string Cpf = null, string Cnpj = null, string DataNascimento = null, string NumeroIdentidade = null, string OrgaoExpedidorIdentidade = null, string Sexo = null, string UnidadeFederativaIdentidade = null, string DataEmissaoIdentidade = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for PessoaResponse and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Nome" is required (not null)
            if (Nome == null)
            {
                throw new InvalidDataException("Nome is a required property for PessoaResponse and cannot be null");
            }
            else
            {
                this.Nome = Nome;
            }
            // to ensure "Tipo" is required (not null)
            if (Tipo == null)
            {
                throw new InvalidDataException("Tipo is a required property for PessoaResponse and cannot be null");
            }
            else
            {
                this.Tipo = Tipo;
            }
            this.Cpf = Cpf;
            this.Cnpj = Cnpj;
            this.DataNascimento = DataNascimento;
            this.NumeroIdentidade = NumeroIdentidade;
            this.OrgaoExpedidorIdentidade = OrgaoExpedidorIdentidade;
            this.Sexo = Sexo;
            this.UnidadeFederativaIdentidade = UnidadeFederativaIdentidade;
            this.DataEmissaoIdentidade = DataEmissaoIdentidade;
            
        }
        
    
        /// <summary>
        /// Identification Code of the Person (id)
        /// </summary>
        /// <value>Identification Code of the Person (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Show the &#39;Full name of the PP&#39; or the &#39; Full name of the social reason (Business name)&#39;
        /// </summary>
        /// <value>Show the &#39;Full name of the PP&#39; or the &#39; Full name of the social reason (Business name)&#39;</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Identification Code of the Person type, being (&#39;PP&#39;: Physical Person), (&#39;PJ&#39;: Legal Person)
        /// </summary>
        /// <value>Identification Code of the Person type, being (&#39;PP&#39;: Physical Person), (&#39;PJ&#39;: Legal Person)</value>
        [DataMember(Name="tipo", EmitDefaultValue=false)]
        public string Tipo { get; set; }
    
        /// <summary>
        /// CPF number, when it is PP
        /// </summary>
        /// <value>CPF number, when it is PP</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// CNPJ number, when it is LP
        /// </summary>
        /// <value>CNPJ number, when it is LP</value>
        [DataMember(Name="cnpj", EmitDefaultValue=false)]
        public string Cnpj { get; set; }
    
        /// <summary>
        /// Birth date of the person, when it is PP, or the date of the Company Opening, when it is LP
        /// </summary>
        /// <value>Birth date of the person, when it is PP, or the date of the Company Opening, when it is LP</value>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        public string DataNascimento { get; set; }
    
        /// <summary>
        /// Identity Number
        /// </summary>
        /// <value>Identity Number</value>
        [DataMember(Name="numeroIdentidade", EmitDefaultValue=false)]
        public string NumeroIdentidade { get; set; }
    
        /// <summary>
        /// Issuer Organ of the ID
        /// </summary>
        /// <value>Issuer Organ of the ID</value>
        [DataMember(Name="orgaoExpedidorIdentidade", EmitDefaultValue=false)]
        public string OrgaoExpedidorIdentidade { get; set; }
    
        /// <summary>
        /// Identification Code of the Person sex, being: (&#39;M&#39;: Male), (&#39;F&#39;: Female), (&#39;O&#39;: Other), (&#39;N&#39;: Not Specified)
        /// </summary>
        /// <value>Identification Code of the Person sex, being: (&#39;M&#39;: Male), (&#39;F&#39;: Female), (&#39;O&#39;: Other), (&#39;N&#39;: Not Specified)</value>
        [DataMember(Name="sexo", EmitDefaultValue=false)]
        public string Sexo { get; set; }
    
        /// <summary>
        /// Acronym of the Federal Unity where was issued the Identity
        /// </summary>
        /// <value>Acronym of the Federal Unity where was issued the Identity</value>
        [DataMember(Name="unidadeFederativaIdentidade", EmitDefaultValue=false)]
        public string UnidadeFederativaIdentidade { get; set; }
    
        /// <summary>
        /// Issue date of the identity in the format yyyy-MM-dd
        /// </summary>
        /// <value>Issue date of the identity in the format yyyy-MM-dd</value>
        [DataMember(Name="dataEmissaoIdentidade", EmitDefaultValue=false)]
        public string DataEmissaoIdentidade { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PessoaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Tipo: ").Append(Tipo).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  Cnpj: ").Append(Cnpj).Append("\n");
            sb.Append("  DataNascimento: ").Append(DataNascimento).Append("\n");
            sb.Append("  NumeroIdentidade: ").Append(NumeroIdentidade).Append("\n");
            sb.Append("  OrgaoExpedidorIdentidade: ").Append(OrgaoExpedidorIdentidade).Append("\n");
            sb.Append("  Sexo: ").Append(Sexo).Append("\n");
            sb.Append("  UnidadeFederativaIdentidade: ").Append(UnidadeFederativaIdentidade).Append("\n");
            sb.Append("  DataEmissaoIdentidade: ").Append(DataEmissaoIdentidade).Append("\n");
            
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
            return this.Equals(obj as PessoaResponse);
        }

        /// <summary>
        /// Returns true if PessoaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PessoaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PessoaResponse other)
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
                    this.Tipo == other.Tipo ||
                    this.Tipo != null &&
                    this.Tipo.Equals(other.Tipo)
                ) && 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
                ) && 
                (
                    this.Cnpj == other.Cnpj ||
                    this.Cnpj != null &&
                    this.Cnpj.Equals(other.Cnpj)
                ) && 
                (
                    this.DataNascimento == other.DataNascimento ||
                    this.DataNascimento != null &&
                    this.DataNascimento.Equals(other.DataNascimento)
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
                    this.Sexo == other.Sexo ||
                    this.Sexo != null &&
                    this.Sexo.Equals(other.Sexo)
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
                
                if (this.Tipo != null)
                    hash = hash * 59 + this.Tipo.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                if (this.Cnpj != null)
                    hash = hash * 59 + this.Cnpj.GetHashCode();
                
                if (this.DataNascimento != null)
                    hash = hash * 59 + this.DataNascimento.GetHashCode();
                
                if (this.NumeroIdentidade != null)
                    hash = hash * 59 + this.NumeroIdentidade.GetHashCode();
                
                if (this.OrgaoExpedidorIdentidade != null)
                    hash = hash * 59 + this.OrgaoExpedidorIdentidade.GetHashCode();
                
                if (this.Sexo != null)
                    hash = hash * 59 + this.Sexo.GetHashCode();
                
                if (this.UnidadeFederativaIdentidade != null)
                    hash = hash * 59 + this.UnidadeFederativaIdentidade.GetHashCode();
                
                if (this.DataEmissaoIdentidade != null)
                    hash = hash * 59 + this.DataEmissaoIdentidade.GetHashCode();
                
                return hash;
            }
        }

    }
}
