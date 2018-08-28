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
    /// {{{vincular_cartoes_response_description}}}
    /// </summary>
    [DataContract]
    public partial class VinculoCartoesResponse :  IEquatable<VinculoCartoesResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VinculoCartoesResponse" /> class.
        /// Initializes a new instance of the <see cref="VinculoCartoesResponse" />class.
        /// </summary>
        /// <param name="IdCartaoPrincipal">{{{vincular_cartoes_response_id_cartao_value}}}.</param>
        /// <param name="IdCartaoVinculado">{{{vincular_cartoes_response_id_cartao_vinculado_value}}}.</param>

        public VinculoCartoesResponse(long? IdCartaoPrincipal = null, long? IdCartaoVinculado = null)
        {
            this.IdCartaoPrincipal = IdCartaoPrincipal;
            this.IdCartaoVinculado = IdCartaoVinculado;
            
        }
        
    
        /// <summary>
        /// {{{vincular_cartoes_response_id_cartao_value}}}
        /// </summary>
        /// <value>{{{vincular_cartoes_response_id_cartao_value}}}</value>
        [DataMember(Name="idCartaoPrincipal", EmitDefaultValue=false)]
        public long? IdCartaoPrincipal { get; set; }
    
        /// <summary>
        /// {{{vincular_cartoes_response_id_cartao_vinculado_value}}}
        /// </summary>
        /// <value>{{{vincular_cartoes_response_id_cartao_vinculado_value}}}</value>
        [DataMember(Name="idCartaoVinculado", EmitDefaultValue=false)]
        public long? IdCartaoVinculado { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VinculoCartoesResponse {\n");
            sb.Append("  IdCartaoPrincipal: ").Append(IdCartaoPrincipal).Append("\n");
            sb.Append("  IdCartaoVinculado: ").Append(IdCartaoVinculado).Append("\n");
            
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
            return this.Equals(obj as VinculoCartoesResponse);
        }

        /// <summary>
        /// Returns true if VinculoCartoesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of VinculoCartoesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VinculoCartoesResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdCartaoPrincipal == other.IdCartaoPrincipal ||
                    this.IdCartaoPrincipal != null &&
                    this.IdCartaoPrincipal.Equals(other.IdCartaoPrincipal)
                ) && 
                (
                    this.IdCartaoVinculado == other.IdCartaoVinculado ||
                    this.IdCartaoVinculado != null &&
                    this.IdCartaoVinculado.Equals(other.IdCartaoVinculado)
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
                
                if (this.IdCartaoPrincipal != null)
                    hash = hash * 59 + this.IdCartaoPrincipal.GetHashCode();
                
                if (this.IdCartaoVinculado != null)
                    hash = hash * 59 + this.IdCartaoVinculado.GetHashCode();
                
                return hash;
            }
        }

    }
}
