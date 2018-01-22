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
    /// Transfer\u00C3\u00AAncia cr\u00C3\u00A9dito conta banc\u00C3\u00A1ria request
    /// </summary>
    [DataContract]
    public partial class PlanoParcelamentoTransferenciaCreditoContaBancariaRequest :  IEquatable<PlanoParcelamentoTransferenciaCreditoContaBancariaRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanoParcelamentoTransferenciaCreditoContaBancariaRequest" /> class.
        /// Initializes a new instance of the <see cref="PlanoParcelamentoTransferenciaCreditoContaBancariaRequest" />class.
        /// </summary>
        /// <param name="IdCartao">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o. (required).</param>
        /// <param name="ValorTransacao">Valor da transa\u00C3\u00A7\u00C3\u00A3o com duas casas decimais para os centavos. (required).</param>
        /// <param name="NumeroMesesCarencia">Representa o N\u00C3\u00BAmero de Meses concedido como car\u00C3\u00AAncia. (required).</param>

        public PlanoParcelamentoTransferenciaCreditoContaBancariaRequest(long? IdCartao = null, double? ValorTransacao = null, int? NumeroMesesCarencia = null)
        {
            // to ensure "IdCartao" is required (not null)
            if (IdCartao == null)
            {
                throw new InvalidDataException("IdCartao is a required property for PlanoParcelamentoTransferenciaCreditoContaBancariaRequest and cannot be null");
            }
            else
            {
                this.IdCartao = IdCartao;
            }
            // to ensure "ValorTransacao" is required (not null)
            if (ValorTransacao == null)
            {
                throw new InvalidDataException("ValorTransacao is a required property for PlanoParcelamentoTransferenciaCreditoContaBancariaRequest and cannot be null");
            }
            else
            {
                this.ValorTransacao = ValorTransacao;
            }
            // to ensure "NumeroMesesCarencia" is required (not null)
            if (NumeroMesesCarencia == null)
            {
                throw new InvalidDataException("NumeroMesesCarencia is a required property for PlanoParcelamentoTransferenciaCreditoContaBancariaRequest and cannot be null");
            }
            else
            {
                this.NumeroMesesCarencia = NumeroMesesCarencia;
            }
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o.</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Valor da transa\u00C3\u00A7\u00C3\u00A3o com duas casas decimais para os centavos.
        /// </summary>
        /// <value>Valor da transa\u00C3\u00A7\u00C3\u00A3o com duas casas decimais para os centavos.</value>
        [DataMember(Name="valorTransacao", EmitDefaultValue=false)]
        public double? ValorTransacao { get; set; }
    
        /// <summary>
        /// Representa o N\u00C3\u00BAmero de Meses concedido como car\u00C3\u00AAncia.
        /// </summary>
        /// <value>Representa o N\u00C3\u00BAmero de Meses concedido como car\u00C3\u00AAncia.</value>
        [DataMember(Name="numeroMesesCarencia", EmitDefaultValue=false)]
        public int? NumeroMesesCarencia { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlanoParcelamentoTransferenciaCreditoContaBancariaRequest {\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  ValorTransacao: ").Append(ValorTransacao).Append("\n");
            sb.Append("  NumeroMesesCarencia: ").Append(NumeroMesesCarencia).Append("\n");
            
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
            return this.Equals(obj as PlanoParcelamentoTransferenciaCreditoContaBancariaRequest);
        }

        /// <summary>
        /// Returns true if PlanoParcelamentoTransferenciaCreditoContaBancariaRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PlanoParcelamentoTransferenciaCreditoContaBancariaRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanoParcelamentoTransferenciaCreditoContaBancariaRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.ValorTransacao == other.ValorTransacao ||
                    this.ValorTransacao != null &&
                    this.ValorTransacao.Equals(other.ValorTransacao)
                ) && 
                (
                    this.NumeroMesesCarencia == other.NumeroMesesCarencia ||
                    this.NumeroMesesCarencia != null &&
                    this.NumeroMesesCarencia.Equals(other.NumeroMesesCarencia)
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
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.ValorTransacao != null)
                    hash = hash * 59 + this.ValorTransacao.GetHashCode();
                
                if (this.NumeroMesesCarencia != null)
                    hash = hash * 59 + this.NumeroMesesCarencia.GetHashCode();
                
                return hash;
            }
        }

    }
}
