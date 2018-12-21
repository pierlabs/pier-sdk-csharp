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
    /// PersonLegalApprovedPersist
    /// </summary>
    [DataContract]
    public partial class PessoaJuridicaAprovadaPersist :  IEquatable<PessoaJuridicaAprovadaPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaJuridicaAprovadaPersist" /> class.
        /// Initializes a new instance of the <see cref="PessoaJuridicaAprovadaPersist" />class.
        /// </summary>
        /// <param name="RazaoSocial">Show the full name of the social reason (business name)&#39; (required).</param>
        /// <param name="NomeFantasia">Show the fantasy name of the company.</param>
        /// <param name="Cnpj">CNPJ (required).</param>
        /// <param name="InscricaoEstadual">State registration number.</param>
        /// <param name="DataAberturaEmpresa">Company opening date, this date must be informed in the format: yyyy-MM-dd (required).</param>
        /// <param name="IdOrigemComercial">Id or the commercial origin (required).</param>
        /// <param name="IdProduto">Id product (required).</param>
        /// <param name="NumeroBanco">Bank number.</param>
        /// <param name="NumeroAgencia">Agency Number.</param>
        /// <param name="NumeroContaCorrente">Number of the current account.</param>
        /// <param name="Email">Email of the company.</param>
        /// <param name="DiaVencimento">Expiration date (required).</param>
        /// <param name="NomeImpresso">Name that must be printed on the card.</param>
        /// <param name="ValorRenda">Apresenta o valor da renda compravada.</param>
        /// <param name="CanalEntrada">Indicate the channel which the register of the client was created.</param>
        /// <param name="ValorPontuacao">Indicate the value of the puntuaction attributed to the client (case it is not informed it will be attributed the value =0).</param>
        /// <param name="Telefones">List the Telephones of the Company.</param>
        /// <param name="Enderecos">It can be informed the following types of address: Residencial, Commercial and Others (required).</param>
        /// <param name="Socios">Show the dates of the partners, in case of existence.</param>
        /// <param name="ReferenciasComerciais">show the dates of the commercial references.</param>
        /// <param name="LimiteGlobal">Value of the Global Limit (required).</param>
        /// <param name="LimiteMaximo">Maximum value of the credit limit to make transactions (required).</param>
        /// <param name="LimiteParcelas">Credit Limit Value accumulated of the sum of the purchase parcels (required).</param>
        /// <param name="ImpedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64) .</param>

        public PessoaJuridicaAprovadaPersist(string RazaoSocial = null, string NomeFantasia = null, string Cnpj = null, string InscricaoEstadual = null, string DataAberturaEmpresa = null, long? IdOrigemComercial = null, long? IdProduto = null, int? NumeroBanco = null, int? NumeroAgencia = null, string NumeroContaCorrente = null, string Email = null, int? DiaVencimento = null, string NomeImpresso = null, double? ValorRenda = null, string CanalEntrada = null, int? ValorPontuacao = null, List<TelephonePersonApprovedPersist> Telefones = null, List<ObjectAddressApproved> Enderecos = null, List<PersonPersist> Socios = null, List<RefenceCommercialApprovedPersist> ReferenciasComerciais = null, double? LimiteGlobal = null, double? LimiteMaximo = null, double? LimiteParcelas = null, bool? ImpedidoFinanciamento = null)
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
            // to ensure "Enderecos" is required (not null)
            if (Enderecos == null)
            {
                throw new InvalidDataException("Enderecos is a required property for PessoaJuridicaAprovadaPersist and cannot be null");
            }
            else
            {
                this.Enderecos = Enderecos;
            }
            // to ensure "LimiteGlobal" is required (not null)
            if (LimiteGlobal == null)
            {
                throw new InvalidDataException("LimiteGlobal is a required property for PessoaJuridicaAprovadaPersist and cannot be null");
            }
            else
            {
                this.LimiteGlobal = LimiteGlobal;
            }
            // to ensure "LimiteMaximo" is required (not null)
            if (LimiteMaximo == null)
            {
                throw new InvalidDataException("LimiteMaximo is a required property for PessoaJuridicaAprovadaPersist and cannot be null");
            }
            else
            {
                this.LimiteMaximo = LimiteMaximo;
            }
            // to ensure "LimiteParcelas" is required (not null)
            if (LimiteParcelas == null)
            {
                throw new InvalidDataException("LimiteParcelas is a required property for PessoaJuridicaAprovadaPersist and cannot be null");
            }
            else
            {
                this.LimiteParcelas = LimiteParcelas;
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
            this.Telefones = Telefones;
            this.Socios = Socios;
            this.ReferenciasComerciais = ReferenciasComerciais;
            this.ImpedidoFinanciamento = ImpedidoFinanciamento;
            
        }
        
    
        /// <summary>
        /// Show the full name of the social reason (business name)&#39;
        /// </summary>
        /// <value>Show the full name of the social reason (business name)&#39;</value>
        [DataMember(Name="razaoSocial", EmitDefaultValue=false)]
        public string RazaoSocial { get; set; }
    
        /// <summary>
        /// Show the fantasy name of the company
        /// </summary>
        /// <value>Show the fantasy name of the company</value>
        [DataMember(Name="nomeFantasia", EmitDefaultValue=false)]
        public string NomeFantasia { get; set; }
    
        /// <summary>
        /// CNPJ
        /// </summary>
        /// <value>CNPJ</value>
        [DataMember(Name="cnpj", EmitDefaultValue=false)]
        public string Cnpj { get; set; }
    
        /// <summary>
        /// State registration number
        /// </summary>
        /// <value>State registration number</value>
        [DataMember(Name="inscricaoEstadual", EmitDefaultValue=false)]
        public string InscricaoEstadual { get; set; }
    
        /// <summary>
        /// Company opening date, this date must be informed in the format: yyyy-MM-dd
        /// </summary>
        /// <value>Company opening date, this date must be informed in the format: yyyy-MM-dd</value>
        [DataMember(Name="dataAberturaEmpresa", EmitDefaultValue=false)]
        public string DataAberturaEmpresa { get; set; }
    
        /// <summary>
        /// Id or the commercial origin
        /// </summary>
        /// <value>Id or the commercial origin</value>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public long? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// Id product
        /// </summary>
        /// <value>Id product</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Bank number
        /// </summary>
        /// <value>Bank number</value>
        [DataMember(Name="numeroBanco", EmitDefaultValue=false)]
        public int? NumeroBanco { get; set; }
    
        /// <summary>
        /// Agency Number
        /// </summary>
        /// <value>Agency Number</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public int? NumeroAgencia { get; set; }
    
        /// <summary>
        /// Number of the current account
        /// </summary>
        /// <value>Number of the current account</value>
        [DataMember(Name="numeroContaCorrente", EmitDefaultValue=false)]
        public string NumeroContaCorrente { get; set; }
    
        /// <summary>
        /// Email of the company
        /// </summary>
        /// <value>Email of the company</value>
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
        /// Apresenta o valor da renda compravada
        /// </summary>
        /// <value>Apresenta o valor da renda compravada</value>
        [DataMember(Name="valorRenda", EmitDefaultValue=false)]
        public double? ValorRenda { get; set; }
    
        /// <summary>
        /// Indicate the channel which the register of the client was created
        /// </summary>
        /// <value>Indicate the channel which the register of the client was created</value>
        [DataMember(Name="canalEntrada", EmitDefaultValue=false)]
        public string CanalEntrada { get; set; }
    
        /// <summary>
        /// Indicate the value of the puntuaction attributed to the client (case it is not informed it will be attributed the value =0)
        /// </summary>
        /// <value>Indicate the value of the puntuaction attributed to the client (case it is not informed it will be attributed the value =0)</value>
        [DataMember(Name="valorPontuacao", EmitDefaultValue=false)]
        public int? ValorPontuacao { get; set; }
    
        /// <summary>
        /// List the Telephones of the Company
        /// </summary>
        /// <value>List the Telephones of the Company</value>
        [DataMember(Name="telefones", EmitDefaultValue=false)]
        public List<TelephonePersonApprovedPersist> Telefones { get; set; }
    
        /// <summary>
        /// It can be informed the following types of address: Residencial, Commercial and Others
        /// </summary>
        /// <value>It can be informed the following types of address: Residencial, Commercial and Others</value>
        [DataMember(Name="enderecos", EmitDefaultValue=false)]
        public List<ObjectAddressApproved> Enderecos { get; set; }
    
        /// <summary>
        /// Show the dates of the partners, in case of existence
        /// </summary>
        /// <value>Show the dates of the partners, in case of existence</value>
        [DataMember(Name="socios", EmitDefaultValue=false)]
        public List<PersonPersist> Socios { get; set; }
    
        /// <summary>
        /// show the dates of the commercial references
        /// </summary>
        /// <value>show the dates of the commercial references</value>
        [DataMember(Name="referenciasComerciais", EmitDefaultValue=false)]
        public List<RefenceCommercialApprovedPersist> ReferenciasComerciais { get; set; }
    
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
        /// Credit Limit Value accumulated of the sum of the purchase parcels
        /// </summary>
        /// <value>Credit Limit Value accumulated of the sum of the purchase parcels</value>
        [DataMember(Name="limiteParcelas", EmitDefaultValue=false)]
        public double? LimiteParcelas { get; set; }
    
        /// <summary>
        /// Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64) 
        /// </summary>
        /// <value>Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64) </value>
        [DataMember(Name="impedidoFinanciamento", EmitDefaultValue=false)]
        public bool? ImpedidoFinanciamento { get; set; }
    
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
                
                return hash;
            }
        }

    }
}
