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
    /// {{{dados_bancarios_conta_update_description}}}
    /// </summary>
    [DataContract]
    public partial class DadosBancariosContaUpdate :  IEquatable<DadosBancariosContaUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DadosBancariosContaUpdate" /> class.
        /// Initializes a new instance of the <see cref="DadosBancariosContaUpdate" />class.
        /// </summary>
        /// <param name="IdConta">{{{dados_bancarios_conta_update_idConta_value}}}.</param>
        /// <param name="CodigoBanco">{{{dados_bancarios_conta_update_banco_value}}}.</param>
        /// <param name="NumeroAgencia">{{{dados_bancarios_conta_update_agencia_value}}}.</param>
        /// <param name="NumeroContaCorrente">{{{dados_bancarios_conta_update_contaCorrente_value}}}.</param>
        /// <param name="IdTipoContaBancaria">{{{dados_bancarios_conta_update_idTipoContaBancaria_value}}}.</param>

        public DadosBancariosContaUpdate(long? IdConta = null, long? CodigoBanco = null, long? NumeroAgencia = null, string NumeroContaCorrente = null, long? IdTipoContaBancaria = null)
        {
            this.IdConta = IdConta;
            this.CodigoBanco = CodigoBanco;
            this.NumeroAgencia = NumeroAgencia;
            this.NumeroContaCorrente = NumeroContaCorrente;
            this.IdTipoContaBancaria = IdTipoContaBancaria;
            
        }
        
    
        /// <summary>
        /// {{{dados_bancarios_conta_update_idConta_value}}}
        /// </summary>
        /// <value>{{{dados_bancarios_conta_update_idConta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{dados_bancarios_conta_update_banco_value}}}
        /// </summary>
        /// <value>{{{dados_bancarios_conta_update_banco_value}}}</value>
        [DataMember(Name="codigoBanco", EmitDefaultValue=false)]
        public long? CodigoBanco { get; set; }
    
        /// <summary>
        /// {{{dados_bancarios_conta_update_agencia_value}}}
        /// </summary>
        /// <value>{{{dados_bancarios_conta_update_agencia_value}}}</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public long? NumeroAgencia { get; set; }
    
        /// <summary>
        /// {{{dados_bancarios_conta_update_contaCorrente_value}}}
        /// </summary>
        /// <value>{{{dados_bancarios_conta_update_contaCorrente_value}}}</value>
        [DataMember(Name="numeroContaCorrente", EmitDefaultValue=false)]
        public string NumeroContaCorrente { get; set; }
    
        /// <summary>
        /// {{{dados_bancarios_conta_update_idTipoContaBancaria_value}}}
        /// </summary>
        /// <value>{{{dados_bancarios_conta_update_idTipoContaBancaria_value}}}</value>
        [DataMember(Name="idTipoContaBancaria", EmitDefaultValue=false)]
        public long? IdTipoContaBancaria { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DadosBancariosContaUpdate {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  CodigoBanco: ").Append(CodigoBanco).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  NumeroContaCorrente: ").Append(NumeroContaCorrente).Append("\n");
            sb.Append("  IdTipoContaBancaria: ").Append(IdTipoContaBancaria).Append("\n");
            
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
            return this.Equals(obj as DadosBancariosContaUpdate);
        }

        /// <summary>
        /// Returns true if DadosBancariosContaUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of DadosBancariosContaUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DadosBancariosContaUpdate other)
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
                    this.CodigoBanco == other.CodigoBanco ||
                    this.CodigoBanco != null &&
                    this.CodigoBanco.Equals(other.CodigoBanco)
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
                    this.IdTipoContaBancaria == other.IdTipoContaBancaria ||
                    this.IdTipoContaBancaria != null &&
                    this.IdTipoContaBancaria.Equals(other.IdTipoContaBancaria)
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
                
                if (this.CodigoBanco != null)
                    hash = hash * 59 + this.CodigoBanco.GetHashCode();
                
                if (this.NumeroAgencia != null)
                    hash = hash * 59 + this.NumeroAgencia.GetHashCode();
                
                if (this.NumeroContaCorrente != null)
                    hash = hash * 59 + this.NumeroContaCorrente.GetHashCode();
                
                if (this.IdTipoContaBancaria != null)
                    hash = hash * 59 + this.IdTipoContaBancaria.GetHashCode();
                
                return hash;
            }
        }

    }
}
