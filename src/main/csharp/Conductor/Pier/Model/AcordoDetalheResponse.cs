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
    /// {{{acordo_detalhe_response_description}}}
    /// </summary>
    [DataContract]
    public partial class AcordoDetalheResponse :  IEquatable<AcordoDetalheResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AcordoDetalheResponse" /> class.
        /// Initializes a new instance of the <see cref="AcordoDetalheResponse" />class.
        /// </summary>
        /// <param name="Id">{{{acordo_response_id_value}}}.</param>
        /// <param name="IdConta">{{{acordo_response_id_conta_value}}}.</param>
        /// <param name="StatusAcordo">{{{acordo_response_status_acordo_value}}}.</param>
        /// <param name="ValorAcordo">{{{acordo_response_valor_acordo_value}}}.</param>
        /// <param name="DataAcordo">{{{acordo_response_data_acordo_value}}}.</param>
        /// <param name="QuantidadeParcelas">{{{acordo_response_quantidade_parcelas_value}}}.</param>
        /// <param name="SaldoAtualFinal">{{{acordo_response_saldo_atual_final_value}}}.</param>
        /// <param name="DiasEmAtraso">{{{acordo_response_dias_em_atraso_value}}}.</param>
        /// <param name="StatusConta">{{{acordo_detalhe_response_status_conta_value}}}.</param>
        /// <param name="AssessoriaAtual">{{{acordo_detalhe_response_assessoria_atual_value}}}.</param>
        /// <param name="TotalPagamentos">{{{acordo_detalhe_response_total_pagamentos_value}}}.</param>
        /// <param name="DataVencimentoCobranca">{{{acordo_detalhe_response_data_vencimento_cobranca_value}}}.</param>
        /// <param name="DataQuebraAcordo">{{{acordo_detalhe_response_data_quebra_acordo_value}}}.</param>
        /// <param name="ValorParcela1">{{{acordo_detalhe_response_valor_parcela1_value}}}.</param>
        /// <param name="ValorParcelaN">{{{acordo_detalhe_response_valor_parcela_n_value}}}.</param>
        /// <param name="ParcelaPedida">{{{acordo_detalhe_response_parcela_pedida_value}}}.</param>
        /// <param name="VencimentoParcelaPedida">{{{acordo_detalhe_response_vencimento_parcela_pedida_value}}}.</param>

        public AcordoDetalheResponse(long? Id = null, long? IdConta = null, long? StatusAcordo = null, double? ValorAcordo = null, string DataAcordo = null, int? QuantidadeParcelas = null, double? SaldoAtualFinal = null, int? DiasEmAtraso = null, long? StatusConta = null, string AssessoriaAtual = null, double? TotalPagamentos = null, string DataVencimentoCobranca = null, string DataQuebraAcordo = null, double? ValorParcela1 = null, double? ValorParcelaN = null, int? ParcelaPedida = null, string VencimentoParcelaPedida = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.StatusAcordo = StatusAcordo;
            this.ValorAcordo = ValorAcordo;
            this.DataAcordo = DataAcordo;
            this.QuantidadeParcelas = QuantidadeParcelas;
            this.SaldoAtualFinal = SaldoAtualFinal;
            this.DiasEmAtraso = DiasEmAtraso;
            this.StatusConta = StatusConta;
            this.AssessoriaAtual = AssessoriaAtual;
            this.TotalPagamentos = TotalPagamentos;
            this.DataVencimentoCobranca = DataVencimentoCobranca;
            this.DataQuebraAcordo = DataQuebraAcordo;
            this.ValorParcela1 = ValorParcela1;
            this.ValorParcelaN = ValorParcelaN;
            this.ParcelaPedida = ParcelaPedida;
            this.VencimentoParcelaPedida = VencimentoParcelaPedida;
            
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
        /// {{{acordo_detalhe_response_status_conta_value}}}
        /// </summary>
        /// <value>{{{acordo_detalhe_response_status_conta_value}}}</value>
        [DataMember(Name="statusConta", EmitDefaultValue=false)]
        public long? StatusConta { get; set; }
    
        /// <summary>
        /// {{{acordo_detalhe_response_assessoria_atual_value}}}
        /// </summary>
        /// <value>{{{acordo_detalhe_response_assessoria_atual_value}}}</value>
        [DataMember(Name="assessoriaAtual", EmitDefaultValue=false)]
        public string AssessoriaAtual { get; set; }
    
        /// <summary>
        /// {{{acordo_detalhe_response_total_pagamentos_value}}}
        /// </summary>
        /// <value>{{{acordo_detalhe_response_total_pagamentos_value}}}</value>
        [DataMember(Name="totalPagamentos", EmitDefaultValue=false)]
        public double? TotalPagamentos { get; set; }
    
        /// <summary>
        /// {{{acordo_detalhe_response_data_vencimento_cobranca_value}}}
        /// </summary>
        /// <value>{{{acordo_detalhe_response_data_vencimento_cobranca_value}}}</value>
        [DataMember(Name="dataVencimentoCobranca", EmitDefaultValue=false)]
        public string DataVencimentoCobranca { get; set; }
    
        /// <summary>
        /// {{{acordo_detalhe_response_data_quebra_acordo_value}}}
        /// </summary>
        /// <value>{{{acordo_detalhe_response_data_quebra_acordo_value}}}</value>
        [DataMember(Name="dataQuebraAcordo", EmitDefaultValue=false)]
        public string DataQuebraAcordo { get; set; }
    
        /// <summary>
        /// {{{acordo_detalhe_response_valor_parcela1_value}}}
        /// </summary>
        /// <value>{{{acordo_detalhe_response_valor_parcela1_value}}}</value>
        [DataMember(Name="valorParcela1", EmitDefaultValue=false)]
        public double? ValorParcela1 { get; set; }
    
        /// <summary>
        /// {{{acordo_detalhe_response_valor_parcela_n_value}}}
        /// </summary>
        /// <value>{{{acordo_detalhe_response_valor_parcela_n_value}}}</value>
        [DataMember(Name="valorParcelaN", EmitDefaultValue=false)]
        public double? ValorParcelaN { get; set; }
    
        /// <summary>
        /// {{{acordo_detalhe_response_parcela_pedida_value}}}
        /// </summary>
        /// <value>{{{acordo_detalhe_response_parcela_pedida_value}}}</value>
        [DataMember(Name="parcelaPedida", EmitDefaultValue=false)]
        public int? ParcelaPedida { get; set; }
    
        /// <summary>
        /// {{{acordo_detalhe_response_vencimento_parcela_pedida_value}}}
        /// </summary>
        /// <value>{{{acordo_detalhe_response_vencimento_parcela_pedida_value}}}</value>
        [DataMember(Name="vencimentoParcelaPedida", EmitDefaultValue=false)]
        public string VencimentoParcelaPedida { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcordoDetalheResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  StatusAcordo: ").Append(StatusAcordo).Append("\n");
            sb.Append("  ValorAcordo: ").Append(ValorAcordo).Append("\n");
            sb.Append("  DataAcordo: ").Append(DataAcordo).Append("\n");
            sb.Append("  QuantidadeParcelas: ").Append(QuantidadeParcelas).Append("\n");
            sb.Append("  SaldoAtualFinal: ").Append(SaldoAtualFinal).Append("\n");
            sb.Append("  DiasEmAtraso: ").Append(DiasEmAtraso).Append("\n");
            sb.Append("  StatusConta: ").Append(StatusConta).Append("\n");
            sb.Append("  AssessoriaAtual: ").Append(AssessoriaAtual).Append("\n");
            sb.Append("  TotalPagamentos: ").Append(TotalPagamentos).Append("\n");
            sb.Append("  DataVencimentoCobranca: ").Append(DataVencimentoCobranca).Append("\n");
            sb.Append("  DataQuebraAcordo: ").Append(DataQuebraAcordo).Append("\n");
            sb.Append("  ValorParcela1: ").Append(ValorParcela1).Append("\n");
            sb.Append("  ValorParcelaN: ").Append(ValorParcelaN).Append("\n");
            sb.Append("  ParcelaPedida: ").Append(ParcelaPedida).Append("\n");
            sb.Append("  VencimentoParcelaPedida: ").Append(VencimentoParcelaPedida).Append("\n");
            
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
            return this.Equals(obj as AcordoDetalheResponse);
        }

        /// <summary>
        /// Returns true if AcordoDetalheResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AcordoDetalheResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcordoDetalheResponse other)
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
                ) && 
                (
                    this.StatusConta == other.StatusConta ||
                    this.StatusConta != null &&
                    this.StatusConta.Equals(other.StatusConta)
                ) && 
                (
                    this.AssessoriaAtual == other.AssessoriaAtual ||
                    this.AssessoriaAtual != null &&
                    this.AssessoriaAtual.Equals(other.AssessoriaAtual)
                ) && 
                (
                    this.TotalPagamentos == other.TotalPagamentos ||
                    this.TotalPagamentos != null &&
                    this.TotalPagamentos.Equals(other.TotalPagamentos)
                ) && 
                (
                    this.DataVencimentoCobranca == other.DataVencimentoCobranca ||
                    this.DataVencimentoCobranca != null &&
                    this.DataVencimentoCobranca.Equals(other.DataVencimentoCobranca)
                ) && 
                (
                    this.DataQuebraAcordo == other.DataQuebraAcordo ||
                    this.DataQuebraAcordo != null &&
                    this.DataQuebraAcordo.Equals(other.DataQuebraAcordo)
                ) && 
                (
                    this.ValorParcela1 == other.ValorParcela1 ||
                    this.ValorParcela1 != null &&
                    this.ValorParcela1.Equals(other.ValorParcela1)
                ) && 
                (
                    this.ValorParcelaN == other.ValorParcelaN ||
                    this.ValorParcelaN != null &&
                    this.ValorParcelaN.Equals(other.ValorParcelaN)
                ) && 
                (
                    this.ParcelaPedida == other.ParcelaPedida ||
                    this.ParcelaPedida != null &&
                    this.ParcelaPedida.Equals(other.ParcelaPedida)
                ) && 
                (
                    this.VencimentoParcelaPedida == other.VencimentoParcelaPedida ||
                    this.VencimentoParcelaPedida != null &&
                    this.VencimentoParcelaPedida.Equals(other.VencimentoParcelaPedida)
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
                
                if (this.StatusConta != null)
                    hash = hash * 59 + this.StatusConta.GetHashCode();
                
                if (this.AssessoriaAtual != null)
                    hash = hash * 59 + this.AssessoriaAtual.GetHashCode();
                
                if (this.TotalPagamentos != null)
                    hash = hash * 59 + this.TotalPagamentos.GetHashCode();
                
                if (this.DataVencimentoCobranca != null)
                    hash = hash * 59 + this.DataVencimentoCobranca.GetHashCode();
                
                if (this.DataQuebraAcordo != null)
                    hash = hash * 59 + this.DataQuebraAcordo.GetHashCode();
                
                if (this.ValorParcela1 != null)
                    hash = hash * 59 + this.ValorParcela1.GetHashCode();
                
                if (this.ValorParcelaN != null)
                    hash = hash * 59 + this.ValorParcelaN.GetHashCode();
                
                if (this.ParcelaPedida != null)
                    hash = hash * 59 + this.ParcelaPedida.GetHashCode();
                
                if (this.VencimentoParcelaPedida != null)
                    hash = hash * 59 + this.VencimentoParcelaPedida.GetHashCode();
                
                return hash;
            }
        }

    }
}
