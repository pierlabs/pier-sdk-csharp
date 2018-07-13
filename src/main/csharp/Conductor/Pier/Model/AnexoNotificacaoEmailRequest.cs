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
    /// {{{anexo_notificacao_email_request_description}}}
    /// </summary>
    [DataContract]
    public partial class AnexoNotificacaoEmailRequest :  IEquatable<AnexoNotificacaoEmailRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnexoNotificacaoEmailRequest" /> class.
        /// Initializes a new instance of the <see cref="AnexoNotificacaoEmailRequest" />class.
        /// </summary>
        /// <param name="IdDocumento">{{{anexo_notificacao_email_request_id_documento_value}}}.</param>

        public AnexoNotificacaoEmailRequest(long? IdDocumento = null)
        {
            this.IdDocumento = IdDocumento;
            
        }
        
    
        /// <summary>
        /// {{{anexo_notificacao_email_request_id_documento_value}}}
        /// </summary>
        /// <value>{{{anexo_notificacao_email_request_id_documento_value}}}</value>
        [DataMember(Name="idDocumento", EmitDefaultValue=false)]
        public long? IdDocumento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnexoNotificacaoEmailRequest {\n");
            sb.Append("  IdDocumento: ").Append(IdDocumento).Append("\n");
            
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
            return this.Equals(obj as AnexoNotificacaoEmailRequest);
        }

        /// <summary>
        /// Returns true if AnexoNotificacaoEmailRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AnexoNotificacaoEmailRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnexoNotificacaoEmailRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdDocumento == other.IdDocumento ||
                    this.IdDocumento != null &&
                    this.IdDocumento.Equals(other.IdDocumento)
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
                
                if (this.IdDocumento != null)
                    hash = hash * 59 + this.IdDocumento.GetHashCode();
                
                return hash;
            }
        }

    }
}
