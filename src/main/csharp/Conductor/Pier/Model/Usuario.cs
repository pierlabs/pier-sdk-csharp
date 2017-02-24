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
    /// Representa\u00C3\u00A7\u00C3\u00A3o do recurso Usuario
    /// </summary>
    [DataContract]
    public partial class Usuario :  IEquatable<Usuario>
    { 
    
        /// <summary>
        /// Status do Usu\u00C3\u00A1rio
        /// </summary>
        /// <value>Status do Usu\u00C3\u00A1rio</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "ATIVO")]
            Ativo,
            
            [EnumMember(Value = "INATIVO")]
            Inativo
        }

    
        /// <summary>
        /// Status do Usu\u00C3\u00A1rio
        /// </summary>
        /// <value>Status do Usu\u00C3\u00A1rio</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Usuario" /> class.
        /// Initializes a new instance of the <see cref="Usuario" />class.
        /// </summary>
        /// <param name="Id">Id do Usu\u00C3\u00A1rio (required).</param>
        /// <param name="Nome">Nome do Usu\u00C3\u00A1rio.</param>
        /// <param name="Login">Login do Usu\u00C3\u00A1rio (required).</param>
        /// <param name="IdEmissor">Id do emissor do usu\u00C3\u00A1rio.</param>
        /// <param name="Cpf">CPF do Usu\u00C3\u00A1rio.</param>
        /// <param name="Email">Email do Usu\u00C3\u00A1rio (required).</param>
        /// <param name="Senha">Apresenta a senha do usu\u00C3\u00A1rio..</param>
        /// <param name="Status">Status do Usu\u00C3\u00A1rio.</param>
        /// <param name="DataCriacao">Status do Usu\u00C3\u00A1rio.</param>
        /// <param name="DataModificacao">Status do Usu\u00C3\u00A1rio.</param>
        /// <param name="TentativasIncorretas">N\u00C3\u00BAmero de tentativas de valida\u00C3\u00A7\u00C3\u00A3o incorretas.</param>

        public Usuario(long? Id = null, string Nome = null, string Login = null, long? IdEmissor = null, string Cpf = null, string Email = null, string Senha = null, StatusEnum? Status = null, DateTime? DataCriacao = null, DateTime? DataModificacao = null, long? TentativasIncorretas = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for Usuario and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Login" is required (not null)
            if (Login == null)
            {
                throw new InvalidDataException("Login is a required property for Usuario and cannot be null");
            }
            else
            {
                this.Login = Login;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for Usuario and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            this.Nome = Nome;
            this.IdEmissor = IdEmissor;
            this.Cpf = Cpf;
            this.Senha = Senha;
            this.Status = Status;
            this.DataCriacao = DataCriacao;
            this.DataModificacao = DataModificacao;
            this.TentativasIncorretas = TentativasIncorretas;
            
        }
        
    
        /// <summary>
        /// Id do Usu\u00C3\u00A1rio
        /// </summary>
        /// <value>Id do Usu\u00C3\u00A1rio</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Nome do Usu\u00C3\u00A1rio
        /// </summary>
        /// <value>Nome do Usu\u00C3\u00A1rio</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Login do Usu\u00C3\u00A1rio
        /// </summary>
        /// <value>Login do Usu\u00C3\u00A1rio</value>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }
    
        /// <summary>
        /// Id do emissor do usu\u00C3\u00A1rio
        /// </summary>
        /// <value>Id do emissor do usu\u00C3\u00A1rio</value>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public long? IdEmissor { get; set; }
    
        /// <summary>
        /// CPF do Usu\u00C3\u00A1rio
        /// </summary>
        /// <value>CPF do Usu\u00C3\u00A1rio</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// Email do Usu\u00C3\u00A1rio
        /// </summary>
        /// <value>Email do Usu\u00C3\u00A1rio</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Apresenta a senha do usu\u00C3\u00A1rio.
        /// </summary>
        /// <value>Apresenta a senha do usu\u00C3\u00A1rio.</value>
        [DataMember(Name="senha", EmitDefaultValue=false)]
        public string Senha { get; set; }
    
        /// <summary>
        /// Status do Usu\u00C3\u00A1rio
        /// </summary>
        /// <value>Status do Usu\u00C3\u00A1rio</value>
        [DataMember(Name="dataCriacao", EmitDefaultValue=false)]
        public DateTime? DataCriacao { get; set; }
    
        /// <summary>
        /// Status do Usu\u00C3\u00A1rio
        /// </summary>
        /// <value>Status do Usu\u00C3\u00A1rio</value>
        [DataMember(Name="dataModificacao", EmitDefaultValue=false)]
        public DateTime? DataModificacao { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero de tentativas de valida\u00C3\u00A7\u00C3\u00A3o incorretas
        /// </summary>
        /// <value>N\u00C3\u00BAmero de tentativas de valida\u00C3\u00A7\u00C3\u00A3o incorretas</value>
        [DataMember(Name="tentativasIncorretas", EmitDefaultValue=false)]
        public long? TentativasIncorretas { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Usuario {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  IdEmissor: ").Append(IdEmissor).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Senha: ").Append(Senha).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DataCriacao: ").Append(DataCriacao).Append("\n");
            sb.Append("  DataModificacao: ").Append(DataModificacao).Append("\n");
            sb.Append("  TentativasIncorretas: ").Append(TentativasIncorretas).Append("\n");
            
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
            return this.Equals(obj as Usuario);
        }

        /// <summary>
        /// Returns true if Usuario instances are equal
        /// </summary>
        /// <param name="other">Instance of Usuario to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Usuario other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
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
                    this.IdEmissor == other.IdEmissor ||
                    this.IdEmissor != null &&
                    this.IdEmissor.Equals(other.IdEmissor)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.DataCriacao == other.DataCriacao ||
                    this.DataCriacao != null &&
                    this.DataCriacao.Equals(other.DataCriacao)
                ) && 
                (
                    this.DataModificacao == other.DataModificacao ||
                    this.DataModificacao != null &&
                    this.DataModificacao.Equals(other.DataModificacao)
                ) && 
                (
                    this.TentativasIncorretas == other.TentativasIncorretas ||
                    this.TentativasIncorretas != null &&
                    this.TentativasIncorretas.Equals(other.TentativasIncorretas)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Login != null)
                    hash = hash * 59 + this.Login.GetHashCode();
                
                if (this.IdEmissor != null)
                    hash = hash * 59 + this.IdEmissor.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.Senha != null)
                    hash = hash * 59 + this.Senha.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.DataCriacao != null)
                    hash = hash * 59 + this.DataCriacao.GetHashCode();
                
                if (this.DataModificacao != null)
                    hash = hash * 59 + this.DataModificacao.GetHashCode();
                
                if (this.TentativasIncorretas != null)
                    hash = hash * 59 + this.TentativasIncorretas.GetHashCode();
                
                return hash;
            }
        }

    }
}
