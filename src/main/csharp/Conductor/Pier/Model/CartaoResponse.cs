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
    /// Objeto Cart\u00E3o
    /// </summary>
    [DataContract]
    public partial class CartaoResponse :  IEquatable<CartaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoResponse" /> class.
        /// Initializes a new instance of the <see cref="CartaoResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o.</param>
        /// <param name="FlagTitular">Apresenta o tipo do Portador do cart\u00E3o, sendo: (1: Titular, 0: Adicional).</param>
        /// <param name="IdPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o cart\u00E3o pertence.</param>
        /// <param name="SequencialCartao">N\u00FAmero sequencial do cart\u00E3o.</param>
        /// <param name="IdConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o cart\u00E3o pertence.</param>
        /// <param name="IdStatus">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Cart\u00E3o.</param>
        /// <param name="DataStatus">Apresenta a data em que o idStatusCartao atual do cart\u00E3o fora aplicado, quando houver.</param>
        /// <param name="IdEstagio">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Impress\u00E3o do Cart\u00E3o.</param>
        /// <param name="DataEstagio">Apresenta a data em que o idEstagio atual do cart\u00E3o fora aplicado, quando houver.</param>
        /// <param name="NumeroBin">N\u00FAmero do bin do cart\u00E3o.</param>
        /// <param name="NumeroCartao">Apresenta o n\u00FAmero do cart\u00E3o.</param>
        /// <param name="NumeroCartaoHash">N\u00FAmero do cart\u00E3o hash.</param>
        /// <param name="NumeroCartaoCriptografado">N\u00FAmero do cart\u00E3o criptografado.</param>
        /// <param name="DataEmissao">Apresenta a data de emiss\u00E3o do cart\u00E3o.</param>
        /// <param name="DataValidade">Apresenta a data de validade do cart\u00E3o em formato yyyy-MM, quando houver.</param>
        /// <param name="CartaoVirtual">Apresenta o status que informa se o cart\u00E3o \u00E9 virtual. Sendo: (1: True, 0: False).</param>
        /// <param name="ImpressaoAvulsa">Quando ativa, indica que o cart\u00E3o fora impresso na Origem Comercial.</param>
        /// <param name="DataImpressao">Apresenta a data em que o cart\u00E3o fora impresso, caso impress\u00E3o em loja, ou a data em que ele fora inclu\u00EDdo no arquivo para impress\u00E3o via gr\u00E1fica.</param>
        /// <param name="NomeArquivoImpressao">Apresenta o nome do arquivo onde o cart\u00E3o fora inclu\u00EDdo para impress\u00E3o por uma gr\u00E1fica, quando houver.</param>
        /// <param name="IdProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto a qual o cart\u00E3o pertence.</param>
        /// <param name="NomeImpresso">Apresenta o nome impresso no cart\u00E3o.</param>
        /// <param name="CodigoDesbloqueio">Apresenta um c\u00F3digo espec\u00EDfico para ser utilizado como vari\u00E1vel no processo de desbloqueio do cart\u00E3o para emissores que querem usar esta funcionalidade.</param>
        /// <param name="TipoPortador">Apresenta o tipo do Portador do cart\u00E3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional).</param>
        /// <param name="IdStatusCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Status do Cart\u00E3o.</param>
        /// <param name="DataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00E3o fora aplicado, quando houver.</param>
        /// <param name="IdEstagioCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Impress\u00E3o do Cart\u00E3o.</param>
        /// <param name="DataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00E3o fora aplicado, quando houver.</param>
        /// <param name="DataGeracao">Apresenta a data em que o cart\u00E3o foi gerado.</param>
        /// <param name="FlagVirtual">Apresenta o status que informa se o cart\u00E3o \u00E9 virtual.</param>
        /// <param name="FlagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00E3o fora impresso na Origem Comercial.</param>
        /// <param name="ArquivoImpressao">Apresenta o nome do arquivo onde o cart\u00E3o fora inclu\u00EDdo para impress\u00E3o por uma gr\u00E1fica, quando houver.</param>
        /// <param name="Portador">Apresenta o n\u00FAmero do portador do cart\u00E3o.</param>
        /// <param name="FlagCartaoMifare">Identifica se o cart\u00E3o cont\u00E9m a tecnologia mifare.</param>
        /// <param name="IdImagem">Apresenta o identificador da cor do cart\u00E3o.</param>

        public CartaoResponse(long? Id = null, int? FlagTitular = null, long? IdPessoa = null, int? SequencialCartao = null, long? IdConta = null, long? IdStatus = null, string DataStatus = null, long? IdEstagio = null, string DataEstagio = null, long? NumeroBin = null, string NumeroCartao = null, long? NumeroCartaoHash = null, string NumeroCartaoCriptografado = null, string DataEmissao = null, string DataValidade = null, int? CartaoVirtual = null, int? ImpressaoAvulsa = null, string DataImpressao = null, string NomeArquivoImpressao = null, long? IdProduto = null, string NomeImpresso = null, string CodigoDesbloqueio = null, string TipoPortador = null, long? IdStatusCartao = null, string DataStatusCartao = null, long? IdEstagioCartao = null, string DataEstagioCartao = null, string DataGeracao = null, int? FlagVirtual = null, int? FlagImpressaoOrigemComercial = null, string ArquivoImpressao = null, int? Portador = null, bool? FlagCartaoMifare = null, long? IdImagem = null)
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
            this.IdProduto = IdProduto;
            this.NomeImpresso = NomeImpresso;
            this.CodigoDesbloqueio = CodigoDesbloqueio;
            this.TipoPortador = TipoPortador;
            this.IdStatusCartao = IdStatusCartao;
            this.DataStatusCartao = DataStatusCartao;
            this.IdEstagioCartao = IdEstagioCartao;
            this.DataEstagioCartao = DataEstagioCartao;
            this.DataGeracao = DataGeracao;
            this.FlagVirtual = FlagVirtual;
            this.FlagImpressaoOrigemComercial = FlagImpressaoOrigemComercial;
            this.ArquivoImpressao = ArquivoImpressao;
            this.Portador = Portador;
            this.FlagCartaoMifare = FlagCartaoMifare;
            this.IdImagem = IdImagem;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Apresenta o tipo do Portador do cart\u00E3o, sendo: (1: Titular, 0: Adicional)
        /// </summary>
        /// <value>Apresenta o tipo do Portador do cart\u00E3o, sendo: (1: Titular, 0: Adicional)</value>
        [DataMember(Name="flagTitular", EmitDefaultValue=false)]
        public int? FlagTitular { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o cart\u00E3o pertence
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o cart\u00E3o pertence</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// N\u00FAmero sequencial do cart\u00E3o
        /// </summary>
        /// <value>N\u00FAmero sequencial do cart\u00E3o</value>
        [DataMember(Name="sequencialCartao", EmitDefaultValue=false)]
        public int? SequencialCartao { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o cart\u00E3o pertence
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o cart\u00E3o pertence</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Status do Cart\u00E3o
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Status do Cart\u00E3o</value>
        [DataMember(Name="idStatus", EmitDefaultValue=false)]
        public long? IdStatus { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o idStatusCartao atual do cart\u00E3o fora aplicado, quando houver
        /// </summary>
        /// <value>Apresenta a data em que o idStatusCartao atual do cart\u00E3o fora aplicado, quando houver</value>
        [DataMember(Name="dataStatus", EmitDefaultValue=false)]
        public string DataStatus { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Impress\u00E3o do Cart\u00E3o
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Impress\u00E3o do Cart\u00E3o</value>
        [DataMember(Name="idEstagio", EmitDefaultValue=false)]
        public long? IdEstagio { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o idEstagio atual do cart\u00E3o fora aplicado, quando houver
        /// </summary>
        /// <value>Apresenta a data em que o idEstagio atual do cart\u00E3o fora aplicado, quando houver</value>
        [DataMember(Name="dataEstagio", EmitDefaultValue=false)]
        public string DataEstagio { get; set; }
    
        /// <summary>
        /// N\u00FAmero do bin do cart\u00E3o
        /// </summary>
        /// <value>N\u00FAmero do bin do cart\u00E3o</value>
        [DataMember(Name="numeroBin", EmitDefaultValue=false)]
        public long? NumeroBin { get; set; }
    
        /// <summary>
        /// Apresenta o n\u00FAmero do cart\u00E3o
        /// </summary>
        /// <value>Apresenta o n\u00FAmero do cart\u00E3o</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// N\u00FAmero do cart\u00E3o hash
        /// </summary>
        /// <value>N\u00FAmero do cart\u00E3o hash</value>
        [DataMember(Name="numeroCartaoHash", EmitDefaultValue=false)]
        public long? NumeroCartaoHash { get; set; }
    
        /// <summary>
        /// N\u00FAmero do cart\u00E3o criptografado
        /// </summary>
        /// <value>N\u00FAmero do cart\u00E3o criptografado</value>
        [DataMember(Name="numeroCartaoCriptografado", EmitDefaultValue=false)]
        public string NumeroCartaoCriptografado { get; set; }
    
        /// <summary>
        /// Apresenta a data de emiss\u00E3o do cart\u00E3o
        /// </summary>
        /// <value>Apresenta a data de emiss\u00E3o do cart\u00E3o</value>
        [DataMember(Name="dataEmissao", EmitDefaultValue=false)]
        public string DataEmissao { get; set; }
    
        /// <summary>
        /// Apresenta a data de validade do cart\u00E3o em formato yyyy-MM, quando houver
        /// </summary>
        /// <value>Apresenta a data de validade do cart\u00E3o em formato yyyy-MM, quando houver</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// Apresenta o status que informa se o cart\u00E3o \u00E9 virtual. Sendo: (1: True, 0: False)
        /// </summary>
        /// <value>Apresenta o status que informa se o cart\u00E3o \u00E9 virtual. Sendo: (1: True, 0: False)</value>
        [DataMember(Name="cartaoVirtual", EmitDefaultValue=false)]
        public int? CartaoVirtual { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que o cart\u00E3o fora impresso na Origem Comercial
        /// </summary>
        /// <value>Quando ativa, indica que o cart\u00E3o fora impresso na Origem Comercial</value>
        [DataMember(Name="impressaoAvulsa", EmitDefaultValue=false)]
        public int? ImpressaoAvulsa { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o cart\u00E3o fora impresso, caso impress\u00E3o em loja, ou a data em que ele fora inclu\u00EDdo no arquivo para impress\u00E3o via gr\u00E1fica
        /// </summary>
        /// <value>Apresenta a data em que o cart\u00E3o fora impresso, caso impress\u00E3o em loja, ou a data em que ele fora inclu\u00EDdo no arquivo para impress\u00E3o via gr\u00E1fica</value>
        [DataMember(Name="dataImpressao", EmitDefaultValue=false)]
        public string DataImpressao { get; set; }
    
        /// <summary>
        /// Apresenta o nome do arquivo onde o cart\u00E3o fora inclu\u00EDdo para impress\u00E3o por uma gr\u00E1fica, quando houver
        /// </summary>
        /// <value>Apresenta o nome do arquivo onde o cart\u00E3o fora inclu\u00EDdo para impress\u00E3o por uma gr\u00E1fica, quando houver</value>
        [DataMember(Name="nomeArquivoImpressao", EmitDefaultValue=false)]
        public string NomeArquivoImpressao { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Produto a qual o cart\u00E3o pertence
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Produto a qual o cart\u00E3o pertence</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Apresenta o nome impresso no cart\u00E3o
        /// </summary>
        /// <value>Apresenta o nome impresso no cart\u00E3o</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// Apresenta um c\u00F3digo espec\u00EDfico para ser utilizado como vari\u00E1vel no processo de desbloqueio do cart\u00E3o para emissores que querem usar esta funcionalidade
        /// </summary>
        /// <value>Apresenta um c\u00F3digo espec\u00EDfico para ser utilizado como vari\u00E1vel no processo de desbloqueio do cart\u00E3o para emissores que querem usar esta funcionalidade</value>
        [DataMember(Name="codigoDesbloqueio", EmitDefaultValue=false)]
        public string CodigoDesbloqueio { get; set; }
    
        /// <summary>
        /// Apresenta o tipo do Portador do cart\u00E3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional)
        /// </summary>
        /// <value>Apresenta o tipo do Portador do cart\u00E3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional)</value>
        [DataMember(Name="tipoPortador", EmitDefaultValue=false)]
        public string TipoPortador { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Status do Cart\u00E3o
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Status do Cart\u00E3o</value>
        [DataMember(Name="idStatusCartao", EmitDefaultValue=false)]
        public long? IdStatusCartao { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o idStatusCartao atual do cart\u00E3o fora aplicado, quando houver
        /// </summary>
        /// <value>Apresenta a data em que o idStatusCartao atual do cart\u00E3o fora aplicado, quando houver</value>
        [DataMember(Name="dataStatusCartao", EmitDefaultValue=false)]
        public string DataStatusCartao { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Impress\u00E3o do Cart\u00E3o
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Est\u00E1gio de Impress\u00E3o do Cart\u00E3o</value>
        [DataMember(Name="idEstagioCartao", EmitDefaultValue=false)]
        public long? IdEstagioCartao { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o idEstagioCartao atual do cart\u00E3o fora aplicado, quando houver
        /// </summary>
        /// <value>Apresenta a data em que o idEstagioCartao atual do cart\u00E3o fora aplicado, quando houver</value>
        [DataMember(Name="dataEstagioCartao", EmitDefaultValue=false)]
        public string DataEstagioCartao { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o cart\u00E3o foi gerado
        /// </summary>
        /// <value>Apresenta a data em que o cart\u00E3o foi gerado</value>
        [DataMember(Name="dataGeracao", EmitDefaultValue=false)]
        public string DataGeracao { get; set; }
    
        /// <summary>
        /// Apresenta o status que informa se o cart\u00E3o \u00E9 virtual
        /// </summary>
        /// <value>Apresenta o status que informa se o cart\u00E3o \u00E9 virtual</value>
        [DataMember(Name="flagVirtual", EmitDefaultValue=false)]
        public int? FlagVirtual { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que o cart\u00E3o fora impresso na Origem Comercial
        /// </summary>
        /// <value>Quando ativa, indica que o cart\u00E3o fora impresso na Origem Comercial</value>
        [DataMember(Name="flagImpressaoOrigemComercial", EmitDefaultValue=false)]
        public int? FlagImpressaoOrigemComercial { get; set; }
    
        /// <summary>
        /// Apresenta o nome do arquivo onde o cart\u00E3o fora inclu\u00EDdo para impress\u00E3o por uma gr\u00E1fica, quando houver
        /// </summary>
        /// <value>Apresenta o nome do arquivo onde o cart\u00E3o fora inclu\u00EDdo para impress\u00E3o por uma gr\u00E1fica, quando houver</value>
        [DataMember(Name="arquivoImpressao", EmitDefaultValue=false)]
        public string ArquivoImpressao { get; set; }
    
        /// <summary>
        /// Apresenta o n\u00FAmero do portador do cart\u00E3o
        /// </summary>
        /// <value>Apresenta o n\u00FAmero do portador do cart\u00E3o</value>
        [DataMember(Name="portador", EmitDefaultValue=false)]
        public int? Portador { get; set; }
    
        /// <summary>
        /// Identifica se o cart\u00E3o cont\u00E9m a tecnologia mifare
        /// </summary>
        /// <value>Identifica se o cart\u00E3o cont\u00E9m a tecnologia mifare</value>
        [DataMember(Name="flagCartaoMifare", EmitDefaultValue=false)]
        public bool? FlagCartaoMifare { get; set; }
    
        /// <summary>
        /// Apresenta o identificador da cor do cart\u00E3o
        /// </summary>
        /// <value>Apresenta o identificador da cor do cart\u00E3o</value>
        [DataMember(Name="idImagem", EmitDefaultValue=false)]
        public long? IdImagem { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoResponse {\n");
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
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  CodigoDesbloqueio: ").Append(CodigoDesbloqueio).Append("\n");
            sb.Append("  TipoPortador: ").Append(TipoPortador).Append("\n");
            sb.Append("  IdStatusCartao: ").Append(IdStatusCartao).Append("\n");
            sb.Append("  DataStatusCartao: ").Append(DataStatusCartao).Append("\n");
            sb.Append("  IdEstagioCartao: ").Append(IdEstagioCartao).Append("\n");
            sb.Append("  DataEstagioCartao: ").Append(DataEstagioCartao).Append("\n");
            sb.Append("  DataGeracao: ").Append(DataGeracao).Append("\n");
            sb.Append("  FlagVirtual: ").Append(FlagVirtual).Append("\n");
            sb.Append("  FlagImpressaoOrigemComercial: ").Append(FlagImpressaoOrigemComercial).Append("\n");
            sb.Append("  ArquivoImpressao: ").Append(ArquivoImpressao).Append("\n");
            sb.Append("  Portador: ").Append(Portador).Append("\n");
            sb.Append("  FlagCartaoMifare: ").Append(FlagCartaoMifare).Append("\n");
            sb.Append("  IdImagem: ").Append(IdImagem).Append("\n");
            
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
            return this.Equals(obj as CartaoResponse);
        }

        /// <summary>
        /// Returns true if CartaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoResponse other)
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
                    this.CodigoDesbloqueio == other.CodigoDesbloqueio ||
                    this.CodigoDesbloqueio != null &&
                    this.CodigoDesbloqueio.Equals(other.CodigoDesbloqueio)
                ) && 
                (
                    this.TipoPortador == other.TipoPortador ||
                    this.TipoPortador != null &&
                    this.TipoPortador.Equals(other.TipoPortador)
                ) && 
                (
                    this.IdStatusCartao == other.IdStatusCartao ||
                    this.IdStatusCartao != null &&
                    this.IdStatusCartao.Equals(other.IdStatusCartao)
                ) && 
                (
                    this.DataStatusCartao == other.DataStatusCartao ||
                    this.DataStatusCartao != null &&
                    this.DataStatusCartao.Equals(other.DataStatusCartao)
                ) && 
                (
                    this.IdEstagioCartao == other.IdEstagioCartao ||
                    this.IdEstagioCartao != null &&
                    this.IdEstagioCartao.Equals(other.IdEstagioCartao)
                ) && 
                (
                    this.DataEstagioCartao == other.DataEstagioCartao ||
                    this.DataEstagioCartao != null &&
                    this.DataEstagioCartao.Equals(other.DataEstagioCartao)
                ) && 
                (
                    this.DataGeracao == other.DataGeracao ||
                    this.DataGeracao != null &&
                    this.DataGeracao.Equals(other.DataGeracao)
                ) && 
                (
                    this.FlagVirtual == other.FlagVirtual ||
                    this.FlagVirtual != null &&
                    this.FlagVirtual.Equals(other.FlagVirtual)
                ) && 
                (
                    this.FlagImpressaoOrigemComercial == other.FlagImpressaoOrigemComercial ||
                    this.FlagImpressaoOrigemComercial != null &&
                    this.FlagImpressaoOrigemComercial.Equals(other.FlagImpressaoOrigemComercial)
                ) && 
                (
                    this.ArquivoImpressao == other.ArquivoImpressao ||
                    this.ArquivoImpressao != null &&
                    this.ArquivoImpressao.Equals(other.ArquivoImpressao)
                ) && 
                (
                    this.Portador == other.Portador ||
                    this.Portador != null &&
                    this.Portador.Equals(other.Portador)
                ) && 
                (
                    this.FlagCartaoMifare == other.FlagCartaoMifare ||
                    this.FlagCartaoMifare != null &&
                    this.FlagCartaoMifare.Equals(other.FlagCartaoMifare)
                ) && 
                (
                    this.IdImagem == other.IdImagem ||
                    this.IdImagem != null &&
                    this.IdImagem.Equals(other.IdImagem)
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
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.NomeImpresso != null)
                    hash = hash * 59 + this.NomeImpresso.GetHashCode();
                
                if (this.CodigoDesbloqueio != null)
                    hash = hash * 59 + this.CodigoDesbloqueio.GetHashCode();
                
                if (this.TipoPortador != null)
                    hash = hash * 59 + this.TipoPortador.GetHashCode();
                
                if (this.IdStatusCartao != null)
                    hash = hash * 59 + this.IdStatusCartao.GetHashCode();
                
                if (this.DataStatusCartao != null)
                    hash = hash * 59 + this.DataStatusCartao.GetHashCode();
                
                if (this.IdEstagioCartao != null)
                    hash = hash * 59 + this.IdEstagioCartao.GetHashCode();
                
                if (this.DataEstagioCartao != null)
                    hash = hash * 59 + this.DataEstagioCartao.GetHashCode();
                
                if (this.DataGeracao != null)
                    hash = hash * 59 + this.DataGeracao.GetHashCode();
                
                if (this.FlagVirtual != null)
                    hash = hash * 59 + this.FlagVirtual.GetHashCode();
                
                if (this.FlagImpressaoOrigemComercial != null)
                    hash = hash * 59 + this.FlagImpressaoOrigemComercial.GetHashCode();
                
                if (this.ArquivoImpressao != null)
                    hash = hash * 59 + this.ArquivoImpressao.GetHashCode();
                
                if (this.Portador != null)
                    hash = hash * 59 + this.Portador.GetHashCode();
                
                if (this.FlagCartaoMifare != null)
                    hash = hash * 59 + this.FlagCartaoMifare.GetHashCode();
                
                if (this.IdImagem != null)
                    hash = hash * 59 + this.IdImagem.GetHashCode();
                
                return hash;
            }
        }

    }
}
