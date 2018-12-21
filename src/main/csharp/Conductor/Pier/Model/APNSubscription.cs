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
    /// Represents a new subscription
    /// </summary>
    [DataContract]
    public partial class APNSubscription :  IEquatable<APNSubscription>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="APNSubscription" /> class.
        /// Initializes a new instance of the <see cref="APNSubscription" />class.
        /// </summary>
        /// <param name="DeviceToken">The device token.</param>
        /// <param name="IdAplicacaoMobile">The mobile application id.</param>
        /// <param name="IdCartoes">List of card ids.</param>

        public APNSubscription(string DeviceToken = null, long? IdAplicacaoMobile = null, List<long?> IdCartoes = null)
        {
            this.DeviceToken = DeviceToken;
            this.IdAplicacaoMobile = IdAplicacaoMobile;
            this.IdCartoes = IdCartoes;
            
        }
        
    
        /// <summary>
        /// The device token
        /// </summary>
        /// <value>The device token</value>
        [DataMember(Name="deviceToken", EmitDefaultValue=false)]
        public string DeviceToken { get; set; }
    
        /// <summary>
        /// The mobile application id
        /// </summary>
        /// <value>The mobile application id</value>
        [DataMember(Name="idAplicacaoMobile", EmitDefaultValue=false)]
        public long? IdAplicacaoMobile { get; set; }
    
        /// <summary>
        /// List of card ids
        /// </summary>
        /// <value>List of card ids</value>
        [DataMember(Name="idCartoes", EmitDefaultValue=false)]
        public List<long?> IdCartoes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class APNSubscription {\n");
            sb.Append("  DeviceToken: ").Append(DeviceToken).Append("\n");
            sb.Append("  IdAplicacaoMobile: ").Append(IdAplicacaoMobile).Append("\n");
            sb.Append("  IdCartoes: ").Append(IdCartoes).Append("\n");
            
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
            return this.Equals(obj as APNSubscription);
        }

        /// <summary>
        /// Returns true if APNSubscription instances are equal
        /// </summary>
        /// <param name="other">Instance of APNSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APNSubscription other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeviceToken == other.DeviceToken ||
                    this.DeviceToken != null &&
                    this.DeviceToken.Equals(other.DeviceToken)
                ) && 
                (
                    this.IdAplicacaoMobile == other.IdAplicacaoMobile ||
                    this.IdAplicacaoMobile != null &&
                    this.IdAplicacaoMobile.Equals(other.IdAplicacaoMobile)
                ) && 
                (
                    this.IdCartoes == other.IdCartoes ||
                    this.IdCartoes != null &&
                    this.IdCartoes.SequenceEqual(other.IdCartoes)
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
                
                if (this.DeviceToken != null)
                    hash = hash * 59 + this.DeviceToken.GetHashCode();
                
                if (this.IdAplicacaoMobile != null)
                    hash = hash * 59 + this.IdAplicacaoMobile.GetHashCode();
                
                if (this.IdCartoes != null)
                    hash = hash * 59 + this.IdCartoes.GetHashCode();
                
                return hash;
            }
        }

    }
}
