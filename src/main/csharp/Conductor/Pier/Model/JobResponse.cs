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
    /// {{{job_response_description}}}
    /// </summary>
    [DataContract]
    public partial class JobResponse :  IEquatable<JobResponse>
    { 
    
        /// <summary>
        /// {{{job_response_status_value}}}
        /// </summary>
        /// <value>{{{job_response_status_value}}}</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "INATIVO")]
            Inativo,
            
            [EnumMember(Value = "ATIVO")]
            Ativo
        }

    
        /// <summary>
        /// {{{job_response_status_value}}}
        /// </summary>
        /// <value>{{{job_response_status_value}}}</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="JobResponse" /> class.
        /// Initializes a new instance of the <see cref="JobResponse" />class.
        /// </summary>
        /// <param name="Id">{{{job_response_id_value}}}.</param>
        /// <param name="Descricao">{{{job_response_descricao_value}}}.</param>
        /// <param name="Groovy">{{{job_response_groovy_value}}}.</param>
        /// <param name="Cron">{{{job_response_cron_value}}}.</param>
        /// <param name="Status">{{{job_response_status_value}}}.</param>

        public JobResponse(long? Id = null, string Descricao = null, string Groovy = null, string Cron = null, StatusEnum? Status = null)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.Groovy = Groovy;
            this.Cron = Cron;
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// {{{job_response_id_value}}}
        /// </summary>
        /// <value>{{{job_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{job_response_descricao_value}}}
        /// </summary>
        /// <value>{{{job_response_descricao_value}}}</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// {{{job_response_groovy_value}}}
        /// </summary>
        /// <value>{{{job_response_groovy_value}}}</value>
        [DataMember(Name="groovy", EmitDefaultValue=false)]
        public string Groovy { get; set; }
    
        /// <summary>
        /// {{{job_response_cron_value}}}
        /// </summary>
        /// <value>{{{job_response_cron_value}}}</value>
        [DataMember(Name="cron", EmitDefaultValue=false)]
        public string Cron { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  Groovy: ").Append(Groovy).Append("\n");
            sb.Append("  Cron: ").Append(Cron).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            
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
            return this.Equals(obj as JobResponse);
        }

        /// <summary>
        /// Returns true if JobResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of JobResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobResponse other)
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
                    this.Groovy == other.Groovy ||
                    this.Groovy != null &&
                    this.Groovy.Equals(other.Groovy)
                ) && 
                (
                    this.Cron == other.Cron ||
                    this.Cron != null &&
                    this.Cron.Equals(other.Cron)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.Groovy != null)
                    hash = hash * 59 + this.Groovy.GetHashCode();
                
                if (this.Cron != null)
                    hash = hash * 59 + this.Cron.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
