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
    /// Representa\u00E7\u00E3o da requisi\u00E7\u00E3o do recurso de consultar conta
    /// </summary>
    [DataContract]
    public partial class TransacaoPayQueryRequest :  IEquatable<TransacaoPayQueryRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransacaoPayQueryRequest" /> class.
        /// Initializes a new instance of the <see cref="TransacaoPayQueryRequest" />class.
        /// </summary>
        /// <param name="NumeroCartao">Numero do cartao (criptografado).</param>
        /// <param name="IdCartao">Id do cart\u00E3o.</param>
        /// <param name="Origem">Origem.</param>
        /// <param name="Sort">Tipo de ordena\u00E7\u00E3o dos registros..</param>

        public TransacaoPayQueryRequest(string NumeroCartao = null, long? IdCartao = null, string Origem = null, List<string> Sort = null)
        {
            this.NumeroCartao = NumeroCartao;
            this.IdCartao = IdCartao;
            this.Origem = Origem;
            this.Sort = Sort;
            
        }
        
    
        /// <summary>
        /// Numero do cartao (criptografado)
        /// </summary>
        /// <value>Numero do cartao (criptografado)</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// Id do cart\u00E3o
        /// </summary>
        /// <value>Id do cart\u00E3o</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Origem
        /// </summary>
        /// <value>Origem</value>
        [DataMember(Name="origem", EmitDefaultValue=false)]
        public string Origem { get; set; }
    
        /// <summary>
        /// Tipo de ordena\u00E7\u00E3o dos registros.
        /// </summary>
        /// <value>Tipo de ordena\u00E7\u00E3o dos registros.</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public List<string> Sort { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransacaoPayQueryRequest {\n");
            sb.Append("  NumeroCartao: ").Append(NumeroCartao).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  Origem: ").Append(Origem).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            
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
            return this.Equals(obj as TransacaoPayQueryRequest);
        }

        /// <summary>
        /// Returns true if TransacaoPayQueryRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of TransacaoPayQueryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransacaoPayQueryRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NumeroCartao == other.NumeroCartao ||
                    this.NumeroCartao != null &&
                    this.NumeroCartao.Equals(other.NumeroCartao)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.Origem == other.Origem ||
                    this.Origem != null &&
                    this.Origem.Equals(other.Origem)
                ) && 
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.SequenceEqual(other.Sort)
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
                
                if (this.NumeroCartao != null)
                    hash = hash * 59 + this.NumeroCartao.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.Origem != null)
                    hash = hash * 59 + this.Origem.GetHashCode();
                
                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();
                
                return hash;
            }
        }

    }
}
