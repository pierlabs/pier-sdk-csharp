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
    public partial class CredorResponse :  IEquatable<CredorResponse>
    { 
    
        /// <summary>
        /// Credor response recebe rav
        /// </summary>
        /// <value>Credor response recebe rav</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RecebeRAVEnum {
            
            [EnumMember(Value = "NAO_TEM_PERMISSAO_RAV")]
            NaoTemPermissaoRav,
            
            [EnumMember(Value = "CREDITO_RAV")]
            CreditoRav,
            
            [EnumMember(Value = "DEBITO_RAV")]
            DebitoRav
        }

    
        /// <summary>
        /// Credor response periodicidade
        /// </summary>
        /// <value>Credor response periodicidade</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PeriodicidadeEnum {
            
            [EnumMember(Value = "DIARIO")]
            Diario,
            
            [EnumMember(Value = "SEMANAL")]
            Semanal,
            
            [EnumMember(Value = "MENSAL")]
            Mensal,
            
            [EnumMember(Value = "DECENDIAL")]
            Decendial,
            
            [EnumMember(Value = "QUINZENAL")]
            Quinzenal
        }

    
        /// <summary>
        /// Credor response recebe rav
        /// </summary>
        /// <value>Credor response recebe rav</value>
        [DataMember(Name="recebeRAV", EmitDefaultValue=false)]
        public RecebeRAVEnum? RecebeRAV { get; set; }
    
        /// <summary>
        /// Credor response periodicidade
        /// </summary>
        /// <value>Credor response periodicidade</value>
        [DataMember(Name="periodicidade", EmitDefaultValue=false)]
        public PeriodicidadeEnum? Periodicidade { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CredorResponse" /> class.
        /// Initializes a new instance of the <see cref="CredorResponse" />class.
        /// </summary>
        /// <param name="Id">Credor response id credor.</param>
        /// <param name="NomeCredor">Credor response nome credor.</param>
        /// <param name="DiaPagamentoSemanal">Credor response pagamento semanal.</param>
        /// <param name="DiaPagamentoMensal">Credor response pagamento mensal.</param>
        /// <param name="DiaPagamentoDecendialPrimeiro">Credor respone pagamento decendial primeiro.</param>
        /// <param name="DiaPagamentoDecendialSegundo">Credor respone pagamento decendial segundo.</param>
        /// <param name="DiaPagamentoDecendialTerceiro">Credor respone pagamento decendial terceiro.</param>
        /// <param name="DiaPagamentoQuinzenalPrimeiro">Credor respone pagamento quinzenal primeiro.</param>
        /// <param name="DiaPagamentoQuinzenalSegundo">Credor respone pagamento quinzenal segundo.</param>
        /// <param name="Banco">credor response banco.</param>
        /// <param name="Agencia">Credor response ag\u00EAncia.</param>
        /// <param name="DigitoAgencia">Credor response d\u00EDgito ag\u00EAncia.</param>
        /// <param name="ContaCorrente">Credor response conta corrente.</param>
        /// <param name="DigitoContaCorrente">Credor response d\u00EDgito conta corrente.</param>
        /// <param name="CredorBanco">Credor response credor banco.</param>
        /// <param name="PercentualRAV">Credor response percentual rav.</param>
        /// <param name="RecebeRAV">Credor response recebe rav.</param>
        /// <param name="PercentualMultiplica">Credor response percentual multiplica.</param>
        /// <param name="TaxaAdministrativa">Credor response taxa adm.</param>
        /// <param name="TaxaBanco">Credor response taxa banco.</param>
        /// <param name="LimiteRAV">Credor response limite rav.</param>
        /// <param name="IdCredorRAV">Credor response id credor rav.</param>
        /// <param name="Periodicidade">Credor response periodicidade.</param>
        /// <param name="IdPessoaJuridica">Credor response id pessoa juridica.</param>
        /// <param name="FlagEscritorioCobranca">Credor response flag escritorio cobranca.</param>
        /// <param name="Prefixo">Cerdor response prefixo escritorio cobran\u00E7a.</param>
        /// <param name="Ativo">Credor response ativo escritorio cobran\u00E7a.</param>
        /// <param name="TelefonesEscritoriosCobranca">Credor response telefone escritorio cobranca.</param>
        /// <param name="NomeContato">Credor response nome contato escritorio cobran\u00E7a.</param>
        /// <param name="Email">Credor response nome contato escritorio cobran\u00E7a.</param>
        /// <param name="NomeLogradouro">Credor response logradouro escritorio cobran\u00E7a.</param>
        /// <param name="NumeroEndereco">Credor response numero endere\u00E7o escritorio cobran\u00E7a.</param>
        /// <param name="ComplementoEndereco">Credor response complemento endere\u00E7o escritorio cobran\u00E7a.</param>
        /// <param name="Bairro">Credor response bairro escritorio cobran\u00E7a.</param>
        /// <param name="Cidade">Credor response cidade escritorio cobran\u00E7a.</param>
        /// <param name="Cep">Credor response cep escritorio cobran\u00E7a.</param>
        /// <param name="Uf">Credor response uf escritorio cobran\u00E7a.</param>
        /// <param name="Responsavel">Credor response responsavel escritorio cobran\u00E7a.</param>
        /// <param name="FlagSegundaViaAcordo">Credor response flag segunda via acordo escritorio cobran\u00E7a.</param>
        /// <param name="ValorMinimoParcela">Credor response valor m\u00EDnimo escritorio cobran\u00E7a.</param>
        /// <param name="DescontoMaximo">Credor response desconto m\u00E1ximo escritorio cobran\u00E7a.</param>

        public CredorResponse(long? Id = null, string NomeCredor = null, int? DiaPagamentoSemanal = null, int? DiaPagamentoMensal = null, int? DiaPagamentoDecendialPrimeiro = null, int? DiaPagamentoDecendialSegundo = null, int? DiaPagamentoDecendialTerceiro = null, int? DiaPagamentoQuinzenalPrimeiro = null, int? DiaPagamentoQuinzenalSegundo = null, int? Banco = null, int? Agencia = null, string DigitoAgencia = null, string ContaCorrente = null, string DigitoContaCorrente = null, bool? CredorBanco = null, double? PercentualRAV = null, RecebeRAVEnum? RecebeRAV = null, double? PercentualMultiplica = null, double? TaxaAdministrativa = null, double? TaxaBanco = null, double? LimiteRAV = null, long? IdCredorRAV = null, PeriodicidadeEnum? Periodicidade = null, long? IdPessoaJuridica = null, bool? FlagEscritorioCobranca = null, string Prefixo = null, bool? Ativo = null, List<TelefoneEscritorioCobrancaDTO> TelefonesEscritoriosCobranca = null, string NomeContato = null, string Email = null, string NomeLogradouro = null, int? NumeroEndereco = null, string ComplementoEndereco = null, string Bairro = null, string Cidade = null, string Cep = null, string Uf = null, string Responsavel = null, int? FlagSegundaViaAcordo = null, double? ValorMinimoParcela = null, double? DescontoMaximo = null)
        {
            this.Id = Id;
            this.NomeCredor = NomeCredor;
            this.DiaPagamentoSemanal = DiaPagamentoSemanal;
            this.DiaPagamentoMensal = DiaPagamentoMensal;
            this.DiaPagamentoDecendialPrimeiro = DiaPagamentoDecendialPrimeiro;
            this.DiaPagamentoDecendialSegundo = DiaPagamentoDecendialSegundo;
            this.DiaPagamentoDecendialTerceiro = DiaPagamentoDecendialTerceiro;
            this.DiaPagamentoQuinzenalPrimeiro = DiaPagamentoQuinzenalPrimeiro;
            this.DiaPagamentoQuinzenalSegundo = DiaPagamentoQuinzenalSegundo;
            this.Banco = Banco;
            this.Agencia = Agencia;
            this.DigitoAgencia = DigitoAgencia;
            this.ContaCorrente = ContaCorrente;
            this.DigitoContaCorrente = DigitoContaCorrente;
            this.CredorBanco = CredorBanco;
            this.PercentualRAV = PercentualRAV;
            this.RecebeRAV = RecebeRAV;
            this.PercentualMultiplica = PercentualMultiplica;
            this.TaxaAdministrativa = TaxaAdministrativa;
            this.TaxaBanco = TaxaBanco;
            this.LimiteRAV = LimiteRAV;
            this.IdCredorRAV = IdCredorRAV;
            this.Periodicidade = Periodicidade;
            this.IdPessoaJuridica = IdPessoaJuridica;
            this.FlagEscritorioCobranca = FlagEscritorioCobranca;
            this.Prefixo = Prefixo;
            this.Ativo = Ativo;
            this.TelefonesEscritoriosCobranca = TelefonesEscritoriosCobranca;
            this.NomeContato = NomeContato;
            this.Email = Email;
            this.NomeLogradouro = NomeLogradouro;
            this.NumeroEndereco = NumeroEndereco;
            this.ComplementoEndereco = ComplementoEndereco;
            this.Bairro = Bairro;
            this.Cidade = Cidade;
            this.Cep = Cep;
            this.Uf = Uf;
            this.Responsavel = Responsavel;
            this.FlagSegundaViaAcordo = FlagSegundaViaAcordo;
            this.ValorMinimoParcela = ValorMinimoParcela;
            this.DescontoMaximo = DescontoMaximo;
            
        }
        
    
        /// <summary>
        /// Credor response id credor
        /// </summary>
        /// <value>Credor response id credor</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Credor response nome credor
        /// </summary>
        /// <value>Credor response nome credor</value>
        [DataMember(Name="nomeCredor", EmitDefaultValue=false)]
        public string NomeCredor { get; set; }
    
        /// <summary>
        /// Credor response pagamento semanal
        /// </summary>
        /// <value>Credor response pagamento semanal</value>
        [DataMember(Name="diaPagamentoSemanal", EmitDefaultValue=false)]
        public int? DiaPagamentoSemanal { get; set; }
    
        /// <summary>
        /// Credor response pagamento mensal
        /// </summary>
        /// <value>Credor response pagamento mensal</value>
        [DataMember(Name="diaPagamentoMensal", EmitDefaultValue=false)]
        public int? DiaPagamentoMensal { get; set; }
    
        /// <summary>
        /// Credor respone pagamento decendial primeiro
        /// </summary>
        /// <value>Credor respone pagamento decendial primeiro</value>
        [DataMember(Name="diaPagamentoDecendialPrimeiro", EmitDefaultValue=false)]
        public int? DiaPagamentoDecendialPrimeiro { get; set; }
    
        /// <summary>
        /// Credor respone pagamento decendial segundo
        /// </summary>
        /// <value>Credor respone pagamento decendial segundo</value>
        [DataMember(Name="diaPagamentoDecendialSegundo", EmitDefaultValue=false)]
        public int? DiaPagamentoDecendialSegundo { get; set; }
    
        /// <summary>
        /// Credor respone pagamento decendial terceiro
        /// </summary>
        /// <value>Credor respone pagamento decendial terceiro</value>
        [DataMember(Name="diaPagamentoDecendialTerceiro", EmitDefaultValue=false)]
        public int? DiaPagamentoDecendialTerceiro { get; set; }
    
        /// <summary>
        /// Credor respone pagamento quinzenal primeiro
        /// </summary>
        /// <value>Credor respone pagamento quinzenal primeiro</value>
        [DataMember(Name="diaPagamentoQuinzenalPrimeiro", EmitDefaultValue=false)]
        public int? DiaPagamentoQuinzenalPrimeiro { get; set; }
    
        /// <summary>
        /// Credor respone pagamento quinzenal segundo
        /// </summary>
        /// <value>Credor respone pagamento quinzenal segundo</value>
        [DataMember(Name="diaPagamentoQuinzenalSegundo", EmitDefaultValue=false)]
        public int? DiaPagamentoQuinzenalSegundo { get; set; }
    
        /// <summary>
        /// credor response banco
        /// </summary>
        /// <value>credor response banco</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public int? Banco { get; set; }
    
        /// <summary>
        /// Credor response ag\u00EAncia
        /// </summary>
        /// <value>Credor response ag\u00EAncia</value>
        [DataMember(Name="agencia", EmitDefaultValue=false)]
        public int? Agencia { get; set; }
    
        /// <summary>
        /// Credor response d\u00EDgito ag\u00EAncia
        /// </summary>
        /// <value>Credor response d\u00EDgito ag\u00EAncia</value>
        [DataMember(Name="digitoAgencia", EmitDefaultValue=false)]
        public string DigitoAgencia { get; set; }
    
        /// <summary>
        /// Credor response conta corrente
        /// </summary>
        /// <value>Credor response conta corrente</value>
        [DataMember(Name="contaCorrente", EmitDefaultValue=false)]
        public string ContaCorrente { get; set; }
    
        /// <summary>
        /// Credor response d\u00EDgito conta corrente
        /// </summary>
        /// <value>Credor response d\u00EDgito conta corrente</value>
        [DataMember(Name="digitoContaCorrente", EmitDefaultValue=false)]
        public string DigitoContaCorrente { get; set; }
    
        /// <summary>
        /// Credor response credor banco
        /// </summary>
        /// <value>Credor response credor banco</value>
        [DataMember(Name="credorBanco", EmitDefaultValue=false)]
        public bool? CredorBanco { get; set; }
    
        /// <summary>
        /// Credor response percentual rav
        /// </summary>
        /// <value>Credor response percentual rav</value>
        [DataMember(Name="percentualRAV", EmitDefaultValue=false)]
        public double? PercentualRAV { get; set; }
    
        /// <summary>
        /// Credor response percentual multiplica
        /// </summary>
        /// <value>Credor response percentual multiplica</value>
        [DataMember(Name="percentualMultiplica", EmitDefaultValue=false)]
        public double? PercentualMultiplica { get; set; }
    
        /// <summary>
        /// Credor response taxa adm
        /// </summary>
        /// <value>Credor response taxa adm</value>
        [DataMember(Name="taxaAdministrativa", EmitDefaultValue=false)]
        public double? TaxaAdministrativa { get; set; }
    
        /// <summary>
        /// Credor response taxa banco
        /// </summary>
        /// <value>Credor response taxa banco</value>
        [DataMember(Name="taxaBanco", EmitDefaultValue=false)]
        public double? TaxaBanco { get; set; }
    
        /// <summary>
        /// Credor response limite rav
        /// </summary>
        /// <value>Credor response limite rav</value>
        [DataMember(Name="limiteRAV", EmitDefaultValue=false)]
        public double? LimiteRAV { get; set; }
    
        /// <summary>
        /// Credor response id credor rav
        /// </summary>
        /// <value>Credor response id credor rav</value>
        [DataMember(Name="idCredorRAV", EmitDefaultValue=false)]
        public long? IdCredorRAV { get; set; }
    
        /// <summary>
        /// Credor response id pessoa juridica
        /// </summary>
        /// <value>Credor response id pessoa juridica</value>
        [DataMember(Name="idPessoaJuridica", EmitDefaultValue=false)]
        public long? IdPessoaJuridica { get; set; }
    
        /// <summary>
        /// Credor response flag escritorio cobranca
        /// </summary>
        /// <value>Credor response flag escritorio cobranca</value>
        [DataMember(Name="flagEscritorioCobranca", EmitDefaultValue=false)]
        public bool? FlagEscritorioCobranca { get; set; }
    
        /// <summary>
        /// Cerdor response prefixo escritorio cobran\u00E7a
        /// </summary>
        /// <value>Cerdor response prefixo escritorio cobran\u00E7a</value>
        [DataMember(Name="prefixo", EmitDefaultValue=false)]
        public string Prefixo { get; set; }
    
        /// <summary>
        /// Credor response ativo escritorio cobran\u00E7a
        /// </summary>
        /// <value>Credor response ativo escritorio cobran\u00E7a</value>
        [DataMember(Name="ativo", EmitDefaultValue=false)]
        public bool? Ativo { get; set; }
    
        /// <summary>
        /// Credor response telefone escritorio cobranca
        /// </summary>
        /// <value>Credor response telefone escritorio cobranca</value>
        [DataMember(Name="telefonesEscritoriosCobranca", EmitDefaultValue=false)]
        public List<TelefoneEscritorioCobrancaDTO> TelefonesEscritoriosCobranca { get; set; }
    
        /// <summary>
        /// Credor response nome contato escritorio cobran\u00E7a
        /// </summary>
        /// <value>Credor response nome contato escritorio cobran\u00E7a</value>
        [DataMember(Name="nomeContato", EmitDefaultValue=false)]
        public string NomeContato { get; set; }
    
        /// <summary>
        /// Credor response nome contato escritorio cobran\u00E7a
        /// </summary>
        /// <value>Credor response nome contato escritorio cobran\u00E7a</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Credor response logradouro escritorio cobran\u00E7a
        /// </summary>
        /// <value>Credor response logradouro escritorio cobran\u00E7a</value>
        [DataMember(Name="nomeLogradouro", EmitDefaultValue=false)]
        public string NomeLogradouro { get; set; }
    
        /// <summary>
        /// Credor response numero endere\u00E7o escritorio cobran\u00E7a
        /// </summary>
        /// <value>Credor response numero endere\u00E7o escritorio cobran\u00E7a</value>
        [DataMember(Name="numeroEndereco", EmitDefaultValue=false)]
        public int? NumeroEndereco { get; set; }
    
        /// <summary>
        /// Credor response complemento endere\u00E7o escritorio cobran\u00E7a
        /// </summary>
        /// <value>Credor response complemento endere\u00E7o escritorio cobran\u00E7a</value>
        [DataMember(Name="complementoEndereco", EmitDefaultValue=false)]
        public string ComplementoEndereco { get; set; }
    
        /// <summary>
        /// Credor response bairro escritorio cobran\u00E7a
        /// </summary>
        /// <value>Credor response bairro escritorio cobran\u00E7a</value>
        [DataMember(Name="bairro", EmitDefaultValue=false)]
        public string Bairro { get; set; }
    
        /// <summary>
        /// Credor response cidade escritorio cobran\u00E7a
        /// </summary>
        /// <value>Credor response cidade escritorio cobran\u00E7a</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// Credor response cep escritorio cobran\u00E7a
        /// </summary>
        /// <value>Credor response cep escritorio cobran\u00E7a</value>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public string Cep { get; set; }
    
        /// <summary>
        /// Credor response uf escritorio cobran\u00E7a
        /// </summary>
        /// <value>Credor response uf escritorio cobran\u00E7a</value>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }
    
        /// <summary>
        /// Credor response responsavel escritorio cobran\u00E7a
        /// </summary>
        /// <value>Credor response responsavel escritorio cobran\u00E7a</value>
        [DataMember(Name="responsavel", EmitDefaultValue=false)]
        public string Responsavel { get; set; }
    
        /// <summary>
        /// Credor response flag segunda via acordo escritorio cobran\u00E7a
        /// </summary>
        /// <value>Credor response flag segunda via acordo escritorio cobran\u00E7a</value>
        [DataMember(Name="flagSegundaViaAcordo", EmitDefaultValue=false)]
        public int? FlagSegundaViaAcordo { get; set; }
    
        /// <summary>
        /// Credor response valor m\u00EDnimo escritorio cobran\u00E7a
        /// </summary>
        /// <value>Credor response valor m\u00EDnimo escritorio cobran\u00E7a</value>
        [DataMember(Name="valorMinimoParcela", EmitDefaultValue=false)]
        public double? ValorMinimoParcela { get; set; }
    
        /// <summary>
        /// Credor response desconto m\u00E1ximo escritorio cobran\u00E7a
        /// </summary>
        /// <value>Credor response desconto m\u00E1ximo escritorio cobran\u00E7a</value>
        [DataMember(Name="descontoMaximo", EmitDefaultValue=false)]
        public double? DescontoMaximo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CredorResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NomeCredor: ").Append(NomeCredor).Append("\n");
            sb.Append("  DiaPagamentoSemanal: ").Append(DiaPagamentoSemanal).Append("\n");
            sb.Append("  DiaPagamentoMensal: ").Append(DiaPagamentoMensal).Append("\n");
            sb.Append("  DiaPagamentoDecendialPrimeiro: ").Append(DiaPagamentoDecendialPrimeiro).Append("\n");
            sb.Append("  DiaPagamentoDecendialSegundo: ").Append(DiaPagamentoDecendialSegundo).Append("\n");
            sb.Append("  DiaPagamentoDecendialTerceiro: ").Append(DiaPagamentoDecendialTerceiro).Append("\n");
            sb.Append("  DiaPagamentoQuinzenalPrimeiro: ").Append(DiaPagamentoQuinzenalPrimeiro).Append("\n");
            sb.Append("  DiaPagamentoQuinzenalSegundo: ").Append(DiaPagamentoQuinzenalSegundo).Append("\n");
            sb.Append("  Banco: ").Append(Banco).Append("\n");
            sb.Append("  Agencia: ").Append(Agencia).Append("\n");
            sb.Append("  DigitoAgencia: ").Append(DigitoAgencia).Append("\n");
            sb.Append("  ContaCorrente: ").Append(ContaCorrente).Append("\n");
            sb.Append("  DigitoContaCorrente: ").Append(DigitoContaCorrente).Append("\n");
            sb.Append("  CredorBanco: ").Append(CredorBanco).Append("\n");
            sb.Append("  PercentualRAV: ").Append(PercentualRAV).Append("\n");
            sb.Append("  RecebeRAV: ").Append(RecebeRAV).Append("\n");
            sb.Append("  PercentualMultiplica: ").Append(PercentualMultiplica).Append("\n");
            sb.Append("  TaxaAdministrativa: ").Append(TaxaAdministrativa).Append("\n");
            sb.Append("  TaxaBanco: ").Append(TaxaBanco).Append("\n");
            sb.Append("  LimiteRAV: ").Append(LimiteRAV).Append("\n");
            sb.Append("  IdCredorRAV: ").Append(IdCredorRAV).Append("\n");
            sb.Append("  Periodicidade: ").Append(Periodicidade).Append("\n");
            sb.Append("  IdPessoaJuridica: ").Append(IdPessoaJuridica).Append("\n");
            sb.Append("  FlagEscritorioCobranca: ").Append(FlagEscritorioCobranca).Append("\n");
            sb.Append("  Prefixo: ").Append(Prefixo).Append("\n");
            sb.Append("  Ativo: ").Append(Ativo).Append("\n");
            sb.Append("  TelefonesEscritoriosCobranca: ").Append(TelefonesEscritoriosCobranca).Append("\n");
            sb.Append("  NomeContato: ").Append(NomeContato).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  NomeLogradouro: ").Append(NomeLogradouro).Append("\n");
            sb.Append("  NumeroEndereco: ").Append(NumeroEndereco).Append("\n");
            sb.Append("  ComplementoEndereco: ").Append(ComplementoEndereco).Append("\n");
            sb.Append("  Bairro: ").Append(Bairro).Append("\n");
            sb.Append("  Cidade: ").Append(Cidade).Append("\n");
            sb.Append("  Cep: ").Append(Cep).Append("\n");
            sb.Append("  Uf: ").Append(Uf).Append("\n");
            sb.Append("  Responsavel: ").Append(Responsavel).Append("\n");
            sb.Append("  FlagSegundaViaAcordo: ").Append(FlagSegundaViaAcordo).Append("\n");
            sb.Append("  ValorMinimoParcela: ").Append(ValorMinimoParcela).Append("\n");
            sb.Append("  DescontoMaximo: ").Append(DescontoMaximo).Append("\n");
            
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
            return this.Equals(obj as CredorResponse);
        }

        /// <summary>
        /// Returns true if CredorResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CredorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CredorResponse other)
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
                    this.NomeCredor == other.NomeCredor ||
                    this.NomeCredor != null &&
                    this.NomeCredor.Equals(other.NomeCredor)
                ) && 
                (
                    this.DiaPagamentoSemanal == other.DiaPagamentoSemanal ||
                    this.DiaPagamentoSemanal != null &&
                    this.DiaPagamentoSemanal.Equals(other.DiaPagamentoSemanal)
                ) && 
                (
                    this.DiaPagamentoMensal == other.DiaPagamentoMensal ||
                    this.DiaPagamentoMensal != null &&
                    this.DiaPagamentoMensal.Equals(other.DiaPagamentoMensal)
                ) && 
                (
                    this.DiaPagamentoDecendialPrimeiro == other.DiaPagamentoDecendialPrimeiro ||
                    this.DiaPagamentoDecendialPrimeiro != null &&
                    this.DiaPagamentoDecendialPrimeiro.Equals(other.DiaPagamentoDecendialPrimeiro)
                ) && 
                (
                    this.DiaPagamentoDecendialSegundo == other.DiaPagamentoDecendialSegundo ||
                    this.DiaPagamentoDecendialSegundo != null &&
                    this.DiaPagamentoDecendialSegundo.Equals(other.DiaPagamentoDecendialSegundo)
                ) && 
                (
                    this.DiaPagamentoDecendialTerceiro == other.DiaPagamentoDecendialTerceiro ||
                    this.DiaPagamentoDecendialTerceiro != null &&
                    this.DiaPagamentoDecendialTerceiro.Equals(other.DiaPagamentoDecendialTerceiro)
                ) && 
                (
                    this.DiaPagamentoQuinzenalPrimeiro == other.DiaPagamentoQuinzenalPrimeiro ||
                    this.DiaPagamentoQuinzenalPrimeiro != null &&
                    this.DiaPagamentoQuinzenalPrimeiro.Equals(other.DiaPagamentoQuinzenalPrimeiro)
                ) && 
                (
                    this.DiaPagamentoQuinzenalSegundo == other.DiaPagamentoQuinzenalSegundo ||
                    this.DiaPagamentoQuinzenalSegundo != null &&
                    this.DiaPagamentoQuinzenalSegundo.Equals(other.DiaPagamentoQuinzenalSegundo)
                ) && 
                (
                    this.Banco == other.Banco ||
                    this.Banco != null &&
                    this.Banco.Equals(other.Banco)
                ) && 
                (
                    this.Agencia == other.Agencia ||
                    this.Agencia != null &&
                    this.Agencia.Equals(other.Agencia)
                ) && 
                (
                    this.DigitoAgencia == other.DigitoAgencia ||
                    this.DigitoAgencia != null &&
                    this.DigitoAgencia.Equals(other.DigitoAgencia)
                ) && 
                (
                    this.ContaCorrente == other.ContaCorrente ||
                    this.ContaCorrente != null &&
                    this.ContaCorrente.Equals(other.ContaCorrente)
                ) && 
                (
                    this.DigitoContaCorrente == other.DigitoContaCorrente ||
                    this.DigitoContaCorrente != null &&
                    this.DigitoContaCorrente.Equals(other.DigitoContaCorrente)
                ) && 
                (
                    this.CredorBanco == other.CredorBanco ||
                    this.CredorBanco != null &&
                    this.CredorBanco.Equals(other.CredorBanco)
                ) && 
                (
                    this.PercentualRAV == other.PercentualRAV ||
                    this.PercentualRAV != null &&
                    this.PercentualRAV.Equals(other.PercentualRAV)
                ) && 
                (
                    this.RecebeRAV == other.RecebeRAV ||
                    this.RecebeRAV != null &&
                    this.RecebeRAV.Equals(other.RecebeRAV)
                ) && 
                (
                    this.PercentualMultiplica == other.PercentualMultiplica ||
                    this.PercentualMultiplica != null &&
                    this.PercentualMultiplica.Equals(other.PercentualMultiplica)
                ) && 
                (
                    this.TaxaAdministrativa == other.TaxaAdministrativa ||
                    this.TaxaAdministrativa != null &&
                    this.TaxaAdministrativa.Equals(other.TaxaAdministrativa)
                ) && 
                (
                    this.TaxaBanco == other.TaxaBanco ||
                    this.TaxaBanco != null &&
                    this.TaxaBanco.Equals(other.TaxaBanco)
                ) && 
                (
                    this.LimiteRAV == other.LimiteRAV ||
                    this.LimiteRAV != null &&
                    this.LimiteRAV.Equals(other.LimiteRAV)
                ) && 
                (
                    this.IdCredorRAV == other.IdCredorRAV ||
                    this.IdCredorRAV != null &&
                    this.IdCredorRAV.Equals(other.IdCredorRAV)
                ) && 
                (
                    this.Periodicidade == other.Periodicidade ||
                    this.Periodicidade != null &&
                    this.Periodicidade.Equals(other.Periodicidade)
                ) && 
                (
                    this.IdPessoaJuridica == other.IdPessoaJuridica ||
                    this.IdPessoaJuridica != null &&
                    this.IdPessoaJuridica.Equals(other.IdPessoaJuridica)
                ) && 
                (
                    this.FlagEscritorioCobranca == other.FlagEscritorioCobranca ||
                    this.FlagEscritorioCobranca != null &&
                    this.FlagEscritorioCobranca.Equals(other.FlagEscritorioCobranca)
                ) && 
                (
                    this.Prefixo == other.Prefixo ||
                    this.Prefixo != null &&
                    this.Prefixo.Equals(other.Prefixo)
                ) && 
                (
                    this.Ativo == other.Ativo ||
                    this.Ativo != null &&
                    this.Ativo.Equals(other.Ativo)
                ) && 
                (
                    this.TelefonesEscritoriosCobranca == other.TelefonesEscritoriosCobranca ||
                    this.TelefonesEscritoriosCobranca != null &&
                    this.TelefonesEscritoriosCobranca.SequenceEqual(other.TelefonesEscritoriosCobranca)
                ) && 
                (
                    this.NomeContato == other.NomeContato ||
                    this.NomeContato != null &&
                    this.NomeContato.Equals(other.NomeContato)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.NomeLogradouro == other.NomeLogradouro ||
                    this.NomeLogradouro != null &&
                    this.NomeLogradouro.Equals(other.NomeLogradouro)
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
                    this.Cep == other.Cep ||
                    this.Cep != null &&
                    this.Cep.Equals(other.Cep)
                ) && 
                (
                    this.Uf == other.Uf ||
                    this.Uf != null &&
                    this.Uf.Equals(other.Uf)
                ) && 
                (
                    this.Responsavel == other.Responsavel ||
                    this.Responsavel != null &&
                    this.Responsavel.Equals(other.Responsavel)
                ) && 
                (
                    this.FlagSegundaViaAcordo == other.FlagSegundaViaAcordo ||
                    this.FlagSegundaViaAcordo != null &&
                    this.FlagSegundaViaAcordo.Equals(other.FlagSegundaViaAcordo)
                ) && 
                (
                    this.ValorMinimoParcela == other.ValorMinimoParcela ||
                    this.ValorMinimoParcela != null &&
                    this.ValorMinimoParcela.Equals(other.ValorMinimoParcela)
                ) && 
                (
                    this.DescontoMaximo == other.DescontoMaximo ||
                    this.DescontoMaximo != null &&
                    this.DescontoMaximo.Equals(other.DescontoMaximo)
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
                
                if (this.NomeCredor != null)
                    hash = hash * 59 + this.NomeCredor.GetHashCode();
                
                if (this.DiaPagamentoSemanal != null)
                    hash = hash * 59 + this.DiaPagamentoSemanal.GetHashCode();
                
                if (this.DiaPagamentoMensal != null)
                    hash = hash * 59 + this.DiaPagamentoMensal.GetHashCode();
                
                if (this.DiaPagamentoDecendialPrimeiro != null)
                    hash = hash * 59 + this.DiaPagamentoDecendialPrimeiro.GetHashCode();
                
                if (this.DiaPagamentoDecendialSegundo != null)
                    hash = hash * 59 + this.DiaPagamentoDecendialSegundo.GetHashCode();
                
                if (this.DiaPagamentoDecendialTerceiro != null)
                    hash = hash * 59 + this.DiaPagamentoDecendialTerceiro.GetHashCode();
                
                if (this.DiaPagamentoQuinzenalPrimeiro != null)
                    hash = hash * 59 + this.DiaPagamentoQuinzenalPrimeiro.GetHashCode();
                
                if (this.DiaPagamentoQuinzenalSegundo != null)
                    hash = hash * 59 + this.DiaPagamentoQuinzenalSegundo.GetHashCode();
                
                if (this.Banco != null)
                    hash = hash * 59 + this.Banco.GetHashCode();
                
                if (this.Agencia != null)
                    hash = hash * 59 + this.Agencia.GetHashCode();
                
                if (this.DigitoAgencia != null)
                    hash = hash * 59 + this.DigitoAgencia.GetHashCode();
                
                if (this.ContaCorrente != null)
                    hash = hash * 59 + this.ContaCorrente.GetHashCode();
                
                if (this.DigitoContaCorrente != null)
                    hash = hash * 59 + this.DigitoContaCorrente.GetHashCode();
                
                if (this.CredorBanco != null)
                    hash = hash * 59 + this.CredorBanco.GetHashCode();
                
                if (this.PercentualRAV != null)
                    hash = hash * 59 + this.PercentualRAV.GetHashCode();
                
                if (this.RecebeRAV != null)
                    hash = hash * 59 + this.RecebeRAV.GetHashCode();
                
                if (this.PercentualMultiplica != null)
                    hash = hash * 59 + this.PercentualMultiplica.GetHashCode();
                
                if (this.TaxaAdministrativa != null)
                    hash = hash * 59 + this.TaxaAdministrativa.GetHashCode();
                
                if (this.TaxaBanco != null)
                    hash = hash * 59 + this.TaxaBanco.GetHashCode();
                
                if (this.LimiteRAV != null)
                    hash = hash * 59 + this.LimiteRAV.GetHashCode();
                
                if (this.IdCredorRAV != null)
                    hash = hash * 59 + this.IdCredorRAV.GetHashCode();
                
                if (this.Periodicidade != null)
                    hash = hash * 59 + this.Periodicidade.GetHashCode();
                
                if (this.IdPessoaJuridica != null)
                    hash = hash * 59 + this.IdPessoaJuridica.GetHashCode();
                
                if (this.FlagEscritorioCobranca != null)
                    hash = hash * 59 + this.FlagEscritorioCobranca.GetHashCode();
                
                if (this.Prefixo != null)
                    hash = hash * 59 + this.Prefixo.GetHashCode();
                
                if (this.Ativo != null)
                    hash = hash * 59 + this.Ativo.GetHashCode();
                
                if (this.TelefonesEscritoriosCobranca != null)
                    hash = hash * 59 + this.TelefonesEscritoriosCobranca.GetHashCode();
                
                if (this.NomeContato != null)
                    hash = hash * 59 + this.NomeContato.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.NomeLogradouro != null)
                    hash = hash * 59 + this.NomeLogradouro.GetHashCode();
                
                if (this.NumeroEndereco != null)
                    hash = hash * 59 + this.NumeroEndereco.GetHashCode();
                
                if (this.ComplementoEndereco != null)
                    hash = hash * 59 + this.ComplementoEndereco.GetHashCode();
                
                if (this.Bairro != null)
                    hash = hash * 59 + this.Bairro.GetHashCode();
                
                if (this.Cidade != null)
                    hash = hash * 59 + this.Cidade.GetHashCode();
                
                if (this.Cep != null)
                    hash = hash * 59 + this.Cep.GetHashCode();
                
                if (this.Uf != null)
                    hash = hash * 59 + this.Uf.GetHashCode();
                
                if (this.Responsavel != null)
                    hash = hash * 59 + this.Responsavel.GetHashCode();
                
                if (this.FlagSegundaViaAcordo != null)
                    hash = hash * 59 + this.FlagSegundaViaAcordo.GetHashCode();
                
                if (this.ValorMinimoParcela != null)
                    hash = hash * 59 + this.ValorMinimoParcela.GetHashCode();
                
                if (this.DescontoMaximo != null)
                    hash = hash * 59 + this.DescontoMaximo.GetHashCode();
                
                return hash;
            }
        }

    }
}
