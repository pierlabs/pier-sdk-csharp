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
    /// Telefone de escritorio para cobran\u00E7a
    /// </summary>
    [DataContract]
    public partial class TelefoneEscritorioCobrancaDTO :  IEquatable<TelefoneEscritorioCobrancaDTO>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TelefoneEscritorioCobrancaDTO" /> class.
        /// Initializes a new instance of the <see cref="TelefoneEscritorioCobrancaDTO" />class.
        /// </summary>
        /// <param name="Id">Telefone escrit\u00F3rio cobranca id.</param>
        /// <param name="Ddd">Telefone escrit\u00F3rio cobranca ddd (required).</param>
        /// <param name="Telefone">Telefone escrit\u00F3rio cobranca telefone (required).</param>
        /// <param name="Ramal">Telefone escrit\u00F3rio cobranca ramal.</param>

        public TelefoneEscritorioCobrancaDTO(long? Id = null, string Ddd = null, string Telefone = null, string Ramal = null)
        {
            // to ensure "Ddd" is required (not null)
            if (Ddd == null)
            {
                throw new InvalidDataException("Ddd is a required property for TelefoneEscritorioCobrancaDTO and cannot be null");
            }
            else
            {
                this.Ddd = Ddd;
            }
            // to ensure "Telefone" is required (not null)
            if (Telefone == null)
            {
                throw new InvalidDataException("Telefone is a required property for TelefoneEscritorioCobrancaDTO and cannot be null");
            }
            else
            {
                this.Telefone = Telefone;
            }
            this.Id = Id;
            this.Ramal = Ramal;
            
        }
        
    
        /// <summary>
        /// Telefone escrit\u00F3rio cobranca id
        /// </summary>
        /// <value>Telefone escrit\u00F3rio cobranca id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Telefone escrit\u00F3rio cobranca ddd
        /// </summary>
        /// <value>Telefone escrit\u00F3rio cobranca ddd</value>
        [DataMember(Name="ddd", EmitDefaultValue=false)]
        public string Ddd { get; set; }
    
        /// <summary>
        /// Telefone escrit\u00F3rio cobranca telefone
        /// </summary>
        /// <value>Telefone escrit\u00F3rio cobranca telefone</value>
        [DataMember(Name="telefone", EmitDefaultValue=false)]
        public string Telefone { get; set; }
    
        /// <summary>
        /// Telefone escrit\u00F3rio cobranca ramal
        /// </summary>
        /// <value>Telefone escrit\u00F3rio cobranca ramal</value>
        [DataMember(Name="ramal", EmitDefaultValue=false)]
        public string Ramal { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TelefoneEscritorioCobrancaDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as TelefoneEscritorioCobrancaDTO);
        }

        /// <summary>
        /// Returns true if TelefoneEscritorioCobrancaDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of TelefoneEscritorioCobrancaDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TelefoneEscritorioCobrancaDTO other)
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
