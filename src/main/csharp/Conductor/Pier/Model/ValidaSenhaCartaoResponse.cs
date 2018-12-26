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
    /// Objeto de resposta para a valida\u00E7\u00E3o de senha do cart\u00E3o
    /// </summary>
    [DataContract]
    public partial class ValidaSenhaCartaoResponse :  IEquatable<ValidaSenhaCartaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidaSenhaCartaoResponse" /> class.
        /// Initializes a new instance of the <see cref="ValidaSenhaCartaoResponse" />class.
        /// </summary>
        /// <param name="Mensagem">Mensagem.</param>
        /// <param name="IdStatusCartao">Descri\u00E7\u00E3o do status do cart\u00E3o.</param>
        /// <param name="StatusCartao">Descri\u00E7\u00E3o do status do cart\u00E3o.</param>
        /// <param name="QuantidadeTentativas">Quantidade tentativas.</param>
        /// <param name="QuantidadeMaximaTentativas">Quantidade m\u00E1xima tentativas permitidas.</param>

        public ValidaSenhaCartaoResponse(string Mensagem = null, long? IdStatusCartao = null, string StatusCartao = null, int? QuantidadeTentativas = null, int? QuantidadeMaximaTentativas = null)
        {
            this.Mensagem = Mensagem;
            this.IdStatusCartao = IdStatusCartao;
            this.StatusCartao = StatusCartao;
            this.QuantidadeTentativas = QuantidadeTentativas;
            this.QuantidadeMaximaTentativas = QuantidadeMaximaTentativas;
            
        }
        
    
        /// <summary>
        /// Mensagem
        /// </summary>
        /// <value>Mensagem</value>
        [DataMember(Name="mensagem", EmitDefaultValue=false)]
        public string Mensagem { get; set; }
    
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
        /// Quantidade tentativas
        /// </summary>
        /// <value>Quantidade tentativas</value>
        [DataMember(Name="quantidadeTentativas", EmitDefaultValue=false)]
        public int? QuantidadeTentativas { get; set; }
    
        /// <summary>
        /// Quantidade m\u00E1xima tentativas permitidas
        /// </summary>
        /// <value>Quantidade m\u00E1xima tentativas permitidas</value>
        [DataMember(Name="quantidadeMaximaTentativas", EmitDefaultValue=false)]
        public int? QuantidadeMaximaTentativas { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidaSenhaCartaoResponse {\n");
            sb.Append("  Mensagem: ").Append(Mensagem).Append("\n");
            sb.Append("  IdStatusCartao: ").Append(IdStatusCartao).Append("\n");
            sb.Append("  StatusCartao: ").Append(StatusCartao).Append("\n");
            sb.Append("  QuantidadeTentativas: ").Append(QuantidadeTentativas).Append("\n");
            sb.Append("  QuantidadeMaximaTentativas: ").Append(QuantidadeMaximaTentativas).Append("\n");
            
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
            return this.Equals(obj as ValidaSenhaCartaoResponse);
        }

        /// <summary>
        /// Returns true if ValidaSenhaCartaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidaSenhaCartaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidaSenhaCartaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Mensagem == other.Mensagem ||
                    this.Mensagem != null &&
                    this.Mensagem.Equals(other.Mensagem)
                ) && 
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
                    this.QuantidadeTentativas == other.QuantidadeTentativas ||
                    this.QuantidadeTentativas != null &&
                    this.QuantidadeTentativas.Equals(other.QuantidadeTentativas)
                ) && 
                (
                    this.QuantidadeMaximaTentativas == other.QuantidadeMaximaTentativas ||
                    this.QuantidadeMaximaTentativas != null &&
                    this.QuantidadeMaximaTentativas.Equals(other.QuantidadeMaximaTentativas)
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
                
                if (this.Mensagem != null)
                    hash = hash * 59 + this.Mensagem.GetHashCode();
                
                if (this.IdStatusCartao != null)
                    hash = hash * 59 + this.IdStatusCartao.GetHashCode();
                
                if (this.StatusCartao != null)
                    hash = hash * 59 + this.StatusCartao.GetHashCode();
                
                if (this.QuantidadeTentativas != null)
                    hash = hash * 59 + this.QuantidadeTentativas.GetHashCode();
                
                if (this.QuantidadeMaximaTentativas != null)
                    hash = hash * 59 + this.QuantidadeMaximaTentativas.GetHashCode();
                
                return hash;
            }
        }

    }
}
