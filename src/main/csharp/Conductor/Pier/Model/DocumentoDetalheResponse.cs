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
    /// Representa\u00E7\u00E3o da resposta para o detalhamento do documento
    /// </summary>
    [DataContract]
    public partial class DocumentoDetalheResponse :  IEquatable<DocumentoDetalheResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentoDetalheResponse" /> class.
        /// Initializes a new instance of the <see cref="DocumentoDetalheResponse" />class.
        /// </summary>
        /// <param name="Id">ID de identifica\u00E7\u00E3o do detalhamento do documento.</param>
        /// <param name="Propriedade">Propriedade do detalhamento do documento.</param>
        /// <param name="Conteudo">Conte\u00FAdo do detalhamento do documento.</param>

        public DocumentoDetalheResponse(long? Id = null, string Propriedade = null, string Conteudo = null)
        {
            this.Id = Id;
            this.Propriedade = Propriedade;
            this.Conteudo = Conteudo;
            
        }
        
    
        /// <summary>
        /// ID de identifica\u00E7\u00E3o do detalhamento do documento
        /// </summary>
        /// <value>ID de identifica\u00E7\u00E3o do detalhamento do documento</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Propriedade do detalhamento do documento
        /// </summary>
        /// <value>Propriedade do detalhamento do documento</value>
        [DataMember(Name="propriedade", EmitDefaultValue=false)]
        public string Propriedade { get; set; }
    
        /// <summary>
        /// Conte\u00FAdo do detalhamento do documento
        /// </summary>
        /// <value>Conte\u00FAdo do detalhamento do documento</value>
        [DataMember(Name="conteudo", EmitDefaultValue=false)]
        public string Conteudo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentoDetalheResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Propriedade: ").Append(Propriedade).Append("\n");
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
            return this.Equals(obj as DocumentoDetalheResponse);
        }

        /// <summary>
        /// Returns true if DocumentoDetalheResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentoDetalheResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentoDetalheResponse other)
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
                    this.Propriedade == other.Propriedade ||
                    this.Propriedade != null &&
                    this.Propriedade.Equals(other.Propriedade)
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
                
                if (this.Propriedade != null)
                    hash = hash * 59 + this.Propriedade.GetHashCode();
                
                if (this.Conteudo != null)
                    hash = hash * 59 + this.Conteudo.GetHashCode();
                
                return hash;
            }
        }

    }
}
