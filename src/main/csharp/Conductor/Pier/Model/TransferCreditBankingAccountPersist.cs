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
    /// Credit Transfer for the bank account
    /// </summary>
    [DataContract]
    public partial class TransferCreditBankingAccountPersist :  IEquatable<TransferCreditBankingAccountPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferCreditBankingAccountPersist" /> class.
        /// Initializes a new instance of the <see cref="TransferCreditBankingAccountPersist" />class.
        /// </summary>
        /// <param name="NsuOrigem">Represent the Unique Sequel Number that identifies the transaction in the system which has created it (required).</param>
        /// <param name="IdCartao">Represent the Card Identifier (required).</param>
        /// <param name="IdContaBancaria">Represent the Banking account identifier (required).</param>
        /// <param name="Valor">Represent the value of the transfer (required).</param>
        /// <param name="NumeroParcelas">Represent the number of parcels which the value of the transfer will be divided (required).</param>
        /// <param name="NumeroMesesCarencia">Represent the number of months given as a lack (required).</param>
        /// <param name="DataHoraTerminal">Represent the date and the time of the terminal requestor (required).</param>
        /// <param name="TerminalRequisitante">Represent the identification of the terminal acquirer (required).</param>
        /// <param name="NumeroEstabelecimento">Represent the Merchant Identification Number (required).</param>

        public TransferCreditBankingAccountPersist(long? NsuOrigem = null, long? IdCartao = null, long? IdContaBancaria = null, double? Valor = null, long? NumeroParcelas = null, int? NumeroMesesCarencia = null, string DataHoraTerminal = null, string TerminalRequisitante = null, string NumeroEstabelecimento = null)
        {
            // to ensure "NsuOrigem" is required (not null)
            if (NsuOrigem == null)
            {
                throw new InvalidDataException("NsuOrigem is a required property for TransferCreditBankingAccountPersist and cannot be null");
            }
            else
            {
                this.NsuOrigem = NsuOrigem;
            }
            // to ensure "IdCartao" is required (not null)
            if (IdCartao == null)
            {
                throw new InvalidDataException("IdCartao is a required property for TransferCreditBankingAccountPersist and cannot be null");
            }
            else
            {
                this.IdCartao = IdCartao;
            }
            // to ensure "IdContaBancaria" is required (not null)
            if (IdContaBancaria == null)
            {
                throw new InvalidDataException("IdContaBancaria is a required property for TransferCreditBankingAccountPersist and cannot be null");
            }
            else
            {
                this.IdContaBancaria = IdContaBancaria;
            }
            // to ensure "Valor" is required (not null)
            if (Valor == null)
            {
                throw new InvalidDataException("Valor is a required property for TransferCreditBankingAccountPersist and cannot be null");
            }
            else
            {
                this.Valor = Valor;
            }
            // to ensure "NumeroParcelas" is required (not null)
            if (NumeroParcelas == null)
            {
                throw new InvalidDataException("NumeroParcelas is a required property for TransferCreditBankingAccountPersist and cannot be null");
            }
            else
            {
                this.NumeroParcelas = NumeroParcelas;
            }
            // to ensure "NumeroMesesCarencia" is required (not null)
            if (NumeroMesesCarencia == null)
            {
                throw new InvalidDataException("NumeroMesesCarencia is a required property for TransferCreditBankingAccountPersist and cannot be null");
            }
            else
            {
                this.NumeroMesesCarencia = NumeroMesesCarencia;
            }
            // to ensure "DataHoraTerminal" is required (not null)
            if (DataHoraTerminal == null)
            {
                throw new InvalidDataException("DataHoraTerminal is a required property for TransferCreditBankingAccountPersist and cannot be null");
            }
            else
            {
                this.DataHoraTerminal = DataHoraTerminal;
            }
            // to ensure "TerminalRequisitante" is required (not null)
            if (TerminalRequisitante == null)
            {
                throw new InvalidDataException("TerminalRequisitante is a required property for TransferCreditBankingAccountPersist and cannot be null");
            }
            else
            {
                this.TerminalRequisitante = TerminalRequisitante;
            }
            // to ensure "NumeroEstabelecimento" is required (not null)
            if (NumeroEstabelecimento == null)
            {
                throw new InvalidDataException("NumeroEstabelecimento is a required property for TransferCreditBankingAccountPersist and cannot be null");
            }
            else
            {
                this.NumeroEstabelecimento = NumeroEstabelecimento;
            }
            
        }
        
    
        /// <summary>
        /// Represent the Unique Sequel Number that identifies the transaction in the system which has created it
        /// </summary>
        /// <value>Represent the Unique Sequel Number that identifies the transaction in the system which has created it</value>
        [DataMember(Name="nsuOrigem", EmitDefaultValue=false)]
        public long? NsuOrigem { get; set; }
    
        /// <summary>
        /// Represent the Card Identifier
        /// </summary>
        /// <value>Represent the Card Identifier</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Represent the Banking account identifier
        /// </summary>
        /// <value>Represent the Banking account identifier</value>
        [DataMember(Name="idContaBancaria", EmitDefaultValue=false)]
        public long? IdContaBancaria { get; set; }
    
        /// <summary>
        /// Represent the value of the transfer
        /// </summary>
        /// <value>Represent the value of the transfer</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// Represent the number of parcels which the value of the transfer will be divided
        /// </summary>
        /// <value>Represent the number of parcels which the value of the transfer will be divided</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public long? NumeroParcelas { get; set; }
    
        /// <summary>
        /// Represent the number of months given as a lack
        /// </summary>
        /// <value>Represent the number of months given as a lack</value>
        [DataMember(Name="numeroMesesCarencia", EmitDefaultValue=false)]
        public int? NumeroMesesCarencia { get; set; }
    
        /// <summary>
        /// Represent the date and the time of the terminal requestor
        /// </summary>
        /// <value>Represent the date and the time of the terminal requestor</value>
        [DataMember(Name="dataHoraTerminal", EmitDefaultValue=false)]
        public string DataHoraTerminal { get; set; }
    
        /// <summary>
        /// Represent the identification of the terminal acquirer
        /// </summary>
        /// <value>Represent the identification of the terminal acquirer</value>
        [DataMember(Name="terminalRequisitante", EmitDefaultValue=false)]
        public string TerminalRequisitante { get; set; }
    
        /// <summary>
        /// Represent the Merchant Identification Number
        /// </summary>
        /// <value>Represent the Merchant Identification Number</value>
        [DataMember(Name="numeroEstabelecimento", EmitDefaultValue=false)]
        public string NumeroEstabelecimento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferCreditBankingAccountPersist {\n");
            sb.Append("  NsuOrigem: ").Append(NsuOrigem).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdContaBancaria: ").Append(IdContaBancaria).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  NumeroParcelas: ").Append(NumeroParcelas).Append("\n");
            sb.Append("  NumeroMesesCarencia: ").Append(NumeroMesesCarencia).Append("\n");
            sb.Append("  DataHoraTerminal: ").Append(DataHoraTerminal).Append("\n");
            sb.Append("  TerminalRequisitante: ").Append(TerminalRequisitante).Append("\n");
            sb.Append("  NumeroEstabelecimento: ").Append(NumeroEstabelecimento).Append("\n");
            
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
            return this.Equals(obj as TransferCreditBankingAccountPersist);
        }

        /// <summary>
        /// Returns true if TransferCreditBankingAccountPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of TransferCreditBankingAccountPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferCreditBankingAccountPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NsuOrigem == other.NsuOrigem ||
                    this.NsuOrigem != null &&
                    this.NsuOrigem.Equals(other.NsuOrigem)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.IdContaBancaria == other.IdContaBancaria ||
                    this.IdContaBancaria != null &&
                    this.IdContaBancaria.Equals(other.IdContaBancaria)
                ) && 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
                ) && 
                (
                    this.NumeroParcelas == other.NumeroParcelas ||
                    this.NumeroParcelas != null &&
                    this.NumeroParcelas.Equals(other.NumeroParcelas)
                ) && 
                (
                    this.NumeroMesesCarencia == other.NumeroMesesCarencia ||
                    this.NumeroMesesCarencia != null &&
                    this.NumeroMesesCarencia.Equals(other.NumeroMesesCarencia)
                ) && 
                (
                    this.DataHoraTerminal == other.DataHoraTerminal ||
                    this.DataHoraTerminal != null &&
                    this.DataHoraTerminal.Equals(other.DataHoraTerminal)
                ) && 
                (
                    this.TerminalRequisitante == other.TerminalRequisitante ||
                    this.TerminalRequisitante != null &&
                    this.TerminalRequisitante.Equals(other.TerminalRequisitante)
                ) && 
                (
                    this.NumeroEstabelecimento == other.NumeroEstabelecimento ||
                    this.NumeroEstabelecimento != null &&
                    this.NumeroEstabelecimento.Equals(other.NumeroEstabelecimento)
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
                
                if (this.NsuOrigem != null)
                    hash = hash * 59 + this.NsuOrigem.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.IdContaBancaria != null)
                    hash = hash * 59 + this.IdContaBancaria.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                if (this.NumeroParcelas != null)
                    hash = hash * 59 + this.NumeroParcelas.GetHashCode();
                
                if (this.NumeroMesesCarencia != null)
                    hash = hash * 59 + this.NumeroMesesCarencia.GetHashCode();
                
                if (this.DataHoraTerminal != null)
                    hash = hash * 59 + this.DataHoraTerminal.GetHashCode();
                
                if (this.TerminalRequisitante != null)
                    hash = hash * 59 + this.TerminalRequisitante.GetHashCode();
                
                if (this.NumeroEstabelecimento != null)
                    hash = hash * 59 + this.NumeroEstabelecimento.GetHashCode();
                
                return hash;
            }
        }

    }
}
