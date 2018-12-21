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
    /// Object Response of the telephone
    /// </summary>
    [DataContract]
    public partial class TelefoneResponse :  IEquatable<TelefoneResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TelefoneResponse" /> class.
        /// Initializes a new instance of the <see cref="TelefoneResponse" />class.
        /// </summary>
        /// <param name="Id">Identification Code of the Telephone.</param>
        /// <param name="IdTipoTelefone">Identification Code of the Telephone Type.</param>
        /// <param name="IdPessoa">Identification Code of the Person which the telephone belongs.</param>
        /// <param name="Ddd">DDD code of the telephon.</param>
        /// <param name="Telefone">Telephone Number.</param>
        /// <param name="Ramal">Extension Number.</param>
        /// <param name="Status">Show the telephone status, where: &#39;0&#39;: Inactive and &#39;1&#39;: Active.</param>

        public TelefoneResponse(long? Id = null, long? IdTipoTelefone = null, long? IdPessoa = null, string Ddd = null, string Telefone = null, string Ramal = null, int? Status = null)
        {
            this.Id = Id;
            this.IdTipoTelefone = IdTipoTelefone;
            this.IdPessoa = IdPessoa;
            this.Ddd = Ddd;
            this.Telefone = Telefone;
            this.Ramal = Ramal;
            this.Status = Status;
            
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
        /// Identification Code of the Person which the telephone belongs
        /// </summary>
        /// <value>Identification Code of the Person which the telephone belongs</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// DDD code of the telephon
        /// </summary>
        /// <value>DDD code of the telephon</value>
        [DataMember(Name="ddd", EmitDefaultValue=false)]
        public string Ddd { get; set; }
    
        /// <summary>
        /// Telephone Number
        /// </summary>
        /// <value>Telephone Number</value>
        [DataMember(Name="telefone", EmitDefaultValue=false)]
        public string Telefone { get; set; }
    
        /// <summary>
        /// Extension Number
        /// </summary>
        /// <value>Extension Number</value>
        [DataMember(Name="ramal", EmitDefaultValue=false)]
        public string Ramal { get; set; }
    
        /// <summary>
        /// Show the telephone status, where: &#39;0&#39;: Inactive and &#39;1&#39;: Active
        /// </summary>
        /// <value>Show the telephone status, where: &#39;0&#39;: Inactive and &#39;1&#39;: Active</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TelefoneResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdTipoTelefone: ").Append(IdTipoTelefone).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  Ddd: ").Append(Ddd).Append("\n");
            sb.Append("  Telefone: ").Append(Telefone).Append("\n");
            sb.Append("  Ramal: ").Append(Ramal).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            
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
            return this.Equals(obj as TelefoneResponse);
        }

        /// <summary>
        /// Returns true if TelefoneResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TelefoneResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TelefoneResponse other)
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
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
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
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.Ddd != null)
                    hash = hash * 59 + this.Ddd.GetHashCode();
                
                if (this.Telefone != null)
                    hash = hash * 59 + this.Telefone.GetHashCode();
                
                if (this.Ramal != null)
                    hash = hash * 59 + this.Ramal.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
