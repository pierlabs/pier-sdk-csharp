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
    /// Objeto de Resposta para o Grupo MCC
    /// </summary>
    [DataContract]
    public partial class GrupoMCCResponse :  IEquatable<GrupoMCCResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GrupoMCCResponse" /> class.
        /// Initializes a new instance of the <see cref="GrupoMCCResponse" />class.
        /// </summary>
        /// <param name="Id">id.</param>
        /// <param name="Descricao">descricao.</param>
        /// <param name="DescricaoExtrato">descricaoExtrato.</param>

        public GrupoMCCResponse(long? Id = null, string Descricao = null, string DescricaoExtrato = null)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.DescricaoExtrato = DescricaoExtrato;
            
        }
        
    
        /// <summary>
        /// id
        /// </summary>
        /// <value>id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// descricao
        /// </summary>
        /// <value>descricao</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// descricaoExtrato
        /// </summary>
        /// <value>descricaoExtrato</value>
        [DataMember(Name="descricaoExtrato", EmitDefaultValue=false)]
        public string DescricaoExtrato { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GrupoMCCResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  DescricaoExtrato: ").Append(DescricaoExtrato).Append("\n");
            
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
            return this.Equals(obj as GrupoMCCResponse);
        }

        /// <summary>
        /// Returns true if GrupoMCCResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GrupoMCCResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GrupoMCCResponse other)
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
                    this.DescricaoExtrato == other.DescricaoExtrato ||
                    this.DescricaoExtrato != null &&
                    this.DescricaoExtrato.Equals(other.DescricaoExtrato)
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
                
                if (this.DescricaoExtrato != null)
                    hash = hash * 59 + this.DescricaoExtrato.GetHashCode();
                
                return hash;
            }
        }

    }
}
