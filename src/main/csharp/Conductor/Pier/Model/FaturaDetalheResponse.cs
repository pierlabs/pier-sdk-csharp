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
    /// Details of the invoice
    /// </summary>
    [DataContract]
    public partial class FaturaDetalheResponse :  IEquatable<FaturaDetalheResponse>
    { 
    
        /// <summary>
        /// Processing situation of the invoice
        /// </summary>
        /// <value>Processing situation of the invoice</value>
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
        /// Processing situation of the invoice
        /// </summary>
        /// <value>Processing situation of the invoice</value>
        [DataMember(Name="situacaoProcessamento", EmitDefaultValue=false)]
        public SituacaoProcessamentoEnum? SituacaoProcessamento { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FaturaDetalheResponse" /> class.
        /// Initializes a new instance of the <see cref="FaturaDetalheResponse" />class.
        /// </summary>
        /// <param name="IdConta">Identification Code of the Account.</param>
        /// <param name="SituacaoProcessamento">Processing situation of the invoice.</param>
        /// <param name="PagamentoEfetuado">Effected Payment Status.</param>
        /// <param name="DataVencimentoFatura">Expiration date of the invoice.</param>
        /// <param name="DataVencimentoReal">Real expiration date of the invoice.</param>
        /// <param name="DataFechamento">Closing date of the invoice.</param>
        /// <param name="ValorTotal">Total value of the invoice.</param>
        /// <param name="ValorPagamentoMinimo">Value of the minimum payment.</param>
        /// <param name="LancamentosFaturaResponse">List the invoice launches.</param>
        /// <param name="SaldoAnterior">Value of the previous value.</param>
        /// <param name="IdBoleto">Identification Code of the Ticket.</param>

        public FaturaDetalheResponse(long? IdConta = null, SituacaoProcessamentoEnum? SituacaoProcessamento = null, bool? PagamentoEfetuado = null, string DataVencimentoFatura = null, string DataVencimentoReal = null, string DataFechamento = null, double? ValorTotal = null, double? ValorPagamentoMinimo = null, List<LancamentoFaturaResponse> LancamentosFaturaResponse = null, double? SaldoAnterior = null, long? IdBoleto = null)
        {
            this.IdConta = IdConta;
            this.SituacaoProcessamento = SituacaoProcessamento;
            this.PagamentoEfetuado = PagamentoEfetuado;
            this.DataVencimentoFatura = DataVencimentoFatura;
            this.DataVencimentoReal = DataVencimentoReal;
            this.DataFechamento = DataFechamento;
            this.ValorTotal = ValorTotal;
            this.ValorPagamentoMinimo = ValorPagamentoMinimo;
            this.LancamentosFaturaResponse = LancamentosFaturaResponse;
            this.SaldoAnterior = SaldoAnterior;
            this.IdBoleto = IdBoleto;
            
        }
        
    
        /// <summary>
        /// Identification Code of the Account
        /// </summary>
        /// <value>Identification Code of the Account</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Effected Payment Status
        /// </summary>
        /// <value>Effected Payment Status</value>
        [DataMember(Name="pagamentoEfetuado", EmitDefaultValue=false)]
        public bool? PagamentoEfetuado { get; set; }
    
        /// <summary>
        /// Expiration date of the invoice
        /// </summary>
        /// <value>Expiration date of the invoice</value>
        [DataMember(Name="dataVencimentoFatura", EmitDefaultValue=false)]
        public string DataVencimentoFatura { get; set; }
    
        /// <summary>
        /// Real expiration date of the invoice
        /// </summary>
        /// <value>Real expiration date of the invoice</value>
        [DataMember(Name="dataVencimentoReal", EmitDefaultValue=false)]
        public string DataVencimentoReal { get; set; }
    
        /// <summary>
        /// Closing date of the invoice
        /// </summary>
        /// <value>Closing date of the invoice</value>
        [DataMember(Name="dataFechamento", EmitDefaultValue=false)]
        public string DataFechamento { get; set; }
    
        /// <summary>
        /// Total value of the invoice
        /// </summary>
        /// <value>Total value of the invoice</value>
        [DataMember(Name="valorTotal", EmitDefaultValue=false)]
        public double? ValorTotal { get; set; }
    
        /// <summary>
        /// Value of the minimum payment
        /// </summary>
        /// <value>Value of the minimum payment</value>
        [DataMember(Name="valorPagamentoMinimo", EmitDefaultValue=false)]
        public double? ValorPagamentoMinimo { get; set; }
    
        /// <summary>
        /// List the invoice launches
        /// </summary>
        /// <value>List the invoice launches</value>
        [DataMember(Name="lancamentosFaturaResponse", EmitDefaultValue=false)]
        public List<LancamentoFaturaResponse> LancamentosFaturaResponse { get; set; }
    
        /// <summary>
        /// Value of the previous value
        /// </summary>
        /// <value>Value of the previous value</value>
        [DataMember(Name="saldoAnterior", EmitDefaultValue=false)]
        public double? SaldoAnterior { get; set; }
    
        /// <summary>
        /// Identification Code of the Ticket
        /// </summary>
        /// <value>Identification Code of the Ticket</value>
        [DataMember(Name="idBoleto", EmitDefaultValue=false)]
        public long? IdBoleto { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FaturaDetalheResponse {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  SituacaoProcessamento: ").Append(SituacaoProcessamento).Append("\n");
            sb.Append("  PagamentoEfetuado: ").Append(PagamentoEfetuado).Append("\n");
            sb.Append("  DataVencimentoFatura: ").Append(DataVencimentoFatura).Append("\n");
            sb.Append("  DataVencimentoReal: ").Append(DataVencimentoReal).Append("\n");
            sb.Append("  DataFechamento: ").Append(DataFechamento).Append("\n");
            sb.Append("  ValorTotal: ").Append(ValorTotal).Append("\n");
            sb.Append("  ValorPagamentoMinimo: ").Append(ValorPagamentoMinimo).Append("\n");
            sb.Append("  LancamentosFaturaResponse: ").Append(LancamentosFaturaResponse).Append("\n");
            sb.Append("  SaldoAnterior: ").Append(SaldoAnterior).Append("\n");
            sb.Append("  IdBoleto: ").Append(IdBoleto).Append("\n");
            
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
                    this.LancamentosFaturaResponse == other.LancamentosFaturaResponse ||
                    this.LancamentosFaturaResponse != null &&
                    this.LancamentosFaturaResponse.SequenceEqual(other.LancamentosFaturaResponse)
                ) && 
                (
                    this.SaldoAnterior == other.SaldoAnterior ||
                    this.SaldoAnterior != null &&
                    this.SaldoAnterior.Equals(other.SaldoAnterior)
                ) && 
                (
                    this.IdBoleto == other.IdBoleto ||
                    this.IdBoleto != null &&
                    this.IdBoleto.Equals(other.IdBoleto)
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
                
                if (this.LancamentosFaturaResponse != null)
                    hash = hash * 59 + this.LancamentosFaturaResponse.GetHashCode();
                
                if (this.SaldoAnterior != null)
                    hash = hash * 59 + this.SaldoAnterior.GetHashCode();
                
                if (this.IdBoleto != null)
                    hash = hash * 59 + this.IdBoleto.GetHashCode();
                
                return hash;
            }
        }

    }
}
