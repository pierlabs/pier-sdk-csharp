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
    /// Response Representation of the TypeOpportunity resource
    /// </summary>
    [DataContract]
    public partial class TipoOportunidadeResponse :  IEquatable<TipoOportunidadeResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoOportunidadeResponse" /> class.
        /// Initializes a new instance of the <see cref="TipoOportunidadeResponse" />class.
        /// </summary>
        /// <param name="Id">Identifier Code of the TypeOpportunity (required).</param>
        /// <param name="Descricao">Description of the TypeOpportunity (required).</param>
        /// <param name="FlagAtivo">Flag that represents if the opportunity type is active (required).</param>

        public TipoOportunidadeResponse(long? Id = null, string Descricao = null, bool? FlagAtivo = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for TipoOportunidadeResponse and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Descricao" is required (not null)
            if (Descricao == null)
            {
                throw new InvalidDataException("Descricao is a required property for TipoOportunidadeResponse and cannot be null");
            }
            else
            {
                this.Descricao = Descricao;
            }
            // to ensure "FlagAtivo" is required (not null)
            if (FlagAtivo == null)
            {
                throw new InvalidDataException("FlagAtivo is a required property for TipoOportunidadeResponse and cannot be null");
            }
            else
            {
                this.FlagAtivo = FlagAtivo;
            }
            
        }
        
    
        /// <summary>
        /// Identifier Code of the TypeOpportunity
        /// </summary>
        /// <value>Identifier Code of the TypeOpportunity</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Description of the TypeOpportunity
        /// </summary>
        /// <value>Description of the TypeOpportunity</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Flag that represents if the opportunity type is active
        /// </summary>
        /// <value>Flag that represents if the opportunity type is active</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public bool? FlagAtivo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoOportunidadeResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  FlagAtivo: ").Append(FlagAtivo).Append("\n");
            
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
            return this.Equals(obj as TipoOportunidadeResponse);
        }

        /// <summary>
        /// Returns true if TipoOportunidadeResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoOportunidadeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoOportunidadeResponse other)
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
                ) && 
                (
                    this.FlagAtivo == other.FlagAtivo ||
                    this.FlagAtivo != null &&
                    this.FlagAtivo.Equals(other.FlagAtivo)
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
                
                if (this.FlagAtivo != null)
                    hash = hash * 59 + this.FlagAtivo.GetHashCode();
                
                return hash;
            }
        }

    }
}
