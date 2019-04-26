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
    /// Objeto para realizar a transfer\u00EAncia entre portadores
    /// </summary>
    [DataContract]
    public partial class TransferenciaPortadoresPersist :  IEquatable<TransferenciaPortadoresPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferenciaPortadoresPersist" /> class.
        /// Initializes a new instance of the <see cref="TransferenciaPortadoresPersist" />class.
        /// </summary>
        /// <param name="IdPessoaOrigem">Identificador da pessoa de origem (required).</param>
        /// <param name="IdPessoaDestino">Identificador da pessoa de destino (required).</param>
        /// <param name="Valor">Valor da transfer\u00EAncia (required).</param>

        public TransferenciaPortadoresPersist(long? IdPessoaOrigem = null, long? IdPessoaDestino = null, double? Valor = null)
        {
            // to ensure "IdPessoaOrigem" is required (not null)
            if (IdPessoaOrigem == null)
            {
                throw new InvalidDataException("IdPessoaOrigem is a required property for TransferenciaPortadoresPersist and cannot be null");
            }
            else
            {
                this.IdPessoaOrigem = IdPessoaOrigem;
            }
            // to ensure "IdPessoaDestino" is required (not null)
            if (IdPessoaDestino == null)
            {
                throw new InvalidDataException("IdPessoaDestino is a required property for TransferenciaPortadoresPersist and cannot be null");
            }
            else
            {
                this.IdPessoaDestino = IdPessoaDestino;
            }
            // to ensure "Valor" is required (not null)
            if (Valor == null)
            {
                throw new InvalidDataException("Valor is a required property for TransferenciaPortadoresPersist and cannot be null");
            }
            else
            {
                this.Valor = Valor;
            }
            
        }
        
    
        /// <summary>
        /// Identificador da pessoa de origem
        /// </summary>
        /// <value>Identificador da pessoa de origem</value>
        [DataMember(Name="idPessoaOrigem", EmitDefaultValue=false)]
        public long? IdPessoaOrigem { get; set; }
    
        /// <summary>
        /// Identificador da pessoa de destino
        /// </summary>
        /// <value>Identificador da pessoa de destino</value>
        [DataMember(Name="idPessoaDestino", EmitDefaultValue=false)]
        public long? IdPessoaDestino { get; set; }
    
        /// <summary>
        /// Valor da transfer\u00EAncia
        /// </summary>
        /// <value>Valor da transfer\u00EAncia</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferenciaPortadoresPersist {\n");
            sb.Append("  IdPessoaOrigem: ").Append(IdPessoaOrigem).Append("\n");
            sb.Append("  IdPessoaDestino: ").Append(IdPessoaDestino).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            
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
            return this.Equals(obj as TransferenciaPortadoresPersist);
        }

        /// <summary>
        /// Returns true if TransferenciaPortadoresPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of TransferenciaPortadoresPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferenciaPortadoresPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdPessoaOrigem == other.IdPessoaOrigem ||
                    this.IdPessoaOrigem != null &&
                    this.IdPessoaOrigem.Equals(other.IdPessoaOrigem)
                ) && 
                (
                    this.IdPessoaDestino == other.IdPessoaDestino ||
                    this.IdPessoaDestino != null &&
                    this.IdPessoaDestino.Equals(other.IdPessoaDestino)
                ) && 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
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
                
                if (this.IdPessoaOrigem != null)
                    hash = hash * 59 + this.IdPessoaOrigem.GetHashCode();
                
                if (this.IdPessoaDestino != null)
                    hash = hash * 59 + this.IdPessoaDestino.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                return hash;
            }
        }

    }
}
