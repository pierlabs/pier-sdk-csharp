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
    /// Objeto de Resposta de Autoriza\u00C3\u00A7\u00C3\u00A3o
    /// </summary>
    [DataContract]
    public partial class TransacaoOnUsResponse :  IEquatable<TransacaoOnUsResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransacaoOnUsResponse" /> class.
        /// Initializes a new instance of the <see cref="TransacaoOnUsResponse" />class.
        /// </summary>
        /// <param name="NsuOrigem">N\u00C3\u00BAmero Sequencial \u00C3\u009Anico que identifica a transa\u00C3\u00A7\u00C3\u00A3o no sistema que a originou..</param>
        /// <param name="NsuAutorizacao">N\u00C3\u00BAmero Sequencial \u00C3\u009Anico gerado pelo Autorizador a cada Transa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="PlanoDeParcelamento">Descri\u00C3\u00A7\u00C3\u00A3o do Plano de Parcelamento atribu\u00C3\u00ADdo a Transa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="CodigoAutorizacao">C\u00C3\u00B3digo de Autoriza\u00C3\u00A7\u00C3\u00A3o gerado pelo Autorizador..</param>
        /// <param name="NumeroMascaradoCartao">N\u00C3\u00BAmero do Cart\u00C3\u00A3o que originou a transa\u00C3\u00A7\u00C3\u00A3o em formato mascarado..</param>
        /// <param name="NomePortadorCartao">Nome do Portador do Cart\u00C3\u00A3o que originou a transa\u00C3\u00A7\u00C3\u00A3o..</param>

        public TransacaoOnUsResponse(string NsuOrigem = null, string NsuAutorizacao = null, List<MapOfstringAndstring> PlanoDeParcelamento = null, string CodigoAutorizacao = null, string NumeroMascaradoCartao = null, string NomePortadorCartao = null)
        {
            this.NsuOrigem = NsuOrigem;
            this.NsuAutorizacao = NsuAutorizacao;
            this.PlanoDeParcelamento = PlanoDeParcelamento;
            this.CodigoAutorizacao = CodigoAutorizacao;
            this.NumeroMascaradoCartao = NumeroMascaradoCartao;
            this.NomePortadorCartao = NomePortadorCartao;
            
        }
        
    
        /// <summary>
        /// N\u00C3\u00BAmero Sequencial \u00C3\u009Anico que identifica a transa\u00C3\u00A7\u00C3\u00A3o no sistema que a originou.
        /// </summary>
        /// <value>N\u00C3\u00BAmero Sequencial \u00C3\u009Anico que identifica a transa\u00C3\u00A7\u00C3\u00A3o no sistema que a originou.</value>
        [DataMember(Name="nsuOrigem", EmitDefaultValue=false)]
        public string NsuOrigem { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero Sequencial \u00C3\u009Anico gerado pelo Autorizador a cada Transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>N\u00C3\u00BAmero Sequencial \u00C3\u009Anico gerado pelo Autorizador a cada Transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="nsuAutorizacao", EmitDefaultValue=false)]
        public string NsuAutorizacao { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o do Plano de Parcelamento atribu\u00C3\u00ADdo a Transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o do Plano de Parcelamento atribu\u00C3\u00ADdo a Transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="planoDeParcelamento", EmitDefaultValue=false)]
        public List<MapOfstringAndstring> PlanoDeParcelamento { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Autoriza\u00C3\u00A7\u00C3\u00A3o gerado pelo Autorizador.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Autoriza\u00C3\u00A7\u00C3\u00A3o gerado pelo Autorizador.</value>
        [DataMember(Name="codigoAutorizacao", EmitDefaultValue=false)]
        public string CodigoAutorizacao { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero do Cart\u00C3\u00A3o que originou a transa\u00C3\u00A7\u00C3\u00A3o em formato mascarado.
        /// </summary>
        /// <value>N\u00C3\u00BAmero do Cart\u00C3\u00A3o que originou a transa\u00C3\u00A7\u00C3\u00A3o em formato mascarado.</value>
        [DataMember(Name="numeroMascaradoCartao", EmitDefaultValue=false)]
        public string NumeroMascaradoCartao { get; set; }
    
        /// <summary>
        /// Nome do Portador do Cart\u00C3\u00A3o que originou a transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Nome do Portador do Cart\u00C3\u00A3o que originou a transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="nomePortadorCartao", EmitDefaultValue=false)]
        public string NomePortadorCartao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransacaoOnUsResponse {\n");
            sb.Append("  NsuOrigem: ").Append(NsuOrigem).Append("\n");
            sb.Append("  NsuAutorizacao: ").Append(NsuAutorizacao).Append("\n");
            sb.Append("  PlanoDeParcelamento: ").Append(PlanoDeParcelamento).Append("\n");
            sb.Append("  CodigoAutorizacao: ").Append(CodigoAutorizacao).Append("\n");
            sb.Append("  NumeroMascaradoCartao: ").Append(NumeroMascaradoCartao).Append("\n");
            sb.Append("  NomePortadorCartao: ").Append(NomePortadorCartao).Append("\n");
            
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
            return this.Equals(obj as TransacaoOnUsResponse);
        }

        /// <summary>
        /// Returns true if TransacaoOnUsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TransacaoOnUsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransacaoOnUsResponse other)
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
                    this.NsuAutorizacao == other.NsuAutorizacao ||
                    this.NsuAutorizacao != null &&
                    this.NsuAutorizacao.Equals(other.NsuAutorizacao)
                ) && 
                (
                    this.PlanoDeParcelamento == other.PlanoDeParcelamento ||
                    this.PlanoDeParcelamento != null &&
                    this.PlanoDeParcelamento.SequenceEqual(other.PlanoDeParcelamento)
                ) && 
                (
                    this.CodigoAutorizacao == other.CodigoAutorizacao ||
                    this.CodigoAutorizacao != null &&
                    this.CodigoAutorizacao.Equals(other.CodigoAutorizacao)
                ) && 
                (
                    this.NumeroMascaradoCartao == other.NumeroMascaradoCartao ||
                    this.NumeroMascaradoCartao != null &&
                    this.NumeroMascaradoCartao.Equals(other.NumeroMascaradoCartao)
                ) && 
                (
                    this.NomePortadorCartao == other.NomePortadorCartao ||
                    this.NomePortadorCartao != null &&
                    this.NomePortadorCartao.Equals(other.NomePortadorCartao)
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
                
                if (this.NsuAutorizacao != null)
                    hash = hash * 59 + this.NsuAutorizacao.GetHashCode();
                
                if (this.PlanoDeParcelamento != null)
                    hash = hash * 59 + this.PlanoDeParcelamento.GetHashCode();
                
                if (this.CodigoAutorizacao != null)
                    hash = hash * 59 + this.CodigoAutorizacao.GetHashCode();
                
                if (this.NumeroMascaradoCartao != null)
                    hash = hash * 59 + this.NumeroMascaradoCartao.GetHashCode();
                
                if (this.NomePortadorCartao != null)
                    hash = hash * 59 + this.NomePortadorCartao.GetHashCode();
                
                return hash;
            }
        }

    }
}
