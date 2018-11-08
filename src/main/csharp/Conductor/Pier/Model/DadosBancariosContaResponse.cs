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
    /// {{{dados_bancarios_conta_response_description}}}
    /// </summary>
    [DataContract]
    public partial class DadosBancariosContaResponse :  IEquatable<DadosBancariosContaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DadosBancariosContaResponse" /> class.
        /// Initializes a new instance of the <see cref="DadosBancariosContaResponse" />class.
        /// </summary>
        /// <param name="Id">{{{dados_bancarios_conta_response_id_value}}}.</param>
        /// <param name="IdConta">{{{dados_bancarios_conta_response_idConta_value}}}.</param>
        /// <param name="CodigoBanco">{{{dados_bancarios_conta_response_banco_value}}}.</param>
        /// <param name="NumeroAgencia">{{{dados_bancarios_conta_response_agencia_value}}}.</param>
        /// <param name="NumeroContaCorrente">{{{dados_bancarios_conta_response_contaCorrente_value}}}.</param>
        /// <param name="IdTipoContaBancaria">{{{dados_bancarios_conta_response_IdTipoContaBancaria_value}}}.</param>
        /// <param name="DvContaCorrente">DvContaCorrente.</param>
        /// <param name="DvAgencia">DvAgencia.</param>

        public DadosBancariosContaResponse(long? Id = null, long? IdConta = null, long? CodigoBanco = null, long? NumeroAgencia = null, string NumeroContaCorrente = null, long? IdTipoContaBancaria = null, string DvContaCorrente = null, int? DvAgencia = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.CodigoBanco = CodigoBanco;
            this.NumeroAgencia = NumeroAgencia;
            this.NumeroContaCorrente = NumeroContaCorrente;
            this.IdTipoContaBancaria = IdTipoContaBancaria;
            this.DvContaCorrente = DvContaCorrente;
            this.DvAgencia = DvAgencia;
            
        }
        
    
        /// <summary>
        /// {{{dados_bancarios_conta_response_id_value}}}
        /// </summary>
        /// <value>{{{dados_bancarios_conta_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{dados_bancarios_conta_response_idConta_value}}}
        /// </summary>
        /// <value>{{{dados_bancarios_conta_response_idConta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{dados_bancarios_conta_response_banco_value}}}
        /// </summary>
        /// <value>{{{dados_bancarios_conta_response_banco_value}}}</value>
        [DataMember(Name="codigoBanco", EmitDefaultValue=false)]
        public long? CodigoBanco { get; set; }
    
        /// <summary>
        /// {{{dados_bancarios_conta_response_agencia_value}}}
        /// </summary>
        /// <value>{{{dados_bancarios_conta_response_agencia_value}}}</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public long? NumeroAgencia { get; set; }
    
        /// <summary>
        /// {{{dados_bancarios_conta_response_contaCorrente_value}}}
        /// </summary>
        /// <value>{{{dados_bancarios_conta_response_contaCorrente_value}}}</value>
        [DataMember(Name="numeroContaCorrente", EmitDefaultValue=false)]
        public string NumeroContaCorrente { get; set; }
    
        /// <summary>
        /// {{{dados_bancarios_conta_response_IdTipoContaBancaria_value}}}
        /// </summary>
        /// <value>{{{dados_bancarios_conta_response_IdTipoContaBancaria_value}}}</value>
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
            sb.Append("class DadosBancariosContaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  CodigoBanco: ").Append(CodigoBanco).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  NumeroContaCorrente: ").Append(NumeroContaCorrente).Append("\n");
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
            return this.Equals(obj as DadosBancariosContaResponse);
        }

        /// <summary>
        /// Returns true if DadosBancariosContaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DadosBancariosContaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DadosBancariosContaResponse other)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
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
                
                if (this.DvContaCorrente != null)
                    hash = hash * 59 + this.DvContaCorrente.GetHashCode();
                
                if (this.DvAgencia != null)
                    hash = hash * 59 + this.DvAgencia.GetHashCode();
                
                return hash;
            }
        }

    }
}
