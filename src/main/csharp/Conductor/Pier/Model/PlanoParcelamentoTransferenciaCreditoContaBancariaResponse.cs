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
    /// Plano de Parcelamentos para Transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para contas banc\u00C3\u00A1rias
    /// </summary>
    [DataContract]
    public partial class PlanoParcelamentoTransferenciaCreditoContaBancariaResponse :  IEquatable<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanoParcelamentoTransferenciaCreditoContaBancariaResponse" /> class.
        /// Initializes a new instance of the <see cref="PlanoParcelamentoTransferenciaCreditoContaBancariaResponse" />class.
        /// </summary>
        /// <param name="NsuOrigem">N\u00C3\u00BAmero Sequencial \u00C3\u009Anico que identifica a transa\u00C3\u00A7\u00C3\u00A3o no sistema que a originou..</param>
        /// <param name="NumeroMascaradoCartao">N\u00C3\u00BAmero do Cart\u00C3\u00A3o que originou a transa\u00C3\u00A7\u00C3\u00A3o em formato mascarado..</param>
        /// <param name="TerminalRequisitante">Apresenta a identifica\u00C3\u00A7\u00C3\u00A3o do terminal requisitante.</param>
        /// <param name="PlanoParcelamentos">Lista os planos de parcelamentos.</param>

        public PlanoParcelamentoTransferenciaCreditoContaBancariaResponse(string NsuOrigem = null, string NumeroMascaradoCartao = null, string TerminalRequisitante = null, List<PlanoParcelamentoTransferenciaResponse> PlanoParcelamentos = null)
        {
            this.NsuOrigem = NsuOrigem;
            this.NumeroMascaradoCartao = NumeroMascaradoCartao;
            this.TerminalRequisitante = TerminalRequisitante;
            this.PlanoParcelamentos = PlanoParcelamentos;
            
        }
        
    
        /// <summary>
        /// N\u00C3\u00BAmero Sequencial \u00C3\u009Anico que identifica a transa\u00C3\u00A7\u00C3\u00A3o no sistema que a originou.
        /// </summary>
        /// <value>N\u00C3\u00BAmero Sequencial \u00C3\u009Anico que identifica a transa\u00C3\u00A7\u00C3\u00A3o no sistema que a originou.</value>
        [DataMember(Name="nsuOrigem", EmitDefaultValue=false)]
        public string NsuOrigem { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero do Cart\u00C3\u00A3o que originou a transa\u00C3\u00A7\u00C3\u00A3o em formato mascarado.
        /// </summary>
        /// <value>N\u00C3\u00BAmero do Cart\u00C3\u00A3o que originou a transa\u00C3\u00A7\u00C3\u00A3o em formato mascarado.</value>
        [DataMember(Name="numeroMascaradoCartao", EmitDefaultValue=false)]
        public string NumeroMascaradoCartao { get; set; }
    
        /// <summary>
        /// Apresenta a identifica\u00C3\u00A7\u00C3\u00A3o do terminal requisitante
        /// </summary>
        /// <value>Apresenta a identifica\u00C3\u00A7\u00C3\u00A3o do terminal requisitante</value>
        [DataMember(Name="terminalRequisitante", EmitDefaultValue=false)]
        public string TerminalRequisitante { get; set; }
    
        /// <summary>
        /// Lista os planos de parcelamentos
        /// </summary>
        /// <value>Lista os planos de parcelamentos</value>
        [DataMember(Name="planoParcelamentos", EmitDefaultValue=false)]
        public List<PlanoParcelamentoTransferenciaResponse> PlanoParcelamentos { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlanoParcelamentoTransferenciaCreditoContaBancariaResponse {\n");
            sb.Append("  NsuOrigem: ").Append(NsuOrigem).Append("\n");
            sb.Append("  NumeroMascaradoCartao: ").Append(NumeroMascaradoCartao).Append("\n");
            sb.Append("  TerminalRequisitante: ").Append(TerminalRequisitante).Append("\n");
            sb.Append("  PlanoParcelamentos: ").Append(PlanoParcelamentos).Append("\n");
            
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
            return this.Equals(obj as PlanoParcelamentoTransferenciaCreditoContaBancariaResponse);
        }

        /// <summary>
        /// Returns true if PlanoParcelamentoTransferenciaCreditoContaBancariaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PlanoParcelamentoTransferenciaCreditoContaBancariaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanoParcelamentoTransferenciaCreditoContaBancariaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NsuOrigem == other.NsuOrigem ||
                    this.NsuOrigem != null &&
                    this.NsuOrigem.Equals(other.NsuOrigem)
                ) && 
                (
                    this.NumeroMascaradoCartao == other.NumeroMascaradoCartao ||
                    this.NumeroMascaradoCartao != null &&
                    this.NumeroMascaradoCartao.Equals(other.NumeroMascaradoCartao)
                ) && 
                (
                    this.TerminalRequisitante == other.TerminalRequisitante ||
                    this.TerminalRequisitante != null &&
                    this.TerminalRequisitante.Equals(other.TerminalRequisitante)
                ) && 
                (
                    this.PlanoParcelamentos == other.PlanoParcelamentos ||
                    this.PlanoParcelamentos != null &&
                    this.PlanoParcelamentos.SequenceEqual(other.PlanoParcelamentos)
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
                
                if (this.NsuOrigem != null)
                    hash = hash * 59 + this.NsuOrigem.GetHashCode();
                
                if (this.NumeroMascaradoCartao != null)
                    hash = hash * 59 + this.NumeroMascaradoCartao.GetHashCode();
                
                if (this.TerminalRequisitante != null)
                    hash = hash * 59 + this.TerminalRequisitante.GetHashCode();
                
                if (this.PlanoParcelamentos != null)
                    hash = hash * 59 + this.PlanoParcelamentos.GetHashCode();
                
                return hash;
            }
        }

    }
}
