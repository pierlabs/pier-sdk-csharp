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
    /// {{{dados_cartao_impressao_response_description}}}
    /// </summary>
    [DataContract]
    public partial class DadosCartaoImpressaoResponse :  IEquatable<DadosCartaoImpressaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DadosCartaoImpressaoResponse" /> class.
        /// Initializes a new instance of the <see cref="DadosCartaoImpressaoResponse" />class.
        /// </summary>
        /// <param name="IdConta">{{{dados_cartao_impressao_response_id_conta_value}}}.</param>
        /// <param name="IdPessoa">{{{dados_cartao_impressao_response_id_pessoa_value}}}.</param>
        /// <param name="IdCartao">{{{dados_cartao_impressao_response_id_cartao_value}}}.</param>
        /// <param name="IdBandeira">{{{dados_cartao_impressao_response_id_bandeira_value}}}.</param>
        /// <param name="IdTipoCartao">{{{dados_cartao_impressao_response_id_tipo_cartao_value}}}.</param>
        /// <param name="NumeroCartao">{{{dados_cartao_impressao_response_numero_cartao_value}}}.</param>
        /// <param name="NomePlastico">{{{dados_cartao_impressao_response_nome_plastico_value}}}.</param>
        /// <param name="Cvv2">{{{dados_cartao_impressao_response_cvv2_value}}}.</param>
        /// <param name="DataGeracao">{{{dados_cartao_impressao_response_data_geracao_value}}}.</param>
        /// <param name="DataValidade">{{{dados_cartao_impressao_response_data_validade_value}}}.</param>
        /// <param name="Cpf">{{{dados_cartao_impressao_response_cpf_value}}}.</param>
        /// <param name="TipoPortador">{{{dados_cartao_impressao_response_tipo_portador_value}}}.</param>
        /// <param name="Trilha1">{{{dados_cartao_impressao_response_trilha1_value}}}.</param>
        /// <param name="Trilha2">{{{dados_cartao_impressao_response_trilha2_value}}}.</param>
        /// <param name="TrilhaCVV1">{{{dados_cartao_impressao_response_trilha_c_v_v1_value}}}.</param>
        /// <param name="TrilhaCVV2">{{{dados_cartao_impressao_response_trilha_c_v_v2_value}}}.</param>
        /// <param name="FlagVirtual">{{{dados_cartao_impressao_response_flag_virtual_value}}}.</param>
        /// <param name="NomeBandeira">{{{dados_cartao_impressao_response_nome_bandeira_value}}}.</param>
        /// <param name="FlagTitular">{{{dados_cartao_impressao_response_flag_titular_value}}}.</param>
        /// <param name="SequencialCartao">{{{dados_cartao_impressao_response_sequencial_cartao_value}}}.</param>
        /// <param name="IdStatus">{{{dados_cartao_impressao_response_id_status_value}}}.</param>
        /// <param name="DescricaoStatusCartao">{{{dados_cartao_impressao_response_descricao_status_cartao_value}}}.</param>
        /// <param name="DataStatus">{{{dados_cartao_impressao_response_data_status_value}}}.</param>
        /// <param name="IdEstagio">{{{dados_cartao_impressao_response_id_estagio_value}}}.</param>
        /// <param name="DescricaoEstagio">{{{dados_cartao_impressao_response_descricao_estagio_value}}}.</param>
        /// <param name="DataEstagio">{{{dados_cartao_impressao_response_data_estagio_value}}}.</param>
        /// <param name="NumeroBin">{{{dados_cartao_impressao_response_numero_bin_value}}}.</param>
        /// <param name="IdProduto">{{{dados_cartao_impressao_response_id_produto_value}}}.</param>
        /// <param name="DescricaoProduto">{{{dados_cartao_impressao_response_descricao_produto_value}}}.</param>
        /// <param name="IdStatusConta">{{{dados_cartao_impressao_response_id_status_conta_value}}}.</param>
        /// <param name="DescricaoStatusConta">{{{dados_cartao_impressao_response_descricao_status_conta_value}}}.</param>
        /// <param name="DataEmbossing">{{{dados_cartao_impressao_response_data_embossing_value}}}.</param>
        /// <param name="CodigoDesbloqueio">{{{dados_cartao_impressao_response_codigo_desbloqueio_value}}}.</param>
        /// <param name="NomePessoa">{{{dados_cartao_impressao_response_nome_pessoa_value}}}.</param>
        /// <param name="TipoPessoa">{{{dados_cartao_impressao_response_tipo_pessoa_value}}}.</param>
        /// <param name="DataNascimento">{{{dados_cartao_impressao_response_data_nascimento_value}}}.</param>
        /// <param name="IdEndereco">{{{dados_cartao_impressao_response_id_endereco_value}}}.</param>
        /// <param name="IdTipoEndereco">{{{dados_cartao_impressao_response_id_tipo_endereco_value}}}.</param>
        /// <param name="DescricaoTipoEndereco">{{{dados_cartao_impressao_response_descricao_tipo_endereco_value}}}.</param>
        /// <param name="Cep">{{{dados_cartao_impressao_response_cep_value}}}.</param>
        /// <param name="Logradouro">{{{dados_cartao_impressao_response_logradouro_value}}}.</param>
        /// <param name="NumeroEndereco">{{{dados_cartao_impressao_response_numero_endereco_value}}}.</param>
        /// <param name="ComplementoEndereco">{{{dados_cartao_impressao_response_complemento_endereco_value}}}.</param>
        /// <param name="Bairro">{{{dados_cartao_impressao_response_bairro_value}}}.</param>
        /// <param name="Cidade">{{{dados_cartao_impressao_response_cidade_value}}}.</param>
        /// <param name="Uf">{{{dados_cartao_impressao_response_uf_value}}}.</param>
        /// <param name="Pais">{{{dados_cartao_impressao_response_pais_value}}}.</param>
        /// <param name="SenhaCriptografada">{{{dados_cartao_impressao_response_senha_criptografada_value}}}.</param>
        /// <param name="Icvv">{{{dados_cartao_impressao_response_icvv_value}}}.</param>
        /// <param name="IdStatusImpressao">{{{dados_cartao_impressao_response_id_status_impressao_value}}}.</param>

        public DadosCartaoImpressaoResponse(long? IdConta = null, long? IdPessoa = null, long? IdCartao = null, long? IdBandeira = null, long? IdTipoCartao = null, string NumeroCartao = null, string NomePlastico = null, string Cvv2 = null, string DataGeracao = null, string DataValidade = null, string Cpf = null, string TipoPortador = null, string Trilha1 = null, string Trilha2 = null, string TrilhaCVV1 = null, string TrilhaCVV2 = null, int? FlagVirtual = null, string NomeBandeira = null, int? FlagTitular = null, int? SequencialCartao = null, long? IdStatus = null, string DescricaoStatusCartao = null, string DataStatus = null, long? IdEstagio = null, string DescricaoEstagio = null, string DataEstagio = null, string NumeroBin = null, long? IdProduto = null, string DescricaoProduto = null, long? IdStatusConta = null, long? DescricaoStatusConta = null, string DataEmbossing = null, string CodigoDesbloqueio = null, string NomePessoa = null, string TipoPessoa = null, string DataNascimento = null, long? IdEndereco = null, long? IdTipoEndereco = null, string DescricaoTipoEndereco = null, string Cep = null, string Logradouro = null, string NumeroEndereco = null, string ComplementoEndereco = null, string Bairro = null, string Cidade = null, string Uf = null, string Pais = null, string SenhaCriptografada = null, string Icvv = null, long? IdStatusImpressao = null)
        {
            this.IdConta = IdConta;
            this.IdPessoa = IdPessoa;
            this.IdCartao = IdCartao;
            this.IdBandeira = IdBandeira;
            this.IdTipoCartao = IdTipoCartao;
            this.NumeroCartao = NumeroCartao;
            this.NomePlastico = NomePlastico;
            this.Cvv2 = Cvv2;
            this.DataGeracao = DataGeracao;
            this.DataValidade = DataValidade;
            this.Cpf = Cpf;
            this.TipoPortador = TipoPortador;
            this.Trilha1 = Trilha1;
            this.Trilha2 = Trilha2;
            this.TrilhaCVV1 = TrilhaCVV1;
            this.TrilhaCVV2 = TrilhaCVV2;
            this.FlagVirtual = FlagVirtual;
            this.NomeBandeira = NomeBandeira;
            this.FlagTitular = FlagTitular;
            this.SequencialCartao = SequencialCartao;
            this.IdStatus = IdStatus;
            this.DescricaoStatusCartao = DescricaoStatusCartao;
            this.DataStatus = DataStatus;
            this.IdEstagio = IdEstagio;
            this.DescricaoEstagio = DescricaoEstagio;
            this.DataEstagio = DataEstagio;
            this.NumeroBin = NumeroBin;
            this.IdProduto = IdProduto;
            this.DescricaoProduto = DescricaoProduto;
            this.IdStatusConta = IdStatusConta;
            this.DescricaoStatusConta = DescricaoStatusConta;
            this.DataEmbossing = DataEmbossing;
            this.CodigoDesbloqueio = CodigoDesbloqueio;
            this.NomePessoa = NomePessoa;
            this.TipoPessoa = TipoPessoa;
            this.DataNascimento = DataNascimento;
            this.IdEndereco = IdEndereco;
            this.IdTipoEndereco = IdTipoEndereco;
            this.DescricaoTipoEndereco = DescricaoTipoEndereco;
            this.Cep = Cep;
            this.Logradouro = Logradouro;
            this.NumeroEndereco = NumeroEndereco;
            this.ComplementoEndereco = ComplementoEndereco;
            this.Bairro = Bairro;
            this.Cidade = Cidade;
            this.Uf = Uf;
            this.Pais = Pais;
            this.SenhaCriptografada = SenhaCriptografada;
            this.Icvv = Icvv;
            this.IdStatusImpressao = IdStatusImpressao;
            
        }
        
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_id_pessoa_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_id_pessoa_value}}}</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_id_cartao_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_id_cartao_value}}}</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_id_bandeira_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_id_bandeira_value}}}</value>
        [DataMember(Name="idBandeira", EmitDefaultValue=false)]
        public long? IdBandeira { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_id_tipo_cartao_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_id_tipo_cartao_value}}}</value>
        [DataMember(Name="idTipoCartao", EmitDefaultValue=false)]
        public long? IdTipoCartao { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_numero_cartao_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_numero_cartao_value}}}</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_nome_plastico_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_nome_plastico_value}}}</value>
        [DataMember(Name="nomePlastico", EmitDefaultValue=false)]
        public string NomePlastico { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_cvv2_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_cvv2_value}}}</value>
        [DataMember(Name="cvv2", EmitDefaultValue=false)]
        public string Cvv2 { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_data_geracao_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_data_geracao_value}}}</value>
        [DataMember(Name="dataGeracao", EmitDefaultValue=false)]
        public string DataGeracao { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_data_validade_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_data_validade_value}}}</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_cpf_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_cpf_value}}}</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_tipo_portador_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_tipo_portador_value}}}</value>
        [DataMember(Name="tipoPortador", EmitDefaultValue=false)]
        public string TipoPortador { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_trilha1_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_trilha1_value}}}</value>
        [DataMember(Name="trilha1", EmitDefaultValue=false)]
        public string Trilha1 { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_trilha2_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_trilha2_value}}}</value>
        [DataMember(Name="trilha2", EmitDefaultValue=false)]
        public string Trilha2 { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_trilha_c_v_v1_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_trilha_c_v_v1_value}}}</value>
        [DataMember(Name="trilhaCVV1", EmitDefaultValue=false)]
        public string TrilhaCVV1 { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_trilha_c_v_v2_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_trilha_c_v_v2_value}}}</value>
        [DataMember(Name="trilhaCVV2", EmitDefaultValue=false)]
        public string TrilhaCVV2 { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_flag_virtual_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_flag_virtual_value}}}</value>
        [DataMember(Name="flagVirtual", EmitDefaultValue=false)]
        public int? FlagVirtual { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_nome_bandeira_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_nome_bandeira_value}}}</value>
        [DataMember(Name="nomeBandeira", EmitDefaultValue=false)]
        public string NomeBandeira { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_flag_titular_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_flag_titular_value}}}</value>
        [DataMember(Name="flagTitular", EmitDefaultValue=false)]
        public int? FlagTitular { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_sequencial_cartao_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_sequencial_cartao_value}}}</value>
        [DataMember(Name="sequencialCartao", EmitDefaultValue=false)]
        public int? SequencialCartao { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_id_status_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_id_status_value}}}</value>
        [DataMember(Name="idStatus", EmitDefaultValue=false)]
        public long? IdStatus { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_descricao_status_cartao_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_descricao_status_cartao_value}}}</value>
        [DataMember(Name="descricaoStatusCartao", EmitDefaultValue=false)]
        public string DescricaoStatusCartao { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_data_status_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_data_status_value}}}</value>
        [DataMember(Name="dataStatus", EmitDefaultValue=false)]
        public string DataStatus { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_id_estagio_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_id_estagio_value}}}</value>
        [DataMember(Name="idEstagio", EmitDefaultValue=false)]
        public long? IdEstagio { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_descricao_estagio_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_descricao_estagio_value}}}</value>
        [DataMember(Name="descricaoEstagio", EmitDefaultValue=false)]
        public string DescricaoEstagio { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_data_estagio_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_data_estagio_value}}}</value>
        [DataMember(Name="dataEstagio", EmitDefaultValue=false)]
        public string DataEstagio { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_numero_bin_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_numero_bin_value}}}</value>
        [DataMember(Name="numeroBin", EmitDefaultValue=false)]
        public string NumeroBin { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_id_produto_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_id_produto_value}}}</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_descricao_produto_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_descricao_produto_value}}}</value>
        [DataMember(Name="descricaoProduto", EmitDefaultValue=false)]
        public string DescricaoProduto { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_id_status_conta_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_id_status_conta_value}}}</value>
        [DataMember(Name="idStatusConta", EmitDefaultValue=false)]
        public long? IdStatusConta { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_descricao_status_conta_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_descricao_status_conta_value}}}</value>
        [DataMember(Name="descricaoStatusConta", EmitDefaultValue=false)]
        public long? DescricaoStatusConta { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_data_embossing_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_data_embossing_value}}}</value>
        [DataMember(Name="dataEmbossing", EmitDefaultValue=false)]
        public string DataEmbossing { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_codigo_desbloqueio_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_codigo_desbloqueio_value}}}</value>
        [DataMember(Name="codigoDesbloqueio", EmitDefaultValue=false)]
        public string CodigoDesbloqueio { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_nome_pessoa_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_nome_pessoa_value}}}</value>
        [DataMember(Name="nomePessoa", EmitDefaultValue=false)]
        public string NomePessoa { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_tipo_pessoa_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_tipo_pessoa_value}}}</value>
        [DataMember(Name="tipoPessoa", EmitDefaultValue=false)]
        public string TipoPessoa { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_data_nascimento_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_data_nascimento_value}}}</value>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        public string DataNascimento { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_id_endereco_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_id_endereco_value}}}</value>
        [DataMember(Name="idEndereco", EmitDefaultValue=false)]
        public long? IdEndereco { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_id_tipo_endereco_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_id_tipo_endereco_value}}}</value>
        [DataMember(Name="idTipoEndereco", EmitDefaultValue=false)]
        public long? IdTipoEndereco { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_descricao_tipo_endereco_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_descricao_tipo_endereco_value}}}</value>
        [DataMember(Name="descricaoTipoEndereco", EmitDefaultValue=false)]
        public string DescricaoTipoEndereco { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_cep_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_cep_value}}}</value>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public string Cep { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_logradouro_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_logradouro_value}}}</value>
        [DataMember(Name="logradouro", EmitDefaultValue=false)]
        public string Logradouro { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_numero_endereco_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_numero_endereco_value}}}</value>
        [DataMember(Name="numeroEndereco", EmitDefaultValue=false)]
        public string NumeroEndereco { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_complemento_endereco_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_complemento_endereco_value}}}</value>
        [DataMember(Name="complementoEndereco", EmitDefaultValue=false)]
        public string ComplementoEndereco { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_bairro_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_bairro_value}}}</value>
        [DataMember(Name="bairro", EmitDefaultValue=false)]
        public string Bairro { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_cidade_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_cidade_value}}}</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_uf_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_uf_value}}}</value>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_pais_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_pais_value}}}</value>
        [DataMember(Name="pais", EmitDefaultValue=false)]
        public string Pais { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_senha_criptografada_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_senha_criptografada_value}}}</value>
        [DataMember(Name="senhaCriptografada", EmitDefaultValue=false)]
        public string SenhaCriptografada { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_icvv_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_icvv_value}}}</value>
        [DataMember(Name="icvv", EmitDefaultValue=false)]
        public string Icvv { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_impressao_response_id_status_impressao_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_impressao_response_id_status_impressao_value}}}</value>
        [DataMember(Name="idStatusImpressao", EmitDefaultValue=false)]
        public long? IdStatusImpressao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DadosCartaoImpressaoResponse {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdBandeira: ").Append(IdBandeira).Append("\n");
            sb.Append("  IdTipoCartao: ").Append(IdTipoCartao).Append("\n");
            sb.Append("  NumeroCartao: ").Append(NumeroCartao).Append("\n");
            sb.Append("  NomePlastico: ").Append(NomePlastico).Append("\n");
            sb.Append("  Cvv2: ").Append(Cvv2).Append("\n");
            sb.Append("  DataGeracao: ").Append(DataGeracao).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  TipoPortador: ").Append(TipoPortador).Append("\n");
            sb.Append("  Trilha1: ").Append(Trilha1).Append("\n");
            sb.Append("  Trilha2: ").Append(Trilha2).Append("\n");
            sb.Append("  TrilhaCVV1: ").Append(TrilhaCVV1).Append("\n");
            sb.Append("  TrilhaCVV2: ").Append(TrilhaCVV2).Append("\n");
            sb.Append("  FlagVirtual: ").Append(FlagVirtual).Append("\n");
            sb.Append("  NomeBandeira: ").Append(NomeBandeira).Append("\n");
            sb.Append("  FlagTitular: ").Append(FlagTitular).Append("\n");
            sb.Append("  SequencialCartao: ").Append(SequencialCartao).Append("\n");
            sb.Append("  IdStatus: ").Append(IdStatus).Append("\n");
            sb.Append("  DescricaoStatusCartao: ").Append(DescricaoStatusCartao).Append("\n");
            sb.Append("  DataStatus: ").Append(DataStatus).Append("\n");
            sb.Append("  IdEstagio: ").Append(IdEstagio).Append("\n");
            sb.Append("  DescricaoEstagio: ").Append(DescricaoEstagio).Append("\n");
            sb.Append("  DataEstagio: ").Append(DataEstagio).Append("\n");
            sb.Append("  NumeroBin: ").Append(NumeroBin).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  DescricaoProduto: ").Append(DescricaoProduto).Append("\n");
            sb.Append("  IdStatusConta: ").Append(IdStatusConta).Append("\n");
            sb.Append("  DescricaoStatusConta: ").Append(DescricaoStatusConta).Append("\n");
            sb.Append("  DataEmbossing: ").Append(DataEmbossing).Append("\n");
            sb.Append("  CodigoDesbloqueio: ").Append(CodigoDesbloqueio).Append("\n");
            sb.Append("  NomePessoa: ").Append(NomePessoa).Append("\n");
            sb.Append("  TipoPessoa: ").Append(TipoPessoa).Append("\n");
            sb.Append("  DataNascimento: ").Append(DataNascimento).Append("\n");
            sb.Append("  IdEndereco: ").Append(IdEndereco).Append("\n");
            sb.Append("  IdTipoEndereco: ").Append(IdTipoEndereco).Append("\n");
            sb.Append("  DescricaoTipoEndereco: ").Append(DescricaoTipoEndereco).Append("\n");
            sb.Append("  Cep: ").Append(Cep).Append("\n");
            sb.Append("  Logradouro: ").Append(Logradouro).Append("\n");
            sb.Append("  NumeroEndereco: ").Append(NumeroEndereco).Append("\n");
            sb.Append("  ComplementoEndereco: ").Append(ComplementoEndereco).Append("\n");
            sb.Append("  Bairro: ").Append(Bairro).Append("\n");
            sb.Append("  Cidade: ").Append(Cidade).Append("\n");
            sb.Append("  Uf: ").Append(Uf).Append("\n");
            sb.Append("  Pais: ").Append(Pais).Append("\n");
            sb.Append("  SenhaCriptografada: ").Append(SenhaCriptografada).Append("\n");
            sb.Append("  Icvv: ").Append(Icvv).Append("\n");
            sb.Append("  IdStatusImpressao: ").Append(IdStatusImpressao).Append("\n");
            
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
            return this.Equals(obj as DadosCartaoImpressaoResponse);
        }

        /// <summary>
        /// Returns true if DadosCartaoImpressaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DadosCartaoImpressaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DadosCartaoImpressaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.IdBandeira == other.IdBandeira ||
                    this.IdBandeira != null &&
                    this.IdBandeira.Equals(other.IdBandeira)
                ) && 
                (
                    this.IdTipoCartao == other.IdTipoCartao ||
                    this.IdTipoCartao != null &&
                    this.IdTipoCartao.Equals(other.IdTipoCartao)
                ) && 
                (
                    this.NumeroCartao == other.NumeroCartao ||
                    this.NumeroCartao != null &&
                    this.NumeroCartao.Equals(other.NumeroCartao)
                ) && 
                (
                    this.NomePlastico == other.NomePlastico ||
                    this.NomePlastico != null &&
                    this.NomePlastico.Equals(other.NomePlastico)
                ) && 
                (
                    this.Cvv2 == other.Cvv2 ||
                    this.Cvv2 != null &&
                    this.Cvv2.Equals(other.Cvv2)
                ) && 
                (
                    this.DataGeracao == other.DataGeracao ||
                    this.DataGeracao != null &&
                    this.DataGeracao.Equals(other.DataGeracao)
                ) && 
                (
                    this.DataValidade == other.DataValidade ||
                    this.DataValidade != null &&
                    this.DataValidade.Equals(other.DataValidade)
                ) && 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
                ) && 
                (
                    this.TipoPortador == other.TipoPortador ||
                    this.TipoPortador != null &&
                    this.TipoPortador.Equals(other.TipoPortador)
                ) && 
                (
                    this.Trilha1 == other.Trilha1 ||
                    this.Trilha1 != null &&
                    this.Trilha1.Equals(other.Trilha1)
                ) && 
                (
                    this.Trilha2 == other.Trilha2 ||
                    this.Trilha2 != null &&
                    this.Trilha2.Equals(other.Trilha2)
                ) && 
                (
                    this.TrilhaCVV1 == other.TrilhaCVV1 ||
                    this.TrilhaCVV1 != null &&
                    this.TrilhaCVV1.Equals(other.TrilhaCVV1)
                ) && 
                (
                    this.TrilhaCVV2 == other.TrilhaCVV2 ||
                    this.TrilhaCVV2 != null &&
                    this.TrilhaCVV2.Equals(other.TrilhaCVV2)
                ) && 
                (
                    this.FlagVirtual == other.FlagVirtual ||
                    this.FlagVirtual != null &&
                    this.FlagVirtual.Equals(other.FlagVirtual)
                ) && 
                (
                    this.NomeBandeira == other.NomeBandeira ||
                    this.NomeBandeira != null &&
                    this.NomeBandeira.Equals(other.NomeBandeira)
                ) && 
                (
                    this.FlagTitular == other.FlagTitular ||
                    this.FlagTitular != null &&
                    this.FlagTitular.Equals(other.FlagTitular)
                ) && 
                (
                    this.SequencialCartao == other.SequencialCartao ||
                    this.SequencialCartao != null &&
                    this.SequencialCartao.Equals(other.SequencialCartao)
                ) && 
                (
                    this.IdStatus == other.IdStatus ||
                    this.IdStatus != null &&
                    this.IdStatus.Equals(other.IdStatus)
                ) && 
                (
                    this.DescricaoStatusCartao == other.DescricaoStatusCartao ||
                    this.DescricaoStatusCartao != null &&
                    this.DescricaoStatusCartao.Equals(other.DescricaoStatusCartao)
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
                    this.DescricaoEstagio == other.DescricaoEstagio ||
                    this.DescricaoEstagio != null &&
                    this.DescricaoEstagio.Equals(other.DescricaoEstagio)
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
                    this.IdStatusConta == other.IdStatusConta ||
                    this.IdStatusConta != null &&
                    this.IdStatusConta.Equals(other.IdStatusConta)
                ) && 
                (
                    this.DescricaoStatusConta == other.DescricaoStatusConta ||
                    this.DescricaoStatusConta != null &&
                    this.DescricaoStatusConta.Equals(other.DescricaoStatusConta)
                ) && 
                (
                    this.DataEmbossing == other.DataEmbossing ||
                    this.DataEmbossing != null &&
                    this.DataEmbossing.Equals(other.DataEmbossing)
                ) && 
                (
                    this.CodigoDesbloqueio == other.CodigoDesbloqueio ||
                    this.CodigoDesbloqueio != null &&
                    this.CodigoDesbloqueio.Equals(other.CodigoDesbloqueio)
                ) && 
                (
                    this.NomePessoa == other.NomePessoa ||
                    this.NomePessoa != null &&
                    this.NomePessoa.Equals(other.NomePessoa)
                ) && 
                (
                    this.TipoPessoa == other.TipoPessoa ||
                    this.TipoPessoa != null &&
                    this.TipoPessoa.Equals(other.TipoPessoa)
                ) && 
                (
                    this.DataNascimento == other.DataNascimento ||
                    this.DataNascimento != null &&
                    this.DataNascimento.Equals(other.DataNascimento)
                ) && 
                (
                    this.IdEndereco == other.IdEndereco ||
                    this.IdEndereco != null &&
                    this.IdEndereco.Equals(other.IdEndereco)
                ) && 
                (
                    this.IdTipoEndereco == other.IdTipoEndereco ||
                    this.IdTipoEndereco != null &&
                    this.IdTipoEndereco.Equals(other.IdTipoEndereco)
                ) && 
                (
                    this.DescricaoTipoEndereco == other.DescricaoTipoEndereco ||
                    this.DescricaoTipoEndereco != null &&
                    this.DescricaoTipoEndereco.Equals(other.DescricaoTipoEndereco)
                ) && 
                (
                    this.Cep == other.Cep ||
                    this.Cep != null &&
                    this.Cep.Equals(other.Cep)
                ) && 
                (
                    this.Logradouro == other.Logradouro ||
                    this.Logradouro != null &&
                    this.Logradouro.Equals(other.Logradouro)
                ) && 
                (
                    this.NumeroEndereco == other.NumeroEndereco ||
                    this.NumeroEndereco != null &&
                    this.NumeroEndereco.Equals(other.NumeroEndereco)
                ) && 
                (
                    this.ComplementoEndereco == other.ComplementoEndereco ||
                    this.ComplementoEndereco != null &&
                    this.ComplementoEndereco.Equals(other.ComplementoEndereco)
                ) && 
                (
                    this.Bairro == other.Bairro ||
                    this.Bairro != null &&
                    this.Bairro.Equals(other.Bairro)
                ) && 
                (
                    this.Cidade == other.Cidade ||
                    this.Cidade != null &&
                    this.Cidade.Equals(other.Cidade)
                ) && 
                (
                    this.Uf == other.Uf ||
                    this.Uf != null &&
                    this.Uf.Equals(other.Uf)
                ) && 
                (
                    this.Pais == other.Pais ||
                    this.Pais != null &&
                    this.Pais.Equals(other.Pais)
                ) && 
                (
                    this.SenhaCriptografada == other.SenhaCriptografada ||
                    this.SenhaCriptografada != null &&
                    this.SenhaCriptografada.Equals(other.SenhaCriptografada)
                ) && 
                (
                    this.Icvv == other.Icvv ||
                    this.Icvv != null &&
                    this.Icvv.Equals(other.Icvv)
                ) && 
                (
                    this.IdStatusImpressao == other.IdStatusImpressao ||
                    this.IdStatusImpressao != null &&
                    this.IdStatusImpressao.Equals(other.IdStatusImpressao)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.IdBandeira != null)
                    hash = hash * 59 + this.IdBandeira.GetHashCode();
                
                if (this.IdTipoCartao != null)
                    hash = hash * 59 + this.IdTipoCartao.GetHashCode();
                
                if (this.NumeroCartao != null)
                    hash = hash * 59 + this.NumeroCartao.GetHashCode();
                
                if (this.NomePlastico != null)
                    hash = hash * 59 + this.NomePlastico.GetHashCode();
                
                if (this.Cvv2 != null)
                    hash = hash * 59 + this.Cvv2.GetHashCode();
                
                if (this.DataGeracao != null)
                    hash = hash * 59 + this.DataGeracao.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                if (this.TipoPortador != null)
                    hash = hash * 59 + this.TipoPortador.GetHashCode();
                
                if (this.Trilha1 != null)
                    hash = hash * 59 + this.Trilha1.GetHashCode();
                
                if (this.Trilha2 != null)
                    hash = hash * 59 + this.Trilha2.GetHashCode();
                
                if (this.TrilhaCVV1 != null)
                    hash = hash * 59 + this.TrilhaCVV1.GetHashCode();
                
                if (this.TrilhaCVV2 != null)
                    hash = hash * 59 + this.TrilhaCVV2.GetHashCode();
                
                if (this.FlagVirtual != null)
                    hash = hash * 59 + this.FlagVirtual.GetHashCode();
                
                if (this.NomeBandeira != null)
                    hash = hash * 59 + this.NomeBandeira.GetHashCode();
                
                if (this.FlagTitular != null)
                    hash = hash * 59 + this.FlagTitular.GetHashCode();
                
                if (this.SequencialCartao != null)
                    hash = hash * 59 + this.SequencialCartao.GetHashCode();
                
                if (this.IdStatus != null)
                    hash = hash * 59 + this.IdStatus.GetHashCode();
                
                if (this.DescricaoStatusCartao != null)
                    hash = hash * 59 + this.DescricaoStatusCartao.GetHashCode();
                
                if (this.DataStatus != null)
                    hash = hash * 59 + this.DataStatus.GetHashCode();
                
                if (this.IdEstagio != null)
                    hash = hash * 59 + this.IdEstagio.GetHashCode();
                
                if (this.DescricaoEstagio != null)
                    hash = hash * 59 + this.DescricaoEstagio.GetHashCode();
                
                if (this.DataEstagio != null)
                    hash = hash * 59 + this.DataEstagio.GetHashCode();
                
                if (this.NumeroBin != null)
                    hash = hash * 59 + this.NumeroBin.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.DescricaoProduto != null)
                    hash = hash * 59 + this.DescricaoProduto.GetHashCode();
                
                if (this.IdStatusConta != null)
                    hash = hash * 59 + this.IdStatusConta.GetHashCode();
                
                if (this.DescricaoStatusConta != null)
                    hash = hash * 59 + this.DescricaoStatusConta.GetHashCode();
                
                if (this.DataEmbossing != null)
                    hash = hash * 59 + this.DataEmbossing.GetHashCode();
                
                if (this.CodigoDesbloqueio != null)
                    hash = hash * 59 + this.CodigoDesbloqueio.GetHashCode();
                
                if (this.NomePessoa != null)
                    hash = hash * 59 + this.NomePessoa.GetHashCode();
                
                if (this.TipoPessoa != null)
                    hash = hash * 59 + this.TipoPessoa.GetHashCode();
                
                if (this.DataNascimento != null)
                    hash = hash * 59 + this.DataNascimento.GetHashCode();
                
                if (this.IdEndereco != null)
                    hash = hash * 59 + this.IdEndereco.GetHashCode();
                
                if (this.IdTipoEndereco != null)
                    hash = hash * 59 + this.IdTipoEndereco.GetHashCode();
                
                if (this.DescricaoTipoEndereco != null)
                    hash = hash * 59 + this.DescricaoTipoEndereco.GetHashCode();
                
                if (this.Cep != null)
                    hash = hash * 59 + this.Cep.GetHashCode();
                
                if (this.Logradouro != null)
                    hash = hash * 59 + this.Logradouro.GetHashCode();
                
                if (this.NumeroEndereco != null)
                    hash = hash * 59 + this.NumeroEndereco.GetHashCode();
                
                if (this.ComplementoEndereco != null)
                    hash = hash * 59 + this.ComplementoEndereco.GetHashCode();
                
                if (this.Bairro != null)
                    hash = hash * 59 + this.Bairro.GetHashCode();
                
                if (this.Cidade != null)
                    hash = hash * 59 + this.Cidade.GetHashCode();
                
                if (this.Uf != null)
                    hash = hash * 59 + this.Uf.GetHashCode();
                
                if (this.Pais != null)
                    hash = hash * 59 + this.Pais.GetHashCode();
                
                if (this.SenhaCriptografada != null)
                    hash = hash * 59 + this.SenhaCriptografada.GetHashCode();
                
                if (this.Icvv != null)
                    hash = hash * 59 + this.Icvv.GetHashCode();
                
                if (this.IdStatusImpressao != null)
                    hash = hash * 59 + this.IdStatusImpressao.GetHashCode();
                
                return hash;
            }
        }

    }
}
