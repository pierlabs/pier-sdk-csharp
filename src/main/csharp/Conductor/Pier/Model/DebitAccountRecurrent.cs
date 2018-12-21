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
    /// Recurrent Debit Accounts
    /// </summary>
    [DataContract]
    public partial class DebitAccountRecurrent :  IEquatable<DebitAccountRecurrent>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DebitAccountRecurrent" /> class.
        /// Initializes a new instance of the <see cref="DebitAccountRecurrent" />class.
        /// </summary>
        /// <param name="IdConta">Identification Code of the Account (id).</param>
        /// <param name="IdTipoDebitoRecorrente">Identification Code of the Recurrent Debit Account (id).</param>
        /// <param name="IdUsuario">Identification Code of the Logged system user (id).</param>
        /// <param name="Login">Logged Login in the system.</param>
        /// <param name="NumeroParcelas">Months quantity for Recurrent Debit.</param>

        public DebitAccountRecurrent(long? IdConta = null, long? IdTipoDebitoRecorrente = null, long? IdUsuario = null, string Login = null, int? NumeroParcelas = null)
        {
            this.IdConta = IdConta;
            this.IdTipoDebitoRecorrente = IdTipoDebitoRecorrente;
            this.IdUsuario = IdUsuario;
            this.Login = Login;
            this.NumeroParcelas = NumeroParcelas;
            
        }
        
    
        /// <summary>
        /// Identification Code of the Account (id)
        /// </summary>
        /// <value>Identification Code of the Account (id)</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identification Code of the Recurrent Debit Account (id)
        /// </summary>
        /// <value>Identification Code of the Recurrent Debit Account (id)</value>
        [DataMember(Name="idTipoDebitoRecorrente", EmitDefaultValue=false)]
        public long? IdTipoDebitoRecorrente { get; set; }
    
        /// <summary>
        /// Identification Code of the Logged system user (id)
        /// </summary>
        /// <value>Identification Code of the Logged system user (id)</value>
        [DataMember(Name="idUsuario", EmitDefaultValue=false)]
        public long? IdUsuario { get; set; }
    
        /// <summary>
        /// Logged Login in the system
        /// </summary>
        /// <value>Logged Login in the system</value>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }
    
        /// <summary>
        /// Months quantity for Recurrent Debit
        /// </summary>
        /// <value>Months quantity for Recurrent Debit</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public int? NumeroParcelas { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DebitAccountRecurrent {\n");
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
            return this.Equals(obj as DebitAccountRecurrent);
        }

        /// <summary>
        /// Returns true if DebitAccountRecurrent instances are equal
        /// </summary>
        /// <param name="other">Instance of DebitAccountRecurrent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DebitAccountRecurrent other)
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
