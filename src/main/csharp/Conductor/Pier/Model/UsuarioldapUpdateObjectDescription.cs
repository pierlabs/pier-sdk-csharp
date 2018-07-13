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
    /// {{{usuarioldap_update_object_description}}}
    /// </summary>
    [DataContract]
    public partial class UsuarioldapUpdateObjectDescription :  IEquatable<UsuarioldapUpdateObjectDescription>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioldapUpdateObjectDescription" /> class.
        /// Initializes a new instance of the <see cref="UsuarioldapUpdateObjectDescription" />class.
        /// </summary>
        /// <param name="Nome">{{{usuario_update_nome_value}}}.</param>
        /// <param name="Login">{{{usuario_update_login_value}}}.</param>
        /// <param name="Cpf">{{{usuario_update_cpf_value}}}.</param>
        /// <param name="Email">{{{usuario_update_email_value}}}.</param>
        /// <param name="Perfis">{{{usuario_persist_email_value}}}.</param>
        /// <param name="Status">{{{usuario_update_status_value}}}.</param>

        public UsuarioldapUpdateObjectDescription(string Nome = null, string Login = null, string Cpf = null, string Email = null, List<ReferenciaIdPersist> Perfis = null, string Status = null)
        {
            this.Nome = Nome;
            this.Login = Login;
            this.Cpf = Cpf;
            this.Email = Email;
            this.Perfis = Perfis;
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// {{{usuario_update_nome_value}}}
        /// </summary>
        /// <value>{{{usuario_update_nome_value}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// {{{usuario_update_login_value}}}
        /// </summary>
        /// <value>{{{usuario_update_login_value}}}</value>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }
    
        /// <summary>
        /// {{{usuario_update_cpf_value}}}
        /// </summary>
        /// <value>{{{usuario_update_cpf_value}}}</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// {{{usuario_update_email_value}}}
        /// </summary>
        /// <value>{{{usuario_update_email_value}}}</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// {{{usuario_persist_email_value}}}
        /// </summary>
        /// <value>{{{usuario_persist_email_value}}}</value>
        [DataMember(Name="perfis", EmitDefaultValue=false)]
        public List<ReferenciaIdPersist> Perfis { get; set; }
    
        /// <summary>
        /// {{{usuario_update_status_value}}}
        /// </summary>
        /// <value>{{{usuario_update_status_value}}}</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsuarioldapUpdateObjectDescription {\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Perfis: ").Append(Perfis).Append("\n");
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
            return this.Equals(obj as UsuarioldapUpdateObjectDescription);
        }

        /// <summary>
        /// Returns true if UsuarioldapUpdateObjectDescription instances are equal
        /// </summary>
        /// <param name="other">Instance of UsuarioldapUpdateObjectDescription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsuarioldapUpdateObjectDescription other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.Login == other.Login ||
                    this.Login != null &&
                    this.Login.Equals(other.Login)
                ) && 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Perfis == other.Perfis ||
                    this.Perfis != null &&
                    this.Perfis.SequenceEqual(other.Perfis)
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
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Login != null)
                    hash = hash * 59 + this.Login.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.Perfis != null)
                    hash = hash * 59 + this.Perfis.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
