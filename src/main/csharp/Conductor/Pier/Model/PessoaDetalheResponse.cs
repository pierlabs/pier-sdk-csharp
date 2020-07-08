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
    /// PessoaDetalheResponse
    /// </summary>
    [DataContract]
    public partial class PessoaDetalheResponse :  IEquatable<PessoaDetalheResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaDetalheResponse" /> class.
        /// Initializes a new instance of the <see cref="PessoaDetalheResponse" />class.
        /// </summary>
        /// <param name="IdPessoa">C\u00F3digo identificador da pessoa.</param>
        /// <param name="NomeMae">Apresenta o nome da m\u00E3e da pessoa fisica.</param>
        /// <param name="IdEstadoCivil">Id Estado civil da pessoa fisica.</param>
        /// <param name="IdProfissao">Profiss\u00E3o da pessoa fisica.</param>
        /// <param name="IdNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica.</param>
        /// <param name="IdNacionalidade">Id Nacionalidade da pessoa fisica.</param>
        /// <param name="NumeroBanco">N\u00FAmero do banco.</param>
        /// <param name="NumeroAgencia">N\u00FAmero da ag\u00EAncia.</param>
        /// <param name="NumeroContaCorrente">N\u00FAmero da conta corrente.</param>
        /// <param name="Email">Email da pessoa fisica.</param>
        /// <param name="NomeEmpresa">Nome que deve ser impresso no cart\u00E3o.</param>
        /// <param name="NomeReferencia1">Nome de refer\u00EAncia 1.</param>
        /// <param name="EnderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1.</param>
        /// <param name="NomeReferencia2">Nome de refer\u00EAncia 2.</param>
        /// <param name="EnderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2.</param>
        /// <param name="Salario">Sal\u00E1rio.</param>
        /// <param name="ImpedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64).</param>
        /// <param name="NaturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica.</param>
        /// <param name="NaturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica.</param>
        /// <param name="GrauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica.</param>
        /// <param name="NumeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica.</param>
        /// <param name="NomePai">Apresenta o nome do pai da pessoa f\u00EDsica.</param>
        /// <param name="ChequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial.</param>
        /// <param name="NumeroCnh">N\u00FAmero da CNH da pessoa.</param>
        /// <param name="PessoaPoliticamenteExposta">Flag para identificar se a pessoa \u00E9 politicamente exposta.</param>
        /// <param name="PatrimonioTotal">Patrim\u00F4nio total da pessoa.</param>
        /// <param name="NomeConjuge">Nome do c\u00F4njuge da pessoa.</param>
        /// <param name="FlagNomePaiNaoInformado">Flag que indica se a pessoa informou nome do pai.</param>
        /// <param name="FlagSemEnderecoComercialFixo">Flag que indica se a pessoa possui endere\u00E7o comercial fixo.</param>
        /// <param name="DataEmissaoCnh">Data emiss\u00E3o CNH.</param>

        public PessoaDetalheResponse(long? IdPessoa = null, string NomeMae = null, long? IdEstadoCivil = null, string IdProfissao = null, long? IdNaturezaOcupacao = null, long? IdNacionalidade = null, int? NumeroBanco = null, int? NumeroAgencia = null, string NumeroContaCorrente = null, string Email = null, string NomeEmpresa = null, string NomeReferencia1 = null, string EnderecoReferencia1 = null, string NomeReferencia2 = null, string EnderecoReferencia2 = null, double? Salario = null, bool? ImpedidoFinanciamento = null, string NaturalidadeCidade = null, string NaturalidadeEstado = null, int? GrauInstrucao = null, int? NumeroDependentes = null, string NomePai = null, int? ChequeEspecial = null, string NumeroCnh = null, bool? PessoaPoliticamenteExposta = null, double? PatrimonioTotal = null, string NomeConjuge = null, bool? FlagNomePaiNaoInformado = null, bool? FlagSemEnderecoComercialFixo = null, string DataEmissaoCnh = null)
        {
            this.IdPessoa = IdPessoa;
            this.NomeMae = NomeMae;
            this.IdEstadoCivil = IdEstadoCivil;
            this.IdProfissao = IdProfissao;
            this.IdNaturezaOcupacao = IdNaturezaOcupacao;
            this.IdNacionalidade = IdNacionalidade;
            this.NumeroBanco = NumeroBanco;
            this.NumeroAgencia = NumeroAgencia;
            this.NumeroContaCorrente = NumeroContaCorrente;
            this.Email = Email;
            this.NomeEmpresa = NomeEmpresa;
            this.NomeReferencia1 = NomeReferencia1;
            this.EnderecoReferencia1 = EnderecoReferencia1;
            this.NomeReferencia2 = NomeReferencia2;
            this.EnderecoReferencia2 = EnderecoReferencia2;
            this.Salario = Salario;
            this.ImpedidoFinanciamento = ImpedidoFinanciamento;
            this.NaturalidadeCidade = NaturalidadeCidade;
            this.NaturalidadeEstado = NaturalidadeEstado;
            this.GrauInstrucao = GrauInstrucao;
            this.NumeroDependentes = NumeroDependentes;
            this.NomePai = NomePai;
            this.ChequeEspecial = ChequeEspecial;
            this.NumeroCnh = NumeroCnh;
            this.PessoaPoliticamenteExposta = PessoaPoliticamenteExposta;
            this.PatrimonioTotal = PatrimonioTotal;
            this.NomeConjuge = NomeConjuge;
            this.FlagNomePaiNaoInformado = FlagNomePaiNaoInformado;
            this.FlagSemEnderecoComercialFixo = FlagSemEnderecoComercialFixo;
            this.DataEmissaoCnh = DataEmissaoCnh;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo identificador da pessoa
        /// </summary>
        /// <value>C\u00F3digo identificador da pessoa</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Apresenta o nome da m\u00E3e da pessoa fisica
        /// </summary>
        /// <value>Apresenta o nome da m\u00E3e da pessoa fisica</value>
        [DataMember(Name="nomeMae", EmitDefaultValue=false)]
        public string NomeMae { get; set; }
    
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
        /// N\u00FAmero do banco
        /// </summary>
        /// <value>N\u00FAmero do banco</value>
        [DataMember(Name="numeroBanco", EmitDefaultValue=false)]
        public int? NumeroBanco { get; set; }
    
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
        /// Nome que deve ser impresso no cart\u00E3o
        /// </summary>
        /// <value>Nome que deve ser impresso no cart\u00E3o</value>
        [DataMember(Name="nomeEmpresa", EmitDefaultValue=false)]
        public string NomeEmpresa { get; set; }
    
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
        /// Sal\u00E1rio
        /// </summary>
        /// <value>Sal\u00E1rio</value>
        [DataMember(Name="salario", EmitDefaultValue=false)]
        public double? Salario { get; set; }
    
        /// <summary>
        /// Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64)
        /// </summary>
        /// <value>Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64)</value>
        [DataMember(Name="impedidoFinanciamento", EmitDefaultValue=false)]
        public bool? ImpedidoFinanciamento { get; set; }
    
        /// <summary>
        /// Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica
        /// </summary>
        /// <value>Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica</value>
        [DataMember(Name="naturalidadeCidade", EmitDefaultValue=false)]
        public string NaturalidadeCidade { get; set; }
    
        /// <summary>
        /// Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica
        /// </summary>
        /// <value>Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica</value>
        [DataMember(Name="naturalidadeEstado", EmitDefaultValue=false)]
        public string NaturalidadeEstado { get; set; }
    
        /// <summary>
        /// Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica
        /// </summary>
        /// <value>Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica</value>
        [DataMember(Name="grauInstrucao", EmitDefaultValue=false)]
        public int? GrauInstrucao { get; set; }
    
        /// <summary>
        /// Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica
        /// </summary>
        /// <value>Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica</value>
        [DataMember(Name="numeroDependentes", EmitDefaultValue=false)]
        public int? NumeroDependentes { get; set; }
    
        /// <summary>
        /// Apresenta o nome do pai da pessoa f\u00EDsica
        /// </summary>
        /// <value>Apresenta o nome do pai da pessoa f\u00EDsica</value>
        [DataMember(Name="nomePai", EmitDefaultValue=false)]
        public string NomePai { get; set; }
    
        /// <summary>
        /// Indica se pessoa f\u00EDsica aderir ao cheque especial
        /// </summary>
        /// <value>Indica se pessoa f\u00EDsica aderir ao cheque especial</value>
        [DataMember(Name="chequeEspecial", EmitDefaultValue=false)]
        public int? ChequeEspecial { get; set; }
    
        /// <summary>
        /// N\u00FAmero da CNH da pessoa
        /// </summary>
        /// <value>N\u00FAmero da CNH da pessoa</value>
        [DataMember(Name="numeroCnh", EmitDefaultValue=false)]
        public string NumeroCnh { get; set; }
    
        /// <summary>
        /// Flag para identificar se a pessoa \u00E9 politicamente exposta
        /// </summary>
        /// <value>Flag para identificar se a pessoa \u00E9 politicamente exposta</value>
        [DataMember(Name="pessoaPoliticamenteExposta", EmitDefaultValue=false)]
        public bool? PessoaPoliticamenteExposta { get; set; }
    
        /// <summary>
        /// Patrim\u00F4nio total da pessoa
        /// </summary>
        /// <value>Patrim\u00F4nio total da pessoa</value>
        [DataMember(Name="patrimonioTotal", EmitDefaultValue=false)]
        public double? PatrimonioTotal { get; set; }
    
        /// <summary>
        /// Nome do c\u00F4njuge da pessoa
        /// </summary>
        /// <value>Nome do c\u00F4njuge da pessoa</value>
        [DataMember(Name="nomeConjuge", EmitDefaultValue=false)]
        public string NomeConjuge { get; set; }
    
        /// <summary>
        /// Flag que indica se a pessoa informou nome do pai
        /// </summary>
        /// <value>Flag que indica se a pessoa informou nome do pai</value>
        [DataMember(Name="flagNomePaiNaoInformado", EmitDefaultValue=false)]
        public bool? FlagNomePaiNaoInformado { get; set; }
    
        /// <summary>
        /// Flag que indica se a pessoa possui endere\u00E7o comercial fixo
        /// </summary>
        /// <value>Flag que indica se a pessoa possui endere\u00E7o comercial fixo</value>
        [DataMember(Name="flagSemEnderecoComercialFixo", EmitDefaultValue=false)]
        public bool? FlagSemEnderecoComercialFixo { get; set; }
    
        /// <summary>
        /// Data emiss\u00E3o CNH
        /// </summary>
        /// <value>Data emiss\u00E3o CNH</value>
        [DataMember(Name="dataEmissaoCnh", EmitDefaultValue=false)]
        public string DataEmissaoCnh { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PessoaDetalheResponse {\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  NomeMae: ").Append(NomeMae).Append("\n");
            sb.Append("  IdEstadoCivil: ").Append(IdEstadoCivil).Append("\n");
            sb.Append("  IdProfissao: ").Append(IdProfissao).Append("\n");
            sb.Append("  IdNaturezaOcupacao: ").Append(IdNaturezaOcupacao).Append("\n");
            sb.Append("  IdNacionalidade: ").Append(IdNacionalidade).Append("\n");
            sb.Append("  NumeroBanco: ").Append(NumeroBanco).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  NumeroContaCorrente: ").Append(NumeroContaCorrente).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  NomeEmpresa: ").Append(NomeEmpresa).Append("\n");
            sb.Append("  NomeReferencia1: ").Append(NomeReferencia1).Append("\n");
            sb.Append("  EnderecoReferencia1: ").Append(EnderecoReferencia1).Append("\n");
            sb.Append("  NomeReferencia2: ").Append(NomeReferencia2).Append("\n");
            sb.Append("  EnderecoReferencia2: ").Append(EnderecoReferencia2).Append("\n");
            sb.Append("  Salario: ").Append(Salario).Append("\n");
            sb.Append("  ImpedidoFinanciamento: ").Append(ImpedidoFinanciamento).Append("\n");
            sb.Append("  NaturalidadeCidade: ").Append(NaturalidadeCidade).Append("\n");
            sb.Append("  NaturalidadeEstado: ").Append(NaturalidadeEstado).Append("\n");
            sb.Append("  GrauInstrucao: ").Append(GrauInstrucao).Append("\n");
            sb.Append("  NumeroDependentes: ").Append(NumeroDependentes).Append("\n");
            sb.Append("  NomePai: ").Append(NomePai).Append("\n");
            sb.Append("  ChequeEspecial: ").Append(ChequeEspecial).Append("\n");
            sb.Append("  NumeroCnh: ").Append(NumeroCnh).Append("\n");
            sb.Append("  PessoaPoliticamenteExposta: ").Append(PessoaPoliticamenteExposta).Append("\n");
            sb.Append("  PatrimonioTotal: ").Append(PatrimonioTotal).Append("\n");
            sb.Append("  NomeConjuge: ").Append(NomeConjuge).Append("\n");
            sb.Append("  FlagNomePaiNaoInformado: ").Append(FlagNomePaiNaoInformado).Append("\n");
            sb.Append("  FlagSemEnderecoComercialFixo: ").Append(FlagSemEnderecoComercialFixo).Append("\n");
            sb.Append("  DataEmissaoCnh: ").Append(DataEmissaoCnh).Append("\n");
            
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
            return this.Equals(obj as PessoaDetalheResponse);
        }

        /// <summary>
        /// Returns true if PessoaDetalheResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PessoaDetalheResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PessoaDetalheResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.NomeMae == other.NomeMae ||
                    this.NomeMae != null &&
                    this.NomeMae.Equals(other.NomeMae)
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
                    this.NumeroBanco == other.NumeroBanco ||
                    this.NumeroBanco != null &&
                    this.NumeroBanco.Equals(other.NumeroBanco)
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
                    this.NomeEmpresa == other.NomeEmpresa ||
                    this.NomeEmpresa != null &&
                    this.NomeEmpresa.Equals(other.NomeEmpresa)
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
                    this.Salario == other.Salario ||
                    this.Salario != null &&
                    this.Salario.Equals(other.Salario)
                ) && 
                (
                    this.ImpedidoFinanciamento == other.ImpedidoFinanciamento ||
                    this.ImpedidoFinanciamento != null &&
                    this.ImpedidoFinanciamento.Equals(other.ImpedidoFinanciamento)
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
                    this.NumeroCnh == other.NumeroCnh ||
                    this.NumeroCnh != null &&
                    this.NumeroCnh.Equals(other.NumeroCnh)
                ) && 
                (
                    this.PessoaPoliticamenteExposta == other.PessoaPoliticamenteExposta ||
                    this.PessoaPoliticamenteExposta != null &&
                    this.PessoaPoliticamenteExposta.Equals(other.PessoaPoliticamenteExposta)
                ) && 
                (
                    this.PatrimonioTotal == other.PatrimonioTotal ||
                    this.PatrimonioTotal != null &&
                    this.PatrimonioTotal.Equals(other.PatrimonioTotal)
                ) && 
                (
                    this.NomeConjuge == other.NomeConjuge ||
                    this.NomeConjuge != null &&
                    this.NomeConjuge.Equals(other.NomeConjuge)
                ) && 
                (
                    this.FlagNomePaiNaoInformado == other.FlagNomePaiNaoInformado ||
                    this.FlagNomePaiNaoInformado != null &&
                    this.FlagNomePaiNaoInformado.Equals(other.FlagNomePaiNaoInformado)
                ) && 
                (
                    this.FlagSemEnderecoComercialFixo == other.FlagSemEnderecoComercialFixo ||
                    this.FlagSemEnderecoComercialFixo != null &&
                    this.FlagSemEnderecoComercialFixo.Equals(other.FlagSemEnderecoComercialFixo)
                ) && 
                (
                    this.DataEmissaoCnh == other.DataEmissaoCnh ||
                    this.DataEmissaoCnh != null &&
                    this.DataEmissaoCnh.Equals(other.DataEmissaoCnh)
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
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.NomeMae != null)
                    hash = hash * 59 + this.NomeMae.GetHashCode();
                
                if (this.IdEstadoCivil != null)
                    hash = hash * 59 + this.IdEstadoCivil.GetHashCode();
                
                if (this.IdProfissao != null)
                    hash = hash * 59 + this.IdProfissao.GetHashCode();
                
                if (this.IdNaturezaOcupacao != null)
                    hash = hash * 59 + this.IdNaturezaOcupacao.GetHashCode();
                
                if (this.IdNacionalidade != null)
                    hash = hash * 59 + this.IdNacionalidade.GetHashCode();
                
                if (this.NumeroBanco != null)
                    hash = hash * 59 + this.NumeroBanco.GetHashCode();
                
                if (this.NumeroAgencia != null)
                    hash = hash * 59 + this.NumeroAgencia.GetHashCode();
                
                if (this.NumeroContaCorrente != null)
                    hash = hash * 59 + this.NumeroContaCorrente.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.NomeEmpresa != null)
                    hash = hash * 59 + this.NomeEmpresa.GetHashCode();
                
                if (this.NomeReferencia1 != null)
                    hash = hash * 59 + this.NomeReferencia1.GetHashCode();
                
                if (this.EnderecoReferencia1 != null)
                    hash = hash * 59 + this.EnderecoReferencia1.GetHashCode();
                
                if (this.NomeReferencia2 != null)
                    hash = hash * 59 + this.NomeReferencia2.GetHashCode();
                
                if (this.EnderecoReferencia2 != null)
                    hash = hash * 59 + this.EnderecoReferencia2.GetHashCode();
                
                if (this.Salario != null)
                    hash = hash * 59 + this.Salario.GetHashCode();
                
                if (this.ImpedidoFinanciamento != null)
                    hash = hash * 59 + this.ImpedidoFinanciamento.GetHashCode();
                
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
                
                if (this.NumeroCnh != null)
                    hash = hash * 59 + this.NumeroCnh.GetHashCode();
                
                if (this.PessoaPoliticamenteExposta != null)
                    hash = hash * 59 + this.PessoaPoliticamenteExposta.GetHashCode();
                
                if (this.PatrimonioTotal != null)
                    hash = hash * 59 + this.PatrimonioTotal.GetHashCode();
                
                if (this.NomeConjuge != null)
                    hash = hash * 59 + this.NomeConjuge.GetHashCode();
                
                if (this.FlagNomePaiNaoInformado != null)
                    hash = hash * 59 + this.FlagNomePaiNaoInformado.GetHashCode();
                
                if (this.FlagSemEnderecoComercialFixo != null)
                    hash = hash * 59 + this.FlagSemEnderecoComercialFixo.GetHashCode();
                
                if (this.DataEmissaoCnh != null)
                    hash = hash * 59 + this.DataEmissaoCnh.GetHashCode();
                
                return hash;
            }
        }

    }
}
