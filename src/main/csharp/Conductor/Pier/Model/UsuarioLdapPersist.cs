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
    /// 
    /// </summary>
    [DataContract]
    public partial class UsuarioLdapPersist :  IEquatable<UsuarioLdapPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioLdapPersist" /> class.
        /// Initializes a new instance of the <see cref="UsuarioLdapPersist" />class.
        /// </summary>
        /// <param name="Cpf">Cpf.</param>
        /// <param name="Email">Email.</param>
        /// <param name="IdEmissor">IdEmissor.</param>
        /// <param name="Login">Login.</param>
        /// <param name="Nome">Nome.</param>
        /// <param name="Perfis">Perfis.</param>

        public UsuarioLdapPersist(string Cpf = null, string Email = null, long? IdEmissor = null, string Login = null, string Nome = null, List<ReferenciaIdPersist> Perfis = null)
        {
            this.Cpf = Cpf;
            this.Email = Email;
            this.IdEmissor = IdEmissor;
            this.Login = Login;
            this.Nome = Nome;
            this.Perfis = Perfis;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Cpf
        /// </summary>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or Sets IdEmissor
        /// </summary>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public long? IdEmissor { get; set; }
    
        /// <summary>
        /// Gets or Sets Login
        /// </summary>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }
    
        /// <summary>
        /// Gets or Sets Nome
        /// </summary>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Gets or Sets Perfis
        /// </summary>
        [DataMember(Name="perfis", EmitDefaultValue=false)]
        public List<ReferenciaIdPersist> Perfis { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsuarioLdapPersist {\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  IdEmissor: ").Append(IdEmissor).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Perfis: ").Append(Perfis).Append("\n");
            
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
            return this.Equals(obj as UsuarioLdapPersist);
        }

        /// <summary>
        /// Returns true if UsuarioLdapPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of UsuarioLdapPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsuarioLdapPersist other)
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
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.IdEmissor == other.IdEmissor ||
                    this.IdEmissor != null &&
                    this.IdEmissor.Equals(other.IdEmissor)
                ) && 
                (
                    this.Login == other.Login ||
                    this.Login != null &&
                    this.Login.Equals(other.Login)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.Perfis == other.Perfis ||
                    this.Perfis != null &&
                    this.Perfis.SequenceEqual(other.Perfis)
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
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.IdEmissor != null)
                    hash = hash * 59 + this.IdEmissor.GetHashCode();
                
                if (this.Login != null)
                    hash = hash * 59 + this.Login.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Perfis != null)
                    hash = hash * 59 + this.Perfis.GetHashCode();
                
                return hash;
            }
        }

    }
}
