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
    /// 
    /// </summary>
    [DataContract]
    public partial class Body :  IEquatable<Body>
    { 
    
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum {
            
            [EnumMember(Value = "CREATED")]
            Created,
            
            [EnumMember(Value = "UPDATED")]
            Updated,
            
            [EnumMember(Value = "DELETED")]
            Deleted
        }

    
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Body" /> class.
        /// Initializes a new instance of the <see cref="Body" />class.
        /// </summary>
        /// <param name="AuthToken">AuthToken.</param>
        /// <param name="Action">Action.</param>
        /// <param name="User">User.</param>

        public Body(AuthToken AuthToken = null, ActionEnum? Action = null, string User = null)
        {
            this.AuthToken = AuthToken;
            this.Action = Action;
            this.User = User;
            
        }
        
    
        /// <summary>
        /// Gets or Sets AuthToken
        /// </summary>
        [DataMember(Name="AuthToken", EmitDefaultValue=false)]
        public AuthToken AuthToken { get; set; }
    
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public string User { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body {\n");
            sb.Append("  AuthToken: ").Append(AuthToken).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            
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
            return this.Equals(obj as Body);
        }

        /// <summary>
        /// Returns true if Body instances are equal
        /// </summary>
        /// <param name="other">Instance of Body to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AuthToken == other.AuthToken ||
                    this.AuthToken != null &&
                    this.AuthToken.Equals(other.AuthToken)
                ) && 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                
                if (this.AuthToken != null)
                    hash = hash * 59 + this.AuthToken.GetHashCode();
                
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                return hash;
            }
        }

    }
}
