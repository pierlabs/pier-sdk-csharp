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
    /// Representa\u00E7\u00E3o do recurso Est\u00E1gio Cart\u00E3o
    /// </summary>
    [DataContract]
    public partial class EstagioCartaoResponse :  IEquatable<EstagioCartaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EstagioCartaoResponse" /> class.
        /// Initializes a new instance of the <see cref="EstagioCartaoResponse" />class.
        /// </summary>
        /// <param name="Id">Id do est\u00E1gio cart\u00E3o (required).</param>
        /// <param name="Nome">Nome do est\u00E1gio cart\u00E3o (required).</param>

        public EstagioCartaoResponse(long? Id = null, string Nome = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for EstagioCartaoResponse and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Nome" is required (not null)
            if (Nome == null)
            {
                throw new InvalidDataException("Nome is a required property for EstagioCartaoResponse and cannot be null");
            }
            else
            {
                this.Nome = Nome;
            }
            
        }
        
    
        /// <summary>
        /// Id do est\u00E1gio cart\u00E3o
        /// </summary>
        /// <value>Id do est\u00E1gio cart\u00E3o</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Nome do est\u00E1gio cart\u00E3o
        /// </summary>
        /// <value>Nome do est\u00E1gio cart\u00E3o</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EstagioCartaoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            
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
            return this.Equals(obj as EstagioCartaoResponse);
        }

        /// <summary>
        /// Returns true if EstagioCartaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of EstagioCartaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EstagioCartaoResponse other)
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
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
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
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                return hash;
            }
        }

    }
}
