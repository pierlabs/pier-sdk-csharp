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
    /// Object for persistence of cards MultiApp
    /// </summary>
    [DataContract]
    public partial class CardMultiAppPersist :  IEquatable<CardMultiAppPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CardMultiAppPersist" /> class.
        /// Initializes a new instance of the <see cref="CardMultiAppPersist" />class.
        /// </summary>
        /// <param name="IdConta">Code of identification of the account (required).</param>
        /// <param name="IdPessoa">Identification code of the Person who will be the holder of the Card (required).</param>

        public CardMultiAppPersist(long? IdConta = null, long? IdPessoa = null)
        {
            // to ensure "IdConta" is required (not null)
            if (IdConta == null)
            {
                throw new InvalidDataException("IdConta is a required property for CardMultiAppPersist and cannot be null");
            }
            else
            {
                this.IdConta = IdConta;
            }
            // to ensure "IdPessoa" is required (not null)
            if (IdPessoa == null)
            {
                throw new InvalidDataException("IdPessoa is a required property for CardMultiAppPersist and cannot be null");
            }
            else
            {
                this.IdPessoa = IdPessoa;
            }
            
        }
        
    
        /// <summary>
        /// Code of identification of the account
        /// </summary>
        /// <value>Code of identification of the account</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identification code of the Person who will be the holder of the Card
        /// </summary>
        /// <value>Identification code of the Person who will be the holder of the Card</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardMultiAppPersist {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            
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
            return this.Equals(obj as CardMultiAppPersist);
        }

        /// <summary>
        /// Returns true if CardMultiAppPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of CardMultiAppPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardMultiAppPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                return hash;
            }
        }

    }
}
