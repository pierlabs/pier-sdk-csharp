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
    /// Representa\u00E7\u00E3o de resposta do recurso de tipos de v\u00EDnculos
    /// </summary>
    [DataContract]
    public partial class TipoVinculoContaResponse :  IEquatable<TipoVinculoContaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoVinculoContaResponse" /> class.
        /// Initializes a new instance of the <see cref="TipoVinculoContaResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo identificador do tipo de v\u00EDnculo (id).</param>
        /// <param name="Descricao">Descri\u00E7\u00E3o do tipo de v\u00EDnculo.</param>

        public TipoVinculoContaResponse(long? Id = null, string Descricao = null)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo identificador do tipo de v\u00EDnculo (id)
        /// </summary>
        /// <value>C\u00F3digo identificador do tipo de v\u00EDnculo (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
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
            sb.Append("class TipoVinculoContaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as TipoVinculoContaResponse);
        }

        /// <summary>
        /// Returns true if TipoVinculoContaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoVinculoContaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoVinculoContaResponse other)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                return hash;
            }
        }

    }
}
