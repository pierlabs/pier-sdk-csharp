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
    /// {{{endereco_response_description}}}
    /// </summary>
    [DataContract]
    public partial class EnderecoResponseValue :  IEquatable<EnderecoResponseValue>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EnderecoResponseValue" /> class.
        /// Initializes a new instance of the <see cref="EnderecoResponseValue" />class.
        /// </summary>
        /// <param name="Cep">{{{endereco_response_cep_value}}}.</param>
        /// <param name="Endereco">{{{endereco_response_endereco_value}}}.</param>
        /// <param name="Bairro">{{{endereco_response_bairro_value}}}.</param>
        /// <param name="Cidade">{{{endereco_response_cidade_value}}}.</param>
        /// <param name="Uf">{{{endereco_response_uf_value}}}.</param>

        public EnderecoResponseValue(string Cep = null, string Endereco = null, string Bairro = null, string Cidade = null, string Uf = null)
        {
            this.Cep = Cep;
            this.Endereco = Endereco;
            this.Bairro = Bairro;
            this.Cidade = Cidade;
            this.Uf = Uf;
            
        }
        
    
        /// <summary>
        /// {{{endereco_response_cep_value}}}
        /// </summary>
        /// <value>{{{endereco_response_cep_value}}}</value>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public string Cep { get; set; }
    
        /// <summary>
        /// {{{endereco_response_endereco_value}}}
        /// </summary>
        /// <value>{{{endereco_response_endereco_value}}}</value>
        [DataMember(Name="endereco", EmitDefaultValue=false)]
        public string Endereco { get; set; }
    
        /// <summary>
        /// {{{endereco_response_bairro_value}}}
        /// </summary>
        /// <value>{{{endereco_response_bairro_value}}}</value>
        [DataMember(Name="bairro", EmitDefaultValue=false)]
        public string Bairro { get; set; }
    
        /// <summary>
        /// {{{endereco_response_cidade_value}}}
        /// </summary>
        /// <value>{{{endereco_response_cidade_value}}}</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// {{{endereco_response_uf_value}}}
        /// </summary>
        /// <value>{{{endereco_response_uf_value}}}</value>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnderecoResponseValue {\n");
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
            return this.Equals(obj as EnderecoResponseValue);
        }

        /// <summary>
        /// Returns true if EnderecoResponseValue instances are equal
        /// </summary>
        /// <param name="other">Instance of EnderecoResponseValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnderecoResponseValue other)
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
