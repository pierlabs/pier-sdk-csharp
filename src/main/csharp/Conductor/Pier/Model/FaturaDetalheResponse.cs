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
    /// Detalhes da fatura
    /// </summary>
    [DataContract]
    public partial class FaturaDetalheResponse :  IEquatable<FaturaDetalheResponse>
    { 
    
        /// <summary>
        /// Situa\u00C3\u00A7\u00C3\u00A3o de Processamento da fatura.
        /// </summary>
        /// <value>Situa\u00C3\u00A7\u00C3\u00A3o de Processamento da fatura.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SituacaoProcessamentoEnum {
            
            [EnumMember(Value = "ABERTA")]
            Aberta,
            
            [EnumMember(Value = "FECHADA")]
            Fechada,
            
            [EnumMember(Value = "TODAS")]
            Todas
        }

    
        /// <summary>
        /// Situa\u00C3\u00A7\u00C3\u00A3o de Processamento da fatura.
        /// </summary>
        /// <value>Situa\u00C3\u00A7\u00C3\u00A3o de Processamento da fatura.</value>
        [DataMember(Name="situacaoProcessamento", EmitDefaultValue=false)]
        public SituacaoProcessamentoEnum? SituacaoProcessamento { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FaturaDetalheResponse" /> class.
        /// Initializes a new instance of the <see cref="FaturaDetalheResponse" />class.
        /// </summary>
        /// <param name="LancamentosFaturaResponse">LancamentosFaturaResponse.</param>
        /// <param name="IdConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta..</param>
        /// <param name="SituacaoProcessamento">Situa\u00C3\u00A7\u00C3\u00A3o de Processamento da fatura..</param>
        /// <param name="PagamentoEfetuado">Status de pagamento efetuado..</param>
        /// <param name="DataVencimentoFatura">Data de vencimento da fatura..</param>
        /// <param name="DataVencimentoReal">Data de vencimento real da fatura..</param>
        /// <param name="DataFechamento">Data de fechamento da fatura..</param>
        /// <param name="ValorTotal">Valor total da fatura..</param>
        /// <param name="ValorPagamentoMinimo">Valor do pagamento m\u00C3\u00ADnimo..</param>
        /// <param name="SaldoAnterior">Valor do saldo anterior..</param>

        public FaturaDetalheResponse(List<LancamentoFaturaResponse> LancamentosFaturaResponse = null, long? IdConta = null, SituacaoProcessamentoEnum? SituacaoProcessamento = null, bool? PagamentoEfetuado = null, string DataVencimentoFatura = null, string DataVencimentoReal = null, string DataFechamento = null, double? ValorTotal = null, double? ValorPagamentoMinimo = null, double? SaldoAnterior = null)
        {
            this.LancamentosFaturaResponse = LancamentosFaturaResponse;
            this.IdConta = IdConta;
            this.SituacaoProcessamento = SituacaoProcessamento;
            this.PagamentoEfetuado = PagamentoEfetuado;
            this.DataVencimentoFatura = DataVencimentoFatura;
            this.DataVencimentoReal = DataVencimentoReal;
            this.DataFechamento = DataFechamento;
            this.ValorTotal = ValorTotal;
            this.ValorPagamentoMinimo = ValorPagamentoMinimo;
            this.SaldoAnterior = SaldoAnterior;
            
        }
        
    
        /// <summary>
        /// Gets or Sets LancamentosFaturaResponse
        /// </summary>
        [DataMember(Name="lancamentosFaturaResponse", EmitDefaultValue=false)]
        public List<LancamentoFaturaResponse> LancamentosFaturaResponse { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta.</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Status de pagamento efetuado.
        /// </summary>
        /// <value>Status de pagamento efetuado.</value>
        [DataMember(Name="pagamentoEfetuado", EmitDefaultValue=false)]
        public bool? PagamentoEfetuado { get; set; }
    
        /// <summary>
        /// Data de vencimento da fatura.
        /// </summary>
        /// <value>Data de vencimento da fatura.</value>
        [DataMember(Name="dataVencimentoFatura", EmitDefaultValue=false)]
        public string DataVencimentoFatura { get; set; }
    
        /// <summary>
        /// Data de vencimento real da fatura.
        /// </summary>
        /// <value>Data de vencimento real da fatura.</value>
        [DataMember(Name="dataVencimentoReal", EmitDefaultValue=false)]
        public string DataVencimentoReal { get; set; }
    
        /// <summary>
        /// Data de fechamento da fatura.
        /// </summary>
        /// <value>Data de fechamento da fatura.</value>
        [DataMember(Name="dataFechamento", EmitDefaultValue=false)]
        public string DataFechamento { get; set; }
    
        /// <summary>
        /// Valor total da fatura.
        /// </summary>
        /// <value>Valor total da fatura.</value>
        [DataMember(Name="valorTotal", EmitDefaultValue=false)]
        public double? ValorTotal { get; set; }
    
        /// <summary>
        /// Valor do pagamento m\u00C3\u00ADnimo.
        /// </summary>
        /// <value>Valor do pagamento m\u00C3\u00ADnimo.</value>
        [DataMember(Name="valorPagamentoMinimo", EmitDefaultValue=false)]
        public double? ValorPagamentoMinimo { get; set; }
    
        /// <summary>
        /// Valor do saldo anterior.
        /// </summary>
        /// <value>Valor do saldo anterior.</value>
        [DataMember(Name="saldoAnterior", EmitDefaultValue=false)]
        public double? SaldoAnterior { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FaturaDetalheResponse {\n");
            sb.Append("  LancamentosFaturaResponse: ").Append(LancamentosFaturaResponse).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  SituacaoProcessamento: ").Append(SituacaoProcessamento).Append("\n");
            sb.Append("  PagamentoEfetuado: ").Append(PagamentoEfetuado).Append("\n");
            sb.Append("  DataVencimentoFatura: ").Append(DataVencimentoFatura).Append("\n");
            sb.Append("  DataVencimentoReal: ").Append(DataVencimentoReal).Append("\n");
            sb.Append("  DataFechamento: ").Append(DataFechamento).Append("\n");
            sb.Append("  ValorTotal: ").Append(ValorTotal).Append("\n");
            sb.Append("  ValorPagamentoMinimo: ").Append(ValorPagamentoMinimo).Append("\n");
            sb.Append("  SaldoAnterior: ").Append(SaldoAnterior).Append("\n");
            
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
            return this.Equals(obj as FaturaDetalheResponse);
        }

        /// <summary>
        /// Returns true if FaturaDetalheResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of FaturaDetalheResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FaturaDetalheResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LancamentosFaturaResponse == other.LancamentosFaturaResponse ||
                    this.LancamentosFaturaResponse != null &&
                    this.LancamentosFaturaResponse.SequenceEqual(other.LancamentosFaturaResponse)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.SituacaoProcessamento == other.SituacaoProcessamento ||
                    this.SituacaoProcessamento != null &&
                    this.SituacaoProcessamento.Equals(other.SituacaoProcessamento)
                ) && 
                (
                    this.PagamentoEfetuado == other.PagamentoEfetuado ||
                    this.PagamentoEfetuado != null &&
                    this.PagamentoEfetuado.Equals(other.PagamentoEfetuado)
                ) && 
                (
                    this.DataVencimentoFatura == other.DataVencimentoFatura ||
                    this.DataVencimentoFatura != null &&
                    this.DataVencimentoFatura.Equals(other.DataVencimentoFatura)
                ) && 
                (
                    this.DataVencimentoReal == other.DataVencimentoReal ||
                    this.DataVencimentoReal != null &&
                    this.DataVencimentoReal.Equals(other.DataVencimentoReal)
                ) && 
                (
                    this.DataFechamento == other.DataFechamento ||
                    this.DataFechamento != null &&
                    this.DataFechamento.Equals(other.DataFechamento)
                ) && 
                (
                    this.ValorTotal == other.ValorTotal ||
                    this.ValorTotal != null &&
                    this.ValorTotal.Equals(other.ValorTotal)
                ) && 
                (
                    this.ValorPagamentoMinimo == other.ValorPagamentoMinimo ||
                    this.ValorPagamentoMinimo != null &&
                    this.ValorPagamentoMinimo.Equals(other.ValorPagamentoMinimo)
                ) && 
                (
                    this.SaldoAnterior == other.SaldoAnterior ||
                    this.SaldoAnterior != null &&
                    this.SaldoAnterior.Equals(other.SaldoAnterior)
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
                
                if (this.LancamentosFaturaResponse != null)
                    hash = hash * 59 + this.LancamentosFaturaResponse.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.SituacaoProcessamento != null)
                    hash = hash * 59 + this.SituacaoProcessamento.GetHashCode();
                
                if (this.PagamentoEfetuado != null)
                    hash = hash * 59 + this.PagamentoEfetuado.GetHashCode();
                
                if (this.DataVencimentoFatura != null)
                    hash = hash * 59 + this.DataVencimentoFatura.GetHashCode();
                
                if (this.DataVencimentoReal != null)
                    hash = hash * 59 + this.DataVencimentoReal.GetHashCode();
                
                if (this.DataFechamento != null)
                    hash = hash * 59 + this.DataFechamento.GetHashCode();
                
                if (this.ValorTotal != null)
                    hash = hash * 59 + this.ValorTotal.GetHashCode();
                
                if (this.ValorPagamentoMinimo != null)
                    hash = hash * 59 + this.ValorPagamentoMinimo.GetHashCode();
                
                if (this.SaldoAnterior != null)
                    hash = hash * 59 + this.SaldoAnterior.GetHashCode();
                
                return hash;
            }
        }

    }
}
