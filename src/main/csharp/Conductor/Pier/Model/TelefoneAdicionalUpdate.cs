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
    /// Object Telphone
    /// </summary>
    [DataContract]
    public partial class TelefoneAdicionalUpdate :  IEquatable<TelefoneAdicionalUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TelefoneAdicionalUpdate" /> class.
        /// Initializes a new instance of the <see cref="TelefoneAdicionalUpdate" />class.
        /// </summary>
        /// <param name="Id">Identification Code of the Telephone.</param>
        /// <param name="IdTipoTelefone">Identification Code of the Telephone Type.</param>
        /// <param name="Ddd">Phone DDD.</param>
        /// <param name="Telefone">Phone Number.</param>
        /// <param name="Ramal">Phone Branch.</param>

        public TelefoneAdicionalUpdate(long? Id = null, long? IdTipoTelefone = null, string Ddd = null, string Telefone = null, string Ramal = null)
        {
            this.Id = Id;
            this.IdTipoTelefone = IdTipoTelefone;
            this.Ddd = Ddd;
            this.Telefone = Telefone;
            this.Ramal = Ramal;
            
        }
        
    
        /// <summary>
        /// Identification Code of the Telephone
        /// </summary>
        /// <value>Identification Code of the Telephone</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Identification Code of the Telephone Type
        /// </summary>
        /// <value>Identification Code of the Telephone Type</value>
        [DataMember(Name="idTipoTelefone", EmitDefaultValue=false)]
        public long? IdTipoTelefone { get; set; }
    
        /// <summary>
        /// Phone DDD
        /// </summary>
        /// <value>Phone DDD</value>
        [DataMember(Name="ddd", EmitDefaultValue=false)]
        public string Ddd { get; set; }
    
        /// <summary>
        /// Phone Number
        /// </summary>
        /// <value>Phone Number</value>
        [DataMember(Name="telefone", EmitDefaultValue=false)]
        public string Telefone { get; set; }
    
        /// <summary>
        /// Phone Branch
        /// </summary>
        /// <value>Phone Branch</value>
        [DataMember(Name="ramal", EmitDefaultValue=false)]
        public string Ramal { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TelefoneAdicionalUpdate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdTipoTelefone: ").Append(IdTipoTelefone).Append("\n");
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
            return this.Equals(obj as TelefoneAdicionalUpdate);
        }

        /// <summary>
        /// Returns true if TelefoneAdicionalUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of TelefoneAdicionalUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TelefoneAdicionalUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdTipoTelefone == other.IdTipoTelefone ||
                    this.IdTipoTelefone != null &&
                    this.IdTipoTelefone.Equals(other.IdTipoTelefone)
                ) && 
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdTipoTelefone != null)
                    hash = hash * 59 + this.IdTipoTelefone.GetHashCode();
                
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
