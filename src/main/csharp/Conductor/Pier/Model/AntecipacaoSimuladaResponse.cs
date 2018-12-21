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
    /// Response Representation of the Simulated Antecipation resource
    /// </summary>
    [DataContract]
    public partial class AntecipacaoSimuladaResponse :  IEquatable<AntecipacaoSimuladaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AntecipacaoSimuladaResponse" /> class.
        /// Initializes a new instance of the <see cref="AntecipacaoSimuladaResponse" />class.
        /// </summary>
        /// <param name="Mcc">Mcc.</param>
        /// <param name="Uf">Uf.</param>
        /// <param name="IdAntecipacaoSimulada">Identifier Code of the simulation of antecipation.</param>
        /// <param name="IdConta">Identifier Code of the Account.</param>
        /// <param name="IdCompra">Identifier Code of the shop event.</param>
        /// <param name="IdTipoTransacao">Identifier Code of type of the shop event.</param>
        /// <param name="QuantidadeParcelasAntecipaveis">Quantity of the antecipated parcels.</param>
        /// <param name="ValorParcela">Value of the parcel.</param>
        /// <param name="DataHoraSimulacao">Date and time which the simulation was made.</param>
        /// <param name="TaxaAntecipacaoAno">Taxe of the antecipation applied (to the year).</param>
        /// <param name="NomeEstabelecimento">Establishment where the transaction was made.</param>
        /// <param name="Status">Description of status of the shop authorization.</param>
        /// <param name="DataCompra">Date of the shop.</param>
        /// <param name="TipoOrigemTransacao">Transaction type of the shop.</param>
        /// <param name="Cidade">City where the shop was made.</param>
        /// <param name="Pais">Country where the shop was made.</param>
        /// <param name="Latitude">Latitudinal Coordinate of location of the shop.</param>
        /// <param name="Longitude">Longitudinal Coordinate of the shop location.</param>
        /// <param name="IdGrupoMCC">Identification Code of the MCC group of the shop.</param>
        /// <param name="DescricaoGrupoMCC">Description of the Group MCC of the shop.</param>
        /// <param name="IdProduto">Identification Code of the shop product.</param>
        /// <param name="DescricaoProduto">Description of the shop product.</param>
        /// <param name="DescricaoEstabelecimento">Description of the establishment of the shop.</param>
        /// <param name="NomeFantasiaEstabelecimento">Fantasy name of the Establishment.</param>
        /// <param name="Detalhes">Details of the simulation.</param>

        public AntecipacaoSimuladaResponse(long? Mcc = null, string Uf = null, long? IdAntecipacaoSimulada = null, long? IdConta = null, long? IdCompra = null, long? IdTipoTransacao = null, int? QuantidadeParcelasAntecipaveis = null, double? ValorParcela = null, string DataHoraSimulacao = null, double? TaxaAntecipacaoAno = null, string NomeEstabelecimento = null, string Status = null, string DataCompra = null, string TipoOrigemTransacao = null, string Cidade = null, string Pais = null, string Latitude = null, string Longitude = null, long? IdGrupoMCC = null, string DescricaoGrupoMCC = null, long? IdProduto = null, string DescricaoProduto = null, string DescricaoEstabelecimento = null, string NomeFantasiaEstabelecimento = null, List<AntecipacaoSimuladaDetalhesResponse> Detalhes = null)
        {
            this.Mcc = Mcc;
            this.Uf = Uf;
            this.IdAntecipacaoSimulada = IdAntecipacaoSimulada;
            this.IdConta = IdConta;
            this.IdCompra = IdCompra;
            this.IdTipoTransacao = IdTipoTransacao;
            this.QuantidadeParcelasAntecipaveis = QuantidadeParcelasAntecipaveis;
            this.ValorParcela = ValorParcela;
            this.DataHoraSimulacao = DataHoraSimulacao;
            this.TaxaAntecipacaoAno = TaxaAntecipacaoAno;
            this.NomeEstabelecimento = NomeEstabelecimento;
            this.Status = Status;
            this.DataCompra = DataCompra;
            this.TipoOrigemTransacao = TipoOrigemTransacao;
            this.Cidade = Cidade;
            this.Pais = Pais;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            this.IdGrupoMCC = IdGrupoMCC;
            this.DescricaoGrupoMCC = DescricaoGrupoMCC;
            this.IdProduto = IdProduto;
            this.DescricaoProduto = DescricaoProduto;
            this.DescricaoEstabelecimento = DescricaoEstabelecimento;
            this.NomeFantasiaEstabelecimento = NomeFantasiaEstabelecimento;
            this.Detalhes = Detalhes;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Mcc
        /// </summary>
        [DataMember(Name="mcc", EmitDefaultValue=false)]
        public long? Mcc { get; set; }
    
        /// <summary>
        /// Gets or Sets Uf
        /// </summary>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }
    
        /// <summary>
        /// Identifier Code of the simulation of antecipation
        /// </summary>
        /// <value>Identifier Code of the simulation of antecipation</value>
        [DataMember(Name="idAntecipacaoSimulada", EmitDefaultValue=false)]
        public long? IdAntecipacaoSimulada { get; set; }
    
        /// <summary>
        /// Identifier Code of the Account
        /// </summary>
        /// <value>Identifier Code of the Account</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identifier Code of the shop event
        /// </summary>
        /// <value>Identifier Code of the shop event</value>
        [DataMember(Name="idCompra", EmitDefaultValue=false)]
        public long? IdCompra { get; set; }
    
        /// <summary>
        /// Identifier Code of type of the shop event
        /// </summary>
        /// <value>Identifier Code of type of the shop event</value>
        [DataMember(Name="idTipoTransacao", EmitDefaultValue=false)]
        public long? IdTipoTransacao { get; set; }
    
        /// <summary>
        /// Quantity of the antecipated parcels
        /// </summary>
        /// <value>Quantity of the antecipated parcels</value>
        [DataMember(Name="quantidadeParcelasAntecipaveis", EmitDefaultValue=false)]
        public int? QuantidadeParcelasAntecipaveis { get; set; }
    
        /// <summary>
        /// Value of the parcel
        /// </summary>
        /// <value>Value of the parcel</value>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public double? ValorParcela { get; set; }
    
        /// <summary>
        /// Date and time which the simulation was made
        /// </summary>
        /// <value>Date and time which the simulation was made</value>
        [DataMember(Name="dataHoraSimulacao", EmitDefaultValue=false)]
        public string DataHoraSimulacao { get; set; }
    
        /// <summary>
        /// Taxe of the antecipation applied (to the year)
        /// </summary>
        /// <value>Taxe of the antecipation applied (to the year)</value>
        [DataMember(Name="taxaAntecipacaoAno", EmitDefaultValue=false)]
        public double? TaxaAntecipacaoAno { get; set; }
    
        /// <summary>
        /// Establishment where the transaction was made
        /// </summary>
        /// <value>Establishment where the transaction was made</value>
        [DataMember(Name="nomeEstabelecimento", EmitDefaultValue=false)]
        public string NomeEstabelecimento { get; set; }
    
        /// <summary>
        /// Description of status of the shop authorization
        /// </summary>
        /// <value>Description of status of the shop authorization</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Date of the shop
        /// </summary>
        /// <value>Date of the shop</value>
        [DataMember(Name="dataCompra", EmitDefaultValue=false)]
        public string DataCompra { get; set; }
    
        /// <summary>
        /// Transaction type of the shop
        /// </summary>
        /// <value>Transaction type of the shop</value>
        [DataMember(Name="tipoOrigemTransacao", EmitDefaultValue=false)]
        public string TipoOrigemTransacao { get; set; }
    
        /// <summary>
        /// City where the shop was made
        /// </summary>
        /// <value>City where the shop was made</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// Country where the shop was made
        /// </summary>
        /// <value>Country where the shop was made</value>
        [DataMember(Name="pais", EmitDefaultValue=false)]
        public string Pais { get; set; }
    
        /// <summary>
        /// Latitudinal Coordinate of location of the shop
        /// </summary>
        /// <value>Latitudinal Coordinate of location of the shop</value>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public string Latitude { get; set; }
    
        /// <summary>
        /// Longitudinal Coordinate of the shop location
        /// </summary>
        /// <value>Longitudinal Coordinate of the shop location</value>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public string Longitude { get; set; }
    
        /// <summary>
        /// Identification Code of the MCC group of the shop
        /// </summary>
        /// <value>Identification Code of the MCC group of the shop</value>
        [DataMember(Name="idGrupoMCC", EmitDefaultValue=false)]
        public long? IdGrupoMCC { get; set; }
    
        /// <summary>
        /// Description of the Group MCC of the shop
        /// </summary>
        /// <value>Description of the Group MCC of the shop</value>
        [DataMember(Name="descricaoGrupoMCC", EmitDefaultValue=false)]
        public string DescricaoGrupoMCC { get; set; }
    
        /// <summary>
        /// Identification Code of the shop product
        /// </summary>
        /// <value>Identification Code of the shop product</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Description of the shop product
        /// </summary>
        /// <value>Description of the shop product</value>
        [DataMember(Name="descricaoProduto", EmitDefaultValue=false)]
        public string DescricaoProduto { get; set; }
    
        /// <summary>
        /// Description of the establishment of the shop
        /// </summary>
        /// <value>Description of the establishment of the shop</value>
        [DataMember(Name="descricaoEstabelecimento", EmitDefaultValue=false)]
        public string DescricaoEstabelecimento { get; set; }
    
        /// <summary>
        /// Fantasy name of the Establishment
        /// </summary>
        /// <value>Fantasy name of the Establishment</value>
        [DataMember(Name="nomeFantasiaEstabelecimento", EmitDefaultValue=false)]
        public string NomeFantasiaEstabelecimento { get; set; }
    
        /// <summary>
        /// Details of the simulation
        /// </summary>
        /// <value>Details of the simulation</value>
        [DataMember(Name="detalhes", EmitDefaultValue=false)]
        public List<AntecipacaoSimuladaDetalhesResponse> Detalhes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AntecipacaoSimuladaResponse {\n");
            sb.Append("  Mcc: ").Append(Mcc).Append("\n");
            sb.Append("  Uf: ").Append(Uf).Append("\n");
            sb.Append("  IdAntecipacaoSimulada: ").Append(IdAntecipacaoSimulada).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdCompra: ").Append(IdCompra).Append("\n");
            sb.Append("  IdTipoTransacao: ").Append(IdTipoTransacao).Append("\n");
            sb.Append("  QuantidadeParcelasAntecipaveis: ").Append(QuantidadeParcelasAntecipaveis).Append("\n");
            sb.Append("  ValorParcela: ").Append(ValorParcela).Append("\n");
            sb.Append("  DataHoraSimulacao: ").Append(DataHoraSimulacao).Append("\n");
            sb.Append("  TaxaAntecipacaoAno: ").Append(TaxaAntecipacaoAno).Append("\n");
            sb.Append("  NomeEstabelecimento: ").Append(NomeEstabelecimento).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DataCompra: ").Append(DataCompra).Append("\n");
            sb.Append("  TipoOrigemTransacao: ").Append(TipoOrigemTransacao).Append("\n");
            sb.Append("  Cidade: ").Append(Cidade).Append("\n");
            sb.Append("  Pais: ").Append(Pais).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  IdGrupoMCC: ").Append(IdGrupoMCC).Append("\n");
            sb.Append("  DescricaoGrupoMCC: ").Append(DescricaoGrupoMCC).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  DescricaoProduto: ").Append(DescricaoProduto).Append("\n");
            sb.Append("  DescricaoEstabelecimento: ").Append(DescricaoEstabelecimento).Append("\n");
            sb.Append("  NomeFantasiaEstabelecimento: ").Append(NomeFantasiaEstabelecimento).Append("\n");
            sb.Append("  Detalhes: ").Append(Detalhes).Append("\n");
            
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
            return this.Equals(obj as AntecipacaoSimuladaResponse);
        }

        /// <summary>
        /// Returns true if AntecipacaoSimuladaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AntecipacaoSimuladaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntecipacaoSimuladaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Mcc == other.Mcc ||
                    this.Mcc != null &&
                    this.Mcc.Equals(other.Mcc)
                ) && 
                (
                    this.Uf == other.Uf ||
                    this.Uf != null &&
                    this.Uf.Equals(other.Uf)
                ) && 
                (
                    this.IdAntecipacaoSimulada == other.IdAntecipacaoSimulada ||
                    this.IdAntecipacaoSimulada != null &&
                    this.IdAntecipacaoSimulada.Equals(other.IdAntecipacaoSimulada)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdCompra == other.IdCompra ||
                    this.IdCompra != null &&
                    this.IdCompra.Equals(other.IdCompra)
                ) && 
                (
                    this.IdTipoTransacao == other.IdTipoTransacao ||
                    this.IdTipoTransacao != null &&
                    this.IdTipoTransacao.Equals(other.IdTipoTransacao)
                ) && 
                (
                    this.QuantidadeParcelasAntecipaveis == other.QuantidadeParcelasAntecipaveis ||
                    this.QuantidadeParcelasAntecipaveis != null &&
                    this.QuantidadeParcelasAntecipaveis.Equals(other.QuantidadeParcelasAntecipaveis)
                ) && 
                (
                    this.ValorParcela == other.ValorParcela ||
                    this.ValorParcela != null &&
                    this.ValorParcela.Equals(other.ValorParcela)
                ) && 
                (
                    this.DataHoraSimulacao == other.DataHoraSimulacao ||
                    this.DataHoraSimulacao != null &&
                    this.DataHoraSimulacao.Equals(other.DataHoraSimulacao)
                ) && 
                (
                    this.TaxaAntecipacaoAno == other.TaxaAntecipacaoAno ||
                    this.TaxaAntecipacaoAno != null &&
                    this.TaxaAntecipacaoAno.Equals(other.TaxaAntecipacaoAno)
                ) && 
                (
                    this.NomeEstabelecimento == other.NomeEstabelecimento ||
                    this.NomeEstabelecimento != null &&
                    this.NomeEstabelecimento.Equals(other.NomeEstabelecimento)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.DataCompra == other.DataCompra ||
                    this.DataCompra != null &&
                    this.DataCompra.Equals(other.DataCompra)
                ) && 
                (
                    this.TipoOrigemTransacao == other.TipoOrigemTransacao ||
                    this.TipoOrigemTransacao != null &&
                    this.TipoOrigemTransacao.Equals(other.TipoOrigemTransacao)
                ) && 
                (
                    this.Cidade == other.Cidade ||
                    this.Cidade != null &&
                    this.Cidade.Equals(other.Cidade)
                ) && 
                (
                    this.Pais == other.Pais ||
                    this.Pais != null &&
                    this.Pais.Equals(other.Pais)
                ) && 
                (
                    this.Latitude == other.Latitude ||
                    this.Latitude != null &&
                    this.Latitude.Equals(other.Latitude)
                ) && 
                (
                    this.Longitude == other.Longitude ||
                    this.Longitude != null &&
                    this.Longitude.Equals(other.Longitude)
                ) && 
                (
                    this.IdGrupoMCC == other.IdGrupoMCC ||
                    this.IdGrupoMCC != null &&
                    this.IdGrupoMCC.Equals(other.IdGrupoMCC)
                ) && 
                (
                    this.DescricaoGrupoMCC == other.DescricaoGrupoMCC ||
                    this.DescricaoGrupoMCC != null &&
                    this.DescricaoGrupoMCC.Equals(other.DescricaoGrupoMCC)
                ) && 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.DescricaoProduto == other.DescricaoProduto ||
                    this.DescricaoProduto != null &&
                    this.DescricaoProduto.Equals(other.DescricaoProduto)
                ) && 
                (
                    this.DescricaoEstabelecimento == other.DescricaoEstabelecimento ||
                    this.DescricaoEstabelecimento != null &&
                    this.DescricaoEstabelecimento.Equals(other.DescricaoEstabelecimento)
                ) && 
                (
                    this.NomeFantasiaEstabelecimento == other.NomeFantasiaEstabelecimento ||
                    this.NomeFantasiaEstabelecimento != null &&
                    this.NomeFantasiaEstabelecimento.Equals(other.NomeFantasiaEstabelecimento)
                ) && 
                (
                    this.Detalhes == other.Detalhes ||
                    this.Detalhes != null &&
                    this.Detalhes.SequenceEqual(other.Detalhes)
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
                
                if (this.Mcc != null)
                    hash = hash * 59 + this.Mcc.GetHashCode();
                
                if (this.Uf != null)
                    hash = hash * 59 + this.Uf.GetHashCode();
                
                if (this.IdAntecipacaoSimulada != null)
                    hash = hash * 59 + this.IdAntecipacaoSimulada.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdCompra != null)
                    hash = hash * 59 + this.IdCompra.GetHashCode();
                
                if (this.IdTipoTransacao != null)
                    hash = hash * 59 + this.IdTipoTransacao.GetHashCode();
                
                if (this.QuantidadeParcelasAntecipaveis != null)
                    hash = hash * 59 + this.QuantidadeParcelasAntecipaveis.GetHashCode();
                
                if (this.ValorParcela != null)
                    hash = hash * 59 + this.ValorParcela.GetHashCode();
                
                if (this.DataHoraSimulacao != null)
                    hash = hash * 59 + this.DataHoraSimulacao.GetHashCode();
                
                if (this.TaxaAntecipacaoAno != null)
                    hash = hash * 59 + this.TaxaAntecipacaoAno.GetHashCode();
                
                if (this.NomeEstabelecimento != null)
                    hash = hash * 59 + this.NomeEstabelecimento.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.DataCompra != null)
                    hash = hash * 59 + this.DataCompra.GetHashCode();
                
                if (this.TipoOrigemTransacao != null)
                    hash = hash * 59 + this.TipoOrigemTransacao.GetHashCode();
                
                if (this.Cidade != null)
                    hash = hash * 59 + this.Cidade.GetHashCode();
                
                if (this.Pais != null)
                    hash = hash * 59 + this.Pais.GetHashCode();
                
                if (this.Latitude != null)
                    hash = hash * 59 + this.Latitude.GetHashCode();
                
                if (this.Longitude != null)
                    hash = hash * 59 + this.Longitude.GetHashCode();
                
                if (this.IdGrupoMCC != null)
                    hash = hash * 59 + this.IdGrupoMCC.GetHashCode();
                
                if (this.DescricaoGrupoMCC != null)
                    hash = hash * 59 + this.DescricaoGrupoMCC.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.DescricaoProduto != null)
                    hash = hash * 59 + this.DescricaoProduto.GetHashCode();
                
                if (this.DescricaoEstabelecimento != null)
                    hash = hash * 59 + this.DescricaoEstabelecimento.GetHashCode();
                
                if (this.NomeFantasiaEstabelecimento != null)
                    hash = hash * 59 + this.NomeFantasiaEstabelecimento.GetHashCode();
                
                if (this.Detalhes != null)
                    hash = hash * 59 + this.Detalhes.GetHashCode();
                
                return hash;
            }
        }

    }
}
