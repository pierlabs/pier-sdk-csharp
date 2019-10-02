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
    /// Objeto de cria\u00E7\u00E3o para um CVV din\u00E2mico
    /// </summary>
    [DataContract]
    public partial class CvvDinamicoPersist :  IEquatable<CvvDinamicoPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CvvDinamicoPersist" /> class.
        /// Initializes a new instance of the <see cref="CvvDinamicoPersist" />class.
        /// </summary>
        /// <param name="DataExpiracao">cvv_dinamico_persist_data_expiracao_value (required).</param>

        public CvvDinamicoPersist(string DataExpiracao = null)
        {
            // to ensure "DataExpiracao" is required (not null)
            if (DataExpiracao == null)
            {
                throw new InvalidDataException("DataExpiracao is a required property for CvvDinamicoPersist and cannot be null");
            }
            else
            {
                this.DataExpiracao = DataExpiracao;
            }
            
        }
        
    
        /// <summary>
        /// cvv_dinamico_persist_data_expiracao_value
        /// </summary>
        /// <value>cvv_dinamico_persist_data_expiracao_value</value>
        [DataMember(Name="dataExpiracao", EmitDefaultValue=false)]
        public string DataExpiracao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CvvDinamicoPersist {\n");
            sb.Append("  DataExpiracao: ").Append(DataExpiracao).Append("\n");
            
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
            return this.Equals(obj as CvvDinamicoPersist);
        }

        /// <summary>
        /// Returns true if CvvDinamicoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of CvvDinamicoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CvvDinamicoPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataExpiracao == other.DataExpiracao ||
                    this.DataExpiracao != null &&
                    this.DataExpiracao.Equals(other.DataExpiracao)
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
                
                if (this.DataExpiracao != null)
                    hash = hash * 59 + this.DataExpiracao.GetHashCode();
                
                return hash;
            }
        }

    }
}
