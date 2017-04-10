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
    /// Objeto Usuario
    /// </summary>
    [DataContract]
    public partial class UsuarioUpdate :  IEquatable<UsuarioUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioUpdate" /> class.
        /// Initializes a new instance of the <see cref="UsuarioUpdate" />class.
        /// </summary>
        /// <param name="Nome">Apresenta o nome do usu\u00C3\u00A1rio..</param>
        /// <param name="Login">Apresenta o login do usu\u00C3\u00A1rio..</param>
        /// <param name="Cpf">N\u00C3\u00BAmero do CPF..</param>
        /// <param name="Email">Apresenta o email do usu\u00C3\u00A1rio..</param>
        /// <param name="Status">Apresenta o status do usu\u00C3\u00A1rio..</param>

        public UsuarioUpdate(string Nome = null, string Login = null, string Cpf = null, string Email = null, string Status = null)
        {
            this.Nome = Nome;
            this.Login = Login;
            this.Cpf = Cpf;
            this.Email = Email;
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// Apresenta o nome do usu\u00C3\u00A1rio.
        /// </summary>
        /// <value>Apresenta o nome do usu\u00C3\u00A1rio.</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Apresenta o login do usu\u00C3\u00A1rio.
        /// </summary>
        /// <value>Apresenta o login do usu\u00C3\u00A1rio.</value>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero do CPF.
        /// </summary>
        /// <value>N\u00C3\u00BAmero do CPF.</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// Apresenta o email do usu\u00C3\u00A1rio.
        /// </summary>
        /// <value>Apresenta o email do usu\u00C3\u00A1rio.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Apresenta o status do usu\u00C3\u00A1rio.
        /// </summary>
        /// <value>Apresenta o status do usu\u00C3\u00A1rio.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsuarioUpdate {\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(obj as UsuarioUpdate);
        }

        /// <summary>
        /// Returns true if UsuarioUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of UsuarioUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsuarioUpdate other)
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
                
                return hash;
            }
        }

    }
}
