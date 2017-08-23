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
    /// Representa\u00C3\u00A7\u00C3\u00A3o da resposta do recurso de planos de parcelamento
    /// </summary>
    [DataContract]
    public partial class PlanoParcelamentoResponse :  IEquatable<PlanoParcelamentoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanoParcelamentoResponse" /> class.
        /// Initializes a new instance of the <see cref="PlanoParcelamentoResponse" />class.
        /// </summary>
        /// <param name="Id">Identificador do parcelamento.</param>
        /// <param name="DataFechamentoFatura">Data de fechamento da fatura.</param>
        /// <param name="DataVencimentoPadrao">Data de vencimento padr\u00C3\u00A3o.</param>
        /// <param name="ValorTotalFatura">Valor total da fatura.</param>
        /// <param name="QuantidadeParcelas">Quantidade de parcelas.</param>
        /// <param name="ValorParcela">Valor da parcela.</param>
        /// <param name="ValorEntrada">Valor de entrada.</param>
        /// <param name="TaxaRefinanciamento">Taxa de refinanciamento.</param>
        /// <param name="CustoEfetivoTotal">Custo efetivo total.</param>
        /// <param name="ValorTotalRefinanciamento">Valor total de refinanciamento.</param>
        /// <param name="ValorIOF">Valor do IOF.</param>
        /// <param name="ValorTAC">Valor do TAC.</param>
        /// <param name="StatusAdesao">Status da ades\u00C3\u00A3o.</param>
        /// <param name="DataInclusao">Data de inclus\u00C3\u00A3o.</param>
        /// <param name="DataProcessamentoAdesao">Data de processamento da ades\u00C3\u00A3o.</param>
        /// <param name="IdConta">Identificador da conta.</param>
        /// <param name="DescricaoServicoTipo">Descri\u00C3\u00A7\u00C3\u00A3o do tipo de servi\u00C3\u00A7o.</param>
        /// <param name="ComEntrada">Indica se a fatura foi com entrada.</param>
        /// <param name="NomeCampanha">Nome da campanha.</param>

        public PlanoParcelamentoResponse(long? Id = null, string DataFechamentoFatura = null, string DataVencimentoPadrao = null, double? ValorTotalFatura = null, int? QuantidadeParcelas = null, double? ValorParcela = null, double? ValorEntrada = null, double? TaxaRefinanciamento = null, double? CustoEfetivoTotal = null, double? ValorTotalRefinanciamento = null, double? ValorIOF = null, double? ValorTAC = null, int? StatusAdesao = null, string DataInclusao = null, string DataProcessamentoAdesao = null, long? IdConta = null, string DescricaoServicoTipo = null, bool? ComEntrada = null, string NomeCampanha = null)
        {
            this.Id = Id;
            this.DataFechamentoFatura = DataFechamentoFatura;
            this.DataVencimentoPadrao = DataVencimentoPadrao;
            this.ValorTotalFatura = ValorTotalFatura;
            this.QuantidadeParcelas = QuantidadeParcelas;
            this.ValorParcela = ValorParcela;
            this.ValorEntrada = ValorEntrada;
            this.TaxaRefinanciamento = TaxaRefinanciamento;
            this.CustoEfetivoTotal = CustoEfetivoTotal;
            this.ValorTotalRefinanciamento = ValorTotalRefinanciamento;
            this.ValorIOF = ValorIOF;
            this.ValorTAC = ValorTAC;
            this.StatusAdesao = StatusAdesao;
            this.DataInclusao = DataInclusao;
            this.DataProcessamentoAdesao = DataProcessamentoAdesao;
            this.IdConta = IdConta;
            this.DescricaoServicoTipo = DescricaoServicoTipo;
            this.ComEntrada = ComEntrada;
            this.NomeCampanha = NomeCampanha;
            
        }
        
    
        /// <summary>
        /// Identificador do parcelamento
        /// </summary>
        /// <value>Identificador do parcelamento</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Data de fechamento da fatura
        /// </summary>
        /// <value>Data de fechamento da fatura</value>
        [DataMember(Name="dataFechamentoFatura", EmitDefaultValue=false)]
        public string DataFechamentoFatura { get; set; }
    
        /// <summary>
        /// Data de vencimento padr\u00C3\u00A3o
        /// </summary>
        /// <value>Data de vencimento padr\u00C3\u00A3o</value>
        [DataMember(Name="dataVencimentoPadrao", EmitDefaultValue=false)]
        public string DataVencimentoPadrao { get; set; }
    
        /// <summary>
        /// Valor total da fatura
        /// </summary>
        /// <value>Valor total da fatura</value>
        [DataMember(Name="valorTotalFatura", EmitDefaultValue=false)]
        public double? ValorTotalFatura { get; set; }
    
        /// <summary>
        /// Quantidade de parcelas
        /// </summary>
        /// <value>Quantidade de parcelas</value>
        [DataMember(Name="quantidadeParcelas", EmitDefaultValue=false)]
        public int? QuantidadeParcelas { get; set; }
    
        /// <summary>
        /// Valor da parcela
        /// </summary>
        /// <value>Valor da parcela</value>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public double? ValorParcela { get; set; }
    
        /// <summary>
        /// Valor de entrada
        /// </summary>
        /// <value>Valor de entrada</value>
        [DataMember(Name="valorEntrada", EmitDefaultValue=false)]
        public double? ValorEntrada { get; set; }
    
        /// <summary>
        /// Taxa de refinanciamento
        /// </summary>
        /// <value>Taxa de refinanciamento</value>
        [DataMember(Name="taxaRefinanciamento", EmitDefaultValue=false)]
        public double? TaxaRefinanciamento { get; set; }
    
        /// <summary>
        /// Custo efetivo total
        /// </summary>
        /// <value>Custo efetivo total</value>
        [DataMember(Name="custoEfetivoTotal", EmitDefaultValue=false)]
        public double? CustoEfetivoTotal { get; set; }
    
        /// <summary>
        /// Valor total de refinanciamento
        /// </summary>
        /// <value>Valor total de refinanciamento</value>
        [DataMember(Name="valorTotalRefinanciamento", EmitDefaultValue=false)]
        public double? ValorTotalRefinanciamento { get; set; }
    
        /// <summary>
        /// Valor do IOF
        /// </summary>
        /// <value>Valor do IOF</value>
        [DataMember(Name="valorIOF", EmitDefaultValue=false)]
        public double? ValorIOF { get; set; }
    
        /// <summary>
        /// Valor do TAC
        /// </summary>
        /// <value>Valor do TAC</value>
        [DataMember(Name="valorTAC", EmitDefaultValue=false)]
        public double? ValorTAC { get; set; }
    
        /// <summary>
        /// Status da ades\u00C3\u00A3o
        /// </summary>
        /// <value>Status da ades\u00C3\u00A3o</value>
        [DataMember(Name="statusAdesao", EmitDefaultValue=false)]
        public int? StatusAdesao { get; set; }
    
        /// <summary>
        /// Data de inclus\u00C3\u00A3o
        /// </summary>
        /// <value>Data de inclus\u00C3\u00A3o</value>
        [DataMember(Name="dataInclusao", EmitDefaultValue=false)]
        public string DataInclusao { get; set; }
    
        /// <summary>
        /// Data de processamento da ades\u00C3\u00A3o
        /// </summary>
        /// <value>Data de processamento da ades\u00C3\u00A3o</value>
        [DataMember(Name="dataProcessamentoAdesao", EmitDefaultValue=false)]
        public string DataProcessamentoAdesao { get; set; }
    
        /// <summary>
        /// Identificador da conta
        /// </summary>
        /// <value>Identificador da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o do tipo de servi\u00C3\u00A7o
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o do tipo de servi\u00C3\u00A7o</value>
        [DataMember(Name="descricaoServicoTipo", EmitDefaultValue=false)]
        public string DescricaoServicoTipo { get; set; }
    
        /// <summary>
        /// Indica se a fatura foi com entrada
        /// </summary>
        /// <value>Indica se a fatura foi com entrada</value>
        [DataMember(Name="comEntrada", EmitDefaultValue=false)]
        public bool? ComEntrada { get; set; }
    
        /// <summary>
        /// Nome da campanha
        /// </summary>
        /// <value>Nome da campanha</value>
        [DataMember(Name="nomeCampanha", EmitDefaultValue=false)]
        public string NomeCampanha { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlanoParcelamentoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DataFechamentoFatura: ").Append(DataFechamentoFatura).Append("\n");
            sb.Append("  DataVencimentoPadrao: ").Append(DataVencimentoPadrao).Append("\n");
            sb.Append("  ValorTotalFatura: ").Append(ValorTotalFatura).Append("\n");
            sb.Append("  QuantidadeParcelas: ").Append(QuantidadeParcelas).Append("\n");
            sb.Append("  ValorParcela: ").Append(ValorParcela).Append("\n");
            sb.Append("  ValorEntrada: ").Append(ValorEntrada).Append("\n");
            sb.Append("  TaxaRefinanciamento: ").Append(TaxaRefinanciamento).Append("\n");
            sb.Append("  CustoEfetivoTotal: ").Append(CustoEfetivoTotal).Append("\n");
            sb.Append("  ValorTotalRefinanciamento: ").Append(ValorTotalRefinanciamento).Append("\n");
            sb.Append("  ValorIOF: ").Append(ValorIOF).Append("\n");
            sb.Append("  ValorTAC: ").Append(ValorTAC).Append("\n");
            sb.Append("  StatusAdesao: ").Append(StatusAdesao).Append("\n");
            sb.Append("  DataInclusao: ").Append(DataInclusao).Append("\n");
            sb.Append("  DataProcessamentoAdesao: ").Append(DataProcessamentoAdesao).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  DescricaoServicoTipo: ").Append(DescricaoServicoTipo).Append("\n");
            sb.Append("  ComEntrada: ").Append(ComEntrada).Append("\n");
            sb.Append("  NomeCampanha: ").Append(NomeCampanha).Append("\n");
            
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
            return this.Equals(obj as PlanoParcelamentoResponse);
        }

        /// <summary>
        /// Returns true if PlanoParcelamentoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PlanoParcelamentoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanoParcelamentoResponse other)
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
                    this.DataFechamentoFatura == other.DataFechamentoFatura ||
                    this.DataFechamentoFatura != null &&
                    this.DataFechamentoFatura.Equals(other.DataFechamentoFatura)
                ) && 
                (
                    this.DataVencimentoPadrao == other.DataVencimentoPadrao ||
                    this.DataVencimentoPadrao != null &&
                    this.DataVencimentoPadrao.Equals(other.DataVencimentoPadrao)
                ) && 
                (
                    this.ValorTotalFatura == other.ValorTotalFatura ||
                    this.ValorTotalFatura != null &&
                    this.ValorTotalFatura.Equals(other.ValorTotalFatura)
                ) && 
                (
                    this.QuantidadeParcelas == other.QuantidadeParcelas ||
                    this.QuantidadeParcelas != null &&
                    this.QuantidadeParcelas.Equals(other.QuantidadeParcelas)
                ) && 
                (
                    this.ValorParcela == other.ValorParcela ||
                    this.ValorParcela != null &&
                    this.ValorParcela.Equals(other.ValorParcela)
                ) && 
                (
                    this.ValorEntrada == other.ValorEntrada ||
                    this.ValorEntrada != null &&
                    this.ValorEntrada.Equals(other.ValorEntrada)
                ) && 
                (
                    this.TaxaRefinanciamento == other.TaxaRefinanciamento ||
                    this.TaxaRefinanciamento != null &&
                    this.TaxaRefinanciamento.Equals(other.TaxaRefinanciamento)
                ) && 
                (
                    this.CustoEfetivoTotal == other.CustoEfetivoTotal ||
                    this.CustoEfetivoTotal != null &&
                    this.CustoEfetivoTotal.Equals(other.CustoEfetivoTotal)
                ) && 
                (
                    this.ValorTotalRefinanciamento == other.ValorTotalRefinanciamento ||
                    this.ValorTotalRefinanciamento != null &&
                    this.ValorTotalRefinanciamento.Equals(other.ValorTotalRefinanciamento)
                ) && 
                (
                    this.ValorIOF == other.ValorIOF ||
                    this.ValorIOF != null &&
                    this.ValorIOF.Equals(other.ValorIOF)
                ) && 
                (
                    this.ValorTAC == other.ValorTAC ||
                    this.ValorTAC != null &&
                    this.ValorTAC.Equals(other.ValorTAC)
                ) && 
                (
                    this.StatusAdesao == other.StatusAdesao ||
                    this.StatusAdesao != null &&
                    this.StatusAdesao.Equals(other.StatusAdesao)
                ) && 
                (
                    this.DataInclusao == other.DataInclusao ||
                    this.DataInclusao != null &&
                    this.DataInclusao.Equals(other.DataInclusao)
                ) && 
                (
                    this.DataProcessamentoAdesao == other.DataProcessamentoAdesao ||
                    this.DataProcessamentoAdesao != null &&
                    this.DataProcessamentoAdesao.Equals(other.DataProcessamentoAdesao)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.DescricaoServicoTipo == other.DescricaoServicoTipo ||
                    this.DescricaoServicoTipo != null &&
                    this.DescricaoServicoTipo.Equals(other.DescricaoServicoTipo)
                ) && 
                (
                    this.ComEntrada == other.ComEntrada ||
                    this.ComEntrada != null &&
                    this.ComEntrada.Equals(other.ComEntrada)
                ) && 
                (
                    this.NomeCampanha == other.NomeCampanha ||
                    this.NomeCampanha != null &&
                    this.NomeCampanha.Equals(other.NomeCampanha)
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
                
                if (this.DataFechamentoFatura != null)
                    hash = hash * 59 + this.DataFechamentoFatura.GetHashCode();
                
                if (this.DataVencimentoPadrao != null)
                    hash = hash * 59 + this.DataVencimentoPadrao.GetHashCode();
                
                if (this.ValorTotalFatura != null)
                    hash = hash * 59 + this.ValorTotalFatura.GetHashCode();
                
                if (this.QuantidadeParcelas != null)
                    hash = hash * 59 + this.QuantidadeParcelas.GetHashCode();
                
                if (this.ValorParcela != null)
                    hash = hash * 59 + this.ValorParcela.GetHashCode();
                
                if (this.ValorEntrada != null)
                    hash = hash * 59 + this.ValorEntrada.GetHashCode();
                
                if (this.TaxaRefinanciamento != null)
                    hash = hash * 59 + this.TaxaRefinanciamento.GetHashCode();
                
                if (this.CustoEfetivoTotal != null)
                    hash = hash * 59 + this.CustoEfetivoTotal.GetHashCode();
                
                if (this.ValorTotalRefinanciamento != null)
                    hash = hash * 59 + this.ValorTotalRefinanciamento.GetHashCode();
                
                if (this.ValorIOF != null)
                    hash = hash * 59 + this.ValorIOF.GetHashCode();
                
                if (this.ValorTAC != null)
                    hash = hash * 59 + this.ValorTAC.GetHashCode();
                
                if (this.StatusAdesao != null)
                    hash = hash * 59 + this.StatusAdesao.GetHashCode();
                
                if (this.DataInclusao != null)
                    hash = hash * 59 + this.DataInclusao.GetHashCode();
                
                if (this.DataProcessamentoAdesao != null)
                    hash = hash * 59 + this.DataProcessamentoAdesao.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.DescricaoServicoTipo != null)
                    hash = hash * 59 + this.DescricaoServicoTipo.GetHashCode();
                
                if (this.ComEntrada != null)
                    hash = hash * 59 + this.ComEntrada.GetHashCode();
                
                if (this.NomeCampanha != null)
                    hash = hash * 59 + this.NomeCampanha.GetHashCode();
                
                return hash;
            }
        }

    }
}
