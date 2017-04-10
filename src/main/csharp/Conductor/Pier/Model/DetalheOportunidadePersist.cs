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
    /// Objeto DetalheOportunidade
    /// </summary>
    [DataContract]
    public partial class DetalheOportunidadePersist :  IEquatable<DetalheOportunidadePersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DetalheOportunidadePersist" /> class.
        /// Initializes a new instance of the <see cref="DetalheOportunidadePersist" />class.
        /// </summary>
        /// <param name="Conteudo">Conte\u00C3\u00BAdo do detalhe (required).</param>
        /// <param name="NomeCampo">Nome do conte\u00C3\u00BAdo (required).</param>

        public DetalheOportunidadePersist(string Conteudo = null, string NomeCampo = null)
        {
            // to ensure "Conteudo" is required (not null)
            if (Conteudo == null)
            {
                throw new InvalidDataException("Conteudo is a required property for DetalheOportunidadePersist and cannot be null");
            }
            else
            {
                this.Conteudo = Conteudo;
            }
            // to ensure "NomeCampo" is required (not null)
            if (NomeCampo == null)
            {
                throw new InvalidDataException("NomeCampo is a required property for DetalheOportunidadePersist and cannot be null");
            }
            else
            {
                this.NomeCampo = NomeCampo;
            }
            
        }
        
    
        /// <summary>
        /// Conte\u00C3\u00BAdo do detalhe
        /// </summary>
        /// <value>Conte\u00C3\u00BAdo do detalhe</value>
        [DataMember(Name="conteudo", EmitDefaultValue=false)]
        public string Conteudo { get; set; }
    
        /// <summary>
        /// Nome do conte\u00C3\u00BAdo
        /// </summary>
        /// <value>Nome do conte\u00C3\u00BAdo</value>
        [DataMember(Name="nomeCampo", EmitDefaultValue=false)]
        public string NomeCampo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetalheOportunidadePersist {\n");
            sb.Append("  Conteudo: ").Append(Conteudo).Append("\n");
            sb.Append("  NomeCampo: ").Append(NomeCampo).Append("\n");
            
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
            return this.Equals(obj as DetalheOportunidadePersist);
        }

        /// <summary>
        /// Returns true if DetalheOportunidadePersist instances are equal
        /// </summary>
        /// <param name="other">Instance of DetalheOportunidadePersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetalheOportunidadePersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Conteudo == other.Conteudo ||
                    this.Conteudo != null &&
                    this.Conteudo.Equals(other.Conteudo)
                ) && 
                (
                    this.NomeCampo == other.NomeCampo ||
                    this.NomeCampo != null &&
                    this.NomeCampo.Equals(other.NomeCampo)
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
                
                if (this.Conteudo != null)
                    hash = hash * 59 + this.Conteudo.GetHashCode();
                
                if (this.NomeCampo != null)
                    hash = hash * 59 + this.NomeCampo.GetHashCode();
                
                return hash;
            }
        }

    }
}
