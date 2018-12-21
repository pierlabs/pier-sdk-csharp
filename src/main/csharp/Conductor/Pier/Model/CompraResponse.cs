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
    /// Object of Purchase
    /// </summary>
    [DataContract]
    public partial class CompraResponse :  IEquatable<CompraResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CompraResponse" /> class.
        /// Initializes a new instance of the <see cref="CompraResponse" />class.
        /// </summary>
        /// <param name="Mcc">Mcc.</param>
        /// <param name="Uf">Uf.</param>
        /// <param name="IdCompra">Identification Code of the shop.</param>
        /// <param name="Status">Description status of the shop authorization.</param>
        /// <param name="DataCompra">Date of the shop.</param>
        /// <param name="ValorTotalCompra">Total value of the shop.</param>
        /// <param name="ValorParcela">Parcel value of the shop.</param>
        /// <param name="PrimeiraParcela">First parcel value of the shop.</param>
        /// <param name="NumeroParcelas">Number of parcels of the shop.</param>
        /// <param name="NumeroParcelasAntecipaveis">Number of of the antecipated parcels of the shops.</param>
        /// <param name="NomeEstabelecimento">Establishment name of the shop.</param>
        /// <param name="TipoOrigemTransacao">Type of transaction of the shop.</param>
        /// <param name="Cidade">City where the shop was made.</param>
        /// <param name="Pais">country where the shop was made.</param>
        /// <param name="Latitude">Latitudinal Coordinate of the shop location.</param>
        /// <param name="Longitude">Longitudinal Coordinate of the shop location.</param>
        /// <param name="IdGrupoMCC">Identification Code of MCC Group of the shop.</param>
        /// <param name="DescricaoGrupoMCC">Description of MCC group of the shop.</param>
        /// <param name="IdConta">Identification Code of the account.</param>
        /// <param name="IdProduto">Identification Code of the product of purchase.</param>
        /// <param name="DescricaoProduto">Description of the product of purchase.</param>
        /// <param name="Cartao">Card number of the shop.</param>
        /// <param name="NomePortadorCartao">Cardholder name of the shop.</param>

        public CompraResponse(long? Mcc = null, string Uf = null, long? IdCompra = null, string Status = null, string DataCompra = null, double? ValorTotalCompra = null, double? ValorParcela = null, double? PrimeiraParcela = null, int? NumeroParcelas = null, int? NumeroParcelasAntecipaveis = null, string NomeEstabelecimento = null, string TipoOrigemTransacao = null, string Cidade = null, string Pais = null, string Latitude = null, string Longitude = null, long? IdGrupoMCC = null, string DescricaoGrupoMCC = null, long? IdConta = null, long? IdProduto = null, string DescricaoProduto = null, string Cartao = null, string NomePortadorCartao = null)
        {
            this.Mcc = Mcc;
            this.Uf = Uf;
            this.IdCompra = IdCompra;
            this.Status = Status;
            this.DataCompra = DataCompra;
            this.ValorTotalCompra = ValorTotalCompra;
            this.ValorParcela = ValorParcela;
            this.PrimeiraParcela = PrimeiraParcela;
            this.NumeroParcelas = NumeroParcelas;
            this.NumeroParcelasAntecipaveis = NumeroParcelasAntecipaveis;
            this.NomeEstabelecimento = NomeEstabelecimento;
            this.TipoOrigemTransacao = TipoOrigemTransacao;
            this.Cidade = Cidade;
            this.Pais = Pais;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            this.IdGrupoMCC = IdGrupoMCC;
            this.DescricaoGrupoMCC = DescricaoGrupoMCC;
            this.IdConta = IdConta;
            this.IdProduto = IdProduto;
            this.DescricaoProduto = DescricaoProduto;
            this.Cartao = Cartao;
            this.NomePortadorCartao = NomePortadorCartao;
            
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
        /// Identification Code of the shop
        /// </summary>
        /// <value>Identification Code of the shop</value>
        [DataMember(Name="idCompra", EmitDefaultValue=false)]
        public long? IdCompra { get; set; }
    
        /// <summary>
        /// Description status of the shop authorization
        /// </summary>
        /// <value>Description status of the shop authorization</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Date of the shop
        /// </summary>
        /// <value>Date of the shop</value>
        [DataMember(Name="dataCompra", EmitDefaultValue=false)]
        public string DataCompra { get; set; }
    
        /// <summary>
        /// Total value of the shop
        /// </summary>
        /// <value>Total value of the shop</value>
        [DataMember(Name="valorTotalCompra", EmitDefaultValue=false)]
        public double? ValorTotalCompra { get; set; }
    
        /// <summary>
        /// Parcel value of the shop
        /// </summary>
        /// <value>Parcel value of the shop</value>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public double? ValorParcela { get; set; }
    
        /// <summary>
        /// First parcel value of the shop
        /// </summary>
        /// <value>First parcel value of the shop</value>
        [DataMember(Name="primeiraParcela", EmitDefaultValue=false)]
        public double? PrimeiraParcela { get; set; }
    
        /// <summary>
        /// Number of parcels of the shop
        /// </summary>
        /// <value>Number of parcels of the shop</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public int? NumeroParcelas { get; set; }
    
        /// <summary>
        /// Number of of the antecipated parcels of the shops
        /// </summary>
        /// <value>Number of of the antecipated parcels of the shops</value>
        [DataMember(Name="numeroParcelasAntecipaveis", EmitDefaultValue=false)]
        public int? NumeroParcelasAntecipaveis { get; set; }
    
        /// <summary>
        /// Establishment name of the shop
        /// </summary>
        /// <value>Establishment name of the shop</value>
        [DataMember(Name="nomeEstabelecimento", EmitDefaultValue=false)]
        public string NomeEstabelecimento { get; set; }
    
        /// <summary>
        /// Type of transaction of the shop
        /// </summary>
        /// <value>Type of transaction of the shop</value>
        [DataMember(Name="tipoOrigemTransacao", EmitDefaultValue=false)]
        public string TipoOrigemTransacao { get; set; }
    
        /// <summary>
        /// City where the shop was made
        /// </summary>
        /// <value>City where the shop was made</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// country where the shop was made
        /// </summary>
        /// <value>country where the shop was made</value>
        [DataMember(Name="pais", EmitDefaultValue=false)]
        public string Pais { get; set; }
    
        /// <summary>
        /// Latitudinal Coordinate of the shop location
        /// </summary>
        /// <value>Latitudinal Coordinate of the shop location</value>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public string Latitude { get; set; }
    
        /// <summary>
        /// Longitudinal Coordinate of the shop location
        /// </summary>
        /// <value>Longitudinal Coordinate of the shop location</value>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public string Longitude { get; set; }
    
        /// <summary>
        /// Identification Code of MCC Group of the shop
        /// </summary>
        /// <value>Identification Code of MCC Group of the shop</value>
        [DataMember(Name="idGrupoMCC", EmitDefaultValue=false)]
        public long? IdGrupoMCC { get; set; }
    
        /// <summary>
        /// Description of MCC group of the shop
        /// </summary>
        /// <value>Description of MCC group of the shop</value>
        [DataMember(Name="descricaoGrupoMCC", EmitDefaultValue=false)]
        public string DescricaoGrupoMCC { get; set; }
    
        /// <summary>
        /// Identification Code of the account
        /// </summary>
        /// <value>Identification Code of the account</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identification Code of the product of purchase
        /// </summary>
        /// <value>Identification Code of the product of purchase</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Description of the product of purchase
        /// </summary>
        /// <value>Description of the product of purchase</value>
        [DataMember(Name="descricaoProduto", EmitDefaultValue=false)]
        public string DescricaoProduto { get; set; }
    
        /// <summary>
        /// Card number of the shop
        /// </summary>
        /// <value>Card number of the shop</value>
        [DataMember(Name="cartao", EmitDefaultValue=false)]
        public string Cartao { get; set; }
    
        /// <summary>
        /// Cardholder name of the shop
        /// </summary>
        /// <value>Cardholder name of the shop</value>
        [DataMember(Name="nomePortadorCartao", EmitDefaultValue=false)]
        public string NomePortadorCartao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompraResponse {\n");
            sb.Append("  Mcc: ").Append(Mcc).Append("\n");
            sb.Append("  Uf: ").Append(Uf).Append("\n");
            sb.Append("  IdCompra: ").Append(IdCompra).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DataCompra: ").Append(DataCompra).Append("\n");
            sb.Append("  ValorTotalCompra: ").Append(ValorTotalCompra).Append("\n");
            sb.Append("  ValorParcela: ").Append(ValorParcela).Append("\n");
            sb.Append("  PrimeiraParcela: ").Append(PrimeiraParcela).Append("\n");
            sb.Append("  NumeroParcelas: ").Append(NumeroParcelas).Append("\n");
            sb.Append("  NumeroParcelasAntecipaveis: ").Append(NumeroParcelasAntecipaveis).Append("\n");
            sb.Append("  NomeEstabelecimento: ").Append(NomeEstabelecimento).Append("\n");
            sb.Append("  TipoOrigemTransacao: ").Append(TipoOrigemTransacao).Append("\n");
            sb.Append("  Cidade: ").Append(Cidade).Append("\n");
            sb.Append("  Pais: ").Append(Pais).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  IdGrupoMCC: ").Append(IdGrupoMCC).Append("\n");
            sb.Append("  DescricaoGrupoMCC: ").Append(DescricaoGrupoMCC).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  DescricaoProduto: ").Append(DescricaoProduto).Append("\n");
            sb.Append("  Cartao: ").Append(Cartao).Append("\n");
            sb.Append("  NomePortadorCartao: ").Append(NomePortadorCartao).Append("\n");
            
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
            return this.Equals(obj as CompraResponse);
        }

        /// <summary>
        /// Returns true if CompraResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CompraResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompraResponse other)
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
                    this.IdCompra == other.IdCompra ||
                    this.IdCompra != null &&
                    this.IdCompra.Equals(other.IdCompra)
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
                    this.ValorTotalCompra == other.ValorTotalCompra ||
                    this.ValorTotalCompra != null &&
                    this.ValorTotalCompra.Equals(other.ValorTotalCompra)
                ) && 
                (
                    this.ValorParcela == other.ValorParcela ||
                    this.ValorParcela != null &&
                    this.ValorParcela.Equals(other.ValorParcela)
                ) && 
                (
                    this.PrimeiraParcela == other.PrimeiraParcela ||
                    this.PrimeiraParcela != null &&
                    this.PrimeiraParcela.Equals(other.PrimeiraParcela)
                ) && 
                (
                    this.NumeroParcelas == other.NumeroParcelas ||
                    this.NumeroParcelas != null &&
                    this.NumeroParcelas.Equals(other.NumeroParcelas)
                ) && 
                (
                    this.NumeroParcelasAntecipaveis == other.NumeroParcelasAntecipaveis ||
                    this.NumeroParcelasAntecipaveis != null &&
                    this.NumeroParcelasAntecipaveis.Equals(other.NumeroParcelasAntecipaveis)
                ) && 
                (
                    this.NomeEstabelecimento == other.NomeEstabelecimento ||
                    this.NomeEstabelecimento != null &&
                    this.NomeEstabelecimento.Equals(other.NomeEstabelecimento)
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
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
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
                    this.Cartao == other.Cartao ||
                    this.Cartao != null &&
                    this.Cartao.Equals(other.Cartao)
                ) && 
                (
                    this.NomePortadorCartao == other.NomePortadorCartao ||
                    this.NomePortadorCartao != null &&
                    this.NomePortadorCartao.Equals(other.NomePortadorCartao)
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
                
                if (this.IdCompra != null)
                    hash = hash * 59 + this.IdCompra.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.DataCompra != null)
                    hash = hash * 59 + this.DataCompra.GetHashCode();
                
                if (this.ValorTotalCompra != null)
                    hash = hash * 59 + this.ValorTotalCompra.GetHashCode();
                
                if (this.ValorParcela != null)
                    hash = hash * 59 + this.ValorParcela.GetHashCode();
                
                if (this.PrimeiraParcela != null)
                    hash = hash * 59 + this.PrimeiraParcela.GetHashCode();
                
                if (this.NumeroParcelas != null)
                    hash = hash * 59 + this.NumeroParcelas.GetHashCode();
                
                if (this.NumeroParcelasAntecipaveis != null)
                    hash = hash * 59 + this.NumeroParcelasAntecipaveis.GetHashCode();
                
                if (this.NomeEstabelecimento != null)
                    hash = hash * 59 + this.NomeEstabelecimento.GetHashCode();
                
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.DescricaoProduto != null)
                    hash = hash * 59 + this.DescricaoProduto.GetHashCode();
                
                if (this.Cartao != null)
                    hash = hash * 59 + this.Cartao.GetHashCode();
                
                if (this.NomePortadorCartao != null)
                    hash = hash * 59 + this.NomePortadorCartao.GetHashCode();
                
                return hash;
            }
        }

    }
}
