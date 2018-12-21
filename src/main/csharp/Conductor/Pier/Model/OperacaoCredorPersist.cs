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
    /// {{{operacao_credor_persist_description}}}
    /// </summary>
    [DataContract]
    public partial class OperacaoCredorPersist :  IEquatable<OperacaoCredorPersist>
    { 
    
        /// <summary>
        /// {{{operacao_credor_persist_periodicidade_value}}}
        /// </summary>
        /// <value>{{{operacao_credor_persist_periodicidade_value}}}</value>
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
        /// {{{operacao_credor_persist_fator_multiplicador_value}}}
        /// </summary>
        /// <value>{{{operacao_credor_persist_fator_multiplicador_value}}}</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FatorMultiplicadorEnum {
            
            [EnumMember(Value = "FORA_AGENDA")]
            ForaAgenda,
            
            [EnumMember(Value = "AGENDA")]
            Agenda,
            
            [EnumMember(Value = "AGENDA_NEGATIVA")]
            AgendaNegativa
        }

    
        /// <summary>
        /// {{{operacao_credor_persist_periodicidade_value}}}
        /// </summary>
        /// <value>{{{operacao_credor_persist_periodicidade_value}}}</value>
        [DataMember(Name="periodicidade", EmitDefaultValue=false)]
        public PeriodicidadeEnum? Periodicidade { get; set; }
    
        /// <summary>
        /// {{{operacao_credor_persist_fator_multiplicador_value}}}
        /// </summary>
        /// <value>{{{operacao_credor_persist_fator_multiplicador_value}}}</value>
        [DataMember(Name="fatorMultiplicador", EmitDefaultValue=false)]
        public FatorMultiplicadorEnum? FatorMultiplicador { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OperacaoCredorPersist" /> class.
        /// Initializes a new instance of the <see cref="OperacaoCredorPersist" />class.
        /// </summary>
        /// <param name="IdOperacao">{{{operacao_credor_persist_id_operacao_value}}} (required).</param>
        /// <param name="IdGrupoEconomico">{{{operacao_credor_persist_id_grupo_economico_value}}} (required).</param>
        /// <param name="IdsProduto">{{{operacao_credor_persist_ids_produto_value}}} (required).</param>
        /// <param name="RemuneracaoPercentual">{{{operacao_credor_persist_remuneracao_percentual_value}}}.</param>
        /// <param name="RemuneracaoFixa">{{{operacao_credor_persist_remuneracao_fixa_value}}}.</param>
        /// <param name="Periodicidade">{{{operacao_credor_persist_periodicidade_value}}}.</param>
        /// <param name="VencimentoPrimeiraParcela">{{{operacao_credor_persist_vencimento_primeira_parcela_value}}}.</param>
        /// <param name="DiasAfastamento">{{{operacao_credor_persist_dias_afastamento_value}}}.</param>
        /// <param name="FatorMultiplicador">{{{operacao_credor_persist_fator_multiplicador_value}}}.</param>
        /// <param name="FlagTaxaFixada">{{{operacao_credor_persist_flag_taxa_fixada_value}}}.</param>
        /// <param name="PlanoMinimo">{{{operacao_credor_persist_plano_minimo_value}}} (required).</param>
        /// <param name="PlanoMaximo">{{{operacao_credor_persist_plano_maximo_value}}} (required).</param>

        public OperacaoCredorPersist(long? IdOperacao = null, long? IdGrupoEconomico = null, List<long?> IdsProduto = null, double? RemuneracaoPercentual = null, double? RemuneracaoFixa = null, PeriodicidadeEnum? Periodicidade = null, int? VencimentoPrimeiraParcela = null, int? DiasAfastamento = null, FatorMultiplicadorEnum? FatorMultiplicador = null, bool? FlagTaxaFixada = null, int? PlanoMinimo = null, int? PlanoMaximo = null)
        {
            // to ensure "IdOperacao" is required (not null)
            if (IdOperacao == null)
            {
                throw new InvalidDataException("IdOperacao is a required property for OperacaoCredorPersist and cannot be null");
            }
            else
            {
                this.IdOperacao = IdOperacao;
            }
            // to ensure "IdGrupoEconomico" is required (not null)
            if (IdGrupoEconomico == null)
            {
                throw new InvalidDataException("IdGrupoEconomico is a required property for OperacaoCredorPersist and cannot be null");
            }
            else
            {
                this.IdGrupoEconomico = IdGrupoEconomico;
            }
            // to ensure "IdsProduto" is required (not null)
            if (IdsProduto == null)
            {
                throw new InvalidDataException("IdsProduto is a required property for OperacaoCredorPersist and cannot be null");
            }
            else
            {
                this.IdsProduto = IdsProduto;
            }
            // to ensure "PlanoMinimo" is required (not null)
            if (PlanoMinimo == null)
            {
                throw new InvalidDataException("PlanoMinimo is a required property for OperacaoCredorPersist and cannot be null");
            }
            else
            {
                this.PlanoMinimo = PlanoMinimo;
            }
            // to ensure "PlanoMaximo" is required (not null)
            if (PlanoMaximo == null)
            {
                throw new InvalidDataException("PlanoMaximo is a required property for OperacaoCredorPersist and cannot be null");
            }
            else
            {
                this.PlanoMaximo = PlanoMaximo;
            }
            this.RemuneracaoPercentual = RemuneracaoPercentual;
            this.RemuneracaoFixa = RemuneracaoFixa;
            this.Periodicidade = Periodicidade;
            this.VencimentoPrimeiraParcela = VencimentoPrimeiraParcela;
            this.DiasAfastamento = DiasAfastamento;
            this.FatorMultiplicador = FatorMultiplicador;
            this.FlagTaxaFixada = FlagTaxaFixada;
            
        }
        
    
        /// <summary>
        /// {{{operacao_credor_persist_id_operacao_value}}}
        /// </summary>
        /// <value>{{{operacao_credor_persist_id_operacao_value}}}</value>
        [DataMember(Name="idOperacao", EmitDefaultValue=false)]
        public long? IdOperacao { get; set; }
    
        /// <summary>
        /// {{{operacao_credor_persist_id_grupo_economico_value}}}
        /// </summary>
        /// <value>{{{operacao_credor_persist_id_grupo_economico_value}}}</value>
        [DataMember(Name="idGrupoEconomico", EmitDefaultValue=false)]
        public long? IdGrupoEconomico { get; set; }
    
        /// <summary>
        /// {{{operacao_credor_persist_ids_produto_value}}}
        /// </summary>
        /// <value>{{{operacao_credor_persist_ids_produto_value}}}</value>
        [DataMember(Name="idsProduto", EmitDefaultValue=false)]
        public List<long?> IdsProduto { get; set; }
    
        /// <summary>
        /// {{{operacao_credor_persist_remuneracao_percentual_value}}}
        /// </summary>
        /// <value>{{{operacao_credor_persist_remuneracao_percentual_value}}}</value>
        [DataMember(Name="remuneracaoPercentual", EmitDefaultValue=false)]
        public double? RemuneracaoPercentual { get; set; }
    
        /// <summary>
        /// {{{operacao_credor_persist_remuneracao_fixa_value}}}
        /// </summary>
        /// <value>{{{operacao_credor_persist_remuneracao_fixa_value}}}</value>
        [DataMember(Name="remuneracaoFixa", EmitDefaultValue=false)]
        public double? RemuneracaoFixa { get; set; }
    
        /// <summary>
        /// {{{operacao_credor_persist_vencimento_primeira_parcela_value}}}
        /// </summary>
        /// <value>{{{operacao_credor_persist_vencimento_primeira_parcela_value}}}</value>
        [DataMember(Name="vencimentoPrimeiraParcela", EmitDefaultValue=false)]
        public int? VencimentoPrimeiraParcela { get; set; }
    
        /// <summary>
        /// {{{operacao_credor_persist_dias_afastamento_value}}}
        /// </summary>
        /// <value>{{{operacao_credor_persist_dias_afastamento_value}}}</value>
        [DataMember(Name="diasAfastamento", EmitDefaultValue=false)]
        public int? DiasAfastamento { get; set; }
    
        /// <summary>
        /// {{{operacao_credor_persist_flag_taxa_fixada_value}}}
        /// </summary>
        /// <value>{{{operacao_credor_persist_flag_taxa_fixada_value}}}</value>
        [DataMember(Name="flagTaxaFixada", EmitDefaultValue=false)]
        public bool? FlagTaxaFixada { get; set; }
    
        /// <summary>
        /// {{{operacao_credor_persist_plano_minimo_value}}}
        /// </summary>
        /// <value>{{{operacao_credor_persist_plano_minimo_value}}}</value>
        [DataMember(Name="planoMinimo", EmitDefaultValue=false)]
        public int? PlanoMinimo { get; set; }
    
        /// <summary>
        /// {{{operacao_credor_persist_plano_maximo_value}}}
        /// </summary>
        /// <value>{{{operacao_credor_persist_plano_maximo_value}}}</value>
        [DataMember(Name="planoMaximo", EmitDefaultValue=false)]
        public int? PlanoMaximo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperacaoCredorPersist {\n");
            sb.Append("  IdOperacao: ").Append(IdOperacao).Append("\n");
            sb.Append("  IdGrupoEconomico: ").Append(IdGrupoEconomico).Append("\n");
            sb.Append("  IdsProduto: ").Append(IdsProduto).Append("\n");
            sb.Append("  RemuneracaoPercentual: ").Append(RemuneracaoPercentual).Append("\n");
            sb.Append("  RemuneracaoFixa: ").Append(RemuneracaoFixa).Append("\n");
            sb.Append("  Periodicidade: ").Append(Periodicidade).Append("\n");
            sb.Append("  VencimentoPrimeiraParcela: ").Append(VencimentoPrimeiraParcela).Append("\n");
            sb.Append("  DiasAfastamento: ").Append(DiasAfastamento).Append("\n");
            sb.Append("  FatorMultiplicador: ").Append(FatorMultiplicador).Append("\n");
            sb.Append("  FlagTaxaFixada: ").Append(FlagTaxaFixada).Append("\n");
            sb.Append("  PlanoMinimo: ").Append(PlanoMinimo).Append("\n");
            sb.Append("  PlanoMaximo: ").Append(PlanoMaximo).Append("\n");
            
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
            return this.Equals(obj as OperacaoCredorPersist);
        }

        /// <summary>
        /// Returns true if OperacaoCredorPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of OperacaoCredorPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperacaoCredorPersist other)
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
                    this.IdGrupoEconomico == other.IdGrupoEconomico ||
                    this.IdGrupoEconomico != null &&
                    this.IdGrupoEconomico.Equals(other.IdGrupoEconomico)
                ) && 
                (
                    this.IdsProduto == other.IdsProduto ||
                    this.IdsProduto != null &&
                    this.IdsProduto.SequenceEqual(other.IdsProduto)
                ) && 
                (
                    this.RemuneracaoPercentual == other.RemuneracaoPercentual ||
                    this.RemuneracaoPercentual != null &&
                    this.RemuneracaoPercentual.Equals(other.RemuneracaoPercentual)
                ) && 
                (
                    this.RemuneracaoFixa == other.RemuneracaoFixa ||
                    this.RemuneracaoFixa != null &&
                    this.RemuneracaoFixa.Equals(other.RemuneracaoFixa)
                ) && 
                (
                    this.Periodicidade == other.Periodicidade ||
                    this.Periodicidade != null &&
                    this.Periodicidade.Equals(other.Periodicidade)
                ) && 
                (
                    this.VencimentoPrimeiraParcela == other.VencimentoPrimeiraParcela ||
                    this.VencimentoPrimeiraParcela != null &&
                    this.VencimentoPrimeiraParcela.Equals(other.VencimentoPrimeiraParcela)
                ) && 
                (
                    this.DiasAfastamento == other.DiasAfastamento ||
                    this.DiasAfastamento != null &&
                    this.DiasAfastamento.Equals(other.DiasAfastamento)
                ) && 
                (
                    this.FatorMultiplicador == other.FatorMultiplicador ||
                    this.FatorMultiplicador != null &&
                    this.FatorMultiplicador.Equals(other.FatorMultiplicador)
                ) && 
                (
                    this.FlagTaxaFixada == other.FlagTaxaFixada ||
                    this.FlagTaxaFixada != null &&
                    this.FlagTaxaFixada.Equals(other.FlagTaxaFixada)
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
                
                if (this.IdGrupoEconomico != null)
                    hash = hash * 59 + this.IdGrupoEconomico.GetHashCode();
                
                if (this.IdsProduto != null)
                    hash = hash * 59 + this.IdsProduto.GetHashCode();
                
                if (this.RemuneracaoPercentual != null)
                    hash = hash * 59 + this.RemuneracaoPercentual.GetHashCode();
                
                if (this.RemuneracaoFixa != null)
                    hash = hash * 59 + this.RemuneracaoFixa.GetHashCode();
                
                if (this.Periodicidade != null)
                    hash = hash * 59 + this.Periodicidade.GetHashCode();
                
                if (this.VencimentoPrimeiraParcela != null)
                    hash = hash * 59 + this.VencimentoPrimeiraParcela.GetHashCode();
                
                if (this.DiasAfastamento != null)
                    hash = hash * 59 + this.DiasAfastamento.GetHashCode();
                
                if (this.FatorMultiplicador != null)
                    hash = hash * 59 + this.FatorMultiplicador.GetHashCode();
                
                if (this.FlagTaxaFixada != null)
                    hash = hash * 59 + this.FlagTaxaFixada.GetHashCode();
                
                if (this.PlanoMinimo != null)
                    hash = hash * 59 + this.PlanoMinimo.GetHashCode();
                
                if (this.PlanoMaximo != null)
                    hash = hash * 59 + this.PlanoMaximo.GetHashCode();
                
                return hash;
            }
        }

    }
}
