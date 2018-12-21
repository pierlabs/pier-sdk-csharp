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
    /// Object DetailOpportunity
    /// </summary>
    [DataContract]
    public partial class DetailOpportunityUpdate :  IEquatable<DetailOpportunityUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailOpportunityUpdate" /> class.
        /// Initializes a new instance of the <see cref="DetailOpportunityUpdate" />class.
        /// </summary>
        /// <param name="Id">Identifier Code of the detail.</param>
        /// <param name="NomeCampo">Name of the content.</param>
        /// <param name="Conteudo">Content of the deatail.</param>

        public DetailOpportunityUpdate(long? Id = null, string NomeCampo = null, string Conteudo = null)
        {
            this.Id = Id;
            this.NomeCampo = NomeCampo;
            this.Conteudo = Conteudo;
            
        }
        
    
        /// <summary>
        /// Identifier Code of the detail
        /// </summary>
        /// <value>Identifier Code of the detail</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Name of the content
        /// </summary>
        /// <value>Name of the content</value>
        [DataMember(Name="nomeCampo", EmitDefaultValue=false)]
        public string NomeCampo { get; set; }
    
        /// <summary>
        /// Content of the deatail
        /// </summary>
        /// <value>Content of the deatail</value>
        [DataMember(Name="conteudo", EmitDefaultValue=false)]
        public string Conteudo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetailOpportunityUpdate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NomeCampo: ").Append(NomeCampo).Append("\n");
            sb.Append("  Conteudo: ").Append(Conteudo).Append("\n");
            
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
            return this.Equals(obj as DetailOpportunityUpdate);
        }

        /// <summary>
        /// Returns true if DetailOpportunityUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of DetailOpportunityUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailOpportunityUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.NomeCampo == other.NomeCampo ||
                    this.NomeCampo != null &&
                    this.NomeCampo.Equals(other.NomeCampo)
                ) && 
                (
                    this.Conteudo == other.Conteudo ||
                    this.Conteudo != null &&
                    this.Conteudo.Equals(other.Conteudo)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.NomeCampo != null)
                    hash = hash * 59 + this.NomeCampo.GetHashCode();
                
                if (this.Conteudo != null)
                    hash = hash * 59 + this.Conteudo.GetHashCode();
                
                return hash;
            }
        }

    }
}
