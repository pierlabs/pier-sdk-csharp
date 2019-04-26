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
    /// Representa\u00E7\u00E3o do recurso Usuario
    /// </summary>
    [DataContract]
    public partial class UsuarioResponse :  IEquatable<UsuarioResponse>
    { 
    
        /// <summary>
        /// Status do Usu\u00E1rio
        /// </summary>
        /// <value>Status do Usu\u00E1rio</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "INATIVO")]
            Inativo,
            
            [EnumMember(Value = "ATIVO")]
            Ativo
        }

    
        /// <summary>
        /// Status do Usu\u00E1rio
        /// </summary>
        /// <value>Status do Usu\u00E1rio</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioResponse" /> class.
        /// Initializes a new instance of the <see cref="UsuarioResponse" />class.
        /// </summary>
        /// <param name="Id">Id do Usu\u00E1rio.</param>
        /// <param name="Nome">Nome do Usu\u00E1rio.</param>
        /// <param name="Login">Login do Usu\u00E1rio (required).</param>
        /// <param name="IdEmissor">Id do emissor do usu\u00E1rio.</param>
        /// <param name="Cpf">CPF do Usu\u00E1rio.</param>
        /// <param name="Email">Email do Usu\u00E1rio (required).</param>
        /// <param name="Status">Status do Usu\u00E1rio.</param>
        /// <param name="DataCriacao">Data de cria\u00E7\u00E3o do Usu\u00E1rio.</param>
        /// <param name="DataModificacao">Data de modifica\u00E7\u00E3o do Usu\u00E1rio.</param>
        /// <param name="TentativasIncorretas">N\u00FAmero de tentativas de valida\u00E7\u00E3o incorretas.</param>
        /// <param name="BloquearAcesso">Indica se o acesso ao aplicativo do usu\u00E1rio est\u00E1 bloqueado.</param>
        /// <param name="DataValidade">dataValidade.</param>
        /// <param name="IdPlataforma">idPlataforma.</param>

        public UsuarioResponse(long? Id = null, string Nome = null, string Login = null, long? IdEmissor = null, string Cpf = null, string Email = null, StatusEnum? Status = null, string DataCriacao = null, string DataModificacao = null, long? TentativasIncorretas = null, bool? BloquearAcesso = null, string DataValidade = null, int? IdPlataforma = null)
        {
            // to ensure "Login" is required (not null)
            if (Login == null)
            {
                throw new InvalidDataException("Login is a required property for UsuarioResponse and cannot be null");
            }
            else
            {
                this.Login = Login;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for UsuarioResponse and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            this.Id = Id;
            this.Nome = Nome;
            this.IdEmissor = IdEmissor;
            this.Cpf = Cpf;
            this.Status = Status;
            this.DataCriacao = DataCriacao;
            this.DataModificacao = DataModificacao;
            this.TentativasIncorretas = TentativasIncorretas;
            this.BloquearAcesso = BloquearAcesso;
            this.DataValidade = DataValidade;
            this.IdPlataforma = IdPlataforma;
            
        }
        
    
        /// <summary>
        /// Id do Usu\u00E1rio
        /// </summary>
        /// <value>Id do Usu\u00E1rio</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Nome do Usu\u00E1rio
        /// </summary>
        /// <value>Nome do Usu\u00E1rio</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Login do Usu\u00E1rio
        /// </summary>
        /// <value>Login do Usu\u00E1rio</value>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }
    
        /// <summary>
        /// Id do emissor do usu\u00E1rio
        /// </summary>
        /// <value>Id do emissor do usu\u00E1rio</value>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public long? IdEmissor { get; set; }
    
        /// <summary>
        /// CPF do Usu\u00E1rio
        /// </summary>
        /// <value>CPF do Usu\u00E1rio</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// Email do Usu\u00E1rio
        /// </summary>
        /// <value>Email do Usu\u00E1rio</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Data de cria\u00E7\u00E3o do Usu\u00E1rio
        /// </summary>
        /// <value>Data de cria\u00E7\u00E3o do Usu\u00E1rio</value>
        [DataMember(Name="dataCriacao", EmitDefaultValue=false)]
        public string DataCriacao { get; set; }
    
        /// <summary>
        /// Data de modifica\u00E7\u00E3o do Usu\u00E1rio
        /// </summary>
        /// <value>Data de modifica\u00E7\u00E3o do Usu\u00E1rio</value>
        [DataMember(Name="dataModificacao", EmitDefaultValue=false)]
        public string DataModificacao { get; set; }
    
        /// <summary>
        /// N\u00FAmero de tentativas de valida\u00E7\u00E3o incorretas
        /// </summary>
        /// <value>N\u00FAmero de tentativas de valida\u00E7\u00E3o incorretas</value>
        [DataMember(Name="tentativasIncorretas", EmitDefaultValue=false)]
        public long? TentativasIncorretas { get; set; }
    
        /// <summary>
        /// Indica se o acesso ao aplicativo do usu\u00E1rio est\u00E1 bloqueado
        /// </summary>
        /// <value>Indica se o acesso ao aplicativo do usu\u00E1rio est\u00E1 bloqueado</value>
        [DataMember(Name="bloquearAcesso", EmitDefaultValue=false)]
        public bool? BloquearAcesso { get; set; }
    
        /// <summary>
        /// dataValidade
        /// </summary>
        /// <value>dataValidade</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// idPlataforma
        /// </summary>
        /// <value>idPlataforma</value>
        [DataMember(Name="idPlataforma", EmitDefaultValue=false)]
        public int? IdPlataforma { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsuarioResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  IdEmissor: ").Append(IdEmissor).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DataCriacao: ").Append(DataCriacao).Append("\n");
            sb.Append("  DataModificacao: ").Append(DataModificacao).Append("\n");
            sb.Append("  TentativasIncorretas: ").Append(TentativasIncorretas).Append("\n");
            sb.Append("  BloquearAcesso: ").Append(BloquearAcesso).Append("\n");
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
            return this.Equals(obj as UsuarioResponse);
        }

        /// <summary>
        /// Returns true if UsuarioResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of UsuarioResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsuarioResponse other)
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
                ) && 
                (
                    this.BloquearAcesso == other.BloquearAcesso ||
                    this.BloquearAcesso != null &&
                    this.BloquearAcesso.Equals(other.BloquearAcesso)
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.DataCriacao != null)
                    hash = hash * 59 + this.DataCriacao.GetHashCode();
                
                if (this.DataModificacao != null)
                    hash = hash * 59 + this.DataModificacao.GetHashCode();
                
                if (this.TentativasIncorretas != null)
                    hash = hash * 59 + this.TentativasIncorretas.GetHashCode();
                
                if (this.BloquearAcesso != null)
                    hash = hash * 59 + this.BloquearAcesso.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                if (this.IdPlataforma != null)
                    hash = hash * 59 + this.IdPlataforma.GetHashCode();
                
                return hash;
            }
        }

    }
}
