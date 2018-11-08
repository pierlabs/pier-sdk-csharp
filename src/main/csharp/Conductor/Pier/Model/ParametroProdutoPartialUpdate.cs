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
    /// {{{parametro_produto_partial_update_description}}}
    /// </summary>
    [DataContract]
    public partial class ParametroProdutoPartialUpdate :  IEquatable<ParametroProdutoPartialUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParametroProdutoPartialUpdate" /> class.
        /// Initializes a new instance of the <see cref="ParametroProdutoPartialUpdate" />class.
        /// </summary>
        /// <param name="DataValidade">{{{parametro_produto_dto_data_validade_value}}}.</param>
        /// <param name="Descricao">{{{parametro_produto_dto_descricao_value}}}.</param>
        /// <param name="ValorParametro">{{{parametro_produto_dto_valor_parametro_value}}}.</param>

        public ParametroProdutoPartialUpdate(string DataValidade = null, string Descricao = null, string ValorParametro = null)
        {
            this.DataValidade = DataValidade;
            this.Descricao = Descricao;
            this.ValorParametro = ValorParametro;
            
        }
        
    
        /// <summary>
        /// {{{parametro_produto_dto_data_validade_value}}}
        /// </summary>
        /// <value>{{{parametro_produto_dto_data_validade_value}}}</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
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
        public string ValorParametro { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParametroProdutoPartialUpdate {\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  ValorParametro: ").Append(ValorParametro).Append("\n");
            
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
            return this.Equals(obj as ParametroProdutoPartialUpdate);
        }

        /// <summary>
        /// Returns true if ParametroProdutoPartialUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of ParametroProdutoPartialUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParametroProdutoPartialUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataValidade == other.DataValidade ||
                    this.DataValidade != null &&
                    this.DataValidade.Equals(other.DataValidade)
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
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.ValorParametro != null)
                    hash = hash * 59 + this.ValorParametro.GetHashCode();
                
                return hash;
            }
        }

    }
}
