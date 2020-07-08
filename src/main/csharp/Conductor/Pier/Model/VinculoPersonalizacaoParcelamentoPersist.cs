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
    /// Objeto de cria\u00E7\u00E3o de um v\u00EDnculo entre uma conta e um parcelamento personalizado
    /// </summary>
    [DataContract]
    public partial class VinculoPersonalizacaoParcelamentoPersist :  IEquatable<VinculoPersonalizacaoParcelamentoPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VinculoPersonalizacaoParcelamentoPersist" /> class.
        /// Initializes a new instance of the <see cref="VinculoPersonalizacaoParcelamentoPersist" />class.
        /// </summary>
        /// <param name="IdConta">C\u00F3digo de identifica\u00E7\u00E3o da conta que ser\u00E1 vinculada ao parcelamento personalizado.</param>
        /// <param name="IdPersonalizacaoParcelamento">C\u00F3digo de identifica\u00E7\u00E3o da personaliza\u00E7\u00E3o de parcelamento que ser\u00E1 vinculada \u00E0 conta.</param>

        public VinculoPersonalizacaoParcelamentoPersist(long? IdConta = null, long? IdPersonalizacaoParcelamento = null)
        {
            this.IdConta = IdConta;
            this.IdPersonalizacaoParcelamento = IdPersonalizacaoParcelamento;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da conta que ser\u00E1 vinculada ao parcelamento personalizado
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da conta que ser\u00E1 vinculada ao parcelamento personalizado</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da personaliza\u00E7\u00E3o de parcelamento que ser\u00E1 vinculada \u00E0 conta
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da personaliza\u00E7\u00E3o de parcelamento que ser\u00E1 vinculada \u00E0 conta</value>
        [DataMember(Name="idPersonalizacaoParcelamento", EmitDefaultValue=false)]
        public long? IdPersonalizacaoParcelamento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VinculoPersonalizacaoParcelamentoPersist {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdPersonalizacaoParcelamento: ").Append(IdPersonalizacaoParcelamento).Append("\n");
            
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
            return this.Equals(obj as VinculoPersonalizacaoParcelamentoPersist);
        }

        /// <summary>
        /// Returns true if VinculoPersonalizacaoParcelamentoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of VinculoPersonalizacaoParcelamentoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VinculoPersonalizacaoParcelamentoPersist other)
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
                    this.IdPersonalizacaoParcelamento == other.IdPersonalizacaoParcelamento ||
                    this.IdPersonalizacaoParcelamento != null &&
                    this.IdPersonalizacaoParcelamento.Equals(other.IdPersonalizacaoParcelamento)
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
                
                if (this.IdPersonalizacaoParcelamento != null)
                    hash = hash * 59 + this.IdPersonalizacaoParcelamento.GetHashCode();
                
                return hash;
            }
        }

    }
}
