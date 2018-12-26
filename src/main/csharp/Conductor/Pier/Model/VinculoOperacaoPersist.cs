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
    /// Objeto VinculoOperacao
    /// </summary>
    [DataContract]
    public partial class VinculoOperacaoPersist :  IEquatable<VinculoOperacaoPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VinculoOperacaoPersist" /> class.
        /// Initializes a new instance of the <see cref="VinculoOperacaoPersist" />class.
        /// </summary>
        /// <param name="IdProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id).</param>
        /// <param name="IdOperacao">C\u00F3digo de Identifica\u00E7\u00E3o da Opera\u00E7\u00E3o (id).</param>
        /// <param name="CodigoMCC">C\u00F3digo MCC.</param>

        public VinculoOperacaoPersist(long? IdProduto = null, long? IdOperacao = null, int? CodigoMCC = null)
        {
            this.IdProduto = IdProduto;
            this.IdOperacao = IdOperacao;
            this.CodigoMCC = CodigoMCC;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id)</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Opera\u00E7\u00E3o (id)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Opera\u00E7\u00E3o (id)</value>
        [DataMember(Name="idOperacao", EmitDefaultValue=false)]
        public long? IdOperacao { get; set; }
    
        /// <summary>
        /// C\u00F3digo MCC
        /// </summary>
        /// <value>C\u00F3digo MCC</value>
        [DataMember(Name="codigoMCC", EmitDefaultValue=false)]
        public int? CodigoMCC { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VinculoOperacaoPersist {\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdOperacao: ").Append(IdOperacao).Append("\n");
            sb.Append("  CodigoMCC: ").Append(CodigoMCC).Append("\n");
            
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
            return this.Equals(obj as VinculoOperacaoPersist);
        }

        /// <summary>
        /// Returns true if VinculoOperacaoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of VinculoOperacaoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VinculoOperacaoPersist other)
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
                    this.IdOperacao == other.IdOperacao ||
                    this.IdOperacao != null &&
                    this.IdOperacao.Equals(other.IdOperacao)
                ) && 
                (
                    this.CodigoMCC == other.CodigoMCC ||
                    this.CodigoMCC != null &&
                    this.CodigoMCC.Equals(other.CodigoMCC)
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
                
                if (this.IdOperacao != null)
                    hash = hash * 59 + this.IdOperacao.GetHashCode();
                
                if (this.CodigoMCC != null)
                    hash = hash * 59 + this.CodigoMCC.GetHashCode();
                
                return hash;
            }
        }

    }
}
