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
    /// Object User
    /// </summary>
    [DataContract]
    public partial class UserUpdate :  IEquatable<UserUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserUpdate" /> class.
        /// Initializes a new instance of the <see cref="UserUpdate" />class.
        /// </summary>
        /// <param name="Nome">Present the username.</param>
        /// <param name="Login">Show the user login (required).</param>
        /// <param name="Cpf">User CPF.</param>
        /// <param name="Email">Show the email of the user (required).</param>
        /// <param name="Status">User Status.</param>
        /// <param name="BloquearAcesso">Indicates if the access to the app of the user is blocked.</param>

        public UserUpdate(string Nome = null, string Login = null, string Cpf = null, string Email = null, string Status = null, bool? BloquearAcesso = null)
        {
            // to ensure "Login" is required (not null)
            if (Login == null)
            {
                throw new InvalidDataException("Login is a required property for UserUpdate and cannot be null");
            }
            else
            {
                this.Login = Login;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for UserUpdate and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Status = Status;
            this.BloquearAcesso = BloquearAcesso;
            
        }
        
    
        /// <summary>
        /// Present the username
        /// </summary>
        /// <value>Present the username</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Show the user login
        /// </summary>
        /// <value>Show the user login</value>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }
    
        /// <summary>
        /// User CPF
        /// </summary>
        /// <value>User CPF</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// Show the email of the user
        /// </summary>
        /// <value>Show the email of the user</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// User Status
        /// </summary>
        /// <value>User Status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Indicates if the access to the app of the user is blocked
        /// </summary>
        /// <value>Indicates if the access to the app of the user is blocked</value>
        [DataMember(Name="bloquearAcesso", EmitDefaultValue=false)]
        public bool? BloquearAcesso { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserUpdate {\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  BloquearAcesso: ").Append(BloquearAcesso).Append("\n");
            
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
            return this.Equals(obj as UserUpdate);
        }

        /// <summary>
        /// Returns true if UserUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of UserUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserUpdate other)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.BloquearAcesso == other.BloquearAcesso ||
                    this.BloquearAcesso != null &&
                    this.BloquearAcesso.Equals(other.BloquearAcesso)
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.BloquearAcesso != null)
                    hash = hash * 59 + this.BloquearAcesso.GetHashCode();
                
                return hash;
            }
        }

    }
}
