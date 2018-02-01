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
    /// Objeto Faturamento
    /// </summary>
    [DataContract]
    public partial class TipoFaturamentoPorContaResponse :  IEquatable<TipoFaturamentoPorContaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoFaturamentoPorContaResponse" /> class.
        /// Initializes a new instance of the <see cref="TipoFaturamentoPorContaResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento por conta (id)..</param>
        /// <param name="IdConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta relacionada ao tipo de faturamento..</param>
        /// <param name="Status">Status da configura\u00C3\u00A7\u00C3\u00A3o que representa que se o tipo de faturamento por conta est\u00C3\u00A1 ativo ou cancelado..</param>
        /// <param name="IdTipoFaturamento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da tipo de faturamento referenciado..</param>
        /// <param name="DataHoraInclusao">Data de inclus\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento por conta..</param>
        /// <param name="DataHoraCancelamento">Data de cancelamento da configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento por conta..</param>
        /// <param name="ModificadoPor">Descri\u00C3\u00A7\u00C3\u00A3o do respons\u00C3\u00A1vel pela \u00C3\u00BAltima modifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o..</param>

        public TipoFaturamentoPorContaResponse(long? Id = null, long? IdConta = null, bool? Status = null, long? IdTipoFaturamento = null, string DataHoraInclusao = null, string DataHoraCancelamento = null, string ModificadoPor = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.Status = Status;
            this.IdTipoFaturamento = IdTipoFaturamento;
            this.DataHoraInclusao = DataHoraInclusao;
            this.DataHoraCancelamento = DataHoraCancelamento;
            this.ModificadoPor = ModificadoPor;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento por conta (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento por conta (id).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta relacionada ao tipo de faturamento.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta relacionada ao tipo de faturamento.</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Status da configura\u00C3\u00A7\u00C3\u00A3o que representa que se o tipo de faturamento por conta est\u00C3\u00A1 ativo ou cancelado.
        /// </summary>
        /// <value>Status da configura\u00C3\u00A7\u00C3\u00A3o que representa que se o tipo de faturamento por conta est\u00C3\u00A1 ativo ou cancelado.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public bool? Status { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da tipo de faturamento referenciado.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da tipo de faturamento referenciado.</value>
        [DataMember(Name="idTipoFaturamento", EmitDefaultValue=false)]
        public long? IdTipoFaturamento { get; set; }
    
        /// <summary>
        /// Data de inclus\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento por conta.
        /// </summary>
        /// <value>Data de inclus\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento por conta.</value>
        [DataMember(Name="dataHoraInclusao", EmitDefaultValue=false)]
        public string DataHoraInclusao { get; set; }
    
        /// <summary>
        /// Data de cancelamento da configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento por conta.
        /// </summary>
        /// <value>Data de cancelamento da configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento por conta.</value>
        [DataMember(Name="dataHoraCancelamento", EmitDefaultValue=false)]
        public string DataHoraCancelamento { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o do respons\u00C3\u00A1vel pela \u00C3\u00BAltima modifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o do respons\u00C3\u00A1vel pela \u00C3\u00BAltima modifica\u00C3\u00A7\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="modificadoPor", EmitDefaultValue=false)]
        public string ModificadoPor { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoFaturamentoPorContaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as TipoFaturamentoPorContaResponse);
        }

        /// <summary>
        /// Returns true if TipoFaturamentoPorContaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoFaturamentoPorContaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoFaturamentoPorContaResponse other)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
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
