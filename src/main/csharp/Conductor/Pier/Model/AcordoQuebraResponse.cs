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
    /// {{{acordo_quebra_response_description}}}
    /// </summary>
    [DataContract]
    public partial class AcordoQuebraResponse :  IEquatable<AcordoQuebraResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AcordoQuebraResponse" /> class.
        /// Initializes a new instance of the <see cref="AcordoQuebraResponse" />class.
        /// </summary>
        /// <param name="Id">{{{acordo_quebra_response_id_value}}}.</param>
        /// <param name="IdConta">{{{acordo_quebra_response_id_conta_value}}}.</param>
        /// <param name="StatusConta">{{{acordo_quebra_response_status_conta_value}}}.</param>
        /// <param name="SaldoAtualFinal">{{{acordo_quebra_response_saldo_atual_final_value}}}.</param>
        /// <param name="DataQuebraAcordo">{{{acordo_quebra_response_data_quebra_acordo_value}}}.</param>

        public AcordoQuebraResponse(long? Id = null, long? IdConta = null, long? StatusConta = null, double? SaldoAtualFinal = null, string DataQuebraAcordo = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.StatusConta = StatusConta;
            this.SaldoAtualFinal = SaldoAtualFinal;
            this.DataQuebraAcordo = DataQuebraAcordo;
            
        }
        
    
        /// <summary>
        /// {{{acordo_quebra_response_id_value}}}
        /// </summary>
        /// <value>{{{acordo_quebra_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{acordo_quebra_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{acordo_quebra_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{acordo_quebra_response_status_conta_value}}}
        /// </summary>
        /// <value>{{{acordo_quebra_response_status_conta_value}}}</value>
        [DataMember(Name="statusConta", EmitDefaultValue=false)]
        public long? StatusConta { get; set; }
    
        /// <summary>
        /// {{{acordo_quebra_response_saldo_atual_final_value}}}
        /// </summary>
        /// <value>{{{acordo_quebra_response_saldo_atual_final_value}}}</value>
        [DataMember(Name="saldoAtualFinal", EmitDefaultValue=false)]
        public double? SaldoAtualFinal { get; set; }
    
        /// <summary>
        /// {{{acordo_quebra_response_data_quebra_acordo_value}}}
        /// </summary>
        /// <value>{{{acordo_quebra_response_data_quebra_acordo_value}}}</value>
        [DataMember(Name="dataQuebraAcordo", EmitDefaultValue=false)]
        public string DataQuebraAcordo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcordoQuebraResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  StatusConta: ").Append(StatusConta).Append("\n");
            sb.Append("  SaldoAtualFinal: ").Append(SaldoAtualFinal).Append("\n");
            sb.Append("  DataQuebraAcordo: ").Append(DataQuebraAcordo).Append("\n");
            
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
            return this.Equals(obj as AcordoQuebraResponse);
        }

        /// <summary>
        /// Returns true if AcordoQuebraResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AcordoQuebraResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcordoQuebraResponse other)
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
                    this.StatusConta == other.StatusConta ||
                    this.StatusConta != null &&
                    this.StatusConta.Equals(other.StatusConta)
                ) && 
                (
                    this.SaldoAtualFinal == other.SaldoAtualFinal ||
                    this.SaldoAtualFinal != null &&
                    this.SaldoAtualFinal.Equals(other.SaldoAtualFinal)
                ) && 
                (
                    this.DataQuebraAcordo == other.DataQuebraAcordo ||
                    this.DataQuebraAcordo != null &&
                    this.DataQuebraAcordo.Equals(other.DataQuebraAcordo)
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
                
                if (this.StatusConta != null)
                    hash = hash * 59 + this.StatusConta.GetHashCode();
                
                if (this.SaldoAtualFinal != null)
                    hash = hash * 59 + this.SaldoAtualFinal.GetHashCode();
                
                if (this.DataQuebraAcordo != null)
                    hash = hash * 59 + this.DataQuebraAcordo.GetHashCode();
                
                return hash;
            }
        }

    }
}
