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
    /// Representation of the template resource document response
    /// </summary>
    [DataContract]
    public partial class DocumentoTemplateResponse :  IEquatable<DocumentoTemplateResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentoTemplateResponse" /> class.
        /// Initializes a new instance of the <see cref="DocumentoTemplateResponse" />class.
        /// </summary>
        /// <param name="Id">Template ID of the Document.</param>
        /// <param name="IdTipoTemplate">ID of the Type of Template.</param>

        public DocumentoTemplateResponse(long? Id = null, long? IdTipoTemplate = null)
        {
            this.Id = Id;
            this.IdTipoTemplate = IdTipoTemplate;
            
        }
        
    
        /// <summary>
        /// Template ID of the Document
        /// </summary>
        /// <value>Template ID of the Document</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// ID of the Type of Template
        /// </summary>
        /// <value>ID of the Type of Template</value>
        [DataMember(Name="idTipoTemplate", EmitDefaultValue=false)]
        public long? IdTipoTemplate { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentoTemplateResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdTipoTemplate: ").Append(IdTipoTemplate).Append("\n");
            
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
            return this.Equals(obj as DocumentoTemplateResponse);
        }

        /// <summary>
        /// Returns true if DocumentoTemplateResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentoTemplateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentoTemplateResponse other)
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
                    this.IdTipoTemplate == other.IdTipoTemplate ||
                    this.IdTipoTemplate != null &&
                    this.IdTipoTemplate.Equals(other.IdTipoTemplate)
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
                
                if (this.IdTipoTemplate != null)
                    hash = hash * 59 + this.IdTipoTemplate.GetHashCode();
                
                return hash;
            }
        }

    }
}
