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
    /// {{{dispositivo_persist_description}}}
    /// </summary>
    [DataContract]
    public partial class DispositivoPersistValue :  IEquatable<DispositivoPersistValue>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DispositivoPersistValue" /> class.
        /// Initializes a new instance of the <see cref="DispositivoPersistValue" />class.
        /// </summary>
        /// <param name="Token">{{{dispositivo_persist_token_value}}}.</param>
        /// <param name="IdAplicacaoMobile">{{{dispositivo_persist_id_aplicacao_mobile_value}}}.</param>
        /// <param name="IdUsuario">{{{dispositivo_persist_id_usuario_value}}}.</param>

        public DispositivoPersistValue(string Token = null, long? IdAplicacaoMobile = null, long? IdUsuario = null)
        {
            this.Token = Token;
            this.IdAplicacaoMobile = IdAplicacaoMobile;
            this.IdUsuario = IdUsuario;
            
        }
        
    
        /// <summary>
        /// {{{dispositivo_persist_token_value}}}
        /// </summary>
        /// <value>{{{dispositivo_persist_token_value}}}</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }
    
        /// <summary>
        /// {{{dispositivo_persist_id_aplicacao_mobile_value}}}
        /// </summary>
        /// <value>{{{dispositivo_persist_id_aplicacao_mobile_value}}}</value>
        [DataMember(Name="idAplicacaoMobile", EmitDefaultValue=false)]
        public long? IdAplicacaoMobile { get; set; }
    
        /// <summary>
        /// {{{dispositivo_persist_id_usuario_value}}}
        /// </summary>
        /// <value>{{{dispositivo_persist_id_usuario_value}}}</value>
        [DataMember(Name="idUsuario", EmitDefaultValue=false)]
        public long? IdUsuario { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DispositivoPersistValue {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  IdAplicacaoMobile: ").Append(IdAplicacaoMobile).Append("\n");
            sb.Append("  IdUsuario: ").Append(IdUsuario).Append("\n");
            
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
            return this.Equals(obj as DispositivoPersistValue);
        }

        /// <summary>
        /// Returns true if DispositivoPersistValue instances are equal
        /// </summary>
        /// <param name="other">Instance of DispositivoPersistValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DispositivoPersistValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
                ) && 
                (
                    this.IdAplicacaoMobile == other.IdAplicacaoMobile ||
                    this.IdAplicacaoMobile != null &&
                    this.IdAplicacaoMobile.Equals(other.IdAplicacaoMobile)
                ) && 
                (
                    this.IdUsuario == other.IdUsuario ||
                    this.IdUsuario != null &&
                    this.IdUsuario.Equals(other.IdUsuario)
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
                
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                
                if (this.IdAplicacaoMobile != null)
                    hash = hash * 59 + this.IdAplicacaoMobile.GetHashCode();
                
                if (this.IdUsuario != null)
                    hash = hash * 59 + this.IdUsuario.GetHashCode();
                
                return hash;
            }
        }

    }
}