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
    /// 
    /// </summary>
    [DataContract]
    public partial class InstituicaoPagamentoPersist :  IEquatable<InstituicaoPagamentoPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InstituicaoPagamentoPersist" /> class.
        /// Initializes a new instance of the <see cref="InstituicaoPagamentoPersist" />class.
        /// </summary>
        /// <param name="Cep">Cep.</param>
        /// <param name="Cnpj">Cnpj.</param>
        /// <param name="CodigoMunicipio">CodigoMunicipio.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Endereco">Endereco.</param>
        /// <param name="Fone">Fone.</param>
        /// <param name="Nome">Nome.</param>
        /// <param name="NomeFantasia">NomeFantasia.</param>
        /// <param name="NomeResponsavel">NomeResponsavel.</param>
        /// <param name="Uf">Uf.</param>
        /// <param name="UfFisco">UfFisco.</param>

        public InstituicaoPagamentoPersist(string Cep = null, string Cnpj = null, string CodigoMunicipio = null, string Email = null, string Endereco = null, string Fone = null, string Nome = null, string NomeFantasia = null, string NomeResponsavel = null, string Uf = null, string UfFisco = null)
        {
            this.Cep = Cep;
            this.Cnpj = Cnpj;
            this.CodigoMunicipio = CodigoMunicipio;
            this.Email = Email;
            this.Endereco = Endereco;
            this.Fone = Fone;
            this.Nome = Nome;
            this.NomeFantasia = NomeFantasia;
            this.NomeResponsavel = NomeResponsavel;
            this.Uf = Uf;
            this.UfFisco = UfFisco;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Cep
        /// </summary>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public string Cep { get; set; }
    
        /// <summary>
        /// Gets or Sets Cnpj
        /// </summary>
        [DataMember(Name="cnpj", EmitDefaultValue=false)]
        public string Cnpj { get; set; }
    
        /// <summary>
        /// Gets or Sets CodigoMunicipio
        /// </summary>
        [DataMember(Name="codigoMunicipio", EmitDefaultValue=false)]
        public string CodigoMunicipio { get; set; }
    
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or Sets Endereco
        /// </summary>
        [DataMember(Name="endereco", EmitDefaultValue=false)]
        public string Endereco { get; set; }
    
        /// <summary>
        /// Gets or Sets Fone
        /// </summary>
        [DataMember(Name="fone", EmitDefaultValue=false)]
        public string Fone { get; set; }
    
        /// <summary>
        /// Gets or Sets Nome
        /// </summary>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Gets or Sets NomeFantasia
        /// </summary>
        [DataMember(Name="nomeFantasia", EmitDefaultValue=false)]
        public string NomeFantasia { get; set; }
    
        /// <summary>
        /// Gets or Sets NomeResponsavel
        /// </summary>
        [DataMember(Name="nomeResponsavel", EmitDefaultValue=false)]
        public string NomeResponsavel { get; set; }
    
        /// <summary>
        /// Gets or Sets Uf
        /// </summary>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }
    
        /// <summary>
        /// Gets or Sets UfFisco
        /// </summary>
        [DataMember(Name="ufFisco", EmitDefaultValue=false)]
        public string UfFisco { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstituicaoPagamentoPersist {\n");
            sb.Append("  Cep: ").Append(Cep).Append("\n");
            sb.Append("  Cnpj: ").Append(Cnpj).Append("\n");
            sb.Append("  CodigoMunicipio: ").Append(CodigoMunicipio).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Endereco: ").Append(Endereco).Append("\n");
            sb.Append("  Fone: ").Append(Fone).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  NomeFantasia: ").Append(NomeFantasia).Append("\n");
            sb.Append("  NomeResponsavel: ").Append(NomeResponsavel).Append("\n");
            sb.Append("  Uf: ").Append(Uf).Append("\n");
            sb.Append("  UfFisco: ").Append(UfFisco).Append("\n");
            
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
            return this.Equals(obj as InstituicaoPagamentoPersist);
        }

        /// <summary>
        /// Returns true if InstituicaoPagamentoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of InstituicaoPagamentoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstituicaoPagamentoPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Cep == other.Cep ||
                    this.Cep != null &&
                    this.Cep.Equals(other.Cep)
                ) && 
                (
                    this.Cnpj == other.Cnpj ||
                    this.Cnpj != null &&
                    this.Cnpj.Equals(other.Cnpj)
                ) && 
                (
                    this.CodigoMunicipio == other.CodigoMunicipio ||
                    this.CodigoMunicipio != null &&
                    this.CodigoMunicipio.Equals(other.CodigoMunicipio)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Endereco == other.Endereco ||
                    this.Endereco != null &&
                    this.Endereco.Equals(other.Endereco)
                ) && 
                (
                    this.Fone == other.Fone ||
                    this.Fone != null &&
                    this.Fone.Equals(other.Fone)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.NomeFantasia == other.NomeFantasia ||
                    this.NomeFantasia != null &&
                    this.NomeFantasia.Equals(other.NomeFantasia)
                ) && 
                (
                    this.NomeResponsavel == other.NomeResponsavel ||
                    this.NomeResponsavel != null &&
                    this.NomeResponsavel.Equals(other.NomeResponsavel)
                ) && 
                (
                    this.Uf == other.Uf ||
                    this.Uf != null &&
                    this.Uf.Equals(other.Uf)
                ) && 
                (
                    this.UfFisco == other.UfFisco ||
                    this.UfFisco != null &&
                    this.UfFisco.Equals(other.UfFisco)
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
                
                if (this.Cep != null)
                    hash = hash * 59 + this.Cep.GetHashCode();
                
                if (this.Cnpj != null)
                    hash = hash * 59 + this.Cnpj.GetHashCode();
                
                if (this.CodigoMunicipio != null)
                    hash = hash * 59 + this.CodigoMunicipio.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.Endereco != null)
                    hash = hash * 59 + this.Endereco.GetHashCode();
                
                if (this.Fone != null)
                    hash = hash * 59 + this.Fone.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.NomeFantasia != null)
                    hash = hash * 59 + this.NomeFantasia.GetHashCode();
                
                if (this.NomeResponsavel != null)
                    hash = hash * 59 + this.NomeResponsavel.GetHashCode();
                
                if (this.Uf != null)
                    hash = hash * 59 + this.Uf.GetHashCode();
                
                if (this.UfFisco != null)
                    hash = hash * 59 + this.UfFisco.GetHashCode();
                
                return hash;
            }
        }

    }
}
