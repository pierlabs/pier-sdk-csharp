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
    /// {{{grade_pendente_request_description}}}
    /// </summary>
    [DataContract]
    public partial class GradePendenteRequest :  IEquatable<GradePendenteRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GradePendenteRequest" /> class.
        /// Initializes a new instance of the <see cref="GradePendenteRequest" />class.
        /// </summary>
        /// <param name="IdConta">{{{grade_pendente_request_id_conta_value}}}.</param>
        /// <param name="DataBase">{{{grade_pendente_request_data_base_value}}}.</param>

        public GradePendenteRequest(long? IdConta = null, string DataBase = null)
        {
            this.IdConta = IdConta;
            this.DataBase = DataBase;
            
        }
        
    
        /// <summary>
        /// {{{grade_pendente_request_id_conta_value}}}
        /// </summary>
        /// <value>{{{grade_pendente_request_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{grade_pendente_request_data_base_value}}}
        /// </summary>
        /// <value>{{{grade_pendente_request_data_base_value}}}</value>
        [DataMember(Name="dataBase", EmitDefaultValue=false)]
        public string DataBase { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GradePendenteRequest {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  DataBase: ").Append(DataBase).Append("\n");
            
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
            return this.Equals(obj as GradePendenteRequest);
        }

        /// <summary>
        /// Returns true if GradePendenteRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of GradePendenteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GradePendenteRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.DataBase == other.DataBase ||
                    this.DataBase != null &&
                    this.DataBase.Equals(other.DataBase)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.DataBase != null)
                    hash = hash * 59 + this.DataBase.GetHashCode();
                
                return hash;
            }
        }

    }
}
