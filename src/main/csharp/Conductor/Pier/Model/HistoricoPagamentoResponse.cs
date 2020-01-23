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
    /// Objeto HistoricoPagamentoResponse
    /// </summary>
    [DataContract]
    public partial class HistoricoPagamentoResponse :  IEquatable<HistoricoPagamentoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricoPagamentoResponse" /> class.
        /// Initializes a new instance of the <see cref="HistoricoPagamentoResponse" />class.
        /// </summary>
        /// <param name="IdConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta.</param>
        /// <param name="IdPagamento">C\u00F3digo de Identifica\u00E7\u00E3o do Pagamento.</param>
        /// <param name="IdEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento onde o Pagamento foi realizado, quando este for o local de pagamento.</param>
        /// <param name="IdBanco">C\u00F3digo de Identifica\u00E7\u00E3o da Institui\u00E7\u00E3o Banc\u00E1ria onde o Pagamento foi realizado, quando este for o local de pagamento.</param>
        /// <param name="IdCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o.</param>
        /// <param name="ValorPagamento">Valor do Pagamento.</param>
        /// <param name="DataHoraPagamento">Data e Hora da realiza\u00E7\u00E3o do Pagamento. Quando feito em Institui\u00E7\u00E3o Banc\u00E1ria, o hor\u00E1rio do pagamento \u00E9 exibido com valor zero.</param>
        /// <param name="DataHoraEntradaPagamento">Data e Hora em que o registro do Pagamento foi cadastrado.</param>
        /// <param name="Status">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Pagamento.</param>
        /// <param name="NossoNumero">C\u00F3digo de Identifica\u00E7\u00E3o do nosso n\u00FAmero.</param>

        public HistoricoPagamentoResponse(long? IdConta = null, long? IdPagamento = null, long? IdEstabelecimento = null, long? IdBanco = null, long? IdCartao = null, double? ValorPagamento = null, string DataHoraPagamento = null, string DataHoraEntradaPagamento = null, long? Status = null, long? NossoNumero = null)
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
            this.NossoNumero = NossoNumero;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Conta
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Pagamento
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Pagamento</value>
        [DataMember(Name="idPagamento", EmitDefaultValue=false)]
        public long? IdPagamento { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento onde o Pagamento foi realizado, quando este for o local de pagamento
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento onde o Pagamento foi realizado, quando este for o local de pagamento</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Institui\u00E7\u00E3o Banc\u00E1ria onde o Pagamento foi realizado, quando este for o local de pagamento
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Institui\u00E7\u00E3o Banc\u00E1ria onde o Pagamento foi realizado, quando este for o local de pagamento</value>
        [DataMember(Name="idBanco", EmitDefaultValue=false)]
        public long? IdBanco { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Valor do Pagamento
        /// </summary>
        /// <value>Valor do Pagamento</value>
        [DataMember(Name="valorPagamento", EmitDefaultValue=false)]
        public double? ValorPagamento { get; set; }
    
        /// <summary>
        /// Data e Hora da realiza\u00E7\u00E3o do Pagamento. Quando feito em Institui\u00E7\u00E3o Banc\u00E1ria, o hor\u00E1rio do pagamento \u00E9 exibido com valor zero
        /// </summary>
        /// <value>Data e Hora da realiza\u00E7\u00E3o do Pagamento. Quando feito em Institui\u00E7\u00E3o Banc\u00E1ria, o hor\u00E1rio do pagamento \u00E9 exibido com valor zero</value>
        [DataMember(Name="dataHoraPagamento", EmitDefaultValue=false)]
        public string DataHoraPagamento { get; set; }
    
        /// <summary>
        /// Data e Hora em que o registro do Pagamento foi cadastrado
        /// </summary>
        /// <value>Data e Hora em que o registro do Pagamento foi cadastrado</value>
        [DataMember(Name="dataHoraEntradaPagamento", EmitDefaultValue=false)]
        public string DataHoraEntradaPagamento { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Status do Pagamento
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Status do Pagamento</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public long? Status { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do nosso n\u00FAmero
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do nosso n\u00FAmero</value>
        [DataMember(Name="nossoNumero", EmitDefaultValue=false)]
        public long? NossoNumero { get; set; }
    
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
            sb.Append("  NossoNumero: ").Append(NossoNumero).Append("\n");
            
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
                ) && 
                (
                    this.NossoNumero == other.NossoNumero ||
                    this.NossoNumero != null &&
                    this.NossoNumero.Equals(other.NossoNumero)
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
                
                if (this.NossoNumero != null)
                    hash = hash * 59 + this.NossoNumero.GetHashCode();
                
                return hash;
            }
        }

    }
}
