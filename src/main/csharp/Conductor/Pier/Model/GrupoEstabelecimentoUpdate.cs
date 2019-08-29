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
    public partial class GrupoEstabelecimentoUpdate :  IEquatable<GrupoEstabelecimentoUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GrupoEstabelecimentoUpdate" /> class.
        /// Initializes a new instance of the <see cref="GrupoEstabelecimentoUpdate" />class.
        /// </summary>
        /// <param name="Descricao">Descricao (required).</param>
        /// <param name="IdLayout">IdLayout (required).</param>

        public GrupoEstabelecimentoUpdate(string Descricao = null, long? IdLayout = null)
        {
            // to ensure "Descricao" is required (not null)
            if (Descricao == null)
            {
                throw new InvalidDataException("Descricao is a required property for GrupoEstabelecimentoUpdate and cannot be null");
            }
            else
            {
                this.Descricao = Descricao;
            }
            // to ensure "IdLayout" is required (not null)
            if (IdLayout == null)
            {
                throw new InvalidDataException("IdLayout is a required property for GrupoEstabelecimentoUpdate and cannot be null");
            }
            else
            {
                this.IdLayout = IdLayout;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Descricao
        /// </summary>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Gets or Sets IdLayout
        /// </summary>
        [DataMember(Name="idLayout", EmitDefaultValue=false)]
        public long? IdLayout { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GrupoEstabelecimentoUpdate {\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  IdLayout: ").Append(IdLayout).Append("\n");
            
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
            return this.Equals(obj as GrupoEstabelecimentoUpdate);
        }

        /// <summary>
        /// Returns true if GrupoEstabelecimentoUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of GrupoEstabelecimentoUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GrupoEstabelecimentoUpdate other)
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
                    this.IdLayout == other.IdLayout ||
                    this.IdLayout != null &&
                    this.IdLayout.Equals(other.IdLayout)
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
                
                if (this.IdLayout != null)
                    hash = hash * 59 + this.IdLayout.GetHashCode();
                
                return hash;
            }
        }

    }
}
