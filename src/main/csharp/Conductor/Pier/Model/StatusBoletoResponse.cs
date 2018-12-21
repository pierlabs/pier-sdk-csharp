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
    /// Representation of the ticket status resource response
    /// </summary>
    [DataContract]
    public partial class StatusBoletoResponse :  IEquatable<StatusBoletoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusBoletoResponse" /> class.
        /// Initializes a new instance of the <see cref="StatusBoletoResponse" />class.
        /// </summary>
        /// <param name="Status">Description of the CNAB summarized status of the ticket.</param>
        /// <param name="Data">Date the status was set.</param>

        public StatusBoletoResponse(string Status = null, string Data = null)
        {
            this.Status = Status;
            this.Data = Data;
            
        }
        
    
        /// <summary>
        /// Description of the CNAB summarized status of the ticket
        /// </summary>
        /// <value>Description of the CNAB summarized status of the ticket</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Date the status was set
        /// </summary>
        /// <value>Date the status was set</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public string Data { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusBoletoResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            
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
            return this.Equals(obj as StatusBoletoResponse);
        }

        /// <summary>
        /// Returns true if StatusBoletoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of StatusBoletoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusBoletoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
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
                
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                
                return hash;
            }
        }

    }
}
