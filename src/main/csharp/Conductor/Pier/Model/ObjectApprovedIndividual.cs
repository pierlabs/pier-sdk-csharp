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
    public partial class ObjectApprovedIndividual :  IEquatable<ObjectApprovedIndividual>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectApprovedIndividual" /> class.
        /// Initializes a new instance of the <see cref="ObjectApprovedIndividual" />class.
        /// </summary>
        /// <param name="Nome">Show the full name of the physical person (required).</param>
        /// <param name="NomeMae">Show the name of the mother of physical person.</param>
        /// <param name="DataNascimento">Birth date of the Person. This date must be informed in the format yyyy-MM-dd.</param>
        /// <param name="Sexo">Code of identification of the sex of the Person, when PF, being: (&#39;M&#39;: Male), (&#39;F&#39;: Female).</param>
        /// <param name="Cpf">CPF number (required).</param>
        /// <param name="NumeroIdentidade">Identity Number.</param>
        /// <param name="OrgaoExpedidorIdentidade">Issuer organ of the ID.</param>
        /// <param name="UnidadeFederativaIdentidade">Acronym of the federal unity where it was issued the ID.</param>
        /// <param name="DataEmissaoIdentidade">Issue date of the identity in the format yyyy-MM-dd.</param>
        /// <param name="IdEstadoCivil">Id Marital Status of the Physical Person.</param>
        /// <param name="IdProfissao">Occupation of the physical person.</param>
        /// <param name="IdNaturezaOcupacao">Id Occupation of the physical person.</param>
        /// <param name="IdNacionalidade">Id Nationality of the physical person.</param>
        /// <param name="IdOrigemComercial">Id of the commercial origin (required).</param>
        /// <param name="IdProduto">Id of the product (required).</param>
        /// <param name="NumeroAgencia">Agency number.</param>
        /// <param name="NumeroContaCorrente">Current Account Number.</param>
        /// <param name="Email">Email of the physical Person.</param>
        /// <param name="DiaVencimento">Expiration date (required).</param>
        /// <param name="NomeImpresso">Name that must be printed on the card.</param>
        /// <param name="NomeEmpresa">Name that must be printed on the card.</param>
        /// <param name="ValorRenda">Show the proven income value.</param>
        /// <param name="CanalEntrada">Indicate the channel which the client register was made.</param>
        /// <param name="ValorPontuacao">Indicate the value of the punctuation attributed to the client (case it is not informed it will be attributed the value =0).</param>
        /// <param name="Telefones">Show the telephones of the company (required).</param>
        /// <param name="Enderecos">It can be informed the following types of address: Residencial, Commerical and Others (required).</param>
        /// <param name="LimiteGlobal">Value of the Global Limit (required).</param>
        /// <param name="LimiteMaximo">Maximum value of the credit limit to make transactions (required).</param>
        /// <param name="LimiteParcelas">Valor do limite de cr?dito acumulado da soma das parcelas das compras (required).</param>
        /// <param name="LimiteConsignado">Value of the consigned margin limit.</param>
        /// <param name="NomeReferencia1">Name Reference 1.</param>
        /// <param name="EnderecoReferencia1">Reference Address 1.</param>
        /// <param name="NomeReferencia2">Name Reference 2.</param>
        /// <param name="EnderecoReferencia2">Reference Address 2.</param>
        /// <param name="ImpedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64) .</param>
        /// <param name="FuncaoAtiva">Active account function. Represents the function in which the account is enabled. Property should only be reported if the issuer makes use of account functions. The functions available for the accounts can be viewed in api/contas/tipos-funcoes.</param>
        /// <param name="NaturalidadeCidade">Displays the name of the birth city.</param>
        /// <param name="NaturalidadeEstado">Presents the acronym of the person&#39;s state of birth.</param>
        /// <param name="GrauInstrucao">It shows the degree of instruction.</param>
        /// <param name="NumeroDependentes">Displays the number of dependents.</param>
        /// <param name="NomePai">Displays the name of the parent.</param>
        /// <param name="ChequeEspecial">Indicates whether you will join the overdraft.</param>
        /// <param name="NumeroBanco">Bank Number.</param>
        /// <param name="Matricula">License Plate Number.</param>
        /// <param name="ResponsavelDigitacao">Responsible for typing the proposal.</param>
        /// <param name="IdPromotorVenda">Sale promoter identification code.</param>

        public ObjectApprovedIndividual(string Nome = null, string NomeMae = null, string DataNascimento = null, string Sexo = null, string Cpf = null, string NumeroIdentidade = null, string OrgaoExpedidorIdentidade = null, string UnidadeFederativaIdentidade = null, string DataEmissaoIdentidade = null, long? IdEstadoCivil = null, string IdProfissao = null, long? IdNaturezaOcupacao = null, long? IdNacionalidade = null, long? IdOrigemComercial = null, long? IdProduto = null, int? NumeroAgencia = null, string NumeroContaCorrente = null, string Email = null, int? DiaVencimento = null, string NomeImpresso = null, string NomeEmpresa = null, double? ValorRenda = null, string CanalEntrada = null, int? ValorPontuacao = null, List<TelephonePersonApprovedPersist> Telefones = null, List<ObjectAddressApproved> Enderecos = null, double? LimiteGlobal = null, double? LimiteMaximo = null, double? LimiteParcelas = null, double? LimiteConsignado = null, string NomeReferencia1 = null, string EnderecoReferencia1 = null, string NomeReferencia2 = null, string EnderecoReferencia2 = null, bool? ImpedidoFinanciamento = null, string FuncaoAtiva = null, string NaturalidadeCidade = null, string NaturalidadeEstado = null, int? GrauInstrucao = null, int? NumeroDependentes = null, string NomePai = null, int? ChequeEspecial = null, int? NumeroBanco = null, string Matricula = null, string ResponsavelDigitacao = null, int? IdPromotorVenda = null)
        {
            // to ensure "Nome" is required (not null)
            if (Nome == null)
            {
                throw new InvalidDataException("Nome is a required property for ObjectApprovedIndividual and cannot be null");
            }
            else
            {
                this.Nome = Nome;
            }
            // to ensure "Cpf" is required (not null)
            if (Cpf == null)
            {
                throw new InvalidDataException("Cpf is a required property for ObjectApprovedIndividual and cannot be null");
            }
            else
            {
                this.Cpf = Cpf;
            }
            // to ensure "IdOrigemComercial" is required (not null)
            if (IdOrigemComercial == null)
            {
                throw new InvalidDataException("IdOrigemComercial is a required property for ObjectApprovedIndividual and cannot be null");
            }
            else
            {
                this.IdOrigemComercial = IdOrigemComercial;
            }
            // to ensure "IdProduto" is required (not null)
            if (IdProduto == null)
            {
                throw new InvalidDataException("IdProduto is a required property for ObjectApprovedIndividual and cannot be null");
            }
            else
            {
                this.IdProduto = IdProduto;
            }
            // to ensure "DiaVencimento" is required (not null)
            if (DiaVencimento == null)
            {
                throw new InvalidDataException("DiaVencimento is a required property for ObjectApprovedIndividual and cannot be null");
            }
            else
            {
                this.DiaVencimento = DiaVencimento;
            }
            // to ensure "Telefones" is required (not null)
            if (Telefones == null)
            {
                throw new InvalidDataException("Telefones is a required property for ObjectApprovedIndividual and cannot be null");
            }
            else
            {
                this.Telefones = Telefones;
            }
            // to ensure "Enderecos" is required (not null)
            if (Enderecos == null)
            {
                throw new InvalidDataException("Enderecos is a required property for ObjectApprovedIndividual and cannot be null");
            }
            else
            {
                this.Enderecos = Enderecos;
            }
            // to ensure "LimiteGlobal" is required (not null)
            if (LimiteGlobal == null)
            {
                throw new InvalidDataException("LimiteGlobal is a required property for ObjectApprovedIndividual and cannot be null");
            }
            else
            {
                this.LimiteGlobal = LimiteGlobal;
            }
            // to ensure "LimiteMaximo" is required (not null)
            if (LimiteMaximo == null)
            {
                throw new InvalidDataException("LimiteMaximo is a required property for ObjectApprovedIndividual and cannot be null");
            }
            else
            {
                this.LimiteMaximo = LimiteMaximo;
            }
            // to ensure "LimiteParcelas" is required (not null)
            if (LimiteParcelas == null)
            {
                throw new InvalidDataException("LimiteParcelas is a required property for ObjectApprovedIndividual and cannot be null");
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
            
        }
        
    
        /// <summary>
        /// Show the full name of the physical person
        /// </summary>
        /// <value>Show the full name of the physical person</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Show the name of the mother of physical person
        /// </summary>
        /// <value>Show the name of the mother of physical person</value>
        [DataMember(Name="nomeMae", EmitDefaultValue=false)]
        public string NomeMae { get; set; }
    
        /// <summary>
        /// Birth date of the Person. This date must be informed in the format yyyy-MM-dd
        /// </summary>
        /// <value>Birth date of the Person. This date must be informed in the format yyyy-MM-dd</value>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        public string DataNascimento { get; set; }
    
        /// <summary>
        /// Code of identification of the sex of the Person, when PF, being: (&#39;M&#39;: Male), (&#39;F&#39;: Female)
        /// </summary>
        /// <value>Code of identification of the sex of the Person, when PF, being: (&#39;M&#39;: Male), (&#39;F&#39;: Female)</value>
        [DataMember(Name="sexo", EmitDefaultValue=false)]
        public string Sexo { get; set; }
    
        /// <summary>
        /// CPF number
        /// </summary>
        /// <value>CPF number</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// Identity Number
        /// </summary>
        /// <value>Identity Number</value>
        [DataMember(Name="numeroIdentidade", EmitDefaultValue=false)]
        public string NumeroIdentidade { get; set; }
    
        /// <summary>
        /// Issuer organ of the ID
        /// </summary>
        /// <value>Issuer organ of the ID</value>
        [DataMember(Name="orgaoExpedidorIdentidade", EmitDefaultValue=false)]
        public string OrgaoExpedidorIdentidade { get; set; }
    
        /// <summary>
        /// Acronym of the federal unity where it was issued the ID
        /// </summary>
        /// <value>Acronym of the federal unity where it was issued the ID</value>
        [DataMember(Name="unidadeFederativaIdentidade", EmitDefaultValue=false)]
        public string UnidadeFederativaIdentidade { get; set; }
    
        /// <summary>
        /// Issue date of the identity in the format yyyy-MM-dd
        /// </summary>
        /// <value>Issue date of the identity in the format yyyy-MM-dd</value>
        [DataMember(Name="dataEmissaoIdentidade", EmitDefaultValue=false)]
        public string DataEmissaoIdentidade { get; set; }
    
        /// <summary>
        /// Id Marital Status of the Physical Person
        /// </summary>
        /// <value>Id Marital Status of the Physical Person</value>
        [DataMember(Name="idEstadoCivil", EmitDefaultValue=false)]
        public long? IdEstadoCivil { get; set; }
    
        /// <summary>
        /// Occupation of the physical person
        /// </summary>
        /// <value>Occupation of the physical person</value>
        [DataMember(Name="idProfissao", EmitDefaultValue=false)]
        public string IdProfissao { get; set; }
    
        /// <summary>
        /// Id Occupation of the physical person
        /// </summary>
        /// <value>Id Occupation of the physical person</value>
        [DataMember(Name="idNaturezaOcupacao", EmitDefaultValue=false)]
        public long? IdNaturezaOcupacao { get; set; }
    
        /// <summary>
        /// Id Nationality of the physical person
        /// </summary>
        /// <value>Id Nationality of the physical person</value>
        [DataMember(Name="idNacionalidade", EmitDefaultValue=false)]
        public long? IdNacionalidade { get; set; }
    
        /// <summary>
        /// Id of the commercial origin
        /// </summary>
        /// <value>Id of the commercial origin</value>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public long? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// Id of the product
        /// </summary>
        /// <value>Id of the product</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Agency number
        /// </summary>
        /// <value>Agency number</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public int? NumeroAgencia { get; set; }
    
        /// <summary>
        /// Current Account Number
        /// </summary>
        /// <value>Current Account Number</value>
        [DataMember(Name="numeroContaCorrente", EmitDefaultValue=false)]
        public string NumeroContaCorrente { get; set; }
    
        /// <summary>
        /// Email of the physical Person
        /// </summary>
        /// <value>Email of the physical Person</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Expiration date
        /// </summary>
        /// <value>Expiration date</value>
        [DataMember(Name="diaVencimento", EmitDefaultValue=false)]
        public int? DiaVencimento { get; set; }
    
        /// <summary>
        /// Name that must be printed on the card
        /// </summary>
        /// <value>Name that must be printed on the card</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// Name that must be printed on the card
        /// </summary>
        /// <value>Name that must be printed on the card</value>
        [DataMember(Name="nomeEmpresa", EmitDefaultValue=false)]
        public string NomeEmpresa { get; set; }
    
        /// <summary>
        /// Show the proven income value
        /// </summary>
        /// <value>Show the proven income value</value>
        [DataMember(Name="valorRenda", EmitDefaultValue=false)]
        public double? ValorRenda { get; set; }
    
        /// <summary>
        /// Indicate the channel which the client register was made
        /// </summary>
        /// <value>Indicate the channel which the client register was made</value>
        [DataMember(Name="canalEntrada", EmitDefaultValue=false)]
        public string CanalEntrada { get; set; }
    
        /// <summary>
        /// Indicate the value of the punctuation attributed to the client (case it is not informed it will be attributed the value =0)
        /// </summary>
        /// <value>Indicate the value of the punctuation attributed to the client (case it is not informed it will be attributed the value =0)</value>
        [DataMember(Name="valorPontuacao", EmitDefaultValue=false)]
        public int? ValorPontuacao { get; set; }
    
        /// <summary>
        /// Show the telephones of the company
        /// </summary>
        /// <value>Show the telephones of the company</value>
        [DataMember(Name="telefones", EmitDefaultValue=false)]
        public List<TelephonePersonApprovedPersist> Telefones { get; set; }
    
        /// <summary>
        /// It can be informed the following types of address: Residencial, Commerical and Others
        /// </summary>
        /// <value>It can be informed the following types of address: Residencial, Commerical and Others</value>
        [DataMember(Name="enderecos", EmitDefaultValue=false)]
        public List<ObjectAddressApproved> Enderecos { get; set; }
    
        /// <summary>
        /// Value of the Global Limit
        /// </summary>
        /// <value>Value of the Global Limit</value>
        [DataMember(Name="limiteGlobal", EmitDefaultValue=false)]
        public double? LimiteGlobal { get; set; }
    
        /// <summary>
        /// Maximum value of the credit limit to make transactions
        /// </summary>
        /// <value>Maximum value of the credit limit to make transactions</value>
        [DataMember(Name="limiteMaximo", EmitDefaultValue=false)]
        public double? LimiteMaximo { get; set; }
    
        /// <summary>
        /// Valor do limite de cr?dito acumulado da soma das parcelas das compras
        /// </summary>
        /// <value>Valor do limite de cr?dito acumulado da soma das parcelas das compras</value>
        [DataMember(Name="limiteParcelas", EmitDefaultValue=false)]
        public double? LimiteParcelas { get; set; }
    
        /// <summary>
        /// Value of the consigned margin limit
        /// </summary>
        /// <value>Value of the consigned margin limit</value>
        [DataMember(Name="limiteConsignado", EmitDefaultValue=false)]
        public double? LimiteConsignado { get; set; }
    
        /// <summary>
        /// Name Reference 1
        /// </summary>
        /// <value>Name Reference 1</value>
        [DataMember(Name="nomeReferencia1", EmitDefaultValue=false)]
        public string NomeReferencia1 { get; set; }
    
        /// <summary>
        /// Reference Address 1
        /// </summary>
        /// <value>Reference Address 1</value>
        [DataMember(Name="enderecoReferencia1", EmitDefaultValue=false)]
        public string EnderecoReferencia1 { get; set; }
    
        /// <summary>
        /// Name Reference 2
        /// </summary>
        /// <value>Name Reference 2</value>
        [DataMember(Name="nomeReferencia2", EmitDefaultValue=false)]
        public string NomeReferencia2 { get; set; }
    
        /// <summary>
        /// Reference Address 2
        /// </summary>
        /// <value>Reference Address 2</value>
        [DataMember(Name="enderecoReferencia2", EmitDefaultValue=false)]
        public string EnderecoReferencia2 { get; set; }
    
        /// <summary>
        /// Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64) 
        /// </summary>
        /// <value>Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64) </value>
        [DataMember(Name="impedidoFinanciamento", EmitDefaultValue=false)]
        public bool? ImpedidoFinanciamento { get; set; }
    
        /// <summary>
        /// Active account function. Represents the function in which the account is enabled. Property should only be reported if the issuer makes use of account functions. The functions available for the accounts can be viewed in api/contas/tipos-funcoes
        /// </summary>
        /// <value>Active account function. Represents the function in which the account is enabled. Property should only be reported if the issuer makes use of account functions. The functions available for the accounts can be viewed in api/contas/tipos-funcoes</value>
        [DataMember(Name="funcaoAtiva", EmitDefaultValue=false)]
        public string FuncaoAtiva { get; set; }
    
        /// <summary>
        /// Displays the name of the birth city
        /// </summary>
        /// <value>Displays the name of the birth city</value>
        [DataMember(Name="naturalidadeCidade", EmitDefaultValue=false)]
        public string NaturalidadeCidade { get; set; }
    
        /// <summary>
        /// Presents the acronym of the person&#39;s state of birth
        /// </summary>
        /// <value>Presents the acronym of the person&#39;s state of birth</value>
        [DataMember(Name="naturalidadeEstado", EmitDefaultValue=false)]
        public string NaturalidadeEstado { get; set; }
    
        /// <summary>
        /// It shows the degree of instruction
        /// </summary>
        /// <value>It shows the degree of instruction</value>
        [DataMember(Name="grauInstrucao", EmitDefaultValue=false)]
        public int? GrauInstrucao { get; set; }
    
        /// <summary>
        /// Displays the number of dependents
        /// </summary>
        /// <value>Displays the number of dependents</value>
        [DataMember(Name="numeroDependentes", EmitDefaultValue=false)]
        public int? NumeroDependentes { get; set; }
    
        /// <summary>
        /// Displays the name of the parent
        /// </summary>
        /// <value>Displays the name of the parent</value>
        [DataMember(Name="nomePai", EmitDefaultValue=false)]
        public string NomePai { get; set; }
    
        /// <summary>
        /// Indicates whether you will join the overdraft
        /// </summary>
        /// <value>Indicates whether you will join the overdraft</value>
        [DataMember(Name="chequeEspecial", EmitDefaultValue=false)]
        public int? ChequeEspecial { get; set; }
    
        /// <summary>
        /// Bank Number
        /// </summary>
        /// <value>Bank Number</value>
        [DataMember(Name="numeroBanco", EmitDefaultValue=false)]
        public int? NumeroBanco { get; set; }
    
        /// <summary>
        /// License Plate Number
        /// </summary>
        /// <value>License Plate Number</value>
        [DataMember(Name="matricula", EmitDefaultValue=false)]
        public string Matricula { get; set; }
    
        /// <summary>
        /// Responsible for typing the proposal
        /// </summary>
        /// <value>Responsible for typing the proposal</value>
        [DataMember(Name="responsavelDigitacao", EmitDefaultValue=false)]
        public string ResponsavelDigitacao { get; set; }
    
        /// <summary>
        /// Sale promoter identification code
        /// </summary>
        /// <value>Sale promoter identification code</value>
        [DataMember(Name="idPromotorVenda", EmitDefaultValue=false)]
        public int? IdPromotorVenda { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectApprovedIndividual {\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  NomeMae: ").Append(NomeMae).Append("\n");
            sb.Append("  DataNascimento: ").Append(DataNascimento).Append("\n");
            sb.Append("  Sexo: ").Append(Sexo).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  NumeroIdentidade: ").Append(NumeroIdentidade).Append("\n");
            sb.Append("  OrgaoExpedidorIdentidade: ").Append(OrgaoExpedidorIdentidade).Append("\n");
            sb.Append("  UnidadeFederativaIdentidade: ").Append(UnidadeFederativaIdentidade).Append("\n");
            sb.Append("  DataEmissaoIdentidade: ").Append(DataEmissaoIdentidade).Append("\n");
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
            return this.Equals(obj as ObjectApprovedIndividual);
        }

        /// <summary>
        /// Returns true if ObjectApprovedIndividual instances are equal
        /// </summary>
        /// <param name="other">Instance of ObjectApprovedIndividual to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectApprovedIndividual other)
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
                
                return hash;
            }
        }

    }
}
