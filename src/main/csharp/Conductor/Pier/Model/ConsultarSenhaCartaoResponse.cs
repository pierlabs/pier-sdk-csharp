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
    /// Representa o objeto de resposta da consulta da senha do cart\u00E3o
    /// </summary>
    [DataContract]
    public partial class ConsultarSenhaCartaoResponse :  IEquatable<ConsultarSenhaCartaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsultarSenhaCartaoResponse" /> class.
        /// Initializes a new instance of the <see cref="ConsultarSenhaCartaoResponse" />class.
        /// </summary>
        /// <param name="Senha">Senha.</param>

        public ConsultarSenhaCartaoResponse(string Senha = null)
        {
            this.Senha = Senha;
            
        }
        
    
        /// <summary>
        /// Senha
        /// </summary>
        /// <value>Senha</value>
        [DataMember(Name="senha", EmitDefaultValue=false)]
        public string Senha { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsultarSenhaCartaoResponse {\n");
            sb.Append("  Senha: ").Append(Senha).Append("\n");
            
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
            return this.Equals(obj as ConsultarSenhaCartaoResponse);
        }

        /// <summary>
        /// Returns true if ConsultarSenhaCartaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ConsultarSenhaCartaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsultarSenhaCartaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Senha == other.Senha ||
                    this.Senha != null &&
                    this.Senha.Equals(other.Senha)
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
                
                if (this.Senha != null)
                    hash = hash * 59 + this.Senha.GetHashCode();
                
                return hash;
            }
        }

    }
}
