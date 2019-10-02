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
    /// Objeto OperacaoCredor
    /// </summary>
    [DataContract]
    public partial class OperacaoCredorPersist :  IEquatable<OperacaoCredorPersist>
    { 
    
        /// <summary>
        /// Periodicidade (DIARIO(1), SEMANAL(2), MENSAL(3), DECENDIAL(4), QUINZENAL(5))
        /// </summary>
        /// <value>Periodicidade (DIARIO(1), SEMANAL(2), MENSAL(3), DECENDIAL(4), QUINZENAL(5))</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PeriodicidadeEnum {
            
            [EnumMember(Value = "NENHUM")]
            Nenhum,
            
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
        /// Fator multiplicador (FORA_AGENDA(0), AGENDA(1))
        /// </summary>
        /// <value>Fator multiplicador (FORA_AGENDA(0), AGENDA(1))</value>
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
        /// Periodicidade (DIARIO(1), SEMANAL(2), MENSAL(3), DECENDIAL(4), QUINZENAL(5))
        /// </summary>
        /// <value>Periodicidade (DIARIO(1), SEMANAL(2), MENSAL(3), DECENDIAL(4), QUINZENAL(5))</value>
        [DataMember(Name="periodicidade", EmitDefaultValue=false)]
        public PeriodicidadeEnum? Periodicidade { get; set; }
    
        /// <summary>
        /// Fator multiplicador (FORA_AGENDA(0), AGENDA(1))
        /// </summary>
        /// <value>Fator multiplicador (FORA_AGENDA(0), AGENDA(1))</value>
        [DataMember(Name="fatorMultiplicador", EmitDefaultValue=false)]
        public FatorMultiplicadorEnum? FatorMultiplicador { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OperacaoCredorPersist" /> class.
        /// Initializes a new instance of the <see cref="OperacaoCredorPersist" />class.
        /// </summary>
        /// <param name="IdOperacao">Apresenta o id da Opera\u00E7\u00E3o (required).</param>
        /// <param name="IdGrupoEconomico">Apresenta o id do Grupo Econ\u00F4mico (required).</param>
        /// <param name="IdsProduto">Apresenta a lista de ids produtos que v\u00E3o ter regras cadastradas (required).</param>
        /// <param name="RemuneracaoPercentual">Remunera\u00E7\u00E3o Percentual.</param>
        /// <param name="RemuneracaoFixa">Remunera\u00E7\u00E3o Fixa.</param>
        /// <param name="Periodicidade">Periodicidade (DIARIO(1), SEMANAL(2), MENSAL(3), DECENDIAL(4), QUINZENAL(5)).</param>
        /// <param name="VencimentoPrimeiraParcela">Vencimento da primeira parcela.</param>
        /// <param name="DiasAfastamento">Dias afastamento.</param>
        /// <param name="FatorMultiplicador">Fator multiplicador (FORA_AGENDA(0), AGENDA(1)).</param>
        /// <param name="FlagTaxaFixada">Flag taxa fixada.</param>
        /// <param name="PlanoMinimo">Plano m\u00EDnimo da regra (required).</param>
        /// <param name="PlanoMaximo">Plano m\u00E1ximo da regra (required).</param>

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
        /// Apresenta o id da Opera\u00E7\u00E3o
        /// </summary>
        /// <value>Apresenta o id da Opera\u00E7\u00E3o</value>
        [DataMember(Name="idOperacao", EmitDefaultValue=false)]
        public long? IdOperacao { get; set; }
    
        /// <summary>
        /// Apresenta o id do Grupo Econ\u00F4mico
        /// </summary>
        /// <value>Apresenta o id do Grupo Econ\u00F4mico</value>
        [DataMember(Name="idGrupoEconomico", EmitDefaultValue=false)]
        public long? IdGrupoEconomico { get; set; }
    
        /// <summary>
        /// Apresenta a lista de ids produtos que v\u00E3o ter regras cadastradas
        /// </summary>
        /// <value>Apresenta a lista de ids produtos que v\u00E3o ter regras cadastradas</value>
        [DataMember(Name="idsProduto", EmitDefaultValue=false)]
        public List<long?> IdsProduto { get; set; }
    
        /// <summary>
        /// Remunera\u00E7\u00E3o Percentual
        /// </summary>
        /// <value>Remunera\u00E7\u00E3o Percentual</value>
        [DataMember(Name="remuneracaoPercentual", EmitDefaultValue=false)]
        public double? RemuneracaoPercentual { get; set; }
    
        /// <summary>
        /// Remunera\u00E7\u00E3o Fixa
        /// </summary>
        /// <value>Remunera\u00E7\u00E3o Fixa</value>
        [DataMember(Name="remuneracaoFixa", EmitDefaultValue=false)]
        public double? RemuneracaoFixa { get; set; }
    
        /// <summary>
        /// Vencimento da primeira parcela
        /// </summary>
        /// <value>Vencimento da primeira parcela</value>
        [DataMember(Name="vencimentoPrimeiraParcela", EmitDefaultValue=false)]
        public int? VencimentoPrimeiraParcela { get; set; }
    
        /// <summary>
        /// Dias afastamento
        /// </summary>
        /// <value>Dias afastamento</value>
        [DataMember(Name="diasAfastamento", EmitDefaultValue=false)]
        public int? DiasAfastamento { get; set; }
    
        /// <summary>
        /// Flag taxa fixada
        /// </summary>
        /// <value>Flag taxa fixada</value>
        [DataMember(Name="flagTaxaFixada", EmitDefaultValue=false)]
        public bool? FlagTaxaFixada { get; set; }
    
        /// <summary>
        /// Plano m\u00EDnimo da regra
        /// </summary>
        /// <value>Plano m\u00EDnimo da regra</value>
        [DataMember(Name="planoMinimo", EmitDefaultValue=false)]
        public int? PlanoMinimo { get; set; }
    
        /// <summary>
        /// Plano m\u00E1ximo da regra
        /// </summary>
        /// <value>Plano m\u00E1ximo da regra</value>
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
