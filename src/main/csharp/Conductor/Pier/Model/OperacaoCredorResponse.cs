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
    /// ObjectOperationCreditor
    /// </summary>
    [DataContract]
    public partial class OperacaoCredorResponse :  IEquatable<OperacaoCredorResponse>
    { 
    
        /// <summary>
        /// Frequency (DAILY(1), WEEKLY(2), MONTHLY(3), DECENDIAL(4), BIWEEKLY(5))
        /// </summary>
        /// <value>Frequency (DAILY(1), WEEKLY(2), MONTHLY(3), DECENDIAL(4), BIWEEKLY(5))</value>
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
        /// Factor Multiplier (OUT_SCHEDULE(0), SCHEDULE(1))
        /// </summary>
        /// <value>Factor Multiplier (OUT_SCHEDULE(0), SCHEDULE(1))</value>
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
        /// Frequency (DAILY(1), WEEKLY(2), MONTHLY(3), DECENDIAL(4), BIWEEKLY(5))
        /// </summary>
        /// <value>Frequency (DAILY(1), WEEKLY(2), MONTHLY(3), DECENDIAL(4), BIWEEKLY(5))</value>
        [DataMember(Name="periodicidade", EmitDefaultValue=false)]
        public PeriodicidadeEnum? Periodicidade { get; set; }
    
        /// <summary>
        /// Factor Multiplier (OUT_SCHEDULE(0), SCHEDULE(1))
        /// </summary>
        /// <value>Factor Multiplier (OUT_SCHEDULE(0), SCHEDULE(1))</value>
        [DataMember(Name="fatorMultiplicador", EmitDefaultValue=false)]
        public FatorMultiplicadorEnum? FatorMultiplicador { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OperacaoCredorResponse" /> class.
        /// Initializes a new instance of the <see cref="OperacaoCredorResponse" />class.
        /// </summary>
        /// <param name="Id">Show the id of the OperationCreditor.</param>
        /// <param name="IdOperacao">Show the id of the Operation.</param>
        /// <param name="IdGrupoEconomico">Show the Economic Id group.</param>
        /// <param name="IdProduto">Show the id of the product.</param>
        /// <param name="RemuneracaoPercentual">Percentage Remunaration.</param>
        /// <param name="RemuneracaoFixa">Remuneration fixed.</param>
        /// <param name="Periodicidade">Frequency (DAILY(1), WEEKLY(2), MONTHLY(3), DECENDIAL(4), BIWEEKLY(5)).</param>
        /// <param name="VencimentoPrimeiraParcela">Expiration of the first parcel.</param>
        /// <param name="DiasAfastamento">Removal days.</param>
        /// <param name="FatorMultiplicador">Factor Multiplier (OUT_SCHEDULE(0), SCHEDULE(1)).</param>
        /// <param name="FlagTaxaFixada">Flag taxe fixed.</param>
        /// <param name="PlanoMinimo">Minimum Plan of the rule.</param>
        /// <param name="PlanoMaximo">Maximum Plan of the rule.</param>

        public OperacaoCredorResponse(long? Id = null, long? IdOperacao = null, long? IdGrupoEconomico = null, long? IdProduto = null, double? RemuneracaoPercentual = null, double? RemuneracaoFixa = null, PeriodicidadeEnum? Periodicidade = null, int? VencimentoPrimeiraParcela = null, int? DiasAfastamento = null, FatorMultiplicadorEnum? FatorMultiplicador = null, bool? FlagTaxaFixada = null, int? PlanoMinimo = null, int? PlanoMaximo = null)
        {
            this.Id = Id;
            this.IdOperacao = IdOperacao;
            this.IdGrupoEconomico = IdGrupoEconomico;
            this.IdProduto = IdProduto;
            this.RemuneracaoPercentual = RemuneracaoPercentual;
            this.RemuneracaoFixa = RemuneracaoFixa;
            this.Periodicidade = Periodicidade;
            this.VencimentoPrimeiraParcela = VencimentoPrimeiraParcela;
            this.DiasAfastamento = DiasAfastamento;
            this.FatorMultiplicador = FatorMultiplicador;
            this.FlagTaxaFixada = FlagTaxaFixada;
            this.PlanoMinimo = PlanoMinimo;
            this.PlanoMaximo = PlanoMaximo;
            
        }
        
    
        /// <summary>
        /// Show the id of the OperationCreditor
        /// </summary>
        /// <value>Show the id of the OperationCreditor</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Show the id of the Operation
        /// </summary>
        /// <value>Show the id of the Operation</value>
        [DataMember(Name="idOperacao", EmitDefaultValue=false)]
        public long? IdOperacao { get; set; }
    
        /// <summary>
        /// Show the Economic Id group
        /// </summary>
        /// <value>Show the Economic Id group</value>
        [DataMember(Name="idGrupoEconomico", EmitDefaultValue=false)]
        public long? IdGrupoEconomico { get; set; }
    
        /// <summary>
        /// Show the id of the product
        /// </summary>
        /// <value>Show the id of the product</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Percentage Remunaration
        /// </summary>
        /// <value>Percentage Remunaration</value>
        [DataMember(Name="remuneracaoPercentual", EmitDefaultValue=false)]
        public double? RemuneracaoPercentual { get; set; }
    
        /// <summary>
        /// Remuneration fixed
        /// </summary>
        /// <value>Remuneration fixed</value>
        [DataMember(Name="remuneracaoFixa", EmitDefaultValue=false)]
        public double? RemuneracaoFixa { get; set; }
    
        /// <summary>
        /// Expiration of the first parcel
        /// </summary>
        /// <value>Expiration of the first parcel</value>
        [DataMember(Name="vencimentoPrimeiraParcela", EmitDefaultValue=false)]
        public int? VencimentoPrimeiraParcela { get; set; }
    
        /// <summary>
        /// Removal days
        /// </summary>
        /// <value>Removal days</value>
        [DataMember(Name="diasAfastamento", EmitDefaultValue=false)]
        public int? DiasAfastamento { get; set; }
    
        /// <summary>
        /// Flag taxe fixed
        /// </summary>
        /// <value>Flag taxe fixed</value>
        [DataMember(Name="flagTaxaFixada", EmitDefaultValue=false)]
        public bool? FlagTaxaFixada { get; set; }
    
        /// <summary>
        /// Minimum Plan of the rule
        /// </summary>
        /// <value>Minimum Plan of the rule</value>
        [DataMember(Name="planoMinimo", EmitDefaultValue=false)]
        public int? PlanoMinimo { get; set; }
    
        /// <summary>
        /// Maximum Plan of the rule
        /// </summary>
        /// <value>Maximum Plan of the rule</value>
        [DataMember(Name="planoMaximo", EmitDefaultValue=false)]
        public int? PlanoMaximo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperacaoCredorResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdOperacao: ").Append(IdOperacao).Append("\n");
            sb.Append("  IdGrupoEconomico: ").Append(IdGrupoEconomico).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
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
            return this.Equals(obj as OperacaoCredorResponse);
        }

        /// <summary>
        /// Returns true if OperacaoCredorResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OperacaoCredorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperacaoCredorResponse other)
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
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdOperacao != null)
                    hash = hash * 59 + this.IdOperacao.GetHashCode();
                
                if (this.IdGrupoEconomico != null)
                    hash = hash * 59 + this.IdGrupoEconomico.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
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
