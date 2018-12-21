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
    /// Object Device
    /// </summary>
    [DataContract]
    public partial class DevicePersist :  IEquatable<DevicePersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DevicePersist" /> class.
        /// Initializes a new instance of the <see cref="DevicePersist" />class.
        /// </summary>
        /// <param name="Token">show the token of the divece.</param>
        /// <param name="IdAplicacaoMobile">Show the identifier of the application.</param>
        /// <param name="IdUsuario">Show the identifier of the user.</param>

        public DevicePersist(string Token = null, long? IdAplicacaoMobile = null, long? IdUsuario = null)
        {
            this.Token = Token;
            this.IdAplicacaoMobile = IdAplicacaoMobile;
            this.IdUsuario = IdUsuario;
            
        }
        
    
        /// <summary>
        /// show the token of the divece
        /// </summary>
        /// <value>show the token of the divece</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }
    
        /// <summary>
        /// Show the identifier of the application
        /// </summary>
        /// <value>Show the identifier of the application</value>
        [DataMember(Name="idAplicacaoMobile", EmitDefaultValue=false)]
        public long? IdAplicacaoMobile { get; set; }
    
        /// <summary>
        /// Show the identifier of the user
        /// </summary>
        /// <value>Show the identifier of the user</value>
        [DataMember(Name="idUsuario", EmitDefaultValue=false)]
        public long? IdUsuario { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DevicePersist {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  IdAplicacaoMobile: ").Append(IdAplicacaoMobile).Append("\n");
            sb.Append("  IdUsuario: ").Append(IdUsuario).Append("\n");
            
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
            return this.Equals(obj as DevicePersist);
        }

        /// <summary>
        /// Returns true if DevicePersist instances are equal
        /// </summary>
        /// <param name="other">Instance of DevicePersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DevicePersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
                ) && 
                (
                    this.IdAplicacaoMobile == other.IdAplicacaoMobile ||
                    this.IdAplicacaoMobile != null &&
                    this.IdAplicacaoMobile.Equals(other.IdAplicacaoMobile)
                ) && 
                (
                    this.IdUsuario == other.IdUsuario ||
                    this.IdUsuario != null &&
                    this.IdUsuario.Equals(other.IdUsuario)
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
                
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                
                if (this.IdAplicacaoMobile != null)
                    hash = hash * 59 + this.IdAplicacaoMobile.GetHashCode();
                
                if (this.IdUsuario != null)
                    hash = hash * 59 + this.IdUsuario.GetHashCode();
                
                return hash;
            }
        }

    }
}
