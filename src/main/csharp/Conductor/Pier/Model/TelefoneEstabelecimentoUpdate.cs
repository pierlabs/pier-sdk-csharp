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
    /// Object telephone
    /// </summary>
    [DataContract]
    public partial class TelefoneEstabelecimentoUpdate :  IEquatable<TelefoneEstabelecimentoUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TelefoneEstabelecimentoUpdate" /> class.
        /// Initializes a new instance of the <see cref="TelefoneEstabelecimentoUpdate" />class.
        /// </summary>
        /// <param name="Ddd">Telephone area code (required).</param>
        /// <param name="Telefone">Phone Number (required).</param>
        /// <param name="Ramal">Phone branch.</param>

        public TelefoneEstabelecimentoUpdate(string Ddd = null, string Telefone = null, string Ramal = null)
        {
            // to ensure "Ddd" is required (not null)
            if (Ddd == null)
            {
                throw new InvalidDataException("Ddd is a required property for TelefoneEstabelecimentoUpdate and cannot be null");
            }
            else
            {
                this.Ddd = Ddd;
            }
            // to ensure "Telefone" is required (not null)
            if (Telefone == null)
            {
                throw new InvalidDataException("Telefone is a required property for TelefoneEstabelecimentoUpdate and cannot be null");
            }
            else
            {
                this.Telefone = Telefone;
            }
            this.Ramal = Ramal;
            
        }
        
    
        /// <summary>
        /// Telephone area code
        /// </summary>
        /// <value>Telephone area code</value>
        [DataMember(Name="ddd", EmitDefaultValue=false)]
        public string Ddd { get; set; }
    
        /// <summary>
        /// Phone Number
        /// </summary>
        /// <value>Phone Number</value>
        [DataMember(Name="telefone", EmitDefaultValue=false)]
        public string Telefone { get; set; }
    
        /// <summary>
        /// Phone branch
        /// </summary>
        /// <value>Phone branch</value>
        [DataMember(Name="ramal", EmitDefaultValue=false)]
        public string Ramal { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TelefoneEstabelecimentoUpdate {\n");
            sb.Append("  Ddd: ").Append(Ddd).Append("\n");
            sb.Append("  Telefone: ").Append(Telefone).Append("\n");
            sb.Append("  Ramal: ").Append(Ramal).Append("\n");
            
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
            return this.Equals(obj as TelefoneEstabelecimentoUpdate);
        }

        /// <summary>
        /// Returns true if TelefoneEstabelecimentoUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of TelefoneEstabelecimentoUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TelefoneEstabelecimentoUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Ddd == other.Ddd ||
                    this.Ddd != null &&
                    this.Ddd.Equals(other.Ddd)
                ) && 
                (
                    this.Telefone == other.Telefone ||
                    this.Telefone != null &&
                    this.Telefone.Equals(other.Telefone)
                ) && 
                (
                    this.Ramal == other.Ramal ||
                    this.Ramal != null &&
                    this.Ramal.Equals(other.Ramal)
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
                
                if (this.Ddd != null)
                    hash = hash * 59 + this.Ddd.GetHashCode();
                
                if (this.Telefone != null)
                    hash = hash * 59 + this.Telefone.GetHashCode();
                
                if (this.Ramal != null)
                    hash = hash * 59 + this.Ramal.GetHashCode();
                
                return hash;
            }
        }

    }
}
