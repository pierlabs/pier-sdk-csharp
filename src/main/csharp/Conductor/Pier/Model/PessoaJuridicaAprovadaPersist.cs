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
    /// Objeto de persist\u00EAncia da Pessoa Juridica Aprovada
    /// </summary>
    [DataContract]
    public partial class PessoaJuridicaAprovadaPersist :  IEquatable<PessoaJuridicaAprovadaPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaJuridicaAprovadaPersist" /> class.
        /// Initializes a new instance of the <see cref="PessoaJuridicaAprovadaPersist" />class.
        /// </summary>
        /// <param name="RazaoSocial">Nome completo da raz\u00E3o social. \u00C9 o nome empresarial (required).</param>
        /// <param name="NomeFantasia">Nome fantasia da empresa.</param>
        /// <param name="Cnpj">Number of the National Registry of Legal Entity (required).</param>
        /// <param name="InscricaoEstadual">N\u00FAmero da Inscri\u00E7\u00E3o Estadual.</param>
        /// <param name="DataAberturaEmpresa">Data de abertura da empresa, essa data deve ser informada no formato: aaaa-MM-dd (required).</param>
        /// <param name="IdOrigemComercial">C\u00F3digo identificador da origem comercial (required).</param>
        /// <param name="IdProduto">C\u00F3digo identificador do produto (required).</param>
        /// <param name="NumeroBanco">N\u00FAmero do banco.</param>
        /// <param name="NumeroAgencia">N\u00FAmero da ag\u00EAncia.</param>
        /// <param name="NumeroContaCorrente">N\u00FAmero da conta corrente.</param>
        /// <param name="Email">Email da empresa.</param>
        /// <param name="DiaVencimento">Dia vencimento (required).</param>
        /// <param name="NomeImpresso">Nome impresso no cart\u00E3o.</param>
        /// <param name="ValorRenda">Valor da renda comprovada.</param>
        /// <param name="CanalEntrada">Canal pelo qual o cadastro do cliente foi realizado.</param>
        /// <param name="ValorPontuacao">Valor da pontua\u00E7\u00E3o atribu\u00EDdo ao cliente. Default: 0.</param>
        /// <param name="Telefones">Telefones da empresa (required).</param>
        /// <param name="Enderecos">Enderecos da empresa (required).</param>
        /// <param name="Socios">S\u00F3cios da empresa (required).</param>
        /// <param name="ReferenciasComerciais">Refer\u00EAncias comerciais da Empresa.</param>
        /// <param name="LimiteGlobal">Valor do Limite Global para a conta.</param>
        /// <param name="LimiteMaximo">Valor m\u00E1ximo do limite de cr\u00E9dito para realizar transa\u00E7\u00F5es.</param>
        /// <param name="LimiteParcelas">Valor do limite de cr\u00E9dito acumulado da soma das parcelas das compras.</param>
        /// <param name="ImpedidoFinanciamento">Indicativo para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito (Lei n. 4.595/64).</param>
        /// <param name="Cnae">C\u00F3digo de Classifica\u00E7\u00E3o Nacional de Atividades Econ\u00F4micas.</param>
        /// <param name="FormaConstituicao">Forma de atos constitutivos de uma atividade empresarial.</param>

        public PessoaJuridicaAprovadaPersist(string RazaoSocial = null, string NomeFantasia = null, string Cnpj = null, string InscricaoEstadual = null, string DataAberturaEmpresa = null, long? IdOrigemComercial = null, long? IdProduto = null, int? NumeroBanco = null, int? NumeroAgencia = null, string NumeroContaCorrente = null, string Email = null, int? DiaVencimento = null, string NomeImpresso = null, double? ValorRenda = null, string CanalEntrada = null, int? ValorPontuacao = null, List<TelefonePessoaAprovadaPersist> Telefones = null, List<EnderecoAprovadoPersist> Enderecos = null, List<SocioAprovadoPersist> Socios = null, List<ReferenciaComercialAprovadoPersist> ReferenciasComerciais = null, double? LimiteGlobal = null, double? LimiteMaximo = null, double? LimiteParcelas = null, bool? ImpedidoFinanciamento = null, string Cnae = null, string FormaConstituicao = null)
        {
            // to ensure "RazaoSocial" is required (not null)
            if (RazaoSocial == null)
            {
                throw new InvalidDataException("RazaoSocial is a required property for PessoaJuridicaAprovadaPersist and cannot be null");
            }
            else
            {
                this.RazaoSocial = RazaoSocial;
            }
            // to ensure "Cnpj" is required (not null)
            if (Cnpj == null)
            {
                throw new InvalidDataException("Cnpj is a required property for PessoaJuridicaAprovadaPersist and cannot be null");
            }
            else
            {
                this.Cnpj = Cnpj;
            }
            // to ensure "DataAberturaEmpresa" is required (not null)
            if (DataAberturaEmpresa == null)
            {
                throw new InvalidDataException("DataAberturaEmpresa is a required property for PessoaJuridicaAprovadaPersist and cannot be null");
            }
            else
            {
                this.DataAberturaEmpresa = DataAberturaEmpresa;
            }
            // to ensure "IdOrigemComercial" is required (not null)
            if (IdOrigemComercial == null)
            {
                throw new InvalidDataException("IdOrigemComercial is a required property for PessoaJuridicaAprovadaPersist and cannot be null");
            }
            else
            {
                this.IdOrigemComercial = IdOrigemComercial;
            }
            // to ensure "IdProduto" is required (not null)
            if (IdProduto == null)
            {
                throw new InvalidDataException("IdProduto is a required property for PessoaJuridicaAprovadaPersist and cannot be null");
            }
            else
            {
                this.IdProduto = IdProduto;
            }
            // to ensure "DiaVencimento" is required (not null)
            if (DiaVencimento == null)
            {
                throw new InvalidDataException("DiaVencimento is a required property for PessoaJuridicaAprovadaPersist and cannot be null");
            }
            else
            {
                this.DiaVencimento = DiaVencimento;
            }
            // to ensure "Telefones" is required (not null)
            if (Telefones == null)
            {
                throw new InvalidDataException("Telefones is a required property for PessoaJuridicaAprovadaPersist and cannot be null");
            }
            else
            {
                this.Telefones = Telefones;
            }
            // to ensure "Enderecos" is required (not null)
            if (Enderecos == null)
            {
                throw new InvalidDataException("Enderecos is a required property for PessoaJuridicaAprovadaPersist and cannot be null");
            }
            else
            {
                this.Enderecos = Enderecos;
            }
            // to ensure "Socios" is required (not null)
            if (Socios == null)
            {
                throw new InvalidDataException("Socios is a required property for PessoaJuridicaAprovadaPersist and cannot be null");
            }
            else
            {
                this.Socios = Socios;
            }
            this.NomeFantasia = NomeFantasia;
            this.InscricaoEstadual = InscricaoEstadual;
            this.NumeroBanco = NumeroBanco;
            this.NumeroAgencia = NumeroAgencia;
            this.NumeroContaCorrente = NumeroContaCorrente;
            this.Email = Email;
            this.NomeImpresso = NomeImpresso;
            this.ValorRenda = ValorRenda;
            this.CanalEntrada = CanalEntrada;
            this.ValorPontuacao = ValorPontuacao;
            this.ReferenciasComerciais = ReferenciasComerciais;
            this.LimiteGlobal = LimiteGlobal;
            this.LimiteMaximo = LimiteMaximo;
            this.LimiteParcelas = LimiteParcelas;
            this.ImpedidoFinanciamento = ImpedidoFinanciamento;
            this.Cnae = Cnae;
            this.FormaConstituicao = FormaConstituicao;
            
        }
        
    
        /// <summary>
        /// Nome completo da raz\u00E3o social. \u00C9 o nome empresarial
        /// </summary>
        /// <value>Nome completo da raz\u00E3o social. \u00C9 o nome empresarial</value>
        [DataMember(Name="razaoSocial", EmitDefaultValue=false)]
        public string RazaoSocial { get; set; }
    
        /// <summary>
        /// Nome fantasia da empresa
        /// </summary>
        /// <value>Nome fantasia da empresa</value>
        [DataMember(Name="nomeFantasia", EmitDefaultValue=false)]
        public string NomeFantasia { get; set; }
    
        /// <summary>
        /// Number of the National Registry of Legal Entity
        /// </summary>
        /// <value>Number of the National Registry of Legal Entity</value>
        [DataMember(Name="cnpj", EmitDefaultValue=false)]
        public string Cnpj { get; set; }
    
        /// <summary>
        /// N\u00FAmero da Inscri\u00E7\u00E3o Estadual
        /// </summary>
        /// <value>N\u00FAmero da Inscri\u00E7\u00E3o Estadual</value>
        [DataMember(Name="inscricaoEstadual", EmitDefaultValue=false)]
        public string InscricaoEstadual { get; set; }
    
        /// <summary>
        /// Data de abertura da empresa, essa data deve ser informada no formato: aaaa-MM-dd
        /// </summary>
        /// <value>Data de abertura da empresa, essa data deve ser informada no formato: aaaa-MM-dd</value>
        [DataMember(Name="dataAberturaEmpresa", EmitDefaultValue=false)]
        public string DataAberturaEmpresa { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da origem comercial
        /// </summary>
        /// <value>C\u00F3digo identificador da origem comercial</value>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public long? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do produto
        /// </summary>
        /// <value>C\u00F3digo identificador do produto</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
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
        /// Email da empresa
        /// </summary>
        /// <value>Email da empresa</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Dia vencimento
        /// </summary>
        /// <value>Dia vencimento</value>
        [DataMember(Name="diaVencimento", EmitDefaultValue=false)]
        public int? DiaVencimento { get; set; }
    
        /// <summary>
        /// Nome impresso no cart\u00E3o
        /// </summary>
        /// <value>Nome impresso no cart\u00E3o</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// Valor da renda comprovada
        /// </summary>
        /// <value>Valor da renda comprovada</value>
        [DataMember(Name="valorRenda", EmitDefaultValue=false)]
        public double? ValorRenda { get; set; }
    
        /// <summary>
        /// Canal pelo qual o cadastro do cliente foi realizado
        /// </summary>
        /// <value>Canal pelo qual o cadastro do cliente foi realizado</value>
        [DataMember(Name="canalEntrada", EmitDefaultValue=false)]
        public string CanalEntrada { get; set; }
    
        /// <summary>
        /// Valor da pontua\u00E7\u00E3o atribu\u00EDdo ao cliente. Default: 0
        /// </summary>
        /// <value>Valor da pontua\u00E7\u00E3o atribu\u00EDdo ao cliente. Default: 0</value>
        [DataMember(Name="valorPontuacao", EmitDefaultValue=false)]
        public int? ValorPontuacao { get; set; }
    
        /// <summary>
        /// Telefones da empresa
        /// </summary>
        /// <value>Telefones da empresa</value>
        [DataMember(Name="telefones", EmitDefaultValue=false)]
        public List<TelefonePessoaAprovadaPersist> Telefones { get; set; }
    
        /// <summary>
        /// Enderecos da empresa
        /// </summary>
        /// <value>Enderecos da empresa</value>
        [DataMember(Name="enderecos", EmitDefaultValue=false)]
        public List<EnderecoAprovadoPersist> Enderecos { get; set; }
    
        /// <summary>
        /// S\u00F3cios da empresa
        /// </summary>
        /// <value>S\u00F3cios da empresa</value>
        [DataMember(Name="socios", EmitDefaultValue=false)]
        public List<SocioAprovadoPersist> Socios { get; set; }
    
        /// <summary>
        /// Refer\u00EAncias comerciais da Empresa
        /// </summary>
        /// <value>Refer\u00EAncias comerciais da Empresa</value>
        [DataMember(Name="referenciasComerciais", EmitDefaultValue=false)]
        public List<ReferenciaComercialAprovadoPersist> ReferenciasComerciais { get; set; }
    
        /// <summary>
        /// Valor do Limite Global para a conta
        /// </summary>
        /// <value>Valor do Limite Global para a conta</value>
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
        /// Indicativo para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito (Lei n. 4.595/64)
        /// </summary>
        /// <value>Indicativo para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito (Lei n. 4.595/64)</value>
        [DataMember(Name="impedidoFinanciamento", EmitDefaultValue=false)]
        public bool? ImpedidoFinanciamento { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Classifica\u00E7\u00E3o Nacional de Atividades Econ\u00F4micas
        /// </summary>
        /// <value>C\u00F3digo de Classifica\u00E7\u00E3o Nacional de Atividades Econ\u00F4micas</value>
        [DataMember(Name="cnae", EmitDefaultValue=false)]
        public string Cnae { get; set; }
    
        /// <summary>
        /// Forma de atos constitutivos de uma atividade empresarial
        /// </summary>
        /// <value>Forma de atos constitutivos de uma atividade empresarial</value>
        [DataMember(Name="formaConstituicao", EmitDefaultValue=false)]
        public string FormaConstituicao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PessoaJuridicaAprovadaPersist {\n");
            sb.Append("  RazaoSocial: ").Append(RazaoSocial).Append("\n");
            sb.Append("  NomeFantasia: ").Append(NomeFantasia).Append("\n");
            sb.Append("  Cnpj: ").Append(Cnpj).Append("\n");
            sb.Append("  InscricaoEstadual: ").Append(InscricaoEstadual).Append("\n");
            sb.Append("  DataAberturaEmpresa: ").Append(DataAberturaEmpresa).Append("\n");
            sb.Append("  IdOrigemComercial: ").Append(IdOrigemComercial).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  NumeroBanco: ").Append(NumeroBanco).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  NumeroContaCorrente: ").Append(NumeroContaCorrente).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  DiaVencimento: ").Append(DiaVencimento).Append("\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  ValorRenda: ").Append(ValorRenda).Append("\n");
            sb.Append("  CanalEntrada: ").Append(CanalEntrada).Append("\n");
            sb.Append("  ValorPontuacao: ").Append(ValorPontuacao).Append("\n");
            sb.Append("  Telefones: ").Append(Telefones).Append("\n");
            sb.Append("  Enderecos: ").Append(Enderecos).Append("\n");
            sb.Append("  Socios: ").Append(Socios).Append("\n");
            sb.Append("  ReferenciasComerciais: ").Append(ReferenciasComerciais).Append("\n");
            sb.Append("  LimiteGlobal: ").Append(LimiteGlobal).Append("\n");
            sb.Append("  LimiteMaximo: ").Append(LimiteMaximo).Append("\n");
            sb.Append("  LimiteParcelas: ").Append(LimiteParcelas).Append("\n");
            sb.Append("  ImpedidoFinanciamento: ").Append(ImpedidoFinanciamento).Append("\n");
            sb.Append("  Cnae: ").Append(Cnae).Append("\n");
            sb.Append("  FormaConstituicao: ").Append(FormaConstituicao).Append("\n");
            
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
            return this.Equals(obj as PessoaJuridicaAprovadaPersist);
        }

        /// <summary>
        /// Returns true if PessoaJuridicaAprovadaPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of PessoaJuridicaAprovadaPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PessoaJuridicaAprovadaPersist other)
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
                    this.NomeFantasia == other.NomeFantasia ||
                    this.NomeFantasia != null &&
                    this.NomeFantasia.Equals(other.NomeFantasia)
                ) && 
                (
                    this.Cnpj == other.Cnpj ||
                    this.Cnpj != null &&
                    this.Cnpj.Equals(other.Cnpj)
                ) && 
                (
                    this.InscricaoEstadual == other.InscricaoEstadual ||
                    this.InscricaoEstadual != null &&
                    this.InscricaoEstadual.Equals(other.InscricaoEstadual)
                ) && 
                (
                    this.DataAberturaEmpresa == other.DataAberturaEmpresa ||
                    this.DataAberturaEmpresa != null &&
                    this.DataAberturaEmpresa.Equals(other.DataAberturaEmpresa)
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
                    this.Socios == other.Socios ||
                    this.Socios != null &&
                    this.Socios.SequenceEqual(other.Socios)
                ) && 
                (
                    this.ReferenciasComerciais == other.ReferenciasComerciais ||
                    this.ReferenciasComerciais != null &&
                    this.ReferenciasComerciais.SequenceEqual(other.ReferenciasComerciais)
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
                    this.ImpedidoFinanciamento == other.ImpedidoFinanciamento ||
                    this.ImpedidoFinanciamento != null &&
                    this.ImpedidoFinanciamento.Equals(other.ImpedidoFinanciamento)
                ) && 
                (
                    this.Cnae == other.Cnae ||
                    this.Cnae != null &&
                    this.Cnae.Equals(other.Cnae)
                ) && 
                (
                    this.FormaConstituicao == other.FormaConstituicao ||
                    this.FormaConstituicao != null &&
                    this.FormaConstituicao.Equals(other.FormaConstituicao)
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
                
                if (this.NomeFantasia != null)
                    hash = hash * 59 + this.NomeFantasia.GetHashCode();
                
                if (this.Cnpj != null)
                    hash = hash * 59 + this.Cnpj.GetHashCode();
                
                if (this.InscricaoEstadual != null)
                    hash = hash * 59 + this.InscricaoEstadual.GetHashCode();
                
                if (this.DataAberturaEmpresa != null)
                    hash = hash * 59 + this.DataAberturaEmpresa.GetHashCode();
                
                if (this.IdOrigemComercial != null)
                    hash = hash * 59 + this.IdOrigemComercial.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.NumeroBanco != null)
                    hash = hash * 59 + this.NumeroBanco.GetHashCode();
                
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
                
                if (this.Socios != null)
                    hash = hash * 59 + this.Socios.GetHashCode();
                
                if (this.ReferenciasComerciais != null)
                    hash = hash * 59 + this.ReferenciasComerciais.GetHashCode();
                
                if (this.LimiteGlobal != null)
                    hash = hash * 59 + this.LimiteGlobal.GetHashCode();
                
                if (this.LimiteMaximo != null)
                    hash = hash * 59 + this.LimiteMaximo.GetHashCode();
                
                if (this.LimiteParcelas != null)
                    hash = hash * 59 + this.LimiteParcelas.GetHashCode();
                
                if (this.ImpedidoFinanciamento != null)
                    hash = hash * 59 + this.ImpedidoFinanciamento.GetHashCode();
                
                if (this.Cnae != null)
                    hash = hash * 59 + this.Cnae.GetHashCode();
                
                if (this.FormaConstituicao != null)
                    hash = hash * 59 + this.FormaConstituicao.GetHashCode();
                
                return hash;
            }
        }

    }
}
