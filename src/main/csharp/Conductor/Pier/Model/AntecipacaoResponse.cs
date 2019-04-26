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
    /// Objeto que Representa Objeto de Resposta de Antecipa\u00E7\u00E3o
    /// </summary>
    [DataContract]
    public partial class AntecipacaoResponse :  IEquatable<AntecipacaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AntecipacaoResponse" /> class.
        /// Initializes a new instance of the <see cref="AntecipacaoResponse" />class.
        /// </summary>
        /// <param name="Mcc">Mcc.</param>
        /// <param name="Uf">Uf.</param>
        /// <param name="Id">C\u00F3digo de identifica\u00E7\u00E3o da antecipa\u00E7\u00E3o.</param>
        /// <param name="IdConta">C\u00F3digo de identifica\u00E7\u00E3o da conta.</param>
        /// <param name="IdCompra">C\u00F3digo de identifica\u00E7\u00E3o da compra.</param>
        /// <param name="QuantidadeParcelasTotal">Apresenta o numero total de parcelas da compra.</param>
        /// <param name="QuantidadeParcelasAntecipadas">Apresenta o numero de parcelas antecipadas.</param>
        /// <param name="ValorParcela">Apresenta o valor de cada parcela antecipadas.</param>
        /// <param name="ValorDescontoTotal">Apresenta o valor total do desconto.</param>
        /// <param name="ValorTotalComDesconto">Apresenta o valor total com desconto.</param>
        /// <param name="TaxaDesconto">Apresenta a taxa de desconto.</param>
        /// <param name="DataCompra">Data da compra.</param>
        /// <param name="Status">Descri\u00E7\u00E3o do status da autoriza\u00E7\u00E3o da compra.</param>
        /// <param name="NomeEstabelecimento">Nome do estabelecimento da compra.</param>
        /// <param name="TipoOrigemTransacao">Tipo de transa\u00E7\u00E3o da compra.</param>
        /// <param name="Cidade">Cidade onde a compra foi realizada.</param>
        /// <param name="Pais">Pa\u00EDs onde a compra foi realizada.</param>
        /// <param name="Latitude">Coordenada latitudinal da localiza\u00E7\u00E3o da compra.</param>
        /// <param name="Longitude">Coordenada longitudinal da localiza\u00E7\u00E3o da compra.</param>
        /// <param name="IdGrupoMCC">C\u00F3digo de Identifica\u00E7\u00E3o do Grupo MCC da compra.</param>
        /// <param name="DescricaoGrupoMCC">Descri\u00E7\u00E3o do Grupo MCC da compra.</param>
        /// <param name="IdProduto">C\u00F3digo de Identifica\u00E7\u00E3o do produto da compra.</param>
        /// <param name="DescricaoProduto">Descri\u00E7\u00E3o do produto da compra.</param>
        /// <param name="DescricaoEstabelecimento">Descri\u00E7\u00E3o do estabelecimento da compra.</param>
        /// <param name="NomeFantasiaEstabelecimento">Nome fantasia do estabelecimento da compra.</param>

        public AntecipacaoResponse(long? Mcc = null, string Uf = null, long? Id = null, long? IdConta = null, long? IdCompra = null, long? QuantidadeParcelasTotal = null, long? QuantidadeParcelasAntecipadas = null, double? ValorParcela = null, double? ValorDescontoTotal = null, double? ValorTotalComDesconto = null, double? TaxaDesconto = null, string DataCompra = null, string Status = null, string NomeEstabelecimento = null, string TipoOrigemTransacao = null, string Cidade = null, string Pais = null, string Latitude = null, string Longitude = null, long? IdGrupoMCC = null, string DescricaoGrupoMCC = null, long? IdProduto = null, string DescricaoProduto = null, string DescricaoEstabelecimento = null, string NomeFantasiaEstabelecimento = null)
        {
            this.Mcc = Mcc;
            this.Uf = Uf;
            this.Id = Id;
            this.IdConta = IdConta;
            this.IdCompra = IdCompra;
            this.QuantidadeParcelasTotal = QuantidadeParcelasTotal;
            this.QuantidadeParcelasAntecipadas = QuantidadeParcelasAntecipadas;
            this.ValorParcela = ValorParcela;
            this.ValorDescontoTotal = ValorDescontoTotal;
            this.ValorTotalComDesconto = ValorTotalComDesconto;
            this.TaxaDesconto = TaxaDesconto;
            this.DataCompra = DataCompra;
            this.Status = Status;
            this.NomeEstabelecimento = NomeEstabelecimento;
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
        /// C\u00F3digo de identifica\u00E7\u00E3o da antecipa\u00E7\u00E3o
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da antecipa\u00E7\u00E3o</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da conta
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da compra
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da compra</value>
        [DataMember(Name="idCompra", EmitDefaultValue=false)]
        public long? IdCompra { get; set; }
    
        /// <summary>
        /// Apresenta o numero total de parcelas da compra
        /// </summary>
        /// <value>Apresenta o numero total de parcelas da compra</value>
        [DataMember(Name="quantidadeParcelasTotal", EmitDefaultValue=false)]
        public long? QuantidadeParcelasTotal { get; set; }
    
        /// <summary>
        /// Apresenta o numero de parcelas antecipadas
        /// </summary>
        /// <value>Apresenta o numero de parcelas antecipadas</value>
        [DataMember(Name="quantidadeParcelasAntecipadas", EmitDefaultValue=false)]
        public long? QuantidadeParcelasAntecipadas { get; set; }
    
        /// <summary>
        /// Apresenta o valor de cada parcela antecipadas
        /// </summary>
        /// <value>Apresenta o valor de cada parcela antecipadas</value>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public double? ValorParcela { get; set; }
    
        /// <summary>
        /// Apresenta o valor total do desconto
        /// </summary>
        /// <value>Apresenta o valor total do desconto</value>
        [DataMember(Name="valorDescontoTotal", EmitDefaultValue=false)]
        public double? ValorDescontoTotal { get; set; }
    
        /// <summary>
        /// Apresenta o valor total com desconto
        /// </summary>
        /// <value>Apresenta o valor total com desconto</value>
        [DataMember(Name="valorTotalComDesconto", EmitDefaultValue=false)]
        public double? ValorTotalComDesconto { get; set; }
    
        /// <summary>
        /// Apresenta a taxa de desconto
        /// </summary>
        /// <value>Apresenta a taxa de desconto</value>
        [DataMember(Name="taxaDesconto", EmitDefaultValue=false)]
        public double? TaxaDesconto { get; set; }
    
        /// <summary>
        /// Data da compra
        /// </summary>
        /// <value>Data da compra</value>
        [DataMember(Name="dataCompra", EmitDefaultValue=false)]
        public string DataCompra { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do status da autoriza\u00E7\u00E3o da compra
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do status da autoriza\u00E7\u00E3o da compra</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
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
        /// Descri\u00E7\u00E3o do estabelecimento da compra
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do estabelecimento da compra</value>
        [DataMember(Name="descricaoEstabelecimento", EmitDefaultValue=false)]
        public string DescricaoEstabelecimento { get; set; }
    
        /// <summary>
        /// Nome fantasia do estabelecimento da compra
        /// </summary>
        /// <value>Nome fantasia do estabelecimento da compra</value>
        [DataMember(Name="nomeFantasiaEstabelecimento", EmitDefaultValue=false)]
        public string NomeFantasiaEstabelecimento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AntecipacaoResponse {\n");
            sb.Append("  Mcc: ").Append(Mcc).Append("\n");
            sb.Append("  Uf: ").Append(Uf).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdCompra: ").Append(IdCompra).Append("\n");
            sb.Append("  QuantidadeParcelasTotal: ").Append(QuantidadeParcelasTotal).Append("\n");
            sb.Append("  QuantidadeParcelasAntecipadas: ").Append(QuantidadeParcelasAntecipadas).Append("\n");
            sb.Append("  ValorParcela: ").Append(ValorParcela).Append("\n");
            sb.Append("  ValorDescontoTotal: ").Append(ValorDescontoTotal).Append("\n");
            sb.Append("  ValorTotalComDesconto: ").Append(ValorTotalComDesconto).Append("\n");
            sb.Append("  TaxaDesconto: ").Append(TaxaDesconto).Append("\n");
            sb.Append("  DataCompra: ").Append(DataCompra).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  NomeEstabelecimento: ").Append(NomeEstabelecimento).Append("\n");
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
            return this.Equals(obj as AntecipacaoResponse);
        }

        /// <summary>
        /// Returns true if AntecipacaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AntecipacaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntecipacaoResponse other)
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                    this.QuantidadeParcelasTotal == other.QuantidadeParcelasTotal ||
                    this.QuantidadeParcelasTotal != null &&
                    this.QuantidadeParcelasTotal.Equals(other.QuantidadeParcelasTotal)
                ) && 
                (
                    this.QuantidadeParcelasAntecipadas == other.QuantidadeParcelasAntecipadas ||
                    this.QuantidadeParcelasAntecipadas != null &&
                    this.QuantidadeParcelasAntecipadas.Equals(other.QuantidadeParcelasAntecipadas)
                ) && 
                (
                    this.ValorParcela == other.ValorParcela ||
                    this.ValorParcela != null &&
                    this.ValorParcela.Equals(other.ValorParcela)
                ) && 
                (
                    this.ValorDescontoTotal == other.ValorDescontoTotal ||
                    this.ValorDescontoTotal != null &&
                    this.ValorDescontoTotal.Equals(other.ValorDescontoTotal)
                ) && 
                (
                    this.ValorTotalComDesconto == other.ValorTotalComDesconto ||
                    this.ValorTotalComDesconto != null &&
                    this.ValorTotalComDesconto.Equals(other.ValorTotalComDesconto)
                ) && 
                (
                    this.TaxaDesconto == other.TaxaDesconto ||
                    this.TaxaDesconto != null &&
                    this.TaxaDesconto.Equals(other.TaxaDesconto)
                ) && 
                (
                    this.DataCompra == other.DataCompra ||
                    this.DataCompra != null &&
                    this.DataCompra.Equals(other.DataCompra)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdCompra != null)
                    hash = hash * 59 + this.IdCompra.GetHashCode();
                
                if (this.QuantidadeParcelasTotal != null)
                    hash = hash * 59 + this.QuantidadeParcelasTotal.GetHashCode();
                
                if (this.QuantidadeParcelasAntecipadas != null)
                    hash = hash * 59 + this.QuantidadeParcelasAntecipadas.GetHashCode();
                
                if (this.ValorParcela != null)
                    hash = hash * 59 + this.ValorParcela.GetHashCode();
                
                if (this.ValorDescontoTotal != null)
                    hash = hash * 59 + this.ValorDescontoTotal.GetHashCode();
                
                if (this.ValorTotalComDesconto != null)
                    hash = hash * 59 + this.ValorTotalComDesconto.GetHashCode();
                
                if (this.TaxaDesconto != null)
                    hash = hash * 59 + this.TaxaDesconto.GetHashCode();
                
                if (this.DataCompra != null)
                    hash = hash * 59 + this.DataCompra.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
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
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.DescricaoProduto != null)
                    hash = hash * 59 + this.DescricaoProduto.GetHashCode();
                
                if (this.DescricaoEstabelecimento != null)
                    hash = hash * 59 + this.DescricaoEstabelecimento.GetHashCode();
                
                if (this.NomeFantasiaEstabelecimento != null)
                    hash = hash * 59 + this.NomeFantasiaEstabelecimento.GetHashCode();
                
                return hash;
            }
        }

    }
}
