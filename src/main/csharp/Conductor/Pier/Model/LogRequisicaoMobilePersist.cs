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
    /// Objeto de persist\u00EAncia de um log de requisi\u00E7\u00E3o mobile
    /// </summary>
    [DataContract]
    public partial class LogRequisicaoMobilePersist :  IEquatable<LogRequisicaoMobilePersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LogRequisicaoMobilePersist" /> class.
        /// Initializes a new instance of the <see cref="LogRequisicaoMobilePersist" />class.
        /// </summary>
        /// <param name="Metodo">M\u00E9todo onde o c\u00F3digo \u00E9 executado (required).</param>
        /// <param name="DataHoraRequisicao">Data e hora que o m\u00E9todo \u00E9 acessado (required).</param>
        /// <param name="IdRequisicao">Identificador da requisi\u00E7\u00E3o.</param>
        /// <param name="Login">Login do usu\u00E1rio.</param>
        /// <param name="Cpf">N\u00FAmero do cpf do usu\u00E1rio.</param>
        /// <param name="AppVersion">Vers\u00E3o da aplica\u00E7\u00E3o.</param>
        /// <param name="DeviceId">Identifica\u00E7\u00E3o do dispositivo.</param>
        /// <param name="PhoneId">Identifica\u00E7\u00E3o do mobile.</param>
        /// <param name="IdChave">Identifica\u00E7\u00E3o da chave.</param>
        /// <param name="IdPlataforma">Identifica\u00E7\u00E3o da plataforma.</param>
        /// <param name="UserAgent">Agente de usu\u00E1rio.</param>
        /// <param name="MarcaCelular">Marca do celular.</param>
        /// <param name="ModeloCelular">Modelo do celular.</param>
        /// <param name="Latitude">Latitude do celular acessado.</param>
        /// <param name="Longitude">Longitude do celular acessado.</param>
        /// <param name="CodigoRetorno">C\u00F3digo de retorno.</param>
        /// <param name="IdProposta">Identifica\u00E7\u00E3o da proposta.</param>
        /// <param name="IdConta">Identifica\u00E7\u00E3o da conta.</param>
        /// <param name="InformacaoAdicional">Informa\u00E7\u00F5es complementares.</param>

        public LogRequisicaoMobilePersist(string Metodo = null, string DataHoraRequisicao = null, long? IdRequisicao = null, string Login = null, string Cpf = null, string AppVersion = null, string DeviceId = null, string PhoneId = null, long? IdChave = null, long? IdPlataforma = null, string UserAgent = null, string MarcaCelular = null, string ModeloCelular = null, string Latitude = null, string Longitude = null, int? CodigoRetorno = null, long? IdProposta = null, long? IdConta = null, string InformacaoAdicional = null)
        {
            // to ensure "Metodo" is required (not null)
            if (Metodo == null)
            {
                throw new InvalidDataException("Metodo is a required property for LogRequisicaoMobilePersist and cannot be null");
            }
            else
            {
                this.Metodo = Metodo;
            }
            // to ensure "DataHoraRequisicao" is required (not null)
            if (DataHoraRequisicao == null)
            {
                throw new InvalidDataException("DataHoraRequisicao is a required property for LogRequisicaoMobilePersist and cannot be null");
            }
            else
            {
                this.DataHoraRequisicao = DataHoraRequisicao;
            }
            this.IdRequisicao = IdRequisicao;
            this.Login = Login;
            this.Cpf = Cpf;
            this.AppVersion = AppVersion;
            this.DeviceId = DeviceId;
            this.PhoneId = PhoneId;
            this.IdChave = IdChave;
            this.IdPlataforma = IdPlataforma;
            this.UserAgent = UserAgent;
            this.MarcaCelular = MarcaCelular;
            this.ModeloCelular = ModeloCelular;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            this.CodigoRetorno = CodigoRetorno;
            this.IdProposta = IdProposta;
            this.IdConta = IdConta;
            this.InformacaoAdicional = InformacaoAdicional;
            
        }
        
    
        /// <summary>
        /// M\u00E9todo onde o c\u00F3digo \u00E9 executado
        /// </summary>
        /// <value>M\u00E9todo onde o c\u00F3digo \u00E9 executado</value>
        [DataMember(Name="metodo", EmitDefaultValue=false)]
        public string Metodo { get; set; }
    
        /// <summary>
        /// Data e hora que o m\u00E9todo \u00E9 acessado
        /// </summary>
        /// <value>Data e hora que o m\u00E9todo \u00E9 acessado</value>
        [DataMember(Name="dataHoraRequisicao", EmitDefaultValue=false)]
        public string DataHoraRequisicao { get; set; }
    
        /// <summary>
        /// Identificador da requisi\u00E7\u00E3o
        /// </summary>
        /// <value>Identificador da requisi\u00E7\u00E3o</value>
        [DataMember(Name="idRequisicao", EmitDefaultValue=false)]
        public long? IdRequisicao { get; set; }
    
        /// <summary>
        /// Login do usu\u00E1rio
        /// </summary>
        /// <value>Login do usu\u00E1rio</value>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }
    
        /// <summary>
        /// N\u00FAmero do cpf do usu\u00E1rio
        /// </summary>
        /// <value>N\u00FAmero do cpf do usu\u00E1rio</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// Vers\u00E3o da aplica\u00E7\u00E3o
        /// </summary>
        /// <value>Vers\u00E3o da aplica\u00E7\u00E3o</value>
        [DataMember(Name="appVersion", EmitDefaultValue=false)]
        public string AppVersion { get; set; }
    
        /// <summary>
        /// Identifica\u00E7\u00E3o do dispositivo
        /// </summary>
        /// <value>Identifica\u00E7\u00E3o do dispositivo</value>
        [DataMember(Name="deviceId", EmitDefaultValue=false)]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Identifica\u00E7\u00E3o do mobile
        /// </summary>
        /// <value>Identifica\u00E7\u00E3o do mobile</value>
        [DataMember(Name="phoneId", EmitDefaultValue=false)]
        public string PhoneId { get; set; }
    
        /// <summary>
        /// Identifica\u00E7\u00E3o da chave
        /// </summary>
        /// <value>Identifica\u00E7\u00E3o da chave</value>
        [DataMember(Name="idChave", EmitDefaultValue=false)]
        public long? IdChave { get; set; }
    
        /// <summary>
        /// Identifica\u00E7\u00E3o da plataforma
        /// </summary>
        /// <value>Identifica\u00E7\u00E3o da plataforma</value>
        [DataMember(Name="idPlataforma", EmitDefaultValue=false)]
        public long? IdPlataforma { get; set; }
    
        /// <summary>
        /// Agente de usu\u00E1rio
        /// </summary>
        /// <value>Agente de usu\u00E1rio</value>
        [DataMember(Name="userAgent", EmitDefaultValue=false)]
        public string UserAgent { get; set; }
    
        /// <summary>
        /// Marca do celular
        /// </summary>
        /// <value>Marca do celular</value>
        [DataMember(Name="marcaCelular", EmitDefaultValue=false)]
        public string MarcaCelular { get; set; }
    
        /// <summary>
        /// Modelo do celular
        /// </summary>
        /// <value>Modelo do celular</value>
        [DataMember(Name="modeloCelular", EmitDefaultValue=false)]
        public string ModeloCelular { get; set; }
    
        /// <summary>
        /// Latitude do celular acessado
        /// </summary>
        /// <value>Latitude do celular acessado</value>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public string Latitude { get; set; }
    
        /// <summary>
        /// Longitude do celular acessado
        /// </summary>
        /// <value>Longitude do celular acessado</value>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public string Longitude { get; set; }
    
        /// <summary>
        /// C\u00F3digo de retorno
        /// </summary>
        /// <value>C\u00F3digo de retorno</value>
        [DataMember(Name="codigoRetorno", EmitDefaultValue=false)]
        public int? CodigoRetorno { get; set; }
    
        /// <summary>
        /// Identifica\u00E7\u00E3o da proposta
        /// </summary>
        /// <value>Identifica\u00E7\u00E3o da proposta</value>
        [DataMember(Name="idProposta", EmitDefaultValue=false)]
        public long? IdProposta { get; set; }
    
        /// <summary>
        /// Identifica\u00E7\u00E3o da conta
        /// </summary>
        /// <value>Identifica\u00E7\u00E3o da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Informa\u00E7\u00F5es complementares
        /// </summary>
        /// <value>Informa\u00E7\u00F5es complementares</value>
        [DataMember(Name="informacaoAdicional", EmitDefaultValue=false)]
        public string InformacaoAdicional { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogRequisicaoMobilePersist {\n");
            sb.Append("  Metodo: ").Append(Metodo).Append("\n");
            sb.Append("  DataHoraRequisicao: ").Append(DataHoraRequisicao).Append("\n");
            sb.Append("  IdRequisicao: ").Append(IdRequisicao).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  PhoneId: ").Append(PhoneId).Append("\n");
            sb.Append("  IdChave: ").Append(IdChave).Append("\n");
            sb.Append("  IdPlataforma: ").Append(IdPlataforma).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
            sb.Append("  MarcaCelular: ").Append(MarcaCelular).Append("\n");
            sb.Append("  ModeloCelular: ").Append(ModeloCelular).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  CodigoRetorno: ").Append(CodigoRetorno).Append("\n");
            sb.Append("  IdProposta: ").Append(IdProposta).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  InformacaoAdicional: ").Append(InformacaoAdicional).Append("\n");
            
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
            return this.Equals(obj as LogRequisicaoMobilePersist);
        }

        /// <summary>
        /// Returns true if LogRequisicaoMobilePersist instances are equal
        /// </summary>
        /// <param name="other">Instance of LogRequisicaoMobilePersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogRequisicaoMobilePersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Metodo == other.Metodo ||
                    this.Metodo != null &&
                    this.Metodo.Equals(other.Metodo)
                ) && 
                (
                    this.DataHoraRequisicao == other.DataHoraRequisicao ||
                    this.DataHoraRequisicao != null &&
                    this.DataHoraRequisicao.Equals(other.DataHoraRequisicao)
                ) && 
                (
                    this.IdRequisicao == other.IdRequisicao ||
                    this.IdRequisicao != null &&
                    this.IdRequisicao.Equals(other.IdRequisicao)
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
                    this.AppVersion == other.AppVersion ||
                    this.AppVersion != null &&
                    this.AppVersion.Equals(other.AppVersion)
                ) && 
                (
                    this.DeviceId == other.DeviceId ||
                    this.DeviceId != null &&
                    this.DeviceId.Equals(other.DeviceId)
                ) && 
                (
                    this.PhoneId == other.PhoneId ||
                    this.PhoneId != null &&
                    this.PhoneId.Equals(other.PhoneId)
                ) && 
                (
                    this.IdChave == other.IdChave ||
                    this.IdChave != null &&
                    this.IdChave.Equals(other.IdChave)
                ) && 
                (
                    this.IdPlataforma == other.IdPlataforma ||
                    this.IdPlataforma != null &&
                    this.IdPlataforma.Equals(other.IdPlataforma)
                ) && 
                (
                    this.UserAgent == other.UserAgent ||
                    this.UserAgent != null &&
                    this.UserAgent.Equals(other.UserAgent)
                ) && 
                (
                    this.MarcaCelular == other.MarcaCelular ||
                    this.MarcaCelular != null &&
                    this.MarcaCelular.Equals(other.MarcaCelular)
                ) && 
                (
                    this.ModeloCelular == other.ModeloCelular ||
                    this.ModeloCelular != null &&
                    this.ModeloCelular.Equals(other.ModeloCelular)
                ) && 
                (
                    this.Latitude == other.Latitude ||
                    this.Latitude != null &&
                    this.Latitude.Equals(other.Latitude)
                ) && 
                (
                    this.Longitude == other.Longitude ||
                    this.Longitude != null &&
                    this.Longitude.Equals(other.Longitude)
                ) && 
                (
                    this.CodigoRetorno == other.CodigoRetorno ||
                    this.CodigoRetorno != null &&
                    this.CodigoRetorno.Equals(other.CodigoRetorno)
                ) && 
                (
                    this.IdProposta == other.IdProposta ||
                    this.IdProposta != null &&
                    this.IdProposta.Equals(other.IdProposta)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.InformacaoAdicional == other.InformacaoAdicional ||
                    this.InformacaoAdicional != null &&
                    this.InformacaoAdicional.Equals(other.InformacaoAdicional)
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
                
                if (this.Metodo != null)
                    hash = hash * 59 + this.Metodo.GetHashCode();
                
                if (this.DataHoraRequisicao != null)
                    hash = hash * 59 + this.DataHoraRequisicao.GetHashCode();
                
                if (this.IdRequisicao != null)
                    hash = hash * 59 + this.IdRequisicao.GetHashCode();
                
                if (this.Login != null)
                    hash = hash * 59 + this.Login.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                if (this.AppVersion != null)
                    hash = hash * 59 + this.AppVersion.GetHashCode();
                
                if (this.DeviceId != null)
                    hash = hash * 59 + this.DeviceId.GetHashCode();
                
                if (this.PhoneId != null)
                    hash = hash * 59 + this.PhoneId.GetHashCode();
                
                if (this.IdChave != null)
                    hash = hash * 59 + this.IdChave.GetHashCode();
                
                if (this.IdPlataforma != null)
                    hash = hash * 59 + this.IdPlataforma.GetHashCode();
                
                if (this.UserAgent != null)
                    hash = hash * 59 + this.UserAgent.GetHashCode();
                
                if (this.MarcaCelular != null)
                    hash = hash * 59 + this.MarcaCelular.GetHashCode();
                
                if (this.ModeloCelular != null)
                    hash = hash * 59 + this.ModeloCelular.GetHashCode();
                
                if (this.Latitude != null)
                    hash = hash * 59 + this.Latitude.GetHashCode();
                
                if (this.Longitude != null)
                    hash = hash * 59 + this.Longitude.GetHashCode();
                
                if (this.CodigoRetorno != null)
                    hash = hash * 59 + this.CodigoRetorno.GetHashCode();
                
                if (this.IdProposta != null)
                    hash = hash * 59 + this.IdProposta.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.InformacaoAdicional != null)
                    hash = hash * 59 + this.InformacaoAdicional.GetHashCode();
                
                return hash;
            }
        }

    }
}
