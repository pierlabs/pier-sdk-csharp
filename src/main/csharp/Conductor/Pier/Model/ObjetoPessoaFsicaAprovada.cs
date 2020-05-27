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
    /// 
    /// </summary>
    [DataContract]
    public partial class ObjetoPessoaFsicaAprovada :  IEquatable<ObjetoPessoaFsicaAprovada>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjetoPessoaFsicaAprovada" /> class.
        /// Initializes a new instance of the <see cref="ObjetoPessoaFsicaAprovada" />class.
        /// </summary>
        /// <param name="Nome">Apresenta o nome completo da pessoa fisica (required).</param>
        /// <param name="NomeMae">Apresenta o nome da m\u00E3e da pessoa fisica.</param>
        /// <param name="DataNascimento">Data de Nascimento da Pessoa. Essa data deve ser informada no formato aaaa-MM-dd.</param>
        /// <param name="Sexo">C\u00F3digo de identifica\u00E7\u00E3o do sexo da Pessoa, quando PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: Feminino).</param>
        /// <param name="Cpf">N\u00FAmero do CPF (required).</param>
        /// <param name="NumeroIdentidade">N\u00FAmero da Identidade.</param>
        /// <param name="OrgaoExpedidorIdentidade">Org\u00E3o expedidor do RG.</param>
        /// <param name="UnidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade.</param>
        /// <param name="DataEmissaoIdentidade">Data emiss\u00E3o da identidade no formato aaaa-MM-dd.</param>
        /// <param name="FlagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual.</param>
        /// <param name="IdEstadoCivil">Id Estado civil da pessoa fisica.</param>
        /// <param name="IdProfissao">Profiss\u00E3o da pessoa fisica.</param>
        /// <param name="IdNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica.</param>
        /// <param name="IdNacionalidade">Id Nacionalidade da pessoa fisica.</param>
        /// <param name="IdOrigemComercial">Id da origem comercial (required).</param>
        /// <param name="IdProduto">Id do produto (required).</param>
        /// <param name="NumeroAgencia">N\u00FAmero da ag\u00EAncia.</param>
        /// <param name="NumeroContaCorrente">N\u00FAmero da conta corrente.</param>
        /// <param name="Email">Email da pessoa fisica.</param>
        /// <param name="DiaVencimento">Dia vencimento (required).</param>
        /// <param name="NomeImpresso">Nome que deve ser impresso no cart\u00E3o.</param>
        /// <param name="NomeEmpresa">Nome que deve ser impresso no cart\u00E3o.</param>
        /// <param name="ValorRenda">Apresenta o valor da renda compravada.</param>
        /// <param name="CanalEntrada">Indica o canal pelo qual o cadastro do cliente foi realizado.</param>
        /// <param name="ValorPontuacao">Indica o valor da pontua\u00E7\u00E3o atribuido ao cliente (caso n\u00E3o informado ser\u00E1 atribuido o valor =0).</param>
        /// <param name="Telefones">Apresenta os telefones da empresa (required).</param>
        /// <param name="Enderecos">Pode ser informado os seguintes tipos de endere\u00E7o: Residencial, Comercial, e Outros (required).</param>
        /// <param name="LimiteGlobal">Valor do Limite Global (required).</param>
        /// <param name="LimiteMaximo">Valor m\u00E1ximo do limite de cr\u00E9dito para realizar transa\u00E7\u00F5es (required).</param>
        /// <param name="LimiteParcelas">Valor do limite de cr\u00E9dito acumulado da soma das parcelas das compras (required).</param>
        /// <param name="LimiteConsignado">Valor do limite de margem consignado.</param>
        /// <param name="NomeReferencia1">Nome de refer\u00EAncia 1.</param>
        /// <param name="EnderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1.</param>
        /// <param name="NomeReferencia2">Nome de refer\u00EAncia 2.</param>
        /// <param name="EnderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2.</param>
        /// <param name="ImpedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito (Lei n. 4.595/64).</param>
        /// <param name="FuncaoAtiva">Fun\u00E7\u00E3o ativa da conta. Representa a fun\u00E7\u00E3o na qual a conta encontra-se habilitada. Propriedade s\u00F3 deve ser informada caso o emissor fa\u00E7a uso de fun\u00E7\u00F5es para contas.  As fun\u00E7\u00F5es dispon\u00EDveis para contas podem ser visualizadas em api/contas/tipos-funcoes.</param>
        /// <param name="NaturalidadeCidade">Apresenta o nome da cidade de nascimento.</param>
        /// <param name="NaturalidadeEstado">Apresenta a sigla do estado de nascimento.</param>
        /// <param name="GrauInstrucao">Apresenta o grau de instru\u00E7\u00E3o.</param>
        /// <param name="NumeroDependentes">Apresenta o n\u00FAmero de dependentes.</param>
        /// <param name="NomePai">Apresenta o nome do pai.</param>
        /// <param name="ChequeEspecial">Indica se ir\u00E1 aderir ao cheque especial.</param>
        /// <param name="NumeroBanco">N\u00FAmero do Banco.</param>
        /// <param name="Matricula">N\u00FAmero da matr\u00EDcula.</param>
        /// <param name="ResponsavelDigitacao">Respons\u00E1vel pela digita\u00E7\u00E3o da proposta.</param>
        /// <param name="IdPromotorVenda">C\u00F3digo identificador do promotor de venda.</param>
        /// <param name="LimiteParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para realizar transa\u00E7\u00F5es de compras parceladas.</param>

        public ObjetoPessoaFsicaAprovada(string Nome = null, string NomeMae = null, string DataNascimento = null, string Sexo = null, string Cpf = null, string NumeroIdentidade = null, string OrgaoExpedidorIdentidade = null, string UnidadeFederativaIdentidade = null, string DataEmissaoIdentidade = null, bool? FlagDeficienteVisual = null, long? IdEstadoCivil = null, string IdProfissao = null, long? IdNaturezaOcupacao = null, long? IdNacionalidade = null, long? IdOrigemComercial = null, long? IdProduto = null, int? NumeroAgencia = null, string NumeroContaCorrente = null, string Email = null, int? DiaVencimento = null, string NomeImpresso = null, string NomeEmpresa = null, double? ValorRenda = null, string CanalEntrada = null, int? ValorPontuacao = null, List<TelefonePessoaAprovadaPersist> Telefones = null, List<EnderecoAprovadoPersist> Enderecos = null, double? LimiteGlobal = null, double? LimiteMaximo = null, double? LimiteParcelas = null, double? LimiteConsignado = null, string NomeReferencia1 = null, string EnderecoReferencia1 = null, string NomeReferencia2 = null, string EnderecoReferencia2 = null, bool? ImpedidoFinanciamento = null, string FuncaoAtiva = null, string NaturalidadeCidade = null, string NaturalidadeEstado = null, int? GrauInstrucao = null, int? NumeroDependentes = null, string NomePai = null, int? ChequeEspecial = null, int? NumeroBanco = null, string Matricula = null, string ResponsavelDigitacao = null, int? IdPromotorVenda = null, double? LimiteParcelado = null)
        {
            // to ensure "Nome" is required (not null)
            if (Nome == null)
            {
                throw new InvalidDataException("Nome is a required property for ObjetoPessoaFsicaAprovada and cannot be null");
            }
            else
            {
                this.Nome = Nome;
            }
            // to ensure "Cpf" is required (not null)
            if (Cpf == null)
            {
                throw new InvalidDataException("Cpf is a required property for ObjetoPessoaFsicaAprovada and cannot be null");
            }
            else
            {
                this.Cpf = Cpf;
            }
            // to ensure "IdOrigemComercial" is required (not null)
            if (IdOrigemComercial == null)
            {
                throw new InvalidDataException("IdOrigemComercial is a required property for ObjetoPessoaFsicaAprovada and cannot be null");
            }
            else
            {
                this.IdOrigemComercial = IdOrigemComercial;
            }
            // to ensure "IdProduto" is required (not null)
            if (IdProduto == null)
            {
                throw new InvalidDataException("IdProduto is a required property for ObjetoPessoaFsicaAprovada and cannot be null");
            }
            else
            {
                this.IdProduto = IdProduto;
            }
            // to ensure "DiaVencimento" is required (not null)
            if (DiaVencimento == null)
            {
                throw new InvalidDataException("DiaVencimento is a required property for ObjetoPessoaFsicaAprovada and cannot be null");
            }
            else
            {
                this.DiaVencimento = DiaVencimento;
            }
            // to ensure "Telefones" is required (not null)
            if (Telefones == null)
            {
                throw new InvalidDataException("Telefones is a required property for ObjetoPessoaFsicaAprovada and cannot be null");
            }
            else
            {
                this.Telefones = Telefones;
            }
            // to ensure "Enderecos" is required (not null)
            if (Enderecos == null)
            {
                throw new InvalidDataException("Enderecos is a required property for ObjetoPessoaFsicaAprovada and cannot be null");
            }
            else
            {
                this.Enderecos = Enderecos;
            }
            // to ensure "LimiteGlobal" is required (not null)
            if (LimiteGlobal == null)
            {
                throw new InvalidDataException("LimiteGlobal is a required property for ObjetoPessoaFsicaAprovada and cannot be null");
            }
            else
            {
                this.LimiteGlobal = LimiteGlobal;
            }
            // to ensure "LimiteMaximo" is required (not null)
            if (LimiteMaximo == null)
            {
                throw new InvalidDataException("LimiteMaximo is a required property for ObjetoPessoaFsicaAprovada and cannot be null");
            }
            else
            {
                this.LimiteMaximo = LimiteMaximo;
            }
            // to ensure "LimiteParcelas" is required (not null)
            if (LimiteParcelas == null)
            {
                throw new InvalidDataException("LimiteParcelas is a required property for ObjetoPessoaFsicaAprovada and cannot be null");
            }
            else
            {
                this.LimiteParcelas = LimiteParcelas;
            }
            this.NomeMae = NomeMae;
            this.DataNascimento = DataNascimento;
            this.Sexo = Sexo;
            this.NumeroIdentidade = NumeroIdentidade;
            this.OrgaoExpedidorIdentidade = OrgaoExpedidorIdentidade;
            this.UnidadeFederativaIdentidade = UnidadeFederativaIdentidade;
            this.DataEmissaoIdentidade = DataEmissaoIdentidade;
            this.FlagDeficienteVisual = FlagDeficienteVisual;
            this.IdEstadoCivil = IdEstadoCivil;
            this.IdProfissao = IdProfissao;
            this.IdNaturezaOcupacao = IdNaturezaOcupacao;
            this.IdNacionalidade = IdNacionalidade;
            this.NumeroAgencia = NumeroAgencia;
            this.NumeroContaCorrente = NumeroContaCorrente;
            this.Email = Email;
            this.NomeImpresso = NomeImpresso;
            this.NomeEmpresa = NomeEmpresa;
            this.ValorRenda = ValorRenda;
            this.CanalEntrada = CanalEntrada;
            this.ValorPontuacao = ValorPontuacao;
            this.LimiteConsignado = LimiteConsignado;
            this.NomeReferencia1 = NomeReferencia1;
            this.EnderecoReferencia1 = EnderecoReferencia1;
            this.NomeReferencia2 = NomeReferencia2;
            this.EnderecoReferencia2 = EnderecoReferencia2;
            this.ImpedidoFinanciamento = ImpedidoFinanciamento;
            this.FuncaoAtiva = FuncaoAtiva;
            this.NaturalidadeCidade = NaturalidadeCidade;
            this.NaturalidadeEstado = NaturalidadeEstado;
            this.GrauInstrucao = GrauInstrucao;
            this.NumeroDependentes = NumeroDependentes;
            this.NomePai = NomePai;
            this.ChequeEspecial = ChequeEspecial;
            this.NumeroBanco = NumeroBanco;
            this.Matricula = Matricula;
            this.ResponsavelDigitacao = ResponsavelDigitacao;
            this.IdPromotorVenda = IdPromotorVenda;
            this.LimiteParcelado = LimiteParcelado;
            
        }
        
    
        /// <summary>
        /// Apresenta o nome completo da pessoa fisica
        /// </summary>
        /// <value>Apresenta o nome completo da pessoa fisica</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Apresenta o nome da m\u00E3e da pessoa fisica
        /// </summary>
        /// <value>Apresenta o nome da m\u00E3e da pessoa fisica</value>
        [DataMember(Name="nomeMae", EmitDefaultValue=false)]
        public string NomeMae { get; set; }
    
        /// <summary>
        /// Data de Nascimento da Pessoa. Essa data deve ser informada no formato aaaa-MM-dd
        /// </summary>
        /// <value>Data de Nascimento da Pessoa. Essa data deve ser informada no formato aaaa-MM-dd</value>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        public string DataNascimento { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do sexo da Pessoa, quando PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: Feminino)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do sexo da Pessoa, quando PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: Feminino)</value>
        [DataMember(Name="sexo", EmitDefaultValue=false)]
        public string Sexo { get; set; }
    
        /// <summary>
        /// N\u00FAmero do CPF
        /// </summary>
        /// <value>N\u00FAmero do CPF</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// N\u00FAmero da Identidade
        /// </summary>
        /// <value>N\u00FAmero da Identidade</value>
        [DataMember(Name="numeroIdentidade", EmitDefaultValue=false)]
        public string NumeroIdentidade { get; set; }
    
        /// <summary>
        /// Org\u00E3o expedidor do RG
        /// </summary>
        /// <value>Org\u00E3o expedidor do RG</value>
        [DataMember(Name="orgaoExpedidorIdentidade", EmitDefaultValue=false)]
        public string OrgaoExpedidorIdentidade { get; set; }
    
        /// <summary>
        /// Sigla da Unidade Federativa de onde foi expedido a Identidade
        /// </summary>
        /// <value>Sigla da Unidade Federativa de onde foi expedido a Identidade</value>
        [DataMember(Name="unidadeFederativaIdentidade", EmitDefaultValue=false)]
        public string UnidadeFederativaIdentidade { get; set; }
    
        /// <summary>
        /// Data emiss\u00E3o da identidade no formato aaaa-MM-dd
        /// </summary>
        /// <value>Data emiss\u00E3o da identidade no formato aaaa-MM-dd</value>
        [DataMember(Name="dataEmissaoIdentidade", EmitDefaultValue=false)]
        public string DataEmissaoIdentidade { get; set; }
    
        /// <summary>
        /// Flag que identifica uma pessoa como deficiente visual
        /// </summary>
        /// <value>Flag que identifica uma pessoa como deficiente visual</value>
        [DataMember(Name="flagDeficienteVisual", EmitDefaultValue=false)]
        public bool? FlagDeficienteVisual { get; set; }
    
        /// <summary>
        /// Id Estado civil da pessoa fisica
        /// </summary>
        /// <value>Id Estado civil da pessoa fisica</value>
        [DataMember(Name="idEstadoCivil", EmitDefaultValue=false)]
        public long? IdEstadoCivil { get; set; }
    
        /// <summary>
        /// Profiss\u00E3o da pessoa fisica
        /// </summary>
        /// <value>Profiss\u00E3o da pessoa fisica</value>
        [DataMember(Name="idProfissao", EmitDefaultValue=false)]
        public string IdProfissao { get; set; }
    
        /// <summary>
        /// Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica
        /// </summary>
        /// <value>Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica</value>
        [DataMember(Name="idNaturezaOcupacao", EmitDefaultValue=false)]
        public long? IdNaturezaOcupacao { get; set; }
    
        /// <summary>
        /// Id Nacionalidade da pessoa fisica
        /// </summary>
        /// <value>Id Nacionalidade da pessoa fisica</value>
        [DataMember(Name="idNacionalidade", EmitDefaultValue=false)]
        public long? IdNacionalidade { get; set; }
    
        /// <summary>
        /// Id da origem comercial
        /// </summary>
        /// <value>Id da origem comercial</value>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public long? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// Id do produto
        /// </summary>
        /// <value>Id do produto</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// N\u00FAmero da ag\u00EAncia
        /// </summary>
        /// <value>N\u00FAmero da ag\u00EAncia</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public int? NumeroAgencia { get; set; }
    
        /// <summary>
        /// N\u00FAmero da conta corrente
        /// </summary>
        /// <value>N\u00FAmero da conta corrente</value>
        [DataMember(Name="numeroContaCorrente", EmitDefaultValue=false)]
        public string NumeroContaCorrente { get; set; }
    
        /// <summary>
        /// Email da pessoa fisica
        /// </summary>
        /// <value>Email da pessoa fisica</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Dia vencimento
        /// </summary>
        /// <value>Dia vencimento</value>
        [DataMember(Name="diaVencimento", EmitDefaultValue=false)]
        public int? DiaVencimento { get; set; }
    
        /// <summary>
        /// Nome que deve ser impresso no cart\u00E3o
        /// </summary>
        /// <value>Nome que deve ser impresso no cart\u00E3o</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// Nome que deve ser impresso no cart\u00E3o
        /// </summary>
        /// <value>Nome que deve ser impresso no cart\u00E3o</value>
        [DataMember(Name="nomeEmpresa", EmitDefaultValue=false)]
        public string NomeEmpresa { get; set; }
    
        /// <summary>
        /// Apresenta o valor da renda compravada
        /// </summary>
        /// <value>Apresenta o valor da renda compravada</value>
        [DataMember(Name="valorRenda", EmitDefaultValue=false)]
        public double? ValorRenda { get; set; }
    
        /// <summary>
        /// Indica o canal pelo qual o cadastro do cliente foi realizado
        /// </summary>
        /// <value>Indica o canal pelo qual o cadastro do cliente foi realizado</value>
        [DataMember(Name="canalEntrada", EmitDefaultValue=false)]
        public string CanalEntrada { get; set; }
    
        /// <summary>
        /// Indica o valor da pontua\u00E7\u00E3o atribuido ao cliente (caso n\u00E3o informado ser\u00E1 atribuido o valor =0)
        /// </summary>
        /// <value>Indica o valor da pontua\u00E7\u00E3o atribuido ao cliente (caso n\u00E3o informado ser\u00E1 atribuido o valor =0)</value>
        [DataMember(Name="valorPontuacao", EmitDefaultValue=false)]
        public int? ValorPontuacao { get; set; }
    
        /// <summary>
        /// Apresenta os telefones da empresa
        /// </summary>
        /// <value>Apresenta os telefones da empresa</value>
        [DataMember(Name="telefones", EmitDefaultValue=false)]
        public List<TelefonePessoaAprovadaPersist> Telefones { get; set; }
    
        /// <summary>
        /// Pode ser informado os seguintes tipos de endere\u00E7o: Residencial, Comercial, e Outros
        /// </summary>
        /// <value>Pode ser informado os seguintes tipos de endere\u00E7o: Residencial, Comercial, e Outros</value>
        [DataMember(Name="enderecos", EmitDefaultValue=false)]
        public List<EnderecoAprovadoPersist> Enderecos { get; set; }
    
        /// <summary>
        /// Valor do Limite Global
        /// </summary>
        /// <value>Valor do Limite Global</value>
        [DataMember(Name="limiteGlobal", EmitDefaultValue=false)]
        public double? LimiteGlobal { get; set; }
    
        /// <summary>
        /// Valor m\u00E1ximo do limite de cr\u00E9dito para realizar transa\u00E7\u00F5es
        /// </summary>
        /// <value>Valor m\u00E1ximo do limite de cr\u00E9dito para realizar transa\u00E7\u00F5es</value>
        [DataMember(Name="limiteMaximo", EmitDefaultValue=false)]
        public double? LimiteMaximo { get; set; }
    
        /// <summary>
        /// Valor do limite de cr\u00E9dito acumulado da soma das parcelas das compras
        /// </summary>
        /// <value>Valor do limite de cr\u00E9dito acumulado da soma das parcelas das compras</value>
        [DataMember(Name="limiteParcelas", EmitDefaultValue=false)]
        public double? LimiteParcelas { get; set; }
    
        /// <summary>
        /// Valor do limite de margem consignado
        /// </summary>
        /// <value>Valor do limite de margem consignado</value>
        [DataMember(Name="limiteConsignado", EmitDefaultValue=false)]
        public double? LimiteConsignado { get; set; }
    
        /// <summary>
        /// Nome de refer\u00EAncia 1
        /// </summary>
        /// <value>Nome de refer\u00EAncia 1</value>
        [DataMember(Name="nomeReferencia1", EmitDefaultValue=false)]
        public string NomeReferencia1 { get; set; }
    
        /// <summary>
        /// Endere\u00E7o de refer\u00EAncia 1
        /// </summary>
        /// <value>Endere\u00E7o de refer\u00EAncia 1</value>
        [DataMember(Name="enderecoReferencia1", EmitDefaultValue=false)]
        public string EnderecoReferencia1 { get; set; }
    
        /// <summary>
        /// Nome de refer\u00EAncia 2
        /// </summary>
        /// <value>Nome de refer\u00EAncia 2</value>
        [DataMember(Name="nomeReferencia2", EmitDefaultValue=false)]
        public string NomeReferencia2 { get; set; }
    
        /// <summary>
        /// Endere\u00E7o de refer\u00EAncia 2
        /// </summary>
        /// <value>Endere\u00E7o de refer\u00EAncia 2</value>
        [DataMember(Name="enderecoReferencia2", EmitDefaultValue=false)]
        public string EnderecoReferencia2 { get; set; }
    
        /// <summary>
        /// Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito (Lei n. 4.595/64)
        /// </summary>
        /// <value>Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito (Lei n. 4.595/64)</value>
        [DataMember(Name="impedidoFinanciamento", EmitDefaultValue=false)]
        public bool? ImpedidoFinanciamento { get; set; }
    
        /// <summary>
        /// Fun\u00E7\u00E3o ativa da conta. Representa a fun\u00E7\u00E3o na qual a conta encontra-se habilitada. Propriedade s\u00F3 deve ser informada caso o emissor fa\u00E7a uso de fun\u00E7\u00F5es para contas.  As fun\u00E7\u00F5es dispon\u00EDveis para contas podem ser visualizadas em api/contas/tipos-funcoes
        /// </summary>
        /// <value>Fun\u00E7\u00E3o ativa da conta. Representa a fun\u00E7\u00E3o na qual a conta encontra-se habilitada. Propriedade s\u00F3 deve ser informada caso o emissor fa\u00E7a uso de fun\u00E7\u00F5es para contas.  As fun\u00E7\u00F5es dispon\u00EDveis para contas podem ser visualizadas em api/contas/tipos-funcoes</value>
        [DataMember(Name="funcaoAtiva", EmitDefaultValue=false)]
        public string FuncaoAtiva { get; set; }
    
        /// <summary>
        /// Apresenta o nome da cidade de nascimento
        /// </summary>
        /// <value>Apresenta o nome da cidade de nascimento</value>
        [DataMember(Name="naturalidadeCidade", EmitDefaultValue=false)]
        public string NaturalidadeCidade { get; set; }
    
        /// <summary>
        /// Apresenta a sigla do estado de nascimento
        /// </summary>
        /// <value>Apresenta a sigla do estado de nascimento</value>
        [DataMember(Name="naturalidadeEstado", EmitDefaultValue=false)]
        public string NaturalidadeEstado { get; set; }
    
        /// <summary>
        /// Apresenta o grau de instru\u00E7\u00E3o
        /// </summary>
        /// <value>Apresenta o grau de instru\u00E7\u00E3o</value>
        [DataMember(Name="grauInstrucao", EmitDefaultValue=false)]
        public int? GrauInstrucao { get; set; }
    
        /// <summary>
        /// Apresenta o n\u00FAmero de dependentes
        /// </summary>
        /// <value>Apresenta o n\u00FAmero de dependentes</value>
        [DataMember(Name="numeroDependentes", EmitDefaultValue=false)]
        public int? NumeroDependentes { get; set; }
    
        /// <summary>
        /// Apresenta o nome do pai
        /// </summary>
        /// <value>Apresenta o nome do pai</value>
        [DataMember(Name="nomePai", EmitDefaultValue=false)]
        public string NomePai { get; set; }
    
        /// <summary>
        /// Indica se ir\u00E1 aderir ao cheque especial
        /// </summary>
        /// <value>Indica se ir\u00E1 aderir ao cheque especial</value>
        [DataMember(Name="chequeEspecial", EmitDefaultValue=false)]
        public int? ChequeEspecial { get; set; }
    
        /// <summary>
        /// N\u00FAmero do Banco
        /// </summary>
        /// <value>N\u00FAmero do Banco</value>
        [DataMember(Name="numeroBanco", EmitDefaultValue=false)]
        public int? NumeroBanco { get; set; }
    
        /// <summary>
        /// N\u00FAmero da matr\u00EDcula
        /// </summary>
        /// <value>N\u00FAmero da matr\u00EDcula</value>
        [DataMember(Name="matricula", EmitDefaultValue=false)]
        public string Matricula { get; set; }
    
        /// <summary>
        /// Respons\u00E1vel pela digita\u00E7\u00E3o da proposta
        /// </summary>
        /// <value>Respons\u00E1vel pela digita\u00E7\u00E3o da proposta</value>
        [DataMember(Name="responsavelDigitacao", EmitDefaultValue=false)]
        public string ResponsavelDigitacao { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do promotor de venda
        /// </summary>
        /// <value>C\u00F3digo identificador do promotor de venda</value>
        [DataMember(Name="idPromotorVenda", EmitDefaultValue=false)]
        public int? IdPromotorVenda { get; set; }
    
        /// <summary>
        /// Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para realizar transa\u00E7\u00F5es de compras parceladas
        /// </summary>
        /// <value>Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para realizar transa\u00E7\u00F5es de compras parceladas</value>
        [DataMember(Name="limiteParcelado", EmitDefaultValue=false)]
        public double? LimiteParcelado { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjetoPessoaFsicaAprovada {\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  NomeMae: ").Append(NomeMae).Append("\n");
            sb.Append("  DataNascimento: ").Append(DataNascimento).Append("\n");
            sb.Append("  Sexo: ").Append(Sexo).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  NumeroIdentidade: ").Append(NumeroIdentidade).Append("\n");
            sb.Append("  OrgaoExpedidorIdentidade: ").Append(OrgaoExpedidorIdentidade).Append("\n");
            sb.Append("  UnidadeFederativaIdentidade: ").Append(UnidadeFederativaIdentidade).Append("\n");
            sb.Append("  DataEmissaoIdentidade: ").Append(DataEmissaoIdentidade).Append("\n");
            sb.Append("  FlagDeficienteVisual: ").Append(FlagDeficienteVisual).Append("\n");
            sb.Append("  IdEstadoCivil: ").Append(IdEstadoCivil).Append("\n");
            sb.Append("  IdProfissao: ").Append(IdProfissao).Append("\n");
            sb.Append("  IdNaturezaOcupacao: ").Append(IdNaturezaOcupacao).Append("\n");
            sb.Append("  IdNacionalidade: ").Append(IdNacionalidade).Append("\n");
            sb.Append("  IdOrigemComercial: ").Append(IdOrigemComercial).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  NumeroContaCorrente: ").Append(NumeroContaCorrente).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  DiaVencimento: ").Append(DiaVencimento).Append("\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  NomeEmpresa: ").Append(NomeEmpresa).Append("\n");
            sb.Append("  ValorRenda: ").Append(ValorRenda).Append("\n");
            sb.Append("  CanalEntrada: ").Append(CanalEntrada).Append("\n");
            sb.Append("  ValorPontuacao: ").Append(ValorPontuacao).Append("\n");
            sb.Append("  Telefones: ").Append(Telefones).Append("\n");
            sb.Append("  Enderecos: ").Append(Enderecos).Append("\n");
            sb.Append("  LimiteGlobal: ").Append(LimiteGlobal).Append("\n");
            sb.Append("  LimiteMaximo: ").Append(LimiteMaximo).Append("\n");
            sb.Append("  LimiteParcelas: ").Append(LimiteParcelas).Append("\n");
            sb.Append("  LimiteConsignado: ").Append(LimiteConsignado).Append("\n");
            sb.Append("  NomeReferencia1: ").Append(NomeReferencia1).Append("\n");
            sb.Append("  EnderecoReferencia1: ").Append(EnderecoReferencia1).Append("\n");
            sb.Append("  NomeReferencia2: ").Append(NomeReferencia2).Append("\n");
            sb.Append("  EnderecoReferencia2: ").Append(EnderecoReferencia2).Append("\n");
            sb.Append("  ImpedidoFinanciamento: ").Append(ImpedidoFinanciamento).Append("\n");
            sb.Append("  FuncaoAtiva: ").Append(FuncaoAtiva).Append("\n");
            sb.Append("  NaturalidadeCidade: ").Append(NaturalidadeCidade).Append("\n");
            sb.Append("  NaturalidadeEstado: ").Append(NaturalidadeEstado).Append("\n");
            sb.Append("  GrauInstrucao: ").Append(GrauInstrucao).Append("\n");
            sb.Append("  NumeroDependentes: ").Append(NumeroDependentes).Append("\n");
            sb.Append("  NomePai: ").Append(NomePai).Append("\n");
            sb.Append("  ChequeEspecial: ").Append(ChequeEspecial).Append("\n");
            sb.Append("  NumeroBanco: ").Append(NumeroBanco).Append("\n");
            sb.Append("  Matricula: ").Append(Matricula).Append("\n");
            sb.Append("  ResponsavelDigitacao: ").Append(ResponsavelDigitacao).Append("\n");
            sb.Append("  IdPromotorVenda: ").Append(IdPromotorVenda).Append("\n");
            sb.Append("  LimiteParcelado: ").Append(LimiteParcelado).Append("\n");
            
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
            return this.Equals(obj as ObjetoPessoaFsicaAprovada);
        }

        /// <summary>
        /// Returns true if ObjetoPessoaFsicaAprovada instances are equal
        /// </summary>
        /// <param name="other">Instance of ObjetoPessoaFsicaAprovada to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjetoPessoaFsicaAprovada other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.NomeMae == other.NomeMae ||
                    this.NomeMae != null &&
                    this.NomeMae.Equals(other.NomeMae)
                ) && 
                (
                    this.DataNascimento == other.DataNascimento ||
                    this.DataNascimento != null &&
                    this.DataNascimento.Equals(other.DataNascimento)
                ) && 
                (
                    this.Sexo == other.Sexo ||
                    this.Sexo != null &&
                    this.Sexo.Equals(other.Sexo)
                ) && 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
                ) && 
                (
                    this.NumeroIdentidade == other.NumeroIdentidade ||
                    this.NumeroIdentidade != null &&
                    this.NumeroIdentidade.Equals(other.NumeroIdentidade)
                ) && 
                (
                    this.OrgaoExpedidorIdentidade == other.OrgaoExpedidorIdentidade ||
                    this.OrgaoExpedidorIdentidade != null &&
                    this.OrgaoExpedidorIdentidade.Equals(other.OrgaoExpedidorIdentidade)
                ) && 
                (
                    this.UnidadeFederativaIdentidade == other.UnidadeFederativaIdentidade ||
                    this.UnidadeFederativaIdentidade != null &&
                    this.UnidadeFederativaIdentidade.Equals(other.UnidadeFederativaIdentidade)
                ) && 
                (
                    this.DataEmissaoIdentidade == other.DataEmissaoIdentidade ||
                    this.DataEmissaoIdentidade != null &&
                    this.DataEmissaoIdentidade.Equals(other.DataEmissaoIdentidade)
                ) && 
                (
                    this.FlagDeficienteVisual == other.FlagDeficienteVisual ||
                    this.FlagDeficienteVisual != null &&
                    this.FlagDeficienteVisual.Equals(other.FlagDeficienteVisual)
                ) && 
                (
                    this.IdEstadoCivil == other.IdEstadoCivil ||
                    this.IdEstadoCivil != null &&
                    this.IdEstadoCivil.Equals(other.IdEstadoCivil)
                ) && 
                (
                    this.IdProfissao == other.IdProfissao ||
                    this.IdProfissao != null &&
                    this.IdProfissao.Equals(other.IdProfissao)
                ) && 
                (
                    this.IdNaturezaOcupacao == other.IdNaturezaOcupacao ||
                    this.IdNaturezaOcupacao != null &&
                    this.IdNaturezaOcupacao.Equals(other.IdNaturezaOcupacao)
                ) && 
                (
                    this.IdNacionalidade == other.IdNacionalidade ||
                    this.IdNacionalidade != null &&
                    this.IdNacionalidade.Equals(other.IdNacionalidade)
                ) && 
                (
                    this.IdOrigemComercial == other.IdOrigemComercial ||
                    this.IdOrigemComercial != null &&
                    this.IdOrigemComercial.Equals(other.IdOrigemComercial)
                ) && 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.NumeroAgencia == other.NumeroAgencia ||
                    this.NumeroAgencia != null &&
                    this.NumeroAgencia.Equals(other.NumeroAgencia)
                ) && 
                (
                    this.NumeroContaCorrente == other.NumeroContaCorrente ||
                    this.NumeroContaCorrente != null &&
                    this.NumeroContaCorrente.Equals(other.NumeroContaCorrente)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.DiaVencimento == other.DiaVencimento ||
                    this.DiaVencimento != null &&
                    this.DiaVencimento.Equals(other.DiaVencimento)
                ) && 
                (
                    this.NomeImpresso == other.NomeImpresso ||
                    this.NomeImpresso != null &&
                    this.NomeImpresso.Equals(other.NomeImpresso)
                ) && 
                (
                    this.NomeEmpresa == other.NomeEmpresa ||
                    this.NomeEmpresa != null &&
                    this.NomeEmpresa.Equals(other.NomeEmpresa)
                ) && 
                (
                    this.ValorRenda == other.ValorRenda ||
                    this.ValorRenda != null &&
                    this.ValorRenda.Equals(other.ValorRenda)
                ) && 
                (
                    this.CanalEntrada == other.CanalEntrada ||
                    this.CanalEntrada != null &&
                    this.CanalEntrada.Equals(other.CanalEntrada)
                ) && 
                (
                    this.ValorPontuacao == other.ValorPontuacao ||
                    this.ValorPontuacao != null &&
                    this.ValorPontuacao.Equals(other.ValorPontuacao)
                ) && 
                (
                    this.Telefones == other.Telefones ||
                    this.Telefones != null &&
                    this.Telefones.SequenceEqual(other.Telefones)
                ) && 
                (
                    this.Enderecos == other.Enderecos ||
                    this.Enderecos != null &&
                    this.Enderecos.SequenceEqual(other.Enderecos)
                ) && 
                (
                    this.LimiteGlobal == other.LimiteGlobal ||
                    this.LimiteGlobal != null &&
                    this.LimiteGlobal.Equals(other.LimiteGlobal)
                ) && 
                (
                    this.LimiteMaximo == other.LimiteMaximo ||
                    this.LimiteMaximo != null &&
                    this.LimiteMaximo.Equals(other.LimiteMaximo)
                ) && 
                (
                    this.LimiteParcelas == other.LimiteParcelas ||
                    this.LimiteParcelas != null &&
                    this.LimiteParcelas.Equals(other.LimiteParcelas)
                ) && 
                (
                    this.LimiteConsignado == other.LimiteConsignado ||
                    this.LimiteConsignado != null &&
                    this.LimiteConsignado.Equals(other.LimiteConsignado)
                ) && 
                (
                    this.NomeReferencia1 == other.NomeReferencia1 ||
                    this.NomeReferencia1 != null &&
                    this.NomeReferencia1.Equals(other.NomeReferencia1)
                ) && 
                (
                    this.EnderecoReferencia1 == other.EnderecoReferencia1 ||
                    this.EnderecoReferencia1 != null &&
                    this.EnderecoReferencia1.Equals(other.EnderecoReferencia1)
                ) && 
                (
                    this.NomeReferencia2 == other.NomeReferencia2 ||
                    this.NomeReferencia2 != null &&
                    this.NomeReferencia2.Equals(other.NomeReferencia2)
                ) && 
                (
                    this.EnderecoReferencia2 == other.EnderecoReferencia2 ||
                    this.EnderecoReferencia2 != null &&
                    this.EnderecoReferencia2.Equals(other.EnderecoReferencia2)
                ) && 
                (
                    this.ImpedidoFinanciamento == other.ImpedidoFinanciamento ||
                    this.ImpedidoFinanciamento != null &&
                    this.ImpedidoFinanciamento.Equals(other.ImpedidoFinanciamento)
                ) && 
                (
                    this.FuncaoAtiva == other.FuncaoAtiva ||
                    this.FuncaoAtiva != null &&
                    this.FuncaoAtiva.Equals(other.FuncaoAtiva)
                ) && 
                (
                    this.NaturalidadeCidade == other.NaturalidadeCidade ||
                    this.NaturalidadeCidade != null &&
                    this.NaturalidadeCidade.Equals(other.NaturalidadeCidade)
                ) && 
                (
                    this.NaturalidadeEstado == other.NaturalidadeEstado ||
                    this.NaturalidadeEstado != null &&
                    this.NaturalidadeEstado.Equals(other.NaturalidadeEstado)
                ) && 
                (
                    this.GrauInstrucao == other.GrauInstrucao ||
                    this.GrauInstrucao != null &&
                    this.GrauInstrucao.Equals(other.GrauInstrucao)
                ) && 
                (
                    this.NumeroDependentes == other.NumeroDependentes ||
                    this.NumeroDependentes != null &&
                    this.NumeroDependentes.Equals(other.NumeroDependentes)
                ) && 
                (
                    this.NomePai == other.NomePai ||
                    this.NomePai != null &&
                    this.NomePai.Equals(other.NomePai)
                ) && 
                (
                    this.ChequeEspecial == other.ChequeEspecial ||
                    this.ChequeEspecial != null &&
                    this.ChequeEspecial.Equals(other.ChequeEspecial)
                ) && 
                (
                    this.NumeroBanco == other.NumeroBanco ||
                    this.NumeroBanco != null &&
                    this.NumeroBanco.Equals(other.NumeroBanco)
                ) && 
                (
                    this.Matricula == other.Matricula ||
                    this.Matricula != null &&
                    this.Matricula.Equals(other.Matricula)
                ) && 
                (
                    this.ResponsavelDigitacao == other.ResponsavelDigitacao ||
                    this.ResponsavelDigitacao != null &&
                    this.ResponsavelDigitacao.Equals(other.ResponsavelDigitacao)
                ) && 
                (
                    this.IdPromotorVenda == other.IdPromotorVenda ||
                    this.IdPromotorVenda != null &&
                    this.IdPromotorVenda.Equals(other.IdPromotorVenda)
                ) && 
                (
                    this.LimiteParcelado == other.LimiteParcelado ||
                    this.LimiteParcelado != null &&
                    this.LimiteParcelado.Equals(other.LimiteParcelado)
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
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.NomeMae != null)
                    hash = hash * 59 + this.NomeMae.GetHashCode();
                
                if (this.DataNascimento != null)
                    hash = hash * 59 + this.DataNascimento.GetHashCode();
                
                if (this.Sexo != null)
                    hash = hash * 59 + this.Sexo.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                if (this.NumeroIdentidade != null)
                    hash = hash * 59 + this.NumeroIdentidade.GetHashCode();
                
                if (this.OrgaoExpedidorIdentidade != null)
                    hash = hash * 59 + this.OrgaoExpedidorIdentidade.GetHashCode();
                
                if (this.UnidadeFederativaIdentidade != null)
                    hash = hash * 59 + this.UnidadeFederativaIdentidade.GetHashCode();
                
                if (this.DataEmissaoIdentidade != null)
                    hash = hash * 59 + this.DataEmissaoIdentidade.GetHashCode();
                
                if (this.FlagDeficienteVisual != null)
                    hash = hash * 59 + this.FlagDeficienteVisual.GetHashCode();
                
                if (this.IdEstadoCivil != null)
                    hash = hash * 59 + this.IdEstadoCivil.GetHashCode();
                
                if (this.IdProfissao != null)
                    hash = hash * 59 + this.IdProfissao.GetHashCode();
                
                if (this.IdNaturezaOcupacao != null)
                    hash = hash * 59 + this.IdNaturezaOcupacao.GetHashCode();
                
                if (this.IdNacionalidade != null)
                    hash = hash * 59 + this.IdNacionalidade.GetHashCode();
                
                if (this.IdOrigemComercial != null)
                    hash = hash * 59 + this.IdOrigemComercial.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.NumeroAgencia != null)
                    hash = hash * 59 + this.NumeroAgencia.GetHashCode();
                
                if (this.NumeroContaCorrente != null)
                    hash = hash * 59 + this.NumeroContaCorrente.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.DiaVencimento != null)
                    hash = hash * 59 + this.DiaVencimento.GetHashCode();
                
                if (this.NomeImpresso != null)
                    hash = hash * 59 + this.NomeImpresso.GetHashCode();
                
                if (this.NomeEmpresa != null)
                    hash = hash * 59 + this.NomeEmpresa.GetHashCode();
                
                if (this.ValorRenda != null)
                    hash = hash * 59 + this.ValorRenda.GetHashCode();
                
                if (this.CanalEntrada != null)
                    hash = hash * 59 + this.CanalEntrada.GetHashCode();
                
                if (this.ValorPontuacao != null)
                    hash = hash * 59 + this.ValorPontuacao.GetHashCode();
                
                if (this.Telefones != null)
                    hash = hash * 59 + this.Telefones.GetHashCode();
                
                if (this.Enderecos != null)
                    hash = hash * 59 + this.Enderecos.GetHashCode();
                
                if (this.LimiteGlobal != null)
                    hash = hash * 59 + this.LimiteGlobal.GetHashCode();
                
                if (this.LimiteMaximo != null)
                    hash = hash * 59 + this.LimiteMaximo.GetHashCode();
                
                if (this.LimiteParcelas != null)
                    hash = hash * 59 + this.LimiteParcelas.GetHashCode();
                
                if (this.LimiteConsignado != null)
                    hash = hash * 59 + this.LimiteConsignado.GetHashCode();
                
                if (this.NomeReferencia1 != null)
                    hash = hash * 59 + this.NomeReferencia1.GetHashCode();
                
                if (this.EnderecoReferencia1 != null)
                    hash = hash * 59 + this.EnderecoReferencia1.GetHashCode();
                
                if (this.NomeReferencia2 != null)
                    hash = hash * 59 + this.NomeReferencia2.GetHashCode();
                
                if (this.EnderecoReferencia2 != null)
                    hash = hash * 59 + this.EnderecoReferencia2.GetHashCode();
                
                if (this.ImpedidoFinanciamento != null)
                    hash = hash * 59 + this.ImpedidoFinanciamento.GetHashCode();
                
                if (this.FuncaoAtiva != null)
                    hash = hash * 59 + this.FuncaoAtiva.GetHashCode();
                
                if (this.NaturalidadeCidade != null)
                    hash = hash * 59 + this.NaturalidadeCidade.GetHashCode();
                
                if (this.NaturalidadeEstado != null)
                    hash = hash * 59 + this.NaturalidadeEstado.GetHashCode();
                
                if (this.GrauInstrucao != null)
                    hash = hash * 59 + this.GrauInstrucao.GetHashCode();
                
                if (this.NumeroDependentes != null)
                    hash = hash * 59 + this.NumeroDependentes.GetHashCode();
                
                if (this.NomePai != null)
                    hash = hash * 59 + this.NomePai.GetHashCode();
                
                if (this.ChequeEspecial != null)
                    hash = hash * 59 + this.ChequeEspecial.GetHashCode();
                
                if (this.NumeroBanco != null)
                    hash = hash * 59 + this.NumeroBanco.GetHashCode();
                
                if (this.Matricula != null)
                    hash = hash * 59 + this.Matricula.GetHashCode();
                
                if (this.ResponsavelDigitacao != null)
                    hash = hash * 59 + this.ResponsavelDigitacao.GetHashCode();
                
                if (this.IdPromotorVenda != null)
                    hash = hash * 59 + this.IdPromotorVenda.GetHashCode();
                
                if (this.LimiteParcelado != null)
                    hash = hash * 59 + this.LimiteParcelado.GetHashCode();
                
                return hash;
            }
        }

    }
}
