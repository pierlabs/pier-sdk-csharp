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
    /// Object Address
    /// </summary>
    [DataContract]
    public partial class EnderecoNacionalResponse :  IEquatable<EnderecoNacionalResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EnderecoNacionalResponse" /> class.
        /// Initializes a new instance of the <see cref="EnderecoNacionalResponse" />class.
        /// </summary>
        /// <param name="Cep">Show the Zipcode in format &#39;58800000&#39;.</param>
        /// <param name="Endereco">address.</param>
        /// <param name="Bairro">Show the name of the neighborhood.</param>
        /// <param name="Cidade">Show the name of the city.</param>
        /// <param name="Uf">Show the acronym of the Federal Unity.</param>

        public EnderecoNacionalResponse(string Cep = null, string Endereco = null, string Bairro = null, string Cidade = null, string Uf = null)
        {
            this.Cep = Cep;
            this.Endereco = Endereco;
            this.Bairro = Bairro;
            this.Cidade = Cidade;
            this.Uf = Uf;
            
        }
        
    
        /// <summary>
        /// Show the Zipcode in format &#39;58800000&#39;
        /// </summary>
        /// <value>Show the Zipcode in format &#39;58800000&#39;</value>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public string Cep { get; set; }
    
        /// <summary>
        /// address
        /// </summary>
        /// <value>address</value>
        [DataMember(Name="endereco", EmitDefaultValue=false)]
        public string Endereco { get; set; }
    
        /// <summary>
        /// Show the name of the neighborhood
        /// </summary>
        /// <value>Show the name of the neighborhood</value>
        [DataMember(Name="bairro", EmitDefaultValue=false)]
        public string Bairro { get; set; }
    
        /// <summary>
        /// Show the name of the city
        /// </summary>
        /// <value>Show the name of the city</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// Show the acronym of the Federal Unity
        /// </summary>
        /// <value>Show the acronym of the Federal Unity</value>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnderecoNacionalResponse {\n");
            sb.Append("  Cep: ").Append(Cep).Append("\n");
            sb.Append("  Endereco: ").Append(Endereco).Append("\n");
            sb.Append("  Bairro: ").Append(Bairro).Append("\n");
            sb.Append("  Cidade: ").Append(Cidade).Append("\n");
            sb.Append("  Uf: ").Append(Uf).Append("\n");
            
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
            return this.Equals(obj as EnderecoNacionalResponse);
        }

        /// <summary>
        /// Returns true if EnderecoNacionalResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of EnderecoNacionalResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnderecoNacionalResponse other)
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
                    this.Endereco == other.Endereco ||
                    this.Endereco != null &&
                    this.Endereco.Equals(other.Endereco)
                ) && 
                (
                    this.Bairro == other.Bairro ||
                    this.Bairro != null &&
                    this.Bairro.Equals(other.Bairro)
                ) && 
                (
                    this.Cidade == other.Cidade ||
                    this.Cidade != null &&
                    this.Cidade.Equals(other.Cidade)
                ) && 
                (
                    this.Uf == other.Uf ||
                    this.Uf != null &&
                    this.Uf.Equals(other.Uf)
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
                
                if (this.Endereco != null)
                    hash = hash * 59 + this.Endereco.GetHashCode();
                
                if (this.Bairro != null)
                    hash = hash * 59 + this.Bairro.GetHashCode();
                
                if (this.Cidade != null)
                    hash = hash * 59 + this.Cidade.GetHashCode();
                
                if (this.Uf != null)
                    hash = hash * 59 + this.Uf.GetHashCode();
                
                return hash;
            }
        }

    }
}
