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
    /// Objeto para persist\u00EAncia de v\u00EDnculos entre contas
    /// </summary>
    [DataContract]
    public partial class VinculoContaPersist :  IEquatable<VinculoContaPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VinculoContaPersist" /> class.
        /// Initializes a new instance of the <see cref="VinculoContaPersist" />class.
        /// </summary>
        /// <param name="IdConta">Id da subconta.</param>
        /// <param name="IdTipoVinculo">Id do tipo de v\u00EDnculo entre as duas contas.</param>

        public VinculoContaPersist(long? IdConta = null, long? IdTipoVinculo = null)
        {
            this.IdConta = IdConta;
            this.IdTipoVinculo = IdTipoVinculo;
            
        }
        
    
        /// <summary>
        /// Id da subconta
        /// </summary>
        /// <value>Id da subconta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Id do tipo de v\u00EDnculo entre as duas contas
        /// </summary>
        /// <value>Id do tipo de v\u00EDnculo entre as duas contas</value>
        [DataMember(Name="idTipoVinculo", EmitDefaultValue=false)]
        public long? IdTipoVinculo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VinculoContaPersist {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdTipoVinculo: ").Append(IdTipoVinculo).Append("\n");
            
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
            return this.Equals(obj as VinculoContaPersist);
        }

        /// <summary>
        /// Returns true if VinculoContaPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of VinculoContaPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VinculoContaPersist other)
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
                    this.IdTipoVinculo == other.IdTipoVinculo ||
                    this.IdTipoVinculo != null &&
                    this.IdTipoVinculo.Equals(other.IdTipoVinculo)
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
                
                if (this.IdTipoVinculo != null)
                    hash = hash * 59 + this.IdTipoVinculo.GetHashCode();
                
                return hash;
            }
        }

    }
}
