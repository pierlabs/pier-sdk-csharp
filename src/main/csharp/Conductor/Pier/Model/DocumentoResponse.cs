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
    /// Representa\u00C3\u00A7\u00C3\u00A3o da resposta para o recurso de Documento
    /// </summary>
    [DataContract]
    public partial class DocumentoResponse :  IEquatable<DocumentoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentoResponse" /> class.
        /// Initializes a new instance of the <see cref="DocumentoResponse" />class.
        /// </summary>
        /// <param name="Id">ID do Documento..</param>
        /// <param name="IdDocumentoTipo">ID do Tipo de Documento associado..</param>
        /// <param name="IdDocumentoTemplate">ID do Template de Documento associado..</param>
        /// <param name="Nome">Nome do Documento..</param>
        /// <param name="Documento">Nome do Documento..</param>
        /// <param name="Extensao">Extens\u00C3\u00A3o do Documento..</param>
        /// <param name="DocumentoDetalhes">Detalhamento do documento..</param>

        public DocumentoResponse(long? Id = null, long? IdDocumentoTipo = null, long? IdDocumentoTemplate = null, string Nome = null, string Documento = null, string Extensao = null, List<DocumentoDetalheResponse> DocumentoDetalhes = null)
        {
            this.Id = Id;
            this.IdDocumentoTipo = IdDocumentoTipo;
            this.IdDocumentoTemplate = IdDocumentoTemplate;
            this.Nome = Nome;
            this.Documento = Documento;
            this.Extensao = Extensao;
            this.DocumentoDetalhes = DocumentoDetalhes;
            
        }
        
    
        /// <summary>
        /// ID do Documento.
        /// </summary>
        /// <value>ID do Documento.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// ID do Tipo de Documento associado.
        /// </summary>
        /// <value>ID do Tipo de Documento associado.</value>
        [DataMember(Name="idDocumentoTipo", EmitDefaultValue=false)]
        public long? IdDocumentoTipo { get; set; }
    
        /// <summary>
        /// ID do Template de Documento associado.
        /// </summary>
        /// <value>ID do Template de Documento associado.</value>
        [DataMember(Name="idDocumentoTemplate", EmitDefaultValue=false)]
        public long? IdDocumentoTemplate { get; set; }
    
        /// <summary>
        /// Nome do Documento.
        /// </summary>
        /// <value>Nome do Documento.</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Nome do Documento.
        /// </summary>
        /// <value>Nome do Documento.</value>
        [DataMember(Name="documento", EmitDefaultValue=false)]
        public string Documento { get; set; }
    
        /// <summary>
        /// Extens\u00C3\u00A3o do Documento.
        /// </summary>
        /// <value>Extens\u00C3\u00A3o do Documento.</value>
        [DataMember(Name="extensao", EmitDefaultValue=false)]
        public string Extensao { get; set; }
    
        /// <summary>
        /// Detalhamento do documento.
        /// </summary>
        /// <value>Detalhamento do documento.</value>
        [DataMember(Name="documentoDetalhes", EmitDefaultValue=false)]
        public List<DocumentoDetalheResponse> DocumentoDetalhes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdDocumentoTipo: ").Append(IdDocumentoTipo).Append("\n");
            sb.Append("  IdDocumentoTemplate: ").Append(IdDocumentoTemplate).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Documento: ").Append(Documento).Append("\n");
            sb.Append("  Extensao: ").Append(Extensao).Append("\n");
            sb.Append("  DocumentoDetalhes: ").Append(DocumentoDetalhes).Append("\n");
            
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
            return this.Equals(obj as DocumentoResponse);
        }

        /// <summary>
        /// Returns true if DocumentoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentoResponse other)
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
                    this.IdDocumentoTipo == other.IdDocumentoTipo ||
                    this.IdDocumentoTipo != null &&
                    this.IdDocumentoTipo.Equals(other.IdDocumentoTipo)
                ) && 
                (
                    this.IdDocumentoTemplate == other.IdDocumentoTemplate ||
                    this.IdDocumentoTemplate != null &&
                    this.IdDocumentoTemplate.Equals(other.IdDocumentoTemplate)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.Documento == other.Documento ||
                    this.Documento != null &&
                    this.Documento.Equals(other.Documento)
                ) && 
                (
                    this.Extensao == other.Extensao ||
                    this.Extensao != null &&
                    this.Extensao.Equals(other.Extensao)
                ) && 
                (
                    this.DocumentoDetalhes == other.DocumentoDetalhes ||
                    this.DocumentoDetalhes != null &&
                    this.DocumentoDetalhes.SequenceEqual(other.DocumentoDetalhes)
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
                
                if (this.IdDocumentoTipo != null)
                    hash = hash * 59 + this.IdDocumentoTipo.GetHashCode();
                
                if (this.IdDocumentoTemplate != null)
                    hash = hash * 59 + this.IdDocumentoTemplate.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Documento != null)
                    hash = hash * 59 + this.Documento.GetHashCode();
                
                if (this.Extensao != null)
                    hash = hash * 59 + this.Extensao.GetHashCode();
                
                if (this.DocumentoDetalhes != null)
                    hash = hash * 59 + this.DocumentoDetalhes.GetHashCode();
                
                return hash;
            }
        }

    }
}
