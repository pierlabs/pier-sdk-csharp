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
    /// Representa\u00C3\u00A7\u00C3\u00A3o do tipo de template.
    /// </summary>
    [DataContract]
    public partial class TipoTemplateRequest :  IEquatable<TipoTemplateRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoTemplateRequest" /> class.
        /// Initializes a new instance of the <see cref="TipoTemplateRequest" />class.
        /// </summary>
        /// <param name="Nome">Nome do tipo de template..</param>
        /// <param name="Descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo de template..</param>
        /// <param name="Sigla">Sigla do tipo de template..</param>

        public TipoTemplateRequest(string Nome = null, string Descricao = null, string Sigla = null)
        {
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.Sigla = Sigla;
            
        }
        
    
        /// <summary>
        /// Nome do tipo de template.
        /// </summary>
        /// <value>Nome do tipo de template.</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o do tipo de template.
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o do tipo de template.</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Sigla do tipo de template.
        /// </summary>
        /// <value>Sigla do tipo de template.</value>
        [DataMember(Name="sigla", EmitDefaultValue=false)]
        public string Sigla { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoTemplateRequest {\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  Sigla: ").Append(Sigla).Append("\n");
            
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
            return this.Equals(obj as TipoTemplateRequest);
        }

        /// <summary>
        /// Returns true if TipoTemplateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoTemplateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoTemplateRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.Sigla == other.Sigla ||
                    this.Sigla != null &&
                    this.Sigla.Equals(other.Sigla)
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
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.Sigla != null)
                    hash = hash * 59 + this.Sigla.GetHashCode();
                
                return hash;
            }
        }

    }
}
