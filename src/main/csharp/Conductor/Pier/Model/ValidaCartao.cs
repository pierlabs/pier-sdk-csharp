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
    /// Objeto de resposta para a valida\u00C3\u00A7\u00C3\u00A3o de cart\u00C3\u00A3o
    /// </summary>
    [DataContract]
    public partial class ValidaCartao :  IEquatable<ValidaCartao>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidaCartao" /> class.
        /// Initializes a new instance of the <see cref="ValidaCartao" />class.
        /// </summary>
        /// <param name="CriptogramaResposta">Criptograma de resposta.</param>
        /// <param name="StatusCartao">Descri\u00C3\u00A7\u00C3\u00A3o do status do cart\u00C3\u00A3o.</param>
        /// <param name="StatusConta">Descri\u00C3\u00A7\u00C3\u00A3o do status da conta.</param>

        public ValidaCartao(string CriptogramaResposta = null, string StatusCartao = null, string StatusConta = null)
        {
            this.CriptogramaResposta = CriptogramaResposta;
            this.StatusCartao = StatusCartao;
            this.StatusConta = StatusConta;
            
        }
        
    
        /// <summary>
        /// Criptograma de resposta
        /// </summary>
        /// <value>Criptograma de resposta</value>
        [DataMember(Name="criptogramaResposta", EmitDefaultValue=false)]
        public string CriptogramaResposta { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o do status do cart\u00C3\u00A3o
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o do status do cart\u00C3\u00A3o</value>
        [DataMember(Name="statusCartao", EmitDefaultValue=false)]
        public string StatusCartao { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o do status da conta
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o do status da conta</value>
        [DataMember(Name="statusConta", EmitDefaultValue=false)]
        public string StatusConta { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidaCartao {\n");
            sb.Append("  CriptogramaResposta: ").Append(CriptogramaResposta).Append("\n");
            sb.Append("  StatusCartao: ").Append(StatusCartao).Append("\n");
            sb.Append("  StatusConta: ").Append(StatusConta).Append("\n");
            
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
            return this.Equals(obj as ValidaCartao);
        }

        /// <summary>
        /// Returns true if ValidaCartao instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidaCartao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidaCartao other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CriptogramaResposta == other.CriptogramaResposta ||
                    this.CriptogramaResposta != null &&
                    this.CriptogramaResposta.Equals(other.CriptogramaResposta)
                ) && 
                (
                    this.StatusCartao == other.StatusCartao ||
                    this.StatusCartao != null &&
                    this.StatusCartao.Equals(other.StatusCartao)
                ) && 
                (
                    this.StatusConta == other.StatusConta ||
                    this.StatusConta != null &&
                    this.StatusConta.Equals(other.StatusConta)
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
                
                if (this.CriptogramaResposta != null)
                    hash = hash * 59 + this.CriptogramaResposta.GetHashCode();
                
                if (this.StatusCartao != null)
                    hash = hash * 59 + this.StatusCartao.GetHashCode();
                
                if (this.StatusConta != null)
                    hash = hash * 59 + this.StatusConta.GetHashCode();
                
                return hash;
            }
        }

    }
}
