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
    /// Objeto log acesso usu\u00E1rio
    /// </summary>
    [DataContract]
    public partial class LogAcessoUsuarioPersist :  IEquatable<LogAcessoUsuarioPersist>
    { 
    
        /// <summary>
        /// Situa\u00E7\u00E3o do Log
        /// </summary>
        /// <value>Situa\u00E7\u00E3o do Log</value>
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
        /// Situa\u00E7\u00E3o do Log
        /// </summary>
        /// <value>Situa\u00E7\u00E3o do Log</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LogAcessoUsuarioPersist" /> class.
        /// Initializes a new instance of the <see cref="LogAcessoUsuarioPersist" />class.
        /// </summary>
        /// <param name="IdUsuario">C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id) (required).</param>
        /// <param name="Login">Login do Usu\u00E1rio (required).</param>
        /// <param name="Mensagem">Mensagem do log.</param>
        /// <param name="VersaoAPP">Vers\u00E2o do aplicativo.</param>
        /// <param name="Device">Opera\u00E7\u00E3o do dispositivo.</param>
        /// <param name="SenhaOK">Status da senha.</param>
        /// <param name="TentativasIncorretas">Quantidade de tentativas incorretas.</param>
        /// <param name="IdPlataforma">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id).</param>
        /// <param name="Status">Situa\u00E7\u00E3o do Log.</param>

        public LogAcessoUsuarioPersist(long? IdUsuario = null, string Login = null, string Mensagem = null, string VersaoAPP = null, string Device = null, int? SenhaOK = null, long? TentativasIncorretas = null, long? IdPlataforma = null, StatusEnum? Status = null)
        {
            // to ensure "IdUsuario" is required (not null)
            if (IdUsuario == null)
            {
                throw new InvalidDataException("IdUsuario is a required property for LogAcessoUsuarioPersist and cannot be null");
            }
            else
            {
                this.IdUsuario = IdUsuario;
            }
            // to ensure "Login" is required (not null)
            if (Login == null)
            {
                throw new InvalidDataException("Login is a required property for LogAcessoUsuarioPersist and cannot be null");
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
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Usu\u00E1rio (id)</value>
        [DataMember(Name="idUsuario", EmitDefaultValue=false)]
        public long? IdUsuario { get; set; }
    
        /// <summary>
        /// Login do Usu\u00E1rio
        /// </summary>
        /// <value>Login do Usu\u00E1rio</value>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }
    
        /// <summary>
        /// Mensagem do log
        /// </summary>
        /// <value>Mensagem do log</value>
        [DataMember(Name="mensagem", EmitDefaultValue=false)]
        public string Mensagem { get; set; }
    
        /// <summary>
        /// Vers\u00E2o do aplicativo
        /// </summary>
        /// <value>Vers\u00E2o do aplicativo</value>
        [DataMember(Name="versaoAPP", EmitDefaultValue=false)]
        public string VersaoAPP { get; set; }
    
        /// <summary>
        /// Opera\u00E7\u00E3o do dispositivo
        /// </summary>
        /// <value>Opera\u00E7\u00E3o do dispositivo</value>
        [DataMember(Name="device", EmitDefaultValue=false)]
        public string Device { get; set; }
    
        /// <summary>
        /// Status da senha
        /// </summary>
        /// <value>Status da senha</value>
        [DataMember(Name="senhaOK", EmitDefaultValue=false)]
        public int? SenhaOK { get; set; }
    
        /// <summary>
        /// Quantidade de tentativas incorretas
        /// </summary>
        /// <value>Quantidade de tentativas incorretas</value>
        [DataMember(Name="tentativasIncorretas", EmitDefaultValue=false)]
        public long? TentativasIncorretas { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</value>
        [DataMember(Name="idPlataforma", EmitDefaultValue=false)]
        public long? IdPlataforma { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogAcessoUsuarioPersist {\n");
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
            return this.Equals(obj as LogAcessoUsuarioPersist);
        }

        /// <summary>
        /// Returns true if LogAcessoUsuarioPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of LogAcessoUsuarioPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogAcessoUsuarioPersist other)
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
