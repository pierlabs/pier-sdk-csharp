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
    /// Objeto Response do Tipo Servi\u00E7o
    /// </summary>
    [DataContract]
    public partial class TipoServicoResponse :  IEquatable<TipoServicoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoServicoResponse" /> class.
        /// Initializes a new instance of the <see cref="TipoServicoResponse" />class.
        /// </summary>
        /// <param name="Descricao">Descricao.</param>
        /// <param name="Id">Identificador do Tipo Servi\u00E7o.</param>

        public TipoServicoResponse(string Descricao = null, long? Id = null)
        {
            this.Descricao = Descricao;
            this.Id = Id;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Descricao
        /// </summary>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Identificador do Tipo Servi\u00E7o
        /// </summary>
        /// <value>Identificador do Tipo Servi\u00E7o</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoServicoResponse {\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            
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
            return this.Equals(obj as TipoServicoResponse);
        }

        /// <summary>
        /// Returns true if TipoServicoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoServicoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoServicoResponse other)
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                return hash;
            }
        }

    }
}
