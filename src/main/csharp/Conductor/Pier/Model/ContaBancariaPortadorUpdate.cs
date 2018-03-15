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
    /// Objeto ContaBancariaPortador
    /// </summary>
    [DataContract]
    public partial class ContaBancariaPortadorUpdate :  IEquatable<ContaBancariaPortadorUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaBancariaPortadorUpdate" /> class.
        /// Initializes a new instance of the <see cref="ContaBancariaPortadorUpdate" />class.
        /// </summary>
        /// <param name="NomeAgencia">Descri\u00E7\u00E3o da ag\u00EAncia.</param>
        /// <param name="Banco">C\u00F3digo do banco (required).</param>
        /// <param name="NumeroAgencia">N\u00FAmero da ag\u00EAncia (required).</param>
        /// <param name="DigitoAgencia">D\u00EDgito da ag\u00EAncia.</param>
        /// <param name="NumeroConta">N\u00FAmero da conta (required).</param>
        /// <param name="DigitoConta">D\u00EDgito da conta.</param>
        /// <param name="FlagAtivo">Sinaliza se conta banc\u00E1ria est\u00E1 ativa ou n\u00E3o (1: Ativa, 0: Inativa) (required).</param>
        /// <param name="FlagContaOrigemDoc">Sinaliza se origem \u00E9 DOC (1: DOC, 0: TED) (required).</param>
        /// <param name="FlagContaPoupanca">Sinaliza se conta banc\u00E1ria \u00E9 poupan\u00E7a (1: Poupan\u00E7a, 0: Conta corrente) (required).</param>
        /// <param name="Favorecido">Nome do favorecido (required).</param>
        /// <param name="NumeroReceiraFederal">Documento do favorecido (required).</param>
        /// <param name="Titularidade">Titularidade da conta (1:Portador \u00E9 o titular, 0: Portador n\u00E3o \u00E9 o t\u00EDtular.</param>

        public ContaBancariaPortadorUpdate(string NomeAgencia = null, long? Banco = null, string NumeroAgencia = null, string DigitoAgencia = null, string NumeroConta = null, string DigitoConta = null, int? FlagAtivo = null, int? FlagContaOrigemDoc = null, int? FlagContaPoupanca = null, string Favorecido = null, string NumeroReceiraFederal = null, int? Titularidade = null)
        {
            // to ensure "Banco" is required (not null)
            if (Banco == null)
            {
                throw new InvalidDataException("Banco is a required property for ContaBancariaPortadorUpdate and cannot be null");
            }
            else
            {
                this.Banco = Banco;
            }
            // to ensure "NumeroAgencia" is required (not null)
            if (NumeroAgencia == null)
            {
                throw new InvalidDataException("NumeroAgencia is a required property for ContaBancariaPortadorUpdate and cannot be null");
            }
            else
            {
                this.NumeroAgencia = NumeroAgencia;
            }
            // to ensure "NumeroConta" is required (not null)
            if (NumeroConta == null)
            {
                throw new InvalidDataException("NumeroConta is a required property for ContaBancariaPortadorUpdate and cannot be null");
            }
            else
            {
                this.NumeroConta = NumeroConta;
            }
            // to ensure "FlagAtivo" is required (not null)
            if (FlagAtivo == null)
            {
                throw new InvalidDataException("FlagAtivo is a required property for ContaBancariaPortadorUpdate and cannot be null");
            }
            else
            {
                this.FlagAtivo = FlagAtivo;
            }
            // to ensure "FlagContaOrigemDoc" is required (not null)
            if (FlagContaOrigemDoc == null)
            {
                throw new InvalidDataException("FlagContaOrigemDoc is a required property for ContaBancariaPortadorUpdate and cannot be null");
            }
            else
            {
                this.FlagContaOrigemDoc = FlagContaOrigemDoc;
            }
            // to ensure "FlagContaPoupanca" is required (not null)
            if (FlagContaPoupanca == null)
            {
                throw new InvalidDataException("FlagContaPoupanca is a required property for ContaBancariaPortadorUpdate and cannot be null");
            }
            else
            {
                this.FlagContaPoupanca = FlagContaPoupanca;
            }
            // to ensure "Favorecido" is required (not null)
            if (Favorecido == null)
            {
                throw new InvalidDataException("Favorecido is a required property for ContaBancariaPortadorUpdate and cannot be null");
            }
            else
            {
                this.Favorecido = Favorecido;
            }
            // to ensure "NumeroReceiraFederal" is required (not null)
            if (NumeroReceiraFederal == null)
            {
                throw new InvalidDataException("NumeroReceiraFederal is a required property for ContaBancariaPortadorUpdate and cannot be null");
            }
            else
            {
                this.NumeroReceiraFederal = NumeroReceiraFederal;
            }
            this.NomeAgencia = NomeAgencia;
            this.DigitoAgencia = DigitoAgencia;
            this.DigitoConta = DigitoConta;
            this.Titularidade = Titularidade;
            
        }
        
    
        /// <summary>
        /// Descri\u00E7\u00E3o da ag\u00EAncia
        /// </summary>
        /// <value>Descri\u00E7\u00E3o da ag\u00EAncia</value>
        [DataMember(Name="nomeAgencia", EmitDefaultValue=false)]
        public string NomeAgencia { get; set; }
    
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
        /// Sinaliza se conta banc\u00E1ria est\u00E1 ativa ou n\u00E3o (1: Ativa, 0: Inativa)
        /// </summary>
        /// <value>Sinaliza se conta banc\u00E1ria est\u00E1 ativa ou n\u00E3o (1: Ativa, 0: Inativa)</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public int? FlagAtivo { get; set; }
    
        /// <summary>
        /// Sinaliza se origem \u00E9 DOC (1: DOC, 0: TED)
        /// </summary>
        /// <value>Sinaliza se origem \u00E9 DOC (1: DOC, 0: TED)</value>
        [DataMember(Name="flagContaOrigemDoc", EmitDefaultValue=false)]
        public int? FlagContaOrigemDoc { get; set; }
    
        /// <summary>
        /// Sinaliza se conta banc\u00E1ria \u00E9 poupan\u00E7a (1: Poupan\u00E7a, 0: Conta corrente)
        /// </summary>
        /// <value>Sinaliza se conta banc\u00E1ria \u00E9 poupan\u00E7a (1: Poupan\u00E7a, 0: Conta corrente)</value>
        [DataMember(Name="flagContaPoupanca", EmitDefaultValue=false)]
        public int? FlagContaPoupanca { get; set; }
    
        /// <summary>
        /// Nome do favorecido
        /// </summary>
        /// <value>Nome do favorecido</value>
        [DataMember(Name="favorecido", EmitDefaultValue=false)]
        public string Favorecido { get; set; }
    
        /// <summary>
        /// Documento do favorecido
        /// </summary>
        /// <value>Documento do favorecido</value>
        [DataMember(Name="numeroReceiraFederal", EmitDefaultValue=false)]
        public string NumeroReceiraFederal { get; set; }
    
        /// <summary>
        /// Titularidade da conta (1:Portador \u00E9 o titular, 0: Portador n\u00E3o \u00E9 o t\u00EDtular
        /// </summary>
        /// <value>Titularidade da conta (1:Portador \u00E9 o titular, 0: Portador n\u00E3o \u00E9 o t\u00EDtular</value>
        [DataMember(Name="titularidade", EmitDefaultValue=false)]
        public int? Titularidade { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContaBancariaPortadorUpdate {\n");
            sb.Append("  NomeAgencia: ").Append(NomeAgencia).Append("\n");
            sb.Append("  Banco: ").Append(Banco).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  DigitoAgencia: ").Append(DigitoAgencia).Append("\n");
            sb.Append("  NumeroConta: ").Append(NumeroConta).Append("\n");
            sb.Append("  DigitoConta: ").Append(DigitoConta).Append("\n");
            sb.Append("  FlagAtivo: ").Append(FlagAtivo).Append("\n");
            sb.Append("  FlagContaOrigemDoc: ").Append(FlagContaOrigemDoc).Append("\n");
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
            return this.Equals(obj as ContaBancariaPortadorUpdate);
        }

        /// <summary>
        /// Returns true if ContaBancariaPortadorUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of ContaBancariaPortadorUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContaBancariaPortadorUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
