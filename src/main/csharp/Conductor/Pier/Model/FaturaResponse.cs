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
    public partial class FaturaResponse :  IEquatable<FaturaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FaturaResponse" /> class.
        /// Initializes a new instance of the <see cref="FaturaResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo identificador da fatura..</param>
        /// <param name="IdConta">C\u00C3\u00B3digo identificador da conta..</param>
        /// <param name="IdProduto">C\u00C3\u00B3digo identificador do produto..</param>
        /// <param name="DataVencimento">Data de vencimento da fatura..</param>
        /// <param name="SaldoFaturaAnterior">Saldo da fatura anterior..</param>
        /// <param name="SaldoMulta">Saldo total da Multa lan\u00C3\u00A7ada na Fatura atual..</param>
        /// <param name="SaldoCompras">Saldo total das compras lan\u00C3\u00A7adas na fatura atual..</param>
        /// <param name="SaldoPagamentos">Saldo total dos pagamentos lan\u00C3\u00A7ados na fatura atual..</param>
        /// <param name="SaldoTarifas">Saldo total das tarifas lan\u00C3\u00A7adas na fatura atual..</param>
        /// <param name="SaldoDebitos">Saldo total dos d\u00C3\u00A9bitos lan\u00C3\u00A7ados na fatura atual..</param>
        /// <param name="SaldoCreditos">Saldo total dos cr\u00C3\u00A9dito lan\u00C3\u00A7ados na fatura atual..</param>
        /// <param name="SaldoAtualFinal">Salto total devedor da fatura atual..</param>
        /// <param name="ValorMinimoFatura">Valor m\u00C3\u00ADnimo para pagamento da fatura..</param>
        /// <param name="FlagEmiteFatura">Quando ativa, indica que fora emitida uma fatura..</param>

        public FaturaResponse(long? Id = null, long? IdConta = null, long? IdProduto = null, DateTime? DataVencimento = null, double? SaldoFaturaAnterior = null, double? SaldoMulta = null, double? SaldoCompras = null, double? SaldoPagamentos = null, double? SaldoTarifas = null, double? SaldoDebitos = null, double? SaldoCreditos = null, double? SaldoAtualFinal = null, double? ValorMinimoFatura = null, int? FlagEmiteFatura = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.IdProduto = IdProduto;
            this.DataVencimento = DataVencimento;
            this.SaldoFaturaAnterior = SaldoFaturaAnterior;
            this.SaldoMulta = SaldoMulta;
            this.SaldoCompras = SaldoCompras;
            this.SaldoPagamentos = SaldoPagamentos;
            this.SaldoTarifas = SaldoTarifas;
            this.SaldoDebitos = SaldoDebitos;
            this.SaldoCreditos = SaldoCreditos;
            this.SaldoAtualFinal = SaldoAtualFinal;
            this.ValorMinimoFatura = ValorMinimoFatura;
            this.FlagEmiteFatura = FlagEmiteFatura;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador da fatura.
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador da fatura.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador da conta.
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador da conta.</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador do produto.
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador do produto.</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Data de vencimento da fatura.
        /// </summary>
        /// <value>Data de vencimento da fatura.</value>
        [DataMember(Name="dataVencimento", EmitDefaultValue=false)]
        public DateTime? DataVencimento { get; set; }
    
        /// <summary>
        /// Saldo da fatura anterior.
        /// </summary>
        /// <value>Saldo da fatura anterior.</value>
        [DataMember(Name="saldoFaturaAnterior", EmitDefaultValue=false)]
        public double? SaldoFaturaAnterior { get; set; }
    
        /// <summary>
        /// Saldo total da Multa lan\u00C3\u00A7ada na Fatura atual.
        /// </summary>
        /// <value>Saldo total da Multa lan\u00C3\u00A7ada na Fatura atual.</value>
        [DataMember(Name="saldoMulta", EmitDefaultValue=false)]
        public double? SaldoMulta { get; set; }
    
        /// <summary>
        /// Saldo total das compras lan\u00C3\u00A7adas na fatura atual.
        /// </summary>
        /// <value>Saldo total das compras lan\u00C3\u00A7adas na fatura atual.</value>
        [DataMember(Name="saldoCompras", EmitDefaultValue=false)]
        public double? SaldoCompras { get; set; }
    
        /// <summary>
        /// Saldo total dos pagamentos lan\u00C3\u00A7ados na fatura atual.
        /// </summary>
        /// <value>Saldo total dos pagamentos lan\u00C3\u00A7ados na fatura atual.</value>
        [DataMember(Name="saldoPagamentos", EmitDefaultValue=false)]
        public double? SaldoPagamentos { get; set; }
    
        /// <summary>
        /// Saldo total das tarifas lan\u00C3\u00A7adas na fatura atual.
        /// </summary>
        /// <value>Saldo total das tarifas lan\u00C3\u00A7adas na fatura atual.</value>
        [DataMember(Name="saldoTarifas", EmitDefaultValue=false)]
        public double? SaldoTarifas { get; set; }
    
        /// <summary>
        /// Saldo total dos d\u00C3\u00A9bitos lan\u00C3\u00A7ados na fatura atual.
        /// </summary>
        /// <value>Saldo total dos d\u00C3\u00A9bitos lan\u00C3\u00A7ados na fatura atual.</value>
        [DataMember(Name="saldoDebitos", EmitDefaultValue=false)]
        public double? SaldoDebitos { get; set; }
    
        /// <summary>
        /// Saldo total dos cr\u00C3\u00A9dito lan\u00C3\u00A7ados na fatura atual.
        /// </summary>
        /// <value>Saldo total dos cr\u00C3\u00A9dito lan\u00C3\u00A7ados na fatura atual.</value>
        [DataMember(Name="saldoCreditos", EmitDefaultValue=false)]
        public double? SaldoCreditos { get; set; }
    
        /// <summary>
        /// Salto total devedor da fatura atual.
        /// </summary>
        /// <value>Salto total devedor da fatura atual.</value>
        [DataMember(Name="saldoAtualFinal", EmitDefaultValue=false)]
        public double? SaldoAtualFinal { get; set; }
    
        /// <summary>
        /// Valor m\u00C3\u00ADnimo para pagamento da fatura.
        /// </summary>
        /// <value>Valor m\u00C3\u00ADnimo para pagamento da fatura.</value>
        [DataMember(Name="valorMinimoFatura", EmitDefaultValue=false)]
        public double? ValorMinimoFatura { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que fora emitida uma fatura.
        /// </summary>
        /// <value>Quando ativa, indica que fora emitida uma fatura.</value>
        [DataMember(Name="flagEmiteFatura", EmitDefaultValue=false)]
        public int? FlagEmiteFatura { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FaturaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  DataVencimento: ").Append(DataVencimento).Append("\n");
            sb.Append("  SaldoFaturaAnterior: ").Append(SaldoFaturaAnterior).Append("\n");
            sb.Append("  SaldoMulta: ").Append(SaldoMulta).Append("\n");
            sb.Append("  SaldoCompras: ").Append(SaldoCompras).Append("\n");
            sb.Append("  SaldoPagamentos: ").Append(SaldoPagamentos).Append("\n");
            sb.Append("  SaldoTarifas: ").Append(SaldoTarifas).Append("\n");
            sb.Append("  SaldoDebitos: ").Append(SaldoDebitos).Append("\n");
            sb.Append("  SaldoCreditos: ").Append(SaldoCreditos).Append("\n");
            sb.Append("  SaldoAtualFinal: ").Append(SaldoAtualFinal).Append("\n");
            sb.Append("  ValorMinimoFatura: ").Append(ValorMinimoFatura).Append("\n");
            sb.Append("  FlagEmiteFatura: ").Append(FlagEmiteFatura).Append("\n");
            
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
            return this.Equals(obj as FaturaResponse);
        }

        /// <summary>
        /// Returns true if FaturaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of FaturaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FaturaResponse other)
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
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.DataVencimento == other.DataVencimento ||
                    this.DataVencimento != null &&
                    this.DataVencimento.Equals(other.DataVencimento)
                ) && 
                (
                    this.SaldoFaturaAnterior == other.SaldoFaturaAnterior ||
                    this.SaldoFaturaAnterior != null &&
                    this.SaldoFaturaAnterior.Equals(other.SaldoFaturaAnterior)
                ) && 
                (
                    this.SaldoMulta == other.SaldoMulta ||
                    this.SaldoMulta != null &&
                    this.SaldoMulta.Equals(other.SaldoMulta)
                ) && 
                (
                    this.SaldoCompras == other.SaldoCompras ||
                    this.SaldoCompras != null &&
                    this.SaldoCompras.Equals(other.SaldoCompras)
                ) && 
                (
                    this.SaldoPagamentos == other.SaldoPagamentos ||
                    this.SaldoPagamentos != null &&
                    this.SaldoPagamentos.Equals(other.SaldoPagamentos)
                ) && 
                (
                    this.SaldoTarifas == other.SaldoTarifas ||
                    this.SaldoTarifas != null &&
                    this.SaldoTarifas.Equals(other.SaldoTarifas)
                ) && 
                (
                    this.SaldoDebitos == other.SaldoDebitos ||
                    this.SaldoDebitos != null &&
                    this.SaldoDebitos.Equals(other.SaldoDebitos)
                ) && 
                (
                    this.SaldoCreditos == other.SaldoCreditos ||
                    this.SaldoCreditos != null &&
                    this.SaldoCreditos.Equals(other.SaldoCreditos)
                ) && 
                (
                    this.SaldoAtualFinal == other.SaldoAtualFinal ||
                    this.SaldoAtualFinal != null &&
                    this.SaldoAtualFinal.Equals(other.SaldoAtualFinal)
                ) && 
                (
                    this.ValorMinimoFatura == other.ValorMinimoFatura ||
                    this.ValorMinimoFatura != null &&
                    this.ValorMinimoFatura.Equals(other.ValorMinimoFatura)
                ) && 
                (
                    this.FlagEmiteFatura == other.FlagEmiteFatura ||
                    this.FlagEmiteFatura != null &&
                    this.FlagEmiteFatura.Equals(other.FlagEmiteFatura)
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
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.DataVencimento != null)
                    hash = hash * 59 + this.DataVencimento.GetHashCode();
                
                if (this.SaldoFaturaAnterior != null)
                    hash = hash * 59 + this.SaldoFaturaAnterior.GetHashCode();
                
                if (this.SaldoMulta != null)
                    hash = hash * 59 + this.SaldoMulta.GetHashCode();
                
                if (this.SaldoCompras != null)
                    hash = hash * 59 + this.SaldoCompras.GetHashCode();
                
                if (this.SaldoPagamentos != null)
                    hash = hash * 59 + this.SaldoPagamentos.GetHashCode();
                
                if (this.SaldoTarifas != null)
                    hash = hash * 59 + this.SaldoTarifas.GetHashCode();
                
                if (this.SaldoDebitos != null)
                    hash = hash * 59 + this.SaldoDebitos.GetHashCode();
                
                if (this.SaldoCreditos != null)
                    hash = hash * 59 + this.SaldoCreditos.GetHashCode();
                
                if (this.SaldoAtualFinal != null)
                    hash = hash * 59 + this.SaldoAtualFinal.GetHashCode();
                
                if (this.ValorMinimoFatura != null)
                    hash = hash * 59 + this.ValorMinimoFatura.GetHashCode();
                
                if (this.FlagEmiteFatura != null)
                    hash = hash * 59 + this.FlagEmiteFatura.GetHashCode();
                
                return hash;
            }
        }

    }
}
