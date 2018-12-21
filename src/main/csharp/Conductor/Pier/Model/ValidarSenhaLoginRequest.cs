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
    /// Representation of the login request valid for login
    /// </summary>
    [DataContract]
    public partial class ValidarSenhaLoginRequest :  IEquatable<ValidarSenhaLoginRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidarSenhaLoginRequest" /> class.
        /// Initializes a new instance of the <see cref="ValidarSenhaLoginRequest" />class.
        /// </summary>
        /// <param name="IdPlataforma">PlataformId.</param>

        public ValidarSenhaLoginRequest(int? IdPlataforma = null)
        {
            this.IdPlataforma = IdPlataforma;
            
        }
        
    
        /// <summary>
        /// PlataformId
        /// </summary>
        /// <value>PlataformId</value>
        [DataMember(Name="idPlataforma", EmitDefaultValue=false)]
        public int? IdPlataforma { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidarSenhaLoginRequest {\n");
            sb.Append("  IdPlataforma: ").Append(IdPlataforma).Append("\n");
            
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
            return this.Equals(obj as ValidarSenhaLoginRequest);
        }

        /// <summary>
        /// Returns true if ValidarSenhaLoginRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidarSenhaLoginRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidarSenhaLoginRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdPlataforma == other.IdPlataforma ||
                    this.IdPlataforma != null &&
                    this.IdPlataforma.Equals(other.IdPlataforma)
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
                
                if (this.IdPlataforma != null)
                    hash = hash * 59 + this.IdPlataforma.GetHashCode();
                
                return hash;
            }
        }

    }
}
