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
    /// {{{cartao_multi_app_persist_description}}}
    /// </summary>
    [DataContract]
    public partial class CartaoMultiAppPersistValue :  IEquatable<CartaoMultiAppPersistValue>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoMultiAppPersistValue" /> class.
        /// Initializes a new instance of the <see cref="CartaoMultiAppPersistValue" />class.
        /// </summary>
        /// <param name="IdConta">{{{cartao_multi_app_persist_id_conta_value}}} (required).</param>
        /// <param name="IdPessoa">{{{cartao_multi_app_persist_id_pessoa_value}}} (required).</param>

        public CartaoMultiAppPersistValue(long? IdConta = null, long? IdPessoa = null)
        {
            // to ensure "IdConta" is required (not null)
            if (IdConta == null)
            {
                throw new InvalidDataException("IdConta is a required property for CartaoMultiAppPersistValue and cannot be null");
            }
            else
            {
                this.IdConta = IdConta;
            }
            // to ensure "IdPessoa" is required (not null)
            if (IdPessoa == null)
            {
                throw new InvalidDataException("IdPessoa is a required property for CartaoMultiAppPersistValue and cannot be null");
            }
            else
            {
                this.IdPessoa = IdPessoa;
            }
            
        }
        
    
        /// <summary>
        /// {{{cartao_multi_app_persist_id_conta_value}}}
        /// </summary>
        /// <value>{{{cartao_multi_app_persist_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{cartao_multi_app_persist_id_pessoa_value}}}
        /// </summary>
        /// <value>{{{cartao_multi_app_persist_id_pessoa_value}}}</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoMultiAppPersistValue {\n");
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
            return this.Equals(obj as CartaoMultiAppPersistValue);
        }

        /// <summary>
        /// Returns true if CartaoMultiAppPersistValue instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoMultiAppPersistValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoMultiAppPersistValue other)
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
