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
    /// {{{acordo_response_description}}}
    /// </summary>
    [DataContract]
    public partial class AcordoResponse :  IEquatable<AcordoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AcordoResponse" /> class.
        /// Initializes a new instance of the <see cref="AcordoResponse" />class.
        /// </summary>
        /// <param name="Id">{{{acordo_response_id_value}}}.</param>
        /// <param name="IdConta">{{{acordo_response_id_conta_value}}}.</param>
        /// <param name="StatusAcordo">{{{acordo_response_status_acordo_value}}}.</param>
        /// <param name="ValorAcordo">{{{acordo_response_valor_acordo_value}}}.</param>
        /// <param name="DataAcordo">{{{acordo_response_data_acordo_value}}}.</param>
        /// <param name="QuantidadeParcelas">{{{acordo_response_quantidade_parcelas_value}}}.</param>
        /// <param name="SaldoAtualFinal">{{{acordo_response_saldo_atual_final_value}}}.</param>
        /// <param name="DiasEmAtraso">{{{acordo_response_dias_em_atraso_value}}}.</param>

        public AcordoResponse(long? Id = null, long? IdConta = null, long? StatusAcordo = null, double? ValorAcordo = null, string DataAcordo = null, int? QuantidadeParcelas = null, double? SaldoAtualFinal = null, int? DiasEmAtraso = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.StatusAcordo = StatusAcordo;
            this.ValorAcordo = ValorAcordo;
            this.DataAcordo = DataAcordo;
            this.QuantidadeParcelas = QuantidadeParcelas;
            this.SaldoAtualFinal = SaldoAtualFinal;
            this.DiasEmAtraso = DiasEmAtraso;
            
        }
        
    
        /// <summary>
        /// {{{acordo_response_id_value}}}
        /// </summary>
        /// <value>{{{acordo_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{acordo_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{acordo_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{acordo_response_status_acordo_value}}}
        /// </summary>
        /// <value>{{{acordo_response_status_acordo_value}}}</value>
        [DataMember(Name="statusAcordo", EmitDefaultValue=false)]
        public long? StatusAcordo { get; set; }
    
        /// <summary>
        /// {{{acordo_response_valor_acordo_value}}}
        /// </summary>
        /// <value>{{{acordo_response_valor_acordo_value}}}</value>
        [DataMember(Name="valorAcordo", EmitDefaultValue=false)]
        public double? ValorAcordo { get; set; }
    
        /// <summary>
        /// {{{acordo_response_data_acordo_value}}}
        /// </summary>
        /// <value>{{{acordo_response_data_acordo_value}}}</value>
        [DataMember(Name="dataAcordo", EmitDefaultValue=false)]
        public string DataAcordo { get; set; }
    
        /// <summary>
        /// {{{acordo_response_quantidade_parcelas_value}}}
        /// </summary>
        /// <value>{{{acordo_response_quantidade_parcelas_value}}}</value>
        [DataMember(Name="quantidadeParcelas", EmitDefaultValue=false)]
        public int? QuantidadeParcelas { get; set; }
    
        /// <summary>
        /// {{{acordo_response_saldo_atual_final_value}}}
        /// </summary>
        /// <value>{{{acordo_response_saldo_atual_final_value}}}</value>
        [DataMember(Name="saldoAtualFinal", EmitDefaultValue=false)]
        public double? SaldoAtualFinal { get; set; }
    
        /// <summary>
        /// {{{acordo_response_dias_em_atraso_value}}}
        /// </summary>
        /// <value>{{{acordo_response_dias_em_atraso_value}}}</value>
        [DataMember(Name="diasEmAtraso", EmitDefaultValue=false)]
        public int? DiasEmAtraso { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcordoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  StatusAcordo: ").Append(StatusAcordo).Append("\n");
            sb.Append("  ValorAcordo: ").Append(ValorAcordo).Append("\n");
            sb.Append("  DataAcordo: ").Append(DataAcordo).Append("\n");
            sb.Append("  QuantidadeParcelas: ").Append(QuantidadeParcelas).Append("\n");
            sb.Append("  SaldoAtualFinal: ").Append(SaldoAtualFinal).Append("\n");
            sb.Append("  DiasEmAtraso: ").Append(DiasEmAtraso).Append("\n");
            
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
            return this.Equals(obj as AcordoResponse);
        }

        /// <summary>
        /// Returns true if AcordoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AcordoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcordoResponse other)
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
                    this.StatusAcordo == other.StatusAcordo ||
                    this.StatusAcordo != null &&
                    this.StatusAcordo.Equals(other.StatusAcordo)
                ) && 
                (
                    this.ValorAcordo == other.ValorAcordo ||
                    this.ValorAcordo != null &&
                    this.ValorAcordo.Equals(other.ValorAcordo)
                ) && 
                (
                    this.DataAcordo == other.DataAcordo ||
                    this.DataAcordo != null &&
                    this.DataAcordo.Equals(other.DataAcordo)
                ) && 
                (
                    this.QuantidadeParcelas == other.QuantidadeParcelas ||
                    this.QuantidadeParcelas != null &&
                    this.QuantidadeParcelas.Equals(other.QuantidadeParcelas)
                ) && 
                (
                    this.SaldoAtualFinal == other.SaldoAtualFinal ||
                    this.SaldoAtualFinal != null &&
                    this.SaldoAtualFinal.Equals(other.SaldoAtualFinal)
                ) && 
                (
                    this.DiasEmAtraso == other.DiasEmAtraso ||
                    this.DiasEmAtraso != null &&
                    this.DiasEmAtraso.Equals(other.DiasEmAtraso)
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
                
                if (this.StatusAcordo != null)
                    hash = hash * 59 + this.StatusAcordo.GetHashCode();
                
                if (this.ValorAcordo != null)
                    hash = hash * 59 + this.ValorAcordo.GetHashCode();
                
                if (this.DataAcordo != null)
                    hash = hash * 59 + this.DataAcordo.GetHashCode();
                
                if (this.QuantidadeParcelas != null)
                    hash = hash * 59 + this.QuantidadeParcelas.GetHashCode();
                
                if (this.SaldoAtualFinal != null)
                    hash = hash * 59 + this.SaldoAtualFinal.GetHashCode();
                
                if (this.DiasEmAtraso != null)
                    hash = hash * 59 + this.DiasEmAtraso.GetHashCode();
                
                return hash;
            }
        }

    }
}
