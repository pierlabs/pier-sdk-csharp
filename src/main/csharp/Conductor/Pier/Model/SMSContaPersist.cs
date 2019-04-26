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
    /// Objeto de persist\u00EAncia de SMSConta
    /// </summary>
    [DataContract]
    public partial class SMSContaPersist :  IEquatable<SMSContaPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SMSContaPersist" /> class.
        /// Initializes a new instance of the <see cref="SMSContaPersist" />class.
        /// </summary>
        /// <param name="IdSMSTipoServico">Id do tipo servi\u00E7o SMS (Id_SMSTipoServico) (required).</param>

        public SMSContaPersist(long? IdSMSTipoServico = null)
        {
            // to ensure "IdSMSTipoServico" is required (not null)
            if (IdSMSTipoServico == null)
            {
                throw new InvalidDataException("IdSMSTipoServico is a required property for SMSContaPersist and cannot be null");
            }
            else
            {
                this.IdSMSTipoServico = IdSMSTipoServico;
            }
            
        }
        
    
        /// <summary>
        /// Id do tipo servi\u00E7o SMS (Id_SMSTipoServico)
        /// </summary>
        /// <value>Id do tipo servi\u00E7o SMS (Id_SMSTipoServico)</value>
        [DataMember(Name="idSMSTipoServico", EmitDefaultValue=false)]
        public long? IdSMSTipoServico { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SMSContaPersist {\n");
            sb.Append("  IdSMSTipoServico: ").Append(IdSMSTipoServico).Append("\n");
            
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
            return this.Equals(obj as SMSContaPersist);
        }

        /// <summary>
        /// Returns true if SMSContaPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of SMSContaPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SMSContaPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdSMSTipoServico == other.IdSMSTipoServico ||
                    this.IdSMSTipoServico != null &&
                    this.IdSMSTipoServico.Equals(other.IdSMSTipoServico)
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
                
                if (this.IdSMSTipoServico != null)
                    hash = hash * 59 + this.IdSMSTipoServico.GetHashCode();
                
                return hash;
            }
        }

    }
}
