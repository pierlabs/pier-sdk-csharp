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
    public partial class PageImplOfEstagioCartao :  IEquatable<PageImplOfEstagioCartao>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PageImplOfEstagioCartao" /> class.
        /// Initializes a new instance of the <see cref="PageImplOfEstagioCartao" />class.
        /// </summary>
        /// <param name="Last">Last.</param>
        /// <param name="TotalElements">TotalElements.</param>
        /// <param name="TotalPages">TotalPages.</param>

        public PageImplOfEstagioCartao(bool? Last = null, long? TotalElements = null, int? TotalPages = null)
        {
            this.Last = Last;
            this.TotalElements = TotalElements;
            this.TotalPages = TotalPages;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Last
        /// </summary>
        [DataMember(Name="last", EmitDefaultValue=false)]
        public bool? Last { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalElements
        /// </summary>
        [DataMember(Name="totalElements", EmitDefaultValue=false)]
        public long? TotalElements { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        [DataMember(Name="totalPages", EmitDefaultValue=false)]
        public int? TotalPages { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageImplOfEstagioCartao {\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
            sb.Append("  TotalElements: ").Append(TotalElements).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            
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
            return this.Equals(obj as PageImplOfEstagioCartao);
        }

        /// <summary>
        /// Returns true if PageImplOfEstagioCartao instances are equal
        /// </summary>
        /// <param name="other">Instance of PageImplOfEstagioCartao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageImplOfEstagioCartao other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Last == other.Last ||
                    this.Last != null &&
                    this.Last.Equals(other.Last)
                ) && 
                (
                    this.TotalElements == other.TotalElements ||
                    this.TotalElements != null &&
                    this.TotalElements.Equals(other.TotalElements)
                ) && 
                (
                    this.TotalPages == other.TotalPages ||
                    this.TotalPages != null &&
                    this.TotalPages.Equals(other.TotalPages)
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
                
                if (this.Last != null)
                    hash = hash * 59 + this.Last.GetHashCode();
                
                if (this.TotalElements != null)
                    hash = hash * 59 + this.TotalElements.GetHashCode();
                
                if (this.TotalPages != null)
                    hash = hash * 59 + this.TotalPages.GetHashCode();
                
                return hash;
            }
        }

    }
}
