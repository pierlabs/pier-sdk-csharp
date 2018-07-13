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
    /// {{{integrar_documento_request_description}}}
    /// </summary>
    [DataContract]
    public partial class IntegrarDocumentoRequest :  IEquatable<IntegrarDocumentoRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrarDocumentoRequest" /> class.
        /// Initializes a new instance of the <see cref="IntegrarDocumentoRequest" />class.
        /// </summary>
        /// <param name="IdTemplate">{{{integrar_documento_request_id_template_value}}}.</param>
        /// <param name="Arquivo">{{{integrar_documento_request_arquivo_value}}}.</param>
        /// <param name="Nome">{{{integrar_documento_request_nome_value}}}.</param>
        /// <param name="Propriedades">{{{integrar_documento_request_propriedades_value}}}.</param>

        public IntegrarDocumentoRequest(long? IdTemplate = null, string Arquivo = null, string Nome = null, List<PropriedadeDocumentoRequest> Propriedades = null)
        {
            this.IdTemplate = IdTemplate;
            this.Arquivo = Arquivo;
            this.Nome = Nome;
            this.Propriedades = Propriedades;
            
        }
        
    
        /// <summary>
        /// {{{integrar_documento_request_id_template_value}}}
        /// </summary>
        /// <value>{{{integrar_documento_request_id_template_value}}}</value>
        [DataMember(Name="idTemplate", EmitDefaultValue=false)]
        public long? IdTemplate { get; set; }
    
        /// <summary>
        /// {{{integrar_documento_request_arquivo_value}}}
        /// </summary>
        /// <value>{{{integrar_documento_request_arquivo_value}}}</value>
        [DataMember(Name="arquivo", EmitDefaultValue=false)]
        public string Arquivo { get; set; }
    
        /// <summary>
        /// {{{integrar_documento_request_nome_value}}}
        /// </summary>
        /// <value>{{{integrar_documento_request_nome_value}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// {{{integrar_documento_request_propriedades_value}}}
        /// </summary>
        /// <value>{{{integrar_documento_request_propriedades_value}}}</value>
        [DataMember(Name="propriedades", EmitDefaultValue=false)]
        public List<PropriedadeDocumentoRequest> Propriedades { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegrarDocumentoRequest {\n");
            sb.Append("  IdTemplate: ").Append(IdTemplate).Append("\n");
            sb.Append("  Arquivo: ").Append(Arquivo).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Propriedades: ").Append(Propriedades).Append("\n");
            
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
            return this.Equals(obj as IntegrarDocumentoRequest);
        }

        /// <summary>
        /// Returns true if IntegrarDocumentoRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of IntegrarDocumentoRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrarDocumentoRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdTemplate == other.IdTemplate ||
                    this.IdTemplate != null &&
                    this.IdTemplate.Equals(other.IdTemplate)
                ) && 
                (
                    this.Arquivo == other.Arquivo ||
                    this.Arquivo != null &&
                    this.Arquivo.Equals(other.Arquivo)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.Propriedades == other.Propriedades ||
                    this.Propriedades != null &&
                    this.Propriedades.SequenceEqual(other.Propriedades)
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
                
                if (this.IdTemplate != null)
                    hash = hash * 59 + this.IdTemplate.GetHashCode();
                
                if (this.Arquivo != null)
                    hash = hash * 59 + this.Arquivo.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Propriedades != null)
                    hash = hash * 59 + this.Propriedades.GetHashCode();
                
                return hash;
            }
        }

    }
}
