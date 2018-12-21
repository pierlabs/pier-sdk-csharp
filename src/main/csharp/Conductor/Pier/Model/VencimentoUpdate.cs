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
    /// Representation Object Update for Expirations
    /// </summary>
    [DataContract]
    public partial class VencimentoUpdate :  IEquatable<VencimentoUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VencimentoUpdate" /> class.
        /// Initializes a new instance of the <see cref="VencimentoUpdate" />class.
        /// </summary>
        /// <param name="DataPrevistaCorte">expected expiring date.</param>

        public VencimentoUpdate(string DataPrevistaCorte = null)
        {
            this.DataPrevistaCorte = DataPrevistaCorte;
            
        }
        
    
        /// <summary>
        /// expected expiring date
        /// </summary>
        /// <value>expected expiring date</value>
        [DataMember(Name="dataPrevistaCorte", EmitDefaultValue=false)]
        public string DataPrevistaCorte { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VencimentoUpdate {\n");
            sb.Append("  DataPrevistaCorte: ").Append(DataPrevistaCorte).Append("\n");
            
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
            return this.Equals(obj as VencimentoUpdate);
        }

        /// <summary>
        /// Returns true if VencimentoUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of VencimentoUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VencimentoUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataPrevistaCorte == other.DataPrevistaCorte ||
                    this.DataPrevistaCorte != null &&
                    this.DataPrevistaCorte.Equals(other.DataPrevistaCorte)
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
                
                if (this.DataPrevistaCorte != null)
                    hash = hash * 59 + this.DataPrevistaCorte.GetHashCode();
                
                return hash;
            }
        }

    }
}
