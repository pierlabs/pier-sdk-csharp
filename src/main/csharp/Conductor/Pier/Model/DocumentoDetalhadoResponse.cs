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
    /// {{{documento_detalhado_response_description}}}
    /// </summary>
    [DataContract]
    public partial class DocumentoDetalhadoResponse :  IEquatable<DocumentoDetalhadoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentoDetalhadoResponse" /> class.
        /// Initializes a new instance of the <see cref="DocumentoDetalhadoResponse" />class.
        /// </summary>
        /// <param name="Id">{{{documento_detalhado_response_id_value}}}.</param>
        /// <param name="IdTemplateDocumento">{{{documento_detalhado_response_id_template_documento_value}}}.</param>
        /// <param name="Nome">{{{documento_detalhado_response_nome_value}}}.</param>
        /// <param name="Documento">{{{documento_detalhado_response_documento_value}}}.</param>
        /// <param name="Extensao">{{{documento_detalhado_response_extensao_value}}}.</param>
        /// <param name="DocumentoDetalhes">{{{documento_detalhado_response_documento_detalhes_value}}}.</param>

        public DocumentoDetalhadoResponse(long? Id = null, long? IdTemplateDocumento = null, string Nome = null, string Documento = null, string Extensao = null, List<DocumentoDetalheResponse> DocumentoDetalhes = null)
        {
            this.Id = Id;
            this.IdTemplateDocumento = IdTemplateDocumento;
            this.Nome = Nome;
            this.Documento = Documento;
            this.Extensao = Extensao;
            this.DocumentoDetalhes = DocumentoDetalhes;
            
        }
        
    
        /// <summary>
        /// {{{documento_detalhado_response_id_value}}}
        /// </summary>
        /// <value>{{{documento_detalhado_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{documento_detalhado_response_id_template_documento_value}}}
        /// </summary>
        /// <value>{{{documento_detalhado_response_id_template_documento_value}}}</value>
        [DataMember(Name="idTemplateDocumento", EmitDefaultValue=false)]
        public long? IdTemplateDocumento { get; set; }
    
        /// <summary>
        /// {{{documento_detalhado_response_nome_value}}}
        /// </summary>
        /// <value>{{{documento_detalhado_response_nome_value}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// {{{documento_detalhado_response_documento_value}}}
        /// </summary>
        /// <value>{{{documento_detalhado_response_documento_value}}}</value>
        [DataMember(Name="documento", EmitDefaultValue=false)]
        public string Documento { get; set; }
    
        /// <summary>
        /// {{{documento_detalhado_response_extensao_value}}}
        /// </summary>
        /// <value>{{{documento_detalhado_response_extensao_value}}}</value>
        [DataMember(Name="extensao", EmitDefaultValue=false)]
        public string Extensao { get; set; }
    
        /// <summary>
        /// {{{documento_detalhado_response_documento_detalhes_value}}}
        /// </summary>
        /// <value>{{{documento_detalhado_response_documento_detalhes_value}}}</value>
        [DataMember(Name="documentoDetalhes", EmitDefaultValue=false)]
        public List<DocumentoDetalheResponse> DocumentoDetalhes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentoDetalhadoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdTemplateDocumento: ").Append(IdTemplateDocumento).Append("\n");
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
            return this.Equals(obj as DocumentoDetalhadoResponse);
        }

        /// <summary>
        /// Returns true if DocumentoDetalhadoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentoDetalhadoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentoDetalhadoResponse other)
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
                
                if (this.IdTemplateDocumento != null)
                    hash = hash * 59 + this.IdTemplateDocumento.GetHashCode();
                
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
