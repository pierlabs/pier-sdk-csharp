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
    /// TipoFaturamentoPorContaPersist
    /// </summary>
    [DataContract]
    public partial class TipoFaturamentoPorContaPersist :  IEquatable<TipoFaturamentoPorContaPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoFaturamentoPorContaPersist" /> class.
        /// Initializes a new instance of the <see cref="TipoFaturamentoPorContaPersist" />class.
        /// </summary>
        /// <param name="Status">Representa se a configura\u00E7\u00E3o est\u00E1 ativada ou desativada para a conta. (required).</param>
        /// <param name="IdConta">C\u00F3digo de identifica\u00E7\u00E3o da conta relacionada. (required).</param>
        /// <param name="IdTipoFaturamento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento relacionada. (required).</param>
        /// <param name="DataHoraInclusao">Data da inclus\u00E3o da configura\u00E7\u00E3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;..</param>
        /// <param name="DataHoraCancelamento">Data do cancelamento da configura\u00E7\u00E3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;..</param>
        /// <param name="ModificadoPor">Identificador do respons\u00E1vel pela modifica\u00E7\u00E3o do registro. (required).</param>

        public TipoFaturamentoPorContaPersist(bool? Status = null, long? IdConta = null, long? IdTipoFaturamento = null, string DataHoraInclusao = null, string DataHoraCancelamento = null, string ModificadoPor = null)
        {
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for TipoFaturamentoPorContaPersist and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "IdConta" is required (not null)
            if (IdConta == null)
            {
                throw new InvalidDataException("IdConta is a required property for TipoFaturamentoPorContaPersist and cannot be null");
            }
            else
            {
                this.IdConta = IdConta;
            }
            // to ensure "IdTipoFaturamento" is required (not null)
            if (IdTipoFaturamento == null)
            {
                throw new InvalidDataException("IdTipoFaturamento is a required property for TipoFaturamentoPorContaPersist and cannot be null");
            }
            else
            {
                this.IdTipoFaturamento = IdTipoFaturamento;
            }
            // to ensure "ModificadoPor" is required (not null)
            if (ModificadoPor == null)
            {
                throw new InvalidDataException("ModificadoPor is a required property for TipoFaturamentoPorContaPersist and cannot be null");
            }
            else
            {
                this.ModificadoPor = ModificadoPor;
            }
            this.DataHoraInclusao = DataHoraInclusao;
            this.DataHoraCancelamento = DataHoraCancelamento;
            
        }
        
    
        /// <summary>
        /// Representa se a configura\u00E7\u00E3o est\u00E1 ativada ou desativada para a conta.
        /// </summary>
        /// <value>Representa se a configura\u00E7\u00E3o est\u00E1 ativada ou desativada para a conta.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public bool? Status { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da conta relacionada.
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da conta relacionada.</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento relacionada.
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento relacionada.</value>
        [DataMember(Name="idTipoFaturamento", EmitDefaultValue=false)]
        public long? IdTipoFaturamento { get; set; }
    
        /// <summary>
        /// Data da inclus\u00E3o da configura\u00E7\u00E3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;.
        /// </summary>
        /// <value>Data da inclus\u00E3o da configura\u00E7\u00E3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;.</value>
        [DataMember(Name="dataHoraInclusao", EmitDefaultValue=false)]
        public string DataHoraInclusao { get; set; }
    
        /// <summary>
        /// Data do cancelamento da configura\u00E7\u00E3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;.
        /// </summary>
        /// <value>Data do cancelamento da configura\u00E7\u00E3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;.</value>
        [DataMember(Name="dataHoraCancelamento", EmitDefaultValue=false)]
        public string DataHoraCancelamento { get; set; }
    
        /// <summary>
        /// Identificador do respons\u00E1vel pela modifica\u00E7\u00E3o do registro.
        /// </summary>
        /// <value>Identificador do respons\u00E1vel pela modifica\u00E7\u00E3o do registro.</value>
        [DataMember(Name="modificadoPor", EmitDefaultValue=false)]
        public string ModificadoPor { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoFaturamentoPorContaPersist {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdTipoFaturamento: ").Append(IdTipoFaturamento).Append("\n");
            sb.Append("  DataHoraInclusao: ").Append(DataHoraInclusao).Append("\n");
            sb.Append("  DataHoraCancelamento: ").Append(DataHoraCancelamento).Append("\n");
            sb.Append("  ModificadoPor: ").Append(ModificadoPor).Append("\n");
            
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
            return this.Equals(obj as TipoFaturamentoPorContaPersist);
        }

        /// <summary>
        /// Returns true if TipoFaturamentoPorContaPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoFaturamentoPorContaPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoFaturamentoPorContaPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdTipoFaturamento == other.IdTipoFaturamento ||
                    this.IdTipoFaturamento != null &&
                    this.IdTipoFaturamento.Equals(other.IdTipoFaturamento)
                ) && 
                (
                    this.DataHoraInclusao == other.DataHoraInclusao ||
                    this.DataHoraInclusao != null &&
                    this.DataHoraInclusao.Equals(other.DataHoraInclusao)
                ) && 
                (
                    this.DataHoraCancelamento == other.DataHoraCancelamento ||
                    this.DataHoraCancelamento != null &&
                    this.DataHoraCancelamento.Equals(other.DataHoraCancelamento)
                ) && 
                (
                    this.ModificadoPor == other.ModificadoPor ||
                    this.ModificadoPor != null &&
                    this.ModificadoPor.Equals(other.ModificadoPor)
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdTipoFaturamento != null)
                    hash = hash * 59 + this.IdTipoFaturamento.GetHashCode();
                
                if (this.DataHoraInclusao != null)
                    hash = hash * 59 + this.DataHoraInclusao.GetHashCode();
                
                if (this.DataHoraCancelamento != null)
                    hash = hash * 59 + this.DataHoraCancelamento.GetHashCode();
                
                if (this.ModificadoPor != null)
                    hash = hash * 59 + this.ModificadoPor.GetHashCode();
                
                return hash;
            }
        }

    }
}
