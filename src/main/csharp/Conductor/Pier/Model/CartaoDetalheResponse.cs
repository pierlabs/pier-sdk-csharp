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
    /// {{{cartao_detalhe_response_description}}}
    /// </summary>
    [DataContract]
    public partial class CartaoDetalheResponse :  IEquatable<CartaoDetalheResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoDetalheResponse" /> class.
        /// Initializes a new instance of the <see cref="CartaoDetalheResponse" />class.
        /// </summary>
        /// <param name="Id">{{{cartao_response_id_value}}}.</param>
        /// <param name="FlagTitular">{{{cartao_response_flag_titular_value}}}.</param>
        /// <param name="IdPessoa">{{{cartao_response_id_pessoa_value}}}.</param>
        /// <param name="SequencialCartao">{{{cartao_response_sequencial_cartao_value}}}.</param>
        /// <param name="IdConta">{{{cartao_response_id_conta_value}}}.</param>
        /// <param name="IdStatus">{{{cartao_response_id_status_value}}}.</param>
        /// <param name="DataStatus">{{{cartao_response_data_status_value}}}.</param>
        /// <param name="IdEstagio">{{{cartao_response_id_estagio_value}}}.</param>
        /// <param name="DataEstagio">{{{cartao_response_data_estagio_value}}}.</param>
        /// <param name="NumeroBin">{{{cartao_response_numero_bin_value}}}.</param>
        /// <param name="NumeroCartao">{{{cartao_response_numero_cartao_value}}}.</param>
        /// <param name="NumeroCartaoHash">{{{cartao_response_numero_cartao_hash_value}}}.</param>
        /// <param name="NumeroCartaoCriptografado">{{{cartao_response_numero_cartao_criptografado_value}}}.</param>
        /// <param name="DataEmissao">{{{cartao_response_data_emissao_value}}}.</param>
        /// <param name="DataValidade">{{{cartao_response_data_validade_value}}}.</param>
        /// <param name="CartaoVirtual">{{{cartao_response_cartao_virtual_value}}}.</param>
        /// <param name="ImpressaoAvulsa">{{{cartao_response_impressao_avulsa_value}}}.</param>
        /// <param name="DataImpressao">{{{cartao_response_data_impressao_value}}}.</param>
        /// <param name="NomeArquivoImpressao">{{{cartao_response_nome_arquivo_impressao_value}}}.</param>
        /// <param name="DescricaoTipoCartao">{{{cartao_detalhe_response_descricao_tipo_cartao_value}}}.</param>
        /// <param name="IdProduto">{{{cartao_response_id_produto_value}}}.</param>
        /// <param name="NomeImpresso">{{{cartao_response_nome_impresso_value}}}.</param>
        /// <param name="TipoCartao">{{{cartao_detalhe_response_tipo_cartao_value}}}.</param>
        /// <param name="CodigoDesbloqueio">{{{cartao_response_codigo_desbloqueio_value}}}.</param>

        public CartaoDetalheResponse(long? Id = null, int? FlagTitular = null, long? IdPessoa = null, int? SequencialCartao = null, long? IdConta = null, long? IdStatus = null, string DataStatus = null, long? IdEstagio = null, string DataEstagio = null, long? NumeroBin = null, string NumeroCartao = null, long? NumeroCartaoHash = null, string NumeroCartaoCriptografado = null, string DataEmissao = null, string DataValidade = null, int? CartaoVirtual = null, int? ImpressaoAvulsa = null, string DataImpressao = null, string NomeArquivoImpressao = null, string DescricaoTipoCartao = null, long? IdProduto = null, string NomeImpresso = null, long? TipoCartao = null, string CodigoDesbloqueio = null)
        {
            this.Id = Id;
            this.FlagTitular = FlagTitular;
            this.IdPessoa = IdPessoa;
            this.SequencialCartao = SequencialCartao;
            this.IdConta = IdConta;
            this.IdStatus = IdStatus;
            this.DataStatus = DataStatus;
            this.IdEstagio = IdEstagio;
            this.DataEstagio = DataEstagio;
            this.NumeroBin = NumeroBin;
            this.NumeroCartao = NumeroCartao;
            this.NumeroCartaoHash = NumeroCartaoHash;
            this.NumeroCartaoCriptografado = NumeroCartaoCriptografado;
            this.DataEmissao = DataEmissao;
            this.DataValidade = DataValidade;
            this.CartaoVirtual = CartaoVirtual;
            this.ImpressaoAvulsa = ImpressaoAvulsa;
            this.DataImpressao = DataImpressao;
            this.NomeArquivoImpressao = NomeArquivoImpressao;
            this.DescricaoTipoCartao = DescricaoTipoCartao;
            this.IdProduto = IdProduto;
            this.NomeImpresso = NomeImpresso;
            this.TipoCartao = TipoCartao;
            this.CodigoDesbloqueio = CodigoDesbloqueio;
            
        }
        
    
        /// <summary>
        /// {{{cartao_response_id_value}}}
        /// </summary>
        /// <value>{{{cartao_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{cartao_response_flag_titular_value}}}
        /// </summary>
        /// <value>{{{cartao_response_flag_titular_value}}}</value>
        [DataMember(Name="flagTitular", EmitDefaultValue=false)]
        public int? FlagTitular { get; set; }
    
        /// <summary>
        /// {{{cartao_response_id_pessoa_value}}}
        /// </summary>
        /// <value>{{{cartao_response_id_pessoa_value}}}</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// {{{cartao_response_sequencial_cartao_value}}}
        /// </summary>
        /// <value>{{{cartao_response_sequencial_cartao_value}}}</value>
        [DataMember(Name="sequencialCartao", EmitDefaultValue=false)]
        public int? SequencialCartao { get; set; }
    
        /// <summary>
        /// {{{cartao_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{cartao_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{cartao_response_id_status_value}}}
        /// </summary>
        /// <value>{{{cartao_response_id_status_value}}}</value>
        [DataMember(Name="idStatus", EmitDefaultValue=false)]
        public long? IdStatus { get; set; }
    
        /// <summary>
        /// {{{cartao_response_data_status_value}}}
        /// </summary>
        /// <value>{{{cartao_response_data_status_value}}}</value>
        [DataMember(Name="dataStatus", EmitDefaultValue=false)]
        public string DataStatus { get; set; }
    
        /// <summary>
        /// {{{cartao_response_id_estagio_value}}}
        /// </summary>
        /// <value>{{{cartao_response_id_estagio_value}}}</value>
        [DataMember(Name="idEstagio", EmitDefaultValue=false)]
        public long? IdEstagio { get; set; }
    
        /// <summary>
        /// {{{cartao_response_data_estagio_value}}}
        /// </summary>
        /// <value>{{{cartao_response_data_estagio_value}}}</value>
        [DataMember(Name="dataEstagio", EmitDefaultValue=false)]
        public string DataEstagio { get; set; }
    
        /// <summary>
        /// {{{cartao_response_numero_bin_value}}}
        /// </summary>
        /// <value>{{{cartao_response_numero_bin_value}}}</value>
        [DataMember(Name="numeroBin", EmitDefaultValue=false)]
        public long? NumeroBin { get; set; }
    
        /// <summary>
        /// {{{cartao_response_numero_cartao_value}}}
        /// </summary>
        /// <value>{{{cartao_response_numero_cartao_value}}}</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// {{{cartao_response_numero_cartao_hash_value}}}
        /// </summary>
        /// <value>{{{cartao_response_numero_cartao_hash_value}}}</value>
        [DataMember(Name="numeroCartaoHash", EmitDefaultValue=false)]
        public long? NumeroCartaoHash { get; set; }
    
        /// <summary>
        /// {{{cartao_response_numero_cartao_criptografado_value}}}
        /// </summary>
        /// <value>{{{cartao_response_numero_cartao_criptografado_value}}}</value>
        [DataMember(Name="numeroCartaoCriptografado", EmitDefaultValue=false)]
        public string NumeroCartaoCriptografado { get; set; }
    
        /// <summary>
        /// {{{cartao_response_data_emissao_value}}}
        /// </summary>
        /// <value>{{{cartao_response_data_emissao_value}}}</value>
        [DataMember(Name="dataEmissao", EmitDefaultValue=false)]
        public string DataEmissao { get; set; }
    
        /// <summary>
        /// {{{cartao_response_data_validade_value}}}
        /// </summary>
        /// <value>{{{cartao_response_data_validade_value}}}</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// {{{cartao_response_cartao_virtual_value}}}
        /// </summary>
        /// <value>{{{cartao_response_cartao_virtual_value}}}</value>
        [DataMember(Name="cartaoVirtual", EmitDefaultValue=false)]
        public int? CartaoVirtual { get; set; }
    
        /// <summary>
        /// {{{cartao_response_impressao_avulsa_value}}}
        /// </summary>
        /// <value>{{{cartao_response_impressao_avulsa_value}}}</value>
        [DataMember(Name="impressaoAvulsa", EmitDefaultValue=false)]
        public int? ImpressaoAvulsa { get; set; }
    
        /// <summary>
        /// {{{cartao_response_data_impressao_value}}}
        /// </summary>
        /// <value>{{{cartao_response_data_impressao_value}}}</value>
        [DataMember(Name="dataImpressao", EmitDefaultValue=false)]
        public string DataImpressao { get; set; }
    
        /// <summary>
        /// {{{cartao_response_nome_arquivo_impressao_value}}}
        /// </summary>
        /// <value>{{{cartao_response_nome_arquivo_impressao_value}}}</value>
        [DataMember(Name="nomeArquivoImpressao", EmitDefaultValue=false)]
        public string NomeArquivoImpressao { get; set; }
    
        /// <summary>
        /// {{{cartao_detalhe_response_descricao_tipo_cartao_value}}}
        /// </summary>
        /// <value>{{{cartao_detalhe_response_descricao_tipo_cartao_value}}}</value>
        [DataMember(Name="descricaoTipoCartao", EmitDefaultValue=false)]
        public string DescricaoTipoCartao { get; set; }
    
        /// <summary>
        /// {{{cartao_response_id_produto_value}}}
        /// </summary>
        /// <value>{{{cartao_response_id_produto_value}}}</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// {{{cartao_response_nome_impresso_value}}}
        /// </summary>
        /// <value>{{{cartao_response_nome_impresso_value}}}</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// {{{cartao_detalhe_response_tipo_cartao_value}}}
        /// </summary>
        /// <value>{{{cartao_detalhe_response_tipo_cartao_value}}}</value>
        [DataMember(Name="tipoCartao", EmitDefaultValue=false)]
        public long? TipoCartao { get; set; }
    
        /// <summary>
        /// {{{cartao_response_codigo_desbloqueio_value}}}
        /// </summary>
        /// <value>{{{cartao_response_codigo_desbloqueio_value}}}</value>
        [DataMember(Name="codigoDesbloqueio", EmitDefaultValue=false)]
        public string CodigoDesbloqueio { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoDetalheResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FlagTitular: ").Append(FlagTitular).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  SequencialCartao: ").Append(SequencialCartao).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdStatus: ").Append(IdStatus).Append("\n");
            sb.Append("  DataStatus: ").Append(DataStatus).Append("\n");
            sb.Append("  IdEstagio: ").Append(IdEstagio).Append("\n");
            sb.Append("  DataEstagio: ").Append(DataEstagio).Append("\n");
            sb.Append("  NumeroBin: ").Append(NumeroBin).Append("\n");
            sb.Append("  NumeroCartao: ").Append(NumeroCartao).Append("\n");
            sb.Append("  NumeroCartaoHash: ").Append(NumeroCartaoHash).Append("\n");
            sb.Append("  NumeroCartaoCriptografado: ").Append(NumeroCartaoCriptografado).Append("\n");
            sb.Append("  DataEmissao: ").Append(DataEmissao).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            sb.Append("  CartaoVirtual: ").Append(CartaoVirtual).Append("\n");
            sb.Append("  ImpressaoAvulsa: ").Append(ImpressaoAvulsa).Append("\n");
            sb.Append("  DataImpressao: ").Append(DataImpressao).Append("\n");
            sb.Append("  NomeArquivoImpressao: ").Append(NomeArquivoImpressao).Append("\n");
            sb.Append("  DescricaoTipoCartao: ").Append(DescricaoTipoCartao).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  TipoCartao: ").Append(TipoCartao).Append("\n");
            sb.Append("  CodigoDesbloqueio: ").Append(CodigoDesbloqueio).Append("\n");
            
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
            return this.Equals(obj as CartaoDetalheResponse);
        }

        /// <summary>
        /// Returns true if CartaoDetalheResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoDetalheResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoDetalheResponse other)
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
                    this.FlagTitular == other.FlagTitular ||
                    this.FlagTitular != null &&
                    this.FlagTitular.Equals(other.FlagTitular)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.SequencialCartao == other.SequencialCartao ||
                    this.SequencialCartao != null &&
                    this.SequencialCartao.Equals(other.SequencialCartao)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdStatus == other.IdStatus ||
                    this.IdStatus != null &&
                    this.IdStatus.Equals(other.IdStatus)
                ) && 
                (
                    this.DataStatus == other.DataStatus ||
                    this.DataStatus != null &&
                    this.DataStatus.Equals(other.DataStatus)
                ) && 
                (
                    this.IdEstagio == other.IdEstagio ||
                    this.IdEstagio != null &&
                    this.IdEstagio.Equals(other.IdEstagio)
                ) && 
                (
                    this.DataEstagio == other.DataEstagio ||
                    this.DataEstagio != null &&
                    this.DataEstagio.Equals(other.DataEstagio)
                ) && 
                (
                    this.NumeroBin == other.NumeroBin ||
                    this.NumeroBin != null &&
                    this.NumeroBin.Equals(other.NumeroBin)
                ) && 
                (
                    this.NumeroCartao == other.NumeroCartao ||
                    this.NumeroCartao != null &&
                    this.NumeroCartao.Equals(other.NumeroCartao)
                ) && 
                (
                    this.NumeroCartaoHash == other.NumeroCartaoHash ||
                    this.NumeroCartaoHash != null &&
                    this.NumeroCartaoHash.Equals(other.NumeroCartaoHash)
                ) && 
                (
                    this.NumeroCartaoCriptografado == other.NumeroCartaoCriptografado ||
                    this.NumeroCartaoCriptografado != null &&
                    this.NumeroCartaoCriptografado.Equals(other.NumeroCartaoCriptografado)
                ) && 
                (
                    this.DataEmissao == other.DataEmissao ||
                    this.DataEmissao != null &&
                    this.DataEmissao.Equals(other.DataEmissao)
                ) && 
                (
                    this.DataValidade == other.DataValidade ||
                    this.DataValidade != null &&
                    this.DataValidade.Equals(other.DataValidade)
                ) && 
                (
                    this.CartaoVirtual == other.CartaoVirtual ||
                    this.CartaoVirtual != null &&
                    this.CartaoVirtual.Equals(other.CartaoVirtual)
                ) && 
                (
                    this.ImpressaoAvulsa == other.ImpressaoAvulsa ||
                    this.ImpressaoAvulsa != null &&
                    this.ImpressaoAvulsa.Equals(other.ImpressaoAvulsa)
                ) && 
                (
                    this.DataImpressao == other.DataImpressao ||
                    this.DataImpressao != null &&
                    this.DataImpressao.Equals(other.DataImpressao)
                ) && 
                (
                    this.NomeArquivoImpressao == other.NomeArquivoImpressao ||
                    this.NomeArquivoImpressao != null &&
                    this.NomeArquivoImpressao.Equals(other.NomeArquivoImpressao)
                ) && 
                (
                    this.DescricaoTipoCartao == other.DescricaoTipoCartao ||
                    this.DescricaoTipoCartao != null &&
                    this.DescricaoTipoCartao.Equals(other.DescricaoTipoCartao)
                ) && 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.NomeImpresso == other.NomeImpresso ||
                    this.NomeImpresso != null &&
                    this.NomeImpresso.Equals(other.NomeImpresso)
                ) && 
                (
                    this.TipoCartao == other.TipoCartao ||
                    this.TipoCartao != null &&
                    this.TipoCartao.Equals(other.TipoCartao)
                ) && 
                (
                    this.CodigoDesbloqueio == other.CodigoDesbloqueio ||
                    this.CodigoDesbloqueio != null &&
                    this.CodigoDesbloqueio.Equals(other.CodigoDesbloqueio)
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
                
                if (this.FlagTitular != null)
                    hash = hash * 59 + this.FlagTitular.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.SequencialCartao != null)
                    hash = hash * 59 + this.SequencialCartao.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdStatus != null)
                    hash = hash * 59 + this.IdStatus.GetHashCode();
                
                if (this.DataStatus != null)
                    hash = hash * 59 + this.DataStatus.GetHashCode();
                
                if (this.IdEstagio != null)
                    hash = hash * 59 + this.IdEstagio.GetHashCode();
                
                if (this.DataEstagio != null)
                    hash = hash * 59 + this.DataEstagio.GetHashCode();
                
                if (this.NumeroBin != null)
                    hash = hash * 59 + this.NumeroBin.GetHashCode();
                
                if (this.NumeroCartao != null)
                    hash = hash * 59 + this.NumeroCartao.GetHashCode();
                
                if (this.NumeroCartaoHash != null)
                    hash = hash * 59 + this.NumeroCartaoHash.GetHashCode();
                
                if (this.NumeroCartaoCriptografado != null)
                    hash = hash * 59 + this.NumeroCartaoCriptografado.GetHashCode();
                
                if (this.DataEmissao != null)
                    hash = hash * 59 + this.DataEmissao.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                if (this.CartaoVirtual != null)
                    hash = hash * 59 + this.CartaoVirtual.GetHashCode();
                
                if (this.ImpressaoAvulsa != null)
                    hash = hash * 59 + this.ImpressaoAvulsa.GetHashCode();
                
                if (this.DataImpressao != null)
                    hash = hash * 59 + this.DataImpressao.GetHashCode();
                
                if (this.NomeArquivoImpressao != null)
                    hash = hash * 59 + this.NomeArquivoImpressao.GetHashCode();
                
                if (this.DescricaoTipoCartao != null)
                    hash = hash * 59 + this.DescricaoTipoCartao.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.NomeImpresso != null)
                    hash = hash * 59 + this.NomeImpresso.GetHashCode();
                
                if (this.TipoCartao != null)
                    hash = hash * 59 + this.TipoCartao.GetHashCode();
                
                if (this.CodigoDesbloqueio != null)
                    hash = hash * 59 + this.CodigoDesbloqueio.GetHashCode();
                
                return hash;
            }
        }

    }
}
