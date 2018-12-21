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
    /// Parameters for persisting bank account data
    /// </summary>
    [DataContract]
    public partial class DadosBancariosContaPersist :  IEquatable<DadosBancariosContaPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DadosBancariosContaPersist" /> class.
        /// Initializes a new instance of the <see cref="DadosBancariosContaPersist" />class.
        /// </summary>
        /// <param name="IdConta">Identification Code of the account.</param>
        /// <param name="NumeroAgencia">Displays the number of the Agency.</param>
        /// <param name="NumeroContaCorrente">Displays the number of the Account.</param>
        /// <param name="CodigoBanco">Displays the number representing the code of the bank.</param>
        /// <param name="IdTipoContaBancaria">Identification Code of the bank account type (id).</param>
        /// <param name="DvContaCorrente">DvContaCorrente.</param>
        /// <param name="DvAgencia">DvAgencia.</param>

        public DadosBancariosContaPersist(long? IdConta = null, long? NumeroAgencia = null, string NumeroContaCorrente = null, long? CodigoBanco = null, long? IdTipoContaBancaria = null, string DvContaCorrente = null, int? DvAgencia = null)
        {
            this.IdConta = IdConta;
            this.NumeroAgencia = NumeroAgencia;
            this.NumeroContaCorrente = NumeroContaCorrente;
            this.CodigoBanco = CodigoBanco;
            this.IdTipoContaBancaria = IdTipoContaBancaria;
            this.DvContaCorrente = DvContaCorrente;
            this.DvAgencia = DvAgencia;
            
        }
        
    
        /// <summary>
        /// Identification Code of the account
        /// </summary>
        /// <value>Identification Code of the account</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Displays the number of the Agency
        /// </summary>
        /// <value>Displays the number of the Agency</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public long? NumeroAgencia { get; set; }
    
        /// <summary>
        /// Displays the number of the Account
        /// </summary>
        /// <value>Displays the number of the Account</value>
        [DataMember(Name="numeroContaCorrente", EmitDefaultValue=false)]
        public string NumeroContaCorrente { get; set; }
    
        /// <summary>
        /// Displays the number representing the code of the bank
        /// </summary>
        /// <value>Displays the number representing the code of the bank</value>
        [DataMember(Name="codigoBanco", EmitDefaultValue=false)]
        public long? CodigoBanco { get; set; }
    
        /// <summary>
        /// Identification Code of the bank account type (id)
        /// </summary>
        /// <value>Identification Code of the bank account type (id)</value>
        [DataMember(Name="idTipoContaBancaria", EmitDefaultValue=false)]
        public long? IdTipoContaBancaria { get; set; }
    
        /// <summary>
        /// Gets or Sets DvContaCorrente
        /// </summary>
        [DataMember(Name="dvContaCorrente", EmitDefaultValue=false)]
        public string DvContaCorrente { get; set; }
    
        /// <summary>
        /// Gets or Sets DvAgencia
        /// </summary>
        [DataMember(Name="dvAgencia", EmitDefaultValue=false)]
        public int? DvAgencia { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DadosBancariosContaPersist {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  NumeroContaCorrente: ").Append(NumeroContaCorrente).Append("\n");
            sb.Append("  CodigoBanco: ").Append(CodigoBanco).Append("\n");
            sb.Append("  IdTipoContaBancaria: ").Append(IdTipoContaBancaria).Append("\n");
            sb.Append("  DvContaCorrente: ").Append(DvContaCorrente).Append("\n");
            sb.Append("  DvAgencia: ").Append(DvAgencia).Append("\n");
            
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
            return this.Equals(obj as DadosBancariosContaPersist);
        }

        /// <summary>
        /// Returns true if DadosBancariosContaPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of DadosBancariosContaPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DadosBancariosContaPersist other)
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
                    this.NumeroAgencia == other.NumeroAgencia ||
                    this.NumeroAgencia != null &&
                    this.NumeroAgencia.Equals(other.NumeroAgencia)
                ) && 
                (
                    this.NumeroContaCorrente == other.NumeroContaCorrente ||
                    this.NumeroContaCorrente != null &&
                    this.NumeroContaCorrente.Equals(other.NumeroContaCorrente)
                ) && 
                (
                    this.CodigoBanco == other.CodigoBanco ||
                    this.CodigoBanco != null &&
                    this.CodigoBanco.Equals(other.CodigoBanco)
                ) && 
                (
                    this.IdTipoContaBancaria == other.IdTipoContaBancaria ||
                    this.IdTipoContaBancaria != null &&
                    this.IdTipoContaBancaria.Equals(other.IdTipoContaBancaria)
                ) && 
                (
                    this.DvContaCorrente == other.DvContaCorrente ||
                    this.DvContaCorrente != null &&
                    this.DvContaCorrente.Equals(other.DvContaCorrente)
                ) && 
                (
                    this.DvAgencia == other.DvAgencia ||
                    this.DvAgencia != null &&
                    this.DvAgencia.Equals(other.DvAgencia)
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
                
                if (this.NumeroAgencia != null)
                    hash = hash * 59 + this.NumeroAgencia.GetHashCode();
                
                if (this.NumeroContaCorrente != null)
                    hash = hash * 59 + this.NumeroContaCorrente.GetHashCode();
                
                if (this.CodigoBanco != null)
                    hash = hash * 59 + this.CodigoBanco.GetHashCode();
                
                if (this.IdTipoContaBancaria != null)
                    hash = hash * 59 + this.IdTipoContaBancaria.GetHashCode();
                
                if (this.DvContaCorrente != null)
                    hash = hash * 59 + this.DvContaCorrente.GetHashCode();
                
                if (this.DvAgencia != null)
                    hash = hash * 59 + this.DvAgencia.GetHashCode();
                
                return hash;
            }
        }

    }
}
