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
    /// Objeto de persist\u00EAncia para novas incri\u00E7\u00F5es
    /// </summary>
    [DataContract]
    public partial class InscricaoAPN :  IEquatable<InscricaoAPN>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InscricaoAPN" /> class.
        /// Initializes a new instance of the <see cref="InscricaoAPN" />class.
        /// </summary>
        /// <param name="DeviceToken">Token do dispositivo.</param>
        /// <param name="IdAplicacaoMobile">Id da aplica\u00E7\u00E3o mobile.</param>
        /// <param name="IdCartoes">Lista de ids dos cart\u00F5es.</param>

        public InscricaoAPN(string DeviceToken = null, long? IdAplicacaoMobile = null, List<long?> IdCartoes = null)
        {
            this.DeviceToken = DeviceToken;
            this.IdAplicacaoMobile = IdAplicacaoMobile;
            this.IdCartoes = IdCartoes;
            
        }
        
    
        /// <summary>
        /// Token do dispositivo
        /// </summary>
        /// <value>Token do dispositivo</value>
        [DataMember(Name="deviceToken", EmitDefaultValue=false)]
        public string DeviceToken { get; set; }
    
        /// <summary>
        /// Id da aplica\u00E7\u00E3o mobile
        /// </summary>
        /// <value>Id da aplica\u00E7\u00E3o mobile</value>
        [DataMember(Name="idAplicacaoMobile", EmitDefaultValue=false)]
        public long? IdAplicacaoMobile { get; set; }
    
        /// <summary>
        /// Lista de ids dos cart\u00F5es
        /// </summary>
        /// <value>Lista de ids dos cart\u00F5es</value>
        [DataMember(Name="idCartoes", EmitDefaultValue=false)]
        public List<long?> IdCartoes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InscricaoAPN {\n");
            sb.Append("  DeviceToken: ").Append(DeviceToken).Append("\n");
            sb.Append("  IdAplicacaoMobile: ").Append(IdAplicacaoMobile).Append("\n");
            sb.Append("  IdCartoes: ").Append(IdCartoes).Append("\n");
            
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
            return this.Equals(obj as InscricaoAPN);
        }

        /// <summary>
        /// Returns true if InscricaoAPN instances are equal
        /// </summary>
        /// <param name="other">Instance of InscricaoAPN to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InscricaoAPN other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeviceToken == other.DeviceToken ||
                    this.DeviceToken != null &&
                    this.DeviceToken.Equals(other.DeviceToken)
                ) && 
                (
                    this.IdAplicacaoMobile == other.IdAplicacaoMobile ||
                    this.IdAplicacaoMobile != null &&
                    this.IdAplicacaoMobile.Equals(other.IdAplicacaoMobile)
                ) && 
                (
                    this.IdCartoes == other.IdCartoes ||
                    this.IdCartoes != null &&
                    this.IdCartoes.SequenceEqual(other.IdCartoes)
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
                
                if (this.DeviceToken != null)
                    hash = hash * 59 + this.DeviceToken.GetHashCode();
                
                if (this.IdAplicacaoMobile != null)
                    hash = hash * 59 + this.IdAplicacaoMobile.GetHashCode();
                
                if (this.IdCartoes != null)
                    hash = hash * 59 + this.IdCartoes.GetHashCode();
                
                return hash;
            }
        }

    }
}
