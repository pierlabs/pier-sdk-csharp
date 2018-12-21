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
    /// {{{tipo_template_response_description}}}
    /// </summary>
    [DataContract]
    public partial class TipoTemplateResponse :  IEquatable<TipoTemplateResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoTemplateResponse" /> class.
        /// Initializes a new instance of the <see cref="TipoTemplateResponse" />class.
        /// </summary>
        /// <param name="Id">{{{tipo_template_response_id_value}}}.</param>
        /// <param name="Nome">{{{tipo_template_response_nome_value}}}.</param>
        /// <param name="Descricao">{{{tipo_template_response_descricao_value}}}.</param>
        /// <param name="Sigla">{{{tipo_template_response_sigla_value}}}.</param>

        public TipoTemplateResponse(long? Id = null, string Nome = null, string Descricao = null, string Sigla = null)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.Sigla = Sigla;
            
        }
        
    
        /// <summary>
        /// {{{tipo_template_response_id_value}}}
        /// </summary>
        /// <value>{{{tipo_template_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{tipo_template_response_nome_value}}}
        /// </summary>
        /// <value>{{{tipo_template_response_nome_value}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// {{{tipo_template_response_descricao_value}}}
        /// </summary>
        /// <value>{{{tipo_template_response_descricao_value}}}</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// {{{tipo_template_response_sigla_value}}}
        /// </summary>
        /// <value>{{{tipo_template_response_sigla_value}}}</value>
        [DataMember(Name="sigla", EmitDefaultValue=false)]
        public string Sigla { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoTemplateResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as TipoTemplateResponse);
        }

        /// <summary>
        /// Returns true if TipoTemplateResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoTemplateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoTemplateResponse other)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
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
