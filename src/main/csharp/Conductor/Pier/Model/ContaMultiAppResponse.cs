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
    /// Object with account record response MultiApp
    /// </summary>
    [DataContract]
    public partial class ContaMultiAppResponse :  IEquatable<ContaMultiAppResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaMultiAppResponse" /> class.
        /// Initializes a new instance of the <see cref="ContaMultiAppResponse" />class.
        /// </summary>
        /// <param name="Contas">generated MultiApp accounts.</param>

        public ContaMultiAppResponse(List<ContaResponse> Contas = null)
        {
            this.Contas = Contas;
            
        }
        
    
        /// <summary>
        /// generated MultiApp accounts
        /// </summary>
        /// <value>generated MultiApp accounts</value>
        [DataMember(Name="contas", EmitDefaultValue=false)]
        public List<ContaResponse> Contas { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContaMultiAppResponse {\n");
            sb.Append("  Contas: ").Append(Contas).Append("\n");
            
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
            return this.Equals(obj as ContaMultiAppResponse);
        }

        /// <summary>
        /// Returns true if ContaMultiAppResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ContaMultiAppResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContaMultiAppResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Contas == other.Contas ||
                    this.Contas != null &&
                    this.Contas.SequenceEqual(other.Contas)
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
                
                if (this.Contas != null)
                    hash = hash * 59 + this.Contas.GetHashCode();
                
                return hash;
            }
        }

    }
}
