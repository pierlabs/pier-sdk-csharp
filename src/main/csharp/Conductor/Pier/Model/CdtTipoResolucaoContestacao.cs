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
    public partial class CdtTipoResolucaoContestacao :  IEquatable<CdtTipoResolucaoContestacao>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CdtTipoResolucaoContestacao" /> class.
        /// Initializes a new instance of the <see cref="CdtTipoResolucaoContestacao" />class.
        /// </summary>
        /// <param name="Descricao">Descricao.</param>
        /// <param name="IdTipoResolucaoContestacao">IdTipoResolucaoContestacao.</param>

        public CdtTipoResolucaoContestacao(string Descricao = null, long? IdTipoResolucaoContestacao = null)
        {
            this.Descricao = Descricao;
            this.IdTipoResolucaoContestacao = IdTipoResolucaoContestacao;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Descricao
        /// </summary>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Gets or Sets IdTipoResolucaoContestacao
        /// </summary>
        [DataMember(Name="idTipoResolucaoContestacao", EmitDefaultValue=false)]
        public long? IdTipoResolucaoContestacao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CdtTipoResolucaoContestacao {\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  IdTipoResolucaoContestacao: ").Append(IdTipoResolucaoContestacao).Append("\n");
            
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
            return this.Equals(obj as CdtTipoResolucaoContestacao);
        }

        /// <summary>
        /// Returns true if CdtTipoResolucaoContestacao instances are equal
        /// </summary>
        /// <param name="other">Instance of CdtTipoResolucaoContestacao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CdtTipoResolucaoContestacao other)
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
                    this.IdTipoResolucaoContestacao == other.IdTipoResolucaoContestacao ||
                    this.IdTipoResolucaoContestacao != null &&
                    this.IdTipoResolucaoContestacao.Equals(other.IdTipoResolucaoContestacao)
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
                
                if (this.IdTipoResolucaoContestacao != null)
                    hash = hash * 59 + this.IdTipoResolucaoContestacao.GetHashCode();
                
                return hash;
            }
        }

    }
}
