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
    /// Representa\u00E7\u00E3o para resposta de dados de Controle de cart\u00E3o por Grupo MCC.
    /// </summary>
    [DataContract]
    public partial class ControleCartaoGrupoMCCResponse :  IEquatable<ControleCartaoGrupoMCCResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ControleCartaoGrupoMCCResponse" /> class.
        /// Initializes a new instance of the <see cref="ControleCartaoGrupoMCCResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo Identificador do controle do cart\u00E3o na base (id).</param>
        /// <param name="IdCartao">C\u00F3digo Identificador do cart\u00E3o na base..</param>
        /// <param name="IdGrupoMCC">C\u00F3digo Identificador do grupo mcc na base..</param>

        public ControleCartaoGrupoMCCResponse(long? Id = null, long? IdCartao = null, long? IdGrupoMCC = null)
        {
            this.Id = Id;
            this.IdCartao = IdCartao;
            this.IdGrupoMCC = IdGrupoMCC;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo Identificador do controle do cart\u00E3o na base (id)
        /// </summary>
        /// <value>C\u00F3digo Identificador do controle do cart\u00E3o na base (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00F3digo Identificador do cart\u00E3o na base.
        /// </summary>
        /// <value>C\u00F3digo Identificador do cart\u00E3o na base.</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// C\u00F3digo Identificador do grupo mcc na base.
        /// </summary>
        /// <value>C\u00F3digo Identificador do grupo mcc na base.</value>
        [DataMember(Name="idGrupoMCC", EmitDefaultValue=false)]
        public long? IdGrupoMCC { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ControleCartaoGrupoMCCResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdGrupoMCC: ").Append(IdGrupoMCC).Append("\n");
            
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
            return this.Equals(obj as ControleCartaoGrupoMCCResponse);
        }

        /// <summary>
        /// Returns true if ControleCartaoGrupoMCCResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ControleCartaoGrupoMCCResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ControleCartaoGrupoMCCResponse other)
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
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.IdGrupoMCC == other.IdGrupoMCC ||
                    this.IdGrupoMCC != null &&
                    this.IdGrupoMCC.Equals(other.IdGrupoMCC)
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
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.IdGrupoMCC != null)
                    hash = hash * 59 + this.IdGrupoMCC.GetHashCode();
                
                return hash;
            }
        }

    }
}
