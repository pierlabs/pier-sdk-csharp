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
    /// Objeto Response do Tipo Servi\u00E7o SMS
    /// </summary>
    [DataContract]
    public partial class TipoServicoSMSResponse :  IEquatable<TipoServicoSMSResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoServicoSMSResponse" /> class.
        /// Initializes a new instance of the <see cref="TipoServicoSMSResponse" />class.
        /// </summary>
        /// <param name="Id">Identificador do Tipo Servi\u00E7o SMS.</param>
        /// <param name="Descricao">Descri\u00E7\u00E3o do Tipo Servi\u00E7o SMS.</param>

        public TipoServicoSMSResponse(long? Id = null, string Descricao = null)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            
        }
        
    
        /// <summary>
        /// Identificador do Tipo Servi\u00E7o SMS
        /// </summary>
        /// <value>Identificador do Tipo Servi\u00E7o SMS</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do Tipo Servi\u00E7o SMS
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do Tipo Servi\u00E7o SMS</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoServicoSMSResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            
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
            return this.Equals(obj as TipoServicoSMSResponse);
        }

        /// <summary>
        /// Returns true if TipoServicoSMSResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoServicoSMSResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoServicoSMSResponse other)
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
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
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
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                return hash;
            }
        }

    }
}
