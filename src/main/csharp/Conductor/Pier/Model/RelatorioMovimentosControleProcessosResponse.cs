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
    /// {{{relatorio_movimentos_controle_processos_response_description}}}
    /// </summary>
    [DataContract]
    public partial class RelatorioMovimentosControleProcessosResponse :  IEquatable<RelatorioMovimentosControleProcessosResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RelatorioMovimentosControleProcessosResponse" /> class.
        /// Initializes a new instance of the <see cref="RelatorioMovimentosControleProcessosResponse" />class.
        /// </summary>
        /// <param name="Vencimento">Vencimento.</param>
        /// <param name="DtCorteMov">DtCorteMov.</param>
        /// <param name="DtCorteReal">DtCorteReal.</param>
        /// <param name="DtFatMov">DtFatMov.</param>
        /// <param name="DtFatReal">DtFatReal.</param>
        /// <param name="ProximoVencimentoReal">ProximoVencimentoReal.</param>
        /// <param name="PrazoEntradaFatVec">PrazoEntradaFatVec.</param>

        public RelatorioMovimentosControleProcessosResponse(string Vencimento = null, string DtCorteMov = null, string DtCorteReal = null, string DtFatMov = null, string DtFatReal = null, string ProximoVencimentoReal = null, int? PrazoEntradaFatVec = null)
        {
            this.Vencimento = Vencimento;
            this.DtCorteMov = DtCorteMov;
            this.DtCorteReal = DtCorteReal;
            this.DtFatMov = DtFatMov;
            this.DtFatReal = DtFatReal;
            this.ProximoVencimentoReal = ProximoVencimentoReal;
            this.PrazoEntradaFatVec = PrazoEntradaFatVec;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Vencimento
        /// </summary>
        [DataMember(Name="vencimento", EmitDefaultValue=false)]
        public string Vencimento { get; set; }
    
        /// <summary>
        /// Gets or Sets DtCorteMov
        /// </summary>
        [DataMember(Name="dtCorteMov", EmitDefaultValue=false)]
        public string DtCorteMov { get; set; }
    
        /// <summary>
        /// Gets or Sets DtCorteReal
        /// </summary>
        [DataMember(Name="dtCorteReal", EmitDefaultValue=false)]
        public string DtCorteReal { get; set; }
    
        /// <summary>
        /// Gets or Sets DtFatMov
        /// </summary>
        [DataMember(Name="dtFatMov", EmitDefaultValue=false)]
        public string DtFatMov { get; set; }
    
        /// <summary>
        /// Gets or Sets DtFatReal
        /// </summary>
        [DataMember(Name="dtFatReal", EmitDefaultValue=false)]
        public string DtFatReal { get; set; }
    
        /// <summary>
        /// Gets or Sets ProximoVencimentoReal
        /// </summary>
        [DataMember(Name="proximoVencimentoReal", EmitDefaultValue=false)]
        public string ProximoVencimentoReal { get; set; }
    
        /// <summary>
        /// Gets or Sets PrazoEntradaFatVec
        /// </summary>
        [DataMember(Name="prazoEntradaFatVec", EmitDefaultValue=false)]
        public int? PrazoEntradaFatVec { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelatorioMovimentosControleProcessosResponse {\n");
            sb.Append("  Vencimento: ").Append(Vencimento).Append("\n");
            sb.Append("  DtCorteMov: ").Append(DtCorteMov).Append("\n");
            sb.Append("  DtCorteReal: ").Append(DtCorteReal).Append("\n");
            sb.Append("  DtFatMov: ").Append(DtFatMov).Append("\n");
            sb.Append("  DtFatReal: ").Append(DtFatReal).Append("\n");
            sb.Append("  ProximoVencimentoReal: ").Append(ProximoVencimentoReal).Append("\n");
            sb.Append("  PrazoEntradaFatVec: ").Append(PrazoEntradaFatVec).Append("\n");
            
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
            return this.Equals(obj as RelatorioMovimentosControleProcessosResponse);
        }

        /// <summary>
        /// Returns true if RelatorioMovimentosControleProcessosResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of RelatorioMovimentosControleProcessosResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelatorioMovimentosControleProcessosResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Vencimento == other.Vencimento ||
                    this.Vencimento != null &&
                    this.Vencimento.Equals(other.Vencimento)
                ) && 
                (
                    this.DtCorteMov == other.DtCorteMov ||
                    this.DtCorteMov != null &&
                    this.DtCorteMov.Equals(other.DtCorteMov)
                ) && 
                (
                    this.DtCorteReal == other.DtCorteReal ||
                    this.DtCorteReal != null &&
                    this.DtCorteReal.Equals(other.DtCorteReal)
                ) && 
                (
                    this.DtFatMov == other.DtFatMov ||
                    this.DtFatMov != null &&
                    this.DtFatMov.Equals(other.DtFatMov)
                ) && 
                (
                    this.DtFatReal == other.DtFatReal ||
                    this.DtFatReal != null &&
                    this.DtFatReal.Equals(other.DtFatReal)
                ) && 
                (
                    this.ProximoVencimentoReal == other.ProximoVencimentoReal ||
                    this.ProximoVencimentoReal != null &&
                    this.ProximoVencimentoReal.Equals(other.ProximoVencimentoReal)
                ) && 
                (
                    this.PrazoEntradaFatVec == other.PrazoEntradaFatVec ||
                    this.PrazoEntradaFatVec != null &&
                    this.PrazoEntradaFatVec.Equals(other.PrazoEntradaFatVec)
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
                
                if (this.Vencimento != null)
                    hash = hash * 59 + this.Vencimento.GetHashCode();
                
                if (this.DtCorteMov != null)
                    hash = hash * 59 + this.DtCorteMov.GetHashCode();
                
                if (this.DtCorteReal != null)
                    hash = hash * 59 + this.DtCorteReal.GetHashCode();
                
                if (this.DtFatMov != null)
                    hash = hash * 59 + this.DtFatMov.GetHashCode();
                
                if (this.DtFatReal != null)
                    hash = hash * 59 + this.DtFatReal.GetHashCode();
                
                if (this.ProximoVencimentoReal != null)
                    hash = hash * 59 + this.ProximoVencimentoReal.GetHashCode();
                
                if (this.PrazoEntradaFatVec != null)
                    hash = hash * 59 + this.PrazoEntradaFatVec.GetHashCode();
                
                return hash;
            }
        }

    }
}
