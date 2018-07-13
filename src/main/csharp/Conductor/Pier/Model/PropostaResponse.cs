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
    /// {{{proposta_response_description}}}
    /// </summary>
    [DataContract]
    public partial class PropostaResponse :  IEquatable<PropostaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PropostaResponse" /> class.
        /// Initializes a new instance of the <see cref="PropostaResponse" />class.
        /// </summary>
        /// <param name="Id">{{{proposta_response_id_value}}}.</param>
        /// <param name="Status">{{{proposta_response_status_value}}}.</param>
        /// <param name="DataCadastramento">{{{proposta_response_data_cadastramento_value}}}.</param>

        public PropostaResponse(long? Id = null, int? Status = null, string DataCadastramento = null)
        {
            this.Id = Id;
            this.Status = Status;
            this.DataCadastramento = DataCadastramento;
            
        }
        
    
        /// <summary>
        /// {{{proposta_response_id_value}}}
        /// </summary>
        /// <value>{{{proposta_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{proposta_response_status_value}}}
        /// </summary>
        /// <value>{{{proposta_response_status_value}}}</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// {{{proposta_response_data_cadastramento_value}}}
        /// </summary>
        /// <value>{{{proposta_response_data_cadastramento_value}}}</value>
        [DataMember(Name="dataCadastramento", EmitDefaultValue=false)]
        public string DataCadastramento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropostaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DataCadastramento: ").Append(DataCadastramento).Append("\n");
            
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
            return this.Equals(obj as PropostaResponse);
        }

        /// <summary>
        /// Returns true if PropostaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PropostaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropostaResponse other)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.DataCadastramento == other.DataCadastramento ||
                    this.DataCadastramento != null &&
                    this.DataCadastramento.Equals(other.DataCadastramento)
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.DataCadastramento != null)
                    hash = hash * 59 + this.DataCadastramento.GetHashCode();
                
                return hash;
            }
        }

    }
}
