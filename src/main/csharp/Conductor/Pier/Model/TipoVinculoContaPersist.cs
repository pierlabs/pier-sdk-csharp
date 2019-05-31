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
    /// Representa a requisi\u00E7\u00E3o do recurso de cadastro de um tipo de v\u00EDnculo
    /// </summary>
    [DataContract]
    public partial class TipoVinculoContaPersist :  IEquatable<TipoVinculoContaPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoVinculoContaPersist" /> class.
        /// Initializes a new instance of the <see cref="TipoVinculoContaPersist" />class.
        /// </summary>
        /// <param name="Descricao">Descri\u00E7\u00E3o do tipo de v\u00EDnculo.</param>

        public TipoVinculoContaPersist(string Descricao = null)
        {
            this.Descricao = Descricao;
            
        }
        
    
        /// <summary>
        /// Descri\u00E7\u00E3o do tipo de v\u00EDnculo
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do tipo de v\u00EDnculo</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoVinculoContaPersist {\n");
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
            return this.Equals(obj as TipoVinculoContaPersist);
        }

        /// <summary>
        /// Returns true if TipoVinculoContaPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoVinculoContaPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoVinculoContaPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                return hash;
            }
        }

    }
}
