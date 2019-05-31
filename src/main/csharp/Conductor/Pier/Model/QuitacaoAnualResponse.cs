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
    /// Objeto de resposta do recurso de quita\u00E7\u00E3o anual de d\u00E9bitos
    /// </summary>
    [DataContract]
    public partial class QuitacaoAnualResponse :  IEquatable<QuitacaoAnualResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QuitacaoAnualResponse" /> class.
        /// Initializes a new instance of the <see cref="QuitacaoAnualResponse" />class.
        /// </summary>
        /// <param name="IdConta">Identificador da conta.</param>
        /// <param name="FlagQuite">Flag que representa o estado de quita\u00E7\u00E3o do portador.</param>

        public QuitacaoAnualResponse(long? IdConta = null, bool? FlagQuite = null)
        {
            this.IdConta = IdConta;
            this.FlagQuite = FlagQuite;
            
        }
        
    
        /// <summary>
        /// Identificador da conta
        /// </summary>
        /// <value>Identificador da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Flag que representa o estado de quita\u00E7\u00E3o do portador
        /// </summary>
        /// <value>Flag que representa o estado de quita\u00E7\u00E3o do portador</value>
        [DataMember(Name="flagQuite", EmitDefaultValue=false)]
        public bool? FlagQuite { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuitacaoAnualResponse {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  FlagQuite: ").Append(FlagQuite).Append("\n");
            
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
            return this.Equals(obj as QuitacaoAnualResponse);
        }

        /// <summary>
        /// Returns true if QuitacaoAnualResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of QuitacaoAnualResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuitacaoAnualResponse other)
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
                    this.FlagQuite == other.FlagQuite ||
                    this.FlagQuite != null &&
                    this.FlagQuite.Equals(other.FlagQuite)
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
                
                if (this.FlagQuite != null)
                    hash = hash * 59 + this.FlagQuite.GetHashCode();
                
                return hash;
            }
        }

    }
}
