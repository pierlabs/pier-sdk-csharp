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
    public partial class UsuarioPersist :  IEquatable<UsuarioPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioPersist" /> class.
        /// Initializes a new instance of the <see cref="UsuarioPersist" />class.
        /// </summary>
        /// <param name="Nome">Apresenta o nome do usu\u00E1rio.</param>
        /// <param name="Login">Apresenta o login do usu\u00E1rio (required).</param>
        /// <param name="Cpf">Cpf do usu\u00E1rio.</param>
        /// <param name="Email">Apresenta o email do usu\u00E1rio (required).</param>
        /// <param name="Senha">Apresenta a senha do usu\u00E1rio (required).</param>
        /// <param name="DataValidade">Data de Validade.</param>
        /// <param name="IdPlataforma">C\u00F3d. de identifica\u00E7a\u00F5 da plataforma.</param>

        public UsuarioPersist(string Nome = null, string Login = null, string Cpf = null, string Email = null, string Senha = null, string DataValidade = null, long? IdPlataforma = null)
        {
            // to ensure "Login" is required (not null)
            if (Login == null)
            {
                throw new InvalidDataException("Login is a required property for UsuarioPersist and cannot be null");
            }
            else
            {
                this.Login = Login;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for UsuarioPersist and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            // to ensure "Senha" is required (not null)
            if (Senha == null)
            {
                throw new InvalidDataException("Senha is a required property for UsuarioPersist and cannot be null");
            }
            else
            {
                this.Senha = Senha;
            }
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.DataValidade = DataValidade;
            this.IdPlataforma = IdPlataforma;
            
        }
        
    
        /// <summary>
        /// Apresenta o nome do usu\u00E1rio
        /// </summary>
        /// <value>Apresenta o nome do usu\u00E1rio</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Apresenta o login do usu\u00E1rio
        /// </summary>
        /// <value>Apresenta o login do usu\u00E1rio</value>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }
    
        /// <summary>
        /// Cpf do usu\u00E1rio
        /// </summary>
        /// <value>Cpf do usu\u00E1rio</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// Apresenta o email do usu\u00E1rio
        /// </summary>
        /// <value>Apresenta o email do usu\u00E1rio</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Apresenta a senha do usu\u00E1rio
        /// </summary>
        /// <value>Apresenta a senha do usu\u00E1rio</value>
        [DataMember(Name="senha", EmitDefaultValue=false)]
        public string Senha { get; set; }
    
        /// <summary>
        /// Data de Validade
        /// </summary>
        /// <value>Data de Validade</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// C\u00F3d. de identifica\u00E7a\u00F5 da plataforma
        /// </summary>
        /// <value>C\u00F3d. de identifica\u00E7a\u00F5 da plataforma</value>
        [DataMember(Name="idPlataforma", EmitDefaultValue=false)]
        public long? IdPlataforma { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsuarioPersist {\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Senha: ").Append(Senha).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            sb.Append("  IdPlataforma: ").Append(IdPlataforma).Append("\n");
            
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
            return this.Equals(obj as UsuarioPersist);
        }

        /// <summary>
        /// Returns true if UsuarioPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of UsuarioPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsuarioPersist other)
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
                    this.Senha == other.Senha ||
                    this.Senha != null &&
                    this.Senha.Equals(other.Senha)
                ) && 
                (
                    this.DataValidade == other.DataValidade ||
                    this.DataValidade != null &&
                    this.DataValidade.Equals(other.DataValidade)
                ) && 
                (
                    this.IdPlataforma == other.IdPlataforma ||
                    this.IdPlataforma != null &&
                    this.IdPlataforma.Equals(other.IdPlataforma)
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
                
                if (this.Senha != null)
                    hash = hash * 59 + this.Senha.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                if (this.IdPlataforma != null)
                    hash = hash * 59 + this.IdPlataforma.GetHashCode();
                
                return hash;
            }
        }

    }
}
