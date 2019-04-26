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
    /// Objeto de resposta de um log de requisi\u00E7\u00E3o mobile
    /// </summary>
    [DataContract]
    public partial class LogRequisicaoMobileResponse :  IEquatable<LogRequisicaoMobileResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LogRequisicaoMobileResponse" /> class.
        /// Initializes a new instance of the <see cref="LogRequisicaoMobileResponse" />class.
        /// </summary>
        /// <param name="AppVersion">AppVersion.</param>
        /// <param name="CodigoRetorno">CodigoRetorno.</param>
        /// <param name="Cpf">Cpf.</param>
        /// <param name="DataHoraRequisicao">DataHoraRequisicao.</param>
        /// <param name="DeviceId">DeviceId.</param>
        /// <param name="Id">Id.</param>
        /// <param name="IdChave">IdChave.</param>
        /// <param name="IdConta">IdConta.</param>
        /// <param name="IdPlataforma">IdPlataforma.</param>
        /// <param name="IdProposta">IdProposta.</param>
        /// <param name="IdRequisicao">IdRequisicao.</param>
        /// <param name="InformacaoAdicional">InformacaoAdicional.</param>
        /// <param name="Latitude">Latitude.</param>
        /// <param name="Login">Login.</param>
        /// <param name="Longitude">Longitude.</param>
        /// <param name="MarcaCelular">MarcaCelular.</param>
        /// <param name="Metodo">M\u00E9todo onde o c\u00F3digo \u00E9 executado.</param>
        /// <param name="ModeloCelular">ModeloCelular.</param>
        /// <param name="PhoneId">PhoneId.</param>
        /// <param name="UserAgent">UserAgent.</param>

        public LogRequisicaoMobileResponse(string AppVersion = null, int? CodigoRetorno = null, string Cpf = null, string DataHoraRequisicao = null, string DeviceId = null, long? Id = null, long? IdChave = null, long? IdConta = null, long? IdPlataforma = null, long? IdProposta = null, long? IdRequisicao = null, string InformacaoAdicional = null, string Latitude = null, string Login = null, string Longitude = null, string MarcaCelular = null, string Metodo = null, string ModeloCelular = null, string PhoneId = null, string UserAgent = null)
        {
            this.AppVersion = AppVersion;
            this.CodigoRetorno = CodigoRetorno;
            this.Cpf = Cpf;
            this.DataHoraRequisicao = DataHoraRequisicao;
            this.DeviceId = DeviceId;
            this.Id = Id;
            this.IdChave = IdChave;
            this.IdConta = IdConta;
            this.IdPlataforma = IdPlataforma;
            this.IdProposta = IdProposta;
            this.IdRequisicao = IdRequisicao;
            this.InformacaoAdicional = InformacaoAdicional;
            this.Latitude = Latitude;
            this.Login = Login;
            this.Longitude = Longitude;
            this.MarcaCelular = MarcaCelular;
            this.Metodo = Metodo;
            this.ModeloCelular = ModeloCelular;
            this.PhoneId = PhoneId;
            this.UserAgent = UserAgent;
            
        }
        
    
        /// <summary>
        /// Gets or Sets AppVersion
        /// </summary>
        [DataMember(Name="appVersion", EmitDefaultValue=false)]
        public string AppVersion { get; set; }
    
        /// <summary>
        /// Gets or Sets CodigoRetorno
        /// </summary>
        [DataMember(Name="codigoRetorno", EmitDefaultValue=false)]
        public int? CodigoRetorno { get; set; }
    
        /// <summary>
        /// Gets or Sets Cpf
        /// </summary>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// Gets or Sets DataHoraRequisicao
        /// </summary>
        [DataMember(Name="dataHoraRequisicao", EmitDefaultValue=false)]
        public string DataHoraRequisicao { get; set; }
    
        /// <summary>
        /// Gets or Sets DeviceId
        /// </summary>
        [DataMember(Name="deviceId", EmitDefaultValue=false)]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Gets or Sets IdChave
        /// </summary>
        [DataMember(Name="idChave", EmitDefaultValue=false)]
        public long? IdChave { get; set; }
    
        /// <summary>
        /// Gets or Sets IdConta
        /// </summary>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Gets or Sets IdPlataforma
        /// </summary>
        [DataMember(Name="idPlataforma", EmitDefaultValue=false)]
        public long? IdPlataforma { get; set; }
    
        /// <summary>
        /// Gets or Sets IdProposta
        /// </summary>
        [DataMember(Name="idProposta", EmitDefaultValue=false)]
        public long? IdProposta { get; set; }
    
        /// <summary>
        /// Gets or Sets IdRequisicao
        /// </summary>
        [DataMember(Name="idRequisicao", EmitDefaultValue=false)]
        public long? IdRequisicao { get; set; }
    
        /// <summary>
        /// Gets or Sets InformacaoAdicional
        /// </summary>
        [DataMember(Name="informacaoAdicional", EmitDefaultValue=false)]
        public string InformacaoAdicional { get; set; }
    
        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public string Latitude { get; set; }
    
        /// <summary>
        /// Gets or Sets Login
        /// </summary>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }
    
        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public string Longitude { get; set; }
    
        /// <summary>
        /// Gets or Sets MarcaCelular
        /// </summary>
        [DataMember(Name="marcaCelular", EmitDefaultValue=false)]
        public string MarcaCelular { get; set; }
    
        /// <summary>
        /// M\u00E9todo onde o c\u00F3digo \u00E9 executado
        /// </summary>
        /// <value>M\u00E9todo onde o c\u00F3digo \u00E9 executado</value>
        [DataMember(Name="metodo", EmitDefaultValue=false)]
        public string Metodo { get; set; }
    
        /// <summary>
        /// Gets or Sets ModeloCelular
        /// </summary>
        [DataMember(Name="modeloCelular", EmitDefaultValue=false)]
        public string ModeloCelular { get; set; }
    
        /// <summary>
        /// Gets or Sets PhoneId
        /// </summary>
        [DataMember(Name="phoneId", EmitDefaultValue=false)]
        public string PhoneId { get; set; }
    
        /// <summary>
        /// Gets or Sets UserAgent
        /// </summary>
        [DataMember(Name="userAgent", EmitDefaultValue=false)]
        public string UserAgent { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogRequisicaoMobileResponse {\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  CodigoRetorno: ").Append(CodigoRetorno).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  DataHoraRequisicao: ").Append(DataHoraRequisicao).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdChave: ").Append(IdChave).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdPlataforma: ").Append(IdPlataforma).Append("\n");
            sb.Append("  IdProposta: ").Append(IdProposta).Append("\n");
            sb.Append("  IdRequisicao: ").Append(IdRequisicao).Append("\n");
            sb.Append("  InformacaoAdicional: ").Append(InformacaoAdicional).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  MarcaCelular: ").Append(MarcaCelular).Append("\n");
            sb.Append("  Metodo: ").Append(Metodo).Append("\n");
            sb.Append("  ModeloCelular: ").Append(ModeloCelular).Append("\n");
            sb.Append("  PhoneId: ").Append(PhoneId).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
            
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
            return this.Equals(obj as LogRequisicaoMobileResponse);
        }

        /// <summary>
        /// Returns true if LogRequisicaoMobileResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of LogRequisicaoMobileResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogRequisicaoMobileResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AppVersion == other.AppVersion ||
                    this.AppVersion != null &&
                    this.AppVersion.Equals(other.AppVersion)
                ) && 
                (
                    this.CodigoRetorno == other.CodigoRetorno ||
                    this.CodigoRetorno != null &&
                    this.CodigoRetorno.Equals(other.CodigoRetorno)
                ) && 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
                ) && 
                (
                    this.DataHoraRequisicao == other.DataHoraRequisicao ||
                    this.DataHoraRequisicao != null &&
                    this.DataHoraRequisicao.Equals(other.DataHoraRequisicao)
                ) && 
                (
                    this.DeviceId == other.DeviceId ||
                    this.DeviceId != null &&
                    this.DeviceId.Equals(other.DeviceId)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdChave == other.IdChave ||
                    this.IdChave != null &&
                    this.IdChave.Equals(other.IdChave)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdPlataforma == other.IdPlataforma ||
                    this.IdPlataforma != null &&
                    this.IdPlataforma.Equals(other.IdPlataforma)
                ) && 
                (
                    this.IdProposta == other.IdProposta ||
                    this.IdProposta != null &&
                    this.IdProposta.Equals(other.IdProposta)
                ) && 
                (
                    this.IdRequisicao == other.IdRequisicao ||
                    this.IdRequisicao != null &&
                    this.IdRequisicao.Equals(other.IdRequisicao)
                ) && 
                (
                    this.InformacaoAdicional == other.InformacaoAdicional ||
                    this.InformacaoAdicional != null &&
                    this.InformacaoAdicional.Equals(other.InformacaoAdicional)
                ) && 
                (
                    this.Latitude == other.Latitude ||
                    this.Latitude != null &&
                    this.Latitude.Equals(other.Latitude)
                ) && 
                (
                    this.Login == other.Login ||
                    this.Login != null &&
                    this.Login.Equals(other.Login)
                ) && 
                (
                    this.Longitude == other.Longitude ||
                    this.Longitude != null &&
                    this.Longitude.Equals(other.Longitude)
                ) && 
                (
                    this.MarcaCelular == other.MarcaCelular ||
                    this.MarcaCelular != null &&
                    this.MarcaCelular.Equals(other.MarcaCelular)
                ) && 
                (
                    this.Metodo == other.Metodo ||
                    this.Metodo != null &&
                    this.Metodo.Equals(other.Metodo)
                ) && 
                (
                    this.ModeloCelular == other.ModeloCelular ||
                    this.ModeloCelular != null &&
                    this.ModeloCelular.Equals(other.ModeloCelular)
                ) && 
                (
                    this.PhoneId == other.PhoneId ||
                    this.PhoneId != null &&
                    this.PhoneId.Equals(other.PhoneId)
                ) && 
                (
                    this.UserAgent == other.UserAgent ||
                    this.UserAgent != null &&
                    this.UserAgent.Equals(other.UserAgent)
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
                
                if (this.AppVersion != null)
                    hash = hash * 59 + this.AppVersion.GetHashCode();
                
                if (this.CodigoRetorno != null)
                    hash = hash * 59 + this.CodigoRetorno.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                if (this.DataHoraRequisicao != null)
                    hash = hash * 59 + this.DataHoraRequisicao.GetHashCode();
                
                if (this.DeviceId != null)
                    hash = hash * 59 + this.DeviceId.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdChave != null)
                    hash = hash * 59 + this.IdChave.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdPlataforma != null)
                    hash = hash * 59 + this.IdPlataforma.GetHashCode();
                
                if (this.IdProposta != null)
                    hash = hash * 59 + this.IdProposta.GetHashCode();
                
                if (this.IdRequisicao != null)
                    hash = hash * 59 + this.IdRequisicao.GetHashCode();
                
                if (this.InformacaoAdicional != null)
                    hash = hash * 59 + this.InformacaoAdicional.GetHashCode();
                
                if (this.Latitude != null)
                    hash = hash * 59 + this.Latitude.GetHashCode();
                
                if (this.Login != null)
                    hash = hash * 59 + this.Login.GetHashCode();
                
                if (this.Longitude != null)
                    hash = hash * 59 + this.Longitude.GetHashCode();
                
                if (this.MarcaCelular != null)
                    hash = hash * 59 + this.MarcaCelular.GetHashCode();
                
                if (this.Metodo != null)
                    hash = hash * 59 + this.Metodo.GetHashCode();
                
                if (this.ModeloCelular != null)
                    hash = hash * 59 + this.ModeloCelular.GetHashCode();
                
                if (this.PhoneId != null)
                    hash = hash * 59 + this.PhoneId.GetHashCode();
                
                if (this.UserAgent != null)
                    hash = hash * 59 + this.UserAgent.GetHashCode();
                
                return hash;
            }
        }

    }
}
