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
    /// {{{usuario_response_description}}}
    /// </summary>
    [DataContract]
    public partial class UsuarioResponse :  IEquatable<UsuarioResponse>
    { 
    
        /// <summary>
        /// {{{usuario_response_status_value}}}
        /// </summary>
        /// <value>{{{usuario_response_status_value}}}</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "INATIVO")]
            Inativo,
            
            [EnumMember(Value = "ATIVO")]
            Ativo
        }

    
        /// <summary>
        /// {{{usuario_response_status_value}}}
        /// </summary>
        /// <value>{{{usuario_response_status_value}}}</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioResponse" /> class.
        /// Initializes a new instance of the <see cref="UsuarioResponse" />class.
        /// </summary>
        /// <param name="Id">{{{usuario_response_id_value}}}.</param>
        /// <param name="Nome">{{{usuario_response_nome_value}}}.</param>
        /// <param name="Login">{{{usuario_response_login_value}}} (required).</param>
        /// <param name="IdEmissor">{{{usuario_response_id_emissor_value}}}.</param>
        /// <param name="Cpf">{{{usuario_response_cpf_value}}}.</param>
        /// <param name="Email">{{{usuario_response_email_value}}} (required).</param>
        /// <param name="Status">{{{usuario_response_status_value}}}.</param>
        /// <param name="DataCriacao">{{{usuario_response_data_criacao_value}}}.</param>
        /// <param name="DataModificacao">{{{usuario_response_data_modificacao_value}}}.</param>
        /// <param name="TentativasIncorretas">{{{usuario_response_tentativas_incorretas_value}}}.</param>
        /// <param name="BloquearAcesso">{{{usuario_response_bloquear_acesso_descricao}}}.</param>
        /// <param name="DataValidade">{{{usuario_response_data_validade_value}}}.</param>
        /// <param name="IdPlataforma">{{{usuario_response_id_plataforma_value}}}.</param>

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
        /// {{{usuario_response_id_value}}}
        /// </summary>
        /// <value>{{{usuario_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{usuario_response_nome_value}}}
        /// </summary>
        /// <value>{{{usuario_response_nome_value}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// {{{usuario_response_login_value}}}
        /// </summary>
        /// <value>{{{usuario_response_login_value}}}</value>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }
    
        /// <summary>
        /// {{{usuario_response_id_emissor_value}}}
        /// </summary>
        /// <value>{{{usuario_response_id_emissor_value}}}</value>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public long? IdEmissor { get; set; }
    
        /// <summary>
        /// {{{usuario_response_cpf_value}}}
        /// </summary>
        /// <value>{{{usuario_response_cpf_value}}}</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// {{{usuario_response_email_value}}}
        /// </summary>
        /// <value>{{{usuario_response_email_value}}}</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// {{{usuario_response_data_criacao_value}}}
        /// </summary>
        /// <value>{{{usuario_response_data_criacao_value}}}</value>
        [DataMember(Name="dataCriacao", EmitDefaultValue=false)]
        public string DataCriacao { get; set; }
    
        /// <summary>
        /// {{{usuario_response_data_modificacao_value}}}
        /// </summary>
        /// <value>{{{usuario_response_data_modificacao_value}}}</value>
        [DataMember(Name="dataModificacao", EmitDefaultValue=false)]
        public string DataModificacao { get; set; }
    
        /// <summary>
        /// {{{usuario_response_tentativas_incorretas_value}}}
        /// </summary>
        /// <value>{{{usuario_response_tentativas_incorretas_value}}}</value>
        [DataMember(Name="tentativasIncorretas", EmitDefaultValue=false)]
        public long? TentativasIncorretas { get; set; }
    
        /// <summary>
        /// {{{usuario_response_bloquear_acesso_descricao}}}
        /// </summary>
        /// <value>{{{usuario_response_bloquear_acesso_descricao}}}</value>
        [DataMember(Name="bloquearAcesso", EmitDefaultValue=false)]
        public bool? BloquearAcesso { get; set; }
    
        /// <summary>
        /// {{{usuario_response_data_validade_value}}}
        /// </summary>
        /// <value>{{{usuario_response_data_validade_value}}}</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// {{{usuario_response_id_plataforma_value}}}
        /// </summary>
        /// <value>{{{usuario_response_id_plataforma_value}}}</value>
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
