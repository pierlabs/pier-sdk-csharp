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
    /// Objeto para atualiza\u00E7\u00E3o de cart\u00F5es
    /// </summary>
    [DataContract]
    public partial class CartaoUpdate :  IEquatable<CartaoUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoUpdate" /> class.
        /// Initializes a new instance of the <see cref="CartaoUpdate" />class.
        /// </summary>
        /// <param name="IdConta">Identificador da conta.</param>
        /// <param name="IdPessoa">Identificador da pessoa.</param>
        /// <param name="SequencialCartao">Sequencial do cart\u00E3o atual.</param>
        /// <param name="Conta">Conta do cart\u00E3o.</param>
        /// <param name="IdStatusCartao">Identificador do status do cart\u00E3o.</param>
        /// <param name="IdEstagioCartao">Identificador do estagio de embossing do cart\u00E3o.</param>
        /// <param name="QtdSenhasIncorretas">Contador de senhas incorretas.</param>
        /// <param name="ArquivoImpressao">Nome do arquivo de embossing que o cart\u00E3o foi impresso.</param>

        public CartaoUpdate(long? IdConta = null, long? IdPessoa = null, int? SequencialCartao = null, long? Conta = null, long? IdStatusCartao = null, long? IdEstagioCartao = null, int? QtdSenhasIncorretas = null, string ArquivoImpressao = null)
        {
            this.IdConta = IdConta;
            this.IdPessoa = IdPessoa;
            this.SequencialCartao = SequencialCartao;
            this.Conta = Conta;
            this.IdStatusCartao = IdStatusCartao;
            this.IdEstagioCartao = IdEstagioCartao;
            this.QtdSenhasIncorretas = QtdSenhasIncorretas;
            this.ArquivoImpressao = ArquivoImpressao;
            
        }
        
    
        /// <summary>
        /// Identificador da conta
        /// </summary>
        /// <value>Identificador da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identificador da pessoa
        /// </summary>
        /// <value>Identificador da pessoa</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Sequencial do cart\u00E3o atual
        /// </summary>
        /// <value>Sequencial do cart\u00E3o atual</value>
        [DataMember(Name="sequencialCartao", EmitDefaultValue=false)]
        public int? SequencialCartao { get; set; }
    
        /// <summary>
        /// Conta do cart\u00E3o
        /// </summary>
        /// <value>Conta do cart\u00E3o</value>
        [DataMember(Name="conta", EmitDefaultValue=false)]
        public long? Conta { get; set; }
    
        /// <summary>
        /// Identificador do status do cart\u00E3o
        /// </summary>
        /// <value>Identificador do status do cart\u00E3o</value>
        [DataMember(Name="idStatusCartao", EmitDefaultValue=false)]
        public long? IdStatusCartao { get; set; }
    
        /// <summary>
        /// Identificador do estagio de embossing do cart\u00E3o
        /// </summary>
        /// <value>Identificador do estagio de embossing do cart\u00E3o</value>
        [DataMember(Name="idEstagioCartao", EmitDefaultValue=false)]
        public long? IdEstagioCartao { get; set; }
    
        /// <summary>
        /// Contador de senhas incorretas
        /// </summary>
        /// <value>Contador de senhas incorretas</value>
        [DataMember(Name="qtdSenhasIncorretas", EmitDefaultValue=false)]
        public int? QtdSenhasIncorretas { get; set; }
    
        /// <summary>
        /// Nome do arquivo de embossing que o cart\u00E3o foi impresso
        /// </summary>
        /// <value>Nome do arquivo de embossing que o cart\u00E3o foi impresso</value>
        [DataMember(Name="arquivoImpressao", EmitDefaultValue=false)]
        public string ArquivoImpressao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoUpdate {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  SequencialCartao: ").Append(SequencialCartao).Append("\n");
            sb.Append("  Conta: ").Append(Conta).Append("\n");
            sb.Append("  IdStatusCartao: ").Append(IdStatusCartao).Append("\n");
            sb.Append("  IdEstagioCartao: ").Append(IdEstagioCartao).Append("\n");
            sb.Append("  QtdSenhasIncorretas: ").Append(QtdSenhasIncorretas).Append("\n");
            sb.Append("  ArquivoImpressao: ").Append(ArquivoImpressao).Append("\n");
            
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
            return this.Equals(obj as CartaoUpdate);
        }

        /// <summary>
        /// Returns true if CartaoUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.SequencialCartao == other.SequencialCartao ||
                    this.SequencialCartao != null &&
                    this.SequencialCartao.Equals(other.SequencialCartao)
                ) && 
                (
                    this.Conta == other.Conta ||
                    this.Conta != null &&
                    this.Conta.Equals(other.Conta)
                ) && 
                (
                    this.IdStatusCartao == other.IdStatusCartao ||
                    this.IdStatusCartao != null &&
                    this.IdStatusCartao.Equals(other.IdStatusCartao)
                ) && 
                (
                    this.IdEstagioCartao == other.IdEstagioCartao ||
                    this.IdEstagioCartao != null &&
                    this.IdEstagioCartao.Equals(other.IdEstagioCartao)
                ) && 
                (
                    this.QtdSenhasIncorretas == other.QtdSenhasIncorretas ||
                    this.QtdSenhasIncorretas != null &&
                    this.QtdSenhasIncorretas.Equals(other.QtdSenhasIncorretas)
                ) && 
                (
                    this.ArquivoImpressao == other.ArquivoImpressao ||
                    this.ArquivoImpressao != null &&
                    this.ArquivoImpressao.Equals(other.ArquivoImpressao)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.SequencialCartao != null)
                    hash = hash * 59 + this.SequencialCartao.GetHashCode();
                
                if (this.Conta != null)
                    hash = hash * 59 + this.Conta.GetHashCode();
                
                if (this.IdStatusCartao != null)
                    hash = hash * 59 + this.IdStatusCartao.GetHashCode();
                
                if (this.IdEstagioCartao != null)
                    hash = hash * 59 + this.IdEstagioCartao.GetHashCode();
                
                if (this.QtdSenhasIncorretas != null)
                    hash = hash * 59 + this.QtdSenhasIncorretas.GetHashCode();
                
                if (this.ArquivoImpressao != null)
                    hash = hash * 59 + this.ArquivoImpressao.GetHashCode();
                
                return hash;
            }
        }

    }
}
