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
    /// Contas D\u00E9bitos Recorrentes
    /// </summary>
    [DataContract]
    public partial class ContaDebitoRecorrente :  IEquatable<ContaDebitoRecorrente>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaDebitoRecorrente" /> class.
        /// Initializes a new instance of the <see cref="ContaDebitoRecorrente" />class.
        /// </summary>
        /// <param name="IdConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="IdTipoDebitoRecorrente">C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id).</param>
        /// <param name="IdUsuario">C\u00F3digo de identifica\u00E7\u00E3o do usu\u00E1rio logado do sistema (id).</param>
        /// <param name="Login">Login logado do sistema.</param>
        /// <param name="NumeroParcelas">Quantidade de parcelas para o d\u00E9bito recorrente.</param>

        public ContaDebitoRecorrente(long? IdConta = null, long? IdTipoDebitoRecorrente = null, long? IdUsuario = null, string Login = null, int? NumeroParcelas = null)
        {
            this.IdConta = IdConta;
            this.IdTipoDebitoRecorrente = IdTipoDebitoRecorrente;
            this.IdUsuario = IdUsuario;
            this.Login = Login;
            this.NumeroParcelas = NumeroParcelas;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da conta (id)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do tipo de d\u00E9bito recorrente (id)</value>
        [DataMember(Name="idTipoDebitoRecorrente", EmitDefaultValue=false)]
        public long? IdTipoDebitoRecorrente { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do usu\u00E1rio logado do sistema (id)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do usu\u00E1rio logado do sistema (id)</value>
        [DataMember(Name="idUsuario", EmitDefaultValue=false)]
        public long? IdUsuario { get; set; }
    
        /// <summary>
        /// Login logado do sistema
        /// </summary>
        /// <value>Login logado do sistema</value>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }
    
        /// <summary>
        /// Quantidade de parcelas para o d\u00E9bito recorrente
        /// </summary>
        /// <value>Quantidade de parcelas para o d\u00E9bito recorrente</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public int? NumeroParcelas { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContaDebitoRecorrente {\n");
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
            return this.Equals(obj as ContaDebitoRecorrente);
        }

        /// <summary>
        /// Returns true if ContaDebitoRecorrente instances are equal
        /// </summary>
        /// <param name="other">Instance of ContaDebitoRecorrente to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContaDebitoRecorrente other)
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
