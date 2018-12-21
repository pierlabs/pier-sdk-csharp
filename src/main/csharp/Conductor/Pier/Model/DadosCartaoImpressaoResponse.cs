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
    /// Object Card for printing
    /// </summary>
    [DataContract]
    public partial class DadosCartaoImpressaoResponse :  IEquatable<DadosCartaoImpressaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DadosCartaoImpressaoResponse" /> class.
        /// Initializes a new instance of the <see cref="DadosCartaoImpressaoResponse" />class.
        /// </summary>
        /// <param name="IdConta">The identification code of the account (id) which the card created belongs.</param>
        /// <param name="IdPessoa">Identification Code of the Person (id) cardholder created.</param>
        /// <param name="IdCartao">Identification Code of the Card (id) that was created.</param>
        /// <param name="IdBandeira">Identification Code fo the flag (id) which the card belongs, when it is flagged.</param>
        /// <param name="IdTipoCartao">Identification Code of the Type of Card (id) attributed to the Card.</param>
        /// <param name="NumeroCartao">Card number.</param>
        /// <param name="NomePlastico">Cardholder name.</param>
        /// <param name="Cvv2">The CVV number to ve printed on the Card.</param>
        /// <param name="DataGeracao">Show the issue date of the card.</param>
        /// <param name="DataValidade">Show the expiration date of the card.</param>
        /// <param name="Cpf">The CPF of the Cardholder.</param>
        /// <param name="TipoPortador">Cardholder type, being: (&#39;H&#39;: Holder, &#39;A&#39;: Additional).</param>
        /// <param name="Trilha1">Trail1 dates, following the rules of the issuer trail.</param>
        /// <param name="Trilha2">Trail2 dates, following the rules of the issuer trail.</param>
        /// <param name="TrilhaCVV1">The dates of the trailCVV01, following the rules of the issuer trail.</param>
        /// <param name="TrilhaCVV2">The dates of the TrailCVV02, following the rules of the issuer trail.</param>
        /// <param name="FlagVirtual">The status that informs if the card is virtual.</param>
        /// <param name="NomeBandeira">Flag name.</param>
        /// <param name="FlagTitular">Flag Indicative of Ownership of the Account.</param>
        /// <param name="SequencialCartao">Card Sequence Code.</param>
        /// <param name="IdStatus">Identifier of the Card Status.</param>
        /// <param name="DescricaoStatusCartao">Description of the Card Status.</param>
        /// <param name="DataStatus">Show the date which the current idStatusCard was applied, when there is.</param>
        /// <param name="IdEstagio">Identifier of the Card Stage.</param>
        /// <param name="DescricaoEstagio">Description of the Card Stage.</param>
        /// <param name="DataEstagio">Show the date which the current idStageCard was applied, when there is.</param>
        /// <param name="NumeroBin">Bin number of the Card.</param>
        /// <param name="IdProduto">Identifier of the Product associated to the account.</param>
        /// <param name="DescricaoProduto">Description of the product.</param>
        /// <param name="IdStatusConta">Identifier of the Card Status.</param>
        /// <param name="DescricaoStatusConta">Description of the account status.</param>
        /// <param name="DataEmbossing">Date that the card was embossing.</param>
        /// <param name="CodigoDesbloqueio">Unlock Code of the Card.</param>
        /// <param name="NomePessoa">The &#39;Full name of the PP&#39; or the &#39;Full name of the Social Reason&#39; (Business Name)&#39;.</param>
        /// <param name="TipoPessoa">Identification Code of the Person, being: (&#39;PP&#39;: Physical Person), (&#39;LP&#39;: Legal Person).</param>
        /// <param name="DataNascimento">Birth date of the Person, when it is PP, or the date of the Business Opening, when it is LP.</param>
        /// <param name="IdEndereco">Identifier of Address of the cardholder.</param>
        /// <param name="IdTipoEndereco">Identification Code of the Type of Address (id).</param>
        /// <param name="DescricaoTipoEndereco">Description of the type of address.</param>
        /// <param name="Cep">Zip code in format &#39;58800000&#39;.</param>
        /// <param name="Logradouro">Street Number.</param>
        /// <param name="NumeroEndereco">Address number.</param>
        /// <param name="ComplementoEndereco">Complementary Descriptions refering to the address.</param>
        /// <param name="Bairro">Neighborhood name.</param>
        /// <param name="Cidade">City name.</param>
        /// <param name="Uf">Federal Unity.</param>
        /// <param name="Pais">Country name.</param>
        /// <param name="SenhaCriptografada">Encrypted password.</param>
        /// <param name="Icvv">The number of ICVV of the card.</param>
        /// <param name="IdStatusImpressao">Displays the print status identifier of the card.</param>

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
        /// The identification code of the account (id) which the card created belongs
        /// </summary>
        /// <value>The identification code of the account (id) which the card created belongs</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identification Code of the Person (id) cardholder created
        /// </summary>
        /// <value>Identification Code of the Person (id) cardholder created</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Identification Code of the Card (id) that was created
        /// </summary>
        /// <value>Identification Code of the Card (id) that was created</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Identification Code fo the flag (id) which the card belongs, when it is flagged
        /// </summary>
        /// <value>Identification Code fo the flag (id) which the card belongs, when it is flagged</value>
        [DataMember(Name="idBandeira", EmitDefaultValue=false)]
        public long? IdBandeira { get; set; }
    
        /// <summary>
        /// Identification Code of the Type of Card (id) attributed to the Card
        /// </summary>
        /// <value>Identification Code of the Type of Card (id) attributed to the Card</value>
        [DataMember(Name="idTipoCartao", EmitDefaultValue=false)]
        public long? IdTipoCartao { get; set; }
    
        /// <summary>
        /// Card number
        /// </summary>
        /// <value>Card number</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// Cardholder name
        /// </summary>
        /// <value>Cardholder name</value>
        [DataMember(Name="nomePlastico", EmitDefaultValue=false)]
        public string NomePlastico { get; set; }
    
        /// <summary>
        /// The CVV number to ve printed on the Card
        /// </summary>
        /// <value>The CVV number to ve printed on the Card</value>
        [DataMember(Name="cvv2", EmitDefaultValue=false)]
        public string Cvv2 { get; set; }
    
        /// <summary>
        /// Show the issue date of the card
        /// </summary>
        /// <value>Show the issue date of the card</value>
        [DataMember(Name="dataGeracao", EmitDefaultValue=false)]
        public string DataGeracao { get; set; }
    
        /// <summary>
        /// Show the expiration date of the card
        /// </summary>
        /// <value>Show the expiration date of the card</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// The CPF of the Cardholder
        /// </summary>
        /// <value>The CPF of the Cardholder</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// Cardholder type, being: (&#39;H&#39;: Holder, &#39;A&#39;: Additional)
        /// </summary>
        /// <value>Cardholder type, being: (&#39;H&#39;: Holder, &#39;A&#39;: Additional)</value>
        [DataMember(Name="tipoPortador", EmitDefaultValue=false)]
        public string TipoPortador { get; set; }
    
        /// <summary>
        /// Trail1 dates, following the rules of the issuer trail
        /// </summary>
        /// <value>Trail1 dates, following the rules of the issuer trail</value>
        [DataMember(Name="trilha1", EmitDefaultValue=false)]
        public string Trilha1 { get; set; }
    
        /// <summary>
        /// Trail2 dates, following the rules of the issuer trail
        /// </summary>
        /// <value>Trail2 dates, following the rules of the issuer trail</value>
        [DataMember(Name="trilha2", EmitDefaultValue=false)]
        public string Trilha2 { get; set; }
    
        /// <summary>
        /// The dates of the trailCVV01, following the rules of the issuer trail
        /// </summary>
        /// <value>The dates of the trailCVV01, following the rules of the issuer trail</value>
        [DataMember(Name="trilhaCVV1", EmitDefaultValue=false)]
        public string TrilhaCVV1 { get; set; }
    
        /// <summary>
        /// The dates of the TrailCVV02, following the rules of the issuer trail
        /// </summary>
        /// <value>The dates of the TrailCVV02, following the rules of the issuer trail</value>
        [DataMember(Name="trilhaCVV2", EmitDefaultValue=false)]
        public string TrilhaCVV2 { get; set; }
    
        /// <summary>
        /// The status that informs if the card is virtual
        /// </summary>
        /// <value>The status that informs if the card is virtual</value>
        [DataMember(Name="flagVirtual", EmitDefaultValue=false)]
        public int? FlagVirtual { get; set; }
    
        /// <summary>
        /// Flag name
        /// </summary>
        /// <value>Flag name</value>
        [DataMember(Name="nomeBandeira", EmitDefaultValue=false)]
        public string NomeBandeira { get; set; }
    
        /// <summary>
        /// Flag Indicative of Ownership of the Account
        /// </summary>
        /// <value>Flag Indicative of Ownership of the Account</value>
        [DataMember(Name="flagTitular", EmitDefaultValue=false)]
        public int? FlagTitular { get; set; }
    
        /// <summary>
        /// Card Sequence Code
        /// </summary>
        /// <value>Card Sequence Code</value>
        [DataMember(Name="sequencialCartao", EmitDefaultValue=false)]
        public int? SequencialCartao { get; set; }
    
        /// <summary>
        /// Identifier of the Card Status
        /// </summary>
        /// <value>Identifier of the Card Status</value>
        [DataMember(Name="idStatus", EmitDefaultValue=false)]
        public long? IdStatus { get; set; }
    
        /// <summary>
        /// Description of the Card Status
        /// </summary>
        /// <value>Description of the Card Status</value>
        [DataMember(Name="descricaoStatusCartao", EmitDefaultValue=false)]
        public string DescricaoStatusCartao { get; set; }
    
        /// <summary>
        /// Show the date which the current idStatusCard was applied, when there is
        /// </summary>
        /// <value>Show the date which the current idStatusCard was applied, when there is</value>
        [DataMember(Name="dataStatus", EmitDefaultValue=false)]
        public string DataStatus { get; set; }
    
        /// <summary>
        /// Identifier of the Card Stage
        /// </summary>
        /// <value>Identifier of the Card Stage</value>
        [DataMember(Name="idEstagio", EmitDefaultValue=false)]
        public long? IdEstagio { get; set; }
    
        /// <summary>
        /// Description of the Card Stage
        /// </summary>
        /// <value>Description of the Card Stage</value>
        [DataMember(Name="descricaoEstagio", EmitDefaultValue=false)]
        public string DescricaoEstagio { get; set; }
    
        /// <summary>
        /// Show the date which the current idStageCard was applied, when there is
        /// </summary>
        /// <value>Show the date which the current idStageCard was applied, when there is</value>
        [DataMember(Name="dataEstagio", EmitDefaultValue=false)]
        public string DataEstagio { get; set; }
    
        /// <summary>
        /// Bin number of the Card
        /// </summary>
        /// <value>Bin number of the Card</value>
        [DataMember(Name="numeroBin", EmitDefaultValue=false)]
        public string NumeroBin { get; set; }
    
        /// <summary>
        /// Identifier of the Product associated to the account
        /// </summary>
        /// <value>Identifier of the Product associated to the account</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Description of the product
        /// </summary>
        /// <value>Description of the product</value>
        [DataMember(Name="descricaoProduto", EmitDefaultValue=false)]
        public string DescricaoProduto { get; set; }
    
        /// <summary>
        /// Identifier of the Card Status
        /// </summary>
        /// <value>Identifier of the Card Status</value>
        [DataMember(Name="idStatusConta", EmitDefaultValue=false)]
        public long? IdStatusConta { get; set; }
    
        /// <summary>
        /// Description of the account status
        /// </summary>
        /// <value>Description of the account status</value>
        [DataMember(Name="descricaoStatusConta", EmitDefaultValue=false)]
        public long? DescricaoStatusConta { get; set; }
    
        /// <summary>
        /// Date that the card was embossing
        /// </summary>
        /// <value>Date that the card was embossing</value>
        [DataMember(Name="dataEmbossing", EmitDefaultValue=false)]
        public string DataEmbossing { get; set; }
    
        /// <summary>
        /// Unlock Code of the Card
        /// </summary>
        /// <value>Unlock Code of the Card</value>
        [DataMember(Name="codigoDesbloqueio", EmitDefaultValue=false)]
        public string CodigoDesbloqueio { get; set; }
    
        /// <summary>
        /// The &#39;Full name of the PP&#39; or the &#39;Full name of the Social Reason&#39; (Business Name)&#39;
        /// </summary>
        /// <value>The &#39;Full name of the PP&#39; or the &#39;Full name of the Social Reason&#39; (Business Name)&#39;</value>
        [DataMember(Name="nomePessoa", EmitDefaultValue=false)]
        public string NomePessoa { get; set; }
    
        /// <summary>
        /// Identification Code of the Person, being: (&#39;PP&#39;: Physical Person), (&#39;LP&#39;: Legal Person)
        /// </summary>
        /// <value>Identification Code of the Person, being: (&#39;PP&#39;: Physical Person), (&#39;LP&#39;: Legal Person)</value>
        [DataMember(Name="tipoPessoa", EmitDefaultValue=false)]
        public string TipoPessoa { get; set; }
    
        /// <summary>
        /// Birth date of the Person, when it is PP, or the date of the Business Opening, when it is LP
        /// </summary>
        /// <value>Birth date of the Person, when it is PP, or the date of the Business Opening, when it is LP</value>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        public string DataNascimento { get; set; }
    
        /// <summary>
        /// Identifier of Address of the cardholder
        /// </summary>
        /// <value>Identifier of Address of the cardholder</value>
        [DataMember(Name="idEndereco", EmitDefaultValue=false)]
        public long? IdEndereco { get; set; }
    
        /// <summary>
        /// Identification Code of the Type of Address (id)
        /// </summary>
        /// <value>Identification Code of the Type of Address (id)</value>
        [DataMember(Name="idTipoEndereco", EmitDefaultValue=false)]
        public long? IdTipoEndereco { get; set; }
    
        /// <summary>
        /// Description of the type of address
        /// </summary>
        /// <value>Description of the type of address</value>
        [DataMember(Name="descricaoTipoEndereco", EmitDefaultValue=false)]
        public string DescricaoTipoEndereco { get; set; }
    
        /// <summary>
        /// Zip code in format &#39;58800000&#39;
        /// </summary>
        /// <value>Zip code in format &#39;58800000&#39;</value>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public string Cep { get; set; }
    
        /// <summary>
        /// Street Number
        /// </summary>
        /// <value>Street Number</value>
        [DataMember(Name="logradouro", EmitDefaultValue=false)]
        public string Logradouro { get; set; }
    
        /// <summary>
        /// Address number
        /// </summary>
        /// <value>Address number</value>
        [DataMember(Name="numeroEndereco", EmitDefaultValue=false)]
        public string NumeroEndereco { get; set; }
    
        /// <summary>
        /// Complementary Descriptions refering to the address
        /// </summary>
        /// <value>Complementary Descriptions refering to the address</value>
        [DataMember(Name="complementoEndereco", EmitDefaultValue=false)]
        public string ComplementoEndereco { get; set; }
    
        /// <summary>
        /// Neighborhood name
        /// </summary>
        /// <value>Neighborhood name</value>
        [DataMember(Name="bairro", EmitDefaultValue=false)]
        public string Bairro { get; set; }
    
        /// <summary>
        /// City name
        /// </summary>
        /// <value>City name</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// Federal Unity
        /// </summary>
        /// <value>Federal Unity</value>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }
    
        /// <summary>
        /// Country name
        /// </summary>
        /// <value>Country name</value>
        [DataMember(Name="pais", EmitDefaultValue=false)]
        public string Pais { get; set; }
    
        /// <summary>
        /// Encrypted password
        /// </summary>
        /// <value>Encrypted password</value>
        [DataMember(Name="senhaCriptografada", EmitDefaultValue=false)]
        public string SenhaCriptografada { get; set; }
    
        /// <summary>
        /// The number of ICVV of the card
        /// </summary>
        /// <value>The number of ICVV of the card</value>
        [DataMember(Name="icvv", EmitDefaultValue=false)]
        public string Icvv { get; set; }
    
        /// <summary>
        /// Displays the print status identifier of the card
        /// </summary>
        /// <value>Displays the print status identifier of the card</value>
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
