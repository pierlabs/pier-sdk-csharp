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
    /// Transfer\u00EAncia banc\u00E1ria
    /// </summary>
    [DataContract]
    public partial class TransferenciaBancariaPersist :  IEquatable<TransferenciaBancariaPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferenciaBancariaPersist" /> class.
        /// Initializes a new instance of the <see cref="TransferenciaBancariaPersist" />class.
        /// </summary>
        /// <param name="ValorCompra">Valor da transfer\u00EAncia (required).</param>
        /// <param name="Valor">Valor da transfer\u00EAncia (required).</param>
        /// <param name="DocumentoFavorecido">N\u00FAmero do CPF ou CNPJ. (required).</param>
        /// <param name="Banco">C\u00F3digo do banco (required).</param>
        /// <param name="NumeroAgencia">N\u00FAmero da ag\u00EAncia (required).</param>
        /// <param name="DigitoAgencia">D\u00EDgito da ag\u00EAncia.</param>
        /// <param name="NumeroConta">N\u00FAmero da conta (required).</param>
        /// <param name="DigitoConta">D\u00EDgito da conta.</param>
        /// <param name="FlagContaPoupanca">Sinaliza se conta banc\u00E1ria \u00E9 poupan\u00E7a (1: Poupan\u00E7a, 0: Conta corrente) (required).</param>
        /// <param name="NomeFavorecido">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;. (required).</param>

        public TransferenciaBancariaPersist(double? ValorCompra = null, double? Valor = null, string DocumentoFavorecido = null, long? Banco = null, string NumeroAgencia = null, string DigitoAgencia = null, string NumeroConta = null, string DigitoConta = null, int? FlagContaPoupanca = null, string NomeFavorecido = null)
        {
            // to ensure "ValorCompra" is required (not null)
            if (ValorCompra == null)
            {
                throw new InvalidDataException("ValorCompra is a required property for TransferenciaBancariaPersist and cannot be null");
            }
            else
            {
                this.ValorCompra = ValorCompra;
            }
            // to ensure "Valor" is required (not null)
            if (Valor == null)
            {
                throw new InvalidDataException("Valor is a required property for TransferenciaBancariaPersist and cannot be null");
            }
            else
            {
                this.Valor = Valor;
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
            // to ensure "NomeFavorecido" is required (not null)
            if (NomeFavorecido == null)
            {
                throw new InvalidDataException("NomeFavorecido is a required property for TransferenciaBancariaPersist and cannot be null");
            }
            else
            {
                this.NomeFavorecido = NomeFavorecido;
            }
            this.DigitoAgencia = DigitoAgencia;
            this.DigitoConta = DigitoConta;
            
        }
        
    
        /// <summary>
        /// Valor da transfer\u00EAncia
        /// </summary>
        /// <value>Valor da transfer\u00EAncia</value>
        [DataMember(Name="valorCompra", EmitDefaultValue=false)]
        public double? ValorCompra { get; set; }
    
        /// <summary>
        /// Valor da transfer\u00EAncia
        /// </summary>
        /// <value>Valor da transfer\u00EAncia</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// N\u00FAmero do CPF ou CNPJ.
        /// </summary>
        /// <value>N\u00FAmero do CPF ou CNPJ.</value>
        [DataMember(Name="documentoFavorecido", EmitDefaultValue=false)]
        public string DocumentoFavorecido { get; set; }
    
        /// <summary>
        /// C\u00F3digo do banco
        /// </summary>
        /// <value>C\u00F3digo do banco</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public long? Banco { get; set; }
    
        /// <summary>
        /// N\u00FAmero da ag\u00EAncia
        /// </summary>
        /// <value>N\u00FAmero da ag\u00EAncia</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public string NumeroAgencia { get; set; }
    
        /// <summary>
        /// D\u00EDgito da ag\u00EAncia
        /// </summary>
        /// <value>D\u00EDgito da ag\u00EAncia</value>
        [DataMember(Name="digitoAgencia", EmitDefaultValue=false)]
        public string DigitoAgencia { get; set; }
    
        /// <summary>
        /// N\u00FAmero da conta
        /// </summary>
        /// <value>N\u00FAmero da conta</value>
        [DataMember(Name="numeroConta", EmitDefaultValue=false)]
        public string NumeroConta { get; set; }
    
        /// <summary>
        /// D\u00EDgito da conta
        /// </summary>
        /// <value>D\u00EDgito da conta</value>
        [DataMember(Name="digitoConta", EmitDefaultValue=false)]
        public string DigitoConta { get; set; }
    
        /// <summary>
        /// Sinaliza se conta banc\u00E1ria \u00E9 poupan\u00E7a (1: Poupan\u00E7a, 0: Conta corrente)
        /// </summary>
        /// <value>Sinaliza se conta banc\u00E1ria \u00E9 poupan\u00E7a (1: Poupan\u00E7a, 0: Conta corrente)</value>
        [DataMember(Name="flagContaPoupanca", EmitDefaultValue=false)]
        public int? FlagContaPoupanca { get; set; }
    
        /// <summary>
        /// Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;.
        /// </summary>
        /// <value>Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;.</value>
        [DataMember(Name="nomeFavorecido", EmitDefaultValue=false)]
        public string NomeFavorecido { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferenciaBancariaPersist {\n");
            sb.Append("  ValorCompra: ").Append(ValorCompra).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  DocumentoFavorecido: ").Append(DocumentoFavorecido).Append("\n");
            sb.Append("  Banco: ").Append(Banco).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  DigitoAgencia: ").Append(DigitoAgencia).Append("\n");
            sb.Append("  NumeroConta: ").Append(NumeroConta).Append("\n");
            sb.Append("  DigitoConta: ").Append(DigitoConta).Append("\n");
            sb.Append("  FlagContaPoupanca: ").Append(FlagContaPoupanca).Append("\n");
            sb.Append("  NomeFavorecido: ").Append(NomeFavorecido).Append("\n");
            
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
                    this.ValorCompra == other.ValorCompra ||
                    this.ValorCompra != null &&
                    this.ValorCompra.Equals(other.ValorCompra)
                ) && 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
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
                ) && 
                (
                    this.NomeFavorecido == other.NomeFavorecido ||
                    this.NomeFavorecido != null &&
                    this.NomeFavorecido.Equals(other.NomeFavorecido)
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
                
                if (this.ValorCompra != null)
                    hash = hash * 59 + this.ValorCompra.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
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
                
                if (this.NomeFavorecido != null)
                    hash = hash * 59 + this.NomeFavorecido.GetHashCode();
                
                return hash;
            }
        }

    }
}
