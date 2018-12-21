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
    /// {{{controle_tentativa_cadastro_resposta_descricao}}}
    /// </summary>
    [DataContract]
    public partial class ControleTentativaCadastroResponse :  IEquatable<ControleTentativaCadastroResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ControleTentativaCadastroResponse" /> class.
        /// Initializes a new instance of the <see cref="ControleTentativaCadastroResponse" />class.
        /// </summary>
        /// <param name="Cpf">{{{controle_tentativa_cadastro_resposta_cpf_descricao}}}.</param>
        /// <param name="Login">{{{controle_tentativa_cadastro_resposta_login_descricao}}}.</param>
        /// <param name="Tentativas">{{{controle_tentativa_cadastro_resposta_tentativas_descricao}}}.</param>

        public ControleTentativaCadastroResponse(string Cpf = null, string Login = null, int? Tentativas = null)
        {
            this.Cpf = Cpf;
            this.Login = Login;
            this.Tentativas = Tentativas;
            
        }
        
    
        /// <summary>
        /// {{{controle_tentativa_cadastro_resposta_cpf_descricao}}}
        /// </summary>
        /// <value>{{{controle_tentativa_cadastro_resposta_cpf_descricao}}}</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// {{{controle_tentativa_cadastro_resposta_login_descricao}}}
        /// </summary>
        /// <value>{{{controle_tentativa_cadastro_resposta_login_descricao}}}</value>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }
    
        /// <summary>
        /// {{{controle_tentativa_cadastro_resposta_tentativas_descricao}}}
        /// </summary>
        /// <value>{{{controle_tentativa_cadastro_resposta_tentativas_descricao}}}</value>
        [DataMember(Name="tentativas", EmitDefaultValue=false)]
        public int? Tentativas { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ControleTentativaCadastroResponse {\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Tentativas: ").Append(Tentativas).Append("\n");
            
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
            return this.Equals(obj as ControleTentativaCadastroResponse);
        }

        /// <summary>
        /// Returns true if ControleTentativaCadastroResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ControleTentativaCadastroResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ControleTentativaCadastroResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
                ) && 
                (
                    this.Login == other.Login ||
                    this.Login != null &&
                    this.Login.Equals(other.Login)
                ) && 
                (
                    this.Tentativas == other.Tentativas ||
                    this.Tentativas != null &&
                    this.Tentativas.Equals(other.Tentativas)
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
                
                if (this.Login != null)
                    hash = hash * 59 + this.Login.GetHashCode();
                
                if (this.Tentativas != null)
                    hash = hash * 59 + this.Tentativas.GetHashCode();
                
                return hash;
            }
        }

    }
}
