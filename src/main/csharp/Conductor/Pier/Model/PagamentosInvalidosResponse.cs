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
    /// Representa um objeto de resposta para pagamentos inv\u00E1lidos
    /// </summary>
    [DataContract]
    public partial class PagamentosInvalidosResponse :  IEquatable<PagamentosInvalidosResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PagamentosInvalidosResponse" /> class.
        /// Initializes a new instance of the <see cref="PagamentosInvalidosResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo identificador do pagamento inv\u00E1lido.</param>
        /// <param name="Banco">C\u00F3digo de identifica\u00E7\u00E3o do banco.</param>
        /// <param name="DataPagamento">Data de pagamento do boleto.</param>
        /// <param name="ValorPago">Valor pago da fatura.</param>
        /// <param name="Descricao">Descri\u00E7\u00E3o do erro ocorrido durante a importa\u00E7\u00E3o do pagamento.</param>

        public PagamentosInvalidosResponse(long? Id = null, long? Banco = null, string DataPagamento = null, double? ValorPago = null, string Descricao = null)
        {
            this.Id = Id;
            this.Banco = Banco;
            this.DataPagamento = DataPagamento;
            this.ValorPago = ValorPago;
            this.Descricao = Descricao;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo identificador do pagamento inv\u00E1lido
        /// </summary>
        /// <value>C\u00F3digo identificador do pagamento inv\u00E1lido</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do banco
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do banco</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public long? Banco { get; set; }
    
        /// <summary>
        /// Data de pagamento do boleto
        /// </summary>
        /// <value>Data de pagamento do boleto</value>
        [DataMember(Name="dataPagamento", EmitDefaultValue=false)]
        public string DataPagamento { get; set; }
    
        /// <summary>
        /// Valor pago da fatura
        /// </summary>
        /// <value>Valor pago da fatura</value>
        [DataMember(Name="valorPago", EmitDefaultValue=false)]
        public double? ValorPago { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do erro ocorrido durante a importa\u00E7\u00E3o do pagamento
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do erro ocorrido durante a importa\u00E7\u00E3o do pagamento</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PagamentosInvalidosResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Banco: ").Append(Banco).Append("\n");
            sb.Append("  DataPagamento: ").Append(DataPagamento).Append("\n");
            sb.Append("  ValorPago: ").Append(ValorPago).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            
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
            return this.Equals(obj as PagamentosInvalidosResponse);
        }

        /// <summary>
        /// Returns true if PagamentosInvalidosResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PagamentosInvalidosResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PagamentosInvalidosResponse other)
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
                    this.Banco == other.Banco ||
                    this.Banco != null &&
                    this.Banco.Equals(other.Banco)
                ) && 
                (
                    this.DataPagamento == other.DataPagamento ||
                    this.DataPagamento != null &&
                    this.DataPagamento.Equals(other.DataPagamento)
                ) && 
                (
                    this.ValorPago == other.ValorPago ||
                    this.ValorPago != null &&
                    this.ValorPago.Equals(other.ValorPago)
                ) && 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
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
                
                if (this.Banco != null)
                    hash = hash * 59 + this.Banco.GetHashCode();
                
                if (this.DataPagamento != null)
                    hash = hash * 59 + this.DataPagamento.GetHashCode();
                
                if (this.ValorPago != null)
                    hash = hash * 59 + this.ValorPago.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                return hash;
            }
        }

    }
}
