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
    /// {{{detalhe_operacao_response_description}}}
    /// </summary>
    [DataContract]
    public partial class DetalheOperacaoResponse :  IEquatable<DetalheOperacaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DetalheOperacaoResponse" /> class.
        /// Initializes a new instance of the <see cref="DetalheOperacaoResponse" />class.
        /// </summary>
        /// <param name="IdOperacao">{{{detalhe_operacao_response_id_operacao_value}}}.</param>
        /// <param name="CodigoProcessamento">{{{detalhe_operacao_response_codigo_processamento_value}}}.</param>
        /// <param name="CodigoProcessamentoCancelamento">{{{detalhe_operacao_response_codigo_processamento_cancelamento_value}}}.</param>
        /// <param name="NomeOperacao">{{{detalhe_operacao_response_nome_operacao_value}}}.</param>
        /// <param name="DescricaoOperacao">{{{detalhe_operacao_response_descricao_operacao_value}}}.</param>
        /// <param name="PlanoMinimo">{{{detalhe_operacao_response_plano_minimo_value}}}.</param>
        /// <param name="PlanoMaximo">{{{detalhe_operacao_response_plano_maximo_value}}}.</param>
        /// <param name="ValorMinimo">{{{detalhe_operacao_response_valor_minimo_value}}}.</param>
        /// <param name="ValorMaximo">{{{detalhe_operacao_response_valor_maximo_value}}}.</param>
        /// <param name="FlagCobraJuros">{{{detalhe_operacao_response_flag_cobra_juros_value}}}.</param>
        /// <param name="TaxaJuros">{{{detalhe_operacao_response_taxa_juros_value}}}.</param>
        /// <param name="FlagCobraTarifa">{{{detalhe_operacao_response_flag_cobra_tarifa_value}}}.</param>
        /// <param name="TaxaTarifa">{{{detalhe_operacao_response_taxa_tarifa_value}}}.</param>
        /// <param name="ValorTac">{{{detalhe_operacao_response_valor_tac_value}}}.</param>
        /// <param name="PercentualTac">{{{detalhe_operacao_response_percentual_tac_value}}}.</param>
        /// <param name="ValorOperacao">{{{detalhe_operacao_response_valor_operacao_value}}}.</param>
        /// <param name="Carencia">{{{detalhe_operacao_response_carencia_value}}}.</param>
        /// <param name="ExcedentePermitido">{{{detalhe_operacao_response_excedente_permitido_value}}}.</param>
        /// <param name="FlagPermitirParcelamento">{{{detalhe_operacao_response_flag_permitir_parcelamento_value}}}.</param>

        public DetalheOperacaoResponse(long? IdOperacao = null, string CodigoProcessamento = null, string CodigoProcessamentoCancelamento = null, string NomeOperacao = null, string DescricaoOperacao = null, int? PlanoMinimo = null, int? PlanoMaximo = null, double? ValorMinimo = null, double? ValorMaximo = null, bool? FlagCobraJuros = null, double? TaxaJuros = null, bool? FlagCobraTarifa = null, double? TaxaTarifa = null, double? ValorTac = null, double? PercentualTac = null, double? ValorOperacao = null, int? Carencia = null, double? ExcedentePermitido = null, bool? FlagPermitirParcelamento = null)
        {
            this.IdOperacao = IdOperacao;
            this.CodigoProcessamento = CodigoProcessamento;
            this.CodigoProcessamentoCancelamento = CodigoProcessamentoCancelamento;
            this.NomeOperacao = NomeOperacao;
            this.DescricaoOperacao = DescricaoOperacao;
            this.PlanoMinimo = PlanoMinimo;
            this.PlanoMaximo = PlanoMaximo;
            this.ValorMinimo = ValorMinimo;
            this.ValorMaximo = ValorMaximo;
            this.FlagCobraJuros = FlagCobraJuros;
            this.TaxaJuros = TaxaJuros;
            this.FlagCobraTarifa = FlagCobraTarifa;
            this.TaxaTarifa = TaxaTarifa;
            this.ValorTac = ValorTac;
            this.PercentualTac = PercentualTac;
            this.ValorOperacao = ValorOperacao;
            this.Carencia = Carencia;
            this.ExcedentePermitido = ExcedentePermitido;
            this.FlagPermitirParcelamento = FlagPermitirParcelamento;
            
        }
        
    
        /// <summary>
        /// {{{detalhe_operacao_response_id_operacao_value}}}
        /// </summary>
        /// <value>{{{detalhe_operacao_response_id_operacao_value}}}</value>
        [DataMember(Name="idOperacao", EmitDefaultValue=false)]
        public long? IdOperacao { get; set; }
    
        /// <summary>
        /// {{{detalhe_operacao_response_codigo_processamento_value}}}
        /// </summary>
        /// <value>{{{detalhe_operacao_response_codigo_processamento_value}}}</value>
        [DataMember(Name="codigoProcessamento", EmitDefaultValue=false)]
        public string CodigoProcessamento { get; set; }
    
        /// <summary>
        /// {{{detalhe_operacao_response_codigo_processamento_cancelamento_value}}}
        /// </summary>
        /// <value>{{{detalhe_operacao_response_codigo_processamento_cancelamento_value}}}</value>
        [DataMember(Name="codigoProcessamentoCancelamento", EmitDefaultValue=false)]
        public string CodigoProcessamentoCancelamento { get; set; }
    
        /// <summary>
        /// {{{detalhe_operacao_response_nome_operacao_value}}}
        /// </summary>
        /// <value>{{{detalhe_operacao_response_nome_operacao_value}}}</value>
        [DataMember(Name="nomeOperacao", EmitDefaultValue=false)]
        public string NomeOperacao { get; set; }
    
        /// <summary>
        /// {{{detalhe_operacao_response_descricao_operacao_value}}}
        /// </summary>
        /// <value>{{{detalhe_operacao_response_descricao_operacao_value}}}</value>
        [DataMember(Name="descricaoOperacao", EmitDefaultValue=false)]
        public string DescricaoOperacao { get; set; }
    
        /// <summary>
        /// {{{detalhe_operacao_response_plano_minimo_value}}}
        /// </summary>
        /// <value>{{{detalhe_operacao_response_plano_minimo_value}}}</value>
        [DataMember(Name="planoMinimo", EmitDefaultValue=false)]
        public int? PlanoMinimo { get; set; }
    
        /// <summary>
        /// {{{detalhe_operacao_response_plano_maximo_value}}}
        /// </summary>
        /// <value>{{{detalhe_operacao_response_plano_maximo_value}}}</value>
        [DataMember(Name="planoMaximo", EmitDefaultValue=false)]
        public int? PlanoMaximo { get; set; }
    
        /// <summary>
        /// {{{detalhe_operacao_response_valor_minimo_value}}}
        /// </summary>
        /// <value>{{{detalhe_operacao_response_valor_minimo_value}}}</value>
        [DataMember(Name="valorMinimo", EmitDefaultValue=false)]
        public double? ValorMinimo { get; set; }
    
        /// <summary>
        /// {{{detalhe_operacao_response_valor_maximo_value}}}
        /// </summary>
        /// <value>{{{detalhe_operacao_response_valor_maximo_value}}}</value>
        [DataMember(Name="valorMaximo", EmitDefaultValue=false)]
        public double? ValorMaximo { get; set; }
    
        /// <summary>
        /// {{{detalhe_operacao_response_flag_cobra_juros_value}}}
        /// </summary>
        /// <value>{{{detalhe_operacao_response_flag_cobra_juros_value}}}</value>
        [DataMember(Name="flagCobraJuros", EmitDefaultValue=false)]
        public bool? FlagCobraJuros { get; set; }
    
        /// <summary>
        /// {{{detalhe_operacao_response_taxa_juros_value}}}
        /// </summary>
        /// <value>{{{detalhe_operacao_response_taxa_juros_value}}}</value>
        [DataMember(Name="taxaJuros", EmitDefaultValue=false)]
        public double? TaxaJuros { get; set; }
    
        /// <summary>
        /// {{{detalhe_operacao_response_flag_cobra_tarifa_value}}}
        /// </summary>
        /// <value>{{{detalhe_operacao_response_flag_cobra_tarifa_value}}}</value>
        [DataMember(Name="flagCobraTarifa", EmitDefaultValue=false)]
        public bool? FlagCobraTarifa { get; set; }
    
        /// <summary>
        /// {{{detalhe_operacao_response_taxa_tarifa_value}}}
        /// </summary>
        /// <value>{{{detalhe_operacao_response_taxa_tarifa_value}}}</value>
        [DataMember(Name="taxaTarifa", EmitDefaultValue=false)]
        public double? TaxaTarifa { get; set; }
    
        /// <summary>
        /// {{{detalhe_operacao_response_valor_tac_value}}}
        /// </summary>
        /// <value>{{{detalhe_operacao_response_valor_tac_value}}}</value>
        [DataMember(Name="valorTac", EmitDefaultValue=false)]
        public double? ValorTac { get; set; }
    
        /// <summary>
        /// {{{detalhe_operacao_response_percentual_tac_value}}}
        /// </summary>
        /// <value>{{{detalhe_operacao_response_percentual_tac_value}}}</value>
        [DataMember(Name="percentualTac", EmitDefaultValue=false)]
        public double? PercentualTac { get; set; }
    
        /// <summary>
        /// {{{detalhe_operacao_response_valor_operacao_value}}}
        /// </summary>
        /// <value>{{{detalhe_operacao_response_valor_operacao_value}}}</value>
        [DataMember(Name="valorOperacao", EmitDefaultValue=false)]
        public double? ValorOperacao { get; set; }
    
        /// <summary>
        /// {{{detalhe_operacao_response_carencia_value}}}
        /// </summary>
        /// <value>{{{detalhe_operacao_response_carencia_value}}}</value>
        [DataMember(Name="carencia", EmitDefaultValue=false)]
        public int? Carencia { get; set; }
    
        /// <summary>
        /// {{{detalhe_operacao_response_excedente_permitido_value}}}
        /// </summary>
        /// <value>{{{detalhe_operacao_response_excedente_permitido_value}}}</value>
        [DataMember(Name="excedentePermitido", EmitDefaultValue=false)]
        public double? ExcedentePermitido { get; set; }
    
        /// <summary>
        /// {{{detalhe_operacao_response_flag_permitir_parcelamento_value}}}
        /// </summary>
        /// <value>{{{detalhe_operacao_response_flag_permitir_parcelamento_value}}}</value>
        [DataMember(Name="flagPermitirParcelamento", EmitDefaultValue=false)]
        public bool? FlagPermitirParcelamento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetalheOperacaoResponse {\n");
            sb.Append("  IdOperacao: ").Append(IdOperacao).Append("\n");
            sb.Append("  CodigoProcessamento: ").Append(CodigoProcessamento).Append("\n");
            sb.Append("  CodigoProcessamentoCancelamento: ").Append(CodigoProcessamentoCancelamento).Append("\n");
            sb.Append("  NomeOperacao: ").Append(NomeOperacao).Append("\n");
            sb.Append("  DescricaoOperacao: ").Append(DescricaoOperacao).Append("\n");
            sb.Append("  PlanoMinimo: ").Append(PlanoMinimo).Append("\n");
            sb.Append("  PlanoMaximo: ").Append(PlanoMaximo).Append("\n");
            sb.Append("  ValorMinimo: ").Append(ValorMinimo).Append("\n");
            sb.Append("  ValorMaximo: ").Append(ValorMaximo).Append("\n");
            sb.Append("  FlagCobraJuros: ").Append(FlagCobraJuros).Append("\n");
            sb.Append("  TaxaJuros: ").Append(TaxaJuros).Append("\n");
            sb.Append("  FlagCobraTarifa: ").Append(FlagCobraTarifa).Append("\n");
            sb.Append("  TaxaTarifa: ").Append(TaxaTarifa).Append("\n");
            sb.Append("  ValorTac: ").Append(ValorTac).Append("\n");
            sb.Append("  PercentualTac: ").Append(PercentualTac).Append("\n");
            sb.Append("  ValorOperacao: ").Append(ValorOperacao).Append("\n");
            sb.Append("  Carencia: ").Append(Carencia).Append("\n");
            sb.Append("  ExcedentePermitido: ").Append(ExcedentePermitido).Append("\n");
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
            return this.Equals(obj as DetalheOperacaoResponse);
        }

        /// <summary>
        /// Returns true if DetalheOperacaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DetalheOperacaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetalheOperacaoResponse other)
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
                    this.DescricaoOperacao == other.DescricaoOperacao ||
                    this.DescricaoOperacao != null &&
                    this.DescricaoOperacao.Equals(other.DescricaoOperacao)
                ) && 
                (
                    this.PlanoMinimo == other.PlanoMinimo ||
                    this.PlanoMinimo != null &&
                    this.PlanoMinimo.Equals(other.PlanoMinimo)
                ) && 
                (
                    this.PlanoMaximo == other.PlanoMaximo ||
                    this.PlanoMaximo != null &&
                    this.PlanoMaximo.Equals(other.PlanoMaximo)
                ) && 
                (
                    this.ValorMinimo == other.ValorMinimo ||
                    this.ValorMinimo != null &&
                    this.ValorMinimo.Equals(other.ValorMinimo)
                ) && 
                (
                    this.ValorMaximo == other.ValorMaximo ||
                    this.ValorMaximo != null &&
                    this.ValorMaximo.Equals(other.ValorMaximo)
                ) && 
                (
                    this.FlagCobraJuros == other.FlagCobraJuros ||
                    this.FlagCobraJuros != null &&
                    this.FlagCobraJuros.Equals(other.FlagCobraJuros)
                ) && 
                (
                    this.TaxaJuros == other.TaxaJuros ||
                    this.TaxaJuros != null &&
                    this.TaxaJuros.Equals(other.TaxaJuros)
                ) && 
                (
                    this.FlagCobraTarifa == other.FlagCobraTarifa ||
                    this.FlagCobraTarifa != null &&
                    this.FlagCobraTarifa.Equals(other.FlagCobraTarifa)
                ) && 
                (
                    this.TaxaTarifa == other.TaxaTarifa ||
                    this.TaxaTarifa != null &&
                    this.TaxaTarifa.Equals(other.TaxaTarifa)
                ) && 
                (
                    this.ValorTac == other.ValorTac ||
                    this.ValorTac != null &&
                    this.ValorTac.Equals(other.ValorTac)
                ) && 
                (
                    this.PercentualTac == other.PercentualTac ||
                    this.PercentualTac != null &&
                    this.PercentualTac.Equals(other.PercentualTac)
                ) && 
                (
                    this.ValorOperacao == other.ValorOperacao ||
                    this.ValorOperacao != null &&
                    this.ValorOperacao.Equals(other.ValorOperacao)
                ) && 
                (
                    this.Carencia == other.Carencia ||
                    this.Carencia != null &&
                    this.Carencia.Equals(other.Carencia)
                ) && 
                (
                    this.ExcedentePermitido == other.ExcedentePermitido ||
                    this.ExcedentePermitido != null &&
                    this.ExcedentePermitido.Equals(other.ExcedentePermitido)
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
                
                if (this.DescricaoOperacao != null)
                    hash = hash * 59 + this.DescricaoOperacao.GetHashCode();
                
                if (this.PlanoMinimo != null)
                    hash = hash * 59 + this.PlanoMinimo.GetHashCode();
                
                if (this.PlanoMaximo != null)
                    hash = hash * 59 + this.PlanoMaximo.GetHashCode();
                
                if (this.ValorMinimo != null)
                    hash = hash * 59 + this.ValorMinimo.GetHashCode();
                
                if (this.ValorMaximo != null)
                    hash = hash * 59 + this.ValorMaximo.GetHashCode();
                
                if (this.FlagCobraJuros != null)
                    hash = hash * 59 + this.FlagCobraJuros.GetHashCode();
                
                if (this.TaxaJuros != null)
                    hash = hash * 59 + this.TaxaJuros.GetHashCode();
                
                if (this.FlagCobraTarifa != null)
                    hash = hash * 59 + this.FlagCobraTarifa.GetHashCode();
                
                if (this.TaxaTarifa != null)
                    hash = hash * 59 + this.TaxaTarifa.GetHashCode();
                
                if (this.ValorTac != null)
                    hash = hash * 59 + this.ValorTac.GetHashCode();
                
                if (this.PercentualTac != null)
                    hash = hash * 59 + this.PercentualTac.GetHashCode();
                
                if (this.ValorOperacao != null)
                    hash = hash * 59 + this.ValorOperacao.GetHashCode();
                
                if (this.Carencia != null)
                    hash = hash * 59 + this.Carencia.GetHashCode();
                
                if (this.ExcedentePermitido != null)
                    hash = hash * 59 + this.ExcedentePermitido.GetHashCode();
                
                if (this.FlagPermitirParcelamento != null)
                    hash = hash * 59 + this.FlagPermitirParcelamento.GetHashCode();
                
                return hash;
            }
        }

    }
}
