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
    /// Fatura
    /// </summary>
    [DataContract]
    public partial class FaturaAbertaResponse :  IEquatable<FaturaAbertaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FaturaAbertaResponse" /> class.
        /// Initializes a new instance of the <see cref="FaturaAbertaResponse" />class.
        /// </summary>
        /// <param name="IdConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta.</param>
        /// <param name="DataVencimentoFatura">Apresenta a data de vencimento da fatura em formato AAAA-MM-DD.</param>
        /// <param name="DataVencimentoReal">Quando a data de vencimento da fatura n\u00E3o for em um dia \u00FAtil, este campo apresentar\u00E1 o pr\u00F3ximo dia \u00FAtil ap\u00F3s o vencimento em formato AAAA-MM-DD.</param>
        /// <param name="DataFechamento">Data de corte da fatura.</param>
        /// <param name="ValorTotal">Apresenta o valor total da fatura no momento da consulta.</param>
        /// <param name="SaldoAnterior">Apresenta o valor da fatura anterior.</param>

        public FaturaAbertaResponse(long? IdConta = null, string DataVencimentoFatura = null, string DataVencimentoReal = null, string DataFechamento = null, double? ValorTotal = null, double? SaldoAnterior = null)
        {
            this.IdConta = IdConta;
            this.DataVencimentoFatura = DataVencimentoFatura;
            this.DataVencimentoReal = DataVencimentoReal;
            this.DataFechamento = DataFechamento;
            this.ValorTotal = ValorTotal;
            this.SaldoAnterior = SaldoAnterior;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da Conta
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da Conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Apresenta a data de vencimento da fatura em formato AAAA-MM-DD
        /// </summary>
        /// <value>Apresenta a data de vencimento da fatura em formato AAAA-MM-DD</value>
        [DataMember(Name="dataVencimentoFatura", EmitDefaultValue=false)]
        public string DataVencimentoFatura { get; set; }
    
        /// <summary>
        /// Quando a data de vencimento da fatura n\u00E3o for em um dia \u00FAtil, este campo apresentar\u00E1 o pr\u00F3ximo dia \u00FAtil ap\u00F3s o vencimento em formato AAAA-MM-DD
        /// </summary>
        /// <value>Quando a data de vencimento da fatura n\u00E3o for em um dia \u00FAtil, este campo apresentar\u00E1 o pr\u00F3ximo dia \u00FAtil ap\u00F3s o vencimento em formato AAAA-MM-DD</value>
        [DataMember(Name="dataVencimentoReal", EmitDefaultValue=false)]
        public string DataVencimentoReal { get; set; }
    
        /// <summary>
        /// Data de corte da fatura
        /// </summary>
        /// <value>Data de corte da fatura</value>
        [DataMember(Name="dataFechamento", EmitDefaultValue=false)]
        public string DataFechamento { get; set; }
    
        /// <summary>
        /// Apresenta o valor total da fatura no momento da consulta
        /// </summary>
        /// <value>Apresenta o valor total da fatura no momento da consulta</value>
        [DataMember(Name="valorTotal", EmitDefaultValue=false)]
        public double? ValorTotal { get; set; }
    
        /// <summary>
        /// Apresenta o valor da fatura anterior
        /// </summary>
        /// <value>Apresenta o valor da fatura anterior</value>
        [DataMember(Name="saldoAnterior", EmitDefaultValue=false)]
        public double? SaldoAnterior { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FaturaAbertaResponse {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  DataVencimentoFatura: ").Append(DataVencimentoFatura).Append("\n");
            sb.Append("  DataVencimentoReal: ").Append(DataVencimentoReal).Append("\n");
            sb.Append("  DataFechamento: ").Append(DataFechamento).Append("\n");
            sb.Append("  ValorTotal: ").Append(ValorTotal).Append("\n");
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
            return this.Equals(obj as FaturaAbertaResponse);
        }

        /// <summary>
        /// Returns true if FaturaAbertaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of FaturaAbertaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FaturaAbertaResponse other)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.DataVencimentoFatura != null)
                    hash = hash * 59 + this.DataVencimentoFatura.GetHashCode();
                
                if (this.DataVencimentoReal != null)
                    hash = hash * 59 + this.DataVencimentoReal.GetHashCode();
                
                if (this.DataFechamento != null)
                    hash = hash * 59 + this.DataFechamento.GetHashCode();
                
                if (this.ValorTotal != null)
                    hash = hash * 59 + this.ValorTotal.GetHashCode();
                
                if (this.SaldoAnterior != null)
                    hash = hash * 59 + this.SaldoAnterior.GetHashCode();
                
                return hash;
            }
        }

    }
}
