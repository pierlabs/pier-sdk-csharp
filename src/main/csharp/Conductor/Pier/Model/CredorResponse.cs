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
    public partial class CredorResponse :  IEquatable<CredorResponse>
    { 
    
        /// <summary>
        /// {{{credor_response_recebe_rav_value}}}
        /// </summary>
        /// <value>{{{credor_response_recebe_rav_value}}}</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RecebeRAVEnum {
            
            [EnumMember(Value = "NAO_TEM_PERMISSAO_RAV")]
            NaoTemPermissaoRav,
            
            [EnumMember(Value = "CREDITO_RAV")]
            CreditoRav,
            
            [EnumMember(Value = "DEBITO_RAV")]
            DebitoRav
        }

    
        /// <summary>
        /// {{{credor_response_periodicidade_value}}}
        /// </summary>
        /// <value>{{{credor_response_periodicidade_value}}}</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PeriodicidadeEnum {
            
            [EnumMember(Value = "DIARIO")]
            Diario,
            
            [EnumMember(Value = "SEMANAL")]
            Semanal,
            
            [EnumMember(Value = "MENSAL")]
            Mensal,
            
            [EnumMember(Value = "DECENDIAL")]
            Decendial,
            
            [EnumMember(Value = "QUINZENAL")]
            Quinzenal
        }

    
        /// <summary>
        /// {{{credor_response_recebe_rav_value}}}
        /// </summary>
        /// <value>{{{credor_response_recebe_rav_value}}}</value>
        [DataMember(Name="recebeRAV", EmitDefaultValue=false)]
        public RecebeRAVEnum? RecebeRAV { get; set; }
    
        /// <summary>
        /// {{{credor_response_periodicidade_value}}}
        /// </summary>
        /// <value>{{{credor_response_periodicidade_value}}}</value>
        [DataMember(Name="periodicidade", EmitDefaultValue=false)]
        public PeriodicidadeEnum? Periodicidade { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CredorResponse" /> class.
        /// Initializes a new instance of the <see cref="CredorResponse" />class.
        /// </summary>
        /// <param name="Id">{{{credor_response_id_value}}}.</param>
        /// <param name="NomeCredor">{{{credor_response_nome_credor_value}}}.</param>
        /// <param name="DiaPagamentoSemanal">{{{credor_response_pagamento_semanal_value}}}.</param>
        /// <param name="DiaPagamentoMensal">{{{credor_response_pagamento_mensal_value}}}.</param>
        /// <param name="DiaPagamentoDecendialPrimeiro">{{{credor_response_pagamento_decendial_primeiro_value}}}.</param>
        /// <param name="DiaPagamentoDecendialSegundo">{{{credor_response_pagamento_decendial_segundo_value}}}.</param>
        /// <param name="DiaPagamentoDecendialTerceiro">{{{credor_response_pagamento_decendial_terceiro_value}}}.</param>
        /// <param name="DiaPagamentoQuinzenalPrimeiro">{{{credor_response_pagamento_quinzenal_primeiro_value}}}.</param>
        /// <param name="DiaPagamentoQuinzenalSegundo">{{{credor_response_pagamento_quinzenal_segundo_value}}}.</param>
        /// <param name="Banco">{{{credor_response_banco_value}}}.</param>
        /// <param name="Agencia">{{{credor_response_agencia_value}}}.</param>
        /// <param name="DigitoAgencia">{{{credor_response_digito_agencia_value}}}.</param>
        /// <param name="ContaCorrente">{{{credor_response_conta_corrente_value}}}.</param>
        /// <param name="DigitoContaCorrente">{{{credor_response_digito_conta_corrente_value}}}.</param>
        /// <param name="CredorBanco">{{{credor_response_credor_banco_value}}}.</param>
        /// <param name="PercentualRAV">{{{credor_response_percentual_rav_value}}}.</param>
        /// <param name="RecebeRAV">{{{credor_response_recebe_rav_value}}}.</param>
        /// <param name="PercentualMultiplica">{{{credor_response_percentual_multiplica_value}}}.</param>
        /// <param name="TaxaAdministrativa">{{{credor_response_taxa_adm_value}}}.</param>
        /// <param name="TaxaBanco">{{{credor_response_taxa_banco_value}}}.</param>
        /// <param name="LimiteRAV">{{{credor_response_limite_rav_value}}}.</param>
        /// <param name="IdCredorRAV">{{{credor_response_id_credor_rav_value}}}.</param>
        /// <param name="Periodicidade">{{{credor_response_periodicidade_value}}}.</param>
        /// <param name="IdPessoaJuridica">{{{credor_response_id_pessoa_juridica_value}}}.</param>
        /// <param name="FlagEscritorioCobranca">{{{credor_response_flag_escritorio_cobranca_value}}}.</param>
        /// <param name="EscritoriosCobranca">{{{credor_response_escritorio_cobranca_value}}}.</param>
        /// <param name="TelefonesEscritoriosCobranca">{{{credor_response_telefone_escritorio_cobranca_value}}}.</param>

        public CredorResponse(long? Id = null, string NomeCredor = null, int? DiaPagamentoSemanal = null, int? DiaPagamentoMensal = null, int? DiaPagamentoDecendialPrimeiro = null, int? DiaPagamentoDecendialSegundo = null, int? DiaPagamentoDecendialTerceiro = null, int? DiaPagamentoQuinzenalPrimeiro = null, int? DiaPagamentoQuinzenalSegundo = null, int? Banco = null, int? Agencia = null, string DigitoAgencia = null, string ContaCorrente = null, string DigitoContaCorrente = null, bool? CredorBanco = null, double? PercentualRAV = null, RecebeRAVEnum? RecebeRAV = null, double? PercentualMultiplica = null, double? TaxaAdministrativa = null, double? TaxaBanco = null, double? LimiteRAV = null, long? IdCredorRAV = null, PeriodicidadeEnum? Periodicidade = null, long? IdPessoaJuridica = null, bool? FlagEscritorioCobranca = null, EscritorioCobrancaDTO EscritoriosCobranca = null, List<TelefoneEscritorioCobrancaDTO> TelefonesEscritoriosCobranca = null)
        {
            this.Id = Id;
            this.NomeCredor = NomeCredor;
            this.DiaPagamentoSemanal = DiaPagamentoSemanal;
            this.DiaPagamentoMensal = DiaPagamentoMensal;
            this.DiaPagamentoDecendialPrimeiro = DiaPagamentoDecendialPrimeiro;
            this.DiaPagamentoDecendialSegundo = DiaPagamentoDecendialSegundo;
            this.DiaPagamentoDecendialTerceiro = DiaPagamentoDecendialTerceiro;
            this.DiaPagamentoQuinzenalPrimeiro = DiaPagamentoQuinzenalPrimeiro;
            this.DiaPagamentoQuinzenalSegundo = DiaPagamentoQuinzenalSegundo;
            this.Banco = Banco;
            this.Agencia = Agencia;
            this.DigitoAgencia = DigitoAgencia;
            this.ContaCorrente = ContaCorrente;
            this.DigitoContaCorrente = DigitoContaCorrente;
            this.CredorBanco = CredorBanco;
            this.PercentualRAV = PercentualRAV;
            this.RecebeRAV = RecebeRAV;
            this.PercentualMultiplica = PercentualMultiplica;
            this.TaxaAdministrativa = TaxaAdministrativa;
            this.TaxaBanco = TaxaBanco;
            this.LimiteRAV = LimiteRAV;
            this.IdCredorRAV = IdCredorRAV;
            this.Periodicidade = Periodicidade;
            this.IdPessoaJuridica = IdPessoaJuridica;
            this.FlagEscritorioCobranca = FlagEscritorioCobranca;
            this.EscritoriosCobranca = EscritoriosCobranca;
            this.TelefonesEscritoriosCobranca = TelefonesEscritoriosCobranca;
            
        }
        
    
        /// <summary>
        /// {{{credor_response_id_value}}}
        /// </summary>
        /// <value>{{{credor_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{credor_response_nome_credor_value}}}
        /// </summary>
        /// <value>{{{credor_response_nome_credor_value}}}</value>
        [DataMember(Name="nomeCredor", EmitDefaultValue=false)]
        public string NomeCredor { get; set; }
    
        /// <summary>
        /// {{{credor_response_pagamento_semanal_value}}}
        /// </summary>
        /// <value>{{{credor_response_pagamento_semanal_value}}}</value>
        [DataMember(Name="diaPagamentoSemanal", EmitDefaultValue=false)]
        public int? DiaPagamentoSemanal { get; set; }
    
        /// <summary>
        /// {{{credor_response_pagamento_mensal_value}}}
        /// </summary>
        /// <value>{{{credor_response_pagamento_mensal_value}}}</value>
        [DataMember(Name="diaPagamentoMensal", EmitDefaultValue=false)]
        public int? DiaPagamentoMensal { get; set; }
    
        /// <summary>
        /// {{{credor_response_pagamento_decendial_primeiro_value}}}
        /// </summary>
        /// <value>{{{credor_response_pagamento_decendial_primeiro_value}}}</value>
        [DataMember(Name="diaPagamentoDecendialPrimeiro", EmitDefaultValue=false)]
        public int? DiaPagamentoDecendialPrimeiro { get; set; }
    
        /// <summary>
        /// {{{credor_response_pagamento_decendial_segundo_value}}}
        /// </summary>
        /// <value>{{{credor_response_pagamento_decendial_segundo_value}}}</value>
        [DataMember(Name="diaPagamentoDecendialSegundo", EmitDefaultValue=false)]
        public int? DiaPagamentoDecendialSegundo { get; set; }
    
        /// <summary>
        /// {{{credor_response_pagamento_decendial_terceiro_value}}}
        /// </summary>
        /// <value>{{{credor_response_pagamento_decendial_terceiro_value}}}</value>
        [DataMember(Name="diaPagamentoDecendialTerceiro", EmitDefaultValue=false)]
        public int? DiaPagamentoDecendialTerceiro { get; set; }
    
        /// <summary>
        /// {{{credor_response_pagamento_quinzenal_primeiro_value}}}
        /// </summary>
        /// <value>{{{credor_response_pagamento_quinzenal_primeiro_value}}}</value>
        [DataMember(Name="diaPagamentoQuinzenalPrimeiro", EmitDefaultValue=false)]
        public int? DiaPagamentoQuinzenalPrimeiro { get; set; }
    
        /// <summary>
        /// {{{credor_response_pagamento_quinzenal_segundo_value}}}
        /// </summary>
        /// <value>{{{credor_response_pagamento_quinzenal_segundo_value}}}</value>
        [DataMember(Name="diaPagamentoQuinzenalSegundo", EmitDefaultValue=false)]
        public int? DiaPagamentoQuinzenalSegundo { get; set; }
    
        /// <summary>
        /// {{{credor_response_banco_value}}}
        /// </summary>
        /// <value>{{{credor_response_banco_value}}}</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public int? Banco { get; set; }
    
        /// <summary>
        /// {{{credor_response_agencia_value}}}
        /// </summary>
        /// <value>{{{credor_response_agencia_value}}}</value>
        [DataMember(Name="agencia", EmitDefaultValue=false)]
        public int? Agencia { get; set; }
    
        /// <summary>
        /// {{{credor_response_digito_agencia_value}}}
        /// </summary>
        /// <value>{{{credor_response_digito_agencia_value}}}</value>
        [DataMember(Name="digitoAgencia", EmitDefaultValue=false)]
        public string DigitoAgencia { get; set; }
    
        /// <summary>
        /// {{{credor_response_conta_corrente_value}}}
        /// </summary>
        /// <value>{{{credor_response_conta_corrente_value}}}</value>
        [DataMember(Name="contaCorrente", EmitDefaultValue=false)]
        public string ContaCorrente { get; set; }
    
        /// <summary>
        /// {{{credor_response_digito_conta_corrente_value}}}
        /// </summary>
        /// <value>{{{credor_response_digito_conta_corrente_value}}}</value>
        [DataMember(Name="digitoContaCorrente", EmitDefaultValue=false)]
        public string DigitoContaCorrente { get; set; }
    
        /// <summary>
        /// {{{credor_response_credor_banco_value}}}
        /// </summary>
        /// <value>{{{credor_response_credor_banco_value}}}</value>
        [DataMember(Name="credorBanco", EmitDefaultValue=false)]
        public bool? CredorBanco { get; set; }
    
        /// <summary>
        /// {{{credor_response_percentual_rav_value}}}
        /// </summary>
        /// <value>{{{credor_response_percentual_rav_value}}}</value>
        [DataMember(Name="percentualRAV", EmitDefaultValue=false)]
        public double? PercentualRAV { get; set; }
    
        /// <summary>
        /// {{{credor_response_percentual_multiplica_value}}}
        /// </summary>
        /// <value>{{{credor_response_percentual_multiplica_value}}}</value>
        [DataMember(Name="percentualMultiplica", EmitDefaultValue=false)]
        public double? PercentualMultiplica { get; set; }
    
        /// <summary>
        /// {{{credor_response_taxa_adm_value}}}
        /// </summary>
        /// <value>{{{credor_response_taxa_adm_value}}}</value>
        [DataMember(Name="taxaAdministrativa", EmitDefaultValue=false)]
        public double? TaxaAdministrativa { get; set; }
    
        /// <summary>
        /// {{{credor_response_taxa_banco_value}}}
        /// </summary>
        /// <value>{{{credor_response_taxa_banco_value}}}</value>
        [DataMember(Name="taxaBanco", EmitDefaultValue=false)]
        public double? TaxaBanco { get; set; }
    
        /// <summary>
        /// {{{credor_response_limite_rav_value}}}
        /// </summary>
        /// <value>{{{credor_response_limite_rav_value}}}</value>
        [DataMember(Name="limiteRAV", EmitDefaultValue=false)]
        public double? LimiteRAV { get; set; }
    
        /// <summary>
        /// {{{credor_response_id_credor_rav_value}}}
        /// </summary>
        /// <value>{{{credor_response_id_credor_rav_value}}}</value>
        [DataMember(Name="idCredorRAV", EmitDefaultValue=false)]
        public long? IdCredorRAV { get; set; }
    
        /// <summary>
        /// {{{credor_response_id_pessoa_juridica_value}}}
        /// </summary>
        /// <value>{{{credor_response_id_pessoa_juridica_value}}}</value>
        [DataMember(Name="idPessoaJuridica", EmitDefaultValue=false)]
        public long? IdPessoaJuridica { get; set; }
    
        /// <summary>
        /// {{{credor_response_flag_escritorio_cobranca_value}}}
        /// </summary>
        /// <value>{{{credor_response_flag_escritorio_cobranca_value}}}</value>
        [DataMember(Name="flagEscritorioCobranca", EmitDefaultValue=false)]
        public bool? FlagEscritorioCobranca { get; set; }
    
        /// <summary>
        /// {{{credor_response_escritorio_cobranca_value}}}
        /// </summary>
        /// <value>{{{credor_response_escritorio_cobranca_value}}}</value>
        [DataMember(Name="escritoriosCobranca", EmitDefaultValue=false)]
        public EscritorioCobrancaDTO EscritoriosCobranca { get; set; }
    
        /// <summary>
        /// {{{credor_response_telefone_escritorio_cobranca_value}}}
        /// </summary>
        /// <value>{{{credor_response_telefone_escritorio_cobranca_value}}}</value>
        [DataMember(Name="telefonesEscritoriosCobranca", EmitDefaultValue=false)]
        public List<TelefoneEscritorioCobrancaDTO> TelefonesEscritoriosCobranca { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CredorResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NomeCredor: ").Append(NomeCredor).Append("\n");
            sb.Append("  DiaPagamentoSemanal: ").Append(DiaPagamentoSemanal).Append("\n");
            sb.Append("  DiaPagamentoMensal: ").Append(DiaPagamentoMensal).Append("\n");
            sb.Append("  DiaPagamentoDecendialPrimeiro: ").Append(DiaPagamentoDecendialPrimeiro).Append("\n");
            sb.Append("  DiaPagamentoDecendialSegundo: ").Append(DiaPagamentoDecendialSegundo).Append("\n");
            sb.Append("  DiaPagamentoDecendialTerceiro: ").Append(DiaPagamentoDecendialTerceiro).Append("\n");
            sb.Append("  DiaPagamentoQuinzenalPrimeiro: ").Append(DiaPagamentoQuinzenalPrimeiro).Append("\n");
            sb.Append("  DiaPagamentoQuinzenalSegundo: ").Append(DiaPagamentoQuinzenalSegundo).Append("\n");
            sb.Append("  Banco: ").Append(Banco).Append("\n");
            sb.Append("  Agencia: ").Append(Agencia).Append("\n");
            sb.Append("  DigitoAgencia: ").Append(DigitoAgencia).Append("\n");
            sb.Append("  ContaCorrente: ").Append(ContaCorrente).Append("\n");
            sb.Append("  DigitoContaCorrente: ").Append(DigitoContaCorrente).Append("\n");
            sb.Append("  CredorBanco: ").Append(CredorBanco).Append("\n");
            sb.Append("  PercentualRAV: ").Append(PercentualRAV).Append("\n");
            sb.Append("  RecebeRAV: ").Append(RecebeRAV).Append("\n");
            sb.Append("  PercentualMultiplica: ").Append(PercentualMultiplica).Append("\n");
            sb.Append("  TaxaAdministrativa: ").Append(TaxaAdministrativa).Append("\n");
            sb.Append("  TaxaBanco: ").Append(TaxaBanco).Append("\n");
            sb.Append("  LimiteRAV: ").Append(LimiteRAV).Append("\n");
            sb.Append("  IdCredorRAV: ").Append(IdCredorRAV).Append("\n");
            sb.Append("  Periodicidade: ").Append(Periodicidade).Append("\n");
            sb.Append("  IdPessoaJuridica: ").Append(IdPessoaJuridica).Append("\n");
            sb.Append("  FlagEscritorioCobranca: ").Append(FlagEscritorioCobranca).Append("\n");
            sb.Append("  EscritoriosCobranca: ").Append(EscritoriosCobranca).Append("\n");
            sb.Append("  TelefonesEscritoriosCobranca: ").Append(TelefonesEscritoriosCobranca).Append("\n");
            
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
            return this.Equals(obj as CredorResponse);
        }

        /// <summary>
        /// Returns true if CredorResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CredorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CredorResponse other)
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
                    this.NomeCredor == other.NomeCredor ||
                    this.NomeCredor != null &&
                    this.NomeCredor.Equals(other.NomeCredor)
                ) && 
                (
                    this.DiaPagamentoSemanal == other.DiaPagamentoSemanal ||
                    this.DiaPagamentoSemanal != null &&
                    this.DiaPagamentoSemanal.Equals(other.DiaPagamentoSemanal)
                ) && 
                (
                    this.DiaPagamentoMensal == other.DiaPagamentoMensal ||
                    this.DiaPagamentoMensal != null &&
                    this.DiaPagamentoMensal.Equals(other.DiaPagamentoMensal)
                ) && 
                (
                    this.DiaPagamentoDecendialPrimeiro == other.DiaPagamentoDecendialPrimeiro ||
                    this.DiaPagamentoDecendialPrimeiro != null &&
                    this.DiaPagamentoDecendialPrimeiro.Equals(other.DiaPagamentoDecendialPrimeiro)
                ) && 
                (
                    this.DiaPagamentoDecendialSegundo == other.DiaPagamentoDecendialSegundo ||
                    this.DiaPagamentoDecendialSegundo != null &&
                    this.DiaPagamentoDecendialSegundo.Equals(other.DiaPagamentoDecendialSegundo)
                ) && 
                (
                    this.DiaPagamentoDecendialTerceiro == other.DiaPagamentoDecendialTerceiro ||
                    this.DiaPagamentoDecendialTerceiro != null &&
                    this.DiaPagamentoDecendialTerceiro.Equals(other.DiaPagamentoDecendialTerceiro)
                ) && 
                (
                    this.DiaPagamentoQuinzenalPrimeiro == other.DiaPagamentoQuinzenalPrimeiro ||
                    this.DiaPagamentoQuinzenalPrimeiro != null &&
                    this.DiaPagamentoQuinzenalPrimeiro.Equals(other.DiaPagamentoQuinzenalPrimeiro)
                ) && 
                (
                    this.DiaPagamentoQuinzenalSegundo == other.DiaPagamentoQuinzenalSegundo ||
                    this.DiaPagamentoQuinzenalSegundo != null &&
                    this.DiaPagamentoQuinzenalSegundo.Equals(other.DiaPagamentoQuinzenalSegundo)
                ) && 
                (
                    this.Banco == other.Banco ||
                    this.Banco != null &&
                    this.Banco.Equals(other.Banco)
                ) && 
                (
                    this.Agencia == other.Agencia ||
                    this.Agencia != null &&
                    this.Agencia.Equals(other.Agencia)
                ) && 
                (
                    this.DigitoAgencia == other.DigitoAgencia ||
                    this.DigitoAgencia != null &&
                    this.DigitoAgencia.Equals(other.DigitoAgencia)
                ) && 
                (
                    this.ContaCorrente == other.ContaCorrente ||
                    this.ContaCorrente != null &&
                    this.ContaCorrente.Equals(other.ContaCorrente)
                ) && 
                (
                    this.DigitoContaCorrente == other.DigitoContaCorrente ||
                    this.DigitoContaCorrente != null &&
                    this.DigitoContaCorrente.Equals(other.DigitoContaCorrente)
                ) && 
                (
                    this.CredorBanco == other.CredorBanco ||
                    this.CredorBanco != null &&
                    this.CredorBanco.Equals(other.CredorBanco)
                ) && 
                (
                    this.PercentualRAV == other.PercentualRAV ||
                    this.PercentualRAV != null &&
                    this.PercentualRAV.Equals(other.PercentualRAV)
                ) && 
                (
                    this.RecebeRAV == other.RecebeRAV ||
                    this.RecebeRAV != null &&
                    this.RecebeRAV.Equals(other.RecebeRAV)
                ) && 
                (
                    this.PercentualMultiplica == other.PercentualMultiplica ||
                    this.PercentualMultiplica != null &&
                    this.PercentualMultiplica.Equals(other.PercentualMultiplica)
                ) && 
                (
                    this.TaxaAdministrativa == other.TaxaAdministrativa ||
                    this.TaxaAdministrativa != null &&
                    this.TaxaAdministrativa.Equals(other.TaxaAdministrativa)
                ) && 
                (
                    this.TaxaBanco == other.TaxaBanco ||
                    this.TaxaBanco != null &&
                    this.TaxaBanco.Equals(other.TaxaBanco)
                ) && 
                (
                    this.LimiteRAV == other.LimiteRAV ||
                    this.LimiteRAV != null &&
                    this.LimiteRAV.Equals(other.LimiteRAV)
                ) && 
                (
                    this.IdCredorRAV == other.IdCredorRAV ||
                    this.IdCredorRAV != null &&
                    this.IdCredorRAV.Equals(other.IdCredorRAV)
                ) && 
                (
                    this.Periodicidade == other.Periodicidade ||
                    this.Periodicidade != null &&
                    this.Periodicidade.Equals(other.Periodicidade)
                ) && 
                (
                    this.IdPessoaJuridica == other.IdPessoaJuridica ||
                    this.IdPessoaJuridica != null &&
                    this.IdPessoaJuridica.Equals(other.IdPessoaJuridica)
                ) && 
                (
                    this.FlagEscritorioCobranca == other.FlagEscritorioCobranca ||
                    this.FlagEscritorioCobranca != null &&
                    this.FlagEscritorioCobranca.Equals(other.FlagEscritorioCobranca)
                ) && 
                (
                    this.EscritoriosCobranca == other.EscritoriosCobranca ||
                    this.EscritoriosCobranca != null &&
                    this.EscritoriosCobranca.Equals(other.EscritoriosCobranca)
                ) && 
                (
                    this.TelefonesEscritoriosCobranca == other.TelefonesEscritoriosCobranca ||
                    this.TelefonesEscritoriosCobranca != null &&
                    this.TelefonesEscritoriosCobranca.SequenceEqual(other.TelefonesEscritoriosCobranca)
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
                
                if (this.NomeCredor != null)
                    hash = hash * 59 + this.NomeCredor.GetHashCode();
                
                if (this.DiaPagamentoSemanal != null)
                    hash = hash * 59 + this.DiaPagamentoSemanal.GetHashCode();
                
                if (this.DiaPagamentoMensal != null)
                    hash = hash * 59 + this.DiaPagamentoMensal.GetHashCode();
                
                if (this.DiaPagamentoDecendialPrimeiro != null)
                    hash = hash * 59 + this.DiaPagamentoDecendialPrimeiro.GetHashCode();
                
                if (this.DiaPagamentoDecendialSegundo != null)
                    hash = hash * 59 + this.DiaPagamentoDecendialSegundo.GetHashCode();
                
                if (this.DiaPagamentoDecendialTerceiro != null)
                    hash = hash * 59 + this.DiaPagamentoDecendialTerceiro.GetHashCode();
                
                if (this.DiaPagamentoQuinzenalPrimeiro != null)
                    hash = hash * 59 + this.DiaPagamentoQuinzenalPrimeiro.GetHashCode();
                
                if (this.DiaPagamentoQuinzenalSegundo != null)
                    hash = hash * 59 + this.DiaPagamentoQuinzenalSegundo.GetHashCode();
                
                if (this.Banco != null)
                    hash = hash * 59 + this.Banco.GetHashCode();
                
                if (this.Agencia != null)
                    hash = hash * 59 + this.Agencia.GetHashCode();
                
                if (this.DigitoAgencia != null)
                    hash = hash * 59 + this.DigitoAgencia.GetHashCode();
                
                if (this.ContaCorrente != null)
                    hash = hash * 59 + this.ContaCorrente.GetHashCode();
                
                if (this.DigitoContaCorrente != null)
                    hash = hash * 59 + this.DigitoContaCorrente.GetHashCode();
                
                if (this.CredorBanco != null)
                    hash = hash * 59 + this.CredorBanco.GetHashCode();
                
                if (this.PercentualRAV != null)
                    hash = hash * 59 + this.PercentualRAV.GetHashCode();
                
                if (this.RecebeRAV != null)
                    hash = hash * 59 + this.RecebeRAV.GetHashCode();
                
                if (this.PercentualMultiplica != null)
                    hash = hash * 59 + this.PercentualMultiplica.GetHashCode();
                
                if (this.TaxaAdministrativa != null)
                    hash = hash * 59 + this.TaxaAdministrativa.GetHashCode();
                
                if (this.TaxaBanco != null)
                    hash = hash * 59 + this.TaxaBanco.GetHashCode();
                
                if (this.LimiteRAV != null)
                    hash = hash * 59 + this.LimiteRAV.GetHashCode();
                
                if (this.IdCredorRAV != null)
                    hash = hash * 59 + this.IdCredorRAV.GetHashCode();
                
                if (this.Periodicidade != null)
                    hash = hash * 59 + this.Periodicidade.GetHashCode();
                
                if (this.IdPessoaJuridica != null)
                    hash = hash * 59 + this.IdPessoaJuridica.GetHashCode();
                
                if (this.FlagEscritorioCobranca != null)
                    hash = hash * 59 + this.FlagEscritorioCobranca.GetHashCode();
                
                if (this.EscritoriosCobranca != null)
                    hash = hash * 59 + this.EscritoriosCobranca.GetHashCode();
                
                if (this.TelefonesEscritoriosCobranca != null)
                    hash = hash * 59 + this.TelefonesEscritoriosCobranca.GetHashCode();
                
                return hash;
            }
        }

    }
}
