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
    /// Objeto de Resposta Par\u00C3\u00A2metro Produto
    /// </summary>
    [DataContract]
    public partial class ParametroProdutoResponse :  IEquatable<ParametroProdutoResponse>
    { 
    
        /// <summary>
        /// Tipo da Transa\u00C3\u00A7\u00C3\u00A3o (ON_US ou OFF_US).
        /// </summary>
        /// <value>Tipo da Transa\u00C3\u00A7\u00C3\u00A3o (ON_US ou OFF_US).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoTransacaoEnum {
            
            [EnumMember(Value = "ON_US")]
            OnUs,
            
            [EnumMember(Value = "OFF_US")]
            OffUs
        }

    
        /// <summary>
        /// Tipo da Transa\u00C3\u00A7\u00C3\u00A3o (ON_US ou OFF_US).
        /// </summary>
        /// <value>Tipo da Transa\u00C3\u00A7\u00C3\u00A3o (ON_US ou OFF_US).</value>
        [DataMember(Name="tipoTransacao", EmitDefaultValue=false)]
        public TipoTransacaoEnum? TipoTransacao { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParametroProdutoResponse" /> class.
        /// Initializes a new instance of the <see cref="ParametroProdutoResponse" />class.
        /// </summary>
        /// <param name="IdProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (required).</param>
        /// <param name="TipoTransacao">Tipo da Transa\u00C3\u00A7\u00C3\u00A3o (ON_US ou OFF_US). (required).</param>
        /// <param name="Descricao">Descri\u00C3\u00A7\u00C3\u00A3o do Tipo da Transa\u00C3\u00A7\u00C3\u00A3o. (required).</param>
        /// <param name="ValorParametro">Valor do Par\u00C3\u00A2metro. (required).</param>
        /// <param name="DataValidade">Data de Validade do Par\u00C3\u00A2metro do Produto. (required).</param>

        public ParametroProdutoResponse(long? IdProduto = null, TipoTransacaoEnum? TipoTransacao = null, string Descricao = null, double? ValorParametro = null, string DataValidade = null)
        {
            // to ensure "IdProduto" is required (not null)
            if (IdProduto == null)
            {
                throw new InvalidDataException("IdProduto is a required property for ParametroProdutoResponse and cannot be null");
            }
            else
            {
                this.IdProduto = IdProduto;
            }
            // to ensure "TipoTransacao" is required (not null)
            if (TipoTransacao == null)
            {
                throw new InvalidDataException("TipoTransacao is a required property for ParametroProdutoResponse and cannot be null");
            }
            else
            {
                this.TipoTransacao = TipoTransacao;
            }
            // to ensure "Descricao" is required (not null)
            if (Descricao == null)
            {
                throw new InvalidDataException("Descricao is a required property for ParametroProdutoResponse and cannot be null");
            }
            else
            {
                this.Descricao = Descricao;
            }
            // to ensure "ValorParametro" is required (not null)
            if (ValorParametro == null)
            {
                throw new InvalidDataException("ValorParametro is a required property for ParametroProdutoResponse and cannot be null");
            }
            else
            {
                this.ValorParametro = ValorParametro;
            }
            // to ensure "DataValidade" is required (not null)
            if (DataValidade == null)
            {
                throw new InvalidDataException("DataValidade is a required property for ParametroProdutoResponse and cannot be null");
            }
            else
            {
                this.DataValidade = DataValidade;
            }
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id).</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o do Tipo da Transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o do Tipo da Transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Valor do Par\u00C3\u00A2metro.
        /// </summary>
        /// <value>Valor do Par\u00C3\u00A2metro.</value>
        [DataMember(Name="valorParametro", EmitDefaultValue=false)]
        public double? ValorParametro { get; set; }
    
        /// <summary>
        /// Data de Validade do Par\u00C3\u00A2metro do Produto.
        /// </summary>
        /// <value>Data de Validade do Par\u00C3\u00A2metro do Produto.</value>
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
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  TipoTransacao: ").Append(TipoTransacao).Append("\n");
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
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.TipoTransacao == other.TipoTransacao ||
                    this.TipoTransacao != null &&
                    this.TipoTransacao.Equals(other.TipoTransacao)
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
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.TipoTransacao != null)
                    hash = hash * 59 + this.TipoTransacao.GetHashCode();
                
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
