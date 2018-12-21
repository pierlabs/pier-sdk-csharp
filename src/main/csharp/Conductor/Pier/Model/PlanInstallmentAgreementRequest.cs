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
    /// Object of request for simulation of an agreement
    /// </summary>
    [DataContract]
    public partial class PlanInstallmentAgreementRequest :  IEquatable<PlanInstallmentAgreementRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanInstallmentAgreementRequest" /> class.
        /// Initializes a new instance of the <see cref="PlanInstallmentAgreementRequest" />class.
        /// </summary>
        /// <param name="SaldoDevedor">Debtor balance (required).</param>
        /// <param name="NumeroParcelas">Number of parcels requested for the agreement (required).</param>
        /// <param name="DiasAtraso">Days of delay of debt (required).</param>

        public PlanInstallmentAgreementRequest(double? SaldoDevedor = null, int? NumeroParcelas = null, int? DiasAtraso = null)
        {
            // to ensure "SaldoDevedor" is required (not null)
            if (SaldoDevedor == null)
            {
                throw new InvalidDataException("SaldoDevedor is a required property for PlanInstallmentAgreementRequest and cannot be null");
            }
            else
            {
                this.SaldoDevedor = SaldoDevedor;
            }
            // to ensure "NumeroParcelas" is required (not null)
            if (NumeroParcelas == null)
            {
                throw new InvalidDataException("NumeroParcelas is a required property for PlanInstallmentAgreementRequest and cannot be null");
            }
            else
            {
                this.NumeroParcelas = NumeroParcelas;
            }
            // to ensure "DiasAtraso" is required (not null)
            if (DiasAtraso == null)
            {
                throw new InvalidDataException("DiasAtraso is a required property for PlanInstallmentAgreementRequest and cannot be null");
            }
            else
            {
                this.DiasAtraso = DiasAtraso;
            }
            
        }
        
    
        /// <summary>
        /// Debtor balance
        /// </summary>
        /// <value>Debtor balance</value>
        [DataMember(Name="saldoDevedor", EmitDefaultValue=false)]
        public double? SaldoDevedor { get; set; }
    
        /// <summary>
        /// Number of parcels requested for the agreement
        /// </summary>
        /// <value>Number of parcels requested for the agreement</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public int? NumeroParcelas { get; set; }
    
        /// <summary>
        /// Days of delay of debt
        /// </summary>
        /// <value>Days of delay of debt</value>
        [DataMember(Name="diasAtraso", EmitDefaultValue=false)]
        public int? DiasAtraso { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlanInstallmentAgreementRequest {\n");
            sb.Append("  SaldoDevedor: ").Append(SaldoDevedor).Append("\n");
            sb.Append("  NumeroParcelas: ").Append(NumeroParcelas).Append("\n");
            sb.Append("  DiasAtraso: ").Append(DiasAtraso).Append("\n");
            
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
            return this.Equals(obj as PlanInstallmentAgreementRequest);
        }

        /// <summary>
        /// Returns true if PlanInstallmentAgreementRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PlanInstallmentAgreementRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanInstallmentAgreementRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SaldoDevedor == other.SaldoDevedor ||
                    this.SaldoDevedor != null &&
                    this.SaldoDevedor.Equals(other.SaldoDevedor)
                ) && 
                (
                    this.NumeroParcelas == other.NumeroParcelas ||
                    this.NumeroParcelas != null &&
                    this.NumeroParcelas.Equals(other.NumeroParcelas)
                ) && 
                (
                    this.DiasAtraso == other.DiasAtraso ||
                    this.DiasAtraso != null &&
                    this.DiasAtraso.Equals(other.DiasAtraso)
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
                
                if (this.SaldoDevedor != null)
                    hash = hash * 59 + this.SaldoDevedor.GetHashCode();
                
                if (this.NumeroParcelas != null)
                    hash = hash * 59 + this.NumeroParcelas.GetHashCode();
                
                if (this.DiasAtraso != null)
                    hash = hash * 59 + this.DiasAtraso.GetHashCode();
                
                return hash;
            }
        }

    }
}
