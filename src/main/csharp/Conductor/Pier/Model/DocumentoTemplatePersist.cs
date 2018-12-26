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
    /// Representa\u00E7\u00E3o do template do documento
    /// </summary>
    [DataContract]
    public partial class DocumentoTemplatePersist :  IEquatable<DocumentoTemplatePersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentoTemplatePersist" /> class.
        /// Initializes a new instance of the <see cref="DocumentoTemplatePersist" />class.
        /// </summary>
        /// <param name="IdTipoTemplate">ID para o Tipo de Template vinculado ao template.</param>
        /// <param name="Template">Template para o conte\u00FAdo do documento.</param>
        /// <param name="Integracoes">Lista de configura\u00E7\u00F5es de integra\u00E7\u00E3o.</param>

        public DocumentoTemplatePersist(long? IdTipoTemplate = null, string Template = null, List<ReferenciaIdPersist> Integracoes = null)
        {
            this.IdTipoTemplate = IdTipoTemplate;
            this.Template = Template;
            this.Integracoes = Integracoes;
            
        }
        
    
        /// <summary>
        /// ID para o Tipo de Template vinculado ao template
        /// </summary>
        /// <value>ID para o Tipo de Template vinculado ao template</value>
        [DataMember(Name="idTipoTemplate", EmitDefaultValue=false)]
        public long? IdTipoTemplate { get; set; }
    
        /// <summary>
        /// Template para o conte\u00FAdo do documento
        /// </summary>
        /// <value>Template para o conte\u00FAdo do documento</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public string Template { get; set; }
    
        /// <summary>
        /// Lista de configura\u00E7\u00F5es de integra\u00E7\u00E3o
        /// </summary>
        /// <value>Lista de configura\u00E7\u00F5es de integra\u00E7\u00E3o</value>
        [DataMember(Name="integracoes", EmitDefaultValue=false)]
        public List<ReferenciaIdPersist> Integracoes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentoTemplatePersist {\n");
            sb.Append("  IdTipoTemplate: ").Append(IdTipoTemplate).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  Integracoes: ").Append(Integracoes).Append("\n");
            
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
                    this.IdTipoTemplate == other.IdTipoTemplate ||
                    this.IdTipoTemplate != null &&
                    this.IdTipoTemplate.Equals(other.IdTipoTemplate)
                ) && 
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
                ) && 
                (
                    this.Integracoes == other.Integracoes ||
                    this.Integracoes != null &&
                    this.Integracoes.SequenceEqual(other.Integracoes)
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
                
                if (this.IdTipoTemplate != null)
                    hash = hash * 59 + this.IdTipoTemplate.GetHashCode();
                
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                
                if (this.Integracoes != null)
                    hash = hash * 59 + this.Integracoes.GetHashCode();
                
                return hash;
            }
        }

    }
}
