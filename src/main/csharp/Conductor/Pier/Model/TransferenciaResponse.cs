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
    /// Objeto transferencia
    /// </summary>
    [DataContract]
    public partial class TransferenciaResponse :  IEquatable<TransferenciaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferenciaResponse" /> class.
        /// Initializes a new instance of the <see cref="TransferenciaResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id)..</param>
        /// <param name="DataTransferencia">Data estabelecida para ocorrer a transfer\u00C3\u00AAncia..</param>
        /// <param name="IdContaOrigem">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 debitado para a transfer\u00C3\u00AAncia. (id)..</param>
        /// <param name="IdContaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 creditado para a transfer\u00C3\u00AAncia. (id)..</param>
        /// <param name="ValorTransferencia">Valor estabelecido para ser transferido..</param>

        public TransferenciaResponse(long? Id = null, string DataTransferencia = null, long? IdContaOrigem = null, long? IdContaDestino = null, double? ValorTransferencia = null)
        {
            this.Id = Id;
            this.DataTransferencia = DataTransferencia;
            this.IdContaOrigem = IdContaOrigem;
            this.IdContaDestino = IdContaDestino;
            this.ValorTransferencia = ValorTransferencia;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Data estabelecida para ocorrer a transfer\u00C3\u00AAncia.
        /// </summary>
        /// <value>Data estabelecida para ocorrer a transfer\u00C3\u00AAncia.</value>
        [DataMember(Name="dataTransferencia", EmitDefaultValue=false)]
        public string DataTransferencia { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 debitado para a transfer\u00C3\u00AAncia. (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 debitado para a transfer\u00C3\u00AAncia. (id).</value>
        [DataMember(Name="idContaOrigem", EmitDefaultValue=false)]
        public long? IdContaOrigem { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 creditado para a transfer\u00C3\u00AAncia. (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta em que o valor ser\u00C3\u00A1 creditado para a transfer\u00C3\u00AAncia. (id).</value>
        [DataMember(Name="idContaDestino", EmitDefaultValue=false)]
        public long? IdContaDestino { get; set; }
    
        /// <summary>
        /// Valor estabelecido para ser transferido.
        /// </summary>
        /// <value>Valor estabelecido para ser transferido.</value>
        [DataMember(Name="valorTransferencia", EmitDefaultValue=false)]
        public double? ValorTransferencia { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferenciaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DataTransferencia: ").Append(DataTransferencia).Append("\n");
            sb.Append("  IdContaOrigem: ").Append(IdContaOrigem).Append("\n");
            sb.Append("  IdContaDestino: ").Append(IdContaDestino).Append("\n");
            sb.Append("  ValorTransferencia: ").Append(ValorTransferencia).Append("\n");
            
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
            return this.Equals(obj as TransferenciaResponse);
        }

        /// <summary>
        /// Returns true if TransferenciaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TransferenciaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferenciaResponse other)
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
                    this.DataTransferencia == other.DataTransferencia ||
                    this.DataTransferencia != null &&
                    this.DataTransferencia.Equals(other.DataTransferencia)
                ) && 
                (
                    this.IdContaOrigem == other.IdContaOrigem ||
                    this.IdContaOrigem != null &&
                    this.IdContaOrigem.Equals(other.IdContaOrigem)
                ) && 
                (
                    this.IdContaDestino == other.IdContaDestino ||
                    this.IdContaDestino != null &&
                    this.IdContaDestino.Equals(other.IdContaDestino)
                ) && 
                (
                    this.ValorTransferencia == other.ValorTransferencia ||
                    this.ValorTransferencia != null &&
                    this.ValorTransferencia.Equals(other.ValorTransferencia)
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
                
                if (this.DataTransferencia != null)
                    hash = hash * 59 + this.DataTransferencia.GetHashCode();
                
                if (this.IdContaOrigem != null)
                    hash = hash * 59 + this.IdContaOrigem.GetHashCode();
                
                if (this.IdContaDestino != null)
                    hash = hash * 59 + this.IdContaDestino.GetHashCode();
                
                if (this.ValorTransferencia != null)
                    hash = hash * 59 + this.ValorTransferencia.GetHashCode();
                
                return hash;
            }
        }

    }
}
