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
    /// {{{antecipacao_response_description}}}
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
        /// <param name="Id">{{{antecipacao_response_id_value}}}.</param>
        /// <param name="IdConta">{{{antecipacao_response_id_conta_value}}}.</param>
        /// <param name="IdCompra">{{{antecipacao_response_id_compra_value}}}.</param>
        /// <param name="QuantidadeParcelasTotal">{{{antecipacao_response_quantidade_parcelas_total_value}}}.</param>
        /// <param name="QuantidadeParcelasAntecipadas">{{{antecipacao_response_quantidade_parcelas_antecipadas_value}}}.</param>
        /// <param name="ValorParcela">{{{antecipacao_response_valor_parcela_value}}}.</param>
        /// <param name="ValorDescontoTotal">{{{antecipacao_response_valor_desconto_total_value}}}.</param>
        /// <param name="ValorTotalComDesconto">{{{antecipacao_response_valor_total_com_desconto_value}}}.</param>
        /// <param name="TaxaDesconto">{{{antecipacao_response_taxa_desconto_value}}}.</param>
        /// <param name="DataCompra">{{{antecipacao_response_data_compra_value}}}.</param>
        /// <param name="Status">{{{antecipacao_response_status_value}}}.</param>
        /// <param name="NomeEstabelecimento">{{{antecipacao_response_nome_estabelecimento_value}}}.</param>
        /// <param name="TipoOrigemTransacao">{{{antecipacao_response_tipo_origem_transacao_value}}}.</param>
        /// <param name="Cidade">{{{antecipacao_response_cidade_value}}}.</param>
        /// <param name="Pais">{{{antecipacao_response_pais_value}}}.</param>
        /// <param name="Latitude">{{{antecipacao_response_latitude_value}}}.</param>
        /// <param name="Longitude">{{{antecipacao_response_longitude_value}}}.</param>
        /// <param name="IdGrupoMCC">{{{antecipacao_response_id_grupo_m_c_c_value}}}.</param>
        /// <param name="DescricaoGrupoMCC">{{{antecipacao_response_descricao_grupo_m_c_c_value}}}.</param>
        /// <param name="IdProduto">{{{antecipacao_response_id_produto_value}}}.</param>
        /// <param name="DescricaoProduto">{{{antecipacao_response_descricao_produto_value}}}.</param>
        /// <param name="DescricaoEstabelecimento">{{{antecipacao_response_descricao_estabelecimento_value}}}.</param>
        /// <param name="NomeFantasiaEstabelecimento">{{{antecipacao_response_nome_fantasia_estabelecimento_value}}}.</param>

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
        /// {{{antecipacao_response_id_value}}}
        /// </summary>
        /// <value>{{{antecipacao_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{antecipacao_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{antecipacao_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{antecipacao_response_id_compra_value}}}
        /// </summary>
        /// <value>{{{antecipacao_response_id_compra_value}}}</value>
        [DataMember(Name="idCompra", EmitDefaultValue=false)]
        public long? IdCompra { get; set; }
    
        /// <summary>
        /// {{{antecipacao_response_quantidade_parcelas_total_value}}}
        /// </summary>
        /// <value>{{{antecipacao_response_quantidade_parcelas_total_value}}}</value>
        [DataMember(Name="quantidadeParcelasTotal", EmitDefaultValue=false)]
        public long? QuantidadeParcelasTotal { get; set; }
    
        /// <summary>
        /// {{{antecipacao_response_quantidade_parcelas_antecipadas_value}}}
        /// </summary>
        /// <value>{{{antecipacao_response_quantidade_parcelas_antecipadas_value}}}</value>
        [DataMember(Name="quantidadeParcelasAntecipadas", EmitDefaultValue=false)]
        public long? QuantidadeParcelasAntecipadas { get; set; }
    
        /// <summary>
        /// {{{antecipacao_response_valor_parcela_value}}}
        /// </summary>
        /// <value>{{{antecipacao_response_valor_parcela_value}}}</value>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public double? ValorParcela { get; set; }
    
        /// <summary>
        /// {{{antecipacao_response_valor_desconto_total_value}}}
        /// </summary>
        /// <value>{{{antecipacao_response_valor_desconto_total_value}}}</value>
        [DataMember(Name="valorDescontoTotal", EmitDefaultValue=false)]
        public double? ValorDescontoTotal { get; set; }
    
        /// <summary>
        /// {{{antecipacao_response_valor_total_com_desconto_value}}}
        /// </summary>
        /// <value>{{{antecipacao_response_valor_total_com_desconto_value}}}</value>
        [DataMember(Name="valorTotalComDesconto", EmitDefaultValue=false)]
        public double? ValorTotalComDesconto { get; set; }
    
        /// <summary>
        /// {{{antecipacao_response_taxa_desconto_value}}}
        /// </summary>
        /// <value>{{{antecipacao_response_taxa_desconto_value}}}</value>
        [DataMember(Name="taxaDesconto", EmitDefaultValue=false)]
        public double? TaxaDesconto { get; set; }
    
        /// <summary>
        /// {{{antecipacao_response_data_compra_value}}}
        /// </summary>
        /// <value>{{{antecipacao_response_data_compra_value}}}</value>
        [DataMember(Name="dataCompra", EmitDefaultValue=false)]
        public string DataCompra { get; set; }
    
        /// <summary>
        /// {{{antecipacao_response_status_value}}}
        /// </summary>
        /// <value>{{{antecipacao_response_status_value}}}</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// {{{antecipacao_response_nome_estabelecimento_value}}}
        /// </summary>
        /// <value>{{{antecipacao_response_nome_estabelecimento_value}}}</value>
        [DataMember(Name="nomeEstabelecimento", EmitDefaultValue=false)]
        public string NomeEstabelecimento { get; set; }
    
        /// <summary>
        /// {{{antecipacao_response_tipo_origem_transacao_value}}}
        /// </summary>
        /// <value>{{{antecipacao_response_tipo_origem_transacao_value}}}</value>
        [DataMember(Name="tipoOrigemTransacao", EmitDefaultValue=false)]
        public string TipoOrigemTransacao { get; set; }
    
        /// <summary>
        /// {{{antecipacao_response_cidade_value}}}
        /// </summary>
        /// <value>{{{antecipacao_response_cidade_value}}}</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// {{{antecipacao_response_pais_value}}}
        /// </summary>
        /// <value>{{{antecipacao_response_pais_value}}}</value>
        [DataMember(Name="pais", EmitDefaultValue=false)]
        public string Pais { get; set; }
    
        /// <summary>
        /// {{{antecipacao_response_latitude_value}}}
        /// </summary>
        /// <value>{{{antecipacao_response_latitude_value}}}</value>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public string Latitude { get; set; }
    
        /// <summary>
        /// {{{antecipacao_response_longitude_value}}}
        /// </summary>
        /// <value>{{{antecipacao_response_longitude_value}}}</value>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public string Longitude { get; set; }
    
        /// <summary>
        /// {{{antecipacao_response_id_grupo_m_c_c_value}}}
        /// </summary>
        /// <value>{{{antecipacao_response_id_grupo_m_c_c_value}}}</value>
        [DataMember(Name="idGrupoMCC", EmitDefaultValue=false)]
        public long? IdGrupoMCC { get; set; }
    
        /// <summary>
        /// {{{antecipacao_response_descricao_grupo_m_c_c_value}}}
        /// </summary>
        /// <value>{{{antecipacao_response_descricao_grupo_m_c_c_value}}}</value>
        [DataMember(Name="descricaoGrupoMCC", EmitDefaultValue=false)]
        public string DescricaoGrupoMCC { get; set; }
    
        /// <summary>
        /// {{{antecipacao_response_id_produto_value}}}
        /// </summary>
        /// <value>{{{antecipacao_response_id_produto_value}}}</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// {{{antecipacao_response_descricao_produto_value}}}
        /// </summary>
        /// <value>{{{antecipacao_response_descricao_produto_value}}}</value>
        [DataMember(Name="descricaoProduto", EmitDefaultValue=false)]
        public string DescricaoProduto { get; set; }
    
        /// <summary>
        /// {{{antecipacao_response_descricao_estabelecimento_value}}}
        /// </summary>
        /// <value>{{{antecipacao_response_descricao_estabelecimento_value}}}</value>
        [DataMember(Name="descricaoEstabelecimento", EmitDefaultValue=false)]
        public string DescricaoEstabelecimento { get; set; }
    
        /// <summary>
        /// {{{antecipacao_response_nome_fantasia_estabelecimento_value}}}
        /// </summary>
        /// <value>{{{antecipacao_response_nome_fantasia_estabelecimento_value}}}</value>
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
