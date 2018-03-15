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
    /// Objeto Cart\u00E3o para Impresso
    /// </summary>
    [DataContract]
    public partial class DadosCartaoImpressaoResponse :  IEquatable<DadosCartaoImpressaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DadosCartaoImpressaoResponse" /> class.
        /// Initializes a new instance of the <see cref="DadosCartaoImpressaoResponse" />class.
        /// </summary>
        /// <param name="IdConta">O C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id) a qual o cart\u00E3o gerado pertence..</param>
        /// <param name="IdPessoa">O C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) portadora do cart\u00E3o gerado..</param>
        /// <param name="IdCartao">O C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id) que foi gerado..</param>
        /// <param name="IdBandeira">O C\u00F3digo de Identifica\u00E7\u00E3o da Bandeira (id) a qual o Cart\u00E3o pertence, quando bandeirado..</param>
        /// <param name="IdTipoCartao">O C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Cart\u00E3o (id) atribu\u00EDdo ao Cart\u00E3o..</param>
        /// <param name="NumeroCartao">O n\u00FAmero do cart\u00E3o..</param>
        /// <param name="NomePlastico">O nome do Portador do Cart\u00E3o..</param>
        /// <param name="Cvv2">O n\u00FAmero do CVV a ser impresso no Cart\u00E3o.</param>
        /// <param name="DataGeracao">Apresenta a data de emiss\u00E3o do Cart\u00E3o..</param>
        /// <param name="DataValidade">Apresenta a data de Validade do Cart\u00E3o..</param>
        /// <param name="Cpf">O CPF do Portador do Cart\u00E3o..</param>
        /// <param name="TipoPortador">O tipo do Portador do cart\u00E3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional)..</param>
        /// <param name="Trilha1">Os dados da Trilha1, seguindo as regras de trilha do emissor..</param>
        /// <param name="Trilha2">Os dados da Trilha2, seguindo as regras de trilha do emissor..</param>
        /// <param name="TrilhaCVV1">Os dados da TrilhaCVV01, seguindo as regras de trilha do emissor..</param>
        /// <param name="TrilhaCVV2">Os dados da TrilhaCVV02, seguindo as regras de trilha do emissor..</param>
        /// <param name="FlagVirtual">O status que informa se o cart\u00E3o \u00E9 virtual .</param>
        /// <param name="NomeBandeira">Nome da Bandeira.</param>
        /// <param name="FlagTitular">Flag Indicativo de Titularidade da Conta.</param>
        /// <param name="SequencialCartao">C\u00F3digo Sequencial do Cart\u00E3o.</param>
        /// <param name="IdStatus">Identificador do Status do Cart\u00E3o.</param>
        /// <param name="DescricaoStatusCartao">Descri\u00E7\u00E3o do Status do Cart\u00E3o.</param>
        /// <param name="DataStatus">Apresenta a data em que o idStatusCartao atual do cart\u00E3o fora aplicado, quando houver..</param>
        /// <param name="IdEstagio">Identificador do Est\u00E1gio do Cart\u00E3o..</param>
        /// <param name="DescricaoEstagio">Descri\u00E7\u00E3o do Estagio do Cart\u00E3o..</param>
        /// <param name="DataEstagio">Apresenta a data em que o idEstagioCartao atual do cart\u00E3o fora aplicado, quando houver..</param>
        /// <param name="NumeroBin">N\u00FAmero do Bin do Cart\u00E3o.</param>
        /// <param name="IdProduto">Identificador do Produto Associado a Conta.</param>
        /// <param name="DescricaoProduto">Descri\u00E7\u00E3o do produto.</param>
        /// <param name="IdStatusConta">Identificador do Status da Conta.</param>
        /// <param name="DescricaoStatusConta">Descri\u00E7\u00E3o do status da conta.</param>
        /// <param name="DataEmbossing">Data que o cart\u00E3o foi embossado.</param>
        /// <param name="CodigoDesbloqueio">C\u00F3digo de desbloqueio do cart\u00E3o.</param>
        /// <param name="NomePessoa">O &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;..</param>
        /// <param name="TipoPessoa">C\u00F3digo de identifica\u00E7\u00E3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00EDsica), (\&quot;PJ\&quot;: Pessoa Jur\u00EDdica)..</param>
        /// <param name="DataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ..</param>
        /// <param name="IdEndereco">Identificador do Endere\u00E7o do titular do cart\u00E3o.</param>
        /// <param name="IdTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id).</param>
        /// <param name="DescricaoTipoEndereco">Descri\u00E7\u00E3o do Tipo de Endere\u00E7o.</param>
        /// <param name="Cep">O C\u00F3digo de Endere\u00E7amento Postal (CEP) no formaro &#39;58800000&#39;.</param>
        /// <param name="Logradouro">Nome do Logradouro.</param>
        /// <param name="NumeroEndereco">N\u00FAmero do endere\u00E7o.</param>
        /// <param name="ComplementoEndereco">Descri\u00E7oes complementares referente ao endere\u00E7o.</param>
        /// <param name="Bairro">Nome do bairro.</param>
        /// <param name="Cidade">Nome do cidade.</param>
        /// <param name="Uf">Unidade federativa.</param>
        /// <param name="Pais">Nome do pa\u00EDs.</param>
        /// <param name="SenhaCriptografada">Senha Criptografada.</param>

        public DadosCartaoImpressaoResponse(long? IdConta = null, long? IdPessoa = null, long? IdCartao = null, long? IdBandeira = null, long? IdTipoCartao = null, string NumeroCartao = null, string NomePlastico = null, string Cvv2 = null, string DataGeracao = null, string DataValidade = null, string Cpf = null, string TipoPortador = null, string Trilha1 = null, string Trilha2 = null, string TrilhaCVV1 = null, string TrilhaCVV2 = null, int? FlagVirtual = null, string NomeBandeira = null, int? FlagTitular = null, int? SequencialCartao = null, long? IdStatus = null, string DescricaoStatusCartao = null, string DataStatus = null, long? IdEstagio = null, string DescricaoEstagio = null, string DataEstagio = null, string NumeroBin = null, long? IdProduto = null, string DescricaoProduto = null, long? IdStatusConta = null, long? DescricaoStatusConta = null, string DataEmbossing = null, string CodigoDesbloqueio = null, string NomePessoa = null, string TipoPessoa = null, string DataNascimento = null, long? IdEndereco = null, long? IdTipoEndereco = null, string DescricaoTipoEndereco = null, string Cep = null, string Logradouro = null, string NumeroEndereco = null, string ComplementoEndereco = null, string Bairro = null, string Cidade = null, string Uf = null, string Pais = null, string SenhaCriptografada = null)
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
            
        }
        
    
        /// <summary>
        /// O C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id) a qual o cart\u00E3o gerado pertence.
        /// </summary>
        /// <value>O C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id) a qual o cart\u00E3o gerado pertence.</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// O C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) portadora do cart\u00E3o gerado.
        /// </summary>
        /// <value>O C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) portadora do cart\u00E3o gerado.</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// O C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id) que foi gerado.
        /// </summary>
        /// <value>O C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id) que foi gerado.</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// O C\u00F3digo de Identifica\u00E7\u00E3o da Bandeira (id) a qual o Cart\u00E3o pertence, quando bandeirado.
        /// </summary>
        /// <value>O C\u00F3digo de Identifica\u00E7\u00E3o da Bandeira (id) a qual o Cart\u00E3o pertence, quando bandeirado.</value>
        [DataMember(Name="idBandeira", EmitDefaultValue=false)]
        public long? IdBandeira { get; set; }
    
        /// <summary>
        /// O C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Cart\u00E3o (id) atribu\u00EDdo ao Cart\u00E3o.
        /// </summary>
        /// <value>O C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Cart\u00E3o (id) atribu\u00EDdo ao Cart\u00E3o.</value>
        [DataMember(Name="idTipoCartao", EmitDefaultValue=false)]
        public long? IdTipoCartao { get; set; }
    
        /// <summary>
        /// O n\u00FAmero do cart\u00E3o.
        /// </summary>
        /// <value>O n\u00FAmero do cart\u00E3o.</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// O nome do Portador do Cart\u00E3o.
        /// </summary>
        /// <value>O nome do Portador do Cart\u00E3o.</value>
        [DataMember(Name="nomePlastico", EmitDefaultValue=false)]
        public string NomePlastico { get; set; }
    
        /// <summary>
        /// O n\u00FAmero do CVV a ser impresso no Cart\u00E3o
        /// </summary>
        /// <value>O n\u00FAmero do CVV a ser impresso no Cart\u00E3o</value>
        [DataMember(Name="cvv2", EmitDefaultValue=false)]
        public string Cvv2 { get; set; }
    
        /// <summary>
        /// Apresenta a data de emiss\u00E3o do Cart\u00E3o.
        /// </summary>
        /// <value>Apresenta a data de emiss\u00E3o do Cart\u00E3o.</value>
        [DataMember(Name="dataGeracao", EmitDefaultValue=false)]
        public string DataGeracao { get; set; }
    
        /// <summary>
        /// Apresenta a data de Validade do Cart\u00E3o.
        /// </summary>
        /// <value>Apresenta a data de Validade do Cart\u00E3o.</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// O CPF do Portador do Cart\u00E3o.
        /// </summary>
        /// <value>O CPF do Portador do Cart\u00E3o.</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// O tipo do Portador do cart\u00E3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional).
        /// </summary>
        /// <value>O tipo do Portador do cart\u00E3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional).</value>
        [DataMember(Name="tipoPortador", EmitDefaultValue=false)]
        public string TipoPortador { get; set; }
    
        /// <summary>
        /// Os dados da Trilha1, seguindo as regras de trilha do emissor.
        /// </summary>
        /// <value>Os dados da Trilha1, seguindo as regras de trilha do emissor.</value>
        [DataMember(Name="trilha1", EmitDefaultValue=false)]
        public string Trilha1 { get; set; }
    
        /// <summary>
        /// Os dados da Trilha2, seguindo as regras de trilha do emissor.
        /// </summary>
        /// <value>Os dados da Trilha2, seguindo as regras de trilha do emissor.</value>
        [DataMember(Name="trilha2", EmitDefaultValue=false)]
        public string Trilha2 { get; set; }
    
        /// <summary>
        /// Os dados da TrilhaCVV01, seguindo as regras de trilha do emissor.
        /// </summary>
        /// <value>Os dados da TrilhaCVV01, seguindo as regras de trilha do emissor.</value>
        [DataMember(Name="trilhaCVV1", EmitDefaultValue=false)]
        public string TrilhaCVV1 { get; set; }
    
        /// <summary>
        /// Os dados da TrilhaCVV02, seguindo as regras de trilha do emissor.
        /// </summary>
        /// <value>Os dados da TrilhaCVV02, seguindo as regras de trilha do emissor.</value>
        [DataMember(Name="trilhaCVV2", EmitDefaultValue=false)]
        public string TrilhaCVV2 { get; set; }
    
        /// <summary>
        /// O status que informa se o cart\u00E3o \u00E9 virtual 
        /// </summary>
        /// <value>O status que informa se o cart\u00E3o \u00E9 virtual </value>
        [DataMember(Name="flagVirtual", EmitDefaultValue=false)]
        public int? FlagVirtual { get; set; }
    
        /// <summary>
        /// Nome da Bandeira
        /// </summary>
        /// <value>Nome da Bandeira</value>
        [DataMember(Name="nomeBandeira", EmitDefaultValue=false)]
        public string NomeBandeira { get; set; }
    
        /// <summary>
        /// Flag Indicativo de Titularidade da Conta
        /// </summary>
        /// <value>Flag Indicativo de Titularidade da Conta</value>
        [DataMember(Name="flagTitular", EmitDefaultValue=false)]
        public int? FlagTitular { get; set; }
    
        /// <summary>
        /// C\u00F3digo Sequencial do Cart\u00E3o
        /// </summary>
        /// <value>C\u00F3digo Sequencial do Cart\u00E3o</value>
        [DataMember(Name="sequencialCartao", EmitDefaultValue=false)]
        public int? SequencialCartao { get; set; }
    
        /// <summary>
        /// Identificador do Status do Cart\u00E3o
        /// </summary>
        /// <value>Identificador do Status do Cart\u00E3o</value>
        [DataMember(Name="idStatus", EmitDefaultValue=false)]
        public long? IdStatus { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do Status do Cart\u00E3o
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do Status do Cart\u00E3o</value>
        [DataMember(Name="descricaoStatusCartao", EmitDefaultValue=false)]
        public string DescricaoStatusCartao { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o idStatusCartao atual do cart\u00E3o fora aplicado, quando houver.
        /// </summary>
        /// <value>Apresenta a data em que o idStatusCartao atual do cart\u00E3o fora aplicado, quando houver.</value>
        [DataMember(Name="dataStatus", EmitDefaultValue=false)]
        public string DataStatus { get; set; }
    
        /// <summary>
        /// Identificador do Est\u00E1gio do Cart\u00E3o.
        /// </summary>
        /// <value>Identificador do Est\u00E1gio do Cart\u00E3o.</value>
        [DataMember(Name="idEstagio", EmitDefaultValue=false)]
        public long? IdEstagio { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do Estagio do Cart\u00E3o.
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do Estagio do Cart\u00E3o.</value>
        [DataMember(Name="descricaoEstagio", EmitDefaultValue=false)]
        public string DescricaoEstagio { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o idEstagioCartao atual do cart\u00E3o fora aplicado, quando houver.
        /// </summary>
        /// <value>Apresenta a data em que o idEstagioCartao atual do cart\u00E3o fora aplicado, quando houver.</value>
        [DataMember(Name="dataEstagio", EmitDefaultValue=false)]
        public string DataEstagio { get; set; }
    
        /// <summary>
        /// N\u00FAmero do Bin do Cart\u00E3o
        /// </summary>
        /// <value>N\u00FAmero do Bin do Cart\u00E3o</value>
        [DataMember(Name="numeroBin", EmitDefaultValue=false)]
        public string NumeroBin { get; set; }
    
        /// <summary>
        /// Identificador do Produto Associado a Conta
        /// </summary>
        /// <value>Identificador do Produto Associado a Conta</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do produto
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do produto</value>
        [DataMember(Name="descricaoProduto", EmitDefaultValue=false)]
        public string DescricaoProduto { get; set; }
    
        /// <summary>
        /// Identificador do Status da Conta
        /// </summary>
        /// <value>Identificador do Status da Conta</value>
        [DataMember(Name="idStatusConta", EmitDefaultValue=false)]
        public long? IdStatusConta { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do status da conta
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do status da conta</value>
        [DataMember(Name="descricaoStatusConta", EmitDefaultValue=false)]
        public long? DescricaoStatusConta { get; set; }
    
        /// <summary>
        /// Data que o cart\u00E3o foi embossado
        /// </summary>
        /// <value>Data que o cart\u00E3o foi embossado</value>
        [DataMember(Name="dataEmbossing", EmitDefaultValue=false)]
        public string DataEmbossing { get; set; }
    
        /// <summary>
        /// C\u00F3digo de desbloqueio do cart\u00E3o
        /// </summary>
        /// <value>C\u00F3digo de desbloqueio do cart\u00E3o</value>
        [DataMember(Name="codigoDesbloqueio", EmitDefaultValue=false)]
        public string CodigoDesbloqueio { get; set; }
    
        /// <summary>
        /// O &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;.
        /// </summary>
        /// <value>O &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;.</value>
        [DataMember(Name="nomePessoa", EmitDefaultValue=false)]
        public string NomePessoa { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00EDsica), (\&quot;PJ\&quot;: Pessoa Jur\u00EDdica).
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00EDsica), (\&quot;PJ\&quot;: Pessoa Jur\u00EDdica).</value>
        [DataMember(Name="tipoPessoa", EmitDefaultValue=false)]
        public string TipoPessoa { get; set; }
    
        /// <summary>
        /// Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ.
        /// </summary>
        /// <value>Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ.</value>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        public string DataNascimento { get; set; }
    
        /// <summary>
        /// Identificador do Endere\u00E7o do titular do cart\u00E3o
        /// </summary>
        /// <value>Identificador do Endere\u00E7o do titular do cart\u00E3o</value>
        [DataMember(Name="idEndereco", EmitDefaultValue=false)]
        public long? IdEndereco { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id)</value>
        [DataMember(Name="idTipoEndereco", EmitDefaultValue=false)]
        public long? IdTipoEndereco { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do Tipo de Endere\u00E7o
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do Tipo de Endere\u00E7o</value>
        [DataMember(Name="descricaoTipoEndereco", EmitDefaultValue=false)]
        public string DescricaoTipoEndereco { get; set; }
    
        /// <summary>
        /// O C\u00F3digo de Endere\u00E7amento Postal (CEP) no formaro &#39;58800000&#39;
        /// </summary>
        /// <value>O C\u00F3digo de Endere\u00E7amento Postal (CEP) no formaro &#39;58800000&#39;</value>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public string Cep { get; set; }
    
        /// <summary>
        /// Nome do Logradouro
        /// </summary>
        /// <value>Nome do Logradouro</value>
        [DataMember(Name="logradouro", EmitDefaultValue=false)]
        public string Logradouro { get; set; }
    
        /// <summary>
        /// N\u00FAmero do endere\u00E7o
        /// </summary>
        /// <value>N\u00FAmero do endere\u00E7o</value>
        [DataMember(Name="numeroEndereco", EmitDefaultValue=false)]
        public string NumeroEndereco { get; set; }
    
        /// <summary>
        /// Descri\u00E7oes complementares referente ao endere\u00E7o
        /// </summary>
        /// <value>Descri\u00E7oes complementares referente ao endere\u00E7o</value>
        [DataMember(Name="complementoEndereco", EmitDefaultValue=false)]
        public string ComplementoEndereco { get; set; }
    
        /// <summary>
        /// Nome do bairro
        /// </summary>
        /// <value>Nome do bairro</value>
        [DataMember(Name="bairro", EmitDefaultValue=false)]
        public string Bairro { get; set; }
    
        /// <summary>
        /// Nome do cidade
        /// </summary>
        /// <value>Nome do cidade</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// Unidade federativa
        /// </summary>
        /// <value>Unidade federativa</value>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }
    
        /// <summary>
        /// Nome do pa\u00EDs
        /// </summary>
        /// <value>Nome do pa\u00EDs</value>
        [DataMember(Name="pais", EmitDefaultValue=false)]
        public string Pais { get; set; }
    
        /// <summary>
        /// Senha Criptografada
        /// </summary>
        /// <value>Senha Criptografada</value>
        [DataMember(Name="senhaCriptografada", EmitDefaultValue=false)]
        public string SenhaCriptografada { get; set; }
    
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
                
                return hash;
            }
        }

    }
}
