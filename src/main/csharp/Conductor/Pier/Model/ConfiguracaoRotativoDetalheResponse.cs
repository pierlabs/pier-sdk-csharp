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
    /// {{{configuracao_rotativo_detalhe_response_description}}}
    /// </summary>
    [DataContract]
    public partial class ConfiguracaoRotativoDetalheResponse :  IEquatable<ConfiguracaoRotativoDetalheResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguracaoRotativoDetalheResponse" /> class.
        /// Initializes a new instance of the <see cref="ConfiguracaoRotativoDetalheResponse" />class.
        /// </summary>
        /// <param name="Id">{{{configuracao_rotativo_detalhe_response_id_value}}}.</param>
        /// <param name="IdProduto">{{{configuracao_rotativo_detalhe_response_id_produto_value}}}.</param>
        /// <param name="CompoeOfertaValorRotativo">{{{configuracao_rotativo_detalhe_response_compoe_oferta_valor_rotativo_value}}}.</param>
        /// <param name="CompoeOfertaValorNaoFinanciavel">{{{configuracao_rotativo_detalhe_response_compoe_oferta_valor_nao_financiavel_value}}}.</param>
        /// <param name="CompoeOfertaValorNovosLancamentos">{{{configuracao_rotativo_detalhe_response_compoe_oferta_valor_novos_lancamentos_value}}}.</param>
        /// <param name="RecalculaParcelamentoParaEntradaMaior">{{{configuracao_rotativo_detalhe_response_recalcula_parcelamento_para_entrada_maior_value}}}.</param>
        /// <param name="MinimoParcelasRecalculoParcelamento">{{{configuracao_rotativo_detalhe_response_minimo_parcelas_recalculo_parcelamento_value}}}.</param>
        /// <param name="RecalculaParcelamento">{{{configuracao_rotativo_detalhe_response_recalcula_parcelamento_value}}}.</param>
        /// <param name="NumeroMinimoOfertas">{{{configuracao_rotativo_detalhe_response_numero_minimo_ofertas_value}}}.</param>
        /// <param name="AceitaPagamentoMaiorQueEntrada">{{{configuracao_rotativo_detalhe_response_aceita_pagamento_maior_que_entrada_value}}}.</param>
        /// <param name="AntecipaParcelamentosAbertos">{{{configuracao_rotativo_detalhe_response_antecipa_parcelamentos_abertos_value}}}.</param>
        /// <param name="ValorMinimoParcela">{{{configuracao_rotativo_detalhe_response_valor_minimo_parcela_value}}}.</param>
        /// <param name="PercentualLimitarValorMinimoParcela">{{{configuracao_rotativo_detalhe_response_percentual_limitar_valor_minimo_parcela_value}}}.</param>
        /// <param name="IdRegraCampanha">{{{configuracao_rotativo_detalhe_response_id_regra_campanha_value}}}.</param>
        /// <param name="ParcelarApenasMinimo">{{{configuracao_rotativo_detalhe_response_parcelar_apenas_minimo_value}}}.</param>
        /// <param name="Usuario">{{{configuracao_rotativo_detalhe_response_usuario_value}}}.</param>

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
        /// {{{configuracao_rotativo_detalhe_response_id_value}}}
        /// </summary>
        /// <value>{{{configuracao_rotativo_detalhe_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{configuracao_rotativo_detalhe_response_id_produto_value}}}
        /// </summary>
        /// <value>{{{configuracao_rotativo_detalhe_response_id_produto_value}}}</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// {{{configuracao_rotativo_detalhe_response_compoe_oferta_valor_rotativo_value}}}
        /// </summary>
        /// <value>{{{configuracao_rotativo_detalhe_response_compoe_oferta_valor_rotativo_value}}}</value>
        [DataMember(Name="compoeOfertaValorRotativo", EmitDefaultValue=false)]
        public bool? CompoeOfertaValorRotativo { get; set; }
    
        /// <summary>
        /// {{{configuracao_rotativo_detalhe_response_compoe_oferta_valor_nao_financiavel_value}}}
        /// </summary>
        /// <value>{{{configuracao_rotativo_detalhe_response_compoe_oferta_valor_nao_financiavel_value}}}</value>
        [DataMember(Name="compoeOfertaValorNaoFinanciavel", EmitDefaultValue=false)]
        public bool? CompoeOfertaValorNaoFinanciavel { get; set; }
    
        /// <summary>
        /// {{{configuracao_rotativo_detalhe_response_compoe_oferta_valor_novos_lancamentos_value}}}
        /// </summary>
        /// <value>{{{configuracao_rotativo_detalhe_response_compoe_oferta_valor_novos_lancamentos_value}}}</value>
        [DataMember(Name="compoeOfertaValorNovosLancamentos", EmitDefaultValue=false)]
        public bool? CompoeOfertaValorNovosLancamentos { get; set; }
    
        /// <summary>
        /// {{{configuracao_rotativo_detalhe_response_recalcula_parcelamento_para_entrada_maior_value}}}
        /// </summary>
        /// <value>{{{configuracao_rotativo_detalhe_response_recalcula_parcelamento_para_entrada_maior_value}}}</value>
        [DataMember(Name="recalculaParcelamentoParaEntradaMaior", EmitDefaultValue=false)]
        public bool? RecalculaParcelamentoParaEntradaMaior { get; set; }
    
        /// <summary>
        /// {{{configuracao_rotativo_detalhe_response_minimo_parcelas_recalculo_parcelamento_value}}}
        /// </summary>
        /// <value>{{{configuracao_rotativo_detalhe_response_minimo_parcelas_recalculo_parcelamento_value}}}</value>
        [DataMember(Name="minimoParcelasRecalculoParcelamento", EmitDefaultValue=false)]
        public bool? MinimoParcelasRecalculoParcelamento { get; set; }
    
        /// <summary>
        /// {{{configuracao_rotativo_detalhe_response_recalcula_parcelamento_value}}}
        /// </summary>
        /// <value>{{{configuracao_rotativo_detalhe_response_recalcula_parcelamento_value}}}</value>
        [DataMember(Name="recalculaParcelamento", EmitDefaultValue=false)]
        public bool? RecalculaParcelamento { get; set; }
    
        /// <summary>
        /// {{{configuracao_rotativo_detalhe_response_numero_minimo_ofertas_value}}}
        /// </summary>
        /// <value>{{{configuracao_rotativo_detalhe_response_numero_minimo_ofertas_value}}}</value>
        [DataMember(Name="numeroMinimoOfertas", EmitDefaultValue=false)]
        public bool? NumeroMinimoOfertas { get; set; }
    
        /// <summary>
        /// {{{configuracao_rotativo_detalhe_response_aceita_pagamento_maior_que_entrada_value}}}
        /// </summary>
        /// <value>{{{configuracao_rotativo_detalhe_response_aceita_pagamento_maior_que_entrada_value}}}</value>
        [DataMember(Name="aceitaPagamentoMaiorQueEntrada", EmitDefaultValue=false)]
        public bool? AceitaPagamentoMaiorQueEntrada { get; set; }
    
        /// <summary>
        /// {{{configuracao_rotativo_detalhe_response_antecipa_parcelamentos_abertos_value}}}
        /// </summary>
        /// <value>{{{configuracao_rotativo_detalhe_response_antecipa_parcelamentos_abertos_value}}}</value>
        [DataMember(Name="antecipaParcelamentosAbertos", EmitDefaultValue=false)]
        public bool? AntecipaParcelamentosAbertos { get; set; }
    
        /// <summary>
        /// {{{configuracao_rotativo_detalhe_response_valor_minimo_parcela_value}}}
        /// </summary>
        /// <value>{{{configuracao_rotativo_detalhe_response_valor_minimo_parcela_value}}}</value>
        [DataMember(Name="valorMinimoParcela", EmitDefaultValue=false)]
        public double? ValorMinimoParcela { get; set; }
    
        /// <summary>
        /// {{{configuracao_rotativo_detalhe_response_percentual_limitar_valor_minimo_parcela_value}}}
        /// </summary>
        /// <value>{{{configuracao_rotativo_detalhe_response_percentual_limitar_valor_minimo_parcela_value}}}</value>
        [DataMember(Name="percentualLimitarValorMinimoParcela", EmitDefaultValue=false)]
        public double? PercentualLimitarValorMinimoParcela { get; set; }
    
        /// <summary>
        /// {{{configuracao_rotativo_detalhe_response_id_regra_campanha_value}}}
        /// </summary>
        /// <value>{{{configuracao_rotativo_detalhe_response_id_regra_campanha_value}}}</value>
        [DataMember(Name="idRegraCampanha", EmitDefaultValue=false)]
        public long? IdRegraCampanha { get; set; }
    
        /// <summary>
        /// {{{configuracao_rotativo_detalhe_response_parcelar_apenas_minimo_value}}}
        /// </summary>
        /// <value>{{{configuracao_rotativo_detalhe_response_parcelar_apenas_minimo_value}}}</value>
        [DataMember(Name="parcelarApenasMinimo", EmitDefaultValue=false)]
        public bool? ParcelarApenasMinimo { get; set; }
    
        /// <summary>
        /// {{{configuracao_rotativo_detalhe_response_usuario_value}}}
        /// </summary>
        /// <value>{{{configuracao_rotativo_detalhe_response_usuario_value}}}</value>
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
