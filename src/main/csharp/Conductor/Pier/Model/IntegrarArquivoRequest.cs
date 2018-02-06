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
    /// Objeto de requisi\u00C3\u00A7\u00C3\u00A3o da integra\u00C3\u00A7\u00C3\u00A3o de Arquivos.
    /// </summary>
    [DataContract]
    public partial class IntegrarArquivoRequest :  IEquatable<IntegrarArquivoRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrarArquivoRequest" /> class.
        /// Initializes a new instance of the <see cref="IntegrarArquivoRequest" />class.
        /// </summary>
        /// <param name="Cpf">CPF do cliente de Arquivos a serem integrados.</param>

        public IntegrarArquivoRequest(string Cpf = null)
        {
            this.Cpf = Cpf;
            
        }
        
    
        /// <summary>
        /// CPF do cliente de Arquivos a serem integrados
        /// </summary>
        /// <value>CPF do cliente de Arquivos a serem integrados</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegrarArquivoRequest {\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            
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
            return this.Equals(obj as IntegrarArquivoRequest);
        }

        /// <summary>
        /// Returns true if IntegrarArquivoRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of IntegrarArquivoRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrarArquivoRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
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
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                return hash;
            }
        }

    }
}
