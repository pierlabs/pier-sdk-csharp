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
    /// 
    /// </summary>
    [DataContract]
    public partial class ContaBancariaPortadorResponse :  IEquatable<ContaBancariaPortadorResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaBancariaPortadorResponse" /> class.
        /// Initializes a new instance of the <see cref="ContaBancariaPortadorResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo identificador da conta banc\u00C3\u00A1ria.</param>
        /// <param name="IdConta">C\u00C3\u00B3digo identificador da conta cart\u00C3\u00A3o.</param>
        /// <param name="NomeAgencia">Descri\u00C3\u00A7\u00C3\u00A3o da ag\u00C3\u00AAncia.</param>
        /// <param name="Banco">C\u00C3\u00B3digo do banco.</param>
        /// <param name="NumeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia.</param>
        /// <param name="DigitoAgencia">D\u00C3\u00ADgito da ag\u00C3\u00AAncia.</param>
        /// <param name="NumeroConta">N\u00C3\u00BAmero da conta.</param>
        /// <param name="DigitoConta">D\u00C3\u00ADgito da conta.</param>
        /// <param name="FlagAtivo">Sinaliza se conta banc\u00C3\u00A1ria est\u00C3\u00A1 ativa ou n\u00C3\u00A3o (1: Ativa, 0: Inativa).</param>
        /// <param name="FlagContaOrigemDoc">Sinaliza se origem \u00C3\u00A9 DOC (1: DOC, 0: TED).</param>
        /// <param name="IdPessoaFisica">C\u00C3\u00B3digo da pessoa.</param>
        /// <param name="FlagContaPoupanca">Sinaliza se conta banc\u00C3\u00A1ria \u00C3\u00A9 poupan\u00C3\u00A7a (1: Poupan\u00C3\u00A7a, 0: Conta corrente).</param>
        /// <param name="Favorecido">Nome do favorecido.</param>
        /// <param name="NumeroReceiraFederal">Documento do favorecido.</param>
        /// <param name="Titularidade">Titularidade da conta (1:Portador \u00C3\u00A9 o titular, 0: Portador n\u00C3\u00A3o \u00C3\u00A9 o t\u00C3\u00ADtular.</param>

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
        /// C\u00C3\u00B3digo identificador da conta banc\u00C3\u00A1ria
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador da conta banc\u00C3\u00A1ria</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador da conta cart\u00C3\u00A3o
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador da conta cart\u00C3\u00A3o</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o da ag\u00C3\u00AAncia
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o da ag\u00C3\u00AAncia</value>
        [DataMember(Name="nomeAgencia", EmitDefaultValue=false)]
        public string NomeAgencia { get; set; }
    
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
        /// Sinaliza se conta banc\u00C3\u00A1ria est\u00C3\u00A1 ativa ou n\u00C3\u00A3o (1: Ativa, 0: Inativa)
        /// </summary>
        /// <value>Sinaliza se conta banc\u00C3\u00A1ria est\u00C3\u00A1 ativa ou n\u00C3\u00A3o (1: Ativa, 0: Inativa)</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public int? FlagAtivo { get; set; }
    
        /// <summary>
        /// Sinaliza se origem \u00C3\u00A9 DOC (1: DOC, 0: TED)
        /// </summary>
        /// <value>Sinaliza se origem \u00C3\u00A9 DOC (1: DOC, 0: TED)</value>
        [DataMember(Name="flagContaOrigemDoc", EmitDefaultValue=false)]
        public int? FlagContaOrigemDoc { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo da pessoa
        /// </summary>
        /// <value>C\u00C3\u00B3digo da pessoa</value>
        [DataMember(Name="idPessoaFisica", EmitDefaultValue=false)]
        public long? IdPessoaFisica { get; set; }
    
        /// <summary>
        /// Sinaliza se conta banc\u00C3\u00A1ria \u00C3\u00A9 poupan\u00C3\u00A7a (1: Poupan\u00C3\u00A7a, 0: Conta corrente)
        /// </summary>
        /// <value>Sinaliza se conta banc\u00C3\u00A1ria \u00C3\u00A9 poupan\u00C3\u00A7a (1: Poupan\u00C3\u00A7a, 0: Conta corrente)</value>
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
        /// Titularidade da conta (1:Portador \u00C3\u00A9 o titular, 0: Portador n\u00C3\u00A3o \u00C3\u00A9 o t\u00C3\u00ADtular
        /// </summary>
        /// <value>Titularidade da conta (1:Portador \u00C3\u00A9 o titular, 0: Portador n\u00C3\u00A3o \u00C3\u00A9 o t\u00C3\u00ADtular</value>
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
