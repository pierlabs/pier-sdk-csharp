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
    /// LogAcessoUsuarioResponse
    /// </summary>
    [DataContract]
    public partial class LogAcessoUsuarioResponse :  IEquatable<LogAcessoUsuarioResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LogAcessoUsuarioResponse" /> class.
        /// Initializes a new instance of the <see cref="LogAcessoUsuarioResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo de mensagem inserida (id).</param>

        public LogAcessoUsuarioResponse(long? Id = null)
        {
            this.Id = Id;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de mensagem inserida (id)
        /// </summary>
        /// <value>C\u00F3digo de mensagem inserida (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogAcessoUsuarioResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            
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
            return this.Equals(obj as LogAcessoUsuarioResponse);
        }

        /// <summary>
        /// Returns true if LogAcessoUsuarioResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of LogAcessoUsuarioResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogAcessoUsuarioResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                
                return hash;
            }
        }

    }
}
