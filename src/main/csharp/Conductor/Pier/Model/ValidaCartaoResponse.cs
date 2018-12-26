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
    /// Objeto de resposta para a valida\u00E7\u00E3o de cart\u00E3o
    /// </summary>
    [DataContract]
    public partial class ValidaCartaoResponse :  IEquatable<ValidaCartaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidaCartaoResponse" /> class.
        /// Initializes a new instance of the <see cref="ValidaCartaoResponse" />class.
        /// </summary>
        /// <param name="IdStatusCartao">Descri\u00E7\u00E3o do status do cart\u00E3o.</param>
        /// <param name="StatusCartao">Descri\u00E7\u00E3o do status do cart\u00E3o.</param>
        /// <param name="IdStatusConta">Descri\u00E7\u00E3o do status da conta.</param>
        /// <param name="StatusConta">Descri\u00E7\u00E3o do status da conta.</param>
        /// <param name="IdConta">C\u00F3digo identificador da conta.</param>
        /// <param name="NumeroAgencia">N\u00FAmero da ag\u00EAncia.</param>
        /// <param name="NumeroContaCorrente">N\u00FAmero da conta corrente.</param>
        /// <param name="CriptogramaResposta">Criptograma de resposta.</param>

        public ValidaCartaoResponse(long? IdStatusCartao = null, string StatusCartao = null, long? IdStatusConta = null, string StatusConta = null, long? IdConta = null, int? NumeroAgencia = null, string NumeroContaCorrente = null, string CriptogramaResposta = null)
        {
            this.IdStatusCartao = IdStatusCartao;
            this.StatusCartao = StatusCartao;
            this.IdStatusConta = IdStatusConta;
            this.StatusConta = StatusConta;
            this.IdConta = IdConta;
            this.NumeroAgencia = NumeroAgencia;
            this.NumeroContaCorrente = NumeroContaCorrente;
            this.CriptogramaResposta = CriptogramaResposta;
            
        }
        
    
        /// <summary>
        /// Descri\u00E7\u00E3o do status do cart\u00E3o
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do status do cart\u00E3o</value>
        [DataMember(Name="idStatusCartao", EmitDefaultValue=false)]
        public long? IdStatusCartao { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do status do cart\u00E3o
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do status do cart\u00E3o</value>
        [DataMember(Name="statusCartao", EmitDefaultValue=false)]
        public string StatusCartao { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do status da conta
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do status da conta</value>
        [DataMember(Name="idStatusConta", EmitDefaultValue=false)]
        public long? IdStatusConta { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do status da conta
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do status da conta</value>
        [DataMember(Name="statusConta", EmitDefaultValue=false)]
        public string StatusConta { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da conta
        /// </summary>
        /// <value>C\u00F3digo identificador da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
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
        /// Criptograma de resposta
        /// </summary>
        /// <value>Criptograma de resposta</value>
        [DataMember(Name="criptogramaResposta", EmitDefaultValue=false)]
        public string CriptogramaResposta { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidaCartaoResponse {\n");
            sb.Append("  IdStatusCartao: ").Append(IdStatusCartao).Append("\n");
            sb.Append("  StatusCartao: ").Append(StatusCartao).Append("\n");
            sb.Append("  IdStatusConta: ").Append(IdStatusConta).Append("\n");
            sb.Append("  StatusConta: ").Append(StatusConta).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  NumeroContaCorrente: ").Append(NumeroContaCorrente).Append("\n");
            sb.Append("  CriptogramaResposta: ").Append(CriptogramaResposta).Append("\n");
            
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
            return this.Equals(obj as ValidaCartaoResponse);
        }

        /// <summary>
        /// Returns true if ValidaCartaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidaCartaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidaCartaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdStatusCartao == other.IdStatusCartao ||
                    this.IdStatusCartao != null &&
                    this.IdStatusCartao.Equals(other.IdStatusCartao)
                ) && 
                (
                    this.StatusCartao == other.StatusCartao ||
                    this.StatusCartao != null &&
                    this.StatusCartao.Equals(other.StatusCartao)
                ) && 
                (
                    this.IdStatusConta == other.IdStatusConta ||
                    this.IdStatusConta != null &&
                    this.IdStatusConta.Equals(other.IdStatusConta)
                ) && 
                (
                    this.StatusConta == other.StatusConta ||
                    this.StatusConta != null &&
                    this.StatusConta.Equals(other.StatusConta)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
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
                    this.CriptogramaResposta == other.CriptogramaResposta ||
                    this.CriptogramaResposta != null &&
                    this.CriptogramaResposta.Equals(other.CriptogramaResposta)
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
                
                if (this.IdStatusCartao != null)
                    hash = hash * 59 + this.IdStatusCartao.GetHashCode();
                
                if (this.StatusCartao != null)
                    hash = hash * 59 + this.StatusCartao.GetHashCode();
                
                if (this.IdStatusConta != null)
                    hash = hash * 59 + this.IdStatusConta.GetHashCode();
                
                if (this.StatusConta != null)
                    hash = hash * 59 + this.StatusConta.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.NumeroAgencia != null)
                    hash = hash * 59 + this.NumeroAgencia.GetHashCode();
                
                if (this.NumeroContaCorrente != null)
                    hash = hash * 59 + this.NumeroContaCorrente.GetHashCode();
                
                if (this.CriptogramaResposta != null)
                    hash = hash * 59 + this.CriptogramaResposta.GetHashCode();
                
                return hash;
            }
        }

    }
}
