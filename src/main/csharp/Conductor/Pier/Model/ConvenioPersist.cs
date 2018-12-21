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
    /// Request Object for save Convenant 
    /// </summary>
    [DataContract]
    public partial class ConvenioPersist :  IEquatable<ConvenioPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvenioPersist" /> class.
        /// Initializes a new instance of the <see cref="ConvenioPersist" />class.
        /// </summary>
        /// <param name="Banco">Bank Id (required).</param>
        /// <param name="Agencia">Agency Number (required).</param>
        /// <param name="ContaCorrente">Current Account (required).</param>
        /// <param name="Especie">Convenant Id code.</param>
        /// <param name="NumeroConvenio">Number Convenant.</param>
        /// <param name="Carteira">Wallet Id Code.</param>
        /// <param name="CodigoCedente">Assignor code.</param>
        /// <param name="EspecieTipo">Species Value.</param>
        /// <param name="EspecieDocumento">Species Document Value.</param>
        /// <param name="Aceite">Information about if payer signed billing document.</param>
        /// <param name="Instrucoes">Instructions for the payment.</param>
        /// <param name="LocalPagamento1">preferred place for payment.</param>
        /// <param name="LocalPagamento2">preferred place for payment(additional).</param>
        /// <param name="EnderecoCobrancaEmissor">billing address.</param>
        /// <param name="NomeBeneficiario">Beneficiary name.</param>
        /// <param name="CnpjBeneficiario">Beneficiary cnpj.</param>

        public ConvenioPersist(long? Banco = null, long? Agencia = null, string ContaCorrente = null, string Especie = null, double? NumeroConvenio = null, long? Carteira = null, string CodigoCedente = null, string EspecieTipo = null, string EspecieDocumento = null, bool? Aceite = null, string Instrucoes = null, string LocalPagamento1 = null, string LocalPagamento2 = null, string EnderecoCobrancaEmissor = null, string NomeBeneficiario = null, string CnpjBeneficiario = null)
        {
            // to ensure "Banco" is required (not null)
            if (Banco == null)
            {
                throw new InvalidDataException("Banco is a required property for ConvenioPersist and cannot be null");
            }
            else
            {
                this.Banco = Banco;
            }
            // to ensure "Agencia" is required (not null)
            if (Agencia == null)
            {
                throw new InvalidDataException("Agencia is a required property for ConvenioPersist and cannot be null");
            }
            else
            {
                this.Agencia = Agencia;
            }
            // to ensure "ContaCorrente" is required (not null)
            if (ContaCorrente == null)
            {
                throw new InvalidDataException("ContaCorrente is a required property for ConvenioPersist and cannot be null");
            }
            else
            {
                this.ContaCorrente = ContaCorrente;
            }
            this.Especie = Especie;
            this.NumeroConvenio = NumeroConvenio;
            this.Carteira = Carteira;
            this.CodigoCedente = CodigoCedente;
            this.EspecieTipo = EspecieTipo;
            this.EspecieDocumento = EspecieDocumento;
            this.Aceite = Aceite;
            this.Instrucoes = Instrucoes;
            this.LocalPagamento1 = LocalPagamento1;
            this.LocalPagamento2 = LocalPagamento2;
            this.EnderecoCobrancaEmissor = EnderecoCobrancaEmissor;
            this.NomeBeneficiario = NomeBeneficiario;
            this.CnpjBeneficiario = CnpjBeneficiario;
            
        }
        
    
        /// <summary>
        /// Bank Id
        /// </summary>
        /// <value>Bank Id</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public long? Banco { get; set; }
    
        /// <summary>
        /// Agency Number
        /// </summary>
        /// <value>Agency Number</value>
        [DataMember(Name="agencia", EmitDefaultValue=false)]
        public long? Agencia { get; set; }
    
        /// <summary>
        /// Current Account
        /// </summary>
        /// <value>Current Account</value>
        [DataMember(Name="contaCorrente", EmitDefaultValue=false)]
        public string ContaCorrente { get; set; }
    
        /// <summary>
        /// Convenant Id code
        /// </summary>
        /// <value>Convenant Id code</value>
        [DataMember(Name="especie", EmitDefaultValue=false)]
        public string Especie { get; set; }
    
        /// <summary>
        /// Number Convenant
        /// </summary>
        /// <value>Number Convenant</value>
        [DataMember(Name="numeroConvenio", EmitDefaultValue=false)]
        public double? NumeroConvenio { get; set; }
    
        /// <summary>
        /// Wallet Id Code
        /// </summary>
        /// <value>Wallet Id Code</value>
        [DataMember(Name="carteira", EmitDefaultValue=false)]
        public long? Carteira { get; set; }
    
        /// <summary>
        /// Assignor code
        /// </summary>
        /// <value>Assignor code</value>
        [DataMember(Name="codigoCedente", EmitDefaultValue=false)]
        public string CodigoCedente { get; set; }
    
        /// <summary>
        /// Species Value
        /// </summary>
        /// <value>Species Value</value>
        [DataMember(Name="especieTipo", EmitDefaultValue=false)]
        public string EspecieTipo { get; set; }
    
        /// <summary>
        /// Species Document Value
        /// </summary>
        /// <value>Species Document Value</value>
        [DataMember(Name="especieDocumento", EmitDefaultValue=false)]
        public string EspecieDocumento { get; set; }
    
        /// <summary>
        /// Information about if payer signed billing document
        /// </summary>
        /// <value>Information about if payer signed billing document</value>
        [DataMember(Name="aceite", EmitDefaultValue=false)]
        public bool? Aceite { get; set; }
    
        /// <summary>
        /// Instructions for the payment
        /// </summary>
        /// <value>Instructions for the payment</value>
        [DataMember(Name="instrucoes", EmitDefaultValue=false)]
        public string Instrucoes { get; set; }
    
        /// <summary>
        /// preferred place for payment
        /// </summary>
        /// <value>preferred place for payment</value>
        [DataMember(Name="localPagamento1", EmitDefaultValue=false)]
        public string LocalPagamento1 { get; set; }
    
        /// <summary>
        /// preferred place for payment(additional)
        /// </summary>
        /// <value>preferred place for payment(additional)</value>
        [DataMember(Name="localPagamento2", EmitDefaultValue=false)]
        public string LocalPagamento2 { get; set; }
    
        /// <summary>
        /// billing address
        /// </summary>
        /// <value>billing address</value>
        [DataMember(Name="enderecoCobrancaEmissor", EmitDefaultValue=false)]
        public string EnderecoCobrancaEmissor { get; set; }
    
        /// <summary>
        /// Beneficiary name
        /// </summary>
        /// <value>Beneficiary name</value>
        [DataMember(Name="nomeBeneficiario", EmitDefaultValue=false)]
        public string NomeBeneficiario { get; set; }
    
        /// <summary>
        /// Beneficiary cnpj
        /// </summary>
        /// <value>Beneficiary cnpj</value>
        [DataMember(Name="cnpjBeneficiario", EmitDefaultValue=false)]
        public string CnpjBeneficiario { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConvenioPersist {\n");
            sb.Append("  Banco: ").Append(Banco).Append("\n");
            sb.Append("  Agencia: ").Append(Agencia).Append("\n");
            sb.Append("  ContaCorrente: ").Append(ContaCorrente).Append("\n");
            sb.Append("  Especie: ").Append(Especie).Append("\n");
            sb.Append("  NumeroConvenio: ").Append(NumeroConvenio).Append("\n");
            sb.Append("  Carteira: ").Append(Carteira).Append("\n");
            sb.Append("  CodigoCedente: ").Append(CodigoCedente).Append("\n");
            sb.Append("  EspecieTipo: ").Append(EspecieTipo).Append("\n");
            sb.Append("  EspecieDocumento: ").Append(EspecieDocumento).Append("\n");
            sb.Append("  Aceite: ").Append(Aceite).Append("\n");
            sb.Append("  Instrucoes: ").Append(Instrucoes).Append("\n");
            sb.Append("  LocalPagamento1: ").Append(LocalPagamento1).Append("\n");
            sb.Append("  LocalPagamento2: ").Append(LocalPagamento2).Append("\n");
            sb.Append("  EnderecoCobrancaEmissor: ").Append(EnderecoCobrancaEmissor).Append("\n");
            sb.Append("  NomeBeneficiario: ").Append(NomeBeneficiario).Append("\n");
            sb.Append("  CnpjBeneficiario: ").Append(CnpjBeneficiario).Append("\n");
            
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
            return this.Equals(obj as ConvenioPersist);
        }

        /// <summary>
        /// Returns true if ConvenioPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of ConvenioPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConvenioPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.ContaCorrente == other.ContaCorrente ||
                    this.ContaCorrente != null &&
                    this.ContaCorrente.Equals(other.ContaCorrente)
                ) && 
                (
                    this.Especie == other.Especie ||
                    this.Especie != null &&
                    this.Especie.Equals(other.Especie)
                ) && 
                (
                    this.NumeroConvenio == other.NumeroConvenio ||
                    this.NumeroConvenio != null &&
                    this.NumeroConvenio.Equals(other.NumeroConvenio)
                ) && 
                (
                    this.Carteira == other.Carteira ||
                    this.Carteira != null &&
                    this.Carteira.Equals(other.Carteira)
                ) && 
                (
                    this.CodigoCedente == other.CodigoCedente ||
                    this.CodigoCedente != null &&
                    this.CodigoCedente.Equals(other.CodigoCedente)
                ) && 
                (
                    this.EspecieTipo == other.EspecieTipo ||
                    this.EspecieTipo != null &&
                    this.EspecieTipo.Equals(other.EspecieTipo)
                ) && 
                (
                    this.EspecieDocumento == other.EspecieDocumento ||
                    this.EspecieDocumento != null &&
                    this.EspecieDocumento.Equals(other.EspecieDocumento)
                ) && 
                (
                    this.Aceite == other.Aceite ||
                    this.Aceite != null &&
                    this.Aceite.Equals(other.Aceite)
                ) && 
                (
                    this.Instrucoes == other.Instrucoes ||
                    this.Instrucoes != null &&
                    this.Instrucoes.Equals(other.Instrucoes)
                ) && 
                (
                    this.LocalPagamento1 == other.LocalPagamento1 ||
                    this.LocalPagamento1 != null &&
                    this.LocalPagamento1.Equals(other.LocalPagamento1)
                ) && 
                (
                    this.LocalPagamento2 == other.LocalPagamento2 ||
                    this.LocalPagamento2 != null &&
                    this.LocalPagamento2.Equals(other.LocalPagamento2)
                ) && 
                (
                    this.EnderecoCobrancaEmissor == other.EnderecoCobrancaEmissor ||
                    this.EnderecoCobrancaEmissor != null &&
                    this.EnderecoCobrancaEmissor.Equals(other.EnderecoCobrancaEmissor)
                ) && 
                (
                    this.NomeBeneficiario == other.NomeBeneficiario ||
                    this.NomeBeneficiario != null &&
                    this.NomeBeneficiario.Equals(other.NomeBeneficiario)
                ) && 
                (
                    this.CnpjBeneficiario == other.CnpjBeneficiario ||
                    this.CnpjBeneficiario != null &&
                    this.CnpjBeneficiario.Equals(other.CnpjBeneficiario)
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
                
                if (this.Banco != null)
                    hash = hash * 59 + this.Banco.GetHashCode();
                
                if (this.Agencia != null)
                    hash = hash * 59 + this.Agencia.GetHashCode();
                
                if (this.ContaCorrente != null)
                    hash = hash * 59 + this.ContaCorrente.GetHashCode();
                
                if (this.Especie != null)
                    hash = hash * 59 + this.Especie.GetHashCode();
                
                if (this.NumeroConvenio != null)
                    hash = hash * 59 + this.NumeroConvenio.GetHashCode();
                
                if (this.Carteira != null)
                    hash = hash * 59 + this.Carteira.GetHashCode();
                
                if (this.CodigoCedente != null)
                    hash = hash * 59 + this.CodigoCedente.GetHashCode();
                
                if (this.EspecieTipo != null)
                    hash = hash * 59 + this.EspecieTipo.GetHashCode();
                
                if (this.EspecieDocumento != null)
                    hash = hash * 59 + this.EspecieDocumento.GetHashCode();
                
                if (this.Aceite != null)
                    hash = hash * 59 + this.Aceite.GetHashCode();
                
                if (this.Instrucoes != null)
                    hash = hash * 59 + this.Instrucoes.GetHashCode();
                
                if (this.LocalPagamento1 != null)
                    hash = hash * 59 + this.LocalPagamento1.GetHashCode();
                
                if (this.LocalPagamento2 != null)
                    hash = hash * 59 + this.LocalPagamento2.GetHashCode();
                
                if (this.EnderecoCobrancaEmissor != null)
                    hash = hash * 59 + this.EnderecoCobrancaEmissor.GetHashCode();
                
                if (this.NomeBeneficiario != null)
                    hash = hash * 59 + this.NomeBeneficiario.GetHashCode();
                
                if (this.CnpjBeneficiario != null)
                    hash = hash * 59 + this.CnpjBeneficiario.GetHashCode();
                
                return hash;
            }
        }

    }
}
