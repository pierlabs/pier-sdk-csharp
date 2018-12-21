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
    /// Representation Object Response for Carrier Bank Account
    /// </summary>
    [DataContract]
    public partial class ContaBancariaPortadorResponse :  IEquatable<ContaBancariaPortadorResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaBancariaPortadorResponse" /> class.
        /// Initializes a new instance of the <see cref="ContaBancariaPortadorResponse" />class.
        /// </summary>
        /// <param name="Id">Identifier Code of the Banking Account.</param>
        /// <param name="IdConta">Identifier Code of the Account Card.</param>
        /// <param name="NomeAgencia">Description of the Agency.</param>
        /// <param name="Banco">BankCode.</param>
        /// <param name="NumeroAgencia">Agency Number.</param>
        /// <param name="DigitoAgencia">Agency Digit.</param>
        /// <param name="NumeroConta">Account Number.</param>
        /// <param name="DigitoConta">Account digit.</param>
        /// <param name="FlagAtivo">Signal if the account is active or not (1: Active, 0: Inactive).</param>
        /// <param name="FlagContaOrigemDoc">Signal if the origin is DOC (1: DOC, 0: TED).</param>
        /// <param name="IdPessoaFisica">Person Code.</param>
        /// <param name="FlagContaPoupanca">Signal if the banking account is a saving account (1: Saving account, 0: Current Account).</param>
        /// <param name="Favorecido">Name of the favored.</param>
        /// <param name="NumeroReceiraFederal">Document of the favored.</param>
        /// <param name="Titularidade">Account Ownership (1:cardholder is the owner, 0: cardholder is not the owner).</param>

        public ContaBancariaPortadorResponse(long? Id = null, long? IdConta = null, string NomeAgencia = null, long? Banco = null, string NumeroAgencia = null, string DigitoAgencia = null, string NumeroConta = null, string DigitoConta = null, int? FlagAtivo = null, int? FlagContaOrigemDoc = null, long? IdPessoaFisica = null, int? FlagContaPoupanca = null, string Favorecido = null, string NumeroReceiraFederal = null, int? Titularidade = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.NomeAgencia = NomeAgencia;
            this.Banco = Banco;
            this.NumeroAgencia = NumeroAgencia;
            this.DigitoAgencia = DigitoAgencia;
            this.NumeroConta = NumeroConta;
            this.DigitoConta = DigitoConta;
            this.FlagAtivo = FlagAtivo;
            this.FlagContaOrigemDoc = FlagContaOrigemDoc;
            this.IdPessoaFisica = IdPessoaFisica;
            this.FlagContaPoupanca = FlagContaPoupanca;
            this.Favorecido = Favorecido;
            this.NumeroReceiraFederal = NumeroReceiraFederal;
            this.Titularidade = Titularidade;
            
        }
        
    
        /// <summary>
        /// Identifier Code of the Banking Account
        /// </summary>
        /// <value>Identifier Code of the Banking Account</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Identifier Code of the Account Card
        /// </summary>
        /// <value>Identifier Code of the Account Card</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Description of the Agency
        /// </summary>
        /// <value>Description of the Agency</value>
        [DataMember(Name="nomeAgencia", EmitDefaultValue=false)]
        public string NomeAgencia { get; set; }
    
        /// <summary>
        /// BankCode
        /// </summary>
        /// <value>BankCode</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public long? Banco { get; set; }
    
        /// <summary>
        /// Agency Number
        /// </summary>
        /// <value>Agency Number</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public string NumeroAgencia { get; set; }
    
        /// <summary>
        /// Agency Digit
        /// </summary>
        /// <value>Agency Digit</value>
        [DataMember(Name="digitoAgencia", EmitDefaultValue=false)]
        public string DigitoAgencia { get; set; }
    
        /// <summary>
        /// Account Number
        /// </summary>
        /// <value>Account Number</value>
        [DataMember(Name="numeroConta", EmitDefaultValue=false)]
        public string NumeroConta { get; set; }
    
        /// <summary>
        /// Account digit
        /// </summary>
        /// <value>Account digit</value>
        [DataMember(Name="digitoConta", EmitDefaultValue=false)]
        public string DigitoConta { get; set; }
    
        /// <summary>
        /// Signal if the account is active or not (1: Active, 0: Inactive)
        /// </summary>
        /// <value>Signal if the account is active or not (1: Active, 0: Inactive)</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public int? FlagAtivo { get; set; }
    
        /// <summary>
        /// Signal if the origin is DOC (1: DOC, 0: TED)
        /// </summary>
        /// <value>Signal if the origin is DOC (1: DOC, 0: TED)</value>
        [DataMember(Name="flagContaOrigemDoc", EmitDefaultValue=false)]
        public int? FlagContaOrigemDoc { get; set; }
    
        /// <summary>
        /// Person Code
        /// </summary>
        /// <value>Person Code</value>
        [DataMember(Name="idPessoaFisica", EmitDefaultValue=false)]
        public long? IdPessoaFisica { get; set; }
    
        /// <summary>
        /// Signal if the banking account is a saving account (1: Saving account, 0: Current Account)
        /// </summary>
        /// <value>Signal if the banking account is a saving account (1: Saving account, 0: Current Account)</value>
        [DataMember(Name="flagContaPoupanca", EmitDefaultValue=false)]
        public int? FlagContaPoupanca { get; set; }
    
        /// <summary>
        /// Name of the favored
        /// </summary>
        /// <value>Name of the favored</value>
        [DataMember(Name="favorecido", EmitDefaultValue=false)]
        public string Favorecido { get; set; }
    
        /// <summary>
        /// Document of the favored
        /// </summary>
        /// <value>Document of the favored</value>
        [DataMember(Name="numeroReceiraFederal", EmitDefaultValue=false)]
        public string NumeroReceiraFederal { get; set; }
    
        /// <summary>
        /// Account Ownership (1:cardholder is the owner, 0: cardholder is not the owner)
        /// </summary>
        /// <value>Account Ownership (1:cardholder is the owner, 0: cardholder is not the owner)</value>
        [DataMember(Name="titularidade", EmitDefaultValue=false)]
        public int? Titularidade { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContaBancariaPortadorResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  NomeAgencia: ").Append(NomeAgencia).Append("\n");
            sb.Append("  Banco: ").Append(Banco).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  DigitoAgencia: ").Append(DigitoAgencia).Append("\n");
            sb.Append("  NumeroConta: ").Append(NumeroConta).Append("\n");
            sb.Append("  DigitoConta: ").Append(DigitoConta).Append("\n");
            sb.Append("  FlagAtivo: ").Append(FlagAtivo).Append("\n");
            sb.Append("  FlagContaOrigemDoc: ").Append(FlagContaOrigemDoc).Append("\n");
            sb.Append("  IdPessoaFisica: ").Append(IdPessoaFisica).Append("\n");
            sb.Append("  FlagContaPoupanca: ").Append(FlagContaPoupanca).Append("\n");
            sb.Append("  Favorecido: ").Append(Favorecido).Append("\n");
            sb.Append("  NumeroReceiraFederal: ").Append(NumeroReceiraFederal).Append("\n");
            sb.Append("  Titularidade: ").Append(Titularidade).Append("\n");
            
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
            return this.Equals(obj as ContaBancariaPortadorResponse);
        }

        /// <summary>
        /// Returns true if ContaBancariaPortadorResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ContaBancariaPortadorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContaBancariaPortadorResponse other)
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
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.NomeAgencia == other.NomeAgencia ||
                    this.NomeAgencia != null &&
                    this.NomeAgencia.Equals(other.NomeAgencia)
                ) && 
                (
                    this.Banco == other.Banco ||
                    this.Banco != null &&
                    this.Banco.Equals(other.Banco)
                ) && 
                (
                    this.NumeroAgencia == other.NumeroAgencia ||
                    this.NumeroAgencia != null &&
                    this.NumeroAgencia.Equals(other.NumeroAgencia)
                ) && 
                (
                    this.DigitoAgencia == other.DigitoAgencia ||
                    this.DigitoAgencia != null &&
                    this.DigitoAgencia.Equals(other.DigitoAgencia)
                ) && 
                (
                    this.NumeroConta == other.NumeroConta ||
                    this.NumeroConta != null &&
                    this.NumeroConta.Equals(other.NumeroConta)
                ) && 
                (
                    this.DigitoConta == other.DigitoConta ||
                    this.DigitoConta != null &&
                    this.DigitoConta.Equals(other.DigitoConta)
                ) && 
                (
                    this.FlagAtivo == other.FlagAtivo ||
                    this.FlagAtivo != null &&
                    this.FlagAtivo.Equals(other.FlagAtivo)
                ) && 
                (
                    this.FlagContaOrigemDoc == other.FlagContaOrigemDoc ||
                    this.FlagContaOrigemDoc != null &&
                    this.FlagContaOrigemDoc.Equals(other.FlagContaOrigemDoc)
                ) && 
                (
                    this.IdPessoaFisica == other.IdPessoaFisica ||
                    this.IdPessoaFisica != null &&
                    this.IdPessoaFisica.Equals(other.IdPessoaFisica)
                ) && 
                (
                    this.FlagContaPoupanca == other.FlagContaPoupanca ||
                    this.FlagContaPoupanca != null &&
                    this.FlagContaPoupanca.Equals(other.FlagContaPoupanca)
                ) && 
                (
                    this.Favorecido == other.Favorecido ||
                    this.Favorecido != null &&
                    this.Favorecido.Equals(other.Favorecido)
                ) && 
                (
                    this.NumeroReceiraFederal == other.NumeroReceiraFederal ||
                    this.NumeroReceiraFederal != null &&
                    this.NumeroReceiraFederal.Equals(other.NumeroReceiraFederal)
                ) && 
                (
                    this.Titularidade == other.Titularidade ||
                    this.Titularidade != null &&
                    this.Titularidade.Equals(other.Titularidade)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.NomeAgencia != null)
                    hash = hash * 59 + this.NomeAgencia.GetHashCode();
                
                if (this.Banco != null)
                    hash = hash * 59 + this.Banco.GetHashCode();
                
                if (this.NumeroAgencia != null)
                    hash = hash * 59 + this.NumeroAgencia.GetHashCode();
                
                if (this.DigitoAgencia != null)
                    hash = hash * 59 + this.DigitoAgencia.GetHashCode();
                
                if (this.NumeroConta != null)
                    hash = hash * 59 + this.NumeroConta.GetHashCode();
                
                if (this.DigitoConta != null)
                    hash = hash * 59 + this.DigitoConta.GetHashCode();
                
                if (this.FlagAtivo != null)
                    hash = hash * 59 + this.FlagAtivo.GetHashCode();
                
                if (this.FlagContaOrigemDoc != null)
                    hash = hash * 59 + this.FlagContaOrigemDoc.GetHashCode();
                
                if (this.IdPessoaFisica != null)
                    hash = hash * 59 + this.IdPessoaFisica.GetHashCode();
                
                if (this.FlagContaPoupanca != null)
                    hash = hash * 59 + this.FlagContaPoupanca.GetHashCode();
                
                if (this.Favorecido != null)
                    hash = hash * 59 + this.Favorecido.GetHashCode();
                
                if (this.NumeroReceiraFederal != null)
                    hash = hash * 59 + this.NumeroReceiraFederal.GetHashCode();
                
                if (this.Titularidade != null)
                    hash = hash * 59 + this.Titularidade.GetHashCode();
                
                return hash;
            }
        }

    }
}
