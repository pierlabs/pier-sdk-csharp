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
    /// {{{plano_parcelamento_acordo_request_description}}}
    /// </summary>
    [DataContract]
    public partial class PlanoParcelamentoAcordoRequestValue :  IEquatable<PlanoParcelamentoAcordoRequestValue>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanoParcelamentoAcordoRequestValue" /> class.
        /// Initializes a new instance of the <see cref="PlanoParcelamentoAcordoRequestValue" />class.
        /// </summary>
        /// <param name="SaldoDevedor">{{{plano_parcelamento_acordo_request_saldo_devedor_value}}} (required).</param>
        /// <param name="NumeroParcelas">{{{plano_parcelamento_acordo_request_numero_parcelas_value}}} (required).</param>
        /// <param name="DiasAtraso">{{{plano_parcelamento_acordo_request_dias_atraso_value}}} (required).</param>

        public PlanoParcelamentoAcordoRequestValue(double? SaldoDevedor = null, int? NumeroParcelas = null, int? DiasAtraso = null)
        {
            // to ensure "SaldoDevedor" is required (not null)
            if (SaldoDevedor == null)
            {
                throw new InvalidDataException("SaldoDevedor is a required property for PlanoParcelamentoAcordoRequestValue and cannot be null");
            }
            else
            {
                this.SaldoDevedor = SaldoDevedor;
            }
            // to ensure "NumeroParcelas" is required (not null)
            if (NumeroParcelas == null)
            {
                throw new InvalidDataException("NumeroParcelas is a required property for PlanoParcelamentoAcordoRequestValue and cannot be null");
            }
            else
            {
                this.NumeroParcelas = NumeroParcelas;
            }
            // to ensure "DiasAtraso" is required (not null)
            if (DiasAtraso == null)
            {
                throw new InvalidDataException("DiasAtraso is a required property for PlanoParcelamentoAcordoRequestValue and cannot be null");
            }
            else
            {
                this.DiasAtraso = DiasAtraso;
            }
            
        }
        
    
        /// <summary>
        /// {{{plano_parcelamento_acordo_request_saldo_devedor_value}}}
        /// </summary>
        /// <value>{{{plano_parcelamento_acordo_request_saldo_devedor_value}}}</value>
        [DataMember(Name="saldoDevedor", EmitDefaultValue=false)]
        public double? SaldoDevedor { get; set; }
    
        /// <summary>
        /// {{{plano_parcelamento_acordo_request_numero_parcelas_value}}}
        /// </summary>
        /// <value>{{{plano_parcelamento_acordo_request_numero_parcelas_value}}}</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public int? NumeroParcelas { get; set; }
    
        /// <summary>
        /// {{{plano_parcelamento_acordo_request_dias_atraso_value}}}
        /// </summary>
        /// <value>{{{plano_parcelamento_acordo_request_dias_atraso_value}}}</value>
        [DataMember(Name="diasAtraso", EmitDefaultValue=false)]
        public int? DiasAtraso { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlanoParcelamentoAcordoRequestValue {\n");
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
            return this.Equals(obj as PlanoParcelamentoAcordoRequestValue);
        }

        /// <summary>
        /// Returns true if PlanoParcelamentoAcordoRequestValue instances are equal
        /// </summary>
        /// <param name="other">Instance of PlanoParcelamentoAcordoRequestValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanoParcelamentoAcordoRequestValue other)
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
