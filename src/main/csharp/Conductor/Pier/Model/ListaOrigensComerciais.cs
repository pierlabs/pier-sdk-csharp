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
    /// Lista de Origens Comerciais
    /// </summary>
    [DataContract]
    public partial class ListaOrigensComerciais :  IEquatable<ListaOrigensComerciais>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ListaOrigensComerciais" /> class.
        /// Initializes a new instance of the <see cref="ListaOrigensComerciais" />class.
        /// </summary>
        /// <param name="OrigensComerciais">Lista de origens comerciais.</param>

        public ListaOrigensComerciais(List<OrigemComercial> OrigensComerciais = null)
        {
            this.OrigensComerciais = OrigensComerciais;
            
        }
        
    
        /// <summary>
        /// Lista de origens comerciais
        /// </summary>
        /// <value>Lista de origens comerciais</value>
        [DataMember(Name="origensComerciais", EmitDefaultValue=false)]
        public List<OrigemComercial> OrigensComerciais { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListaOrigensComerciais {\n");
            sb.Append("  OrigensComerciais: ").Append(OrigensComerciais).Append("\n");
            
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
            return this.Equals(obj as ListaOrigensComerciais);
        }

        /// <summary>
        /// Returns true if ListaOrigensComerciais instances are equal
        /// </summary>
        /// <param name="other">Instance of ListaOrigensComerciais to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListaOrigensComerciais other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OrigensComerciais == other.OrigensComerciais ||
                    this.OrigensComerciais != null &&
                    this.OrigensComerciais.SequenceEqual(other.OrigensComerciais)
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
                
                if (this.OrigensComerciais != null)
                    hash = hash * 59 + this.OrigensComerciais.GetHashCode();
                
                return hash;
            }
        }

    }
}
