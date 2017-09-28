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
    /// Representa\u00C3\u00A7\u00C3\u00A3o do template do documento.
    /// </summary>
    [DataContract]
    public partial class DocumentoTemplatePersist :  IEquatable<DocumentoTemplatePersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentoTemplatePersist" /> class.
        /// Initializes a new instance of the <see cref="DocumentoTemplatePersist" />class.
        /// </summary>
        /// <param name="IdTipoDocumento">ID para o Tipo de Documento vinculado ao template..</param>
        /// <param name="Template">Template para o conte\u00C3\u00BAdo do documento..</param>

        public DocumentoTemplatePersist(long? IdTipoDocumento = null, string Template = null)
        {
            this.IdTipoDocumento = IdTipoDocumento;
            this.Template = Template;
            
        }
        
    
        /// <summary>
        /// ID para o Tipo de Documento vinculado ao template.
        /// </summary>
        /// <value>ID para o Tipo de Documento vinculado ao template.</value>
        [DataMember(Name="idTipoDocumento", EmitDefaultValue=false)]
        public long? IdTipoDocumento { get; set; }
    
        /// <summary>
        /// Template para o conte\u00C3\u00BAdo do documento.
        /// </summary>
        /// <value>Template para o conte\u00C3\u00BAdo do documento.</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public string Template { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentoTemplatePersist {\n");
            sb.Append("  IdTipoDocumento: ").Append(IdTipoDocumento).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            
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
            return this.Equals(obj as DocumentoTemplatePersist);
        }

        /// <summary>
        /// Returns true if DocumentoTemplatePersist instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentoTemplatePersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentoTemplatePersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdTipoDocumento == other.IdTipoDocumento ||
                    this.IdTipoDocumento != null &&
                    this.IdTipoDocumento.Equals(other.IdTipoDocumento)
                ) && 
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
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
                
                if (this.IdTipoDocumento != null)
                    hash = hash * 59 + this.IdTipoDocumento.GetHashCode();
                
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                
                return hash;
            }
        }

    }
}
