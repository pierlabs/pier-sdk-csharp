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
    /// Response Representation of the operation resource
    /// </summary>
    [DataContract]
    public partial class OperacaoResponse :  IEquatable<OperacaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OperacaoResponse" /> class.
        /// Initializes a new instance of the <see cref="OperacaoResponse" />class.
        /// </summary>
        /// <param name="IdOperacao">Code that identifies the operation.</param>
        /// <param name="CodigoProcessamento">Processing Code used in transaction with the authorizer.</param>
        /// <param name="CodigoProcessamentoCancelamento">Processing Code used to cancel transactions in the authorizer.</param>
        /// <param name="NomeOperacao">Operation name.</param>
        /// <param name="FlagCobraJuros">Flag indicative for the charge of interest.</param>
        /// <param name="FlagCobraTarifa">Flag indicative for the charge of taxes.</param>
        /// <param name="Carencia">Quantity of months for the Lack.</param>
        /// <param name="FlagPermitirParcelamento">Allow parceled transactions.</param>
        /// <param name="FlagManterTaxaJurosNoRotativo">Boolean that signals to all transactions of this operation type must use the purchase interest rate as the due balance interest rate.</param>

        public OperacaoResponse(long? IdOperacao = null, string CodigoProcessamento = null, string CodigoProcessamentoCancelamento = null, string NomeOperacao = null, bool? FlagCobraJuros = null, bool? FlagCobraTarifa = null, int? Carencia = null, bool? FlagPermitirParcelamento = null, bool? FlagManterTaxaJurosNoRotativo = null)
        {
            this.IdOperacao = IdOperacao;
            this.CodigoProcessamento = CodigoProcessamento;
            this.CodigoProcessamentoCancelamento = CodigoProcessamentoCancelamento;
            this.NomeOperacao = NomeOperacao;
            this.FlagCobraJuros = FlagCobraJuros;
            this.FlagCobraTarifa = FlagCobraTarifa;
            this.Carencia = Carencia;
            this.FlagPermitirParcelamento = FlagPermitirParcelamento;
            this.FlagManterTaxaJurosNoRotativo = FlagManterTaxaJurosNoRotativo;
            
        }
        
    
        /// <summary>
        /// Code that identifies the operation
        /// </summary>
        /// <value>Code that identifies the operation</value>
        [DataMember(Name="idOperacao", EmitDefaultValue=false)]
        public long? IdOperacao { get; set; }
    
        /// <summary>
        /// Processing Code used in transaction with the authorizer
        /// </summary>
        /// <value>Processing Code used in transaction with the authorizer</value>
        [DataMember(Name="codigoProcessamento", EmitDefaultValue=false)]
        public string CodigoProcessamento { get; set; }
    
        /// <summary>
        /// Processing Code used to cancel transactions in the authorizer
        /// </summary>
        /// <value>Processing Code used to cancel transactions in the authorizer</value>
        [DataMember(Name="codigoProcessamentoCancelamento", EmitDefaultValue=false)]
        public string CodigoProcessamentoCancelamento { get; set; }
    
        /// <summary>
        /// Operation name
        /// </summary>
        /// <value>Operation name</value>
        [DataMember(Name="nomeOperacao", EmitDefaultValue=false)]
        public string NomeOperacao { get; set; }
    
        /// <summary>
        /// Flag indicative for the charge of interest
        /// </summary>
        /// <value>Flag indicative for the charge of interest</value>
        [DataMember(Name="flagCobraJuros", EmitDefaultValue=false)]
        public bool? FlagCobraJuros { get; set; }
    
        /// <summary>
        /// Flag indicative for the charge of taxes
        /// </summary>
        /// <value>Flag indicative for the charge of taxes</value>
        [DataMember(Name="flagCobraTarifa", EmitDefaultValue=false)]
        public bool? FlagCobraTarifa { get; set; }
    
        /// <summary>
        /// Quantity of months for the Lack
        /// </summary>
        /// <value>Quantity of months for the Lack</value>
        [DataMember(Name="carencia", EmitDefaultValue=false)]
        public int? Carencia { get; set; }
    
        /// <summary>
        /// Allow parceled transactions
        /// </summary>
        /// <value>Allow parceled transactions</value>
        [DataMember(Name="flagPermitirParcelamento", EmitDefaultValue=false)]
        public bool? FlagPermitirParcelamento { get; set; }
    
        /// <summary>
        /// Boolean that signals to all transactions of this operation type must use the purchase interest rate as the due balance interest rate
        /// </summary>
        /// <value>Boolean that signals to all transactions of this operation type must use the purchase interest rate as the due balance interest rate</value>
        [DataMember(Name="flagManterTaxaJurosNoRotativo", EmitDefaultValue=false)]
        public bool? FlagManterTaxaJurosNoRotativo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperacaoResponse {\n");
            sb.Append("  IdOperacao: ").Append(IdOperacao).Append("\n");
            sb.Append("  CodigoProcessamento: ").Append(CodigoProcessamento).Append("\n");
            sb.Append("  CodigoProcessamentoCancelamento: ").Append(CodigoProcessamentoCancelamento).Append("\n");
            sb.Append("  NomeOperacao: ").Append(NomeOperacao).Append("\n");
            sb.Append("  FlagCobraJuros: ").Append(FlagCobraJuros).Append("\n");
            sb.Append("  FlagCobraTarifa: ").Append(FlagCobraTarifa).Append("\n");
            sb.Append("  Carencia: ").Append(Carencia).Append("\n");
            sb.Append("  FlagPermitirParcelamento: ").Append(FlagPermitirParcelamento).Append("\n");
            sb.Append("  FlagManterTaxaJurosNoRotativo: ").Append(FlagManterTaxaJurosNoRotativo).Append("\n");
            
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
            return this.Equals(obj as OperacaoResponse);
        }

        /// <summary>
        /// Returns true if OperacaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OperacaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperacaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdOperacao == other.IdOperacao ||
                    this.IdOperacao != null &&
                    this.IdOperacao.Equals(other.IdOperacao)
                ) && 
                (
                    this.CodigoProcessamento == other.CodigoProcessamento ||
                    this.CodigoProcessamento != null &&
                    this.CodigoProcessamento.Equals(other.CodigoProcessamento)
                ) && 
                (
                    this.CodigoProcessamentoCancelamento == other.CodigoProcessamentoCancelamento ||
                    this.CodigoProcessamentoCancelamento != null &&
                    this.CodigoProcessamentoCancelamento.Equals(other.CodigoProcessamentoCancelamento)
                ) && 
                (
                    this.NomeOperacao == other.NomeOperacao ||
                    this.NomeOperacao != null &&
                    this.NomeOperacao.Equals(other.NomeOperacao)
                ) && 
                (
                    this.FlagCobraJuros == other.FlagCobraJuros ||
                    this.FlagCobraJuros != null &&
                    this.FlagCobraJuros.Equals(other.FlagCobraJuros)
                ) && 
                (
                    this.FlagCobraTarifa == other.FlagCobraTarifa ||
                    this.FlagCobraTarifa != null &&
                    this.FlagCobraTarifa.Equals(other.FlagCobraTarifa)
                ) && 
                (
                    this.Carencia == other.Carencia ||
                    this.Carencia != null &&
                    this.Carencia.Equals(other.Carencia)
                ) && 
                (
                    this.FlagPermitirParcelamento == other.FlagPermitirParcelamento ||
                    this.FlagPermitirParcelamento != null &&
                    this.FlagPermitirParcelamento.Equals(other.FlagPermitirParcelamento)
                ) && 
                (
                    this.FlagManterTaxaJurosNoRotativo == other.FlagManterTaxaJurosNoRotativo ||
                    this.FlagManterTaxaJurosNoRotativo != null &&
                    this.FlagManterTaxaJurosNoRotativo.Equals(other.FlagManterTaxaJurosNoRotativo)
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
                
                if (this.IdOperacao != null)
                    hash = hash * 59 + this.IdOperacao.GetHashCode();
                
                if (this.CodigoProcessamento != null)
                    hash = hash * 59 + this.CodigoProcessamento.GetHashCode();
                
                if (this.CodigoProcessamentoCancelamento != null)
                    hash = hash * 59 + this.CodigoProcessamentoCancelamento.GetHashCode();
                
                if (this.NomeOperacao != null)
                    hash = hash * 59 + this.NomeOperacao.GetHashCode();
                
                if (this.FlagCobraJuros != null)
                    hash = hash * 59 + this.FlagCobraJuros.GetHashCode();
                
                if (this.FlagCobraTarifa != null)
                    hash = hash * 59 + this.FlagCobraTarifa.GetHashCode();
                
                if (this.Carencia != null)
                    hash = hash * 59 + this.Carencia.GetHashCode();
                
                if (this.FlagPermitirParcelamento != null)
                    hash = hash * 59 + this.FlagPermitirParcelamento.GetHashCode();
                
                if (this.FlagManterTaxaJurosNoRotativo != null)
                    hash = hash * 59 + this.FlagManterTaxaJurosNoRotativo.GetHashCode();
                
                return hash;
            }
        }

    }
}
