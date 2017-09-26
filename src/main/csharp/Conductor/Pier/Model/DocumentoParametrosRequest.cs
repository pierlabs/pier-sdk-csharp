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
    /// Objeto que encapsula os par\u00C3\u00A2metros para gera\u00C3\u00A7\u00C3\u00A3o de um documento
    /// </summary>
    [DataContract]
    public partial class DocumentoParametrosRequest :  IEquatable<DocumentoParametrosRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentoParametrosRequest" /> class.
        /// Initializes a new instance of the <see cref="DocumentoParametrosRequest" />class.
        /// </summary>
        /// <param name="IdTipoDocumento">ID para o tipo de documento..</param>
        /// <param name="IdTemplateDocumento">ID para o template do documento..</param>
        /// <param name="Nome">Nome para o arquivo..</param>
        /// <param name="ParametrosConteudo">Mapa de par\u00C3\u00A2metros para montagem do documento..</param>

        public DocumentoParametrosRequest(long? IdTipoDocumento = null, long? IdTemplateDocumento = null, string Nome = null, Dictionary<string, Object> ParametrosConteudo = null)
        {
            this.IdTipoDocumento = IdTipoDocumento;
            this.IdTemplateDocumento = IdTemplateDocumento;
            this.Nome = Nome;
            this.ParametrosConteudo = ParametrosConteudo;
            
        }
        
    
        /// <summary>
        /// ID para o tipo de documento.
        /// </summary>
        /// <value>ID para o tipo de documento.</value>
        [DataMember(Name="idTipoDocumento", EmitDefaultValue=false)]
        public long? IdTipoDocumento { get; set; }
    
        /// <summary>
        /// ID para o template do documento.
        /// </summary>
        /// <value>ID para o template do documento.</value>
        [DataMember(Name="idTemplateDocumento", EmitDefaultValue=false)]
        public long? IdTemplateDocumento { get; set; }
    
        /// <summary>
        /// Nome para o arquivo.
        /// </summary>
        /// <value>Nome para o arquivo.</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Mapa de par\u00C3\u00A2metros para montagem do documento.
        /// </summary>
        /// <value>Mapa de par\u00C3\u00A2metros para montagem do documento.</value>
        [DataMember(Name="parametrosConteudo", EmitDefaultValue=false)]
        public Dictionary<string, Object> ParametrosConteudo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentoParametrosRequest {\n");
            sb.Append("  IdTipoDocumento: ").Append(IdTipoDocumento).Append("\n");
            sb.Append("  IdTemplateDocumento: ").Append(IdTemplateDocumento).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  ParametrosConteudo: ").Append(ParametrosConteudo).Append("\n");
            
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
            return this.Equals(obj as DocumentoParametrosRequest);
        }

        /// <summary>
        /// Returns true if DocumentoParametrosRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentoParametrosRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentoParametrosRequest other)
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
                    this.IdTemplateDocumento == other.IdTemplateDocumento ||
                    this.IdTemplateDocumento != null &&
                    this.IdTemplateDocumento.Equals(other.IdTemplateDocumento)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.ParametrosConteudo == other.ParametrosConteudo ||
                    this.ParametrosConteudo != null &&
                    this.ParametrosConteudo.SequenceEqual(other.ParametrosConteudo)
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
                
                if (this.IdTemplateDocumento != null)
                    hash = hash * 59 + this.IdTemplateDocumento.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.ParametrosConteudo != null)
                    hash = hash * 59 + this.ParametrosConteudo.GetHashCode();
                
                return hash;
            }
        }

    }
}
