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
    /// {{{emissor_response_description}}}
    /// </summary>
    [DataContract]
    public partial class EmissorPierResponse :  IEquatable<EmissorPierResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmissorPierResponse" /> class.
        /// Initializes a new instance of the <see cref="EmissorPierResponse" />class.
        /// </summary>
        /// <param name="Id">{{{emissor_response_id_value}}}.</param>
        /// <param name="Nome">{{{emissor_response_nome_value}}}.</param>
        /// <param name="Tema">{{{emissor_response_tema_value}}}.</param>

        public EmissorPierResponse(int? Id = null, string Nome = null, string Tema = null)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Tema = Tema;
            
        }
        
    
        /// <summary>
        /// {{{emissor_response_id_value}}}
        /// </summary>
        /// <value>{{{emissor_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
    
        /// <summary>
        /// {{{emissor_response_nome_value}}}
        /// </summary>
        /// <value>{{{emissor_response_nome_value}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// {{{emissor_response_tema_value}}}
        /// </summary>
        /// <value>{{{emissor_response_tema_value}}}</value>
        [DataMember(Name="tema", EmitDefaultValue=false)]
        public string Tema { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmissorPierResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Tema: ").Append(Tema).Append("\n");
            
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
            return this.Equals(obj as EmissorPierResponse);
        }

        /// <summary>
        /// Returns true if EmissorPierResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of EmissorPierResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmissorPierResponse other)
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
                ) && 
                (
                    this.Tema == other.Tema ||
                    this.Tema != null &&
                    this.Tema.Equals(other.Tema)
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
                
                if (this.Tema != null)
                    hash = hash * 59 + this.Tema.GetHashCode();
                
                return hash;
            }
        }

    }
}
