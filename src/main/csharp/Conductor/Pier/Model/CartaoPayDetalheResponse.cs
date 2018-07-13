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
    /// {{{cartao_pay_detalhe_response_description}}}
    /// </summary>
    [DataContract]
    public partial class CartaoPayDetalheResponse :  IEquatable<CartaoPayDetalheResponse>
    { 
    
        /// <summary>
        /// {{{cartao_pay_base_response_status_value}}}
        /// </summary>
        /// <value>{{{cartao_pay_base_response_status_value}}}</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "ATIVO")]
            Ativo,
            
            [EnumMember(Value = "INATIVO")]
            Inativo,
            
            [EnumMember(Value = "BLOQUEADO")]
            Bloqueado
        }

    
        /// <summary>
        /// {{{cartao_pay_base_response_status_value}}}
        /// </summary>
        /// <value>{{{cartao_pay_base_response_status_value}}}</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoPayDetalheResponse" /> class.
        /// Initializes a new instance of the <see cref="CartaoPayDetalheResponse" />class.
        /// </summary>
        /// <param name="Id">{{{cartao_pay_base_response_id_value}}}.</param>
        /// <param name="NumeroCartao">{{{cartao_pay_base_response_numero_cartao_value}}}.</param>
        /// <param name="DataValidadeCartao">{{{cartao_pay_base_response_data_validade_cartao_value}}}.</param>
        /// <param name="NomeImpresso">{{{cartao_pay_base_response_nome_impresso_value}}}.</param>
        /// <param name="IdEntidade">{{{cartao_pay_base_response_id_entidade_value}}}.</param>
        /// <param name="NomeEntidade">{{{cartao_pay_base_response_nome_entidade_value}}}.</param>
        /// <param name="Status">{{{cartao_pay_base_response_status_value}}}.</param>
        /// <param name="Cvv">{{{cartao_pay_detalhe_response_cvv_value}}}.</param>
        /// <param name="DataValidadeChaveCriptograma">{{{cartao_pay_detalhe_response_data_validade_chave_criptograma_value}}}.</param>

        public CartaoPayDetalheResponse(long? Id = null, string NumeroCartao = null, string DataValidadeCartao = null, string NomeImpresso = null, long? IdEntidade = null, string NomeEntidade = null, StatusEnum? Status = null, string Cvv = null, string DataValidadeChaveCriptograma = null)
        {
            this.Id = Id;
            this.NumeroCartao = NumeroCartao;
            this.DataValidadeCartao = DataValidadeCartao;
            this.NomeImpresso = NomeImpresso;
            this.IdEntidade = IdEntidade;
            this.NomeEntidade = NomeEntidade;
            this.Status = Status;
            this.Cvv = Cvv;
            this.DataValidadeChaveCriptograma = DataValidadeChaveCriptograma;
            
        }
        
    
        /// <summary>
        /// {{{cartao_pay_base_response_id_value}}}
        /// </summary>
        /// <value>{{{cartao_pay_base_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{cartao_pay_base_response_numero_cartao_value}}}
        /// </summary>
        /// <value>{{{cartao_pay_base_response_numero_cartao_value}}}</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// {{{cartao_pay_base_response_data_validade_cartao_value}}}
        /// </summary>
        /// <value>{{{cartao_pay_base_response_data_validade_cartao_value}}}</value>
        [DataMember(Name="dataValidadeCartao", EmitDefaultValue=false)]
        public string DataValidadeCartao { get; set; }
    
        /// <summary>
        /// {{{cartao_pay_base_response_nome_impresso_value}}}
        /// </summary>
        /// <value>{{{cartao_pay_base_response_nome_impresso_value}}}</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// {{{cartao_pay_base_response_id_entidade_value}}}
        /// </summary>
        /// <value>{{{cartao_pay_base_response_id_entidade_value}}}</value>
        [DataMember(Name="idEntidade", EmitDefaultValue=false)]
        public long? IdEntidade { get; set; }
    
        /// <summary>
        /// {{{cartao_pay_base_response_nome_entidade_value}}}
        /// </summary>
        /// <value>{{{cartao_pay_base_response_nome_entidade_value}}}</value>
        [DataMember(Name="nomeEntidade", EmitDefaultValue=false)]
        public string NomeEntidade { get; set; }
    
        /// <summary>
        /// {{{cartao_pay_detalhe_response_cvv_value}}}
        /// </summary>
        /// <value>{{{cartao_pay_detalhe_response_cvv_value}}}</value>
        [DataMember(Name="cvv", EmitDefaultValue=false)]
        public string Cvv { get; set; }
    
        /// <summary>
        /// {{{cartao_pay_detalhe_response_data_validade_chave_criptograma_value}}}
        /// </summary>
        /// <value>{{{cartao_pay_detalhe_response_data_validade_chave_criptograma_value}}}</value>
        [DataMember(Name="dataValidadeChaveCriptograma", EmitDefaultValue=false)]
        public string DataValidadeChaveCriptograma { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoPayDetalheResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NumeroCartao: ").Append(NumeroCartao).Append("\n");
            sb.Append("  DataValidadeCartao: ").Append(DataValidadeCartao).Append("\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  IdEntidade: ").Append(IdEntidade).Append("\n");
            sb.Append("  NomeEntidade: ").Append(NomeEntidade).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Cvv: ").Append(Cvv).Append("\n");
            sb.Append("  DataValidadeChaveCriptograma: ").Append(DataValidadeChaveCriptograma).Append("\n");
            
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
            return this.Equals(obj as CartaoPayDetalheResponse);
        }

        /// <summary>
        /// Returns true if CartaoPayDetalheResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoPayDetalheResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoPayDetalheResponse other)
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
                    this.NumeroCartao == other.NumeroCartao ||
                    this.NumeroCartao != null &&
                    this.NumeroCartao.Equals(other.NumeroCartao)
                ) && 
                (
                    this.DataValidadeCartao == other.DataValidadeCartao ||
                    this.DataValidadeCartao != null &&
                    this.DataValidadeCartao.Equals(other.DataValidadeCartao)
                ) && 
                (
                    this.NomeImpresso == other.NomeImpresso ||
                    this.NomeImpresso != null &&
                    this.NomeImpresso.Equals(other.NomeImpresso)
                ) && 
                (
                    this.IdEntidade == other.IdEntidade ||
                    this.IdEntidade != null &&
                    this.IdEntidade.Equals(other.IdEntidade)
                ) && 
                (
                    this.NomeEntidade == other.NomeEntidade ||
                    this.NomeEntidade != null &&
                    this.NomeEntidade.Equals(other.NomeEntidade)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Cvv == other.Cvv ||
                    this.Cvv != null &&
                    this.Cvv.Equals(other.Cvv)
                ) && 
                (
                    this.DataValidadeChaveCriptograma == other.DataValidadeChaveCriptograma ||
                    this.DataValidadeChaveCriptograma != null &&
                    this.DataValidadeChaveCriptograma.Equals(other.DataValidadeChaveCriptograma)
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
                
                if (this.NumeroCartao != null)
                    hash = hash * 59 + this.NumeroCartao.GetHashCode();
                
                if (this.DataValidadeCartao != null)
                    hash = hash * 59 + this.DataValidadeCartao.GetHashCode();
                
                if (this.NomeImpresso != null)
                    hash = hash * 59 + this.NomeImpresso.GetHashCode();
                
                if (this.IdEntidade != null)
                    hash = hash * 59 + this.IdEntidade.GetHashCode();
                
                if (this.NomeEntidade != null)
                    hash = hash * 59 + this.NomeEntidade.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Cvv != null)
                    hash = hash * 59 + this.Cvv.GetHashCode();
                
                if (this.DataValidadeChaveCriptograma != null)
                    hash = hash * 59 + this.DataValidadeChaveCriptograma.GetHashCode();
                
                return hash;
            }
        }

    }
}
