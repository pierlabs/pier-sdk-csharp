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
    /// {{{tipo_operacao_persist_description}}}
    /// </summary>
    [DataContract]
    public partial class TipoOperacaoParcialUpdate :  IEquatable<TipoOperacaoParcialUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoOperacaoParcialUpdate" /> class.
        /// Initializes a new instance of the <see cref="TipoOperacaoParcialUpdate" />class.
        /// </summary>
        /// <param name="FlagManterTaxaJurosNoRotativo">{{{tipo_operacao_persist_flag_manter_taxa_juros_no_rotativo_value}}}.</param>

        public TipoOperacaoParcialUpdate(bool? FlagManterTaxaJurosNoRotativo = null)
        {
            this.FlagManterTaxaJurosNoRotativo = FlagManterTaxaJurosNoRotativo;
            
        }
        
    
        /// <summary>
        /// {{{tipo_operacao_persist_flag_manter_taxa_juros_no_rotativo_value}}}
        /// </summary>
        /// <value>{{{tipo_operacao_persist_flag_manter_taxa_juros_no_rotativo_value}}}</value>
        [DataMember(Name="flagManterTaxaJurosNoRotativo", EmitDefaultValue=false)]
        public bool? FlagManterTaxaJurosNoRotativo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoOperacaoParcialUpdate {\n");
            sb.Append("  FlagManterTaxaJurosNoRotativo: ").Append(FlagManterTaxaJurosNoRotativo).Append("\n");
            
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
            return this.Equals(obj as TipoOperacaoParcialUpdate);
        }

        /// <summary>
        /// Returns true if TipoOperacaoParcialUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoOperacaoParcialUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoOperacaoParcialUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FlagManterTaxaJurosNoRotativo == other.FlagManterTaxaJurosNoRotativo ||
                    this.FlagManterTaxaJurosNoRotativo != null &&
                    this.FlagManterTaxaJurosNoRotativo.Equals(other.FlagManterTaxaJurosNoRotativo)
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
                
                if (this.FlagManterTaxaJurosNoRotativo != null)
                    hash = hash * 59 + this.FlagManterTaxaJurosNoRotativo.GetHashCode();
                
                return hash;
            }
        }

    }
}
