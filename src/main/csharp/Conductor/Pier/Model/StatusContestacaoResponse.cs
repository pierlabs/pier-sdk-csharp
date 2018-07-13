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
    /// {{{status_contestacao_response_description}}}
    /// </summary>
    [DataContract]
    public partial class StatusContestacaoResponse :  IEquatable<StatusContestacaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusContestacaoResponse" /> class.
        /// Initializes a new instance of the <see cref="StatusContestacaoResponse" />class.
        /// </summary>
        /// <param name="IdStatusContestacao">{{{status_contestacao_request_idstatuscontestacao_value}}}.</param>
        /// <param name="Descricao">{{{status_contestacao_response_descricao_value}}}.</param>

        public StatusContestacaoResponse(long? IdStatusContestacao = null, string Descricao = null)
        {
            this.IdStatusContestacao = IdStatusContestacao;
            this.Descricao = Descricao;
            
        }
        
    
        /// <summary>
        /// {{{status_contestacao_request_idstatuscontestacao_value}}}
        /// </summary>
        /// <value>{{{status_contestacao_request_idstatuscontestacao_value}}}</value>
        [DataMember(Name="idStatusContestacao", EmitDefaultValue=false)]
        public long? IdStatusContestacao { get; set; }
    
        /// <summary>
        /// {{{status_contestacao_response_descricao_value}}}
        /// </summary>
        /// <value>{{{status_contestacao_response_descricao_value}}}</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusContestacaoResponse {\n");
            sb.Append("  IdStatusContestacao: ").Append(IdStatusContestacao).Append("\n");
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
            return this.Equals(obj as StatusContestacaoResponse);
        }

        /// <summary>
        /// Returns true if StatusContestacaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of StatusContestacaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusContestacaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdStatusContestacao == other.IdStatusContestacao ||
                    this.IdStatusContestacao != null &&
                    this.IdStatusContestacao.Equals(other.IdStatusContestacao)
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
                
                if (this.IdStatusContestacao != null)
                    hash = hash * 59 + this.IdStatusContestacao.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                return hash;
            }
        }

    }
}
