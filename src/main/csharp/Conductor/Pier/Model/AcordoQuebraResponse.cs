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
    /// Resposta da quebra do Acordo
    /// </summary>
    [DataContract]
    public partial class AcordoQuebraResponse :  IEquatable<AcordoQuebraResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AcordoQuebraResponse" /> class.
        /// Initializes a new instance of the <see cref="AcordoQuebraResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo de Identifica\u00E7\u00E3o do acordo (id).</param>
        /// <param name="IdConta">C\u00F3digo de Identifica\u00E7\u00E3o da conta (idConta).</param>
        /// <param name="StatusConta">Status da conta do acordo.</param>
        /// <param name="SaldoAtualFinal">Saldo atual final da conta.</param>
        /// <param name="DataQuebraAcordo">Data de quebra do acordo.</param>

        public AcordoQuebraResponse(long? Id = null, long? IdConta = null, long? StatusConta = null, double? SaldoAtualFinal = null, string DataQuebraAcordo = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.StatusConta = StatusConta;
            this.SaldoAtualFinal = SaldoAtualFinal;
            this.DataQuebraAcordo = DataQuebraAcordo;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do acordo (id)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do acordo (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da conta (idConta)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da conta (idConta)</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Status da conta do acordo
        /// </summary>
        /// <value>Status da conta do acordo</value>
        [DataMember(Name="statusConta", EmitDefaultValue=false)]
        public long? StatusConta { get; set; }
    
        /// <summary>
        /// Saldo atual final da conta
        /// </summary>
        /// <value>Saldo atual final da conta</value>
        [DataMember(Name="saldoAtualFinal", EmitDefaultValue=false)]
        public double? SaldoAtualFinal { get; set; }
    
        /// <summary>
        /// Data de quebra do acordo
        /// </summary>
        /// <value>Data de quebra do acordo</value>
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
