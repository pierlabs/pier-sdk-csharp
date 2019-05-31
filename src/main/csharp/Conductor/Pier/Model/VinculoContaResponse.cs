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
    /// Descri\u00E7\u00E3o do objeto de resposta do recurso para v\u00EDnculo entre contas
    /// </summary>
    [DataContract]
    public partial class VinculoContaResponse :  IEquatable<VinculoContaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VinculoContaResponse" /> class.
        /// Initializes a new instance of the <see cref="VinculoContaResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo identificador do v\u00EDnculo de contas (id).</param>
        /// <param name="IdConta">Id da subconta.</param>
        /// <param name="IdContaPai">Id da conta pai.</param>
        /// <param name="IdTipoVinculo">Id do tipo de v\u00EDnculo entre as duas contas.</param>

        public VinculoContaResponse(long? Id = null, long? IdConta = null, long? IdContaPai = null, long? IdTipoVinculo = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.IdContaPai = IdContaPai;
            this.IdTipoVinculo = IdTipoVinculo;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo identificador do v\u00EDnculo de contas (id)
        /// </summary>
        /// <value>C\u00F3digo identificador do v\u00EDnculo de contas (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Id da subconta
        /// </summary>
        /// <value>Id da subconta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Id da conta pai
        /// </summary>
        /// <value>Id da conta pai</value>
        [DataMember(Name="idContaPai", EmitDefaultValue=false)]
        public long? IdContaPai { get; set; }
    
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
            sb.Append("class VinculoContaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdContaPai: ").Append(IdContaPai).Append("\n");
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
            return this.Equals(obj as VinculoContaResponse);
        }

        /// <summary>
        /// Returns true if VinculoContaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of VinculoContaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VinculoContaResponse other)
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
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdContaPai == other.IdContaPai ||
                    this.IdContaPai != null &&
                    this.IdContaPai.Equals(other.IdContaPai)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdContaPai != null)
                    hash = hash * 59 + this.IdContaPai.GetHashCode();
                
                if (this.IdTipoVinculo != null)
                    hash = hash * 59 + this.IdTipoVinculo.GetHashCode();
                
                return hash;
            }
        }

    }
}
