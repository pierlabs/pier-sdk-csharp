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
    /// Transfer\u00C3\u00AAncia banc\u00C3\u00A1ria
    /// </summary>
    [DataContract]
    public partial class TransferenciaBancariaPersist :  IEquatable<TransferenciaBancariaPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferenciaBancariaPersist" /> class.
        /// Initializes a new instance of the <see cref="TransferenciaBancariaPersist" />class.
        /// </summary>
        /// <param name="DataCompra">Data da transfer\u00C3\u00AAncia (required).</param>
        /// <param name="ProximoVencimentoPadrao">Dia do vencimento padr\u00C3\u00A3o da fatura (required).</param>
        /// <param name="ProximoVencimentoReal">Data do vencimento real da fatura (required).</param>
        /// <param name="ValorCompra">Valor da transfer\u00C3\u00AAncia (required).</param>
        /// <param name="NomeFavorecido">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;. (required).</param>
        /// <param name="DocumentoFavorecido">N\u00C3\u00BAmero do CPF ou CNPJ. (required).</param>
        /// <param name="Banco">C\u00C3\u00B3digo do banco (required).</param>
        /// <param name="NumeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia (required).</param>
        /// <param name="DigitoAgencia">D\u00C3\u00ADgito da ag\u00C3\u00AAncia.</param>
        /// <param name="NumeroConta">N\u00C3\u00BAmero da conta (required).</param>
        /// <param name="DigitoConta">D\u00C3\u00ADgito da conta.</param>
        /// <param name="FlagContaPoupanca">Sinaliza se conta banc\u00C3\u00A1ria \u00C3\u00A9 poupan\u00C3\u00A7a (1: Poupan\u00C3\u00A7a, 0: Conta corrente) (required).</param>

        public TransferenciaBancariaPersist(DateTime? DataCompra = null, DateTime? ProximoVencimentoPadrao = null, DateTime? ProximoVencimentoReal = null, double? ValorCompra = null, string NomeFavorecido = null, string DocumentoFavorecido = null, long? Banco = null, string NumeroAgencia = null, string DigitoAgencia = null, string NumeroConta = null, string DigitoConta = null, int? FlagContaPoupanca = null)
        {
            // to ensure "DataCompra" is required (not null)
            if (DataCompra == null)
            {
                throw new InvalidDataException("DataCompra is a required property for TransferenciaBancariaPersist and cannot be null");
            }
            else
            {
                this.DataCompra = DataCompra;
            }
            // to ensure "ProximoVencimentoPadrao" is required (not null)
            if (ProximoVencimentoPadrao == null)
            {
                throw new InvalidDataException("ProximoVencimentoPadrao is a required property for TransferenciaBancariaPersist and cannot be null");
            }
            else
            {
                this.ProximoVencimentoPadrao = ProximoVencimentoPadrao;
            }
            // to ensure "ProximoVencimentoReal" is required (not null)
            if (ProximoVencimentoReal == null)
            {
                throw new InvalidDataException("ProximoVencimentoReal is a required property for TransferenciaBancariaPersist and cannot be null");
            }
            else
            {
                this.ProximoVencimentoReal = ProximoVencimentoReal;
            }
            // to ensure "ValorCompra" is required (not null)
            if (ValorCompra == null)
            {
                throw new InvalidDataException("ValorCompra is a required property for TransferenciaBancariaPersist and cannot be null");
            }
            else
            {
                this.ValorCompra = ValorCompra;
            }
            // to ensure "NomeFavorecido" is required (not null)
            if (NomeFavorecido == null)
            {
                throw new InvalidDataException("NomeFavorecido is a required property for TransferenciaBancariaPersist and cannot be null");
            }
            else
            {
                this.NomeFavorecido = NomeFavorecido;
            }
            // to ensure "DocumentoFavorecido" is required (not null)
            if (DocumentoFavorecido == null)
            {
                throw new InvalidDataException("DocumentoFavorecido is a required property for TransferenciaBancariaPersist and cannot be null");
            }
            else
            {
                this.DocumentoFavorecido = DocumentoFavorecido;
            }
            // to ensure "Banco" is required (not null)
            if (Banco == null)
            {
                throw new InvalidDataException("Banco is a required property for TransferenciaBancariaPersist and cannot be null");
            }
            else
            {
                this.Banco = Banco;
            }
            // to ensure "NumeroAgencia" is required (not null)
            if (NumeroAgencia == null)
            {
                throw new InvalidDataException("NumeroAgencia is a required property for TransferenciaBancariaPersist and cannot be null");
            }
            else
            {
                this.NumeroAgencia = NumeroAgencia;
            }
            // to ensure "NumeroConta" is required (not null)
            if (NumeroConta == null)
            {
                throw new InvalidDataException("NumeroConta is a required property for TransferenciaBancariaPersist and cannot be null");
            }
            else
            {
                this.NumeroConta = NumeroConta;
            }
            // to ensure "FlagContaPoupanca" is required (not null)
            if (FlagContaPoupanca == null)
            {
                throw new InvalidDataException("FlagContaPoupanca is a required property for TransferenciaBancariaPersist and cannot be null");
            }
            else
            {
                this.FlagContaPoupanca = FlagContaPoupanca;
            }
            this.DigitoAgencia = DigitoAgencia;
            this.DigitoConta = DigitoConta;
            
        }
        
    
        /// <summary>
        /// Data da transfer\u00C3\u00AAncia
        /// </summary>
        /// <value>Data da transfer\u00C3\u00AAncia</value>
        [DataMember(Name="dataCompra", EmitDefaultValue=false)]
        public DateTime? DataCompra { get; set; }
    
        /// <summary>
        /// Dia do vencimento padr\u00C3\u00A3o da fatura
        /// </summary>
        /// <value>Dia do vencimento padr\u00C3\u00A3o da fatura</value>
        [DataMember(Name="proximoVencimentoPadrao", EmitDefaultValue=false)]
        public DateTime? ProximoVencimentoPadrao { get; set; }
    
        /// <summary>
        /// Data do vencimento real da fatura
        /// </summary>
        /// <value>Data do vencimento real da fatura</value>
        [DataMember(Name="proximoVencimentoReal", EmitDefaultValue=false)]
        public DateTime? ProximoVencimentoReal { get; set; }
    
        /// <summary>
        /// Valor da transfer\u00C3\u00AAncia
        /// </summary>
        /// <value>Valor da transfer\u00C3\u00AAncia</value>
        [DataMember(Name="valorCompra", EmitDefaultValue=false)]
        public double? ValorCompra { get; set; }
    
        /// <summary>
        /// Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;.
        /// </summary>
        /// <value>Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;.</value>
        [DataMember(Name="nomeFavorecido", EmitDefaultValue=false)]
        public string NomeFavorecido { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero do CPF ou CNPJ.
        /// </summary>
        /// <value>N\u00C3\u00BAmero do CPF ou CNPJ.</value>
        [DataMember(Name="documentoFavorecido", EmitDefaultValue=false)]
        public string DocumentoFavorecido { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo do banco
        /// </summary>
        /// <value>C\u00C3\u00B3digo do banco</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public long? Banco { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero da ag\u00C3\u00AAncia
        /// </summary>
        /// <value>N\u00C3\u00BAmero da ag\u00C3\u00AAncia</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public string NumeroAgencia { get; set; }
    
        /// <summary>
        /// D\u00C3\u00ADgito da ag\u00C3\u00AAncia
        /// </summary>
        /// <value>D\u00C3\u00ADgito da ag\u00C3\u00AAncia</value>
        [DataMember(Name="digitoAgencia", EmitDefaultValue=false)]
        public string DigitoAgencia { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero da conta
        /// </summary>
        /// <value>N\u00C3\u00BAmero da conta</value>
        [DataMember(Name="numeroConta", EmitDefaultValue=false)]
        public string NumeroConta { get; set; }
    
        /// <summary>
        /// D\u00C3\u00ADgito da conta
        /// </summary>
        /// <value>D\u00C3\u00ADgito da conta</value>
        [DataMember(Name="digitoConta", EmitDefaultValue=false)]
        public string DigitoConta { get; set; }
    
        /// <summary>
        /// Sinaliza se conta banc\u00C3\u00A1ria \u00C3\u00A9 poupan\u00C3\u00A7a (1: Poupan\u00C3\u00A7a, 0: Conta corrente)
        /// </summary>
        /// <value>Sinaliza se conta banc\u00C3\u00A1ria \u00C3\u00A9 poupan\u00C3\u00A7a (1: Poupan\u00C3\u00A7a, 0: Conta corrente)</value>
        [DataMember(Name="flagContaPoupanca", EmitDefaultValue=false)]
        public int? FlagContaPoupanca { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferenciaBancariaPersist {\n");
            sb.Append("  DataCompra: ").Append(DataCompra).Append("\n");
            sb.Append("  ProximoVencimentoPadrao: ").Append(ProximoVencimentoPadrao).Append("\n");
            sb.Append("  ProximoVencimentoReal: ").Append(ProximoVencimentoReal).Append("\n");
            sb.Append("  ValorCompra: ").Append(ValorCompra).Append("\n");
            sb.Append("  NomeFavorecido: ").Append(NomeFavorecido).Append("\n");
            sb.Append("  DocumentoFavorecido: ").Append(DocumentoFavorecido).Append("\n");
            sb.Append("  Banco: ").Append(Banco).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  DigitoAgencia: ").Append(DigitoAgencia).Append("\n");
            sb.Append("  NumeroConta: ").Append(NumeroConta).Append("\n");
            sb.Append("  DigitoConta: ").Append(DigitoConta).Append("\n");
            sb.Append("  FlagContaPoupanca: ").Append(FlagContaPoupanca).Append("\n");
            
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
            return this.Equals(obj as TransferenciaBancariaPersist);
        }

        /// <summary>
        /// Returns true if TransferenciaBancariaPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of TransferenciaBancariaPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferenciaBancariaPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataCompra == other.DataCompra ||
                    this.DataCompra != null &&
                    this.DataCompra.Equals(other.DataCompra)
                ) && 
                (
                    this.ProximoVencimentoPadrao == other.ProximoVencimentoPadrao ||
                    this.ProximoVencimentoPadrao != null &&
                    this.ProximoVencimentoPadrao.Equals(other.ProximoVencimentoPadrao)
                ) && 
                (
                    this.ProximoVencimentoReal == other.ProximoVencimentoReal ||
                    this.ProximoVencimentoReal != null &&
                    this.ProximoVencimentoReal.Equals(other.ProximoVencimentoReal)
                ) && 
                (
                    this.ValorCompra == other.ValorCompra ||
                    this.ValorCompra != null &&
                    this.ValorCompra.Equals(other.ValorCompra)
                ) && 
                (
                    this.NomeFavorecido == other.NomeFavorecido ||
                    this.NomeFavorecido != null &&
                    this.NomeFavorecido.Equals(other.NomeFavorecido)
                ) && 
                (
                    this.DocumentoFavorecido == other.DocumentoFavorecido ||
                    this.DocumentoFavorecido != null &&
                    this.DocumentoFavorecido.Equals(other.DocumentoFavorecido)
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
                    this.FlagContaPoupanca == other.FlagContaPoupanca ||
                    this.FlagContaPoupanca != null &&
                    this.FlagContaPoupanca.Equals(other.FlagContaPoupanca)
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
                
                if (this.DataCompra != null)
                    hash = hash * 59 + this.DataCompra.GetHashCode();
                
                if (this.ProximoVencimentoPadrao != null)
                    hash = hash * 59 + this.ProximoVencimentoPadrao.GetHashCode();
                
                if (this.ProximoVencimentoReal != null)
                    hash = hash * 59 + this.ProximoVencimentoReal.GetHashCode();
                
                if (this.ValorCompra != null)
                    hash = hash * 59 + this.ValorCompra.GetHashCode();
                
                if (this.NomeFavorecido != null)
                    hash = hash * 59 + this.NomeFavorecido.GetHashCode();
                
                if (this.DocumentoFavorecido != null)
                    hash = hash * 59 + this.DocumentoFavorecido.GetHashCode();
                
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
                
                if (this.FlagContaPoupanca != null)
                    hash = hash * 59 + this.FlagContaPoupanca.GetHashCode();
                
                return hash;
            }
        }

    }
}
