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
    /// User device identifier object
    /// </summary>
    [DataContract]
    public partial class UsuarioDispositivoPersist :  IEquatable<UsuarioDispositivoPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioDispositivoPersist" /> class.
        /// Initializes a new instance of the <see cref="UsuarioDispositivoPersist" />class.
        /// </summary>
        /// <param name="IdUsuario">User identifier code (required).</param>
        /// <param name="PhoneId">User device identifier code (required).</param>

        public UsuarioDispositivoPersist(long? IdUsuario = null, string PhoneId = null)
        {
            // to ensure "IdUsuario" is required (not null)
            if (IdUsuario == null)
            {
                throw new InvalidDataException("IdUsuario is a required property for UsuarioDispositivoPersist and cannot be null");
            }
            else
            {
                this.IdUsuario = IdUsuario;
            }
            // to ensure "PhoneId" is required (not null)
            if (PhoneId == null)
            {
                throw new InvalidDataException("PhoneId is a required property for UsuarioDispositivoPersist and cannot be null");
            }
            else
            {
                this.PhoneId = PhoneId;
            }
            
        }
        
    
        /// <summary>
        /// User identifier code
        /// </summary>
        /// <value>User identifier code</value>
        [DataMember(Name="idUsuario", EmitDefaultValue=false)]
        public long? IdUsuario { get; set; }
    
        /// <summary>
        /// User device identifier code
        /// </summary>
        /// <value>User device identifier code</value>
        [DataMember(Name="phoneId", EmitDefaultValue=false)]
        public string PhoneId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsuarioDispositivoPersist {\n");
            sb.Append("  IdUsuario: ").Append(IdUsuario).Append("\n");
            sb.Append("  PhoneId: ").Append(PhoneId).Append("\n");
            
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
            return this.Equals(obj as UsuarioDispositivoPersist);
        }

        /// <summary>
        /// Returns true if UsuarioDispositivoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of UsuarioDispositivoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsuarioDispositivoPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdUsuario == other.IdUsuario ||
                    this.IdUsuario != null &&
                    this.IdUsuario.Equals(other.IdUsuario)
                ) && 
                (
                    this.PhoneId == other.PhoneId ||
                    this.PhoneId != null &&
                    this.PhoneId.Equals(other.PhoneId)
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
                
                if (this.IdUsuario != null)
                    hash = hash * 59 + this.IdUsuario.GetHashCode();
                
                if (this.PhoneId != null)
                    hash = hash * 59 + this.PhoneId.GetHashCode();
                
                return hash;
            }
        }

    }
}
