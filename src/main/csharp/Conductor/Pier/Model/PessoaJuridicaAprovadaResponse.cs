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
    /// PersonLegalApproedPersist
    /// </summary>
    [DataContract]
    public partial class PessoaJuridicaAprovadaResponse :  IEquatable<PessoaJuridicaAprovadaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaJuridicaAprovadaResponse" /> class.
        /// Initializes a new instance of the <see cref="PessoaJuridicaAprovadaResponse" />class.
        /// </summary>
        /// <param name="Id">Identification Code of the Legal Person (id).</param>
        /// <param name="RazaoSocial">Show the full name of the social reason (business name).</param>
        /// <param name="NomeFantasia">Show the fantasy name of the company.</param>
        /// <param name="Cnpj">National Register Number of the Legal Person (CNPJ).</param>
        /// <param name="InscricaoEstadual">State Enrollment Number (SE).</param>
        /// <param name="DataAberturaEmpresa">Opening date of the company, this date must be informed in the format: yyyy-MM-dd.</param>
        /// <param name="IdOrigemComercial">Id of the commercial origin.</param>
        /// <param name="IdProduto">Id of the Product.</param>
        /// <param name="NumeroBanco">Bank number.</param>
        /// <param name="NumeroAgencia">Agency number.</param>
        /// <param name="NumeroContaCorrente">Current Account Number.</param>
        /// <param name="Email">Company name.</param>
        /// <param name="DiaVencimento">Expiration day.</param>
        /// <param name="NomeImpresso">Name that must be printed on the card.</param>
        /// <param name="IdConta">Identification Code of the Registered Account.</param>
        /// <param name="IdProposta">Identification Code of the purpose.</param>
        /// <param name="CanalEntrada">Indicate the way which the register of the client was created.</param>
        /// <param name="ValorPontuacao">Indicate the value of the score attributed to the client (in case it is not informed it will be attributed the value =0).</param>
        /// <param name="Telefones">Show the telephones of the company.</param>
        /// <param name="Enderecos">It may be informed the types of address: Residential, Commercial and Others.</param>
        /// <param name="Socios">Show the dates of the partners in the company, in case that it exists.</param>
        /// <param name="Referencias">Show the dates of the partners of the company, in case that it exists.</param>
        /// <param name="LimiteGlobal">Value of the Global limit (required).</param>
        /// <param name="LimiteMaximo">Maximum value of limit credit to make trnsactions (required).</param>
        /// <param name="LimiteParcelas">Value of accumulated credit limit of sum of the parcels of the shops (required).</param>
        /// <param name="ImpedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64) .</param>

        public PessoaJuridicaAprovadaResponse(long? Id = null, string RazaoSocial = null, string NomeFantasia = null, string Cnpj = null, string InscricaoEstadual = null, string DataAberturaEmpresa = null, long? IdOrigemComercial = null, long? IdProduto = null, int? NumeroBanco = null, int? NumeroAgencia = null, string NumeroContaCorrente = null, string Email = null, int? DiaVencimento = null, string NomeImpresso = null, long? IdConta = null, long? IdProposta = null, string CanalEntrada = null, int? ValorPontuacao = null, List<TelefonePessoaAprovadaResponse> Telefones = null, List<ObjectAddressApproved> Enderecos = null, List<SocioAprovadoResponse> Socios = null, List<ReferenciaComercialAprovadoResponse> Referencias = null, double? LimiteGlobal = null, double? LimiteMaximo = null, double? LimiteParcelas = null, bool? ImpedidoFinanciamento = null)
        {
            // to ensure "LimiteGlobal" is required (not null)
            if (LimiteGlobal == null)
            {
                throw new InvalidDataException("LimiteGlobal is a required property for PessoaJuridicaAprovadaResponse and cannot be null");
            }
            else
            {
                this.LimiteGlobal = LimiteGlobal;
            }
            // to ensure "LimiteMaximo" is required (not null)
            if (LimiteMaximo == null)
            {
                throw new InvalidDataException("LimiteMaximo is a required property for PessoaJuridicaAprovadaResponse and cannot be null");
            }
            else
            {
                this.LimiteMaximo = LimiteMaximo;
            }
            // to ensure "LimiteParcelas" is required (not null)
            if (LimiteParcelas == null)
            {
                throw new InvalidDataException("LimiteParcelas is a required property for PessoaJuridicaAprovadaResponse and cannot be null");
            }
            else
            {
                this.LimiteParcelas = LimiteParcelas;
            }
            this.Id = Id;
            this.RazaoSocial = RazaoSocial;
            this.NomeFantasia = NomeFantasia;
            this.Cnpj = Cnpj;
            this.InscricaoEstadual = InscricaoEstadual;
            this.DataAberturaEmpresa = DataAberturaEmpresa;
            this.IdOrigemComercial = IdOrigemComercial;
            this.IdProduto = IdProduto;
            this.NumeroBanco = NumeroBanco;
            this.NumeroAgencia = NumeroAgencia;
            this.NumeroContaCorrente = NumeroContaCorrente;
            this.Email = Email;
            this.DiaVencimento = DiaVencimento;
            this.NomeImpresso = NomeImpresso;
            this.IdConta = IdConta;
            this.IdProposta = IdProposta;
            this.CanalEntrada = CanalEntrada;
            this.ValorPontuacao = ValorPontuacao;
            this.Telefones = Telefones;
            this.Enderecos = Enderecos;
            this.Socios = Socios;
            this.Referencias = Referencias;
            this.ImpedidoFinanciamento = ImpedidoFinanciamento;
            
        }
        
    
        /// <summary>
        /// Identification Code of the Legal Person (id)
        /// </summary>
        /// <value>Identification Code of the Legal Person (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Show the full name of the social reason (business name)
        /// </summary>
        /// <value>Show the full name of the social reason (business name)</value>
        [DataMember(Name="razaoSocial", EmitDefaultValue=false)]
        public string RazaoSocial { get; set; }
    
        /// <summary>
        /// Show the fantasy name of the company
        /// </summary>
        /// <value>Show the fantasy name of the company</value>
        [DataMember(Name="nomeFantasia", EmitDefaultValue=false)]
        public string NomeFantasia { get; set; }
    
        /// <summary>
        /// National Register Number of the Legal Person (CNPJ)
        /// </summary>
        /// <value>National Register Number of the Legal Person (CNPJ)</value>
        [DataMember(Name="cnpj", EmitDefaultValue=false)]
        public string Cnpj { get; set; }
    
        /// <summary>
        /// State Enrollment Number (SE)
        /// </summary>
        /// <value>State Enrollment Number (SE)</value>
        [DataMember(Name="inscricaoEstadual", EmitDefaultValue=false)]
        public string InscricaoEstadual { get; set; }
    
        /// <summary>
        /// Opening date of the company, this date must be informed in the format: yyyy-MM-dd
        /// </summary>
        /// <value>Opening date of the company, this date must be informed in the format: yyyy-MM-dd</value>
        [DataMember(Name="dataAberturaEmpresa", EmitDefaultValue=false)]
        public string DataAberturaEmpresa { get; set; }
    
        /// <summary>
        /// Id of the commercial origin
        /// </summary>
        /// <value>Id of the commercial origin</value>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public long? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// Id of the Product
        /// </summary>
        /// <value>Id of the Product</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Bank number
        /// </summary>
        /// <value>Bank number</value>
        [DataMember(Name="numeroBanco", EmitDefaultValue=false)]
        public int? NumeroBanco { get; set; }
    
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
        /// Company name
        /// </summary>
        /// <value>Company name</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Expiration day
        /// </summary>
        /// <value>Expiration day</value>
        [DataMember(Name="diaVencimento", EmitDefaultValue=false)]
        public int? DiaVencimento { get; set; }
    
        /// <summary>
        /// Name that must be printed on the card
        /// </summary>
        /// <value>Name that must be printed on the card</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// Identification Code of the Registered Account
        /// </summary>
        /// <value>Identification Code of the Registered Account</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identification Code of the purpose
        /// </summary>
        /// <value>Identification Code of the purpose</value>
        [DataMember(Name="idProposta", EmitDefaultValue=false)]
        public long? IdProposta { get; set; }
    
        /// <summary>
        /// Indicate the way which the register of the client was created
        /// </summary>
        /// <value>Indicate the way which the register of the client was created</value>
        [DataMember(Name="canalEntrada", EmitDefaultValue=false)]
        public string CanalEntrada { get; set; }
    
        /// <summary>
        /// Indicate the value of the score attributed to the client (in case it is not informed it will be attributed the value =0)
        /// </summary>
        /// <value>Indicate the value of the score attributed to the client (in case it is not informed it will be attributed the value =0)</value>
        [DataMember(Name="valorPontuacao", EmitDefaultValue=false)]
        public int? ValorPontuacao { get; set; }
    
        /// <summary>
        /// Show the telephones of the company
        /// </summary>
        /// <value>Show the telephones of the company</value>
        [DataMember(Name="telefones", EmitDefaultValue=false)]
        public List<TelefonePessoaAprovadaResponse> Telefones { get; set; }
    
        /// <summary>
        /// It may be informed the types of address: Residential, Commercial and Others
        /// </summary>
        /// <value>It may be informed the types of address: Residential, Commercial and Others</value>
        [DataMember(Name="enderecos", EmitDefaultValue=false)]
        public List<ObjectAddressApproved> Enderecos { get; set; }
    
        /// <summary>
        /// Show the dates of the partners in the company, in case that it exists
        /// </summary>
        /// <value>Show the dates of the partners in the company, in case that it exists</value>
        [DataMember(Name="socios", EmitDefaultValue=false)]
        public List<SocioAprovadoResponse> Socios { get; set; }
    
        /// <summary>
        /// Show the dates of the partners of the company, in case that it exists
        /// </summary>
        /// <value>Show the dates of the partners of the company, in case that it exists</value>
        [DataMember(Name="referencias", EmitDefaultValue=false)]
        public List<ReferenciaComercialAprovadoResponse> Referencias { get; set; }
    
        /// <summary>
        /// Value of the Global limit
        /// </summary>
        /// <value>Value of the Global limit</value>
        [DataMember(Name="limiteGlobal", EmitDefaultValue=false)]
        public double? LimiteGlobal { get; set; }
    
        /// <summary>
        /// Maximum value of limit credit to make trnsactions
        /// </summary>
        /// <value>Maximum value of limit credit to make trnsactions</value>
        [DataMember(Name="limiteMaximo", EmitDefaultValue=false)]
        public double? LimiteMaximo { get; set; }
    
        /// <summary>
        /// Value of accumulated credit limit of sum of the parcels of the shops
        /// </summary>
        /// <value>Value of accumulated credit limit of sum of the parcels of the shops</value>
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
            sb.Append("class PessoaJuridicaAprovadaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdProposta: ").Append(IdProposta).Append("\n");
            sb.Append("  CanalEntrada: ").Append(CanalEntrada).Append("\n");
            sb.Append("  ValorPontuacao: ").Append(ValorPontuacao).Append("\n");
            sb.Append("  Telefones: ").Append(Telefones).Append("\n");
            sb.Append("  Enderecos: ").Append(Enderecos).Append("\n");
            sb.Append("  Socios: ").Append(Socios).Append("\n");
            sb.Append("  Referencias: ").Append(Referencias).Append("\n");
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
            return this.Equals(obj as PessoaJuridicaAprovadaResponse);
        }

        /// <summary>
        /// Returns true if PessoaJuridicaAprovadaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PessoaJuridicaAprovadaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PessoaJuridicaAprovadaResponse other)
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
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdProposta == other.IdProposta ||
                    this.IdProposta != null &&
                    this.IdProposta.Equals(other.IdProposta)
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
                    this.Referencias == other.Referencias ||
                    this.Referencias != null &&
                    this.Referencias.SequenceEqual(other.Referencias)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdProposta != null)
                    hash = hash * 59 + this.IdProposta.GetHashCode();
                
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
                
                if (this.Referencias != null)
                    hash = hash * 59 + this.Referencias.GetHashCode();
                
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
