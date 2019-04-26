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
    /// 
    /// </summary>
    [DataContract]
    public partial class RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido :  IEquatable<RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido" /> class.
        /// Initializes a new instance of the <see cref="RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido" />class.
        /// </summary>
        /// <param name="IdConta">Identificador da conta de um pagamento inv\u00E1lido regularizado.</param>
        /// <param name="IdPagamento">Id do pagamento inv\u00E1lido.</param>
        /// <param name="IdPagamentoRejeitado">Identificador do pagamento inv\u00E1lido regularizado.</param>
        /// <param name="NossoNumero">N\u00FAmero do boleto de um pagamento inv\u00E1lido regularizado.</param>
        /// <param name="ValorPago">Valor pago de um boleto regularizado.</param>

        public RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido(long? IdConta = null, long? IdPagamento = null, long? IdPagamentoRejeitado = null, double? NossoNumero = null, double? ValorPago = null)
        {
            this.IdConta = IdConta;
            this.IdPagamento = IdPagamento;
            this.IdPagamentoRejeitado = IdPagamentoRejeitado;
            this.NossoNumero = NossoNumero;
            this.ValorPago = ValorPago;
            
        }
        
    
        /// <summary>
        /// Identificador da conta de um pagamento inv\u00E1lido regularizado
        /// </summary>
        /// <value>Identificador da conta de um pagamento inv\u00E1lido regularizado</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Id do pagamento inv\u00E1lido
        /// </summary>
        /// <value>Id do pagamento inv\u00E1lido</value>
        [DataMember(Name="idPagamento", EmitDefaultValue=false)]
        public long? IdPagamento { get; set; }
    
        /// <summary>
        /// Identificador do pagamento inv\u00E1lido regularizado
        /// </summary>
        /// <value>Identificador do pagamento inv\u00E1lido regularizado</value>
        [DataMember(Name="idPagamentoRejeitado", EmitDefaultValue=false)]
        public long? IdPagamentoRejeitado { get; set; }
    
        /// <summary>
        /// N\u00FAmero do boleto de um pagamento inv\u00E1lido regularizado
        /// </summary>
        /// <value>N\u00FAmero do boleto de um pagamento inv\u00E1lido regularizado</value>
        [DataMember(Name="nossoNumero", EmitDefaultValue=false)]
        public double? NossoNumero { get; set; }
    
        /// <summary>
        /// Valor pago de um boleto regularizado
        /// </summary>
        /// <value>Valor pago de um boleto regularizado</value>
        [DataMember(Name="valorPago", EmitDefaultValue=false)]
        public double? ValorPago { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdPagamento: ").Append(IdPagamento).Append("\n");
            sb.Append("  IdPagamentoRejeitado: ").Append(IdPagamentoRejeitado).Append("\n");
            sb.Append("  NossoNumero: ").Append(NossoNumero).Append("\n");
            sb.Append("  ValorPago: ").Append(ValorPago).Append("\n");
            
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
            return this.Equals(obj as RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido);
        }

        /// <summary>
        /// Returns true if RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido instances are equal
        /// </summary>
        /// <param name="other">Instance of RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepresentaUmObjetoDeRespostaParaRegularizarUmPagamentoInvlido other)
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
                    this.IdPagamentoRejeitado == other.IdPagamentoRejeitado ||
                    this.IdPagamentoRejeitado != null &&
                    this.IdPagamentoRejeitado.Equals(other.IdPagamentoRejeitado)
                ) && 
                (
                    this.NossoNumero == other.NossoNumero ||
                    this.NossoNumero != null &&
                    this.NossoNumero.Equals(other.NossoNumero)
                ) && 
                (
                    this.ValorPago == other.ValorPago ||
                    this.ValorPago != null &&
                    this.ValorPago.Equals(other.ValorPago)
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
                
                if (this.IdPagamentoRejeitado != null)
                    hash = hash * 59 + this.IdPagamentoRejeitado.GetHashCode();
                
                if (this.NossoNumero != null)
                    hash = hash * 59 + this.NossoNumero.GetHashCode();
                
                if (this.ValorPago != null)
                    hash = hash * 59 + this.ValorPago.GetHashCode();
                
                return hash;
            }
        }

    }
}
