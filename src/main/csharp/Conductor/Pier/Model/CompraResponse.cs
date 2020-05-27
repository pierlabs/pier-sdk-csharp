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
    /// Objeto de Compra
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
        /// <param name="IdCompra">C\u00F3digo de identifica\u00E7\u00E3o da compra.</param>
        /// <param name="Status">Descri\u00E7\u00E3o do status da autoriza\u00E7\u00E3o da compra.</param>
        /// <param name="DataCompra">Data da compra.</param>
        /// <param name="ValorTotalCompra">Valor total da compra.</param>
        /// <param name="ValorParcela">Valor da parcela da compra.</param>
        /// <param name="PrimeiraParcela">Valor da primeira parcela da compra.</param>
        /// <param name="NumeroParcelas">N\u00FAmero de parcelas da compra.</param>
        /// <param name="NumeroParcelasAntecipaveis">N\u00FAmero de parcelas antecip\u00E1veis da compra.</param>
        /// <param name="NomeEstabelecimento">Nome do estabelecimento da compra.</param>
        /// <param name="TipoOrigemTransacao">Tipo de transa\u00E7\u00E3o da compra.</param>
        /// <param name="Cidade">Cidade onde a compra foi realizada.</param>
        /// <param name="Pais">Pa\u00EDs onde a compra foi realizada.</param>
        /// <param name="Latitude">Coordenada latitudinal da localiza\u00E7\u00E3o da compra.</param>
        /// <param name="Longitude">Coordenada longitudinal da localiza\u00E7\u00E3o da compra.</param>
        /// <param name="IdGrupoMCC">C\u00F3digo de Identifica\u00E7\u00E3o do Grupo MCC da compra.</param>
        /// <param name="DescricaoGrupoMCC">Descri\u00E7\u00E3o do Grupo MCC da compra.</param>
        /// <param name="IdConta">C\u00F3digo de Identifica\u00E7\u00E3o da conta da compra.</param>
        /// <param name="IdProduto">C\u00F3digo de Identifica\u00E7\u00E3o do produto da compra.</param>
        /// <param name="DescricaoProduto">Descri\u00E7\u00E3o do produto da compra.</param>
        /// <param name="Cartao">N\u00FAmero do cart\u00E3o da compra.</param>
        /// <param name="NomePortadorCartao">Nome do portador do cart\u00E3o da compra.</param>
        /// <param name="TipoEvento">Tipo do evento.</param>

        public CompraResponse(long? Mcc = null, string Uf = null, long? IdCompra = null, string Status = null, string DataCompra = null, double? ValorTotalCompra = null, double? ValorParcela = null, double? PrimeiraParcela = null, int? NumeroParcelas = null, int? NumeroParcelasAntecipaveis = null, string NomeEstabelecimento = null, string TipoOrigemTransacao = null, string Cidade = null, string Pais = null, string Latitude = null, string Longitude = null, long? IdGrupoMCC = null, string DescricaoGrupoMCC = null, long? IdConta = null, long? IdProduto = null, string DescricaoProduto = null, string Cartao = null, string NomePortadorCartao = null, string TipoEvento = null)
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
            this.TipoEvento = TipoEvento;
            
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
        /// C\u00F3digo de identifica\u00E7\u00E3o da compra
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da compra</value>
        [DataMember(Name="idCompra", EmitDefaultValue=false)]
        public long? IdCompra { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do status da autoriza\u00E7\u00E3o da compra
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do status da autoriza\u00E7\u00E3o da compra</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Data da compra
        /// </summary>
        /// <value>Data da compra</value>
        [DataMember(Name="dataCompra", EmitDefaultValue=false)]
        public string DataCompra { get; set; }
    
        /// <summary>
        /// Valor total da compra
        /// </summary>
        /// <value>Valor total da compra</value>
        [DataMember(Name="valorTotalCompra", EmitDefaultValue=false)]
        public double? ValorTotalCompra { get; set; }
    
        /// <summary>
        /// Valor da parcela da compra
        /// </summary>
        /// <value>Valor da parcela da compra</value>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public double? ValorParcela { get; set; }
    
        /// <summary>
        /// Valor da primeira parcela da compra
        /// </summary>
        /// <value>Valor da primeira parcela da compra</value>
        [DataMember(Name="primeiraParcela", EmitDefaultValue=false)]
        public double? PrimeiraParcela { get; set; }
    
        /// <summary>
        /// N\u00FAmero de parcelas da compra
        /// </summary>
        /// <value>N\u00FAmero de parcelas da compra</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public int? NumeroParcelas { get; set; }
    
        /// <summary>
        /// N\u00FAmero de parcelas antecip\u00E1veis da compra
        /// </summary>
        /// <value>N\u00FAmero de parcelas antecip\u00E1veis da compra</value>
        [DataMember(Name="numeroParcelasAntecipaveis", EmitDefaultValue=false)]
        public int? NumeroParcelasAntecipaveis { get; set; }
    
        /// <summary>
        /// Nome do estabelecimento da compra
        /// </summary>
        /// <value>Nome do estabelecimento da compra</value>
        [DataMember(Name="nomeEstabelecimento", EmitDefaultValue=false)]
        public string NomeEstabelecimento { get; set; }
    
        /// <summary>
        /// Tipo de transa\u00E7\u00E3o da compra
        /// </summary>
        /// <value>Tipo de transa\u00E7\u00E3o da compra</value>
        [DataMember(Name="tipoOrigemTransacao", EmitDefaultValue=false)]
        public string TipoOrigemTransacao { get; set; }
    
        /// <summary>
        /// Cidade onde a compra foi realizada
        /// </summary>
        /// <value>Cidade onde a compra foi realizada</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// Pa\u00EDs onde a compra foi realizada
        /// </summary>
        /// <value>Pa\u00EDs onde a compra foi realizada</value>
        [DataMember(Name="pais", EmitDefaultValue=false)]
        public string Pais { get; set; }
    
        /// <summary>
        /// Coordenada latitudinal da localiza\u00E7\u00E3o da compra
        /// </summary>
        /// <value>Coordenada latitudinal da localiza\u00E7\u00E3o da compra</value>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public string Latitude { get; set; }
    
        /// <summary>
        /// Coordenada longitudinal da localiza\u00E7\u00E3o da compra
        /// </summary>
        /// <value>Coordenada longitudinal da localiza\u00E7\u00E3o da compra</value>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public string Longitude { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Grupo MCC da compra
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Grupo MCC da compra</value>
        [DataMember(Name="idGrupoMCC", EmitDefaultValue=false)]
        public long? IdGrupoMCC { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do Grupo MCC da compra
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do Grupo MCC da compra</value>
        [DataMember(Name="descricaoGrupoMCC", EmitDefaultValue=false)]
        public string DescricaoGrupoMCC { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da conta da compra
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da conta da compra</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do produto da compra
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do produto da compra</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do produto da compra
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do produto da compra</value>
        [DataMember(Name="descricaoProduto", EmitDefaultValue=false)]
        public string DescricaoProduto { get; set; }
    
        /// <summary>
        /// N\u00FAmero do cart\u00E3o da compra
        /// </summary>
        /// <value>N\u00FAmero do cart\u00E3o da compra</value>
        [DataMember(Name="cartao", EmitDefaultValue=false)]
        public string Cartao { get; set; }
    
        /// <summary>
        /// Nome do portador do cart\u00E3o da compra
        /// </summary>
        /// <value>Nome do portador do cart\u00E3o da compra</value>
        [DataMember(Name="nomePortadorCartao", EmitDefaultValue=false)]
        public string NomePortadorCartao { get; set; }
    
        /// <summary>
        /// Tipo do evento
        /// </summary>
        /// <value>Tipo do evento</value>
        [DataMember(Name="tipoEvento", EmitDefaultValue=false)]
        public string TipoEvento { get; set; }
    
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
            sb.Append("  TipoEvento: ").Append(TipoEvento).Append("\n");
            
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
                ) && 
                (
                    this.TipoEvento == other.TipoEvento ||
                    this.TipoEvento != null &&
                    this.TipoEvento.Equals(other.TipoEvento)
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
                
                if (this.TipoEvento != null)
                    hash = hash * 59 + this.TipoEvento.GetHashCode();
                
                return hash;
            }
        }

    }
}
