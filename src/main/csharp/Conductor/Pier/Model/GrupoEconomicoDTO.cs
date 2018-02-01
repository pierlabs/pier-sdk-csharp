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
    /// Par\u00C3\u00A2metros de requisi\u00C3\u00A7\u00C3\u00A3o para cadastrar grupo econ\u00C3\u00B4mico
    /// </summary>
    [DataContract]
    public partial class GrupoEconomicoDTO :  IEquatable<GrupoEconomicoDTO>
    { 
    
        /// <summary>
        /// Periodicidade do pagamento
        /// </summary>
        /// <value>Periodicidade do pagamento</value>
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
        /// Dia para pagamento semanal
        /// </summary>
        /// <value>Dia para pagamento semanal</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PagamentoSemanalEnum {
            
            [EnumMember(Value = "SEGUNDA")]
            Segunda,
            
            [EnumMember(Value = "TERCA")]
            Terca,
            
            [EnumMember(Value = "QUARTA")]
            Quarta,
            
            [EnumMember(Value = "QUINTA")]
            Quinta,
            
            [EnumMember(Value = "SEXTA")]
            Sexta,
            
            [EnumMember(Value = "SABADO")]
            Sabado,
            
            [EnumMember(Value = "DOMINGO")]
            Domingo
        }

    
        /// <summary>
        /// Indica se o credor recebe RAV e o tipo
        /// </summary>
        /// <value>Indica se o credor recebe RAV e o tipo</value>
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
        [DataMember(Name="periodicidade", EmitDefaultValue=false)]
        public PeriodicidadeEnum? Periodicidade { get; set; }
    
        /// <summary>
        /// Dia para pagamento semanal
        /// </summary>
        /// <value>Dia para pagamento semanal</value>
        [DataMember(Name="pagamentoSemanal", EmitDefaultValue=false)]
        public PagamentoSemanalEnum? PagamentoSemanal { get; set; }
    
        /// <summary>
        /// Indica se o credor recebe RAV e o tipo
        /// </summary>
        /// <value>Indica se o credor recebe RAV e o tipo</value>
        [DataMember(Name="recebeRAV", EmitDefaultValue=false)]
        public RecebeRAVEnum? RecebeRAV { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GrupoEconomicoDTO" /> class.
        /// Initializes a new instance of the <see cref="GrupoEconomicoDTO" />class.
        /// </summary>
        /// <param name="RazaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (required).</param>
        /// <param name="NomeCredor">Nome do credor.</param>
        /// <param name="NumeroReceitaFederal">N\u00C3\u00BAmero da Receita Federal (required).</param>
        /// <param name="InscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual.</param>
        /// <param name="Contato">Nome da pessoa para entrar em contato.</param>
        /// <param name="Banco">C\u00C3\u00B3digo do banco.</param>
        /// <param name="Agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica.</param>
        /// <param name="DigitoAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia.</param>
        /// <param name="ContaCorrente">C\u00C3\u00B3digo da Conta Corrente.</param>
        /// <param name="DigitoContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente.</param>
        /// <param name="Periodicidade">Periodicidade do pagamento (required).</param>
        /// <param name="PagamentoSemanal">Dia para pagamento semanal.</param>
        /// <param name="PagamentoMensal">Dia da data para o pagamento mensal.</param>
        /// <param name="PagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial.</param>
        /// <param name="PagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial.</param>
        /// <param name="PagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial.</param>
        /// <param name="PagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal.</param>
        /// <param name="PagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal.</param>
        /// <param name="PercentualRAV">Valor percentual do RAV do credor (required).</param>
        /// <param name="RecebeRAV">Indica se o credor recebe RAV e o tipo.</param>
        /// <param name="PercentualMultiplica">Percentual Multiplica.</param>
        /// <param name="TaxaAdm">Taxa Administrativa.</param>
        /// <param name="TaxaBanco">Taxa do Banco.</param>
        /// <param name="LimiteRAV">Valor limite do RAV.</param>

        public GrupoEconomicoDTO(string RazaoSocial = null, string NomeCredor = null, string NumeroReceitaFederal = null, string InscricaoEstadual = null, string Contato = null, int? Banco = null, int? Agencia = null, string DigitoAgencia = null, string ContaCorrente = null, string DigitoContaCorrente = null, PeriodicidadeEnum? Periodicidade = null, PagamentoSemanalEnum? PagamentoSemanal = null, int? PagamentoMensal = null, int? PagamentoDecendialPrimeiro = null, int? PagamentoDecendialSegundo = null, int? PagamentoDecendialTerceiro = null, int? PagamentoQuinzenalPrimeiro = null, int? PagamentoQuinzenalSegundo = null, double? PercentualRAV = null, RecebeRAVEnum? RecebeRAV = null, double? PercentualMultiplica = null, double? TaxaAdm = null, double? TaxaBanco = null, double? LimiteRAV = null)
        {
            // to ensure "RazaoSocial" is required (not null)
            if (RazaoSocial == null)
            {
                throw new InvalidDataException("RazaoSocial is a required property for GrupoEconomicoDTO and cannot be null");
            }
            else
            {
                this.RazaoSocial = RazaoSocial;
            }
            // to ensure "NumeroReceitaFederal" is required (not null)
            if (NumeroReceitaFederal == null)
            {
                throw new InvalidDataException("NumeroReceitaFederal is a required property for GrupoEconomicoDTO and cannot be null");
            }
            else
            {
                this.NumeroReceitaFederal = NumeroReceitaFederal;
            }
            // to ensure "Periodicidade" is required (not null)
            if (Periodicidade == null)
            {
                throw new InvalidDataException("Periodicidade is a required property for GrupoEconomicoDTO and cannot be null");
            }
            else
            {
                this.Periodicidade = Periodicidade;
            }
            // to ensure "PercentualRAV" is required (not null)
            if (PercentualRAV == null)
            {
                throw new InvalidDataException("PercentualRAV is a required property for GrupoEconomicoDTO and cannot be null");
            }
            else
            {
                this.PercentualRAV = PercentualRAV;
            }
            this.NomeCredor = NomeCredor;
            this.InscricaoEstadual = InscricaoEstadual;
            this.Contato = Contato;
            this.Banco = Banco;
            this.Agencia = Agencia;
            this.DigitoAgencia = DigitoAgencia;
            this.ContaCorrente = ContaCorrente;
            this.DigitoContaCorrente = DigitoContaCorrente;
            this.PagamentoSemanal = PagamentoSemanal;
            this.PagamentoMensal = PagamentoMensal;
            this.PagamentoDecendialPrimeiro = PagamentoDecendialPrimeiro;
            this.PagamentoDecendialSegundo = PagamentoDecendialSegundo;
            this.PagamentoDecendialTerceiro = PagamentoDecendialTerceiro;
            this.PagamentoQuinzenalPrimeiro = PagamentoQuinzenalPrimeiro;
            this.PagamentoQuinzenalSegundo = PagamentoQuinzenalSegundo;
            this.RecebeRAV = RecebeRAV;
            this.PercentualMultiplica = PercentualMultiplica;
            this.TaxaAdm = TaxaAdm;
            this.TaxaBanco = TaxaBanco;
            this.LimiteRAV = LimiteRAV;
            
        }
        
    
        /// <summary>
        /// Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica
        /// </summary>
        /// <value>Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica</value>
        [DataMember(Name="razaoSocial", EmitDefaultValue=false)]
        public string RazaoSocial { get; set; }
    
        /// <summary>
        /// Nome do credor
        /// </summary>
        /// <value>Nome do credor</value>
        [DataMember(Name="nomeCredor", EmitDefaultValue=false)]
        public string NomeCredor { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero da Receita Federal
        /// </summary>
        /// <value>N\u00C3\u00BAmero da Receita Federal</value>
        [DataMember(Name="numeroReceitaFederal", EmitDefaultValue=false)]
        public string NumeroReceitaFederal { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual
        /// </summary>
        /// <value>N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual</value>
        [DataMember(Name="inscricaoEstadual", EmitDefaultValue=false)]
        public string InscricaoEstadual { get; set; }
    
        /// <summary>
        /// Nome da pessoa para entrar em contato
        /// </summary>
        /// <value>Nome da pessoa para entrar em contato</value>
        [DataMember(Name="contato", EmitDefaultValue=false)]
        public string Contato { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo do banco
        /// </summary>
        /// <value>C\u00C3\u00B3digo do banco</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public int? Banco { get; set; }
    
        /// <summary>
        /// Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica
        /// </summary>
        /// <value>Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica</value>
        [DataMember(Name="agencia", EmitDefaultValue=false)]
        public int? Agencia { get; set; }
    
        /// <summary>
        /// D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia
        /// </summary>
        /// <value>D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia</value>
        [DataMember(Name="digitoAgencia", EmitDefaultValue=false)]
        public string DigitoAgencia { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo da Conta Corrente
        /// </summary>
        /// <value>C\u00C3\u00B3digo da Conta Corrente</value>
        [DataMember(Name="contaCorrente", EmitDefaultValue=false)]
        public string ContaCorrente { get; set; }
    
        /// <summary>
        /// D\u00C3\u00ADgito Verificador da Conta Corrente
        /// </summary>
        /// <value>D\u00C3\u00ADgito Verificador da Conta Corrente</value>
        [DataMember(Name="digitoContaCorrente", EmitDefaultValue=false)]
        public string DigitoContaCorrente { get; set; }
    
        /// <summary>
        /// Dia da data para o pagamento mensal
        /// </summary>
        /// <value>Dia da data para o pagamento mensal</value>
        [DataMember(Name="pagamentoMensal", EmitDefaultValue=false)]
        public int? PagamentoMensal { get; set; }
    
        /// <summary>
        /// Dia da data para o primeiro pagamento decendial
        /// </summary>
        /// <value>Dia da data para o primeiro pagamento decendial</value>
        [DataMember(Name="pagamentoDecendialPrimeiro", EmitDefaultValue=false)]
        public int? PagamentoDecendialPrimeiro { get; set; }
    
        /// <summary>
        /// Dia da data para o segundo pagamento decendial
        /// </summary>
        /// <value>Dia da data para o segundo pagamento decendial</value>
        [DataMember(Name="pagamentoDecendialSegundo", EmitDefaultValue=false)]
        public int? PagamentoDecendialSegundo { get; set; }
    
        /// <summary>
        /// Dia da data para o terceiro pagamento decendial
        /// </summary>
        /// <value>Dia da data para o terceiro pagamento decendial</value>
        [DataMember(Name="pagamentoDecendialTerceiro", EmitDefaultValue=false)]
        public int? PagamentoDecendialTerceiro { get; set; }
    
        /// <summary>
        /// Dia da data para o primeiro pagamento quinzenal
        /// </summary>
        /// <value>Dia da data para o primeiro pagamento quinzenal</value>
        [DataMember(Name="pagamentoQuinzenalPrimeiro", EmitDefaultValue=false)]
        public int? PagamentoQuinzenalPrimeiro { get; set; }
    
        /// <summary>
        /// Dia da data para o segundo pagamento quinzenal
        /// </summary>
        /// <value>Dia da data para o segundo pagamento quinzenal</value>
        [DataMember(Name="pagamentoQuinzenalSegundo", EmitDefaultValue=false)]
        public int? PagamentoQuinzenalSegundo { get; set; }
    
        /// <summary>
        /// Valor percentual do RAV do credor
        /// </summary>
        /// <value>Valor percentual do RAV do credor</value>
        [DataMember(Name="percentualRAV", EmitDefaultValue=false)]
        public double? PercentualRAV { get; set; }
    
        /// <summary>
        /// Percentual Multiplica
        /// </summary>
        /// <value>Percentual Multiplica</value>
        [DataMember(Name="percentualMultiplica", EmitDefaultValue=false)]
        public double? PercentualMultiplica { get; set; }
    
        /// <summary>
        /// Taxa Administrativa
        /// </summary>
        /// <value>Taxa Administrativa</value>
        [DataMember(Name="taxaAdm", EmitDefaultValue=false)]
        public double? TaxaAdm { get; set; }
    
        /// <summary>
        /// Taxa do Banco
        /// </summary>
        /// <value>Taxa do Banco</value>
        [DataMember(Name="taxaBanco", EmitDefaultValue=false)]
        public double? TaxaBanco { get; set; }
    
        /// <summary>
        /// Valor limite do RAV
        /// </summary>
        /// <value>Valor limite do RAV</value>
        [DataMember(Name="limiteRAV", EmitDefaultValue=false)]
        public double? LimiteRAV { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GrupoEconomicoDTO {\n");
            sb.Append("  RazaoSocial: ").Append(RazaoSocial).Append("\n");
            sb.Append("  NomeCredor: ").Append(NomeCredor).Append("\n");
            sb.Append("  NumeroReceitaFederal: ").Append(NumeroReceitaFederal).Append("\n");
            sb.Append("  InscricaoEstadual: ").Append(InscricaoEstadual).Append("\n");
            sb.Append("  Contato: ").Append(Contato).Append("\n");
            sb.Append("  Banco: ").Append(Banco).Append("\n");
            sb.Append("  Agencia: ").Append(Agencia).Append("\n");
            sb.Append("  DigitoAgencia: ").Append(DigitoAgencia).Append("\n");
            sb.Append("  ContaCorrente: ").Append(ContaCorrente).Append("\n");
            sb.Append("  DigitoContaCorrente: ").Append(DigitoContaCorrente).Append("\n");
            sb.Append("  Periodicidade: ").Append(Periodicidade).Append("\n");
            sb.Append("  PagamentoSemanal: ").Append(PagamentoSemanal).Append("\n");
            sb.Append("  PagamentoMensal: ").Append(PagamentoMensal).Append("\n");
            sb.Append("  PagamentoDecendialPrimeiro: ").Append(PagamentoDecendialPrimeiro).Append("\n");
            sb.Append("  PagamentoDecendialSegundo: ").Append(PagamentoDecendialSegundo).Append("\n");
            sb.Append("  PagamentoDecendialTerceiro: ").Append(PagamentoDecendialTerceiro).Append("\n");
            sb.Append("  PagamentoQuinzenalPrimeiro: ").Append(PagamentoQuinzenalPrimeiro).Append("\n");
            sb.Append("  PagamentoQuinzenalSegundo: ").Append(PagamentoQuinzenalSegundo).Append("\n");
            sb.Append("  PercentualRAV: ").Append(PercentualRAV).Append("\n");
            sb.Append("  RecebeRAV: ").Append(RecebeRAV).Append("\n");
            sb.Append("  PercentualMultiplica: ").Append(PercentualMultiplica).Append("\n");
            sb.Append("  TaxaAdm: ").Append(TaxaAdm).Append("\n");
            sb.Append("  TaxaBanco: ").Append(TaxaBanco).Append("\n");
            sb.Append("  LimiteRAV: ").Append(LimiteRAV).Append("\n");
            
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
            return this.Equals(obj as GrupoEconomicoDTO);
        }

        /// <summary>
        /// Returns true if GrupoEconomicoDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of GrupoEconomicoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GrupoEconomicoDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RazaoSocial == other.RazaoSocial ||
                    this.RazaoSocial != null &&
                    this.RazaoSocial.Equals(other.RazaoSocial)
                ) && 
                (
                    this.NomeCredor == other.NomeCredor ||
                    this.NomeCredor != null &&
                    this.NomeCredor.Equals(other.NomeCredor)
                ) && 
                (
                    this.NumeroReceitaFederal == other.NumeroReceitaFederal ||
                    this.NumeroReceitaFederal != null &&
                    this.NumeroReceitaFederal.Equals(other.NumeroReceitaFederal)
                ) && 
                (
                    this.InscricaoEstadual == other.InscricaoEstadual ||
                    this.InscricaoEstadual != null &&
                    this.InscricaoEstadual.Equals(other.InscricaoEstadual)
                ) && 
                (
                    this.Contato == other.Contato ||
                    this.Contato != null &&
                    this.Contato.Equals(other.Contato)
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
                    this.Periodicidade == other.Periodicidade ||
                    this.Periodicidade != null &&
                    this.Periodicidade.Equals(other.Periodicidade)
                ) && 
                (
                    this.PagamentoSemanal == other.PagamentoSemanal ||
                    this.PagamentoSemanal != null &&
                    this.PagamentoSemanal.Equals(other.PagamentoSemanal)
                ) && 
                (
                    this.PagamentoMensal == other.PagamentoMensal ||
                    this.PagamentoMensal != null &&
                    this.PagamentoMensal.Equals(other.PagamentoMensal)
                ) && 
                (
                    this.PagamentoDecendialPrimeiro == other.PagamentoDecendialPrimeiro ||
                    this.PagamentoDecendialPrimeiro != null &&
                    this.PagamentoDecendialPrimeiro.Equals(other.PagamentoDecendialPrimeiro)
                ) && 
                (
                    this.PagamentoDecendialSegundo == other.PagamentoDecendialSegundo ||
                    this.PagamentoDecendialSegundo != null &&
                    this.PagamentoDecendialSegundo.Equals(other.PagamentoDecendialSegundo)
                ) && 
                (
                    this.PagamentoDecendialTerceiro == other.PagamentoDecendialTerceiro ||
                    this.PagamentoDecendialTerceiro != null &&
                    this.PagamentoDecendialTerceiro.Equals(other.PagamentoDecendialTerceiro)
                ) && 
                (
                    this.PagamentoQuinzenalPrimeiro == other.PagamentoQuinzenalPrimeiro ||
                    this.PagamentoQuinzenalPrimeiro != null &&
                    this.PagamentoQuinzenalPrimeiro.Equals(other.PagamentoQuinzenalPrimeiro)
                ) && 
                (
                    this.PagamentoQuinzenalSegundo == other.PagamentoQuinzenalSegundo ||
                    this.PagamentoQuinzenalSegundo != null &&
                    this.PagamentoQuinzenalSegundo.Equals(other.PagamentoQuinzenalSegundo)
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
                    this.TaxaAdm == other.TaxaAdm ||
                    this.TaxaAdm != null &&
                    this.TaxaAdm.Equals(other.TaxaAdm)
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
                
                if (this.RazaoSocial != null)
                    hash = hash * 59 + this.RazaoSocial.GetHashCode();
                
                if (this.NomeCredor != null)
                    hash = hash * 59 + this.NomeCredor.GetHashCode();
                
                if (this.NumeroReceitaFederal != null)
                    hash = hash * 59 + this.NumeroReceitaFederal.GetHashCode();
                
                if (this.InscricaoEstadual != null)
                    hash = hash * 59 + this.InscricaoEstadual.GetHashCode();
                
                if (this.Contato != null)
                    hash = hash * 59 + this.Contato.GetHashCode();
                
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
                
                if (this.Periodicidade != null)
                    hash = hash * 59 + this.Periodicidade.GetHashCode();
                
                if (this.PagamentoSemanal != null)
                    hash = hash * 59 + this.PagamentoSemanal.GetHashCode();
                
                if (this.PagamentoMensal != null)
                    hash = hash * 59 + this.PagamentoMensal.GetHashCode();
                
                if (this.PagamentoDecendialPrimeiro != null)
                    hash = hash * 59 + this.PagamentoDecendialPrimeiro.GetHashCode();
                
                if (this.PagamentoDecendialSegundo != null)
                    hash = hash * 59 + this.PagamentoDecendialSegundo.GetHashCode();
                
                if (this.PagamentoDecendialTerceiro != null)
                    hash = hash * 59 + this.PagamentoDecendialTerceiro.GetHashCode();
                
                if (this.PagamentoQuinzenalPrimeiro != null)
                    hash = hash * 59 + this.PagamentoQuinzenalPrimeiro.GetHashCode();
                
                if (this.PagamentoQuinzenalSegundo != null)
                    hash = hash * 59 + this.PagamentoQuinzenalSegundo.GetHashCode();
                
                if (this.PercentualRAV != null)
                    hash = hash * 59 + this.PercentualRAV.GetHashCode();
                
                if (this.RecebeRAV != null)
                    hash = hash * 59 + this.RecebeRAV.GetHashCode();
                
                if (this.PercentualMultiplica != null)
                    hash = hash * 59 + this.PercentualMultiplica.GetHashCode();
                
                if (this.TaxaAdm != null)
                    hash = hash * 59 + this.TaxaAdm.GetHashCode();
                
                if (this.TaxaBanco != null)
                    hash = hash * 59 + this.TaxaBanco.GetHashCode();
                
                if (this.LimiteRAV != null)
                    hash = hash * 59 + this.LimiteRAV.GetHashCode();
                
                return hash;
            }
        }

    }
}
