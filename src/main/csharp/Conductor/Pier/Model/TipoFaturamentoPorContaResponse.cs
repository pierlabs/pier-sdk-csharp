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
    /// {{{tipo_faturamento_por_conta_response_description}}}
    /// </summary>
    [DataContract]
    public partial class TipoFaturamentoPorContaResponse :  IEquatable<TipoFaturamentoPorContaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoFaturamentoPorContaResponse" /> class.
        /// Initializes a new instance of the <see cref="TipoFaturamentoPorContaResponse" />class.
        /// </summary>
        /// <param name="Id">{{{tipo_faturamento_por_conta_response_id_value}}}.</param>
        /// <param name="IdConta">{{{tipo_faturamento_por_conta_response_id_conta_value}}}.</param>
        /// <param name="Ativo">{{{tipo_faturamento_por_conta_response_status_value}}}.</param>
        /// <param name="IdTipoFaturamento">{{{tipo_faturamento_por_conta_response_id_tipo_faturamento_value}}}.</param>
        /// <param name="DataHoraInclusao">{{{tipo_faturamento_por_conta_response_data_hora_inclusao_value}}}.</param>
        /// <param name="DataHoraCancelamento">{{{tipo_faturamento_por_conta_response_data_hora_cancelamento_value}}}.</param>
        /// <param name="ModificadoPor">{{{tipo_faturamento_por_conta_response_modificado_por_value}}}.</param>

        public TipoFaturamentoPorContaResponse(long? Id = null, long? IdConta = null, bool? Ativo = null, long? IdTipoFaturamento = null, string DataHoraInclusao = null, string DataHoraCancelamento = null, string ModificadoPor = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.Ativo = Ativo;
            this.IdTipoFaturamento = IdTipoFaturamento;
            this.DataHoraInclusao = DataHoraInclusao;
            this.DataHoraCancelamento = DataHoraCancelamento;
            this.ModificadoPor = ModificadoPor;
            
        }
        
    
        /// <summary>
        /// {{{tipo_faturamento_por_conta_response_id_value}}}
        /// </summary>
        /// <value>{{{tipo_faturamento_por_conta_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{tipo_faturamento_por_conta_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{tipo_faturamento_por_conta_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{tipo_faturamento_por_conta_response_status_value}}}
        /// </summary>
        /// <value>{{{tipo_faturamento_por_conta_response_status_value}}}</value>
        [DataMember(Name="ativo", EmitDefaultValue=false)]
        public bool? Ativo { get; set; }
    
        /// <summary>
        /// {{{tipo_faturamento_por_conta_response_id_tipo_faturamento_value}}}
        /// </summary>
        /// <value>{{{tipo_faturamento_por_conta_response_id_tipo_faturamento_value}}}</value>
        [DataMember(Name="idTipoFaturamento", EmitDefaultValue=false)]
        public long? IdTipoFaturamento { get; set; }
    
        /// <summary>
        /// {{{tipo_faturamento_por_conta_response_data_hora_inclusao_value}}}
        /// </summary>
        /// <value>{{{tipo_faturamento_por_conta_response_data_hora_inclusao_value}}}</value>
        [DataMember(Name="dataHoraInclusao", EmitDefaultValue=false)]
        public string DataHoraInclusao { get; set; }
    
        /// <summary>
        /// {{{tipo_faturamento_por_conta_response_data_hora_cancelamento_value}}}
        /// </summary>
        /// <value>{{{tipo_faturamento_por_conta_response_data_hora_cancelamento_value}}}</value>
        [DataMember(Name="dataHoraCancelamento", EmitDefaultValue=false)]
        public string DataHoraCancelamento { get; set; }
    
        /// <summary>
        /// {{{tipo_faturamento_por_conta_response_modificado_por_value}}}
        /// </summary>
        /// <value>{{{tipo_faturamento_por_conta_response_modificado_por_value}}}</value>
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
            sb.Append("  Ativo: ").Append(Ativo).Append("\n");
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
                    this.Ativo == other.Ativo ||
                    this.Ativo != null &&
                    this.Ativo.Equals(other.Ativo)
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
                
                if (this.Ativo != null)
                    hash = hash * 59 + this.Ativo.GetHashCode();
                
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
