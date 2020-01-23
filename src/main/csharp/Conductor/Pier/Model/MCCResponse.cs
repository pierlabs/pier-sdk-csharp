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
    /// ObjetoMCC
    /// </summary>
    [DataContract]
    public partial class MCCResponse :  IEquatable<MCCResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MCCResponse" /> class.
        /// Initializes a new instance of the <see cref="MCCResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo de Identifica\u00E7\u00E3o do MCC (id).</param>
        /// <param name="Descricao">descricao do MCC.</param>
        /// <param name="GrupoMCCId">C\u00F3digo de indentifica\u00E7\u00E3o do grupo MCC.</param>
        /// <param name="GrupoMCCDescricao">Descri\u00E7\u00E3o do grupo MCC.</param>

        public MCCResponse(long? Id = null, string Descricao = null, long? GrupoMCCId = null, string GrupoMCCDescricao = null)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.GrupoMCCId = GrupoMCCId;
            this.GrupoMCCDescricao = GrupoMCCDescricao;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do MCC (id)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do MCC (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// descricao do MCC
        /// </summary>
        /// <value>descricao do MCC</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// C\u00F3digo de indentifica\u00E7\u00E3o do grupo MCC
        /// </summary>
        /// <value>C\u00F3digo de indentifica\u00E7\u00E3o do grupo MCC</value>
        [DataMember(Name="grupoMCCId", EmitDefaultValue=false)]
        public long? GrupoMCCId { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do grupo MCC
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do grupo MCC</value>
        [DataMember(Name="grupoMCCDescricao", EmitDefaultValue=false)]
        public string GrupoMCCDescricao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MCCResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  GrupoMCCId: ").Append(GrupoMCCId).Append("\n");
            sb.Append("  GrupoMCCDescricao: ").Append(GrupoMCCDescricao).Append("\n");
            
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
            return this.Equals(obj as MCCResponse);
        }

        /// <summary>
        /// Returns true if MCCResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of MCCResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MCCResponse other)
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
                    this.GrupoMCCId == other.GrupoMCCId ||
                    this.GrupoMCCId != null &&
                    this.GrupoMCCId.Equals(other.GrupoMCCId)
                ) && 
                (
                    this.GrupoMCCDescricao == other.GrupoMCCDescricao ||
                    this.GrupoMCCDescricao != null &&
                    this.GrupoMCCDescricao.Equals(other.GrupoMCCDescricao)
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
                
                if (this.GrupoMCCId != null)
                    hash = hash * 59 + this.GrupoMCCId.GetHashCode();
                
                if (this.GrupoMCCDescricao != null)
                    hash = hash * 59 + this.GrupoMCCDescricao.GetHashCode();
                
                return hash;
            }
        }

    }
}
