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
    /// Object fileParameters for the dates persistence
    /// </summary>
    [DataContract]
    public partial class ArquivoDetalhesPersist :  IEquatable<ArquivoDetalhesPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ArquivoDetalhesPersist" /> class.
        /// Initializes a new instance of the <see cref="ArquivoDetalhesPersist" />class.
        /// </summary>
        /// <param name="NomeCampo">Name that identifies the detail of the file (required).</param>
        /// <param name="Conteudo">Content of the nameField (required).</param>

        public ArquivoDetalhesPersist(string NomeCampo = null, string Conteudo = null)
        {
            // to ensure "NomeCampo" is required (not null)
            if (NomeCampo == null)
            {
                throw new InvalidDataException("NomeCampo is a required property for ArquivoDetalhesPersist and cannot be null");
            }
            else
            {
                this.NomeCampo = NomeCampo;
            }
            // to ensure "Conteudo" is required (not null)
            if (Conteudo == null)
            {
                throw new InvalidDataException("Conteudo is a required property for ArquivoDetalhesPersist and cannot be null");
            }
            else
            {
                this.Conteudo = Conteudo;
            }
            
        }
        
    
        /// <summary>
        /// Name that identifies the detail of the file
        /// </summary>
        /// <value>Name that identifies the detail of the file</value>
        [DataMember(Name="nomeCampo", EmitDefaultValue=false)]
        public string NomeCampo { get; set; }
    
        /// <summary>
        /// Content of the nameField
        /// </summary>
        /// <value>Content of the nameField</value>
        [DataMember(Name="conteudo", EmitDefaultValue=false)]
        public string Conteudo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArquivoDetalhesPersist {\n");
            sb.Append("  NomeCampo: ").Append(NomeCampo).Append("\n");
            sb.Append("  Conteudo: ").Append(Conteudo).Append("\n");
            
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
            return this.Equals(obj as ArquivoDetalhesPersist);
        }

        /// <summary>
        /// Returns true if ArquivoDetalhesPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of ArquivoDetalhesPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArquivoDetalhesPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NomeCampo == other.NomeCampo ||
                    this.NomeCampo != null &&
                    this.NomeCampo.Equals(other.NomeCampo)
                ) && 
                (
                    this.Conteudo == other.Conteudo ||
                    this.Conteudo != null &&
                    this.Conteudo.Equals(other.Conteudo)
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
                
                if (this.NomeCampo != null)
                    hash = hash * 59 + this.NomeCampo.GetHashCode();
                
                if (this.Conteudo != null)
                    hash = hash * 59 + this.Conteudo.GetHashCode();
                
                return hash;
            }
        }

    }
}
