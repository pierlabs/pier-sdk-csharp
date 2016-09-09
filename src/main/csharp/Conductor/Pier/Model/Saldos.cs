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
    /// Saldos
    /// </summary>
    [DataContract]
    public partial class Saldos :  IEquatable<Saldos>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Saldos" /> class.
        /// Initializes a new instance of the <see cref="Saldos" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Limite Disponibilidade (id). (required).</param>
        /// <param name="SaldoDisponivelCompra">SaldoDisponivelCompra (required).</param>
        /// <param name="SaldoDisponivelCompraInternacional">SaldoDisponivelCompraInternacional (required).</param>
        /// <param name="SaldoDisponivelExterno">SaldoDisponivelExterno (required).</param>
        /// <param name="SaldoDisponivelExtra">SaldoDisponivelExtra (required).</param>
        /// <param name="SaldoDisponivelGlobal">Campo que  (required).</param>
        /// <param name="SaldoDisponivelMensal">SaldoDisponivelMensal (required).</param>
        /// <param name="SaldoDisponivelParcelado">SaldoDisponivelParcelado (required).</param>
        /// <param name="SaldoDisponivelParcelas">SaldoDisponivelParcelas (required).</param>
        /// <param name="SaldoDisponivelSaque">SaldoDisponivelSaque (required).</param>
        /// <param name="SaldoDisponivelSaqueInternacional">SaldoDisponivelSaqueInternacional (required).</param>
        /// <param name="SaldoPontosFidelidade">SaldoPontosFidelidade (required).</param>

        public Saldos(long? Id = null, double? SaldoDisponivelCompra = null, double? SaldoDisponivelCompraInternacional = null, double? SaldoDisponivelExterno = null, double? SaldoDisponivelExtra = null, double? SaldoDisponivelGlobal = null, double? SaldoDisponivelMensal = null, double? SaldoDisponivelParcelado = null, double? SaldoDisponivelParcelas = null, double? SaldoDisponivelSaque = null, double? SaldoDisponivelSaqueInternacional = null, double? SaldoPontosFidelidade = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for Saldos and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "SaldoDisponivelCompra" is required (not null)
            if (SaldoDisponivelCompra == null)
            {
                throw new InvalidDataException("SaldoDisponivelCompra is a required property for Saldos and cannot be null");
            }
            else
            {
                this.SaldoDisponivelCompra = SaldoDisponivelCompra;
            }
            // to ensure "SaldoDisponivelCompraInternacional" is required (not null)
            if (SaldoDisponivelCompraInternacional == null)
            {
                throw new InvalidDataException("SaldoDisponivelCompraInternacional is a required property for Saldos and cannot be null");
            }
            else
            {
                this.SaldoDisponivelCompraInternacional = SaldoDisponivelCompraInternacional;
            }
            // to ensure "SaldoDisponivelExterno" is required (not null)
            if (SaldoDisponivelExterno == null)
            {
                throw new InvalidDataException("SaldoDisponivelExterno is a required property for Saldos and cannot be null");
            }
            else
            {
                this.SaldoDisponivelExterno = SaldoDisponivelExterno;
            }
            // to ensure "SaldoDisponivelExtra" is required (not null)
            if (SaldoDisponivelExtra == null)
            {
                throw new InvalidDataException("SaldoDisponivelExtra is a required property for Saldos and cannot be null");
            }
            else
            {
                this.SaldoDisponivelExtra = SaldoDisponivelExtra;
            }
            // to ensure "SaldoDisponivelGlobal" is required (not null)
            if (SaldoDisponivelGlobal == null)
            {
                throw new InvalidDataException("SaldoDisponivelGlobal is a required property for Saldos and cannot be null");
            }
            else
            {
                this.SaldoDisponivelGlobal = SaldoDisponivelGlobal;
            }
            // to ensure "SaldoDisponivelMensal" is required (not null)
            if (SaldoDisponivelMensal == null)
            {
                throw new InvalidDataException("SaldoDisponivelMensal is a required property for Saldos and cannot be null");
            }
            else
            {
                this.SaldoDisponivelMensal = SaldoDisponivelMensal;
            }
            // to ensure "SaldoDisponivelParcelado" is required (not null)
            if (SaldoDisponivelParcelado == null)
            {
                throw new InvalidDataException("SaldoDisponivelParcelado is a required property for Saldos and cannot be null");
            }
            else
            {
                this.SaldoDisponivelParcelado = SaldoDisponivelParcelado;
            }
            // to ensure "SaldoDisponivelParcelas" is required (not null)
            if (SaldoDisponivelParcelas == null)
            {
                throw new InvalidDataException("SaldoDisponivelParcelas is a required property for Saldos and cannot be null");
            }
            else
            {
                this.SaldoDisponivelParcelas = SaldoDisponivelParcelas;
            }
            // to ensure "SaldoDisponivelSaque" is required (not null)
            if (SaldoDisponivelSaque == null)
            {
                throw new InvalidDataException("SaldoDisponivelSaque is a required property for Saldos and cannot be null");
            }
            else
            {
                this.SaldoDisponivelSaque = SaldoDisponivelSaque;
            }
            // to ensure "SaldoDisponivelSaqueInternacional" is required (not null)
            if (SaldoDisponivelSaqueInternacional == null)
            {
                throw new InvalidDataException("SaldoDisponivelSaqueInternacional is a required property for Saldos and cannot be null");
            }
            else
            {
                this.SaldoDisponivelSaqueInternacional = SaldoDisponivelSaqueInternacional;
            }
            // to ensure "SaldoPontosFidelidade" is required (not null)
            if (SaldoPontosFidelidade == null)
            {
                throw new InvalidDataException("SaldoPontosFidelidade is a required property for Saldos and cannot be null");
            }
            else
            {
                this.SaldoPontosFidelidade = SaldoPontosFidelidade;
            }
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Limite Disponibilidade (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Limite Disponibilidade (id).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Gets or Sets SaldoDisponivelCompra
        /// </summary>
        [DataMember(Name="saldoDisponivelCompra", EmitDefaultValue=false)]
        public double? SaldoDisponivelCompra { get; set; }
    
        /// <summary>
        /// Gets or Sets SaldoDisponivelCompraInternacional
        /// </summary>
        [DataMember(Name="saldoDisponivelCompraInternacional", EmitDefaultValue=false)]
        public double? SaldoDisponivelCompraInternacional { get; set; }
    
        /// <summary>
        /// Gets or Sets SaldoDisponivelExterno
        /// </summary>
        [DataMember(Name="saldoDisponivelExterno", EmitDefaultValue=false)]
        public double? SaldoDisponivelExterno { get; set; }
    
        /// <summary>
        /// Gets or Sets SaldoDisponivelExtra
        /// </summary>
        [DataMember(Name="saldoDisponivelExtra", EmitDefaultValue=false)]
        public double? SaldoDisponivelExtra { get; set; }
    
        /// <summary>
        /// Campo que 
        /// </summary>
        /// <value>Campo que </value>
        [DataMember(Name="saldoDisponivelGlobal", EmitDefaultValue=false)]
        public double? SaldoDisponivelGlobal { get; set; }
    
        /// <summary>
        /// Gets or Sets SaldoDisponivelMensal
        /// </summary>
        [DataMember(Name="saldoDisponivelMensal", EmitDefaultValue=false)]
        public double? SaldoDisponivelMensal { get; set; }
    
        /// <summary>
        /// Gets or Sets SaldoDisponivelParcelado
        /// </summary>
        [DataMember(Name="saldoDisponivelParcelado", EmitDefaultValue=false)]
        public double? SaldoDisponivelParcelado { get; set; }
    
        /// <summary>
        /// Gets or Sets SaldoDisponivelParcelas
        /// </summary>
        [DataMember(Name="saldoDisponivelParcelas", EmitDefaultValue=false)]
        public double? SaldoDisponivelParcelas { get; set; }
    
        /// <summary>
        /// Gets or Sets SaldoDisponivelSaque
        /// </summary>
        [DataMember(Name="saldoDisponivelSaque", EmitDefaultValue=false)]
        public double? SaldoDisponivelSaque { get; set; }
    
        /// <summary>
        /// Gets or Sets SaldoDisponivelSaqueInternacional
        /// </summary>
        [DataMember(Name="saldoDisponivelSaqueInternacional", EmitDefaultValue=false)]
        public double? SaldoDisponivelSaqueInternacional { get; set; }
    
        /// <summary>
        /// Gets or Sets SaldoPontosFidelidade
        /// </summary>
        [DataMember(Name="saldoPontosFidelidade", EmitDefaultValue=false)]
        public double? SaldoPontosFidelidade { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Saldos {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SaldoDisponivelCompra: ").Append(SaldoDisponivelCompra).Append("\n");
            sb.Append("  SaldoDisponivelCompraInternacional: ").Append(SaldoDisponivelCompraInternacional).Append("\n");
            sb.Append("  SaldoDisponivelExterno: ").Append(SaldoDisponivelExterno).Append("\n");
            sb.Append("  SaldoDisponivelExtra: ").Append(SaldoDisponivelExtra).Append("\n");
            sb.Append("  SaldoDisponivelGlobal: ").Append(SaldoDisponivelGlobal).Append("\n");
            sb.Append("  SaldoDisponivelMensal: ").Append(SaldoDisponivelMensal).Append("\n");
            sb.Append("  SaldoDisponivelParcelado: ").Append(SaldoDisponivelParcelado).Append("\n");
            sb.Append("  SaldoDisponivelParcelas: ").Append(SaldoDisponivelParcelas).Append("\n");
            sb.Append("  SaldoDisponivelSaque: ").Append(SaldoDisponivelSaque).Append("\n");
            sb.Append("  SaldoDisponivelSaqueInternacional: ").Append(SaldoDisponivelSaqueInternacional).Append("\n");
            sb.Append("  SaldoPontosFidelidade: ").Append(SaldoPontosFidelidade).Append("\n");
            
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
            return this.Equals(obj as Saldos);
        }

        /// <summary>
        /// Returns true if Saldos instances are equal
        /// </summary>
        /// <param name="other">Instance of Saldos to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Saldos other)
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
                    this.SaldoDisponivelCompra == other.SaldoDisponivelCompra ||
                    this.SaldoDisponivelCompra != null &&
                    this.SaldoDisponivelCompra.Equals(other.SaldoDisponivelCompra)
                ) && 
                (
                    this.SaldoDisponivelCompraInternacional == other.SaldoDisponivelCompraInternacional ||
                    this.SaldoDisponivelCompraInternacional != null &&
                    this.SaldoDisponivelCompraInternacional.Equals(other.SaldoDisponivelCompraInternacional)
                ) && 
                (
                    this.SaldoDisponivelExterno == other.SaldoDisponivelExterno ||
                    this.SaldoDisponivelExterno != null &&
                    this.SaldoDisponivelExterno.Equals(other.SaldoDisponivelExterno)
                ) && 
                (
                    this.SaldoDisponivelExtra == other.SaldoDisponivelExtra ||
                    this.SaldoDisponivelExtra != null &&
                    this.SaldoDisponivelExtra.Equals(other.SaldoDisponivelExtra)
                ) && 
                (
                    this.SaldoDisponivelGlobal == other.SaldoDisponivelGlobal ||
                    this.SaldoDisponivelGlobal != null &&
                    this.SaldoDisponivelGlobal.Equals(other.SaldoDisponivelGlobal)
                ) && 
                (
                    this.SaldoDisponivelMensal == other.SaldoDisponivelMensal ||
                    this.SaldoDisponivelMensal != null &&
                    this.SaldoDisponivelMensal.Equals(other.SaldoDisponivelMensal)
                ) && 
                (
                    this.SaldoDisponivelParcelado == other.SaldoDisponivelParcelado ||
                    this.SaldoDisponivelParcelado != null &&
                    this.SaldoDisponivelParcelado.Equals(other.SaldoDisponivelParcelado)
                ) && 
                (
                    this.SaldoDisponivelParcelas == other.SaldoDisponivelParcelas ||
                    this.SaldoDisponivelParcelas != null &&
                    this.SaldoDisponivelParcelas.Equals(other.SaldoDisponivelParcelas)
                ) && 
                (
                    this.SaldoDisponivelSaque == other.SaldoDisponivelSaque ||
                    this.SaldoDisponivelSaque != null &&
                    this.SaldoDisponivelSaque.Equals(other.SaldoDisponivelSaque)
                ) && 
                (
                    this.SaldoDisponivelSaqueInternacional == other.SaldoDisponivelSaqueInternacional ||
                    this.SaldoDisponivelSaqueInternacional != null &&
                    this.SaldoDisponivelSaqueInternacional.Equals(other.SaldoDisponivelSaqueInternacional)
                ) && 
                (
                    this.SaldoPontosFidelidade == other.SaldoPontosFidelidade ||
                    this.SaldoPontosFidelidade != null &&
                    this.SaldoPontosFidelidade.Equals(other.SaldoPontosFidelidade)
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
                
                if (this.SaldoDisponivelCompra != null)
                    hash = hash * 59 + this.SaldoDisponivelCompra.GetHashCode();
                
                if (this.SaldoDisponivelCompraInternacional != null)
                    hash = hash * 59 + this.SaldoDisponivelCompraInternacional.GetHashCode();
                
                if (this.SaldoDisponivelExterno != null)
                    hash = hash * 59 + this.SaldoDisponivelExterno.GetHashCode();
                
                if (this.SaldoDisponivelExtra != null)
                    hash = hash * 59 + this.SaldoDisponivelExtra.GetHashCode();
                
                if (this.SaldoDisponivelGlobal != null)
                    hash = hash * 59 + this.SaldoDisponivelGlobal.GetHashCode();
                
                if (this.SaldoDisponivelMensal != null)
                    hash = hash * 59 + this.SaldoDisponivelMensal.GetHashCode();
                
                if (this.SaldoDisponivelParcelado != null)
                    hash = hash * 59 + this.SaldoDisponivelParcelado.GetHashCode();
                
                if (this.SaldoDisponivelParcelas != null)
                    hash = hash * 59 + this.SaldoDisponivelParcelas.GetHashCode();
                
                if (this.SaldoDisponivelSaque != null)
                    hash = hash * 59 + this.SaldoDisponivelSaque.GetHashCode();
                
                if (this.SaldoDisponivelSaqueInternacional != null)
                    hash = hash * 59 + this.SaldoDisponivelSaqueInternacional.GetHashCode();
                
                if (this.SaldoPontosFidelidade != null)
                    hash = hash * 59 + this.SaldoPontosFidelidade.GetHashCode();
                
                return hash;
            }
        }

    }
}
