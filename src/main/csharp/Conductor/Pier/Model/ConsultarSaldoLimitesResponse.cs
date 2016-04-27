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
    public partial class ConsultarSaldoLimitesResponse :  IEquatable<ConsultarSaldoLimitesResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsultarSaldoLimitesResponse" /> class.
        /// Initializes a new instance of the <see cref="ConsultarSaldoLimitesResponse" />class.
        /// </summary>
        /// <param name="CodRetorno">CodRetorno.</param>
        /// <param name="CodigoRetorno">CodigoRetorno.</param>
        /// <param name="DescricaoRetorno">DescricaoRetorno.</param>
        /// <param name="DisponibCompraNac">DisponibCompraNac.</param>
        /// <param name="DisponibGlobalCredito">DisponibGlobalCredito.</param>
        /// <param name="DisponibParceladoNac">DisponibParceladoNac.</param>
        /// <param name="DisponibParcelasNac">DisponibParcelasNac.</param>
        /// <param name="DisponibSaqueNacGlobal">DisponibSaqueNacGlobal.</param>
        /// <param name="LimiteCompraNac">LimiteCompraNac.</param>
        /// <param name="LimiteGlobalCredito">LimiteGlobalCredito.</param>
        /// <param name="LimiteParceladoNac">LimiteParceladoNac.</param>
        /// <param name="LimiteParcelasNac">LimiteParcelasNac.</param>
        /// <param name="LimiteSaqueNacGlobal">LimiteSaqueNacGlobal.</param>
        /// <param name="LimiteSaqueNacPeriodo">LimiteSaqueNacPeriodo.</param>
        /// <param name="RendaComprovada">RendaComprovada.</param>
        /// <param name="SolicitacaoPendente">SolicitacaoPendente.</param>

        public ConsultarSaldoLimitesResponse(int? CodRetorno = null, int? CodigoRetorno = null, string DescricaoRetorno = null, double? DisponibCompraNac = null, double? DisponibGlobalCredito = null, double? DisponibParceladoNac = null, double? DisponibParcelasNac = null, double? DisponibSaqueNacGlobal = null, double? LimiteCompraNac = null, double? LimiteGlobalCredito = null, double? LimiteParceladoNac = null, double? LimiteParcelasNac = null, double? LimiteSaqueNacGlobal = null, double? LimiteSaqueNacPeriodo = null, double? RendaComprovada = null, bool? SolicitacaoPendente = null)
        {
            this.CodRetorno = CodRetorno;
            this.CodigoRetorno = CodigoRetorno;
            this.DescricaoRetorno = DescricaoRetorno;
            this.DisponibCompraNac = DisponibCompraNac;
            this.DisponibGlobalCredito = DisponibGlobalCredito;
            this.DisponibParceladoNac = DisponibParceladoNac;
            this.DisponibParcelasNac = DisponibParcelasNac;
            this.DisponibSaqueNacGlobal = DisponibSaqueNacGlobal;
            this.LimiteCompraNac = LimiteCompraNac;
            this.LimiteGlobalCredito = LimiteGlobalCredito;
            this.LimiteParceladoNac = LimiteParceladoNac;
            this.LimiteParcelasNac = LimiteParcelasNac;
            this.LimiteSaqueNacGlobal = LimiteSaqueNacGlobal;
            this.LimiteSaqueNacPeriodo = LimiteSaqueNacPeriodo;
            this.RendaComprovada = RendaComprovada;
            this.SolicitacaoPendente = SolicitacaoPendente;
            
        }
        
    
        /// <summary>
        /// Gets or Sets CodRetorno
        /// </summary>
        [DataMember(Name="codRetorno", EmitDefaultValue=false)]
        public int? CodRetorno { get; set; }
    
        /// <summary>
        /// Gets or Sets CodigoRetorno
        /// </summary>
        [DataMember(Name="codigoRetorno", EmitDefaultValue=false)]
        public int? CodigoRetorno { get; set; }
    
        /// <summary>
        /// Gets or Sets DescricaoRetorno
        /// </summary>
        [DataMember(Name="descricaoRetorno", EmitDefaultValue=false)]
        public string DescricaoRetorno { get; set; }
    
        /// <summary>
        /// Gets or Sets DisponibCompraNac
        /// </summary>
        [DataMember(Name="disponibCompraNac", EmitDefaultValue=false)]
        public double? DisponibCompraNac { get; set; }
    
        /// <summary>
        /// Gets or Sets DisponibGlobalCredito
        /// </summary>
        [DataMember(Name="disponibGlobalCredito", EmitDefaultValue=false)]
        public double? DisponibGlobalCredito { get; set; }
    
        /// <summary>
        /// Gets or Sets DisponibParceladoNac
        /// </summary>
        [DataMember(Name="disponibParceladoNac", EmitDefaultValue=false)]
        public double? DisponibParceladoNac { get; set; }
    
        /// <summary>
        /// Gets or Sets DisponibParcelasNac
        /// </summary>
        [DataMember(Name="disponibParcelasNac", EmitDefaultValue=false)]
        public double? DisponibParcelasNac { get; set; }
    
        /// <summary>
        /// Gets or Sets DisponibSaqueNacGlobal
        /// </summary>
        [DataMember(Name="disponibSaqueNacGlobal", EmitDefaultValue=false)]
        public double? DisponibSaqueNacGlobal { get; set; }
    
        /// <summary>
        /// Gets or Sets LimiteCompraNac
        /// </summary>
        [DataMember(Name="limiteCompraNac", EmitDefaultValue=false)]
        public double? LimiteCompraNac { get; set; }
    
        /// <summary>
        /// Gets or Sets LimiteGlobalCredito
        /// </summary>
        [DataMember(Name="limiteGlobalCredito", EmitDefaultValue=false)]
        public double? LimiteGlobalCredito { get; set; }
    
        /// <summary>
        /// Gets or Sets LimiteParceladoNac
        /// </summary>
        [DataMember(Name="limiteParceladoNac", EmitDefaultValue=false)]
        public double? LimiteParceladoNac { get; set; }
    
        /// <summary>
        /// Gets or Sets LimiteParcelasNac
        /// </summary>
        [DataMember(Name="limiteParcelasNac", EmitDefaultValue=false)]
        public double? LimiteParcelasNac { get; set; }
    
        /// <summary>
        /// Gets or Sets LimiteSaqueNacGlobal
        /// </summary>
        [DataMember(Name="limiteSaqueNacGlobal", EmitDefaultValue=false)]
        public double? LimiteSaqueNacGlobal { get; set; }
    
        /// <summary>
        /// Gets or Sets LimiteSaqueNacPeriodo
        /// </summary>
        [DataMember(Name="limiteSaqueNacPeriodo", EmitDefaultValue=false)]
        public double? LimiteSaqueNacPeriodo { get; set; }
    
        /// <summary>
        /// Gets or Sets RendaComprovada
        /// </summary>
        [DataMember(Name="rendaComprovada", EmitDefaultValue=false)]
        public double? RendaComprovada { get; set; }
    
        /// <summary>
        /// Gets or Sets SolicitacaoPendente
        /// </summary>
        [DataMember(Name="solicitacaoPendente", EmitDefaultValue=false)]
        public bool? SolicitacaoPendente { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsultarSaldoLimitesResponse {\n");
            sb.Append("  CodRetorno: ").Append(CodRetorno).Append("\n");
            sb.Append("  CodigoRetorno: ").Append(CodigoRetorno).Append("\n");
            sb.Append("  DescricaoRetorno: ").Append(DescricaoRetorno).Append("\n");
            sb.Append("  DisponibCompraNac: ").Append(DisponibCompraNac).Append("\n");
            sb.Append("  DisponibGlobalCredito: ").Append(DisponibGlobalCredito).Append("\n");
            sb.Append("  DisponibParceladoNac: ").Append(DisponibParceladoNac).Append("\n");
            sb.Append("  DisponibParcelasNac: ").Append(DisponibParcelasNac).Append("\n");
            sb.Append("  DisponibSaqueNacGlobal: ").Append(DisponibSaqueNacGlobal).Append("\n");
            sb.Append("  LimiteCompraNac: ").Append(LimiteCompraNac).Append("\n");
            sb.Append("  LimiteGlobalCredito: ").Append(LimiteGlobalCredito).Append("\n");
            sb.Append("  LimiteParceladoNac: ").Append(LimiteParceladoNac).Append("\n");
            sb.Append("  LimiteParcelasNac: ").Append(LimiteParcelasNac).Append("\n");
            sb.Append("  LimiteSaqueNacGlobal: ").Append(LimiteSaqueNacGlobal).Append("\n");
            sb.Append("  LimiteSaqueNacPeriodo: ").Append(LimiteSaqueNacPeriodo).Append("\n");
            sb.Append("  RendaComprovada: ").Append(RendaComprovada).Append("\n");
            sb.Append("  SolicitacaoPendente: ").Append(SolicitacaoPendente).Append("\n");
            
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
            return this.Equals(obj as ConsultarSaldoLimitesResponse);
        }

        /// <summary>
        /// Returns true if ConsultarSaldoLimitesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ConsultarSaldoLimitesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsultarSaldoLimitesResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CodRetorno == other.CodRetorno ||
                    this.CodRetorno != null &&
                    this.CodRetorno.Equals(other.CodRetorno)
                ) && 
                (
                    this.CodigoRetorno == other.CodigoRetorno ||
                    this.CodigoRetorno != null &&
                    this.CodigoRetorno.Equals(other.CodigoRetorno)
                ) && 
                (
                    this.DescricaoRetorno == other.DescricaoRetorno ||
                    this.DescricaoRetorno != null &&
                    this.DescricaoRetorno.Equals(other.DescricaoRetorno)
                ) && 
                (
                    this.DisponibCompraNac == other.DisponibCompraNac ||
                    this.DisponibCompraNac != null &&
                    this.DisponibCompraNac.Equals(other.DisponibCompraNac)
                ) && 
                (
                    this.DisponibGlobalCredito == other.DisponibGlobalCredito ||
                    this.DisponibGlobalCredito != null &&
                    this.DisponibGlobalCredito.Equals(other.DisponibGlobalCredito)
                ) && 
                (
                    this.DisponibParceladoNac == other.DisponibParceladoNac ||
                    this.DisponibParceladoNac != null &&
                    this.DisponibParceladoNac.Equals(other.DisponibParceladoNac)
                ) && 
                (
                    this.DisponibParcelasNac == other.DisponibParcelasNac ||
                    this.DisponibParcelasNac != null &&
                    this.DisponibParcelasNac.Equals(other.DisponibParcelasNac)
                ) && 
                (
                    this.DisponibSaqueNacGlobal == other.DisponibSaqueNacGlobal ||
                    this.DisponibSaqueNacGlobal != null &&
                    this.DisponibSaqueNacGlobal.Equals(other.DisponibSaqueNacGlobal)
                ) && 
                (
                    this.LimiteCompraNac == other.LimiteCompraNac ||
                    this.LimiteCompraNac != null &&
                    this.LimiteCompraNac.Equals(other.LimiteCompraNac)
                ) && 
                (
                    this.LimiteGlobalCredito == other.LimiteGlobalCredito ||
                    this.LimiteGlobalCredito != null &&
                    this.LimiteGlobalCredito.Equals(other.LimiteGlobalCredito)
                ) && 
                (
                    this.LimiteParceladoNac == other.LimiteParceladoNac ||
                    this.LimiteParceladoNac != null &&
                    this.LimiteParceladoNac.Equals(other.LimiteParceladoNac)
                ) && 
                (
                    this.LimiteParcelasNac == other.LimiteParcelasNac ||
                    this.LimiteParcelasNac != null &&
                    this.LimiteParcelasNac.Equals(other.LimiteParcelasNac)
                ) && 
                (
                    this.LimiteSaqueNacGlobal == other.LimiteSaqueNacGlobal ||
                    this.LimiteSaqueNacGlobal != null &&
                    this.LimiteSaqueNacGlobal.Equals(other.LimiteSaqueNacGlobal)
                ) && 
                (
                    this.LimiteSaqueNacPeriodo == other.LimiteSaqueNacPeriodo ||
                    this.LimiteSaqueNacPeriodo != null &&
                    this.LimiteSaqueNacPeriodo.Equals(other.LimiteSaqueNacPeriodo)
                ) && 
                (
                    this.RendaComprovada == other.RendaComprovada ||
                    this.RendaComprovada != null &&
                    this.RendaComprovada.Equals(other.RendaComprovada)
                ) && 
                (
                    this.SolicitacaoPendente == other.SolicitacaoPendente ||
                    this.SolicitacaoPendente != null &&
                    this.SolicitacaoPendente.Equals(other.SolicitacaoPendente)
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
                
                if (this.CodRetorno != null)
                    hash = hash * 59 + this.CodRetorno.GetHashCode();
                
                if (this.CodigoRetorno != null)
                    hash = hash * 59 + this.CodigoRetorno.GetHashCode();
                
                if (this.DescricaoRetorno != null)
                    hash = hash * 59 + this.DescricaoRetorno.GetHashCode();
                
                if (this.DisponibCompraNac != null)
                    hash = hash * 59 + this.DisponibCompraNac.GetHashCode();
                
                if (this.DisponibGlobalCredito != null)
                    hash = hash * 59 + this.DisponibGlobalCredito.GetHashCode();
                
                if (this.DisponibParceladoNac != null)
                    hash = hash * 59 + this.DisponibParceladoNac.GetHashCode();
                
                if (this.DisponibParcelasNac != null)
                    hash = hash * 59 + this.DisponibParcelasNac.GetHashCode();
                
                if (this.DisponibSaqueNacGlobal != null)
                    hash = hash * 59 + this.DisponibSaqueNacGlobal.GetHashCode();
                
                if (this.LimiteCompraNac != null)
                    hash = hash * 59 + this.LimiteCompraNac.GetHashCode();
                
                if (this.LimiteGlobalCredito != null)
                    hash = hash * 59 + this.LimiteGlobalCredito.GetHashCode();
                
                if (this.LimiteParceladoNac != null)
                    hash = hash * 59 + this.LimiteParceladoNac.GetHashCode();
                
                if (this.LimiteParcelasNac != null)
                    hash = hash * 59 + this.LimiteParcelasNac.GetHashCode();
                
                if (this.LimiteSaqueNacGlobal != null)
                    hash = hash * 59 + this.LimiteSaqueNacGlobal.GetHashCode();
                
                if (this.LimiteSaqueNacPeriodo != null)
                    hash = hash * 59 + this.LimiteSaqueNacPeriodo.GetHashCode();
                
                if (this.RendaComprovada != null)
                    hash = hash * 59 + this.RendaComprovada.GetHashCode();
                
                if (this.SolicitacaoPendente != null)
                    hash = hash * 59 + this.SolicitacaoPendente.GetHashCode();
                
                return hash;
            }
        }

    }
}
