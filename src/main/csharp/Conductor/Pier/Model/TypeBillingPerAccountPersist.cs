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
    /// TypeBillingPerAccountPersist
    /// </summary>
    [DataContract]
    public partial class TypeBillingPerAccountPersist :  IEquatable<TypeBillingPerAccountPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TypeBillingPerAccountPersist" /> class.
        /// Initializes a new instance of the <see cref="TypeBillingPerAccountPersist" />class.
        /// </summary>
        /// <param name="IdConta">Identification Code of the related account (required).</param>
        /// <param name="IdTipoFaturamento">Identification Code of the billing type related (required).</param>

        public TypeBillingPerAccountPersist(long? IdConta = null, long? IdTipoFaturamento = null)
        {
            // to ensure "IdConta" is required (not null)
            if (IdConta == null)
            {
                throw new InvalidDataException("IdConta is a required property for TypeBillingPerAccountPersist and cannot be null");
            }
            else
            {
                this.IdConta = IdConta;
            }
            // to ensure "IdTipoFaturamento" is required (not null)
            if (IdTipoFaturamento == null)
            {
                throw new InvalidDataException("IdTipoFaturamento is a required property for TypeBillingPerAccountPersist and cannot be null");
            }
            else
            {
                this.IdTipoFaturamento = IdTipoFaturamento;
            }
            
        }
        
    
        /// <summary>
        /// Identification Code of the related account
        /// </summary>
        /// <value>Identification Code of the related account</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identification Code of the billing type related
        /// </summary>
        /// <value>Identification Code of the billing type related</value>
        [DataMember(Name="idTipoFaturamento", EmitDefaultValue=false)]
        public long? IdTipoFaturamento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TypeBillingPerAccountPersist {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdTipoFaturamento: ").Append(IdTipoFaturamento).Append("\n");
            
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
            return this.Equals(obj as TypeBillingPerAccountPersist);
        }

        /// <summary>
        /// Returns true if TypeBillingPerAccountPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of TypeBillingPerAccountPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TypeBillingPerAccountPersist other)
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
                    this.IdTipoFaturamento == other.IdTipoFaturamento ||
                    this.IdTipoFaturamento != null &&
                    this.IdTipoFaturamento.Equals(other.IdTipoFaturamento)
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
                
                if (this.IdTipoFaturamento != null)
                    hash = hash * 59 + this.IdTipoFaturamento.GetHashCode();
                
                return hash;
            }
        }

    }
}
