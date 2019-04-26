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
    /// Objeto Dispositivo
    /// </summary>
    [DataContract]
    public partial class DispositivoPersist :  IEquatable<DispositivoPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DispositivoPersist" /> class.
        /// Initializes a new instance of the <see cref="DispositivoPersist" />class.
        /// </summary>
        /// <param name="Token">Apresenta o token do dispositivo.</param>
        /// <param name="IdAplicacaoMobile">Apresenta o identificador da aplica\u00E7\u00E3o.</param>
        /// <param name="IdUsuario">Apresenta o identificador do usu\u00E1rio.</param>

        public DispositivoPersist(string Token = null, long? IdAplicacaoMobile = null, long? IdUsuario = null)
        {
            this.Token = Token;
            this.IdAplicacaoMobile = IdAplicacaoMobile;
            this.IdUsuario = IdUsuario;
            
        }
        
    
        /// <summary>
        /// Apresenta o token do dispositivo
        /// </summary>
        /// <value>Apresenta o token do dispositivo</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }
    
        /// <summary>
        /// Apresenta o identificador da aplica\u00E7\u00E3o
        /// </summary>
        /// <value>Apresenta o identificador da aplica\u00E7\u00E3o</value>
        [DataMember(Name="idAplicacaoMobile", EmitDefaultValue=false)]
        public long? IdAplicacaoMobile { get; set; }
    
        /// <summary>
        /// Apresenta o identificador do usu\u00E1rio
        /// </summary>
        /// <value>Apresenta o identificador do usu\u00E1rio</value>
        [DataMember(Name="idUsuario", EmitDefaultValue=false)]
        public long? IdUsuario { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DispositivoPersist {\n");
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
            return this.Equals(obj as DispositivoPersist);
        }

        /// <summary>
        /// Returns true if DispositivoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of DispositivoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DispositivoPersist other)
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
