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
    /// Representa\u00C3\u00A7\u00C3\u00A3o da resposta do recurso de consultar cart\u00C3\u00A3o
    /// </summary>
    [DataContract]
    public partial class TransacaoPayQueryResponse :  IEquatable<TransacaoPayQueryResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransacaoPayQueryResponse" /> class.
        /// Initializes a new instance of the <see cref="TransacaoPayQueryResponse" />class.
        /// </summary>
        /// <param name="Codigo">Resultado de consulta de conta.</param>
        /// <param name="Descricao">Mensagem descrevendo resposta..</param>

        public TransacaoPayQueryResponse(string Codigo = null, string Descricao = null)
        {
            this.Codigo = Codigo;
            this.Descricao = Descricao;
            
        }
        
    
        /// <summary>
        /// Resultado de consulta de conta
        /// </summary>
        /// <value>Resultado de consulta de conta</value>
        [DataMember(Name="codigo", EmitDefaultValue=false)]
        public string Codigo { get; set; }
    
        /// <summary>
        /// Mensagem descrevendo resposta.
        /// </summary>
        /// <value>Mensagem descrevendo resposta.</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransacaoPayQueryResponse {\n");
            sb.Append("  Codigo: ").Append(Codigo).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            
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
            return this.Equals(obj as TransacaoPayQueryResponse);
        }

        /// <summary>
        /// Returns true if TransacaoPayQueryResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TransacaoPayQueryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransacaoPayQueryResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Codigo == other.Codigo ||
                    this.Codigo != null &&
                    this.Codigo.Equals(other.Codigo)
                ) && 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
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
                
                if (this.Codigo != null)
                    hash = hash * 59 + this.Codigo.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                return hash;
            }
        }

    }
}