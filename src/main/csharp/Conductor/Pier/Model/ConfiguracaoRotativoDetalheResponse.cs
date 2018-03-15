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
    /// Objeto conta
    /// </summary>
    [DataContract]
    public partial class ConfiguracaoRotativoDetalheResponse :  IEquatable<ConfiguracaoRotativoDetalheResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguracaoRotativoDetalheResponse" /> class.
        /// Initializes a new instance of the <see cref="ConfiguracaoRotativoDetalheResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo de identifica\u00E7\u00E3o de ConfiguracaoRotativo (id)..</param>
        /// <param name="IdProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (idProduto)..</param>
        /// <param name="CompoeOfertaValorRotativo">Quando verdadeiro, indica que o valor do rotativo deve compor a oferta de parcelamento..</param>
        /// <param name="CompoeOfertaValorNaoFinanciavel">Quando verdadeiro, indica que o valor n\u00E3o financi\u00E1vel deve compor a oferta de parcelamento..</param>
        /// <param name="CompoeOfertaValorNovosLancamentos">Quando verdadeiro, indica que o valor de novos lan\u00E7amentos deve compor a oferta de parcelamento.</param>
        /// <param name="RecalculaParcelamentoParaEntradaMaior">Quando verdadeiro, indica que deve recalcular o parcelamento caso o valor pago de entrada seja maior que o valor esperado.</param>
        /// <param name="MinimoParcelasRecalculoParcelamento">Indica o m\u00EDnimo de parcelas que ser\u00E1 acatado no rec\u00E1lculo do parcelamento..</param>
        /// <param name="RecalculaParcelamento">Quando verdadeiro, indica que o parcelamento deve ser recalculado caso o valor calculado da oferta seja inferior ao valor configurado m\u00EDnimo da parcela (valorMinimoParcela) e de percentual aberto.</param>
        /// <param name="NumeroMinimoOfertas">N\u00FAmero m\u00EDnimo de parcelas que ser\u00E1 acatado no recalculo da oferta..</param>
        /// <param name="AceitaPagamentoMaiorQueEntrada">Quando verdadeiro, indica que valores pagos entre o valor da entrada e o m\u00EDnimo da fatura ser\u00E3o acatados para a ades\u00E3o ao parcelamento.</param>
        /// <param name="AntecipaParcelamentosAbertos">Quando verdadeiro, indica que deve-se incluir o valor presente dos parcelamentos em aberto..</param>
        /// <param name="ValorMinimoParcela">Valor m\u00EDnimo da parcela que deve ser aceito na oferta..</param>
        /// <param name="PercentualLimitarValorMinimoParcela">Percentual sobre os valores de parcelamento anteriores em aberto que deve ser considerado para limitar valorMinimoParcela..</param>
        /// <param name="IdRegraCampanha">C\u00F3digo de Identifica\u00E7\u00E3o da regra de campanha..</param>
        /// <param name="ParcelarApenasMinimo">Quando verdadeiro, indica que parcelamento ofertado ter\u00E1 como valor base o valor m\u00EDnimo das transa\u00E7\u00F5es..</param>
        /// <param name="Usuario">Nome do usu\u00E1rio..</param>

        public ConfiguracaoRotativoDetalheResponse(long? Id = null, long? IdProduto = null, bool? CompoeOfertaValorRotativo = null, bool? CompoeOfertaValorNaoFinanciavel = null, bool? CompoeOfertaValorNovosLancamentos = null, bool? RecalculaParcelamentoParaEntradaMaior = null, bool? MinimoParcelasRecalculoParcelamento = null, bool? RecalculaParcelamento = null, bool? NumeroMinimoOfertas = null, bool? AceitaPagamentoMaiorQueEntrada = null, bool? AntecipaParcelamentosAbertos = null, double? ValorMinimoParcela = null, double? PercentualLimitarValorMinimoParcela = null, long? IdRegraCampanha = null, bool? ParcelarApenasMinimo = null, string Usuario = null)
        {
            this.Id = Id;
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
        /// C\u00F3digo de identifica\u00E7\u00E3o de ConfiguracaoRotativo (id).
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o de ConfiguracaoRotativo (id).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Produto (idProduto).
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Produto (idProduto).</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Quando verdadeiro, indica que o valor do rotativo deve compor a oferta de parcelamento.
        /// </summary>
        /// <value>Quando verdadeiro, indica que o valor do rotativo deve compor a oferta de parcelamento.</value>
        [DataMember(Name="compoeOfertaValorRotativo", EmitDefaultValue=false)]
        public bool? CompoeOfertaValorRotativo { get; set; }
    
        /// <summary>
        /// Quando verdadeiro, indica que o valor n\u00E3o financi\u00E1vel deve compor a oferta de parcelamento.
        /// </summary>
        /// <value>Quando verdadeiro, indica que o valor n\u00E3o financi\u00E1vel deve compor a oferta de parcelamento.</value>
        [DataMember(Name="compoeOfertaValorNaoFinanciavel", EmitDefaultValue=false)]
        public bool? CompoeOfertaValorNaoFinanciavel { get; set; }
    
        /// <summary>
        /// Quando verdadeiro, indica que o valor de novos lan\u00E7amentos deve compor a oferta de parcelamento
        /// </summary>
        /// <value>Quando verdadeiro, indica que o valor de novos lan\u00E7amentos deve compor a oferta de parcelamento</value>
        [DataMember(Name="compoeOfertaValorNovosLancamentos", EmitDefaultValue=false)]
        public bool? CompoeOfertaValorNovosLancamentos { get; set; }
    
        /// <summary>
        /// Quando verdadeiro, indica que deve recalcular o parcelamento caso o valor pago de entrada seja maior que o valor esperado
        /// </summary>
        /// <value>Quando verdadeiro, indica que deve recalcular o parcelamento caso o valor pago de entrada seja maior que o valor esperado</value>
        [DataMember(Name="recalculaParcelamentoParaEntradaMaior", EmitDefaultValue=false)]
        public bool? RecalculaParcelamentoParaEntradaMaior { get; set; }
    
        /// <summary>
        /// Indica o m\u00EDnimo de parcelas que ser\u00E1 acatado no rec\u00E1lculo do parcelamento.
        /// </summary>
        /// <value>Indica o m\u00EDnimo de parcelas que ser\u00E1 acatado no rec\u00E1lculo do parcelamento.</value>
        [DataMember(Name="minimoParcelasRecalculoParcelamento", EmitDefaultValue=false)]
        public bool? MinimoParcelasRecalculoParcelamento { get; set; }
    
        /// <summary>
        /// Quando verdadeiro, indica que o parcelamento deve ser recalculado caso o valor calculado da oferta seja inferior ao valor configurado m\u00EDnimo da parcela (valorMinimoParcela) e de percentual aberto
        /// </summary>
        /// <value>Quando verdadeiro, indica que o parcelamento deve ser recalculado caso o valor calculado da oferta seja inferior ao valor configurado m\u00EDnimo da parcela (valorMinimoParcela) e de percentual aberto</value>
        [DataMember(Name="recalculaParcelamento", EmitDefaultValue=false)]
        public bool? RecalculaParcelamento { get; set; }
    
        /// <summary>
        /// N\u00FAmero m\u00EDnimo de parcelas que ser\u00E1 acatado no recalculo da oferta.
        /// </summary>
        /// <value>N\u00FAmero m\u00EDnimo de parcelas que ser\u00E1 acatado no recalculo da oferta.</value>
        [DataMember(Name="numeroMinimoOfertas", EmitDefaultValue=false)]
        public bool? NumeroMinimoOfertas { get; set; }
    
        /// <summary>
        /// Quando verdadeiro, indica que valores pagos entre o valor da entrada e o m\u00EDnimo da fatura ser\u00E3o acatados para a ades\u00E3o ao parcelamento
        /// </summary>
        /// <value>Quando verdadeiro, indica que valores pagos entre o valor da entrada e o m\u00EDnimo da fatura ser\u00E3o acatados para a ades\u00E3o ao parcelamento</value>
        [DataMember(Name="aceitaPagamentoMaiorQueEntrada", EmitDefaultValue=false)]
        public bool? AceitaPagamentoMaiorQueEntrada { get; set; }
    
        /// <summary>
        /// Quando verdadeiro, indica que deve-se incluir o valor presente dos parcelamentos em aberto.
        /// </summary>
        /// <value>Quando verdadeiro, indica que deve-se incluir o valor presente dos parcelamentos em aberto.</value>
        [DataMember(Name="antecipaParcelamentosAbertos", EmitDefaultValue=false)]
        public bool? AntecipaParcelamentosAbertos { get; set; }
    
        /// <summary>
        /// Valor m\u00EDnimo da parcela que deve ser aceito na oferta.
        /// </summary>
        /// <value>Valor m\u00EDnimo da parcela que deve ser aceito na oferta.</value>
        [DataMember(Name="valorMinimoParcela", EmitDefaultValue=false)]
        public double? ValorMinimoParcela { get; set; }
    
        /// <summary>
        /// Percentual sobre os valores de parcelamento anteriores em aberto que deve ser considerado para limitar valorMinimoParcela.
        /// </summary>
        /// <value>Percentual sobre os valores de parcelamento anteriores em aberto que deve ser considerado para limitar valorMinimoParcela.</value>
        [DataMember(Name="percentualLimitarValorMinimoParcela", EmitDefaultValue=false)]
        public double? PercentualLimitarValorMinimoParcela { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da regra de campanha.
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da regra de campanha.</value>
        [DataMember(Name="idRegraCampanha", EmitDefaultValue=false)]
        public long? IdRegraCampanha { get; set; }
    
        /// <summary>
        /// Quando verdadeiro, indica que parcelamento ofertado ter\u00E1 como valor base o valor m\u00EDnimo das transa\u00E7\u00F5es.
        /// </summary>
        /// <value>Quando verdadeiro, indica que parcelamento ofertado ter\u00E1 como valor base o valor m\u00EDnimo das transa\u00E7\u00F5es.</value>
        [DataMember(Name="parcelarApenasMinimo", EmitDefaultValue=false)]
        public bool? ParcelarApenasMinimo { get; set; }
    
        /// <summary>
        /// Nome do usu\u00E1rio.
        /// </summary>
        /// <value>Nome do usu\u00E1rio.</value>
        [DataMember(Name="usuario", EmitDefaultValue=false)]
        public string Usuario { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfiguracaoRotativoDetalheResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as ConfiguracaoRotativoDetalheResponse);
        }

        /// <summary>
        /// Returns true if ConfiguracaoRotativoDetalheResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ConfiguracaoRotativoDetalheResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfiguracaoRotativoDetalheResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
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
