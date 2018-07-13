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
    /// {{{usuario_persistencia_descricao}}}
    /// </summary>
    [DataContract]
    public partial class UsuarioPersistencia :  IEquatable<UsuarioPersistencia>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioPersistencia" /> class.
        /// Initializes a new instance of the <see cref="UsuarioPersistencia" />class.
        /// </summary>
        /// <param name="Nome">{{{usuario_persistencia_nome_descricao}}}.</param>
        /// <param name="Login">{{{usuario_persistencia_login_descricao}}}.</param>
        /// <param name="Cpf">{{{usuario_persistencia_cpf_descricao}}}.</param>
        /// <param name="Email">{{{usuario_persistencia_email_descricao}}}.</param>
        /// <param name="Senha">{{{usuario_persistencia_senha_descricao}}}.</param>
        /// <param name="DataValidade">{{{usuario_persistencia_data_validade_descricao}}}.</param>
        /// <param name="IdPlataforma">{{{usuario_persistencia_id_plataforma_descricao}}}.</param>

        public UsuarioPersistencia(string Nome = null, string Login = null, string Cpf = null, string Email = null, string Senha = null, string DataValidade = null, long? IdPlataforma = null)
        {
            this.Nome = Nome;
            this.Login = Login;
            this.Cpf = Cpf;
            this.Email = Email;
            this.Senha = Senha;
            this.DataValidade = DataValidade;
            this.IdPlataforma = IdPlataforma;
            
        }
        
    
        /// <summary>
        /// {{{usuario_persistencia_nome_descricao}}}
        /// </summary>
        /// <value>{{{usuario_persistencia_nome_descricao}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// {{{usuario_persistencia_login_descricao}}}
        /// </summary>
        /// <value>{{{usuario_persistencia_login_descricao}}}</value>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }
    
        /// <summary>
        /// {{{usuario_persistencia_cpf_descricao}}}
        /// </summary>
        /// <value>{{{usuario_persistencia_cpf_descricao}}}</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// {{{usuario_persistencia_email_descricao}}}
        /// </summary>
        /// <value>{{{usuario_persistencia_email_descricao}}}</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// {{{usuario_persistencia_senha_descricao}}}
        /// </summary>
        /// <value>{{{usuario_persistencia_senha_descricao}}}</value>
        [DataMember(Name="senha", EmitDefaultValue=false)]
        public string Senha { get; set; }
    
        /// <summary>
        /// {{{usuario_persistencia_data_validade_descricao}}}
        /// </summary>
        /// <value>{{{usuario_persistencia_data_validade_descricao}}}</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// {{{usuario_persistencia_id_plataforma_descricao}}}
        /// </summary>
        /// <value>{{{usuario_persistencia_id_plataforma_descricao}}}</value>
        [DataMember(Name="idPlataforma", EmitDefaultValue=false)]
        public long? IdPlataforma { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsuarioPersistencia {\n");
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
            return this.Equals(obj as UsuarioPersistencia);
        }

        /// <summary>
        /// Returns true if UsuarioPersistencia instances are equal
        /// </summary>
        /// <param name="other">Instance of UsuarioPersistencia to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsuarioPersistencia other)
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
