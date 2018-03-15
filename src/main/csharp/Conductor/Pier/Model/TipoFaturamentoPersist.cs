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
    /// TipoFaturamentoPersist
    /// </summary>
    [DataContract]
    public partial class TipoFaturamentoPersist :  IEquatable<TipoFaturamentoPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoFaturamentoPersist" /> class.
        /// Initializes a new instance of the <see cref="TipoFaturamentoPersist" />class.
        /// </summary>
        /// <param name="Descricao">Desci\u00E7\u00E3o do tipo de faturamento. (required).</param>
        /// <param name="FlagApenasDemonstrativo">Flag que representa que o faturamento ser\u00E1 apenas demonstrativo. (required).</param>
        /// <param name="IdConvenio">C\u00F3digo de identifica\u00E7\u00E3o do convenio relacionado ao tipo de faturamento..</param>

        public TipoFaturamentoPersist(string Descricao = null, bool? FlagApenasDemonstrativo = null, long? IdConvenio = null)
        {
            // to ensure "Descricao" is required (not null)
            if (Descricao == null)
            {
                throw new InvalidDataException("Descricao is a required property for TipoFaturamentoPersist and cannot be null");
            }
            else
            {
                this.Descricao = Descricao;
            }
            // to ensure "FlagApenasDemonstrativo" is required (not null)
            if (FlagApenasDemonstrativo == null)
            {
                throw new InvalidDataException("FlagApenasDemonstrativo is a required property for TipoFaturamentoPersist and cannot be null");
            }
            else
            {
                this.FlagApenasDemonstrativo = FlagApenasDemonstrativo;
            }
            this.IdConvenio = IdConvenio;
            
        }
        
    
        /// <summary>
        /// Desci\u00E7\u00E3o do tipo de faturamento.
        /// </summary>
        /// <value>Desci\u00E7\u00E3o do tipo de faturamento.</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Flag que representa que o faturamento ser\u00E1 apenas demonstrativo.
        /// </summary>
        /// <value>Flag que representa que o faturamento ser\u00E1 apenas demonstrativo.</value>
        [DataMember(Name="flagApenasDemonstrativo", EmitDefaultValue=false)]
        public bool? FlagApenasDemonstrativo { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do convenio relacionado ao tipo de faturamento.
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do convenio relacionado ao tipo de faturamento.</value>
        [DataMember(Name="idConvenio", EmitDefaultValue=false)]
        public long? IdConvenio { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoFaturamentoPersist {\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  FlagApenasDemonstrativo: ").Append(FlagApenasDemonstrativo).Append("\n");
            sb.Append("  IdConvenio: ").Append(IdConvenio).Append("\n");
            
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
            return this.Equals(obj as TipoFaturamentoPersist);
        }

        /// <summary>
        /// Returns true if TipoFaturamentoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoFaturamentoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoFaturamentoPersist other)
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
                    this.FlagApenasDemonstrativo == other.FlagApenasDemonstrativo ||
                    this.FlagApenasDemonstrativo != null &&
                    this.FlagApenasDemonstrativo.Equals(other.FlagApenasDemonstrativo)
                ) && 
                (
                    this.IdConvenio == other.IdConvenio ||
                    this.IdConvenio != null &&
                    this.IdConvenio.Equals(other.IdConvenio)
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
                
                if (this.FlagApenasDemonstrativo != null)
                    hash = hash * 59 + this.FlagApenasDemonstrativo.GetHashCode();
                
                if (this.IdConvenio != null)
                    hash = hash * 59 + this.IdConvenio.GetHashCode();
                
                return hash;
            }
        }

    }
}
