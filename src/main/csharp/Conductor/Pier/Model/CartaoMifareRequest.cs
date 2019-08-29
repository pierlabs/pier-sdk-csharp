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
    /// Request parameters related to mifare technology
    /// </summary>
    [DataContract]
    public partial class CartaoMifareRequest :  IEquatable<CartaoMifareRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoMifareRequest" /> class.
        /// Initializes a new instance of the <see cref="CartaoMifareRequest" />class.
        /// </summary>
        /// <param name="IdMifare">C\u00F3digo identificador da tecnologia MIFARE.</param>
        /// <param name="MatriculaMifare">N\u00FAmero da matricula do portador.</param>

        public CartaoMifareRequest(long? IdMifare = null, string MatriculaMifare = null)
        {
            this.IdMifare = IdMifare;
            this.MatriculaMifare = MatriculaMifare;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo identificador da tecnologia MIFARE
        /// </summary>
        /// <value>C\u00F3digo identificador da tecnologia MIFARE</value>
        [DataMember(Name="idMifare", EmitDefaultValue=false)]
        public long? IdMifare { get; set; }
    
        /// <summary>
        /// N\u00FAmero da matricula do portador
        /// </summary>
        /// <value>N\u00FAmero da matricula do portador</value>
        [DataMember(Name="matriculaMifare", EmitDefaultValue=false)]
        public string MatriculaMifare { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoMifareRequest {\n");
            sb.Append("  IdMifare: ").Append(IdMifare).Append("\n");
            sb.Append("  MatriculaMifare: ").Append(MatriculaMifare).Append("\n");
            
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
            return this.Equals(obj as CartaoMifareRequest);
        }

        /// <summary>
        /// Returns true if CartaoMifareRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoMifareRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoMifareRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdMifare == other.IdMifare ||
                    this.IdMifare != null &&
                    this.IdMifare.Equals(other.IdMifare)
                ) && 
                (
                    this.MatriculaMifare == other.MatriculaMifare ||
                    this.MatriculaMifare != null &&
                    this.MatriculaMifare.Equals(other.MatriculaMifare)
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
                
                if (this.IdMifare != null)
                    hash = hash * 59 + this.IdMifare.GetHashCode();
                
                if (this.MatriculaMifare != null)
                    hash = hash * 59 + this.MatriculaMifare.GetHashCode();
                
                return hash;
            }
        }

    }
}
