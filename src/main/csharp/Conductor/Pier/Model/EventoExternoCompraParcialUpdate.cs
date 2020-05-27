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
    /// Objeto que representa a altera\u00E7\u00E3o parcial do recurso de Evento Externo de Compra
    /// </summary>
    [DataContract]
    public partial class EventoExternoCompraParcialUpdate :  IEquatable<EventoExternoCompraParcialUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EventoExternoCompraParcialUpdate" /> class.
        /// Initializes a new instance of the <see cref="EventoExternoCompraParcialUpdate" />class.
        /// </summary>
        /// <param name="Status">Status da compra (required).</param>

        public EventoExternoCompraParcialUpdate(long? Status = null)
        {
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for EventoExternoCompraParcialUpdate and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            
        }
        
    
        /// <summary>
        /// Status da compra
        /// </summary>
        /// <value>Status da compra</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public long? Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventoExternoCompraParcialUpdate {\n");
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
            return this.Equals(obj as EventoExternoCompraParcialUpdate);
        }

        /// <summary>
        /// Returns true if EventoExternoCompraParcialUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of EventoExternoCompraParcialUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventoExternoCompraParcialUpdate other)
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
