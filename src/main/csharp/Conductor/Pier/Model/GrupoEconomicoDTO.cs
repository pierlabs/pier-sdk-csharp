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
    /// {{{grupo_economico_d_t_o_description}}}
    /// </summary>
    [DataContract]
    public partial class GrupoEconomicoDTO :  IEquatable<GrupoEconomicoDTO>
    { 
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_periodicidade_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_periodicidade_value}}}</value>
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
        /// {{{grupo_economico_d_t_o_pagamento_semanal_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_pagamento_semanal_value}}}</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PagamentoSemanalEnum {
            
            [EnumMember(Value = "SEGUNDA")]
            Segunda,
            
            [EnumMember(Value = "TERCA")]
            Terca,
            
            [EnumMember(Value = "QUARTA")]
            Quarta,
            
            [EnumMember(Value = "QUINTA")]
            Quinta,
            
            [EnumMember(Value = "SEXTA")]
            Sexta,
            
            [EnumMember(Value = "SABADO")]
            Sabado,
            
            [EnumMember(Value = "DOMINGO")]
            Domingo
        }

    
        /// <summary>
        /// {{{grupo_economico_d_t_o_recebe_r_a_v_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_recebe_r_a_v_value}}}</value>
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
        /// {{{grupo_economico_d_t_o_periodicidade_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_periodicidade_value}}}</value>
        [DataMember(Name="periodicidade", EmitDefaultValue=false)]
        public PeriodicidadeEnum? Periodicidade { get; set; }
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_pagamento_semanal_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_pagamento_semanal_value}}}</value>
        [DataMember(Name="pagamentoSemanal", EmitDefaultValue=false)]
        public PagamentoSemanalEnum? PagamentoSemanal { get; set; }
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_recebe_r_a_v_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_recebe_r_a_v_value}}}</value>
        [DataMember(Name="recebeRAV", EmitDefaultValue=false)]
        public RecebeRAVEnum? RecebeRAV { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GrupoEconomicoDTO" /> class.
        /// Initializes a new instance of the <see cref="GrupoEconomicoDTO" />class.
        /// </summary>
        /// <param name="RazaoSocial">{{{grupo_economico_d_t_o_razao_social_value}}} (required).</param>
        /// <param name="NomeCredor">{{{grupo_economico_d_t_o_nome_credor_value}}}.</param>
        /// <param name="NumeroReceitaFederal">{{{grupo_economico_d_t_o_numero_receita_federal_value}}} (required).</param>
        /// <param name="InscricaoEstadual">{{{grupo_economico_d_t_o_inscricao_estadual_value}}}.</param>
        /// <param name="Contato">{{{grupo_economico_d_t_o_contato_value}}}.</param>
        /// <param name="Banco">{{{grupo_economico_d_t_o_banco_value}}}.</param>
        /// <param name="Agencia">{{{grupo_economico_d_t_o_agencia_value}}}.</param>
        /// <param name="DigitoAgencia">{{{grupo_economico_d_t_o_digito_agencia_value}}}.</param>
        /// <param name="ContaCorrente">{{{grupo_economico_d_t_o_conta_corrente_value}}}.</param>
        /// <param name="DigitoContaCorrente">{{{grupo_economico_d_t_o_digito_conta_corrente_value}}}.</param>
        /// <param name="Periodicidade">{{{grupo_economico_d_t_o_periodicidade_value}}} (required).</param>
        /// <param name="PagamentoSemanal">{{{grupo_economico_d_t_o_pagamento_semanal_value}}}.</param>
        /// <param name="PagamentoMensal">{{{grupo_economico_d_t_o_pagamento_mensal_value}}}.</param>
        /// <param name="PagamentoDecendialPrimeiro">{{{grupo_economico_d_t_o_pagamento_decendial_primeiro_value}}}.</param>
        /// <param name="PagamentoDecendialSegundo">{{{grupo_economico_d_t_o_pagamento_decendial_segundo_value}}}.</param>
        /// <param name="PagamentoDecendialTerceiro">{{{grupo_economico_d_t_o_pagamento_decendial_terceiro_value}}}.</param>
        /// <param name="PagamentoQuinzenalPrimeiro">{{{grupo_economico_d_t_o_pagamento_quinzenal_primeiro_value}}}.</param>
        /// <param name="PagamentoQuinzenalSegundo">{{{grupo_economico_d_t_o_pagamento_quinzenal_segundo_value}}}.</param>
        /// <param name="IdCredorRAV">{{{grupo_economico_d_t_o_id_credor_r_a_v_value}}} (required).</param>
        /// <param name="PercentualRAV">{{{grupo_economico_d_t_o_percentual_r_a_v_value}}} (required).</param>
        /// <param name="RecebeRAV">{{{grupo_economico_d_t_o_recebe_r_a_v_value}}}.</param>
        /// <param name="PercentualMultiplica">{{{grupo_economico_d_t_o_percentual_multiplica_value}}}.</param>
        /// <param name="TaxaAdm">{{{grupo_economico_d_t_o_taxa_adm_value}}}.</param>
        /// <param name="TaxaBanco">{{{grupo_economico_d_t_o_taxa_banco_value}}}.</param>
        /// <param name="LimiteRAV">{{{grupo_economico_d_t_o_limite_r_a_v_value}}}.</param>

        public GrupoEconomicoDTO(string RazaoSocial = null, string NomeCredor = null, string NumeroReceitaFederal = null, string InscricaoEstadual = null, string Contato = null, int? Banco = null, int? Agencia = null, string DigitoAgencia = null, string ContaCorrente = null, string DigitoContaCorrente = null, PeriodicidadeEnum? Periodicidade = null, PagamentoSemanalEnum? PagamentoSemanal = null, int? PagamentoMensal = null, int? PagamentoDecendialPrimeiro = null, int? PagamentoDecendialSegundo = null, int? PagamentoDecendialTerceiro = null, int? PagamentoQuinzenalPrimeiro = null, int? PagamentoQuinzenalSegundo = null, long? IdCredorRAV = null, double? PercentualRAV = null, RecebeRAVEnum? RecebeRAV = null, double? PercentualMultiplica = null, double? TaxaAdm = null, double? TaxaBanco = null, double? LimiteRAV = null)
        {
            // to ensure "RazaoSocial" is required (not null)
            if (RazaoSocial == null)
            {
                throw new InvalidDataException("RazaoSocial is a required property for GrupoEconomicoDTO and cannot be null");
            }
            else
            {
                this.RazaoSocial = RazaoSocial;
            }
            // to ensure "NumeroReceitaFederal" is required (not null)
            if (NumeroReceitaFederal == null)
            {
                throw new InvalidDataException("NumeroReceitaFederal is a required property for GrupoEconomicoDTO and cannot be null");
            }
            else
            {
                this.NumeroReceitaFederal = NumeroReceitaFederal;
            }
            // to ensure "Periodicidade" is required (not null)
            if (Periodicidade == null)
            {
                throw new InvalidDataException("Periodicidade is a required property for GrupoEconomicoDTO and cannot be null");
            }
            else
            {
                this.Periodicidade = Periodicidade;
            }
            // to ensure "IdCredorRAV" is required (not null)
            if (IdCredorRAV == null)
            {
                throw new InvalidDataException("IdCredorRAV is a required property for GrupoEconomicoDTO and cannot be null");
            }
            else
            {
                this.IdCredorRAV = IdCredorRAV;
            }
            // to ensure "PercentualRAV" is required (not null)
            if (PercentualRAV == null)
            {
                throw new InvalidDataException("PercentualRAV is a required property for GrupoEconomicoDTO and cannot be null");
            }
            else
            {
                this.PercentualRAV = PercentualRAV;
            }
            this.NomeCredor = NomeCredor;
            this.InscricaoEstadual = InscricaoEstadual;
            this.Contato = Contato;
            this.Banco = Banco;
            this.Agencia = Agencia;
            this.DigitoAgencia = DigitoAgencia;
            this.ContaCorrente = ContaCorrente;
            this.DigitoContaCorrente = DigitoContaCorrente;
            this.PagamentoSemanal = PagamentoSemanal;
            this.PagamentoMensal = PagamentoMensal;
            this.PagamentoDecendialPrimeiro = PagamentoDecendialPrimeiro;
            this.PagamentoDecendialSegundo = PagamentoDecendialSegundo;
            this.PagamentoDecendialTerceiro = PagamentoDecendialTerceiro;
            this.PagamentoQuinzenalPrimeiro = PagamentoQuinzenalPrimeiro;
            this.PagamentoQuinzenalSegundo = PagamentoQuinzenalSegundo;
            this.RecebeRAV = RecebeRAV;
            this.PercentualMultiplica = PercentualMultiplica;
            this.TaxaAdm = TaxaAdm;
            this.TaxaBanco = TaxaBanco;
            this.LimiteRAV = LimiteRAV;
            
        }
        
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_razao_social_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_razao_social_value}}}</value>
        [DataMember(Name="razaoSocial", EmitDefaultValue=false)]
        public string RazaoSocial { get; set; }
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_nome_credor_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_nome_credor_value}}}</value>
        [DataMember(Name="nomeCredor", EmitDefaultValue=false)]
        public string NomeCredor { get; set; }
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_numero_receita_federal_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_numero_receita_federal_value}}}</value>
        [DataMember(Name="numeroReceitaFederal", EmitDefaultValue=false)]
        public string NumeroReceitaFederal { get; set; }
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_inscricao_estadual_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_inscricao_estadual_value}}}</value>
        [DataMember(Name="inscricaoEstadual", EmitDefaultValue=false)]
        public string InscricaoEstadual { get; set; }
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_contato_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_contato_value}}}</value>
        [DataMember(Name="contato", EmitDefaultValue=false)]
        public string Contato { get; set; }
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_banco_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_banco_value}}}</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public int? Banco { get; set; }
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_agencia_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_agencia_value}}}</value>
        [DataMember(Name="agencia", EmitDefaultValue=false)]
        public int? Agencia { get; set; }
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_digito_agencia_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_digito_agencia_value}}}</value>
        [DataMember(Name="digitoAgencia", EmitDefaultValue=false)]
        public string DigitoAgencia { get; set; }
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_conta_corrente_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_conta_corrente_value}}}</value>
        [DataMember(Name="contaCorrente", EmitDefaultValue=false)]
        public string ContaCorrente { get; set; }
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_digito_conta_corrente_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_digito_conta_corrente_value}}}</value>
        [DataMember(Name="digitoContaCorrente", EmitDefaultValue=false)]
        public string DigitoContaCorrente { get; set; }
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_pagamento_mensal_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_pagamento_mensal_value}}}</value>
        [DataMember(Name="pagamentoMensal", EmitDefaultValue=false)]
        public int? PagamentoMensal { get; set; }
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_pagamento_decendial_primeiro_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_pagamento_decendial_primeiro_value}}}</value>
        [DataMember(Name="pagamentoDecendialPrimeiro", EmitDefaultValue=false)]
        public int? PagamentoDecendialPrimeiro { get; set; }
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_pagamento_decendial_segundo_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_pagamento_decendial_segundo_value}}}</value>
        [DataMember(Name="pagamentoDecendialSegundo", EmitDefaultValue=false)]
        public int? PagamentoDecendialSegundo { get; set; }
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_pagamento_decendial_terceiro_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_pagamento_decendial_terceiro_value}}}</value>
        [DataMember(Name="pagamentoDecendialTerceiro", EmitDefaultValue=false)]
        public int? PagamentoDecendialTerceiro { get; set; }
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_pagamento_quinzenal_primeiro_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_pagamento_quinzenal_primeiro_value}}}</value>
        [DataMember(Name="pagamentoQuinzenalPrimeiro", EmitDefaultValue=false)]
        public int? PagamentoQuinzenalPrimeiro { get; set; }
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_pagamento_quinzenal_segundo_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_pagamento_quinzenal_segundo_value}}}</value>
        [DataMember(Name="pagamentoQuinzenalSegundo", EmitDefaultValue=false)]
        public int? PagamentoQuinzenalSegundo { get; set; }
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_id_credor_r_a_v_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_id_credor_r_a_v_value}}}</value>
        [DataMember(Name="idCredorRAV", EmitDefaultValue=false)]
        public long? IdCredorRAV { get; set; }
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_percentual_r_a_v_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_percentual_r_a_v_value}}}</value>
        [DataMember(Name="percentualRAV", EmitDefaultValue=false)]
        public double? PercentualRAV { get; set; }
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_percentual_multiplica_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_percentual_multiplica_value}}}</value>
        [DataMember(Name="percentualMultiplica", EmitDefaultValue=false)]
        public double? PercentualMultiplica { get; set; }
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_taxa_adm_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_taxa_adm_value}}}</value>
        [DataMember(Name="taxaAdm", EmitDefaultValue=false)]
        public double? TaxaAdm { get; set; }
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_taxa_banco_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_taxa_banco_value}}}</value>
        [DataMember(Name="taxaBanco", EmitDefaultValue=false)]
        public double? TaxaBanco { get; set; }
    
        /// <summary>
        /// {{{grupo_economico_d_t_o_limite_r_a_v_value}}}
        /// </summary>
        /// <value>{{{grupo_economico_d_t_o_limite_r_a_v_value}}}</value>
        [DataMember(Name="limiteRAV", EmitDefaultValue=false)]
        public double? LimiteRAV { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GrupoEconomicoDTO {\n");
            sb.Append("  RazaoSocial: ").Append(RazaoSocial).Append("\n");
            sb.Append("  NomeCredor: ").Append(NomeCredor).Append("\n");
            sb.Append("  NumeroReceitaFederal: ").Append(NumeroReceitaFederal).Append("\n");
            sb.Append("  InscricaoEstadual: ").Append(InscricaoEstadual).Append("\n");
            sb.Append("  Contato: ").Append(Contato).Append("\n");
            sb.Append("  Banco: ").Append(Banco).Append("\n");
            sb.Append("  Agencia: ").Append(Agencia).Append("\n");
            sb.Append("  DigitoAgencia: ").Append(DigitoAgencia).Append("\n");
            sb.Append("  ContaCorrente: ").Append(ContaCorrente).Append("\n");
            sb.Append("  DigitoContaCorrente: ").Append(DigitoContaCorrente).Append("\n");
            sb.Append("  Periodicidade: ").Append(Periodicidade).Append("\n");
            sb.Append("  PagamentoSemanal: ").Append(PagamentoSemanal).Append("\n");
            sb.Append("  PagamentoMensal: ").Append(PagamentoMensal).Append("\n");
            sb.Append("  PagamentoDecendialPrimeiro: ").Append(PagamentoDecendialPrimeiro).Append("\n");
            sb.Append("  PagamentoDecendialSegundo: ").Append(PagamentoDecendialSegundo).Append("\n");
            sb.Append("  PagamentoDecendialTerceiro: ").Append(PagamentoDecendialTerceiro).Append("\n");
            sb.Append("  PagamentoQuinzenalPrimeiro: ").Append(PagamentoQuinzenalPrimeiro).Append("\n");
            sb.Append("  PagamentoQuinzenalSegundo: ").Append(PagamentoQuinzenalSegundo).Append("\n");
            sb.Append("  IdCredorRAV: ").Append(IdCredorRAV).Append("\n");
            sb.Append("  PercentualRAV: ").Append(PercentualRAV).Append("\n");
            sb.Append("  RecebeRAV: ").Append(RecebeRAV).Append("\n");
            sb.Append("  PercentualMultiplica: ").Append(PercentualMultiplica).Append("\n");
            sb.Append("  TaxaAdm: ").Append(TaxaAdm).Append("\n");
            sb.Append("  TaxaBanco: ").Append(TaxaBanco).Append("\n");
            sb.Append("  LimiteRAV: ").Append(LimiteRAV).Append("\n");
            
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
            return this.Equals(obj as GrupoEconomicoDTO);
        }

        /// <summary>
        /// Returns true if GrupoEconomicoDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of GrupoEconomicoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GrupoEconomicoDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RazaoSocial == other.RazaoSocial ||
                    this.RazaoSocial != null &&
                    this.RazaoSocial.Equals(other.RazaoSocial)
                ) && 
                (
                    this.NomeCredor == other.NomeCredor ||
                    this.NomeCredor != null &&
                    this.NomeCredor.Equals(other.NomeCredor)
                ) && 
                (
                    this.NumeroReceitaFederal == other.NumeroReceitaFederal ||
                    this.NumeroReceitaFederal != null &&
                    this.NumeroReceitaFederal.Equals(other.NumeroReceitaFederal)
                ) && 
                (
                    this.InscricaoEstadual == other.InscricaoEstadual ||
                    this.InscricaoEstadual != null &&
                    this.InscricaoEstadual.Equals(other.InscricaoEstadual)
                ) && 
                (
                    this.Contato == other.Contato ||
                    this.Contato != null &&
                    this.Contato.Equals(other.Contato)
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
                    this.Periodicidade == other.Periodicidade ||
                    this.Periodicidade != null &&
                    this.Periodicidade.Equals(other.Periodicidade)
                ) && 
                (
                    this.PagamentoSemanal == other.PagamentoSemanal ||
                    this.PagamentoSemanal != null &&
                    this.PagamentoSemanal.Equals(other.PagamentoSemanal)
                ) && 
                (
                    this.PagamentoMensal == other.PagamentoMensal ||
                    this.PagamentoMensal != null &&
                    this.PagamentoMensal.Equals(other.PagamentoMensal)
                ) && 
                (
                    this.PagamentoDecendialPrimeiro == other.PagamentoDecendialPrimeiro ||
                    this.PagamentoDecendialPrimeiro != null &&
                    this.PagamentoDecendialPrimeiro.Equals(other.PagamentoDecendialPrimeiro)
                ) && 
                (
                    this.PagamentoDecendialSegundo == other.PagamentoDecendialSegundo ||
                    this.PagamentoDecendialSegundo != null &&
                    this.PagamentoDecendialSegundo.Equals(other.PagamentoDecendialSegundo)
                ) && 
                (
                    this.PagamentoDecendialTerceiro == other.PagamentoDecendialTerceiro ||
                    this.PagamentoDecendialTerceiro != null &&
                    this.PagamentoDecendialTerceiro.Equals(other.PagamentoDecendialTerceiro)
                ) && 
                (
                    this.PagamentoQuinzenalPrimeiro == other.PagamentoQuinzenalPrimeiro ||
                    this.PagamentoQuinzenalPrimeiro != null &&
                    this.PagamentoQuinzenalPrimeiro.Equals(other.PagamentoQuinzenalPrimeiro)
                ) && 
                (
                    this.PagamentoQuinzenalSegundo == other.PagamentoQuinzenalSegundo ||
                    this.PagamentoQuinzenalSegundo != null &&
                    this.PagamentoQuinzenalSegundo.Equals(other.PagamentoQuinzenalSegundo)
                ) && 
                (
                    this.IdCredorRAV == other.IdCredorRAV ||
                    this.IdCredorRAV != null &&
                    this.IdCredorRAV.Equals(other.IdCredorRAV)
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
                    this.TaxaAdm == other.TaxaAdm ||
                    this.TaxaAdm != null &&
                    this.TaxaAdm.Equals(other.TaxaAdm)
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
                
                if (this.RazaoSocial != null)
                    hash = hash * 59 + this.RazaoSocial.GetHashCode();
                
                if (this.NomeCredor != null)
                    hash = hash * 59 + this.NomeCredor.GetHashCode();
                
                if (this.NumeroReceitaFederal != null)
                    hash = hash * 59 + this.NumeroReceitaFederal.GetHashCode();
                
                if (this.InscricaoEstadual != null)
                    hash = hash * 59 + this.InscricaoEstadual.GetHashCode();
                
                if (this.Contato != null)
                    hash = hash * 59 + this.Contato.GetHashCode();
                
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
                
                if (this.Periodicidade != null)
                    hash = hash * 59 + this.Periodicidade.GetHashCode();
                
                if (this.PagamentoSemanal != null)
                    hash = hash * 59 + this.PagamentoSemanal.GetHashCode();
                
                if (this.PagamentoMensal != null)
                    hash = hash * 59 + this.PagamentoMensal.GetHashCode();
                
                if (this.PagamentoDecendialPrimeiro != null)
                    hash = hash * 59 + this.PagamentoDecendialPrimeiro.GetHashCode();
                
                if (this.PagamentoDecendialSegundo != null)
                    hash = hash * 59 + this.PagamentoDecendialSegundo.GetHashCode();
                
                if (this.PagamentoDecendialTerceiro != null)
                    hash = hash * 59 + this.PagamentoDecendialTerceiro.GetHashCode();
                
                if (this.PagamentoQuinzenalPrimeiro != null)
                    hash = hash * 59 + this.PagamentoQuinzenalPrimeiro.GetHashCode();
                
                if (this.PagamentoQuinzenalSegundo != null)
                    hash = hash * 59 + this.PagamentoQuinzenalSegundo.GetHashCode();
                
                if (this.IdCredorRAV != null)
                    hash = hash * 59 + this.IdCredorRAV.GetHashCode();
                
                if (this.PercentualRAV != null)
                    hash = hash * 59 + this.PercentualRAV.GetHashCode();
                
                if (this.RecebeRAV != null)
                    hash = hash * 59 + this.RecebeRAV.GetHashCode();
                
                if (this.PercentualMultiplica != null)
                    hash = hash * 59 + this.PercentualMultiplica.GetHashCode();
                
                if (this.TaxaAdm != null)
                    hash = hash * 59 + this.TaxaAdm.GetHashCode();
                
                if (this.TaxaBanco != null)
                    hash = hash * 59 + this.TaxaBanco.GetHashCode();
                
                if (this.LimiteRAV != null)
                    hash = hash * 59 + this.LimiteRAV.GetHashCode();
                
                return hash;
            }
        }

    }
}
