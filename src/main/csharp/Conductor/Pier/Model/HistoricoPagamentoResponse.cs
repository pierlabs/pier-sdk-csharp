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
    /// Object HistoricPaymentResponse
    /// </summary>
    [DataContract]
    public partial class HistoricoPagamentoResponse :  IEquatable<HistoricoPagamentoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricoPagamentoResponse" /> class.
        /// Initializes a new instance of the <see cref="HistoricoPagamentoResponse" />class.
        /// </summary>
        /// <param name="IdConta">Identification Code of the Account.</param>
        /// <param name="IdPagamento">Identification Code of the Payment.</param>
        /// <param name="IdEstabelecimento">Identification code of the Merchant where the Payment was made, when it is the place of the payment.</param>
        /// <param name="IdBanco">Identification Code of the Banking Institution where the payment was made, when it is the place of the payment.</param>
        /// <param name="IdCartao">Identification Code of the Card.</param>
        /// <param name="ValorPagamento">Value of the Payment.</param>
        /// <param name="DataHoraPagamento">Date and time of the payment. When it is made in a Banking Institution, the payment time is displayed with zero value.</param>
        /// <param name="DataHoraEntradaPagamento">Date and time which the Payment register was created.</param>
        /// <param name="Status">Identification Code of the Payment Status.</param>

        public HistoricoPagamentoResponse(long? IdConta = null, long? IdPagamento = null, long? IdEstabelecimento = null, long? IdBanco = null, long? IdCartao = null, double? ValorPagamento = null, string DataHoraPagamento = null, string DataHoraEntradaPagamento = null, long? Status = null)
        {
            this.IdConta = IdConta;
            this.IdPagamento = IdPagamento;
            this.IdEstabelecimento = IdEstabelecimento;
            this.IdBanco = IdBanco;
            this.IdCartao = IdCartao;
            this.ValorPagamento = ValorPagamento;
            this.DataHoraPagamento = DataHoraPagamento;
            this.DataHoraEntradaPagamento = DataHoraEntradaPagamento;
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// Identification Code of the Account
        /// </summary>
        /// <value>Identification Code of the Account</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identification Code of the Payment
        /// </summary>
        /// <value>Identification Code of the Payment</value>
        [DataMember(Name="idPagamento", EmitDefaultValue=false)]
        public long? IdPagamento { get; set; }
    
        /// <summary>
        /// Identification code of the Merchant where the Payment was made, when it is the place of the payment
        /// </summary>
        /// <value>Identification code of the Merchant where the Payment was made, when it is the place of the payment</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// Identification Code of the Banking Institution where the payment was made, when it is the place of the payment
        /// </summary>
        /// <value>Identification Code of the Banking Institution where the payment was made, when it is the place of the payment</value>
        [DataMember(Name="idBanco", EmitDefaultValue=false)]
        public long? IdBanco { get; set; }
    
        /// <summary>
        /// Identification Code of the Card
        /// </summary>
        /// <value>Identification Code of the Card</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Value of the Payment
        /// </summary>
        /// <value>Value of the Payment</value>
        [DataMember(Name="valorPagamento", EmitDefaultValue=false)]
        public double? ValorPagamento { get; set; }
    
        /// <summary>
        /// Date and time of the payment. When it is made in a Banking Institution, the payment time is displayed with zero value
        /// </summary>
        /// <value>Date and time of the payment. When it is made in a Banking Institution, the payment time is displayed with zero value</value>
        [DataMember(Name="dataHoraPagamento", EmitDefaultValue=false)]
        public string DataHoraPagamento { get; set; }
    
        /// <summary>
        /// Date and time which the Payment register was created
        /// </summary>
        /// <value>Date and time which the Payment register was created</value>
        [DataMember(Name="dataHoraEntradaPagamento", EmitDefaultValue=false)]
        public string DataHoraEntradaPagamento { get; set; }
    
        /// <summary>
        /// Identification Code of the Payment Status
        /// </summary>
        /// <value>Identification Code of the Payment Status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public long? Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricoPagamentoResponse {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdPagamento: ").Append(IdPagamento).Append("\n");
            sb.Append("  IdEstabelecimento: ").Append(IdEstabelecimento).Append("\n");
            sb.Append("  IdBanco: ").Append(IdBanco).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  ValorPagamento: ").Append(ValorPagamento).Append("\n");
            sb.Append("  DataHoraPagamento: ").Append(DataHoraPagamento).Append("\n");
            sb.Append("  DataHoraEntradaPagamento: ").Append(DataHoraEntradaPagamento).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            
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
            return this.Equals(obj as HistoricoPagamentoResponse);
        }

        /// <summary>
        /// Returns true if HistoricoPagamentoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of HistoricoPagamentoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricoPagamentoResponse other)
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
                    this.IdPagamento == other.IdPagamento ||
                    this.IdPagamento != null &&
                    this.IdPagamento.Equals(other.IdPagamento)
                ) && 
                (
                    this.IdEstabelecimento == other.IdEstabelecimento ||
                    this.IdEstabelecimento != null &&
                    this.IdEstabelecimento.Equals(other.IdEstabelecimento)
                ) && 
                (
                    this.IdBanco == other.IdBanco ||
                    this.IdBanco != null &&
                    this.IdBanco.Equals(other.IdBanco)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.ValorPagamento == other.ValorPagamento ||
                    this.ValorPagamento != null &&
                    this.ValorPagamento.Equals(other.ValorPagamento)
                ) && 
                (
                    this.DataHoraPagamento == other.DataHoraPagamento ||
                    this.DataHoraPagamento != null &&
                    this.DataHoraPagamento.Equals(other.DataHoraPagamento)
                ) && 
                (
                    this.DataHoraEntradaPagamento == other.DataHoraEntradaPagamento ||
                    this.DataHoraEntradaPagamento != null &&
                    this.DataHoraEntradaPagamento.Equals(other.DataHoraEntradaPagamento)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.IdPagamento != null)
                    hash = hash * 59 + this.IdPagamento.GetHashCode();
                
                if (this.IdEstabelecimento != null)
                    hash = hash * 59 + this.IdEstabelecimento.GetHashCode();
                
                if (this.IdBanco != null)
                    hash = hash * 59 + this.IdBanco.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.ValorPagamento != null)
                    hash = hash * 59 + this.ValorPagamento.GetHashCode();
                
                if (this.DataHoraPagamento != null)
                    hash = hash * 59 + this.DataHoraPagamento.GetHashCode();
                
                if (this.DataHoraEntradaPagamento != null)
                    hash = hash * 59 + this.DataHoraEntradaPagamento.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
