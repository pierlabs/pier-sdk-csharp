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
    /// {{{inscricao_apn_persistencia_descricao}}}
    /// </summary>
    [DataContract]
    public partial class InscricaoApnPersistencia :  IEquatable<InscricaoApnPersistencia>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InscricaoApnPersistencia" /> class.
        /// Initializes a new instance of the <see cref="InscricaoApnPersistencia" />class.
        /// </summary>
        /// <param name="DeviceToken">{{{inscricao_apn_persistencia_device_token_descricao}}}.</param>
        /// <param name="IdAplicacaoMobile">{{{inscricao_apn_persistencia_id_aplicacao_mobile_descricao}}}.</param>
        /// <param name="IdCartoes">{{{inscricao_apn_persistencia_id_cartoes_descricao}}}.</param>

        public InscricaoApnPersistencia(string DeviceToken = null, long? IdAplicacaoMobile = null, List<long?> IdCartoes = null)
        {
            this.DeviceToken = DeviceToken;
            this.IdAplicacaoMobile = IdAplicacaoMobile;
            this.IdCartoes = IdCartoes;
            
        }
        
    
        /// <summary>
        /// {{{inscricao_apn_persistencia_device_token_descricao}}}
        /// </summary>
        /// <value>{{{inscricao_apn_persistencia_device_token_descricao}}}</value>
        [DataMember(Name="deviceToken", EmitDefaultValue=false)]
        public string DeviceToken { get; set; }
    
        /// <summary>
        /// {{{inscricao_apn_persistencia_id_aplicacao_mobile_descricao}}}
        /// </summary>
        /// <value>{{{inscricao_apn_persistencia_id_aplicacao_mobile_descricao}}}</value>
        [DataMember(Name="idAplicacaoMobile", EmitDefaultValue=false)]
        public long? IdAplicacaoMobile { get; set; }
    
        /// <summary>
        /// {{{inscricao_apn_persistencia_id_cartoes_descricao}}}
        /// </summary>
        /// <value>{{{inscricao_apn_persistencia_id_cartoes_descricao}}}</value>
        [DataMember(Name="idCartoes", EmitDefaultValue=false)]
        public List<long?> IdCartoes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InscricaoApnPersistencia {\n");
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
            return this.Equals(obj as InscricaoApnPersistencia);
        }

        /// <summary>
        /// Returns true if InscricaoApnPersistencia instances are equal
        /// </summary>
        /// <param name="other">Instance of InscricaoApnPersistencia to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InscricaoApnPersistencia other)
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
