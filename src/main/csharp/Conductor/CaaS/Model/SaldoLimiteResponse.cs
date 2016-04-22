using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Conductor.CaaS.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class SaldoLimiteResponse :  IEquatable<SaldoLimiteResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaldoLimiteResponse" /> class.
        /// </summary>
        public SaldoLimiteResponse()
        {
            
        }

        
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
        /// Gets or Sets FlagAntecipacao
        /// </summary>
        [DataMember(Name="flagAntecipacao", EmitDefaultValue=false)]
        public bool? FlagAntecipacao { get; set; }
  
        
        /// <summary>
        /// Gets or Sets LimiteCompraNac
        /// </summary>
        [DataMember(Name="limiteCompraNac", EmitDefaultValue=false)]
        public double? LimiteCompraNac { get; set; }
  
        
        /// <summary>
        /// Gets or Sets LimiteCreditoConcedido
        /// </summary>
        [DataMember(Name="limiteCreditoConcedido", EmitDefaultValue=false)]
        public double? LimiteCreditoConcedido { get; set; }
  
        
        /// <summary>
        /// Gets or Sets LimiteCreditoDisponivel
        /// </summary>
        [DataMember(Name="limiteCreditoDisponivel", EmitDefaultValue=false)]
        public double? LimiteCreditoDisponivel { get; set; }
  
        
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
        /// Gets or Sets LimitePontuacao
        /// </summary>
        [DataMember(Name="limitePontuacao", EmitDefaultValue=false)]
        public double? LimitePontuacao { get; set; }
  
        
        /// <summary>
        /// Gets or Sets LimiteSaqueNacGlobal
        /// </summary>
        [DataMember(Name="limiteSaqueNacGlobal", EmitDefaultValue=false)]
        public double? LimiteSaqueNacGlobal { get; set; }
  
        
        /// <summary>
        /// Gets or Sets NumeroCiclo
        /// </summary>
        [DataMember(Name="numeroCiclo", EmitDefaultValue=false)]
        public int? NumeroCiclo { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PontosConcedidos
        /// </summary>
        [DataMember(Name="pontosConcedidos", EmitDefaultValue=false)]
        public double? PontosConcedidos { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PontosRemanescentes
        /// </summary>
        [DataMember(Name="pontosRemanescentes", EmitDefaultValue=false)]
        public double? PontosRemanescentes { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ProximoVencimentoPadrao
        /// </summary>
        [DataMember(Name="proximoVencimentoPadrao", EmitDefaultValue=false)]
        public string ProximoVencimentoPadrao { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ProximoVencimentoReal
        /// </summary>
        [DataMember(Name="proximoVencimentoReal", EmitDefaultValue=false)]
        public string ProximoVencimentoReal { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SaldoAtualFinal
        /// </summary>
        [DataMember(Name="saldoAtualFinal", EmitDefaultValue=false)]
        public double? SaldoAtualFinal { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SaldoCredor
        /// </summary>
        [DataMember(Name="saldoCredor", EmitDefaultValue=false)]
        public double? SaldoCredor { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SaldoDevedor
        /// </summary>
        [DataMember(Name="saldoDevedor", EmitDefaultValue=false)]
        public double? SaldoDevedor { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SaldoDevedorOneroso
        /// </summary>
        [DataMember(Name="saldoDevedorOneroso", EmitDefaultValue=false)]
        public double? SaldoDevedorOneroso { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SaldoDevedorTotal
        /// </summary>
        [DataMember(Name="saldoDevedorTotal", EmitDefaultValue=false)]
        public double? SaldoDevedorTotal { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SaltaExtratoAnterior
        /// </summary>
        [DataMember(Name="saltaExtratoAnterior", EmitDefaultValue=false)]
        public double? SaltaExtratoAnterior { get; set; }
  
        
        /// <summary>
        /// Gets or Sets TotalDisponivelUtilizacao
        /// </summary>
        [DataMember(Name="totalDisponivelUtilizacao", EmitDefaultValue=false)]
        public double? TotalDisponivelUtilizacao { get; set; }
  
        
        /// <summary>
        /// Gets or Sets TotalFuturo
        /// </summary>
        [DataMember(Name="totalFuturo", EmitDefaultValue=false)]
        public double? TotalFuturo { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ValorMinimoExtrato
        /// </summary>
        [DataMember(Name="valorMinimoExtrato", EmitDefaultValue=false)]
        public double? ValorMinimoExtrato { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ValorMinimoExtratoOriginal
        /// </summary>
        [DataMember(Name="valorMinimoExtratoOriginal", EmitDefaultValue=false)]
        public double? ValorMinimoExtratoOriginal { get; set; }
  
        
        /// <summary>
        /// Gets or Sets VencimentoPadraoAnterior
        /// </summary>
        [DataMember(Name="vencimentoPadraoAnterior", EmitDefaultValue=false)]
        public string VencimentoPadraoAnterior { get; set; }
  
        
        /// <summary>
        /// Gets or Sets VencimentoPosProx
        /// </summary>
        [DataMember(Name="vencimentoPosProx", EmitDefaultValue=false)]
        public string VencimentoPosProx { get; set; }
  
        
        /// <summary>
        /// Gets or Sets VencimentoRealAnterior
        /// </summary>
        [DataMember(Name="vencimentoRealAnterior", EmitDefaultValue=false)]
        public string VencimentoRealAnterior { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaldoLimiteResponse {\n");
            sb.Append("  DisponibCompraNac: ").Append(DisponibCompraNac).Append("\n");
            sb.Append("  DisponibGlobalCredito: ").Append(DisponibGlobalCredito).Append("\n");
            sb.Append("  DisponibParceladoNac: ").Append(DisponibParceladoNac).Append("\n");
            sb.Append("  DisponibParcelasNac: ").Append(DisponibParcelasNac).Append("\n");
            sb.Append("  DisponibSaqueNacGlobal: ").Append(DisponibSaqueNacGlobal).Append("\n");
            sb.Append("  FlagAntecipacao: ").Append(FlagAntecipacao).Append("\n");
            sb.Append("  LimiteCompraNac: ").Append(LimiteCompraNac).Append("\n");
            sb.Append("  LimiteCreditoConcedido: ").Append(LimiteCreditoConcedido).Append("\n");
            sb.Append("  LimiteCreditoDisponivel: ").Append(LimiteCreditoDisponivel).Append("\n");
            sb.Append("  LimiteGlobalCredito: ").Append(LimiteGlobalCredito).Append("\n");
            sb.Append("  LimiteParceladoNac: ").Append(LimiteParceladoNac).Append("\n");
            sb.Append("  LimiteParcelasNac: ").Append(LimiteParcelasNac).Append("\n");
            sb.Append("  LimitePontuacao: ").Append(LimitePontuacao).Append("\n");
            sb.Append("  LimiteSaqueNacGlobal: ").Append(LimiteSaqueNacGlobal).Append("\n");
            sb.Append("  NumeroCiclo: ").Append(NumeroCiclo).Append("\n");
            sb.Append("  PontosConcedidos: ").Append(PontosConcedidos).Append("\n");
            sb.Append("  PontosRemanescentes: ").Append(PontosRemanescentes).Append("\n");
            sb.Append("  ProximoVencimentoPadrao: ").Append(ProximoVencimentoPadrao).Append("\n");
            sb.Append("  ProximoVencimentoReal: ").Append(ProximoVencimentoReal).Append("\n");
            sb.Append("  SaldoAtualFinal: ").Append(SaldoAtualFinal).Append("\n");
            sb.Append("  SaldoCredor: ").Append(SaldoCredor).Append("\n");
            sb.Append("  SaldoDevedor: ").Append(SaldoDevedor).Append("\n");
            sb.Append("  SaldoDevedorOneroso: ").Append(SaldoDevedorOneroso).Append("\n");
            sb.Append("  SaldoDevedorTotal: ").Append(SaldoDevedorTotal).Append("\n");
            sb.Append("  SaltaExtratoAnterior: ").Append(SaltaExtratoAnterior).Append("\n");
            sb.Append("  TotalDisponivelUtilizacao: ").Append(TotalDisponivelUtilizacao).Append("\n");
            sb.Append("  TotalFuturo: ").Append(TotalFuturo).Append("\n");
            sb.Append("  ValorMinimoExtrato: ").Append(ValorMinimoExtrato).Append("\n");
            sb.Append("  ValorMinimoExtratoOriginal: ").Append(ValorMinimoExtratoOriginal).Append("\n");
            sb.Append("  VencimentoPadraoAnterior: ").Append(VencimentoPadraoAnterior).Append("\n");
            sb.Append("  VencimentoPosProx: ").Append(VencimentoPosProx).Append("\n");
            sb.Append("  VencimentoRealAnterior: ").Append(VencimentoRealAnterior).Append("\n");
            
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
            return this.Equals(obj as SaldoLimiteResponse);
        }

        /// <summary>
        /// Returns true if SaldoLimiteResponse instances are equal
        /// </summary>
        /// <param name="obj">Instance of SaldoLimiteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaldoLimiteResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.FlagAntecipacao == other.FlagAntecipacao ||
                    this.FlagAntecipacao != null &&
                    this.FlagAntecipacao.Equals(other.FlagAntecipacao)
                ) && 
                (
                    this.LimiteCompraNac == other.LimiteCompraNac ||
                    this.LimiteCompraNac != null &&
                    this.LimiteCompraNac.Equals(other.LimiteCompraNac)
                ) && 
                (
                    this.LimiteCreditoConcedido == other.LimiteCreditoConcedido ||
                    this.LimiteCreditoConcedido != null &&
                    this.LimiteCreditoConcedido.Equals(other.LimiteCreditoConcedido)
                ) && 
                (
                    this.LimiteCreditoDisponivel == other.LimiteCreditoDisponivel ||
                    this.LimiteCreditoDisponivel != null &&
                    this.LimiteCreditoDisponivel.Equals(other.LimiteCreditoDisponivel)
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
                    this.LimitePontuacao == other.LimitePontuacao ||
                    this.LimitePontuacao != null &&
                    this.LimitePontuacao.Equals(other.LimitePontuacao)
                ) && 
                (
                    this.LimiteSaqueNacGlobal == other.LimiteSaqueNacGlobal ||
                    this.LimiteSaqueNacGlobal != null &&
                    this.LimiteSaqueNacGlobal.Equals(other.LimiteSaqueNacGlobal)
                ) && 
                (
                    this.NumeroCiclo == other.NumeroCiclo ||
                    this.NumeroCiclo != null &&
                    this.NumeroCiclo.Equals(other.NumeroCiclo)
                ) && 
                (
                    this.PontosConcedidos == other.PontosConcedidos ||
                    this.PontosConcedidos != null &&
                    this.PontosConcedidos.Equals(other.PontosConcedidos)
                ) && 
                (
                    this.PontosRemanescentes == other.PontosRemanescentes ||
                    this.PontosRemanescentes != null &&
                    this.PontosRemanescentes.Equals(other.PontosRemanescentes)
                ) && 
                (
                    this.ProximoVencimentoPadrao == other.ProximoVencimentoPadrao ||
                    this.ProximoVencimentoPadrao != null &&
                    this.ProximoVencimentoPadrao.Equals(other.ProximoVencimentoPadrao)
                ) && 
                (
                    this.ProximoVencimentoReal == other.ProximoVencimentoReal ||
                    this.ProximoVencimentoReal != null &&
                    this.ProximoVencimentoReal.Equals(other.ProximoVencimentoReal)
                ) && 
                (
                    this.SaldoAtualFinal == other.SaldoAtualFinal ||
                    this.SaldoAtualFinal != null &&
                    this.SaldoAtualFinal.Equals(other.SaldoAtualFinal)
                ) && 
                (
                    this.SaldoCredor == other.SaldoCredor ||
                    this.SaldoCredor != null &&
                    this.SaldoCredor.Equals(other.SaldoCredor)
                ) && 
                (
                    this.SaldoDevedor == other.SaldoDevedor ||
                    this.SaldoDevedor != null &&
                    this.SaldoDevedor.Equals(other.SaldoDevedor)
                ) && 
                (
                    this.SaldoDevedorOneroso == other.SaldoDevedorOneroso ||
                    this.SaldoDevedorOneroso != null &&
                    this.SaldoDevedorOneroso.Equals(other.SaldoDevedorOneroso)
                ) && 
                (
                    this.SaldoDevedorTotal == other.SaldoDevedorTotal ||
                    this.SaldoDevedorTotal != null &&
                    this.SaldoDevedorTotal.Equals(other.SaldoDevedorTotal)
                ) && 
                (
                    this.SaltaExtratoAnterior == other.SaltaExtratoAnterior ||
                    this.SaltaExtratoAnterior != null &&
                    this.SaltaExtratoAnterior.Equals(other.SaltaExtratoAnterior)
                ) && 
                (
                    this.TotalDisponivelUtilizacao == other.TotalDisponivelUtilizacao ||
                    this.TotalDisponivelUtilizacao != null &&
                    this.TotalDisponivelUtilizacao.Equals(other.TotalDisponivelUtilizacao)
                ) && 
                (
                    this.TotalFuturo == other.TotalFuturo ||
                    this.TotalFuturo != null &&
                    this.TotalFuturo.Equals(other.TotalFuturo)
                ) && 
                (
                    this.ValorMinimoExtrato == other.ValorMinimoExtrato ||
                    this.ValorMinimoExtrato != null &&
                    this.ValorMinimoExtrato.Equals(other.ValorMinimoExtrato)
                ) && 
                (
                    this.ValorMinimoExtratoOriginal == other.ValorMinimoExtratoOriginal ||
                    this.ValorMinimoExtratoOriginal != null &&
                    this.ValorMinimoExtratoOriginal.Equals(other.ValorMinimoExtratoOriginal)
                ) && 
                (
                    this.VencimentoPadraoAnterior == other.VencimentoPadraoAnterior ||
                    this.VencimentoPadraoAnterior != null &&
                    this.VencimentoPadraoAnterior.Equals(other.VencimentoPadraoAnterior)
                ) && 
                (
                    this.VencimentoPosProx == other.VencimentoPosProx ||
                    this.VencimentoPosProx != null &&
                    this.VencimentoPosProx.Equals(other.VencimentoPosProx)
                ) && 
                (
                    this.VencimentoRealAnterior == other.VencimentoRealAnterior ||
                    this.VencimentoRealAnterior != null &&
                    this.VencimentoRealAnterior.Equals(other.VencimentoRealAnterior)
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
                
                if (this.DisponibCompraNac != null)
                    hash = hash * 57 + this.DisponibCompraNac.GetHashCode();
                
                if (this.DisponibGlobalCredito != null)
                    hash = hash * 57 + this.DisponibGlobalCredito.GetHashCode();
                
                if (this.DisponibParceladoNac != null)
                    hash = hash * 57 + this.DisponibParceladoNac.GetHashCode();
                
                if (this.DisponibParcelasNac != null)
                    hash = hash * 57 + this.DisponibParcelasNac.GetHashCode();
                
                if (this.DisponibSaqueNacGlobal != null)
                    hash = hash * 57 + this.DisponibSaqueNacGlobal.GetHashCode();
                
                if (this.FlagAntecipacao != null)
                    hash = hash * 57 + this.FlagAntecipacao.GetHashCode();
                
                if (this.LimiteCompraNac != null)
                    hash = hash * 57 + this.LimiteCompraNac.GetHashCode();
                
                if (this.LimiteCreditoConcedido != null)
                    hash = hash * 57 + this.LimiteCreditoConcedido.GetHashCode();
                
                if (this.LimiteCreditoDisponivel != null)
                    hash = hash * 57 + this.LimiteCreditoDisponivel.GetHashCode();
                
                if (this.LimiteGlobalCredito != null)
                    hash = hash * 57 + this.LimiteGlobalCredito.GetHashCode();
                
                if (this.LimiteParceladoNac != null)
                    hash = hash * 57 + this.LimiteParceladoNac.GetHashCode();
                
                if (this.LimiteParcelasNac != null)
                    hash = hash * 57 + this.LimiteParcelasNac.GetHashCode();
                
                if (this.LimitePontuacao != null)
                    hash = hash * 57 + this.LimitePontuacao.GetHashCode();
                
                if (this.LimiteSaqueNacGlobal != null)
                    hash = hash * 57 + this.LimiteSaqueNacGlobal.GetHashCode();
                
                if (this.NumeroCiclo != null)
                    hash = hash * 57 + this.NumeroCiclo.GetHashCode();
                
                if (this.PontosConcedidos != null)
                    hash = hash * 57 + this.PontosConcedidos.GetHashCode();
                
                if (this.PontosRemanescentes != null)
                    hash = hash * 57 + this.PontosRemanescentes.GetHashCode();
                
                if (this.ProximoVencimentoPadrao != null)
                    hash = hash * 57 + this.ProximoVencimentoPadrao.GetHashCode();
                
                if (this.ProximoVencimentoReal != null)
                    hash = hash * 57 + this.ProximoVencimentoReal.GetHashCode();
                
                if (this.SaldoAtualFinal != null)
                    hash = hash * 57 + this.SaldoAtualFinal.GetHashCode();
                
                if (this.SaldoCredor != null)
                    hash = hash * 57 + this.SaldoCredor.GetHashCode();
                
                if (this.SaldoDevedor != null)
                    hash = hash * 57 + this.SaldoDevedor.GetHashCode();
                
                if (this.SaldoDevedorOneroso != null)
                    hash = hash * 57 + this.SaldoDevedorOneroso.GetHashCode();
                
                if (this.SaldoDevedorTotal != null)
                    hash = hash * 57 + this.SaldoDevedorTotal.GetHashCode();
                
                if (this.SaltaExtratoAnterior != null)
                    hash = hash * 57 + this.SaltaExtratoAnterior.GetHashCode();
                
                if (this.TotalDisponivelUtilizacao != null)
                    hash = hash * 57 + this.TotalDisponivelUtilizacao.GetHashCode();
                
                if (this.TotalFuturo != null)
                    hash = hash * 57 + this.TotalFuturo.GetHashCode();
                
                if (this.ValorMinimoExtrato != null)
                    hash = hash * 57 + this.ValorMinimoExtrato.GetHashCode();
                
                if (this.ValorMinimoExtratoOriginal != null)
                    hash = hash * 57 + this.ValorMinimoExtratoOriginal.GetHashCode();
                
                if (this.VencimentoPadraoAnterior != null)
                    hash = hash * 57 + this.VencimentoPadraoAnterior.GetHashCode();
                
                if (this.VencimentoPosProx != null)
                    hash = hash * 57 + this.VencimentoPosProx.GetHashCode();
                
                if (this.VencimentoRealAnterior != null)
                    hash = hash * 57 + this.VencimentoRealAnterior.GetHashCode();
                
                return hash;
            }
        }

    }
}
