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
    public partial class CredorPersist :  IEquatable<CredorPersist>
    { 
    
        /// <summary>
        /// creditor persist receives rav
        /// </summary>
        /// <value>creditor persist receives rav</value>
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
        /// creditor request periodicity
        /// </summary>
        /// <value>creditor request periodicity</value>
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
        /// creditor persist receives rav
        /// </summary>
        /// <value>creditor persist receives rav</value>
        [DataMember(Name="recebeRAV", EmitDefaultValue=false)]
        public RecebeRAVEnum? RecebeRAV { get; set; }
    
        /// <summary>
        /// creditor request periodicity
        /// </summary>
        /// <value>creditor request periodicity</value>
        [DataMember(Name="periodicidade", EmitDefaultValue=false)]
        public PeriodicidadeEnum? Periodicidade { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CredorPersist" /> class.
        /// Initializes a new instance of the <see cref="CredorPersist" />class.
        /// </summary>
        /// <param name="TelefonesEscritoriosCobranca">lender persist phones.</param>
        /// <param name="NomeCredor">lender persist name lender.</param>
        /// <param name="DiaPagamentoSemanal">creditor persist weekly payment.</param>
        /// <param name="DiaPagamentoMensal">creditor persist monthly payment.</param>
        /// <param name="DiaPagamentoDecendialPrimeiro">lender pays off the first ten-day payment.</param>
        /// <param name="DiaPagamentoDecendialSegundo">lender pays second decimal payment.</param>
        /// <param name="DiaPagamentoDecendialTerceiro">creditor replies third decimal payment.</param>
        /// <param name="DiaPagamentoQuinzenalPrimeiro">lender replies biweekly payment first.</param>
        /// <param name="DiaPagamentoQuinzenalSegundo">lender replies biweekly payment first.</param>
        /// <param name="Banco">bank lender persist.</param>
        /// <param name="Agencia">lender persist agency.</param>
        /// <param name="DigitoAgencia">lender persist agency digit.</param>
        /// <param name="ContaCorrente">creditor persist checking account.</param>
        /// <param name="DigitoContaCorrente">current account lender.</param>
        /// <param name="CredorBanco">lender persist bank creditor.</param>
        /// <param name="PercentualRAV">percent rav persist creditor (required).</param>
        /// <param name="RecebeRAV">creditor persist receives rav.</param>
        /// <param name="PercentualMultiplica">percentage persist creditor multiplies.</param>
        /// <param name="TaxaAdministrativa">lender persist rate adm.</param>
        /// <param name="TaxaBanco">creditor bank rate persist.</param>
        /// <param name="LimiteRAV">creditor persist limit rav.</param>
        /// <param name="IdCredorRAV">creditor persist id creditor rav (required).</param>
        /// <param name="Periodicidade">creditor request periodicity (required).</param>
        /// <param name="IdPessoaJuridica">creditor request legal id person (required).</param>
        /// <param name="FlagEscritorioCobranca">creditor persist flag billing desk.</param>
        /// <param name="Prefixo">creditor persist prefix.</param>
        /// <param name="Ativo">creditor persist flag active.</param>
        /// <param name="NomeContato">creditor persist contact.</param>
        /// <param name="Email">creditor persist email.</param>
        /// <param name="NomeLogradouro">lender persist public place.</param>
        /// <param name="NumeroEndereco">creditor persist address number.</param>
        /// <param name="ComplementoEndereco">lender persist complement.</param>
        /// <param name="Bairro">lender persist neighborhood.</param>
        /// <param name="Cidade">lender persist city.</param>
        /// <param name="Cep">lender persist cep.</param>
        /// <param name="Uf">lender persist uf.</param>
        /// <param name="Responsavel">lender responsible persist.</param>
        /// <param name="FlagSegundaViaAcordo">creditor persist flag second via arrangement.</param>
        /// <param name="ValorMinimoParcela">lender persist minimum value plot.</param>
        /// <param name="DescontoMaximo">maximum discount creditor persist.</param>

        public CredorPersist(List<TelefoneEscritorioCobrancaDTO> TelefonesEscritoriosCobranca = null, string NomeCredor = null, int? DiaPagamentoSemanal = null, int? DiaPagamentoMensal = null, int? DiaPagamentoDecendialPrimeiro = null, int? DiaPagamentoDecendialSegundo = null, int? DiaPagamentoDecendialTerceiro = null, int? DiaPagamentoQuinzenalPrimeiro = null, int? DiaPagamentoQuinzenalSegundo = null, int? Banco = null, int? Agencia = null, string DigitoAgencia = null, string ContaCorrente = null, string DigitoContaCorrente = null, bool? CredorBanco = null, double? PercentualRAV = null, RecebeRAVEnum? RecebeRAV = null, double? PercentualMultiplica = null, double? TaxaAdministrativa = null, double? TaxaBanco = null, double? LimiteRAV = null, long? IdCredorRAV = null, PeriodicidadeEnum? Periodicidade = null, long? IdPessoaJuridica = null, bool? FlagEscritorioCobranca = null, string Prefixo = null, bool? Ativo = null, string NomeContato = null, string Email = null, string NomeLogradouro = null, int? NumeroEndereco = null, string ComplementoEndereco = null, string Bairro = null, string Cidade = null, string Cep = null, string Uf = null, string Responsavel = null, int? FlagSegundaViaAcordo = null, double? ValorMinimoParcela = null, double? DescontoMaximo = null)
        {
            // to ensure "PercentualRAV" is required (not null)
            if (PercentualRAV == null)
            {
                throw new InvalidDataException("PercentualRAV is a required property for CredorPersist and cannot be null");
            }
            else
            {
                this.PercentualRAV = PercentualRAV;
            }
            // to ensure "IdCredorRAV" is required (not null)
            if (IdCredorRAV == null)
            {
                throw new InvalidDataException("IdCredorRAV is a required property for CredorPersist and cannot be null");
            }
            else
            {
                this.IdCredorRAV = IdCredorRAV;
            }
            // to ensure "Periodicidade" is required (not null)
            if (Periodicidade == null)
            {
                throw new InvalidDataException("Periodicidade is a required property for CredorPersist and cannot be null");
            }
            else
            {
                this.Periodicidade = Periodicidade;
            }
            // to ensure "IdPessoaJuridica" is required (not null)
            if (IdPessoaJuridica == null)
            {
                throw new InvalidDataException("IdPessoaJuridica is a required property for CredorPersist and cannot be null");
            }
            else
            {
                this.IdPessoaJuridica = IdPessoaJuridica;
            }
            this.TelefonesEscritoriosCobranca = TelefonesEscritoriosCobranca;
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
            this.RecebeRAV = RecebeRAV;
            this.PercentualMultiplica = PercentualMultiplica;
            this.TaxaAdministrativa = TaxaAdministrativa;
            this.TaxaBanco = TaxaBanco;
            this.LimiteRAV = LimiteRAV;
            this.FlagEscritorioCobranca = FlagEscritorioCobranca;
            this.Prefixo = Prefixo;
            this.Ativo = Ativo;
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
        /// lender persist phones
        /// </summary>
        /// <value>lender persist phones</value>
        [DataMember(Name="telefonesEscritoriosCobranca", EmitDefaultValue=false)]
        public List<TelefoneEscritorioCobrancaDTO> TelefonesEscritoriosCobranca { get; set; }
    
        /// <summary>
        /// lender persist name lender
        /// </summary>
        /// <value>lender persist name lender</value>
        [DataMember(Name="nomeCredor", EmitDefaultValue=false)]
        public string NomeCredor { get; set; }
    
        /// <summary>
        /// creditor persist weekly payment
        /// </summary>
        /// <value>creditor persist weekly payment</value>
        [DataMember(Name="diaPagamentoSemanal", EmitDefaultValue=false)]
        public int? DiaPagamentoSemanal { get; set; }
    
        /// <summary>
        /// creditor persist monthly payment
        /// </summary>
        /// <value>creditor persist monthly payment</value>
        [DataMember(Name="diaPagamentoMensal", EmitDefaultValue=false)]
        public int? DiaPagamentoMensal { get; set; }
    
        /// <summary>
        /// lender pays off the first ten-day payment
        /// </summary>
        /// <value>lender pays off the first ten-day payment</value>
        [DataMember(Name="diaPagamentoDecendialPrimeiro", EmitDefaultValue=false)]
        public int? DiaPagamentoDecendialPrimeiro { get; set; }
    
        /// <summary>
        /// lender pays second decimal payment
        /// </summary>
        /// <value>lender pays second decimal payment</value>
        [DataMember(Name="diaPagamentoDecendialSegundo", EmitDefaultValue=false)]
        public int? DiaPagamentoDecendialSegundo { get; set; }
    
        /// <summary>
        /// creditor replies third decimal payment
        /// </summary>
        /// <value>creditor replies third decimal payment</value>
        [DataMember(Name="diaPagamentoDecendialTerceiro", EmitDefaultValue=false)]
        public int? DiaPagamentoDecendialTerceiro { get; set; }
    
        /// <summary>
        /// lender replies biweekly payment first
        /// </summary>
        /// <value>lender replies biweekly payment first</value>
        [DataMember(Name="diaPagamentoQuinzenalPrimeiro", EmitDefaultValue=false)]
        public int? DiaPagamentoQuinzenalPrimeiro { get; set; }
    
        /// <summary>
        /// lender replies biweekly payment first
        /// </summary>
        /// <value>lender replies biweekly payment first</value>
        [DataMember(Name="diaPagamentoQuinzenalSegundo", EmitDefaultValue=false)]
        public int? DiaPagamentoQuinzenalSegundo { get; set; }
    
        /// <summary>
        /// bank lender persist
        /// </summary>
        /// <value>bank lender persist</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public int? Banco { get; set; }
    
        /// <summary>
        /// lender persist agency
        /// </summary>
        /// <value>lender persist agency</value>
        [DataMember(Name="agencia", EmitDefaultValue=false)]
        public int? Agencia { get; set; }
    
        /// <summary>
        /// lender persist agency digit
        /// </summary>
        /// <value>lender persist agency digit</value>
        [DataMember(Name="digitoAgencia", EmitDefaultValue=false)]
        public string DigitoAgencia { get; set; }
    
        /// <summary>
        /// creditor persist checking account
        /// </summary>
        /// <value>creditor persist checking account</value>
        [DataMember(Name="contaCorrente", EmitDefaultValue=false)]
        public string ContaCorrente { get; set; }
    
        /// <summary>
        /// current account lender
        /// </summary>
        /// <value>current account lender</value>
        [DataMember(Name="digitoContaCorrente", EmitDefaultValue=false)]
        public string DigitoContaCorrente { get; set; }
    
        /// <summary>
        /// lender persist bank creditor
        /// </summary>
        /// <value>lender persist bank creditor</value>
        [DataMember(Name="credorBanco", EmitDefaultValue=false)]
        public bool? CredorBanco { get; set; }
    
        /// <summary>
        /// percent rav persist creditor
        /// </summary>
        /// <value>percent rav persist creditor</value>
        [DataMember(Name="percentualRAV", EmitDefaultValue=false)]
        public double? PercentualRAV { get; set; }
    
        /// <summary>
        /// percentage persist creditor multiplies
        /// </summary>
        /// <value>percentage persist creditor multiplies</value>
        [DataMember(Name="percentualMultiplica", EmitDefaultValue=false)]
        public double? PercentualMultiplica { get; set; }
    
        /// <summary>
        /// lender persist rate adm
        /// </summary>
        /// <value>lender persist rate adm</value>
        [DataMember(Name="taxaAdministrativa", EmitDefaultValue=false)]
        public double? TaxaAdministrativa { get; set; }
    
        /// <summary>
        /// creditor bank rate persist
        /// </summary>
        /// <value>creditor bank rate persist</value>
        [DataMember(Name="taxaBanco", EmitDefaultValue=false)]
        public double? TaxaBanco { get; set; }
    
        /// <summary>
        /// creditor persist limit rav
        /// </summary>
        /// <value>creditor persist limit rav</value>
        [DataMember(Name="limiteRAV", EmitDefaultValue=false)]
        public double? LimiteRAV { get; set; }
    
        /// <summary>
        /// creditor persist id creditor rav
        /// </summary>
        /// <value>creditor persist id creditor rav</value>
        [DataMember(Name="idCredorRAV", EmitDefaultValue=false)]
        public long? IdCredorRAV { get; set; }
    
        /// <summary>
        /// creditor request legal id person
        /// </summary>
        /// <value>creditor request legal id person</value>
        [DataMember(Name="idPessoaJuridica", EmitDefaultValue=false)]
        public long? IdPessoaJuridica { get; set; }
    
        /// <summary>
        /// creditor persist flag billing desk
        /// </summary>
        /// <value>creditor persist flag billing desk</value>
        [DataMember(Name="flagEscritorioCobranca", EmitDefaultValue=false)]
        public bool? FlagEscritorioCobranca { get; set; }
    
        /// <summary>
        /// creditor persist prefix
        /// </summary>
        /// <value>creditor persist prefix</value>
        [DataMember(Name="prefixo", EmitDefaultValue=false)]
        public string Prefixo { get; set; }
    
        /// <summary>
        /// creditor persist flag active
        /// </summary>
        /// <value>creditor persist flag active</value>
        [DataMember(Name="ativo", EmitDefaultValue=false)]
        public bool? Ativo { get; set; }
    
        /// <summary>
        /// creditor persist contact
        /// </summary>
        /// <value>creditor persist contact</value>
        [DataMember(Name="nomeContato", EmitDefaultValue=false)]
        public string NomeContato { get; set; }
    
        /// <summary>
        /// creditor persist email
        /// </summary>
        /// <value>creditor persist email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// lender persist public place
        /// </summary>
        /// <value>lender persist public place</value>
        [DataMember(Name="nomeLogradouro", EmitDefaultValue=false)]
        public string NomeLogradouro { get; set; }
    
        /// <summary>
        /// creditor persist address number
        /// </summary>
        /// <value>creditor persist address number</value>
        [DataMember(Name="numeroEndereco", EmitDefaultValue=false)]
        public int? NumeroEndereco { get; set; }
    
        /// <summary>
        /// lender persist complement
        /// </summary>
        /// <value>lender persist complement</value>
        [DataMember(Name="complementoEndereco", EmitDefaultValue=false)]
        public string ComplementoEndereco { get; set; }
    
        /// <summary>
        /// lender persist neighborhood
        /// </summary>
        /// <value>lender persist neighborhood</value>
        [DataMember(Name="bairro", EmitDefaultValue=false)]
        public string Bairro { get; set; }
    
        /// <summary>
        /// lender persist city
        /// </summary>
        /// <value>lender persist city</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// lender persist cep
        /// </summary>
        /// <value>lender persist cep</value>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public string Cep { get; set; }
    
        /// <summary>
        /// lender persist uf
        /// </summary>
        /// <value>lender persist uf</value>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }
    
        /// <summary>
        /// lender responsible persist
        /// </summary>
        /// <value>lender responsible persist</value>
        [DataMember(Name="responsavel", EmitDefaultValue=false)]
        public string Responsavel { get; set; }
    
        /// <summary>
        /// creditor persist flag second via arrangement
        /// </summary>
        /// <value>creditor persist flag second via arrangement</value>
        [DataMember(Name="flagSegundaViaAcordo", EmitDefaultValue=false)]
        public int? FlagSegundaViaAcordo { get; set; }
    
        /// <summary>
        /// lender persist minimum value plot
        /// </summary>
        /// <value>lender persist minimum value plot</value>
        [DataMember(Name="valorMinimoParcela", EmitDefaultValue=false)]
        public double? ValorMinimoParcela { get; set; }
    
        /// <summary>
        /// maximum discount creditor persist
        /// </summary>
        /// <value>maximum discount creditor persist</value>
        [DataMember(Name="descontoMaximo", EmitDefaultValue=false)]
        public double? DescontoMaximo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CredorPersist {\n");
            sb.Append("  TelefonesEscritoriosCobranca: ").Append(TelefonesEscritoriosCobranca).Append("\n");
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
            return this.Equals(obj as CredorPersist);
        }

        /// <summary>
        /// Returns true if CredorPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of CredorPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CredorPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TelefonesEscritoriosCobranca == other.TelefonesEscritoriosCobranca ||
                    this.TelefonesEscritoriosCobranca != null &&
                    this.TelefonesEscritoriosCobranca.SequenceEqual(other.TelefonesEscritoriosCobranca)
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
                
                if (this.TelefonesEscritoriosCobranca != null)
                    hash = hash * 59 + this.TelefonesEscritoriosCobranca.GetHashCode();
                
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
