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
    /// Representa\u00C3\u00A7\u00C3\u00A3o da resposta do recurso Operacao
    /// </summary>
    [DataContract]
    public partial class OperacaoResponse :  IEquatable<OperacaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OperacaoResponse" /> class.
        /// Initializes a new instance of the <see cref="OperacaoResponse" />class.
        /// </summary>
        /// <param name="IdOperacao">C\u00C3\u00B3digo que identifica a opera\u00C3\u00A7\u00C3\u00A3o.</param>
        /// <param name="CodigoProcessamento">C\u00C3\u00B3digo de processamento usado em transa\u00C3\u00A7\u00C3\u00B5es com o autorizador.</param>
        /// <param name="CodigoProcessamentoCancelamento">C\u00C3\u00B3digo de processamento usado para cancelar transa\u00C3\u00A7\u00C3\u00B5es no autorizador.</param>
        /// <param name="NomeOperacao">Nome da opera\u00C3\u00A7\u00C3\u00A3o.</param>
        /// <param name="FlagCobraJuros">Flag indicativa para crobran\u00C3\u00A7a de juros.</param>
        /// <param name="FlagCobraTarifa">Flag indicativa para crobran\u00C3\u00A7a de tarifas.</param>
        /// <param name="Carencia">Quantidade de meses para car\u00C3\u00AAncia.</param>
        /// <param name="FlagPermitirParcelamento">Permitir transa\u00C3\u00A7\u00C3\u00B5es parceladas.</param>

        public OperacaoResponse(long? IdOperacao = null, string CodigoProcessamento = null, string CodigoProcessamentoCancelamento = null, string NomeOperacao = null, bool? FlagCobraJuros = null, bool? FlagCobraTarifa = null, int? Carencia = null, bool? FlagPermitirParcelamento = null)
        {
            this.IdOperacao = IdOperacao;
            this.CodigoProcessamento = CodigoProcessamento;
            this.CodigoProcessamentoCancelamento = CodigoProcessamentoCancelamento;
            this.NomeOperacao = NomeOperacao;
            this.FlagCobraJuros = FlagCobraJuros;
            this.FlagCobraTarifa = FlagCobraTarifa;
            this.Carencia = Carencia;
            this.FlagPermitirParcelamento = FlagPermitirParcelamento;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo que identifica a opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <value>C\u00C3\u00B3digo que identifica a opera\u00C3\u00A7\u00C3\u00A3o</value>
        [DataMember(Name="idOperacao", EmitDefaultValue=false)]
        public long? IdOperacao { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de processamento usado em transa\u00C3\u00A7\u00C3\u00B5es com o autorizador
        /// </summary>
        /// <value>C\u00C3\u00B3digo de processamento usado em transa\u00C3\u00A7\u00C3\u00B5es com o autorizador</value>
        [DataMember(Name="codigoProcessamento", EmitDefaultValue=false)]
        public string CodigoProcessamento { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de processamento usado para cancelar transa\u00C3\u00A7\u00C3\u00B5es no autorizador
        /// </summary>
        /// <value>C\u00C3\u00B3digo de processamento usado para cancelar transa\u00C3\u00A7\u00C3\u00B5es no autorizador</value>
        [DataMember(Name="codigoProcessamentoCancelamento", EmitDefaultValue=false)]
        public string CodigoProcessamentoCancelamento { get; set; }
    
        /// <summary>
        /// Nome da opera\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <value>Nome da opera\u00C3\u00A7\u00C3\u00A3o</value>
        [DataMember(Name="nomeOperacao", EmitDefaultValue=false)]
        public string NomeOperacao { get; set; }
    
        /// <summary>
        /// Flag indicativa para crobran\u00C3\u00A7a de juros
        /// </summary>
        /// <value>Flag indicativa para crobran\u00C3\u00A7a de juros</value>
        [DataMember(Name="flagCobraJuros", EmitDefaultValue=false)]
        public bool? FlagCobraJuros { get; set; }
    
        /// <summary>
        /// Flag indicativa para crobran\u00C3\u00A7a de tarifas
        /// </summary>
        /// <value>Flag indicativa para crobran\u00C3\u00A7a de tarifas</value>
        [DataMember(Name="flagCobraTarifa", EmitDefaultValue=false)]
        public bool? FlagCobraTarifa { get; set; }
    
        /// <summary>
        /// Quantidade de meses para car\u00C3\u00AAncia
        /// </summary>
        /// <value>Quantidade de meses para car\u00C3\u00AAncia</value>
        [DataMember(Name="carencia", EmitDefaultValue=false)]
        public int? Carencia { get; set; }
    
        /// <summary>
        /// Permitir transa\u00C3\u00A7\u00C3\u00B5es parceladas
        /// </summary>
        /// <value>Permitir transa\u00C3\u00A7\u00C3\u00B5es parceladas</value>
        [DataMember(Name="flagPermitirParcelamento", EmitDefaultValue=false)]
        public bool? FlagPermitirParcelamento { get; set; }
    
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
                
                return hash;
            }
        }

    }
}
