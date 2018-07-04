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
    /// {{{anuidade_response_description}}}
    /// </summary>
    [DataContract]
    public partial class AnuidadeResponse :  IEquatable<AnuidadeResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnuidadeResponse" /> class.
        /// Initializes a new instance of the <see cref="AnuidadeResponse" />class.
        /// </summary>
        /// <param name="Id">{{{anuidade_response_id_value}}}.</param>
        /// <param name="Descricao">{{{anuidade_response_descricao_value}}}.</param>
        /// <param name="Valor">{{{anuidade_response_valor_value}}}.</param>
        /// <param name="FlagAnuidadeBonificada">{{{anuidade_response_flag_anuidade_bonificada_value}}}.</param>

        public AnuidadeResponse(long? Id = null, string Descricao = null, double? Valor = null, bool? FlagAnuidadeBonificada = null)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.Valor = Valor;
            this.FlagAnuidadeBonificada = FlagAnuidadeBonificada;
            
        }
        
    
        /// <summary>
        /// {{{anuidade_response_id_value}}}
        /// </summary>
        /// <value>{{{anuidade_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{anuidade_response_descricao_value}}}
        /// </summary>
        /// <value>{{{anuidade_response_descricao_value}}}</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// {{{anuidade_response_valor_value}}}
        /// </summary>
        /// <value>{{{anuidade_response_valor_value}}}</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// {{{anuidade_response_flag_anuidade_bonificada_value}}}
        /// </summary>
        /// <value>{{{anuidade_response_flag_anuidade_bonificada_value}}}</value>
        [DataMember(Name="flagAnuidadeBonificada", EmitDefaultValue=false)]
        public bool? FlagAnuidadeBonificada { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnuidadeResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  FlagAnuidadeBonificada: ").Append(FlagAnuidadeBonificada).Append("\n");
            
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
            return this.Equals(obj as AnuidadeResponse);
        }

        /// <summary>
        /// Returns true if AnuidadeResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AnuidadeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnuidadeResponse other)
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
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
                ) && 
                (
                    this.FlagAnuidadeBonificada == other.FlagAnuidadeBonificada ||
                    this.FlagAnuidadeBonificada != null &&
                    this.FlagAnuidadeBonificada.Equals(other.FlagAnuidadeBonificada)
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
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                if (this.FlagAnuidadeBonificada != null)
                    hash = hash * 59 + this.FlagAnuidadeBonificada.GetHashCode();
                
                return hash;
            }
        }

    }
}
