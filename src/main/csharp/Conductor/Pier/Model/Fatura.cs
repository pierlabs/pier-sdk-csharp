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
    /// Objeto Fatura
    /// </summary>
    [DataContract]
    public partial class Fatura :  IEquatable<Fatura>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Fatura" /> class.
        /// Initializes a new instance of the <see cref="Fatura" />class.
        /// </summary>
        /// <param name="DataVencimento">Data de Vencimento da Fatura..</param>
        /// <param name="SaldoFaturaAnterior">Saldo da Fatura Anterior..</param>
        /// <param name="SaldoMulta">Saldo total da Multa lan\u00C3\u00A7ada na Fatura atual..</param>
        /// <param name="SaldoCompras">Saldo total das Compras lan\u00C3\u00A7adas na Fatura atual..</param>
        /// <param name="SaldoPagamentos">Saldo total dos Pagamentos lan\u00C3\u00A7ados na Fatura atual..</param>
        /// <param name="SaldoTarifas">Saldo total das Tarifas lan\u00C3\u00A7adas na Fatura atual..</param>
        /// <param name="SaldoDebitos">Saldo total dos D\u00C3\u00A9bitos lan\u00C3\u00A7ados na Fatura atual..</param>
        /// <param name="SaldoCreditos">Saldo total dos Cr\u00C3\u00A9dito lan\u00C3\u00A7ados na Fatura atual..</param>
        /// <param name="SaldoAtualFinal">Salto total devedor da Fatura atual..</param>
        /// <param name="ValorMinimoFatura">Valor m\u00C3\u00ADnimo para Pagamento da Fatura..</param>
        /// <param name="FlagEmiteFatura">Quando ativa, indica que fora emitida uma Fatura..</param>

        public Fatura(DateTime? DataVencimento = null, double? SaldoFaturaAnterior = null, double? SaldoMulta = null, double? SaldoCompras = null, double? SaldoPagamentos = null, double? SaldoTarifas = null, double? SaldoDebitos = null, double? SaldoCreditos = null, double? SaldoAtualFinal = null, double? ValorMinimoFatura = null, int? FlagEmiteFatura = null)
        {
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
        /// Data de Vencimento da Fatura.
        /// </summary>
        /// <value>Data de Vencimento da Fatura.</value>
        [DataMember(Name="dataVencimento", EmitDefaultValue=false)]
        public DateTime? DataVencimento { get; set; }
    
        /// <summary>
        /// Saldo da Fatura Anterior.
        /// </summary>
        /// <value>Saldo da Fatura Anterior.</value>
        [DataMember(Name="saldoFaturaAnterior", EmitDefaultValue=false)]
        public double? SaldoFaturaAnterior { get; set; }
    
        /// <summary>
        /// Saldo total da Multa lan\u00C3\u00A7ada na Fatura atual.
        /// </summary>
        /// <value>Saldo total da Multa lan\u00C3\u00A7ada na Fatura atual.</value>
        [DataMember(Name="saldoMulta", EmitDefaultValue=false)]
        public double? SaldoMulta { get; set; }
    
        /// <summary>
        /// Saldo total das Compras lan\u00C3\u00A7adas na Fatura atual.
        /// </summary>
        /// <value>Saldo total das Compras lan\u00C3\u00A7adas na Fatura atual.</value>
        [DataMember(Name="saldoCompras", EmitDefaultValue=false)]
        public double? SaldoCompras { get; set; }
    
        /// <summary>
        /// Saldo total dos Pagamentos lan\u00C3\u00A7ados na Fatura atual.
        /// </summary>
        /// <value>Saldo total dos Pagamentos lan\u00C3\u00A7ados na Fatura atual.</value>
        [DataMember(Name="saldoPagamentos", EmitDefaultValue=false)]
        public double? SaldoPagamentos { get; set; }
    
        /// <summary>
        /// Saldo total das Tarifas lan\u00C3\u00A7adas na Fatura atual.
        /// </summary>
        /// <value>Saldo total das Tarifas lan\u00C3\u00A7adas na Fatura atual.</value>
        [DataMember(Name="saldoTarifas", EmitDefaultValue=false)]
        public double? SaldoTarifas { get; set; }
    
        /// <summary>
        /// Saldo total dos D\u00C3\u00A9bitos lan\u00C3\u00A7ados na Fatura atual.
        /// </summary>
        /// <value>Saldo total dos D\u00C3\u00A9bitos lan\u00C3\u00A7ados na Fatura atual.</value>
        [DataMember(Name="saldoDebitos", EmitDefaultValue=false)]
        public double? SaldoDebitos { get; set; }
    
        /// <summary>
        /// Saldo total dos Cr\u00C3\u00A9dito lan\u00C3\u00A7ados na Fatura atual.
        /// </summary>
        /// <value>Saldo total dos Cr\u00C3\u00A9dito lan\u00C3\u00A7ados na Fatura atual.</value>
        [DataMember(Name="saldoCreditos", EmitDefaultValue=false)]
        public double? SaldoCreditos { get; set; }
    
        /// <summary>
        /// Salto total devedor da Fatura atual.
        /// </summary>
        /// <value>Salto total devedor da Fatura atual.</value>
        [DataMember(Name="saldoAtualFinal", EmitDefaultValue=false)]
        public double? SaldoAtualFinal { get; set; }
    
        /// <summary>
        /// Valor m\u00C3\u00ADnimo para Pagamento da Fatura.
        /// </summary>
        /// <value>Valor m\u00C3\u00ADnimo para Pagamento da Fatura.</value>
        [DataMember(Name="valorMinimoFatura", EmitDefaultValue=false)]
        public double? ValorMinimoFatura { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que fora emitida uma Fatura.
        /// </summary>
        /// <value>Quando ativa, indica que fora emitida uma Fatura.</value>
        [DataMember(Name="flagEmiteFatura", EmitDefaultValue=false)]
        public int? FlagEmiteFatura { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Fatura {\n");
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
            return this.Equals(obj as Fatura);
        }

        /// <summary>
        /// Returns true if Fatura instances are equal
        /// </summary>
        /// <param name="other">Instance of Fatura to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Fatura other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
