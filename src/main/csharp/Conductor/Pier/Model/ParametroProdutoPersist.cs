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
    /// Par\u00E2metros utilizados no cadastro de par\u00E2metros de produto
    /// </summary>
    [DataContract]
    public partial class ParametroProdutoPersist :  IEquatable<ParametroProdutoPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParametroProdutoPersist" /> class.
        /// Initializes a new instance of the <see cref="ParametroProdutoPersist" />class.
        /// </summary>
        /// <param name="IdProduto">Identificador do produto (required).</param>
        /// <param name="DataValidade">Data de validade do par\u00E2metro de produto (required).</param>
        /// <param name="Codigo">C\u00F3digo do par\u00E2metro do produto (required).</param>
        /// <param name="Descricao">Descri\u00E7\u00E3o do par\u00E2metro de produto (required).</param>
        /// <param name="Tipo">Tipo do par\u00E2metro de produto (required).</param>
        /// <param name="ValorParametro">Valor do par\u00E2metro do produto.</param>

        public ParametroProdutoPersist(long? IdProduto = null, string DataValidade = null, string Codigo = null, string Descricao = null, string Tipo = null, string ValorParametro = null)
        {
            // to ensure "IdProduto" is required (not null)
            if (IdProduto == null)
            {
                throw new InvalidDataException("IdProduto is a required property for ParametroProdutoPersist and cannot be null");
            }
            else
            {
                this.IdProduto = IdProduto;
            }
            // to ensure "DataValidade" is required (not null)
            if (DataValidade == null)
            {
                throw new InvalidDataException("DataValidade is a required property for ParametroProdutoPersist and cannot be null");
            }
            else
            {
                this.DataValidade = DataValidade;
            }
            // to ensure "Codigo" is required (not null)
            if (Codigo == null)
            {
                throw new InvalidDataException("Codigo is a required property for ParametroProdutoPersist and cannot be null");
            }
            else
            {
                this.Codigo = Codigo;
            }
            // to ensure "Descricao" is required (not null)
            if (Descricao == null)
            {
                throw new InvalidDataException("Descricao is a required property for ParametroProdutoPersist and cannot be null");
            }
            else
            {
                this.Descricao = Descricao;
            }
            // to ensure "Tipo" is required (not null)
            if (Tipo == null)
            {
                throw new InvalidDataException("Tipo is a required property for ParametroProdutoPersist and cannot be null");
            }
            else
            {
                this.Tipo = Tipo;
            }
            this.ValorParametro = ValorParametro;
            
        }
        
    
        /// <summary>
        /// Identificador do produto
        /// </summary>
        /// <value>Identificador do produto</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Data de validade do par\u00E2metro de produto
        /// </summary>
        /// <value>Data de validade do par\u00E2metro de produto</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// C\u00F3digo do par\u00E2metro do produto
        /// </summary>
        /// <value>C\u00F3digo do par\u00E2metro do produto</value>
        [DataMember(Name="codigo", EmitDefaultValue=false)]
        public string Codigo { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do par\u00E2metro de produto
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do par\u00E2metro de produto</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Tipo do par\u00E2metro de produto
        /// </summary>
        /// <value>Tipo do par\u00E2metro de produto</value>
        [DataMember(Name="tipo", EmitDefaultValue=false)]
        public string Tipo { get; set; }
    
        /// <summary>
        /// Valor do par\u00E2metro do produto
        /// </summary>
        /// <value>Valor do par\u00E2metro do produto</value>
        [DataMember(Name="valorParametro", EmitDefaultValue=false)]
        public string ValorParametro { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParametroProdutoPersist {\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            sb.Append("  Codigo: ").Append(Codigo).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  Tipo: ").Append(Tipo).Append("\n");
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
            return this.Equals(obj as ParametroProdutoPersist);
        }

        /// <summary>
        /// Returns true if ParametroProdutoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of ParametroProdutoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParametroProdutoPersist other)
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
                    this.DataValidade == other.DataValidade ||
                    this.DataValidade != null &&
                    this.DataValidade.Equals(other.DataValidade)
                ) && 
                (
                    this.Codigo == other.Codigo ||
                    this.Codigo != null &&
                    this.Codigo.Equals(other.Codigo)
                ) && 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.Tipo == other.Tipo ||
                    this.Tipo != null &&
                    this.Tipo.Equals(other.Tipo)
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
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                if (this.Codigo != null)
                    hash = hash * 59 + this.Codigo.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.Tipo != null)
                    hash = hash * 59 + this.Tipo.GetHashCode();
                
                if (this.ValorParametro != null)
                    hash = hash * 59 + this.ValorParametro.GetHashCode();
                
                return hash;
            }
        }

    }
}
