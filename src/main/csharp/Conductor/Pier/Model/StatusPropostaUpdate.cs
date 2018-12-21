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
    /// {{{status_proposta_update_request_description}}}
    /// </summary>
    [DataContract]
    public partial class StatusPropostaUpdate :  IEquatable<StatusPropostaUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusPropostaUpdate" /> class.
        /// Initializes a new instance of the <see cref="StatusPropostaUpdate" />class.
        /// </summary>
        /// <param name="Status">{{{status_proposta_update_status_value}}} (required).</param>

        public StatusPropostaUpdate(int? Status = null)
        {
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for StatusPropostaUpdate and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            
        }
        
    
        /// <summary>
        /// {{{status_proposta_update_status_value}}}
        /// </summary>
        /// <value>{{{status_proposta_update_status_value}}}</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusPropostaUpdate {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            
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
            return this.Equals(obj as StatusPropostaUpdate);
        }

        /// <summary>
        /// Returns true if StatusPropostaUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of StatusPropostaUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusPropostaUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
