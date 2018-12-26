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
    /// {{{parametro_produto_response_description}}}
    /// </summary>
    [DataContract]
    public partial class ParametroProdutoResponse :  IEquatable<ParametroProdutoResponse>
    { 
    
        /// <summary>
        /// {{{parametro_produto_dto_tipo_origem_transacao_value}}}
        /// </summary>
        /// <value>{{{parametro_produto_dto_tipo_origem_transacao_value}}}</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoOrigemTransacaoEnum {
            
            [EnumMember(Value = "ON_US")]
            OnUs,
            
            [EnumMember(Value = "OFF_US")]
            OffUs
        }

    
        /// <summary>
        /// {{{parametro_produto_dto_tipo_origem_transacao_value}}}
        /// </summary>
        /// <value>{{{parametro_produto_dto_tipo_origem_transacao_value}}}</value>
        [DataMember(Name="tipoOrigemTransacao", EmitDefaultValue=false)]
        public TipoOrigemTransacaoEnum? TipoOrigemTransacao { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParametroProdutoResponse" /> class.
        /// Initializes a new instance of the <see cref="ParametroProdutoResponse" />class.
        /// </summary>
        /// <param name="Id">{{{parametro_produto_dto_id_value}}}.</param>
        /// <param name="IdProduto">{{{parametro_produto_dto_id_produto_value}}}.</param>
        /// <param name="TipoOrigemTransacao">{{{parametro_produto_dto_tipo_origem_transacao_value}}}.</param>
        /// <param name="Descricao">{{{parametro_produto_dto_descricao_value}}}.</param>
        /// <param name="ValorParametro">{{{parametro_produto_dto_valor_parametro_value}}}.</param>
        /// <param name="DataValidade">{{{parametro_produto_dto_data_validade_value}}}.</param>

        public ParametroProdutoResponse(long? Id = null, long? IdProduto = null, TipoOrigemTransacaoEnum? TipoOrigemTransacao = null, string Descricao = null, double? ValorParametro = null, string DataValidade = null)
        {
            this.Id = Id;
            this.IdProduto = IdProduto;
            this.TipoOrigemTransacao = TipoOrigemTransacao;
            this.Descricao = Descricao;
            this.ValorParametro = ValorParametro;
            this.DataValidade = DataValidade;
            
        }
        
    
        /// <summary>
        /// {{{parametro_produto_dto_id_value}}}
        /// </summary>
        /// <value>{{{parametro_produto_dto_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{parametro_produto_dto_id_produto_value}}}
        /// </summary>
        /// <value>{{{parametro_produto_dto_id_produto_value}}}</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// {{{parametro_produto_dto_descricao_value}}}
        /// </summary>
        /// <value>{{{parametro_produto_dto_descricao_value}}}</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// {{{parametro_produto_dto_valor_parametro_value}}}
        /// </summary>
        /// <value>{{{parametro_produto_dto_valor_parametro_value}}}</value>
        [DataMember(Name="valorParametro", EmitDefaultValue=false)]
        public double? ValorParametro { get; set; }
    
        /// <summary>
        /// {{{parametro_produto_dto_data_validade_value}}}
        /// </summary>
        /// <value>{{{parametro_produto_dto_data_validade_value}}}</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParametroProdutoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  TipoOrigemTransacao: ").Append(TipoOrigemTransacao).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  ValorParametro: ").Append(ValorParametro).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            
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
            return this.Equals(obj as ParametroProdutoResponse);
        }

        /// <summary>
        /// Returns true if ParametroProdutoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ParametroProdutoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParametroProdutoResponse other)
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
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.TipoOrigemTransacao == other.TipoOrigemTransacao ||
                    this.TipoOrigemTransacao != null &&
                    this.TipoOrigemTransacao.Equals(other.TipoOrigemTransacao)
                ) && 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.ValorParametro == other.ValorParametro ||
                    this.ValorParametro != null &&
                    this.ValorParametro.Equals(other.ValorParametro)
                ) && 
                (
                    this.DataValidade == other.DataValidade ||
                    this.DataValidade != null &&
                    this.DataValidade.Equals(other.DataValidade)
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
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.TipoOrigemTransacao != null)
                    hash = hash * 59 + this.TipoOrigemTransacao.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.ValorParametro != null)
                    hash = hash * 59 + this.ValorParametro.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                return hash;
            }
        }

    }
}
