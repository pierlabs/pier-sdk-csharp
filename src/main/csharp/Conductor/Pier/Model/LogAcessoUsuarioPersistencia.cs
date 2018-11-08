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
    /// {{{log_acesso_usuario_persistencia_descricao}}}
    /// </summary>
    [DataContract]
    public partial class LogAcessoUsuarioPersistencia :  IEquatable<LogAcessoUsuarioPersistencia>
    { 
    
        /// <summary>
        /// {{{log_acesso_usuario_persistencia_status_log_acesso_descricao}}}
        /// </summary>
        /// <value>{{{log_acesso_usuario_persistencia_status_log_acesso_descricao}}}</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "SUCESSO")]
            Sucesso,
            
            [EnumMember(Value = "SENHA_INVALIDA")]
            SenhaInvalida,
            
            [EnumMember(Value = "BLOQUEDO")]
            Bloquedo,
            
            [EnumMember(Value = "CADASTRADO")]
            Cadastrado,
            
            [EnumMember(Value = "SENHA_ALTERADO")]
            SenhaAlterado
        }

    
        /// <summary>
        /// {{{log_acesso_usuario_persistencia_status_log_acesso_descricao}}}
        /// </summary>
        /// <value>{{{log_acesso_usuario_persistencia_status_log_acesso_descricao}}}</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LogAcessoUsuarioPersistencia" /> class.
        /// Initializes a new instance of the <see cref="LogAcessoUsuarioPersistencia" />class.
        /// </summary>
        /// <param name="IdUsuario">{{{log_acesso_usuario_persistencia_id_usuario_descricao}}} (required).</param>
        /// <param name="Login">{{{log_acesso_usuario_persistencia_login_descricao}}} (required).</param>
        /// <param name="Mensagem">{{{log_acesso_usuario_persistencia_message_descricao}}}.</param>
        /// <param name="VersaoAPP">{{{log_acesso_usuario_persistencia_versao_app_descricao}}}.</param>
        /// <param name="Device">{{{log_acesso_usuario_persistencia_device_descricao}}}.</param>
        /// <param name="SenhaOK">{{{log_acesso_usuario_persistencia_senha_ok_descricao}}}.</param>
        /// <param name="TentativasIncorretas">{{{log_acesso_usuario_persistencia_tentativas_incorretas_descricao}}}.</param>
        /// <param name="IdPlataforma">{{{log_acesso_usuario_persistencia_id_plataforma_descricao}}}.</param>
        /// <param name="Status">{{{log_acesso_usuario_persistencia_status_log_acesso_descricao}}}.</param>

        public LogAcessoUsuarioPersistencia(long? IdUsuario = null, string Login = null, string Mensagem = null, string VersaoAPP = null, string Device = null, int? SenhaOK = null, long? TentativasIncorretas = null, long? IdPlataforma = null, StatusEnum? Status = null)
        {
            // to ensure "IdUsuario" is required (not null)
            if (IdUsuario == null)
            {
                throw new InvalidDataException("IdUsuario is a required property for LogAcessoUsuarioPersistencia and cannot be null");
            }
            else
            {
                this.IdUsuario = IdUsuario;
            }
            // to ensure "Login" is required (not null)
            if (Login == null)
            {
                throw new InvalidDataException("Login is a required property for LogAcessoUsuarioPersistencia and cannot be null");
            }
            else
            {
                this.Login = Login;
            }
            this.Mensagem = Mensagem;
            this.VersaoAPP = VersaoAPP;
            this.Device = Device;
            this.SenhaOK = SenhaOK;
            this.TentativasIncorretas = TentativasIncorretas;
            this.IdPlataforma = IdPlataforma;
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// {{{log_acesso_usuario_persistencia_id_usuario_descricao}}}
        /// </summary>
        /// <value>{{{log_acesso_usuario_persistencia_id_usuario_descricao}}}</value>
        [DataMember(Name="idUsuario", EmitDefaultValue=false)]
        public long? IdUsuario { get; set; }
    
        /// <summary>
        /// {{{log_acesso_usuario_persistencia_login_descricao}}}
        /// </summary>
        /// <value>{{{log_acesso_usuario_persistencia_login_descricao}}}</value>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }
    
        /// <summary>
        /// {{{log_acesso_usuario_persistencia_message_descricao}}}
        /// </summary>
        /// <value>{{{log_acesso_usuario_persistencia_message_descricao}}}</value>
        [DataMember(Name="mensagem", EmitDefaultValue=false)]
        public string Mensagem { get; set; }
    
        /// <summary>
        /// {{{log_acesso_usuario_persistencia_versao_app_descricao}}}
        /// </summary>
        /// <value>{{{log_acesso_usuario_persistencia_versao_app_descricao}}}</value>
        [DataMember(Name="versaoAPP", EmitDefaultValue=false)]
        public string VersaoAPP { get; set; }
    
        /// <summary>
        /// {{{log_acesso_usuario_persistencia_device_descricao}}}
        /// </summary>
        /// <value>{{{log_acesso_usuario_persistencia_device_descricao}}}</value>
        [DataMember(Name="device", EmitDefaultValue=false)]
        public string Device { get; set; }
    
        /// <summary>
        /// {{{log_acesso_usuario_persistencia_senha_ok_descricao}}}
        /// </summary>
        /// <value>{{{log_acesso_usuario_persistencia_senha_ok_descricao}}}</value>
        [DataMember(Name="senhaOK", EmitDefaultValue=false)]
        public int? SenhaOK { get; set; }
    
        /// <summary>
        /// {{{log_acesso_usuario_persistencia_tentativas_incorretas_descricao}}}
        /// </summary>
        /// <value>{{{log_acesso_usuario_persistencia_tentativas_incorretas_descricao}}}</value>
        [DataMember(Name="tentativasIncorretas", EmitDefaultValue=false)]
        public long? TentativasIncorretas { get; set; }
    
        /// <summary>
        /// {{{log_acesso_usuario_persistencia_id_plataforma_descricao}}}
        /// </summary>
        /// <value>{{{log_acesso_usuario_persistencia_id_plataforma_descricao}}}</value>
        [DataMember(Name="idPlataforma", EmitDefaultValue=false)]
        public long? IdPlataforma { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogAcessoUsuarioPersistencia {\n");
            sb.Append("  IdUsuario: ").Append(IdUsuario).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Mensagem: ").Append(Mensagem).Append("\n");
            sb.Append("  VersaoAPP: ").Append(VersaoAPP).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  SenhaOK: ").Append(SenhaOK).Append("\n");
            sb.Append("  TentativasIncorretas: ").Append(TentativasIncorretas).Append("\n");
            sb.Append("  IdPlataforma: ").Append(IdPlataforma).Append("\n");
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
            return this.Equals(obj as LogAcessoUsuarioPersistencia);
        }

        /// <summary>
        /// Returns true if LogAcessoUsuarioPersistencia instances are equal
        /// </summary>
        /// <param name="other">Instance of LogAcessoUsuarioPersistencia to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogAcessoUsuarioPersistencia other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdUsuario == other.IdUsuario ||
                    this.IdUsuario != null &&
                    this.IdUsuario.Equals(other.IdUsuario)
                ) && 
                (
                    this.Login == other.Login ||
                    this.Login != null &&
                    this.Login.Equals(other.Login)
                ) && 
                (
                    this.Mensagem == other.Mensagem ||
                    this.Mensagem != null &&
                    this.Mensagem.Equals(other.Mensagem)
                ) && 
                (
                    this.VersaoAPP == other.VersaoAPP ||
                    this.VersaoAPP != null &&
                    this.VersaoAPP.Equals(other.VersaoAPP)
                ) && 
                (
                    this.Device == other.Device ||
                    this.Device != null &&
                    this.Device.Equals(other.Device)
                ) && 
                (
                    this.SenhaOK == other.SenhaOK ||
                    this.SenhaOK != null &&
                    this.SenhaOK.Equals(other.SenhaOK)
                ) && 
                (
                    this.TentativasIncorretas == other.TentativasIncorretas ||
                    this.TentativasIncorretas != null &&
                    this.TentativasIncorretas.Equals(other.TentativasIncorretas)
                ) && 
                (
                    this.IdPlataforma == other.IdPlataforma ||
                    this.IdPlataforma != null &&
                    this.IdPlataforma.Equals(other.IdPlataforma)
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
                
                if (this.IdUsuario != null)
                    hash = hash * 59 + this.IdUsuario.GetHashCode();
                
                if (this.Login != null)
                    hash = hash * 59 + this.Login.GetHashCode();
                
                if (this.Mensagem != null)
                    hash = hash * 59 + this.Mensagem.GetHashCode();
                
                if (this.VersaoAPP != null)
                    hash = hash * 59 + this.VersaoAPP.GetHashCode();
                
                if (this.Device != null)
                    hash = hash * 59 + this.Device.GetHashCode();
                
                if (this.SenhaOK != null)
                    hash = hash * 59 + this.SenhaOK.GetHashCode();
                
                if (this.TentativasIncorretas != null)
                    hash = hash * 59 + this.TentativasIncorretas.GetHashCode();
                
                if (this.IdPlataforma != null)
                    hash = hash * 59 + this.IdPlataforma.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
