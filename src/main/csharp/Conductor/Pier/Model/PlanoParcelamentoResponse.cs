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
    /// Response Representa??o of the installment plan resource
    /// </summary>
    [DataContract]
    public partial class PlanoParcelamentoResponse :  IEquatable<PlanoParcelamentoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanoParcelamentoResponse" /> class.
        /// Initializes a new instance of the <see cref="PlanoParcelamentoResponse" />class.
        /// </summary>
        /// <param name="Id">Identifier of the Installment.</param>
        /// <param name="DataFechamentoFatura">date of the Closing invoice.</param>
        /// <param name="DataVencimentoPadrao">Standard Expiration Date.</param>
        /// <param name="ValorTotalFatura">Total value of the invoice.</param>
        /// <param name="QuantidadeParcelas">Quantity of parcels.</param>
        /// <param name="ValorParcela">Parcel Value.</param>
        /// <param name="ValorEntrada">entrance value.</param>
        /// <param name="TaxaRefinanciamento">Refinancing Taxes.</param>
        /// <param name="CustoEfetivoTotal">Total acquisition cost.</param>
        /// <param name="ValorTotalRefinanciamento">Total value of the refinancing.</param>
        /// <param name="ValorIOF">Value of the IOF.</param>
        /// <param name="ValorTAC">TAC value.</param>
        /// <param name="StatusAdesao">Status of the Accession.</param>
        /// <param name="DataInclusao">Inclusion date.</param>
        /// <param name="DataProcessamentoAdesao">Processing date of the Accession.</param>
        /// <param name="IdConta">Identifier of the Account.</param>
        /// <param name="IdServicoTipo">Identification Code of the Service type.</param>
        /// <param name="DescricaoServicoTipo">Description of the service type.</param>
        /// <param name="ComEntrada">Indicate if the invoice was with an entrance.</param>
        /// <param name="NomeCampanha">Campaign Name.</param>

        public PlanoParcelamentoResponse(long? Id = null, string DataFechamentoFatura = null, string DataVencimentoPadrao = null, double? ValorTotalFatura = null, int? QuantidadeParcelas = null, double? ValorParcela = null, double? ValorEntrada = null, double? TaxaRefinanciamento = null, double? CustoEfetivoTotal = null, double? ValorTotalRefinanciamento = null, double? ValorIOF = null, double? ValorTAC = null, int? StatusAdesao = null, string DataInclusao = null, string DataProcessamentoAdesao = null, long? IdConta = null, long? IdServicoTipo = null, string DescricaoServicoTipo = null, bool? ComEntrada = null, string NomeCampanha = null)
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
            this.IdServicoTipo = IdServicoTipo;
            this.DescricaoServicoTipo = DescricaoServicoTipo;
            this.ComEntrada = ComEntrada;
            this.NomeCampanha = NomeCampanha;
            
        }
        
    
        /// <summary>
        /// Identifier of the Installment
        /// </summary>
        /// <value>Identifier of the Installment</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// date of the Closing invoice
        /// </summary>
        /// <value>date of the Closing invoice</value>
        [DataMember(Name="dataFechamentoFatura", EmitDefaultValue=false)]
        public string DataFechamentoFatura { get; set; }
    
        /// <summary>
        /// Standard Expiration Date
        /// </summary>
        /// <value>Standard Expiration Date</value>
        [DataMember(Name="dataVencimentoPadrao", EmitDefaultValue=false)]
        public string DataVencimentoPadrao { get; set; }
    
        /// <summary>
        /// Total value of the invoice
        /// </summary>
        /// <value>Total value of the invoice</value>
        [DataMember(Name="valorTotalFatura", EmitDefaultValue=false)]
        public double? ValorTotalFatura { get; set; }
    
        /// <summary>
        /// Quantity of parcels
        /// </summary>
        /// <value>Quantity of parcels</value>
        [DataMember(Name="quantidadeParcelas", EmitDefaultValue=false)]
        public int? QuantidadeParcelas { get; set; }
    
        /// <summary>
        /// Parcel Value
        /// </summary>
        /// <value>Parcel Value</value>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public double? ValorParcela { get; set; }
    
        /// <summary>
        /// entrance value
        /// </summary>
        /// <value>entrance value</value>
        [DataMember(Name="valorEntrada", EmitDefaultValue=false)]
        public double? ValorEntrada { get; set; }
    
        /// <summary>
        /// Refinancing Taxes
        /// </summary>
        /// <value>Refinancing Taxes</value>
        [DataMember(Name="taxaRefinanciamento", EmitDefaultValue=false)]
        public double? TaxaRefinanciamento { get; set; }
    
        /// <summary>
        /// Total acquisition cost
        /// </summary>
        /// <value>Total acquisition cost</value>
        [DataMember(Name="custoEfetivoTotal", EmitDefaultValue=false)]
        public double? CustoEfetivoTotal { get; set; }
    
        /// <summary>
        /// Total value of the refinancing
        /// </summary>
        /// <value>Total value of the refinancing</value>
        [DataMember(Name="valorTotalRefinanciamento", EmitDefaultValue=false)]
        public double? ValorTotalRefinanciamento { get; set; }
    
        /// <summary>
        /// Value of the IOF
        /// </summary>
        /// <value>Value of the IOF</value>
        [DataMember(Name="valorIOF", EmitDefaultValue=false)]
        public double? ValorIOF { get; set; }
    
        /// <summary>
        /// TAC value
        /// </summary>
        /// <value>TAC value</value>
        [DataMember(Name="valorTAC", EmitDefaultValue=false)]
        public double? ValorTAC { get; set; }
    
        /// <summary>
        /// Status of the Accession
        /// </summary>
        /// <value>Status of the Accession</value>
        [DataMember(Name="statusAdesao", EmitDefaultValue=false)]
        public int? StatusAdesao { get; set; }
    
        /// <summary>
        /// Inclusion date
        /// </summary>
        /// <value>Inclusion date</value>
        [DataMember(Name="dataInclusao", EmitDefaultValue=false)]
        public string DataInclusao { get; set; }
    
        /// <summary>
        /// Processing date of the Accession
        /// </summary>
        /// <value>Processing date of the Accession</value>
        [DataMember(Name="dataProcessamentoAdesao", EmitDefaultValue=false)]
        public string DataProcessamentoAdesao { get; set; }
    
        /// <summary>
        /// Identifier of the Account
        /// </summary>
        /// <value>Identifier of the Account</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identification Code of the Service type
        /// </summary>
        /// <value>Identification Code of the Service type</value>
        [DataMember(Name="idServicoTipo", EmitDefaultValue=false)]
        public long? IdServicoTipo { get; set; }
    
        /// <summary>
        /// Description of the service type
        /// </summary>
        /// <value>Description of the service type</value>
        [DataMember(Name="descricaoServicoTipo", EmitDefaultValue=false)]
        public string DescricaoServicoTipo { get; set; }
    
        /// <summary>
        /// Indicate if the invoice was with an entrance
        /// </summary>
        /// <value>Indicate if the invoice was with an entrance</value>
        [DataMember(Name="comEntrada", EmitDefaultValue=false)]
        public bool? ComEntrada { get; set; }
    
        /// <summary>
        /// Campaign Name
        /// </summary>
        /// <value>Campaign Name</value>
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
            sb.Append("  IdServicoTipo: ").Append(IdServicoTipo).Append("\n");
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
                    this.IdServicoTipo == other.IdServicoTipo ||
                    this.IdServicoTipo != null &&
                    this.IdServicoTipo.Equals(other.IdServicoTipo)
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
                
                if (this.IdServicoTipo != null)
                    hash = hash * 59 + this.IdServicoTipo.GetHashCode();
                
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
