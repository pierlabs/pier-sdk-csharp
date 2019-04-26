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
    /// Objeto a ser persistido de pagamento inv\u00E1lido
    /// </summary>
    [DataContract]
    public partial class RegularizacaoPagamentoPersist :  IEquatable<RegularizacaoPagamentoPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RegularizacaoPagamentoPersist" /> class.
        /// Initializes a new instance of the <see cref="RegularizacaoPagamentoPersist" />class.
        /// </summary>
        /// <param name="IdConta">Identificador da conta cadastrada na base ap\u00F3s regularizar um pagamento inv\u00E1lido.</param>
        /// <param name="NossoNumero">N\u00FAmero do boleto do pagamento inv\u00E1lido.</param>
        /// <param name="ValorPago">Valor do boleto do pagamento inv\u00E1lido.</param>

        public RegularizacaoPagamentoPersist(long? IdConta = null, double? NossoNumero = null, double? ValorPago = null)
        {
            this.IdConta = IdConta;
            this.NossoNumero = NossoNumero;
            this.ValorPago = ValorPago;
            
        }
        
    
        /// <summary>
        /// Identificador da conta cadastrada na base ap\u00F3s regularizar um pagamento inv\u00E1lido
        /// </summary>
        /// <value>Identificador da conta cadastrada na base ap\u00F3s regularizar um pagamento inv\u00E1lido</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// N\u00FAmero do boleto do pagamento inv\u00E1lido
        /// </summary>
        /// <value>N\u00FAmero do boleto do pagamento inv\u00E1lido</value>
        [DataMember(Name="nossoNumero", EmitDefaultValue=false)]
        public double? NossoNumero { get; set; }
    
        /// <summary>
        /// Valor do boleto do pagamento inv\u00E1lido
        /// </summary>
        /// <value>Valor do boleto do pagamento inv\u00E1lido</value>
        [DataMember(Name="valorPago", EmitDefaultValue=false)]
        public double? ValorPago { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegularizacaoPagamentoPersist {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
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
            return this.Equals(obj as RegularizacaoPagamentoPersist);
        }

        /// <summary>
        /// Returns true if RegularizacaoPagamentoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of RegularizacaoPagamentoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegularizacaoPagamentoPersist other)
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
                
                if (this.NossoNumero != null)
                    hash = hash * 59 + this.NossoNumero.GetHashCode();
                
                if (this.ValorPago != null)
                    hash = hash * 59 + this.ValorPago.GetHashCode();
                
                return hash;
            }
        }

    }
}
