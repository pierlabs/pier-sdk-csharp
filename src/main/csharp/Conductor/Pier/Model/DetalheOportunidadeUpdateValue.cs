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
    /// {{{detalhe_oportunidade_update_description}}}
    /// </summary>
    [DataContract]
    public partial class DetalheOportunidadeUpdateValue :  IEquatable<DetalheOportunidadeUpdateValue>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DetalheOportunidadeUpdateValue" /> class.
        /// Initializes a new instance of the <see cref="DetalheOportunidadeUpdateValue" />class.
        /// </summary>
        /// <param name="Id">{{{detalhe_oportunidade_update_id_value}}}.</param>
        /// <param name="NomeCampo">{{{detalhe_oportunidade_update_nome_campo_value}}}.</param>
        /// <param name="Conteudo">{{{detalhe_oportunidade_update_conteudo_value}}}.</param>

        public DetalheOportunidadeUpdateValue(long? Id = null, string NomeCampo = null, string Conteudo = null)
        {
            this.Id = Id;
            this.NomeCampo = NomeCampo;
            this.Conteudo = Conteudo;
            
        }
        
    
        /// <summary>
        /// {{{detalhe_oportunidade_update_id_value}}}
        /// </summary>
        /// <value>{{{detalhe_oportunidade_update_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{detalhe_oportunidade_update_nome_campo_value}}}
        /// </summary>
        /// <value>{{{detalhe_oportunidade_update_nome_campo_value}}}</value>
        [DataMember(Name="nomeCampo", EmitDefaultValue=false)]
        public string NomeCampo { get; set; }
    
        /// <summary>
        /// {{{detalhe_oportunidade_update_conteudo_value}}}
        /// </summary>
        /// <value>{{{detalhe_oportunidade_update_conteudo_value}}}</value>
        [DataMember(Name="conteudo", EmitDefaultValue=false)]
        public string Conteudo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetalheOportunidadeUpdateValue {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NomeCampo: ").Append(NomeCampo).Append("\n");
            sb.Append("  Conteudo: ").Append(Conteudo).Append("\n");
            
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
            return this.Equals(obj as DetalheOportunidadeUpdateValue);
        }

        /// <summary>
        /// Returns true if DetalheOportunidadeUpdateValue instances are equal
        /// </summary>
        /// <param name="other">Instance of DetalheOportunidadeUpdateValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetalheOportunidadeUpdateValue other)
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
                    this.NomeCampo == other.NomeCampo ||
                    this.NomeCampo != null &&
                    this.NomeCampo.Equals(other.NomeCampo)
                ) && 
                (
                    this.Conteudo == other.Conteudo ||
                    this.Conteudo != null &&
                    this.Conteudo.Equals(other.Conteudo)
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
                
                if (this.NomeCampo != null)
                    hash = hash * 59 + this.NomeCampo.GetHashCode();
                
                if (this.Conteudo != null)
                    hash = hash * 59 + this.Conteudo.GetHashCode();
                
                return hash;
            }
        }

    }
}
