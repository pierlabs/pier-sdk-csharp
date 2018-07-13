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
    /// {{{tipo_debito_recorrente_response_description}}}
    /// </summary>
    [DataContract]
    public partial class TipoDebitoRecorrenteResponse :  IEquatable<TipoDebitoRecorrenteResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoDebitoRecorrenteResponse" /> class.
        /// Initializes a new instance of the <see cref="TipoDebitoRecorrenteResponse" />class.
        /// </summary>
        /// <param name="FlagAnuidadeBonificada">FlagAnuidadeBonificada.</param>
        /// <param name="Id">{{{tipo_debito_recorrente_response_id_value}}}.</param>
        /// <param name="Nome">{{{tipo_debito_recorrente_response_descricao_value}}}.</param>
        /// <param name="Valor">{{{tipo_debito_recorrente_response_valor_value}}}.</param>
        /// <param name="FlagAtivo">{{{tipo_debito_recorrente_response_flag_ativo_value}}}.</param>
        /// <param name="ValorBonus">{{{tipo_debito_recorrente_response_valor_bonus_value}}}.</param>
        /// <param name="NumeroParcelas">{{{tipo_debito_recorrente_response_numero_parcelas_value}}}.</param>
        /// <param name="FlagAdereAutomatico">{{{tipo_debito_recorrente_response_flag_adere_automatico_value}}}.</param>
        /// <param name="FlagGeraNumeroSorte">{{{tipo_debito_recorrente_response_flag_gera_numero_sorte_value}}}.</param>
        /// <param name="FaixaEtaria">{{{tipo_debito_recorrente_response_faixa_etaria_value}}}.</param>
        /// <param name="FlagSeguro">{{{tipo_debito_recorrente_response_flag_seguro_value}}}.</param>
        /// <param name="SorteiosMensais">{{{tipo_debito_recorrente_response_sorteios_mensais_value}}}.</param>
        /// <param name="FlagAdesaoAutomatica">{{{tipo_debito_recorrente_response_flag_adesao_automatica_value}}}.</param>
        /// <param name="FlagDependente">{{{tipo_debito_recorrente_response_flag_dependente_value}}}.</param>
        /// <param name="QuantidadeDependente">{{{tipo_debito_recorrente_response_quantidade_dependente_value}}}.</param>
        /// <param name="IdTermoSeguroServico">{{{tipo_debito_recorrente_response_id_termo_seguro_servico_value}}}.</param>
        /// <param name="IdadeMinima">{{{tipo_debito_recorrente_response_idade_minima_value}}}.</param>
        /// <param name="IdadeMaxima">{{{tipo_debito_recorrente_response_idade_maxima_value}}}.</param>
        /// <param name="FlagDebitoIncondicional">{{{tipo_debito_recorrente_response_flag_debito_incondicional_value}}}.</param>
        /// <param name="FlagExtratoIncondicional">{{{tipo_debito_recorrente_response_flag_extrato_incondicional_value}}}.</param>
        /// <param name="FlagEstornoAutomatico">{{{tipo_debito_recorrente_response_flag_estorno_automatico_value}}}.</param>
        /// <param name="ValorRepassadoSeguradora">{{{tipo_debito_recorrente_response_valor_repassado_seguradora_value}}}.</param>
        /// <param name="FlagLancaTransacao">{{{tipo_debito_recorrente_response_flag_lanca_transacao_value}}}.</param>
        /// <param name="FlagTransferenciaAutomatica">{{{tipo_debito_recorrente_response_flag_transferencia_automatica_value}}}.</param>
        /// <param name="IdProduto">{{{tipo_debito_recorrente_response_id_produto_value}}}.</param>
        /// <param name="IdGrupoDebitoRecorrente">{{{tipo_debito_recorrente_response_id_grupo_debito_recorrente_value}}}.</param>
        /// <param name="QuantidadeTentativasCobranca">{{{tipo_debito_recorrente_response_quantidade_tentativas_cobranca_value}}}.</param>
        /// <param name="IdAjuste">{{{tipo_debito_recorrente_response_id_ajuste_value}}}.</param>

        public TipoDebitoRecorrenteResponse(bool? FlagAnuidadeBonificada = null, long? Id = null, string Nome = null, double? Valor = null, bool? FlagAtivo = null, double? ValorBonus = null, int? NumeroParcelas = null, bool? FlagAdereAutomatico = null, bool? FlagGeraNumeroSorte = null, string FaixaEtaria = null, bool? FlagSeguro = null, string SorteiosMensais = null, bool? FlagAdesaoAutomatica = null, bool? FlagDependente = null, int? QuantidadeDependente = null, long? IdTermoSeguroServico = null, int? IdadeMinima = null, int? IdadeMaxima = null, bool? FlagDebitoIncondicional = null, bool? FlagExtratoIncondicional = null, bool? FlagEstornoAutomatico = null, double? ValorRepassadoSeguradora = null, bool? FlagLancaTransacao = null, bool? FlagTransferenciaAutomatica = null, long? IdProduto = null, long? IdGrupoDebitoRecorrente = null, int? QuantidadeTentativasCobranca = null, long? IdAjuste = null)
        {
            this.FlagAnuidadeBonificada = FlagAnuidadeBonificada;
            this.Id = Id;
            this.Nome = Nome;
            this.Valor = Valor;
            this.FlagAtivo = FlagAtivo;
            this.ValorBonus = ValorBonus;
            this.NumeroParcelas = NumeroParcelas;
            this.FlagAdereAutomatico = FlagAdereAutomatico;
            this.FlagGeraNumeroSorte = FlagGeraNumeroSorte;
            this.FaixaEtaria = FaixaEtaria;
            this.FlagSeguro = FlagSeguro;
            this.SorteiosMensais = SorteiosMensais;
            this.FlagAdesaoAutomatica = FlagAdesaoAutomatica;
            this.FlagDependente = FlagDependente;
            this.QuantidadeDependente = QuantidadeDependente;
            this.IdTermoSeguroServico = IdTermoSeguroServico;
            this.IdadeMinima = IdadeMinima;
            this.IdadeMaxima = IdadeMaxima;
            this.FlagDebitoIncondicional = FlagDebitoIncondicional;
            this.FlagExtratoIncondicional = FlagExtratoIncondicional;
            this.FlagEstornoAutomatico = FlagEstornoAutomatico;
            this.ValorRepassadoSeguradora = ValorRepassadoSeguradora;
            this.FlagLancaTransacao = FlagLancaTransacao;
            this.FlagTransferenciaAutomatica = FlagTransferenciaAutomatica;
            this.IdProduto = IdProduto;
            this.IdGrupoDebitoRecorrente = IdGrupoDebitoRecorrente;
            this.QuantidadeTentativasCobranca = QuantidadeTentativasCobranca;
            this.IdAjuste = IdAjuste;
            
        }
        
    
        /// <summary>
        /// Gets or Sets FlagAnuidadeBonificada
        /// </summary>
        [DataMember(Name="flagAnuidadeBonificada", EmitDefaultValue=false)]
        public bool? FlagAnuidadeBonificada { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_id_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_descricao_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_descricao_value}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_valor_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_valor_value}}}</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_flag_ativo_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_flag_ativo_value}}}</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public bool? FlagAtivo { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_valor_bonus_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_valor_bonus_value}}}</value>
        [DataMember(Name="valorBonus", EmitDefaultValue=false)]
        public double? ValorBonus { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_numero_parcelas_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_numero_parcelas_value}}}</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public int? NumeroParcelas { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_flag_adere_automatico_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_flag_adere_automatico_value}}}</value>
        [DataMember(Name="flagAdereAutomatico", EmitDefaultValue=false)]
        public bool? FlagAdereAutomatico { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_flag_gera_numero_sorte_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_flag_gera_numero_sorte_value}}}</value>
        [DataMember(Name="flagGeraNumeroSorte", EmitDefaultValue=false)]
        public bool? FlagGeraNumeroSorte { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_faixa_etaria_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_faixa_etaria_value}}}</value>
        [DataMember(Name="faixaEtaria", EmitDefaultValue=false)]
        public string FaixaEtaria { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_flag_seguro_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_flag_seguro_value}}}</value>
        [DataMember(Name="flagSeguro", EmitDefaultValue=false)]
        public bool? FlagSeguro { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_sorteios_mensais_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_sorteios_mensais_value}}}</value>
        [DataMember(Name="sorteiosMensais", EmitDefaultValue=false)]
        public string SorteiosMensais { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_flag_adesao_automatica_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_flag_adesao_automatica_value}}}</value>
        [DataMember(Name="flagAdesaoAutomatica", EmitDefaultValue=false)]
        public bool? FlagAdesaoAutomatica { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_flag_dependente_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_flag_dependente_value}}}</value>
        [DataMember(Name="flagDependente", EmitDefaultValue=false)]
        public bool? FlagDependente { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_quantidade_dependente_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_quantidade_dependente_value}}}</value>
        [DataMember(Name="quantidadeDependente", EmitDefaultValue=false)]
        public int? QuantidadeDependente { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_id_termo_seguro_servico_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_id_termo_seguro_servico_value}}}</value>
        [DataMember(Name="idTermoSeguroServico", EmitDefaultValue=false)]
        public long? IdTermoSeguroServico { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_idade_minima_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_idade_minima_value}}}</value>
        [DataMember(Name="idadeMinima", EmitDefaultValue=false)]
        public int? IdadeMinima { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_idade_maxima_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_idade_maxima_value}}}</value>
        [DataMember(Name="idadeMaxima", EmitDefaultValue=false)]
        public int? IdadeMaxima { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_flag_debito_incondicional_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_flag_debito_incondicional_value}}}</value>
        [DataMember(Name="flagDebitoIncondicional", EmitDefaultValue=false)]
        public bool? FlagDebitoIncondicional { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_flag_extrato_incondicional_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_flag_extrato_incondicional_value}}}</value>
        [DataMember(Name="flagExtratoIncondicional", EmitDefaultValue=false)]
        public bool? FlagExtratoIncondicional { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_flag_estorno_automatico_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_flag_estorno_automatico_value}}}</value>
        [DataMember(Name="flagEstornoAutomatico", EmitDefaultValue=false)]
        public bool? FlagEstornoAutomatico { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_valor_repassado_seguradora_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_valor_repassado_seguradora_value}}}</value>
        [DataMember(Name="valorRepassadoSeguradora", EmitDefaultValue=false)]
        public double? ValorRepassadoSeguradora { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_flag_lanca_transacao_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_flag_lanca_transacao_value}}}</value>
        [DataMember(Name="flagLancaTransacao", EmitDefaultValue=false)]
        public bool? FlagLancaTransacao { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_flag_transferencia_automatica_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_flag_transferencia_automatica_value}}}</value>
        [DataMember(Name="flagTransferenciaAutomatica", EmitDefaultValue=false)]
        public bool? FlagTransferenciaAutomatica { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_id_produto_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_id_produto_value}}}</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_id_grupo_debito_recorrente_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_id_grupo_debito_recorrente_value}}}</value>
        [DataMember(Name="idGrupoDebitoRecorrente", EmitDefaultValue=false)]
        public long? IdGrupoDebitoRecorrente { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_quantidade_tentativas_cobranca_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_quantidade_tentativas_cobranca_value}}}</value>
        [DataMember(Name="quantidadeTentativasCobranca", EmitDefaultValue=false)]
        public int? QuantidadeTentativasCobranca { get; set; }
    
        /// <summary>
        /// {{{tipo_debito_recorrente_response_id_ajuste_value}}}
        /// </summary>
        /// <value>{{{tipo_debito_recorrente_response_id_ajuste_value}}}</value>
        [DataMember(Name="idAjuste", EmitDefaultValue=false)]
        public long? IdAjuste { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoDebitoRecorrenteResponse {\n");
            sb.Append("  FlagAnuidadeBonificada: ").Append(FlagAnuidadeBonificada).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  FlagAtivo: ").Append(FlagAtivo).Append("\n");
            sb.Append("  ValorBonus: ").Append(ValorBonus).Append("\n");
            sb.Append("  NumeroParcelas: ").Append(NumeroParcelas).Append("\n");
            sb.Append("  FlagAdereAutomatico: ").Append(FlagAdereAutomatico).Append("\n");
            sb.Append("  FlagGeraNumeroSorte: ").Append(FlagGeraNumeroSorte).Append("\n");
            sb.Append("  FaixaEtaria: ").Append(FaixaEtaria).Append("\n");
            sb.Append("  FlagSeguro: ").Append(FlagSeguro).Append("\n");
            sb.Append("  SorteiosMensais: ").Append(SorteiosMensais).Append("\n");
            sb.Append("  FlagAdesaoAutomatica: ").Append(FlagAdesaoAutomatica).Append("\n");
            sb.Append("  FlagDependente: ").Append(FlagDependente).Append("\n");
            sb.Append("  QuantidadeDependente: ").Append(QuantidadeDependente).Append("\n");
            sb.Append("  IdTermoSeguroServico: ").Append(IdTermoSeguroServico).Append("\n");
            sb.Append("  IdadeMinima: ").Append(IdadeMinima).Append("\n");
            sb.Append("  IdadeMaxima: ").Append(IdadeMaxima).Append("\n");
            sb.Append("  FlagDebitoIncondicional: ").Append(FlagDebitoIncondicional).Append("\n");
            sb.Append("  FlagExtratoIncondicional: ").Append(FlagExtratoIncondicional).Append("\n");
            sb.Append("  FlagEstornoAutomatico: ").Append(FlagEstornoAutomatico).Append("\n");
            sb.Append("  ValorRepassadoSeguradora: ").Append(ValorRepassadoSeguradora).Append("\n");
            sb.Append("  FlagLancaTransacao: ").Append(FlagLancaTransacao).Append("\n");
            sb.Append("  FlagTransferenciaAutomatica: ").Append(FlagTransferenciaAutomatica).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdGrupoDebitoRecorrente: ").Append(IdGrupoDebitoRecorrente).Append("\n");
            sb.Append("  QuantidadeTentativasCobranca: ").Append(QuantidadeTentativasCobranca).Append("\n");
            sb.Append("  IdAjuste: ").Append(IdAjuste).Append("\n");
            
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
            return this.Equals(obj as TipoDebitoRecorrenteResponse);
        }

        /// <summary>
        /// Returns true if TipoDebitoRecorrenteResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoDebitoRecorrenteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoDebitoRecorrenteResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FlagAnuidadeBonificada == other.FlagAnuidadeBonificada ||
                    this.FlagAnuidadeBonificada != null &&
                    this.FlagAnuidadeBonificada.Equals(other.FlagAnuidadeBonificada)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
                ) && 
                (
                    this.FlagAtivo == other.FlagAtivo ||
                    this.FlagAtivo != null &&
                    this.FlagAtivo.Equals(other.FlagAtivo)
                ) && 
                (
                    this.ValorBonus == other.ValorBonus ||
                    this.ValorBonus != null &&
                    this.ValorBonus.Equals(other.ValorBonus)
                ) && 
                (
                    this.NumeroParcelas == other.NumeroParcelas ||
                    this.NumeroParcelas != null &&
                    this.NumeroParcelas.Equals(other.NumeroParcelas)
                ) && 
                (
                    this.FlagAdereAutomatico == other.FlagAdereAutomatico ||
                    this.FlagAdereAutomatico != null &&
                    this.FlagAdereAutomatico.Equals(other.FlagAdereAutomatico)
                ) && 
                (
                    this.FlagGeraNumeroSorte == other.FlagGeraNumeroSorte ||
                    this.FlagGeraNumeroSorte != null &&
                    this.FlagGeraNumeroSorte.Equals(other.FlagGeraNumeroSorte)
                ) && 
                (
                    this.FaixaEtaria == other.FaixaEtaria ||
                    this.FaixaEtaria != null &&
                    this.FaixaEtaria.Equals(other.FaixaEtaria)
                ) && 
                (
                    this.FlagSeguro == other.FlagSeguro ||
                    this.FlagSeguro != null &&
                    this.FlagSeguro.Equals(other.FlagSeguro)
                ) && 
                (
                    this.SorteiosMensais == other.SorteiosMensais ||
                    this.SorteiosMensais != null &&
                    this.SorteiosMensais.Equals(other.SorteiosMensais)
                ) && 
                (
                    this.FlagAdesaoAutomatica == other.FlagAdesaoAutomatica ||
                    this.FlagAdesaoAutomatica != null &&
                    this.FlagAdesaoAutomatica.Equals(other.FlagAdesaoAutomatica)
                ) && 
                (
                    this.FlagDependente == other.FlagDependente ||
                    this.FlagDependente != null &&
                    this.FlagDependente.Equals(other.FlagDependente)
                ) && 
                (
                    this.QuantidadeDependente == other.QuantidadeDependente ||
                    this.QuantidadeDependente != null &&
                    this.QuantidadeDependente.Equals(other.QuantidadeDependente)
                ) && 
                (
                    this.IdTermoSeguroServico == other.IdTermoSeguroServico ||
                    this.IdTermoSeguroServico != null &&
                    this.IdTermoSeguroServico.Equals(other.IdTermoSeguroServico)
                ) && 
                (
                    this.IdadeMinima == other.IdadeMinima ||
                    this.IdadeMinima != null &&
                    this.IdadeMinima.Equals(other.IdadeMinima)
                ) && 
                (
                    this.IdadeMaxima == other.IdadeMaxima ||
                    this.IdadeMaxima != null &&
                    this.IdadeMaxima.Equals(other.IdadeMaxima)
                ) && 
                (
                    this.FlagDebitoIncondicional == other.FlagDebitoIncondicional ||
                    this.FlagDebitoIncondicional != null &&
                    this.FlagDebitoIncondicional.Equals(other.FlagDebitoIncondicional)
                ) && 
                (
                    this.FlagExtratoIncondicional == other.FlagExtratoIncondicional ||
                    this.FlagExtratoIncondicional != null &&
                    this.FlagExtratoIncondicional.Equals(other.FlagExtratoIncondicional)
                ) && 
                (
                    this.FlagEstornoAutomatico == other.FlagEstornoAutomatico ||
                    this.FlagEstornoAutomatico != null &&
                    this.FlagEstornoAutomatico.Equals(other.FlagEstornoAutomatico)
                ) && 
                (
                    this.ValorRepassadoSeguradora == other.ValorRepassadoSeguradora ||
                    this.ValorRepassadoSeguradora != null &&
                    this.ValorRepassadoSeguradora.Equals(other.ValorRepassadoSeguradora)
                ) && 
                (
                    this.FlagLancaTransacao == other.FlagLancaTransacao ||
                    this.FlagLancaTransacao != null &&
                    this.FlagLancaTransacao.Equals(other.FlagLancaTransacao)
                ) && 
                (
                    this.FlagTransferenciaAutomatica == other.FlagTransferenciaAutomatica ||
                    this.FlagTransferenciaAutomatica != null &&
                    this.FlagTransferenciaAutomatica.Equals(other.FlagTransferenciaAutomatica)
                ) && 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.IdGrupoDebitoRecorrente == other.IdGrupoDebitoRecorrente ||
                    this.IdGrupoDebitoRecorrente != null &&
                    this.IdGrupoDebitoRecorrente.Equals(other.IdGrupoDebitoRecorrente)
                ) && 
                (
                    this.QuantidadeTentativasCobranca == other.QuantidadeTentativasCobranca ||
                    this.QuantidadeTentativasCobranca != null &&
                    this.QuantidadeTentativasCobranca.Equals(other.QuantidadeTentativasCobranca)
                ) && 
                (
                    this.IdAjuste == other.IdAjuste ||
                    this.IdAjuste != null &&
                    this.IdAjuste.Equals(other.IdAjuste)
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
                
                if (this.FlagAnuidadeBonificada != null)
                    hash = hash * 59 + this.FlagAnuidadeBonificada.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                if (this.FlagAtivo != null)
                    hash = hash * 59 + this.FlagAtivo.GetHashCode();
                
                if (this.ValorBonus != null)
                    hash = hash * 59 + this.ValorBonus.GetHashCode();
                
                if (this.NumeroParcelas != null)
                    hash = hash * 59 + this.NumeroParcelas.GetHashCode();
                
                if (this.FlagAdereAutomatico != null)
                    hash = hash * 59 + this.FlagAdereAutomatico.GetHashCode();
                
                if (this.FlagGeraNumeroSorte != null)
                    hash = hash * 59 + this.FlagGeraNumeroSorte.GetHashCode();
                
                if (this.FaixaEtaria != null)
                    hash = hash * 59 + this.FaixaEtaria.GetHashCode();
                
                if (this.FlagSeguro != null)
                    hash = hash * 59 + this.FlagSeguro.GetHashCode();
                
                if (this.SorteiosMensais != null)
                    hash = hash * 59 + this.SorteiosMensais.GetHashCode();
                
                if (this.FlagAdesaoAutomatica != null)
                    hash = hash * 59 + this.FlagAdesaoAutomatica.GetHashCode();
                
                if (this.FlagDependente != null)
                    hash = hash * 59 + this.FlagDependente.GetHashCode();
                
                if (this.QuantidadeDependente != null)
                    hash = hash * 59 + this.QuantidadeDependente.GetHashCode();
                
                if (this.IdTermoSeguroServico != null)
                    hash = hash * 59 + this.IdTermoSeguroServico.GetHashCode();
                
                if (this.IdadeMinima != null)
                    hash = hash * 59 + this.IdadeMinima.GetHashCode();
                
                if (this.IdadeMaxima != null)
                    hash = hash * 59 + this.IdadeMaxima.GetHashCode();
                
                if (this.FlagDebitoIncondicional != null)
                    hash = hash * 59 + this.FlagDebitoIncondicional.GetHashCode();
                
                if (this.FlagExtratoIncondicional != null)
                    hash = hash * 59 + this.FlagExtratoIncondicional.GetHashCode();
                
                if (this.FlagEstornoAutomatico != null)
                    hash = hash * 59 + this.FlagEstornoAutomatico.GetHashCode();
                
                if (this.ValorRepassadoSeguradora != null)
                    hash = hash * 59 + this.ValorRepassadoSeguradora.GetHashCode();
                
                if (this.FlagLancaTransacao != null)
                    hash = hash * 59 + this.FlagLancaTransacao.GetHashCode();
                
                if (this.FlagTransferenciaAutomatica != null)
                    hash = hash * 59 + this.FlagTransferenciaAutomatica.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.IdGrupoDebitoRecorrente != null)
                    hash = hash * 59 + this.IdGrupoDebitoRecorrente.GetHashCode();
                
                if (this.QuantidadeTentativasCobranca != null)
                    hash = hash * 59 + this.QuantidadeTentativasCobranca.GetHashCode();
                
                if (this.IdAjuste != null)
                    hash = hash * 59 + this.IdAjuste.GetHashCode();
                
                return hash;
            }
        }

    }
}
