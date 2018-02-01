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
    public partial class OperacaoCredorUpdate :  IEquatable<OperacaoCredorUpdate>
    { 
    
        /// <summary>
        /// Periodicidade (DIARIO(1), SEMANAL(2), MENSAL(3), DECENDIAL(4), QUINZENAL(5)).
        /// </summary>
        /// <value>Periodicidade (DIARIO(1), SEMANAL(2), MENSAL(3), DECENDIAL(4), QUINZENAL(5)).</value>
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
        /// Fator multiplicador (FORA_AGENDA(0), AGENDA(1)).
        /// </summary>
        /// <value>Fator multiplicador (FORA_AGENDA(0), AGENDA(1)).</value>
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
        /// Periodicidade (DIARIO(1), SEMANAL(2), MENSAL(3), DECENDIAL(4), QUINZENAL(5)).
        /// </summary>
        /// <value>Periodicidade (DIARIO(1), SEMANAL(2), MENSAL(3), DECENDIAL(4), QUINZENAL(5)).</value>
        [DataMember(Name="periodicidade", EmitDefaultValue=false)]
        public PeriodicidadeEnum? Periodicidade { get; set; }
    
        /// <summary>
        /// Fator multiplicador (FORA_AGENDA(0), AGENDA(1)).
        /// </summary>
        /// <value>Fator multiplicador (FORA_AGENDA(0), AGENDA(1)).</value>
        [DataMember(Name="fatorMultiplicador", EmitDefaultValue=false)]
        public FatorMultiplicadorEnum? FatorMultiplicador { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OperacaoCredorUpdate" /> class.
        /// Initializes a new instance of the <see cref="OperacaoCredorUpdate" />class.
        /// </summary>
        /// <param name="IdOperacao">Apresenta o id da Opera\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="IdCredor">Apresenta o id do Credor..</param>
        /// <param name="IdProduto">Apresenta o id do produto que vai ser alterado..</param>
        /// <param name="RemuneracaoPercentual">Remunera\u00C3\u00A7\u00C3\u00A3o Percentual..</param>
        /// <param name="RemuneracaoFixa">Remunera\u00C3\u00A7\u00C3\u00A3o Fixa..</param>
        /// <param name="Periodicidade">Periodicidade (DIARIO(1), SEMANAL(2), MENSAL(3), DECENDIAL(4), QUINZENAL(5))..</param>
        /// <param name="VencimentoPrimeiraParcela">Vencimento da primeira parcela..</param>
        /// <param name="DiasAfastamento">Dias afastamento..</param>
        /// <param name="FatorMultiplicador">Fator multiplicador (FORA_AGENDA(0), AGENDA(1))..</param>
        /// <param name="FlagTaxaFixada">Flag taxa fixada..</param>
        /// <param name="PlanoMinimo">Plano m\u00C3\u00ADnimo da regra..</param>
        /// <param name="PlanoMaximo">Plano m\u00C3\u00A1ximo da regra..</param>

        public OperacaoCredorUpdate(long? IdOperacao = null, long? IdCredor = null, long? IdProduto = null, double? RemuneracaoPercentual = null, double? RemuneracaoFixa = null, PeriodicidadeEnum? Periodicidade = null, int? VencimentoPrimeiraParcela = null, int? DiasAfastamento = null, FatorMultiplicadorEnum? FatorMultiplicador = null, bool? FlagTaxaFixada = null, int? PlanoMinimo = null, int? PlanoMaximo = null)
        {
            this.IdOperacao = IdOperacao;
            this.IdCredor = IdCredor;
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
        /// Apresenta o id da Opera\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Apresenta o id da Opera\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="idOperacao", EmitDefaultValue=false)]
        public long? IdOperacao { get; set; }
    
        /// <summary>
        /// Apresenta o id do Credor.
        /// </summary>
        /// <value>Apresenta o id do Credor.</value>
        [DataMember(Name="idCredor", EmitDefaultValue=false)]
        public long? IdCredor { get; set; }
    
        /// <summary>
        /// Apresenta o id do produto que vai ser alterado.
        /// </summary>
        /// <value>Apresenta o id do produto que vai ser alterado.</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Remunera\u00C3\u00A7\u00C3\u00A3o Percentual.
        /// </summary>
        /// <value>Remunera\u00C3\u00A7\u00C3\u00A3o Percentual.</value>
        [DataMember(Name="remuneracaoPercentual", EmitDefaultValue=false)]
        public double? RemuneracaoPercentual { get; set; }
    
        /// <summary>
        /// Remunera\u00C3\u00A7\u00C3\u00A3o Fixa.
        /// </summary>
        /// <value>Remunera\u00C3\u00A7\u00C3\u00A3o Fixa.</value>
        [DataMember(Name="remuneracaoFixa", EmitDefaultValue=false)]
        public double? RemuneracaoFixa { get; set; }
    
        /// <summary>
        /// Vencimento da primeira parcela.
        /// </summary>
        /// <value>Vencimento da primeira parcela.</value>
        [DataMember(Name="vencimentoPrimeiraParcela", EmitDefaultValue=false)]
        public int? VencimentoPrimeiraParcela { get; set; }
    
        /// <summary>
        /// Dias afastamento.
        /// </summary>
        /// <value>Dias afastamento.</value>
        [DataMember(Name="diasAfastamento", EmitDefaultValue=false)]
        public int? DiasAfastamento { get; set; }
    
        /// <summary>
        /// Flag taxa fixada.
        /// </summary>
        /// <value>Flag taxa fixada.</value>
        [DataMember(Name="flagTaxaFixada", EmitDefaultValue=false)]
        public bool? FlagTaxaFixada { get; set; }
    
        /// <summary>
        /// Plano m\u00C3\u00ADnimo da regra.
        /// </summary>
        /// <value>Plano m\u00C3\u00ADnimo da regra.</value>
        [DataMember(Name="planoMinimo", EmitDefaultValue=false)]
        public int? PlanoMinimo { get; set; }
    
        /// <summary>
        /// Plano m\u00C3\u00A1ximo da regra.
        /// </summary>
        /// <value>Plano m\u00C3\u00A1ximo da regra.</value>
        [DataMember(Name="planoMaximo", EmitDefaultValue=false)]
        public int? PlanoMaximo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperacaoCredorUpdate {\n");
            sb.Append("  IdOperacao: ").Append(IdOperacao).Append("\n");
            sb.Append("  IdCredor: ").Append(IdCredor).Append("\n");
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
            return this.Equals(obj as OperacaoCredorUpdate);
        }

        /// <summary>
        /// Returns true if OperacaoCredorUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of OperacaoCredorUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperacaoCredorUpdate other)
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
                    this.IdCredor == other.IdCredor ||
                    this.IdCredor != null &&
                    this.IdCredor.Equals(other.IdCredor)
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
                
                if (this.IdOperacao != null)
                    hash = hash * 59 + this.IdOperacao.GetHashCode();
                
                if (this.IdCredor != null)
                    hash = hash * 59 + this.IdCredor.GetHashCode();
                
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
