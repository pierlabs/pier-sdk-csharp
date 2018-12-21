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
    /// {{{conta_debito_recorrente_persist_description}}}
    /// </summary>
    [DataContract]
    public partial class ContaDebitoRecorrentePersistValue :  IEquatable<ContaDebitoRecorrentePersistValue>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaDebitoRecorrentePersistValue" /> class.
        /// Initializes a new instance of the <see cref="ContaDebitoRecorrentePersistValue" />class.
        /// </summary>
        /// <param name="IdConta">{{{conta_debito_recorrente_persist_id_conta_value}}}.</param>
        /// <param name="IdTipoDebitoRecorrente">{{{conta_debito_recorrente_persist_id_tipo_debito_recorrente_value}}}.</param>
        /// <param name="IdUsuario">{{{conta_debito_recorrente_persist_id_usuario_value}}}.</param>
        /// <param name="Login">{{{conta_debito_recorrente_persist_login_value}}}.</param>
        /// <param name="NumeroParcelas">{{{conta_debito_recorrente_persist_num_parcelas_value}}}.</param>

        public ContaDebitoRecorrentePersistValue(long? IdConta = null, long? IdTipoDebitoRecorrente = null, long? IdUsuario = null, string Login = null, int? NumeroParcelas = null)
        {
            this.IdConta = IdConta;
            this.IdTipoDebitoRecorrente = IdTipoDebitoRecorrente;
            this.IdUsuario = IdUsuario;
            this.Login = Login;
            this.NumeroParcelas = NumeroParcelas;
            
        }
        
    
        /// <summary>
        /// {{{conta_debito_recorrente_persist_id_conta_value}}}
        /// </summary>
        /// <value>{{{conta_debito_recorrente_persist_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{conta_debito_recorrente_persist_id_tipo_debito_recorrente_value}}}
        /// </summary>
        /// <value>{{{conta_debito_recorrente_persist_id_tipo_debito_recorrente_value}}}</value>
        [DataMember(Name="idTipoDebitoRecorrente", EmitDefaultValue=false)]
        public long? IdTipoDebitoRecorrente { get; set; }
    
        /// <summary>
        /// {{{conta_debito_recorrente_persist_id_usuario_value}}}
        /// </summary>
        /// <value>{{{conta_debito_recorrente_persist_id_usuario_value}}}</value>
        [DataMember(Name="idUsuario", EmitDefaultValue=false)]
        public long? IdUsuario { get; set; }
    
        /// <summary>
        /// {{{conta_debito_recorrente_persist_login_value}}}
        /// </summary>
        /// <value>{{{conta_debito_recorrente_persist_login_value}}}</value>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }
    
        /// <summary>
        /// {{{conta_debito_recorrente_persist_num_parcelas_value}}}
        /// </summary>
        /// <value>{{{conta_debito_recorrente_persist_num_parcelas_value}}}</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public int? NumeroParcelas { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContaDebitoRecorrentePersistValue {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdTipoDebitoRecorrente: ").Append(IdTipoDebitoRecorrente).Append("\n");
            sb.Append("  IdUsuario: ").Append(IdUsuario).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  NumeroParcelas: ").Append(NumeroParcelas).Append("\n");
            
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
            return this.Equals(obj as ContaDebitoRecorrentePersistValue);
        }

        /// <summary>
        /// Returns true if ContaDebitoRecorrentePersistValue instances are equal
        /// </summary>
        /// <param name="other">Instance of ContaDebitoRecorrentePersistValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContaDebitoRecorrentePersistValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdTipoDebitoRecorrente == other.IdTipoDebitoRecorrente ||
                    this.IdTipoDebitoRecorrente != null &&
                    this.IdTipoDebitoRecorrente.Equals(other.IdTipoDebitoRecorrente)
                ) && 
                (
                    this.IdUsuario == other.IdUsuario ||
                    this.IdUsuario != null &&
                    this.IdUsuario.Equals(other.IdUsuario)
                ) && 
                (
                    this.Login == other.Login ||
                    this.Login != null &&
                    this.Login.Equals(other.Login)
                ) && 
                (
                    this.NumeroParcelas == other.NumeroParcelas ||
                    this.NumeroParcelas != null &&
                    this.NumeroParcelas.Equals(other.NumeroParcelas)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdTipoDebitoRecorrente != null)
                    hash = hash * 59 + this.IdTipoDebitoRecorrente.GetHashCode();
                
                if (this.IdUsuario != null)
                    hash = hash * 59 + this.IdUsuario.GetHashCode();
                
                if (this.Login != null)
                    hash = hash * 59 + this.Login.GetHashCode();
                
                if (this.NumeroParcelas != null)
                    hash = hash * 59 + this.NumeroParcelas.GetHashCode();
                
                return hash;
            }
        }

    }
}
