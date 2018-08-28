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
    /// {{{request_secure_3d_description}}}
    /// </summary>
    [DataContract]
    public partial class Secure3dRequest :  IEquatable<Secure3dRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Secure3dRequest" /> class.
        /// Initializes a new instance of the <see cref="Secure3dRequest" />class.
        /// </summary>
        /// <param name="IdCartao">{{{id_cartao_3d_secure}}}.</param>
        /// <param name="Otp">{{{id_cartao_3d_secure}}}.</param>

        public Secure3dRequest(long? IdCartao = null, string Otp = null)
        {
            this.IdCartao = IdCartao;
            this.Otp = Otp;
            
        }
        
    
        /// <summary>
        /// {{{id_cartao_3d_secure}}}
        /// </summary>
        /// <value>{{{id_cartao_3d_secure}}}</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// {{{id_cartao_3d_secure}}}
        /// </summary>
        /// <value>{{{id_cartao_3d_secure}}}</value>
        [DataMember(Name="otp", EmitDefaultValue=false)]
        public string Otp { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Secure3dRequest {\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  Otp: ").Append(Otp).Append("\n");
            
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
            return this.Equals(obj as Secure3dRequest);
        }

        /// <summary>
        /// Returns true if Secure3dRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of Secure3dRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Secure3dRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.Otp == other.Otp ||
                    this.Otp != null &&
                    this.Otp.Equals(other.Otp)
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
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.Otp != null)
                    hash = hash * 59 + this.Otp.GetHashCode();
                
                return hash;
            }
        }

    }
}
