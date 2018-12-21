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
    /// Object Response of the file parameter
    /// </summary>
    [DataContract]
    public partial class ArquivoParametroResponse :  IEquatable<ArquivoParametroResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ArquivoParametroResponse" /> class.
        /// Initializes a new instance of the <see cref="ArquivoParametroResponse" />class.
        /// </summary>
        /// <param name="Id">Identification Code of detail of the file.</param>
        /// <param name="NomeCampo">Name that identify the details of the file (required).</param>
        /// <param name="Conteudo">Content of nameField (required).</param>

        public ArquivoParametroResponse(long? Id = null, string NomeCampo = null, string Conteudo = null)
        {
            // to ensure "NomeCampo" is required (not null)
            if (NomeCampo == null)
            {
                throw new InvalidDataException("NomeCampo is a required property for ArquivoParametroResponse and cannot be null");
            }
            else
            {
                this.NomeCampo = NomeCampo;
            }
            // to ensure "Conteudo" is required (not null)
            if (Conteudo == null)
            {
                throw new InvalidDataException("Conteudo is a required property for ArquivoParametroResponse and cannot be null");
            }
            else
            {
                this.Conteudo = Conteudo;
            }
            this.Id = Id;
            
        }
        
    
        /// <summary>
        /// Identification Code of detail of the file
        /// </summary>
        /// <value>Identification Code of detail of the file</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Name that identify the details of the file
        /// </summary>
        /// <value>Name that identify the details of the file</value>
        [DataMember(Name="nomeCampo", EmitDefaultValue=false)]
        public string NomeCampo { get; set; }
    
        /// <summary>
        /// Content of nameField
        /// </summary>
        /// <value>Content of nameField</value>
        [DataMember(Name="conteudo", EmitDefaultValue=false)]
        public string Conteudo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArquivoParametroResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as ArquivoParametroResponse);
        }

        /// <summary>
        /// Returns true if ArquivoParametroResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ArquivoParametroResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArquivoParametroResponse other)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.NomeCampo != null)
                    hash = hash * 59 + this.NomeCampo.GetHashCode();
                
                if (this.Conteudo != null)
                    hash = hash * 59 + this.Conteudo.GetHashCode();
                
                return hash;
            }
        }

    }
}
