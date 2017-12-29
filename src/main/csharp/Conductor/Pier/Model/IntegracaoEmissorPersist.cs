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
    /// Representa a requisi\u00C3\u00A7\u00C3\u00A3o do recurso de incluir integra\u00C3\u00A7\u00C3\u00A3o emissor
    /// </summary>
    [DataContract]
    public partial class IntegracaoEmissorPersist :  IEquatable<IntegracaoEmissorPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegracaoEmissorPersist" /> class.
        /// Initializes a new instance of the <see cref="IntegracaoEmissorPersist" />class.
        /// </summary>
        /// <param name="CanalEntrada">Canal de entrada onde deve ser informado o dispositivo usado na comunica\u00C3\u00A7\u00C3\u00A3o..</param>

        public IntegracaoEmissorPersist(string CanalEntrada = null)
        {
            this.CanalEntrada = CanalEntrada;
            
        }
        
    
        /// <summary>
        /// Canal de entrada onde deve ser informado o dispositivo usado na comunica\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Canal de entrada onde deve ser informado o dispositivo usado na comunica\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="canalEntrada", EmitDefaultValue=false)]
        public string CanalEntrada { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegracaoEmissorPersist {\n");
            sb.Append("  CanalEntrada: ").Append(CanalEntrada).Append("\n");
            
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
            return this.Equals(obj as IntegracaoEmissorPersist);
        }

        /// <summary>
        /// Returns true if IntegracaoEmissorPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of IntegracaoEmissorPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegracaoEmissorPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CanalEntrada == other.CanalEntrada ||
                    this.CanalEntrada != null &&
                    this.CanalEntrada.Equals(other.CanalEntrada)
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
                
                if (this.CanalEntrada != null)
                    hash = hash * 59 + this.CanalEntrada.GetHashCode();
                
                return hash;
            }
        }

    }
}
