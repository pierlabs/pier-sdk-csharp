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
        /// Identifica se o credor tem um RAV associado, e seu tipo
        /// </summary>
        /// <value>Identifica se o credor tem um RAV associado, e seu tipo</value>
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
        /// Periodicidade do pagamento
        /// </summary>
        /// <value>Periodicidade do pagamento</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PeriodicidadeEnum {
            
            [EnumMember(Value = "NENHUM")]
            Nenhum,
            
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
        /// Identifica se o credor tem um RAV associado, e seu tipo
        /// </summary>
        /// <value>Identifica se o credor tem um RAV associado, e seu tipo</value>
        [DataMember(Name="recebeRAV", EmitDefaultValue=false)]
        public RecebeRAVEnum? RecebeRAV { get; set; }
    
        /// <summary>
        /// Periodicidade do pagamento
        /// </summary>
        /// <value>Periodicidade do pagamento</value>
        [DataMember(Name="periodicidade", EmitDefaultValue=false)]
        public PeriodicidadeEnum? Periodicidade { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CredorPersist" /> class.
        /// Initializes a new instance of the <see cref="CredorPersist" />class.
        /// </summary>
        /// <param name="TelefonesEscritoriosCobranca">Telefones do credor.</param>
        /// <param name="NomeCredor">Nome do credor.</param>
        /// <param name="DiaPagamentoSemanal">Dia do pagamento caso seja semanal.</param>
        /// <param name="DiaPagamentoMensal">Dia do pagamento caso seja mensal.</param>
        /// <param name="DiaPagamentoDecendialPrimeiro">Dia do primeiro pagamento caso seja decendial.</param>
        /// <param name="DiaPagamentoDecendialSegundo">Dia do segundo pagamento caso seja decendial.</param>
        /// <param name="DiaPagamentoDecendialTerceiro">Dia do terceiro pagamento caso seja decendial.</param>
        /// <param name="DiaPagamentoQuinzenalPrimeiro">Dia do primeiro pagamento caso seja quinzenal.</param>
        /// <param name="DiaPagamentoQuinzenalSegundo">Dia do segundo pagamento caso seja quinzenal.</param>
        /// <param name="Banco">Banco do credor.</param>
        /// <param name="Agencia">Ag\u00EAncia do credor.</param>
        /// <param name="DigitoAgencia">D\u00EDgito da ag\u00EAncia.</param>
        /// <param name="ContaCorrente">Conta corrente do credor.</param>
        /// <param name="DigitoContaCorrente">D\u00EDgito da conta corrente.</param>
        /// <param name="CredorBanco">Banco credor.</param>
        /// <param name="PercentualRAV">Percentual RAV (required).</param>
        /// <param name="RecebeRAV">Identifica se o credor tem um RAV associado, e seu tipo.</param>
        /// <param name="PercentualMultiplica">Percentual de multiplica\u00E7\u00E3o utilizado para gerar taxa de desconto do RAV.</param>
        /// <param name="TaxaAdministrativa">Taxa administrativa usada para gerar o valor do RAV.</param>
        /// <param name="TaxaBanco">Taxa do banco RAV.</param>
        /// <param name="LimiteRAV">Valor limite do RAV.</param>
        /// <param name="IdCredorRAV">Identificador da RAV do credor (required).</param>
        /// <param name="Periodicidade">Periodicidade do pagamento (required).</param>
        /// <param name="IdPessoaJuridica">Identificador da pessoa jur\u00EDdica associada ao credor (required).</param>
        /// <param name="FlagEscritorioCobranca">Flag para controle interno.</param>
        /// <param name="Prefixo">Prefixo utilizado pelo escrit\u00F3rio de cobran\u00E7a.</param>
        /// <param name="Ativo">Identifica se o escrit\u00F3rio de cobran\u00E7a est\u00E1 ativo.</param>
        /// <param name="NomeContato">Nome para contato no escrit\u00F3rio de cobran\u00E7a.</param>
        /// <param name="Email">Email do contato no escrit\u00F3rio de cobran\u00E7a.</param>
        /// <param name="NomeLogradouro">Logradouro do credor.</param>
        /// <param name="NumeroEndereco">N\u00FAmero do endere\u00E7o do credor.</param>
        /// <param name="ComplementoEndereco">Complemento do endere\u00E7o do credor.</param>
        /// <param name="Bairro">Bairro do endere\u00E7o do credor.</param>
        /// <param name="Cidade">Cidade do endere\u00E7o do credor.</param>
        /// <param name="Cep">CEP do endere\u00E7o do credor.</param>
        /// <param name="Uf">UF do endere\u00E7o do credor.</param>
        /// <param name="Responsavel">Respons\u00E1vel pelo credor.</param>
        /// <param name="FlagSegundaViaAcordo">Identifica se h\u00E1 uma segunda via do acordo firmado.</param>
        /// <param name="ValorMinimoParcela">Valor m\u00EDnimo da parcela cobrado pelo escrit\u00F3rio de cobran\u00E7a.</param>
        /// <param name="DescontoMaximo">Desconto m\u00E1ximo estabelecido pelo escrit\u00F3rio de cobran\u00E7a.</param>

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
        /// Telefones do credor
        /// </summary>
        /// <value>Telefones do credor</value>
        [DataMember(Name="telefonesEscritoriosCobranca", EmitDefaultValue=false)]
        public List<TelefoneEscritorioCobrancaDTO> TelefonesEscritoriosCobranca { get; set; }
    
        /// <summary>
        /// Nome do credor
        /// </summary>
        /// <value>Nome do credor</value>
        [DataMember(Name="nomeCredor", EmitDefaultValue=false)]
        public string NomeCredor { get; set; }
    
        /// <summary>
        /// Dia do pagamento caso seja semanal
        /// </summary>
        /// <value>Dia do pagamento caso seja semanal</value>
        [DataMember(Name="diaPagamentoSemanal", EmitDefaultValue=false)]
        public int? DiaPagamentoSemanal { get; set; }
    
        /// <summary>
        /// Dia do pagamento caso seja mensal
        /// </summary>
        /// <value>Dia do pagamento caso seja mensal</value>
        [DataMember(Name="diaPagamentoMensal", EmitDefaultValue=false)]
        public int? DiaPagamentoMensal { get; set; }
    
        /// <summary>
        /// Dia do primeiro pagamento caso seja decendial
        /// </summary>
        /// <value>Dia do primeiro pagamento caso seja decendial</value>
        [DataMember(Name="diaPagamentoDecendialPrimeiro", EmitDefaultValue=false)]
        public int? DiaPagamentoDecendialPrimeiro { get; set; }
    
        /// <summary>
        /// Dia do segundo pagamento caso seja decendial
        /// </summary>
        /// <value>Dia do segundo pagamento caso seja decendial</value>
        [DataMember(Name="diaPagamentoDecendialSegundo", EmitDefaultValue=false)]
        public int? DiaPagamentoDecendialSegundo { get; set; }
    
        /// <summary>
        /// Dia do terceiro pagamento caso seja decendial
        /// </summary>
        /// <value>Dia do terceiro pagamento caso seja decendial</value>
        [DataMember(Name="diaPagamentoDecendialTerceiro", EmitDefaultValue=false)]
        public int? DiaPagamentoDecendialTerceiro { get; set; }
    
        /// <summary>
        /// Dia do primeiro pagamento caso seja quinzenal
        /// </summary>
        /// <value>Dia do primeiro pagamento caso seja quinzenal</value>
        [DataMember(Name="diaPagamentoQuinzenalPrimeiro", EmitDefaultValue=false)]
        public int? DiaPagamentoQuinzenalPrimeiro { get; set; }
    
        /// <summary>
        /// Dia do segundo pagamento caso seja quinzenal
        /// </summary>
        /// <value>Dia do segundo pagamento caso seja quinzenal</value>
        [DataMember(Name="diaPagamentoQuinzenalSegundo", EmitDefaultValue=false)]
        public int? DiaPagamentoQuinzenalSegundo { get; set; }
    
        /// <summary>
        /// Banco do credor
        /// </summary>
        /// <value>Banco do credor</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public int? Banco { get; set; }
    
        /// <summary>
        /// Ag\u00EAncia do credor
        /// </summary>
        /// <value>Ag\u00EAncia do credor</value>
        [DataMember(Name="agencia", EmitDefaultValue=false)]
        public int? Agencia { get; set; }
    
        /// <summary>
        /// D\u00EDgito da ag\u00EAncia
        /// </summary>
        /// <value>D\u00EDgito da ag\u00EAncia</value>
        [DataMember(Name="digitoAgencia", EmitDefaultValue=false)]
        public string DigitoAgencia { get; set; }
    
        /// <summary>
        /// Conta corrente do credor
        /// </summary>
        /// <value>Conta corrente do credor</value>
        [DataMember(Name="contaCorrente", EmitDefaultValue=false)]
        public string ContaCorrente { get; set; }
    
        /// <summary>
        /// D\u00EDgito da conta corrente
        /// </summary>
        /// <value>D\u00EDgito da conta corrente</value>
        [DataMember(Name="digitoContaCorrente", EmitDefaultValue=false)]
        public string DigitoContaCorrente { get; set; }
    
        /// <summary>
        /// Banco credor
        /// </summary>
        /// <value>Banco credor</value>
        [DataMember(Name="credorBanco", EmitDefaultValue=false)]
        public bool? CredorBanco { get; set; }
    
        /// <summary>
        /// Percentual RAV
        /// </summary>
        /// <value>Percentual RAV</value>
        [DataMember(Name="percentualRAV", EmitDefaultValue=false)]
        public double? PercentualRAV { get; set; }
    
        /// <summary>
        /// Percentual de multiplica\u00E7\u00E3o utilizado para gerar taxa de desconto do RAV
        /// </summary>
        /// <value>Percentual de multiplica\u00E7\u00E3o utilizado para gerar taxa de desconto do RAV</value>
        [DataMember(Name="percentualMultiplica", EmitDefaultValue=false)]
        public double? PercentualMultiplica { get; set; }
    
        /// <summary>
        /// Taxa administrativa usada para gerar o valor do RAV
        /// </summary>
        /// <value>Taxa administrativa usada para gerar o valor do RAV</value>
        [DataMember(Name="taxaAdministrativa", EmitDefaultValue=false)]
        public double? TaxaAdministrativa { get; set; }
    
        /// <summary>
        /// Taxa do banco RAV
        /// </summary>
        /// <value>Taxa do banco RAV</value>
        [DataMember(Name="taxaBanco", EmitDefaultValue=false)]
        public double? TaxaBanco { get; set; }
    
        /// <summary>
        /// Valor limite do RAV
        /// </summary>
        /// <value>Valor limite do RAV</value>
        [DataMember(Name="limiteRAV", EmitDefaultValue=false)]
        public double? LimiteRAV { get; set; }
    
        /// <summary>
        /// Identificador da RAV do credor
        /// </summary>
        /// <value>Identificador da RAV do credor</value>
        [DataMember(Name="idCredorRAV", EmitDefaultValue=false)]
        public long? IdCredorRAV { get; set; }
    
        /// <summary>
        /// Identificador da pessoa jur\u00EDdica associada ao credor
        /// </summary>
        /// <value>Identificador da pessoa jur\u00EDdica associada ao credor</value>
        [DataMember(Name="idPessoaJuridica", EmitDefaultValue=false)]
        public long? IdPessoaJuridica { get; set; }
    
        /// <summary>
        /// Flag para controle interno
        /// </summary>
        /// <value>Flag para controle interno</value>
        [DataMember(Name="flagEscritorioCobranca", EmitDefaultValue=false)]
        public bool? FlagEscritorioCobranca { get; set; }
    
        /// <summary>
        /// Prefixo utilizado pelo escrit\u00F3rio de cobran\u00E7a
        /// </summary>
        /// <value>Prefixo utilizado pelo escrit\u00F3rio de cobran\u00E7a</value>
        [DataMember(Name="prefixo", EmitDefaultValue=false)]
        public string Prefixo { get; set; }
    
        /// <summary>
        /// Identifica se o escrit\u00F3rio de cobran\u00E7a est\u00E1 ativo
        /// </summary>
        /// <value>Identifica se o escrit\u00F3rio de cobran\u00E7a est\u00E1 ativo</value>
        [DataMember(Name="ativo", EmitDefaultValue=false)]
        public bool? Ativo { get; set; }
    
        /// <summary>
        /// Nome para contato no escrit\u00F3rio de cobran\u00E7a
        /// </summary>
        /// <value>Nome para contato no escrit\u00F3rio de cobran\u00E7a</value>
        [DataMember(Name="nomeContato", EmitDefaultValue=false)]
        public string NomeContato { get; set; }
    
        /// <summary>
        /// Email do contato no escrit\u00F3rio de cobran\u00E7a
        /// </summary>
        /// <value>Email do contato no escrit\u00F3rio de cobran\u00E7a</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Logradouro do credor
        /// </summary>
        /// <value>Logradouro do credor</value>
        [DataMember(Name="nomeLogradouro", EmitDefaultValue=false)]
        public string NomeLogradouro { get; set; }
    
        /// <summary>
        /// N\u00FAmero do endere\u00E7o do credor
        /// </summary>
        /// <value>N\u00FAmero do endere\u00E7o do credor</value>
        [DataMember(Name="numeroEndereco", EmitDefaultValue=false)]
        public int? NumeroEndereco { get; set; }
    
        /// <summary>
        /// Complemento do endere\u00E7o do credor
        /// </summary>
        /// <value>Complemento do endere\u00E7o do credor</value>
        [DataMember(Name="complementoEndereco", EmitDefaultValue=false)]
        public string ComplementoEndereco { get; set; }
    
        /// <summary>
        /// Bairro do endere\u00E7o do credor
        /// </summary>
        /// <value>Bairro do endere\u00E7o do credor</value>
        [DataMember(Name="bairro", EmitDefaultValue=false)]
        public string Bairro { get; set; }
    
        /// <summary>
        /// Cidade do endere\u00E7o do credor
        /// </summary>
        /// <value>Cidade do endere\u00E7o do credor</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// CEP do endere\u00E7o do credor
        /// </summary>
        /// <value>CEP do endere\u00E7o do credor</value>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public string Cep { get; set; }
    
        /// <summary>
        /// UF do endere\u00E7o do credor
        /// </summary>
        /// <value>UF do endere\u00E7o do credor</value>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }
    
        /// <summary>
        /// Respons\u00E1vel pelo credor
        /// </summary>
        /// <value>Respons\u00E1vel pelo credor</value>
        [DataMember(Name="responsavel", EmitDefaultValue=false)]
        public string Responsavel { get; set; }
    
        /// <summary>
        /// Identifica se h\u00E1 uma segunda via do acordo firmado
        /// </summary>
        /// <value>Identifica se h\u00E1 uma segunda via do acordo firmado</value>
        [DataMember(Name="flagSegundaViaAcordo", EmitDefaultValue=false)]
        public int? FlagSegundaViaAcordo { get; set; }
    
        /// <summary>
        /// Valor m\u00EDnimo da parcela cobrado pelo escrit\u00F3rio de cobran\u00E7a
        /// </summary>
        /// <value>Valor m\u00EDnimo da parcela cobrado pelo escrit\u00F3rio de cobran\u00E7a</value>
        [DataMember(Name="valorMinimoParcela", EmitDefaultValue=false)]
        public double? ValorMinimoParcela { get; set; }
    
        /// <summary>
        /// Desconto m\u00E1ximo estabelecido pelo escrit\u00F3rio de cobran\u00E7a
        /// </summary>
        /// <value>Desconto m\u00E1ximo estabelecido pelo escrit\u00F3rio de cobran\u00E7a</value>
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
