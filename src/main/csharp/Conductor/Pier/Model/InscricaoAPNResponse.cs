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
    /// Representa a resposta de uma inscricao APN
    /// </summary>
    [DataContract]
    public partial class InscricaoAPNResponse :  IEquatable<InscricaoAPNResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InscricaoAPNResponse" /> class.
        /// Initializes a new instance of the <see cref="InscricaoAPNResponse" />class.
        /// </summary>
        /// <param name="AplicacaoMobile">Representa a aplica\u00E7\u00E3o mobile da inscri\u00E7\u00E3o.</param>
        /// <param name="Ativo">Indica se a inscri\u00E7\u00E3o est\u00E1 ativa.</param>
        /// <param name="Cartao">Representa o cart\u00E3o associado \u00E0 inscri\u00E7\u00E3o.</param>
        /// <param name="DataCriacao">Data da cria\u00E7\u00E3o da inscri\u00E7\u00E3o.</param>
        /// <param name="DataDesativacao">Data da desativa\u00E7\u00E3o da inscri\u00E7\u00E3o.</param>
        /// <param name="DeviceToken">Token do dispositivo.</param>
        /// <param name="Id">Id da inscri\u00E7\u00E3o.</param>

        public InscricaoAPNResponse(AplicacaoMobileEmissorResponse AplicacaoMobile = null, bool? Ativo = null, CartaoEmissorResponse Cartao = null, string DataCriacao = null, string DataDesativacao = null, string DeviceToken = null, long? Id = null)
        {
            this.AplicacaoMobile = AplicacaoMobile;
            this.Ativo = Ativo;
            this.Cartao = Cartao;
            this.DataCriacao = DataCriacao;
            this.DataDesativacao = DataDesativacao;
            this.DeviceToken = DeviceToken;
            this.Id = Id;
            
        }
        
    
        /// <summary>
        /// Representa a aplica\u00E7\u00E3o mobile da inscri\u00E7\u00E3o
        /// </summary>
        /// <value>Representa a aplica\u00E7\u00E3o mobile da inscri\u00E7\u00E3o</value>
        [DataMember(Name="aplicacaoMobile", EmitDefaultValue=false)]
        public AplicacaoMobileEmissorResponse AplicacaoMobile { get; set; }
    
        /// <summary>
        /// Indica se a inscri\u00E7\u00E3o est\u00E1 ativa
        /// </summary>
        /// <value>Indica se a inscri\u00E7\u00E3o est\u00E1 ativa</value>
        [DataMember(Name="ativo", EmitDefaultValue=false)]
        public bool? Ativo { get; set; }
    
        /// <summary>
        /// Representa o cart\u00E3o associado \u00E0 inscri\u00E7\u00E3o
        /// </summary>
        /// <value>Representa o cart\u00E3o associado \u00E0 inscri\u00E7\u00E3o</value>
        [DataMember(Name="cartao", EmitDefaultValue=false)]
        public CartaoEmissorResponse Cartao { get; set; }
    
        /// <summary>
        /// Data da cria\u00E7\u00E3o da inscri\u00E7\u00E3o
        /// </summary>
        /// <value>Data da cria\u00E7\u00E3o da inscri\u00E7\u00E3o</value>
        [DataMember(Name="dataCriacao", EmitDefaultValue=false)]
        public string DataCriacao { get; set; }
    
        /// <summary>
        /// Data da desativa\u00E7\u00E3o da inscri\u00E7\u00E3o
        /// </summary>
        /// <value>Data da desativa\u00E7\u00E3o da inscri\u00E7\u00E3o</value>
        [DataMember(Name="dataDesativacao", EmitDefaultValue=false)]
        public string DataDesativacao { get; set; }
    
        /// <summary>
        /// Token do dispositivo
        /// </summary>
        /// <value>Token do dispositivo</value>
        [DataMember(Name="deviceToken", EmitDefaultValue=false)]
        public string DeviceToken { get; set; }
    
        /// <summary>
        /// Id da inscri\u00E7\u00E3o
        /// </summary>
        /// <value>Id da inscri\u00E7\u00E3o</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InscricaoAPNResponse {\n");
            sb.Append("  AplicacaoMobile: ").Append(AplicacaoMobile).Append("\n");
            sb.Append("  Ativo: ").Append(Ativo).Append("\n");
            sb.Append("  Cartao: ").Append(Cartao).Append("\n");
            sb.Append("  DataCriacao: ").Append(DataCriacao).Append("\n");
            sb.Append("  DataDesativacao: ").Append(DataDesativacao).Append("\n");
            sb.Append("  DeviceToken: ").Append(DeviceToken).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            
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
            return this.Equals(obj as InscricaoAPNResponse);
        }

        /// <summary>
        /// Returns true if InscricaoAPNResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of InscricaoAPNResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InscricaoAPNResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AplicacaoMobile == other.AplicacaoMobile ||
                    this.AplicacaoMobile != null &&
                    this.AplicacaoMobile.Equals(other.AplicacaoMobile)
                ) && 
                (
                    this.Ativo == other.Ativo ||
                    this.Ativo != null &&
                    this.Ativo.Equals(other.Ativo)
                ) && 
                (
                    this.Cartao == other.Cartao ||
                    this.Cartao != null &&
                    this.Cartao.Equals(other.Cartao)
                ) && 
                (
                    this.DataCriacao == other.DataCriacao ||
                    this.DataCriacao != null &&
                    this.DataCriacao.Equals(other.DataCriacao)
                ) && 
                (
                    this.DataDesativacao == other.DataDesativacao ||
                    this.DataDesativacao != null &&
                    this.DataDesativacao.Equals(other.DataDesativacao)
                ) && 
                (
                    this.DeviceToken == other.DeviceToken ||
                    this.DeviceToken != null &&
                    this.DeviceToken.Equals(other.DeviceToken)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                
                if (this.AplicacaoMobile != null)
                    hash = hash * 59 + this.AplicacaoMobile.GetHashCode();
                
                if (this.Ativo != null)
                    hash = hash * 59 + this.Ativo.GetHashCode();
                
                if (this.Cartao != null)
                    hash = hash * 59 + this.Cartao.GetHashCode();
                
                if (this.DataCriacao != null)
                    hash = hash * 59 + this.DataCriacao.GetHashCode();
                
                if (this.DataDesativacao != null)
                    hash = hash * 59 + this.DataDesativacao.GetHashCode();
                
                if (this.DeviceToken != null)
                    hash = hash * 59 + this.DeviceToken.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                return hash;
            }
        }

    }
}
