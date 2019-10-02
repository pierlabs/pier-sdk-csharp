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
    /// 
    /// </summary>
    [DataContract]
    public partial class FantasiaBasicaPersist :  IEquatable<FantasiaBasicaPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FantasiaBasicaPersist" /> class.
        /// Initializes a new instance of the <see cref="FantasiaBasicaPersist" />class.
        /// </summary>
        /// <param name="Descricao">Descricao.</param>
        /// <param name="DescricaoArquivo">DescricaoArquivo.</param>
        /// <param name="Nome">Nome.</param>
        /// <param name="QuantidadeMaxProposta">QuantidadeMaxProposta.</param>

        public FantasiaBasicaPersist(string Descricao = null, string DescricaoArquivo = null, string Nome = null, int? QuantidadeMaxProposta = null)
        {
            this.Descricao = Descricao;
            this.DescricaoArquivo = DescricaoArquivo;
            this.Nome = Nome;
            this.QuantidadeMaxProposta = QuantidadeMaxProposta;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Descricao
        /// </summary>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Gets or Sets DescricaoArquivo
        /// </summary>
        [DataMember(Name="descricaoArquivo", EmitDefaultValue=false)]
        public string DescricaoArquivo { get; set; }
    
        /// <summary>
        /// Gets or Sets Nome
        /// </summary>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Gets or Sets QuantidadeMaxProposta
        /// </summary>
        [DataMember(Name="quantidadeMaxProposta", EmitDefaultValue=false)]
        public int? QuantidadeMaxProposta { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FantasiaBasicaPersist {\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  DescricaoArquivo: ").Append(DescricaoArquivo).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  QuantidadeMaxProposta: ").Append(QuantidadeMaxProposta).Append("\n");
            
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
            return this.Equals(obj as FantasiaBasicaPersist);
        }

        /// <summary>
        /// Returns true if FantasiaBasicaPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of FantasiaBasicaPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FantasiaBasicaPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.DescricaoArquivo == other.DescricaoArquivo ||
                    this.DescricaoArquivo != null &&
                    this.DescricaoArquivo.Equals(other.DescricaoArquivo)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.QuantidadeMaxProposta == other.QuantidadeMaxProposta ||
                    this.QuantidadeMaxProposta != null &&
                    this.QuantidadeMaxProposta.Equals(other.QuantidadeMaxProposta)
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
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.DescricaoArquivo != null)
                    hash = hash * 59 + this.DescricaoArquivo.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.QuantidadeMaxProposta != null)
                    hash = hash * 59 + this.QuantidadeMaxProposta.GetHashCode();
                
                return hash;
            }
        }

    }
}
