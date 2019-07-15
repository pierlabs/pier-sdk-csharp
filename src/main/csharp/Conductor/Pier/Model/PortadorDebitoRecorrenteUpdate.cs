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
    /// Representa\u00E7\u00E3o da atualiza\u00E7\u00E3o do d\u00E9bito recorrente do portador
    /// </summary>
    [DataContract]
    public partial class PortadorDebitoRecorrenteUpdate :  IEquatable<PortadorDebitoRecorrenteUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PortadorDebitoRecorrenteUpdate" /> class.
        /// Initializes a new instance of the <see cref="PortadorDebitoRecorrenteUpdate" />class.
        /// </summary>
        /// <param name="Portador">N\u00FAmero referente ao portador.</param>
        /// <param name="IdProduto">C\u00F3digo identificador do produto.</param>
        /// <param name="IdAnuidade">C\u00F3digo identificador da anuidade inv\u00E1lido.</param>
        /// <param name="DataHoraInicio">Data e hora do in\u00EDcio da recorr\u00EAncia do d\u00E9bito.</param>
        /// <param name="DataHoraFim">Data e hora do fim da recorr\u00EAncia do d\u00E9bito.</param>
        /// <param name="NumeroParcela">N\u00FAmero de parcelas recorrentes.</param>
        /// <param name="ParcelaPerdida">N\u00FAmero de parcelas j\u00E1 pedidas.</param>
        /// <param name="ValorParcela">Valor da parcela com aplica\u00E7\u00E3o da parcela de desconto.</param>
        /// <param name="ValorOriginal">Valor total sem a aplica\u00E7\u00E3o da porcentagem de desconto.</param>
        /// <param name="PercentualDesconto">Percentual de desconto de cada parcela.</param>
        /// <param name="FlagCartaoDesbloqueado">Falg para identifica\u00E7\u00E3o de cart\u00E3o desbloqueado.</param>
        /// <param name="FlagLancatarifa">Falg para identifica\u00E7\u00E3o de lan\u00E7amento de tarifa.</param>
        /// <param name="DataFimDescontoAnuidade">Data referente ao final do desconto da anuidade.</param>

        public PortadorDebitoRecorrenteUpdate(int? Portador = null, long? IdProduto = null, long? IdAnuidade = null, string DataHoraInicio = null, string DataHoraFim = null, int? NumeroParcela = null, int? ParcelaPerdida = null, double? ValorParcela = null, double? ValorOriginal = null, double? PercentualDesconto = null, bool? FlagCartaoDesbloqueado = null, bool? FlagLancatarifa = null, string DataFimDescontoAnuidade = null)
        {
            this.Portador = Portador;
            this.IdProduto = IdProduto;
            this.IdAnuidade = IdAnuidade;
            this.DataHoraInicio = DataHoraInicio;
            this.DataHoraFim = DataHoraFim;
            this.NumeroParcela = NumeroParcela;
            this.ParcelaPerdida = ParcelaPerdida;
            this.ValorParcela = ValorParcela;
            this.ValorOriginal = ValorOriginal;
            this.PercentualDesconto = PercentualDesconto;
            this.FlagCartaoDesbloqueado = FlagCartaoDesbloqueado;
            this.FlagLancatarifa = FlagLancatarifa;
            this.DataFimDescontoAnuidade = DataFimDescontoAnuidade;
            
        }
        
    
        /// <summary>
        /// N\u00FAmero referente ao portador
        /// </summary>
        /// <value>N\u00FAmero referente ao portador</value>
        [DataMember(Name="portador", EmitDefaultValue=false)]
        public int? Portador { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do produto
        /// </summary>
        /// <value>C\u00F3digo identificador do produto</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da anuidade inv\u00E1lido
        /// </summary>
        /// <value>C\u00F3digo identificador da anuidade inv\u00E1lido</value>
        [DataMember(Name="idAnuidade", EmitDefaultValue=false)]
        public long? IdAnuidade { get; set; }
    
        /// <summary>
        /// Data e hora do in\u00EDcio da recorr\u00EAncia do d\u00E9bito
        /// </summary>
        /// <value>Data e hora do in\u00EDcio da recorr\u00EAncia do d\u00E9bito</value>
        [DataMember(Name="dataHoraInicio", EmitDefaultValue=false)]
        public string DataHoraInicio { get; set; }
    
        /// <summary>
        /// Data e hora do fim da recorr\u00EAncia do d\u00E9bito
        /// </summary>
        /// <value>Data e hora do fim da recorr\u00EAncia do d\u00E9bito</value>
        [DataMember(Name="dataHoraFim", EmitDefaultValue=false)]
        public string DataHoraFim { get; set; }
    
        /// <summary>
        /// N\u00FAmero de parcelas recorrentes
        /// </summary>
        /// <value>N\u00FAmero de parcelas recorrentes</value>
        [DataMember(Name="numeroParcela", EmitDefaultValue=false)]
        public int? NumeroParcela { get; set; }
    
        /// <summary>
        /// N\u00FAmero de parcelas j\u00E1 pedidas
        /// </summary>
        /// <value>N\u00FAmero de parcelas j\u00E1 pedidas</value>
        [DataMember(Name="parcelaPerdida", EmitDefaultValue=false)]
        public int? ParcelaPerdida { get; set; }
    
        /// <summary>
        /// Valor da parcela com aplica\u00E7\u00E3o da parcela de desconto
        /// </summary>
        /// <value>Valor da parcela com aplica\u00E7\u00E3o da parcela de desconto</value>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public double? ValorParcela { get; set; }
    
        /// <summary>
        /// Valor total sem a aplica\u00E7\u00E3o da porcentagem de desconto
        /// </summary>
        /// <value>Valor total sem a aplica\u00E7\u00E3o da porcentagem de desconto</value>
        [DataMember(Name="valorOriginal", EmitDefaultValue=false)]
        public double? ValorOriginal { get; set; }
    
        /// <summary>
        /// Percentual de desconto de cada parcela
        /// </summary>
        /// <value>Percentual de desconto de cada parcela</value>
        [DataMember(Name="percentualDesconto", EmitDefaultValue=false)]
        public double? PercentualDesconto { get; set; }
    
        /// <summary>
        /// Falg para identifica\u00E7\u00E3o de cart\u00E3o desbloqueado
        /// </summary>
        /// <value>Falg para identifica\u00E7\u00E3o de cart\u00E3o desbloqueado</value>
        [DataMember(Name="flagCartaoDesbloqueado", EmitDefaultValue=false)]
        public bool? FlagCartaoDesbloqueado { get; set; }
    
        /// <summary>
        /// Falg para identifica\u00E7\u00E3o de lan\u00E7amento de tarifa
        /// </summary>
        /// <value>Falg para identifica\u00E7\u00E3o de lan\u00E7amento de tarifa</value>
        [DataMember(Name="flagLancatarifa", EmitDefaultValue=false)]
        public bool? FlagLancatarifa { get; set; }
    
        /// <summary>
        /// Data referente ao final do desconto da anuidade
        /// </summary>
        /// <value>Data referente ao final do desconto da anuidade</value>
        [DataMember(Name="dataFimDescontoAnuidade", EmitDefaultValue=false)]
        public string DataFimDescontoAnuidade { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortadorDebitoRecorrenteUpdate {\n");
            sb.Append("  Portador: ").Append(Portador).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdAnuidade: ").Append(IdAnuidade).Append("\n");
            sb.Append("  DataHoraInicio: ").Append(DataHoraInicio).Append("\n");
            sb.Append("  DataHoraFim: ").Append(DataHoraFim).Append("\n");
            sb.Append("  NumeroParcela: ").Append(NumeroParcela).Append("\n");
            sb.Append("  ParcelaPerdida: ").Append(ParcelaPerdida).Append("\n");
            sb.Append("  ValorParcela: ").Append(ValorParcela).Append("\n");
            sb.Append("  ValorOriginal: ").Append(ValorOriginal).Append("\n");
            sb.Append("  PercentualDesconto: ").Append(PercentualDesconto).Append("\n");
            sb.Append("  FlagCartaoDesbloqueado: ").Append(FlagCartaoDesbloqueado).Append("\n");
            sb.Append("  FlagLancatarifa: ").Append(FlagLancatarifa).Append("\n");
            sb.Append("  DataFimDescontoAnuidade: ").Append(DataFimDescontoAnuidade).Append("\n");
            
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
            return this.Equals(obj as PortadorDebitoRecorrenteUpdate);
        }

        /// <summary>
        /// Returns true if PortadorDebitoRecorrenteUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of PortadorDebitoRecorrenteUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortadorDebitoRecorrenteUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Portador == other.Portador ||
                    this.Portador != null &&
                    this.Portador.Equals(other.Portador)
                ) && 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.IdAnuidade == other.IdAnuidade ||
                    this.IdAnuidade != null &&
                    this.IdAnuidade.Equals(other.IdAnuidade)
                ) && 
                (
                    this.DataHoraInicio == other.DataHoraInicio ||
                    this.DataHoraInicio != null &&
                    this.DataHoraInicio.Equals(other.DataHoraInicio)
                ) && 
                (
                    this.DataHoraFim == other.DataHoraFim ||
                    this.DataHoraFim != null &&
                    this.DataHoraFim.Equals(other.DataHoraFim)
                ) && 
                (
                    this.NumeroParcela == other.NumeroParcela ||
                    this.NumeroParcela != null &&
                    this.NumeroParcela.Equals(other.NumeroParcela)
                ) && 
                (
                    this.ParcelaPerdida == other.ParcelaPerdida ||
                    this.ParcelaPerdida != null &&
                    this.ParcelaPerdida.Equals(other.ParcelaPerdida)
                ) && 
                (
                    this.ValorParcela == other.ValorParcela ||
                    this.ValorParcela != null &&
                    this.ValorParcela.Equals(other.ValorParcela)
                ) && 
                (
                    this.ValorOriginal == other.ValorOriginal ||
                    this.ValorOriginal != null &&
                    this.ValorOriginal.Equals(other.ValorOriginal)
                ) && 
                (
                    this.PercentualDesconto == other.PercentualDesconto ||
                    this.PercentualDesconto != null &&
                    this.PercentualDesconto.Equals(other.PercentualDesconto)
                ) && 
                (
                    this.FlagCartaoDesbloqueado == other.FlagCartaoDesbloqueado ||
                    this.FlagCartaoDesbloqueado != null &&
                    this.FlagCartaoDesbloqueado.Equals(other.FlagCartaoDesbloqueado)
                ) && 
                (
                    this.FlagLancatarifa == other.FlagLancatarifa ||
                    this.FlagLancatarifa != null &&
                    this.FlagLancatarifa.Equals(other.FlagLancatarifa)
                ) && 
                (
                    this.DataFimDescontoAnuidade == other.DataFimDescontoAnuidade ||
                    this.DataFimDescontoAnuidade != null &&
                    this.DataFimDescontoAnuidade.Equals(other.DataFimDescontoAnuidade)
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
                
                if (this.Portador != null)
                    hash = hash * 59 + this.Portador.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.IdAnuidade != null)
                    hash = hash * 59 + this.IdAnuidade.GetHashCode();
                
                if (this.DataHoraInicio != null)
                    hash = hash * 59 + this.DataHoraInicio.GetHashCode();
                
                if (this.DataHoraFim != null)
                    hash = hash * 59 + this.DataHoraFim.GetHashCode();
                
                if (this.NumeroParcela != null)
                    hash = hash * 59 + this.NumeroParcela.GetHashCode();
                
                if (this.ParcelaPerdida != null)
                    hash = hash * 59 + this.ParcelaPerdida.GetHashCode();
                
                if (this.ValorParcela != null)
                    hash = hash * 59 + this.ValorParcela.GetHashCode();
                
                if (this.ValorOriginal != null)
                    hash = hash * 59 + this.ValorOriginal.GetHashCode();
                
                if (this.PercentualDesconto != null)
                    hash = hash * 59 + this.PercentualDesconto.GetHashCode();
                
                if (this.FlagCartaoDesbloqueado != null)
                    hash = hash * 59 + this.FlagCartaoDesbloqueado.GetHashCode();
                
                if (this.FlagLancatarifa != null)
                    hash = hash * 59 + this.FlagLancatarifa.GetHashCode();
                
                if (this.DataFimDescontoAnuidade != null)
                    hash = hash * 59 + this.DataFimDescontoAnuidade.GetHashCode();
                
                return hash;
            }
        }

    }
}
