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
    /// {{{inscricao_apn_resposta_descricao}}}
    /// </summary>
    [DataContract]
    public partial class InscricaoAPNResponse :  IEquatable<InscricaoAPNResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InscricaoAPNResponse" /> class.
        /// Initializes a new instance of the <see cref="InscricaoAPNResponse" />class.
        /// </summary>
        /// <param name="AplicacaoMobile">{{{inscricao_apn_resposta_aplicacao_mobile_descricao}}}.</param>
        /// <param name="Ativo">{{{inscricao_apn_resposta_ativo_descricao}}}.</param>
        /// <param name="Cartao">{{{inscricao_apn_resposta_cartao_descricao}}}.</param>
        /// <param name="DataCriacao">{{{inscricao_apn_resposta_data_criacao_descricao}}}.</param>
        /// <param name="DataDesativacao">{{{inscricao_apn_resposta_data_desativacao_descricao}}}.</param>
        /// <param name="DeviceToken">{{{inscricao_apn_resposta_device_token_descricao}}}.</param>
        /// <param name="Id">{{{inscricao_apn_resposta_id_descricao}}}.</param>

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
        /// {{{inscricao_apn_resposta_aplicacao_mobile_descricao}}}
        /// </summary>
        /// <value>{{{inscricao_apn_resposta_aplicacao_mobile_descricao}}}</value>
        [DataMember(Name="aplicacaoMobile", EmitDefaultValue=false)]
        public AplicacaoMobileEmissorResponse AplicacaoMobile { get; set; }
    
        /// <summary>
        /// {{{inscricao_apn_resposta_ativo_descricao}}}
        /// </summary>
        /// <value>{{{inscricao_apn_resposta_ativo_descricao}}}</value>
        [DataMember(Name="ativo", EmitDefaultValue=false)]
        public bool? Ativo { get; set; }
    
        /// <summary>
        /// {{{inscricao_apn_resposta_cartao_descricao}}}
        /// </summary>
        /// <value>{{{inscricao_apn_resposta_cartao_descricao}}}</value>
        [DataMember(Name="cartao", EmitDefaultValue=false)]
        public CartaoEmissorResponse Cartao { get; set; }
    
        /// <summary>
        /// {{{inscricao_apn_resposta_data_criacao_descricao}}}
        /// </summary>
        /// <value>{{{inscricao_apn_resposta_data_criacao_descricao}}}</value>
        [DataMember(Name="dataCriacao", EmitDefaultValue=false)]
        public string DataCriacao { get; set; }
    
        /// <summary>
        /// {{{inscricao_apn_resposta_data_desativacao_descricao}}}
        /// </summary>
        /// <value>{{{inscricao_apn_resposta_data_desativacao_descricao}}}</value>
        [DataMember(Name="dataDesativacao", EmitDefaultValue=false)]
        public string DataDesativacao { get; set; }
    
        /// <summary>
        /// {{{inscricao_apn_resposta_device_token_descricao}}}
        /// </summary>
        /// <value>{{{inscricao_apn_resposta_device_token_descricao}}}</value>
        [DataMember(Name="deviceToken", EmitDefaultValue=false)]
        public string DeviceToken { get; set; }
    
        /// <summary>
        /// {{{inscricao_apn_resposta_id_descricao}}}
        /// </summary>
        /// <value>{{{inscricao_apn_resposta_id_descricao}}}</value>
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
