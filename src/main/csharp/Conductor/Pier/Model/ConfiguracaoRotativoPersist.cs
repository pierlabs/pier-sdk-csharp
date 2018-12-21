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
    /// Revolving Configuration
    /// </summary>
    [DataContract]
    public partial class ConfiguracaoRotativoPersist :  IEquatable<ConfiguracaoRotativoPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguracaoRotativoPersist" /> class.
        /// Initializes a new instance of the <see cref="ConfiguracaoRotativoPersist" />class.
        /// </summary>
        /// <param name="IdProduto">C?digo de Identifica??o do Produto (idProduto).</param>
        /// <param name="CompoeOfertaValorRotativo">When it is true, indicates that the revolving value must compose the installment offer.</param>
        /// <param name="CompoeOfertaValorNaoFinanciavel">When it is true, indicate that the non financing value must compose the offer of installment.</param>
        /// <param name="CompoeOfertaValorNovosLancamentos">When it is true, indicate that the value of the new lauching must have the offer of installment.</param>
        /// <param name="RecalculaParcelamentoParaEntradaMaior">When it is true, it indicates that must recalculate the installment in case the entrance paid value be higher than the expected value.</param>
        /// <param name="MinimoParcelasRecalculoParcelamento">Indicate the minimum of parcels that will be abided by the recalculation of the installment.</param>
        /// <param name="RecalculaParcelamento">when it is true, indicate that the installment must be recalculated in case the value calculated of the offer is inferior to the configurated minimum parcel value (valueMinimumParcel) and the opened percentage.</param>
        /// <param name="NumeroMinimoOfertas">Minimum number of parcels that will be abided in the offer recalculate.</param>
        /// <param name="AceitaPagamentoMaiorQueEntrada">When it is true, indicates that values paid between the entrance value and the minimum of the invoice will be abided to the accession of the installment.</param>
        /// <param name="AntecipaParcelamentosAbertos">When it is true, indicates that mus include the value of the installment opened.</param>
        /// <param name="ValorMinimoParcela">Minimum value of the parcel must be accepted in the offer.</param>
        /// <param name="PercentualLimitarValorMinimoParcela">Percentage about the previous installment values opened that must be considered to limit valueMinimumParcel.</param>
        /// <param name="IdRegraCampanha">C?digo de Identifica??o da regra de campanha.</param>
        /// <param name="ParcelarApenasMinimo">When it is true, indicate that the offered installment will have as value base the minimum value of the transactions.</param>
        /// <param name="Usuario">Username.</param>

        public ConfiguracaoRotativoPersist(long? IdProduto = null, bool? CompoeOfertaValorRotativo = null, bool? CompoeOfertaValorNaoFinanciavel = null, bool? CompoeOfertaValorNovosLancamentos = null, bool? RecalculaParcelamentoParaEntradaMaior = null, bool? MinimoParcelasRecalculoParcelamento = null, bool? RecalculaParcelamento = null, bool? NumeroMinimoOfertas = null, bool? AceitaPagamentoMaiorQueEntrada = null, bool? AntecipaParcelamentosAbertos = null, double? ValorMinimoParcela = null, double? PercentualLimitarValorMinimoParcela = null, long? IdRegraCampanha = null, bool? ParcelarApenasMinimo = null, string Usuario = null)
        {
            this.IdProduto = IdProduto;
            this.CompoeOfertaValorRotativo = CompoeOfertaValorRotativo;
            this.CompoeOfertaValorNaoFinanciavel = CompoeOfertaValorNaoFinanciavel;
            this.CompoeOfertaValorNovosLancamentos = CompoeOfertaValorNovosLancamentos;
            this.RecalculaParcelamentoParaEntradaMaior = RecalculaParcelamentoParaEntradaMaior;
            this.MinimoParcelasRecalculoParcelamento = MinimoParcelasRecalculoParcelamento;
            this.RecalculaParcelamento = RecalculaParcelamento;
            this.NumeroMinimoOfertas = NumeroMinimoOfertas;
            this.AceitaPagamentoMaiorQueEntrada = AceitaPagamentoMaiorQueEntrada;
            this.AntecipaParcelamentosAbertos = AntecipaParcelamentosAbertos;
            this.ValorMinimoParcela = ValorMinimoParcela;
            this.PercentualLimitarValorMinimoParcela = PercentualLimitarValorMinimoParcela;
            this.IdRegraCampanha = IdRegraCampanha;
            this.ParcelarApenasMinimo = ParcelarApenasMinimo;
            this.Usuario = Usuario;
            
        }
        
    
        /// <summary>
        /// C?digo de Identifica??o do Produto (idProduto)
        /// </summary>
        /// <value>C?digo de Identifica??o do Produto (idProduto)</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// When it is true, indicates that the revolving value must compose the installment offer
        /// </summary>
        /// <value>When it is true, indicates that the revolving value must compose the installment offer</value>
        [DataMember(Name="compoeOfertaValorRotativo", EmitDefaultValue=false)]
        public bool? CompoeOfertaValorRotativo { get; set; }
    
        /// <summary>
        /// When it is true, indicate that the non financing value must compose the offer of installment
        /// </summary>
        /// <value>When it is true, indicate that the non financing value must compose the offer of installment</value>
        [DataMember(Name="compoeOfertaValorNaoFinanciavel", EmitDefaultValue=false)]
        public bool? CompoeOfertaValorNaoFinanciavel { get; set; }
    
        /// <summary>
        /// When it is true, indicate that the value of the new lauching must have the offer of installment
        /// </summary>
        /// <value>When it is true, indicate that the value of the new lauching must have the offer of installment</value>
        [DataMember(Name="compoeOfertaValorNovosLancamentos", EmitDefaultValue=false)]
        public bool? CompoeOfertaValorNovosLancamentos { get; set; }
    
        /// <summary>
        /// When it is true, it indicates that must recalculate the installment in case the entrance paid value be higher than the expected value
        /// </summary>
        /// <value>When it is true, it indicates that must recalculate the installment in case the entrance paid value be higher than the expected value</value>
        [DataMember(Name="recalculaParcelamentoParaEntradaMaior", EmitDefaultValue=false)]
        public bool? RecalculaParcelamentoParaEntradaMaior { get; set; }
    
        /// <summary>
        /// Indicate the minimum of parcels that will be abided by the recalculation of the installment
        /// </summary>
        /// <value>Indicate the minimum of parcels that will be abided by the recalculation of the installment</value>
        [DataMember(Name="minimoParcelasRecalculoParcelamento", EmitDefaultValue=false)]
        public bool? MinimoParcelasRecalculoParcelamento { get; set; }
    
        /// <summary>
        /// when it is true, indicate that the installment must be recalculated in case the value calculated of the offer is inferior to the configurated minimum parcel value (valueMinimumParcel) and the opened percentage
        /// </summary>
        /// <value>when it is true, indicate that the installment must be recalculated in case the value calculated of the offer is inferior to the configurated minimum parcel value (valueMinimumParcel) and the opened percentage</value>
        [DataMember(Name="recalculaParcelamento", EmitDefaultValue=false)]
        public bool? RecalculaParcelamento { get; set; }
    
        /// <summary>
        /// Minimum number of parcels that will be abided in the offer recalculate
        /// </summary>
        /// <value>Minimum number of parcels that will be abided in the offer recalculate</value>
        [DataMember(Name="numeroMinimoOfertas", EmitDefaultValue=false)]
        public bool? NumeroMinimoOfertas { get; set; }
    
        /// <summary>
        /// When it is true, indicates that values paid between the entrance value and the minimum of the invoice will be abided to the accession of the installment
        /// </summary>
        /// <value>When it is true, indicates that values paid between the entrance value and the minimum of the invoice will be abided to the accession of the installment</value>
        [DataMember(Name="aceitaPagamentoMaiorQueEntrada", EmitDefaultValue=false)]
        public bool? AceitaPagamentoMaiorQueEntrada { get; set; }
    
        /// <summary>
        /// When it is true, indicates that mus include the value of the installment opened
        /// </summary>
        /// <value>When it is true, indicates that mus include the value of the installment opened</value>
        [DataMember(Name="antecipaParcelamentosAbertos", EmitDefaultValue=false)]
        public bool? AntecipaParcelamentosAbertos { get; set; }
    
        /// <summary>
        /// Minimum value of the parcel must be accepted in the offer
        /// </summary>
        /// <value>Minimum value of the parcel must be accepted in the offer</value>
        [DataMember(Name="valorMinimoParcela", EmitDefaultValue=false)]
        public double? ValorMinimoParcela { get; set; }
    
        /// <summary>
        /// Percentage about the previous installment values opened that must be considered to limit valueMinimumParcel
        /// </summary>
        /// <value>Percentage about the previous installment values opened that must be considered to limit valueMinimumParcel</value>
        [DataMember(Name="percentualLimitarValorMinimoParcela", EmitDefaultValue=false)]
        public double? PercentualLimitarValorMinimoParcela { get; set; }
    
        /// <summary>
        /// C?digo de Identifica??o da regra de campanha
        /// </summary>
        /// <value>C?digo de Identifica??o da regra de campanha</value>
        [DataMember(Name="idRegraCampanha", EmitDefaultValue=false)]
        public long? IdRegraCampanha { get; set; }
    
        /// <summary>
        /// When it is true, indicate that the offered installment will have as value base the minimum value of the transactions
        /// </summary>
        /// <value>When it is true, indicate that the offered installment will have as value base the minimum value of the transactions</value>
        [DataMember(Name="parcelarApenasMinimo", EmitDefaultValue=false)]
        public bool? ParcelarApenasMinimo { get; set; }
    
        /// <summary>
        /// Username
        /// </summary>
        /// <value>Username</value>
        [DataMember(Name="usuario", EmitDefaultValue=false)]
        public string Usuario { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfiguracaoRotativoPersist {\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  CompoeOfertaValorRotativo: ").Append(CompoeOfertaValorRotativo).Append("\n");
            sb.Append("  CompoeOfertaValorNaoFinanciavel: ").Append(CompoeOfertaValorNaoFinanciavel).Append("\n");
            sb.Append("  CompoeOfertaValorNovosLancamentos: ").Append(CompoeOfertaValorNovosLancamentos).Append("\n");
            sb.Append("  RecalculaParcelamentoParaEntradaMaior: ").Append(RecalculaParcelamentoParaEntradaMaior).Append("\n");
            sb.Append("  MinimoParcelasRecalculoParcelamento: ").Append(MinimoParcelasRecalculoParcelamento).Append("\n");
            sb.Append("  RecalculaParcelamento: ").Append(RecalculaParcelamento).Append("\n");
            sb.Append("  NumeroMinimoOfertas: ").Append(NumeroMinimoOfertas).Append("\n");
            sb.Append("  AceitaPagamentoMaiorQueEntrada: ").Append(AceitaPagamentoMaiorQueEntrada).Append("\n");
            sb.Append("  AntecipaParcelamentosAbertos: ").Append(AntecipaParcelamentosAbertos).Append("\n");
            sb.Append("  ValorMinimoParcela: ").Append(ValorMinimoParcela).Append("\n");
            sb.Append("  PercentualLimitarValorMinimoParcela: ").Append(PercentualLimitarValorMinimoParcela).Append("\n");
            sb.Append("  IdRegraCampanha: ").Append(IdRegraCampanha).Append("\n");
            sb.Append("  ParcelarApenasMinimo: ").Append(ParcelarApenasMinimo).Append("\n");
            sb.Append("  Usuario: ").Append(Usuario).Append("\n");
            
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
            return this.Equals(obj as ConfiguracaoRotativoPersist);
        }

        /// <summary>
        /// Returns true if ConfiguracaoRotativoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of ConfiguracaoRotativoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfiguracaoRotativoPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.CompoeOfertaValorRotativo == other.CompoeOfertaValorRotativo ||
                    this.CompoeOfertaValorRotativo != null &&
                    this.CompoeOfertaValorRotativo.Equals(other.CompoeOfertaValorRotativo)
                ) && 
                (
                    this.CompoeOfertaValorNaoFinanciavel == other.CompoeOfertaValorNaoFinanciavel ||
                    this.CompoeOfertaValorNaoFinanciavel != null &&
                    this.CompoeOfertaValorNaoFinanciavel.Equals(other.CompoeOfertaValorNaoFinanciavel)
                ) && 
                (
                    this.CompoeOfertaValorNovosLancamentos == other.CompoeOfertaValorNovosLancamentos ||
                    this.CompoeOfertaValorNovosLancamentos != null &&
                    this.CompoeOfertaValorNovosLancamentos.Equals(other.CompoeOfertaValorNovosLancamentos)
                ) && 
                (
                    this.RecalculaParcelamentoParaEntradaMaior == other.RecalculaParcelamentoParaEntradaMaior ||
                    this.RecalculaParcelamentoParaEntradaMaior != null &&
                    this.RecalculaParcelamentoParaEntradaMaior.Equals(other.RecalculaParcelamentoParaEntradaMaior)
                ) && 
                (
                    this.MinimoParcelasRecalculoParcelamento == other.MinimoParcelasRecalculoParcelamento ||
                    this.MinimoParcelasRecalculoParcelamento != null &&
                    this.MinimoParcelasRecalculoParcelamento.Equals(other.MinimoParcelasRecalculoParcelamento)
                ) && 
                (
                    this.RecalculaParcelamento == other.RecalculaParcelamento ||
                    this.RecalculaParcelamento != null &&
                    this.RecalculaParcelamento.Equals(other.RecalculaParcelamento)
                ) && 
                (
                    this.NumeroMinimoOfertas == other.NumeroMinimoOfertas ||
                    this.NumeroMinimoOfertas != null &&
                    this.NumeroMinimoOfertas.Equals(other.NumeroMinimoOfertas)
                ) && 
                (
                    this.AceitaPagamentoMaiorQueEntrada == other.AceitaPagamentoMaiorQueEntrada ||
                    this.AceitaPagamentoMaiorQueEntrada != null &&
                    this.AceitaPagamentoMaiorQueEntrada.Equals(other.AceitaPagamentoMaiorQueEntrada)
                ) && 
                (
                    this.AntecipaParcelamentosAbertos == other.AntecipaParcelamentosAbertos ||
                    this.AntecipaParcelamentosAbertos != null &&
                    this.AntecipaParcelamentosAbertos.Equals(other.AntecipaParcelamentosAbertos)
                ) && 
                (
                    this.ValorMinimoParcela == other.ValorMinimoParcela ||
                    this.ValorMinimoParcela != null &&
                    this.ValorMinimoParcela.Equals(other.ValorMinimoParcela)
                ) && 
                (
                    this.PercentualLimitarValorMinimoParcela == other.PercentualLimitarValorMinimoParcela ||
                    this.PercentualLimitarValorMinimoParcela != null &&
                    this.PercentualLimitarValorMinimoParcela.Equals(other.PercentualLimitarValorMinimoParcela)
                ) && 
                (
                    this.IdRegraCampanha == other.IdRegraCampanha ||
                    this.IdRegraCampanha != null &&
                    this.IdRegraCampanha.Equals(other.IdRegraCampanha)
                ) && 
                (
                    this.ParcelarApenasMinimo == other.ParcelarApenasMinimo ||
                    this.ParcelarApenasMinimo != null &&
                    this.ParcelarApenasMinimo.Equals(other.ParcelarApenasMinimo)
                ) && 
                (
                    this.Usuario == other.Usuario ||
                    this.Usuario != null &&
                    this.Usuario.Equals(other.Usuario)
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
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.CompoeOfertaValorRotativo != null)
                    hash = hash * 59 + this.CompoeOfertaValorRotativo.GetHashCode();
                
                if (this.CompoeOfertaValorNaoFinanciavel != null)
                    hash = hash * 59 + this.CompoeOfertaValorNaoFinanciavel.GetHashCode();
                
                if (this.CompoeOfertaValorNovosLancamentos != null)
                    hash = hash * 59 + this.CompoeOfertaValorNovosLancamentos.GetHashCode();
                
                if (this.RecalculaParcelamentoParaEntradaMaior != null)
                    hash = hash * 59 + this.RecalculaParcelamentoParaEntradaMaior.GetHashCode();
                
                if (this.MinimoParcelasRecalculoParcelamento != null)
                    hash = hash * 59 + this.MinimoParcelasRecalculoParcelamento.GetHashCode();
                
                if (this.RecalculaParcelamento != null)
                    hash = hash * 59 + this.RecalculaParcelamento.GetHashCode();
                
                if (this.NumeroMinimoOfertas != null)
                    hash = hash * 59 + this.NumeroMinimoOfertas.GetHashCode();
                
                if (this.AceitaPagamentoMaiorQueEntrada != null)
                    hash = hash * 59 + this.AceitaPagamentoMaiorQueEntrada.GetHashCode();
                
                if (this.AntecipaParcelamentosAbertos != null)
                    hash = hash * 59 + this.AntecipaParcelamentosAbertos.GetHashCode();
                
                if (this.ValorMinimoParcela != null)
                    hash = hash * 59 + this.ValorMinimoParcela.GetHashCode();
                
                if (this.PercentualLimitarValorMinimoParcela != null)
                    hash = hash * 59 + this.PercentualLimitarValorMinimoParcela.GetHashCode();
                
                if (this.IdRegraCampanha != null)
                    hash = hash * 59 + this.IdRegraCampanha.GetHashCode();
                
                if (this.ParcelarApenasMinimo != null)
                    hash = hash * 59 + this.ParcelarApenasMinimo.GetHashCode();
                
                if (this.Usuario != null)
                    hash = hash * 59 + this.Usuario.GetHashCode();
                
                return hash;
            }
        }

    }
}
