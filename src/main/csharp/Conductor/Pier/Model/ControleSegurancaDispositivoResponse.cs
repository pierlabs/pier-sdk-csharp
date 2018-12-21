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
    /// {{{controle_seguranca_dispositivo_resposta_descricao}}}
    /// </summary>
    [DataContract]
    public partial class ControleSegurancaDispositivoResponse :  IEquatable<ControleSegurancaDispositivoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ControleSegurancaDispositivoResponse" /> class.
        /// Initializes a new instance of the <see cref="ControleSegurancaDispositivoResponse" />class.
        /// </summary>
        /// <param name="Id">{{{controle_seguranca_dispositivo_resposta_id_descricao}}}.</param>
        /// <param name="IdUsuario">{{{controle_seguranca_dispositivo_resposta_id_usuario_descricao}}}.</param>
        /// <param name="PhoneId">{{{controle_seguranca_dispositivo_resposta_phone_id_descricao}}}.</param>

        public ControleSegurancaDispositivoResponse(long? Id = null, long? IdUsuario = null, string PhoneId = null)
        {
            this.Id = Id;
            this.IdUsuario = IdUsuario;
            this.PhoneId = PhoneId;
            
        }
        
    
        /// <summary>
        /// {{{controle_seguranca_dispositivo_resposta_id_descricao}}}
        /// </summary>
        /// <value>{{{controle_seguranca_dispositivo_resposta_id_descricao}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{controle_seguranca_dispositivo_resposta_id_usuario_descricao}}}
        /// </summary>
        /// <value>{{{controle_seguranca_dispositivo_resposta_id_usuario_descricao}}}</value>
        [DataMember(Name="idUsuario", EmitDefaultValue=false)]
        public long? IdUsuario { get; set; }
    
        /// <summary>
        /// {{{controle_seguranca_dispositivo_resposta_phone_id_descricao}}}
        /// </summary>
        /// <value>{{{controle_seguranca_dispositivo_resposta_phone_id_descricao}}}</value>
        [DataMember(Name="phoneId", EmitDefaultValue=false)]
        public string PhoneId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ControleSegurancaDispositivoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdUsuario: ").Append(IdUsuario).Append("\n");
            sb.Append("  PhoneId: ").Append(PhoneId).Append("\n");
            
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
            return this.Equals(obj as ControleSegurancaDispositivoResponse);
        }

        /// <summary>
        /// Returns true if ControleSegurancaDispositivoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ControleSegurancaDispositivoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ControleSegurancaDispositivoResponse other)
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
                    this.IdUsuario == other.IdUsuario ||
                    this.IdUsuario != null &&
                    this.IdUsuario.Equals(other.IdUsuario)
                ) && 
                (
                    this.PhoneId == other.PhoneId ||
                    this.PhoneId != null &&
                    this.PhoneId.Equals(other.PhoneId)
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
                
                if (this.IdUsuario != null)
                    hash = hash * 59 + this.IdUsuario.GetHashCode();
                
                if (this.PhoneId != null)
                    hash = hash * 59 + this.PhoneId.GetHashCode();
                
                return hash;
            }
        }

    }
}
