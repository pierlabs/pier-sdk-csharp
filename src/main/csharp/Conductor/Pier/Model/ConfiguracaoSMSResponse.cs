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
    /// Objeto Configura\u00E7\u00E3o SMS
    /// </summary>
    [DataContract]
    public partial class ConfiguracaoSMSResponse :  IEquatable<ConfiguracaoSMSResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguracaoSMSResponse" /> class.
        /// Initializes a new instance of the <see cref="ConfiguracaoSMSResponse" />class.
        /// </summary>
        /// <param name="Id">Id Configura\u00E7\u00E3o SMS.</param>
        /// <param name="IdEmissor">Id emissor.</param>
        /// <param name="UsuarioSMS">Usuario SMS.</param>
        /// <param name="SenhaSMS">Senha SMS.</param>

        public ConfiguracaoSMSResponse(long? Id = null, long? IdEmissor = null, string UsuarioSMS = null, string SenhaSMS = null)
        {
            this.Id = Id;
            this.IdEmissor = IdEmissor;
            this.UsuarioSMS = UsuarioSMS;
            this.SenhaSMS = SenhaSMS;
            
        }
        
    
        /// <summary>
        /// Id Configura\u00E7\u00E3o SMS
        /// </summary>
        /// <value>Id Configura\u00E7\u00E3o SMS</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Id emissor
        /// </summary>
        /// <value>Id emissor</value>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public long? IdEmissor { get; set; }
    
        /// <summary>
        /// Usuario SMS
        /// </summary>
        /// <value>Usuario SMS</value>
        [DataMember(Name="usuarioSMS", EmitDefaultValue=false)]
        public string UsuarioSMS { get; set; }
    
        /// <summary>
        /// Senha SMS
        /// </summary>
        /// <value>Senha SMS</value>
        [DataMember(Name="senhaSMS", EmitDefaultValue=false)]
        public string SenhaSMS { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfiguracaoSMSResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdEmissor: ").Append(IdEmissor).Append("\n");
            sb.Append("  UsuarioSMS: ").Append(UsuarioSMS).Append("\n");
            sb.Append("  SenhaSMS: ").Append(SenhaSMS).Append("\n");
            
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
            return this.Equals(obj as ConfiguracaoSMSResponse);
        }

        /// <summary>
        /// Returns true if ConfiguracaoSMSResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ConfiguracaoSMSResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfiguracaoSMSResponse other)
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
                    this.IdEmissor == other.IdEmissor ||
                    this.IdEmissor != null &&
                    this.IdEmissor.Equals(other.IdEmissor)
                ) && 
                (
                    this.UsuarioSMS == other.UsuarioSMS ||
                    this.UsuarioSMS != null &&
                    this.UsuarioSMS.Equals(other.UsuarioSMS)
                ) && 
                (
                    this.SenhaSMS == other.SenhaSMS ||
                    this.SenhaSMS != null &&
                    this.SenhaSMS.Equals(other.SenhaSMS)
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
                
                if (this.IdEmissor != null)
                    hash = hash * 59 + this.IdEmissor.GetHashCode();
                
                if (this.UsuarioSMS != null)
                    hash = hash * 59 + this.UsuarioSMS.GetHashCode();
                
                if (this.SenhaSMS != null)
                    hash = hash * 59 + this.SenhaSMS.GetHashCode();
                
                return hash;
            }
        }

    }
}
