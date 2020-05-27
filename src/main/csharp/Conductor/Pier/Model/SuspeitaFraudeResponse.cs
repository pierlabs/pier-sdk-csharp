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
    /// Objeto que represensa o response da suspeita de fraude
    /// </summary>
    [DataContract]
    public partial class SuspeitaFraudeResponse :  IEquatable<SuspeitaFraudeResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SuspeitaFraudeResponse" /> class.
        /// Initializes a new instance of the <see cref="SuspeitaFraudeResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo de identifica\u00E7\u00E3o da suspeita de fraude.</param>
        /// <param name="IdMotivoFraude">C\u00F3digo de identifica\u00E7\u00E3o do motivo da suspeita de fraude.</param>
        /// <param name="IdPessoa">C\u00F3digo de identifica\u00E7\u00E3o da pessoa com suspeita de fraude.</param>
        /// <param name="DataHoraSuspeitaFraude">Data e hora em que foi identificado a suspeita de fraude.</param>
        /// <param name="DataHoraCriacao">Data e hora em que o cadastro foi realizado no PIER.</param>

        public SuspeitaFraudeResponse(long? Id = null, long? IdMotivoFraude = null, long? IdPessoa = null, string DataHoraSuspeitaFraude = null, string DataHoraCriacao = null)
        {
            this.Id = Id;
            this.IdMotivoFraude = IdMotivoFraude;
            this.IdPessoa = IdPessoa;
            this.DataHoraSuspeitaFraude = DataHoraSuspeitaFraude;
            this.DataHoraCriacao = DataHoraCriacao;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da suspeita de fraude
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da suspeita de fraude</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do motivo da suspeita de fraude
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do motivo da suspeita de fraude</value>
        [DataMember(Name="idMotivoFraude", EmitDefaultValue=false)]
        public long? IdMotivoFraude { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da pessoa com suspeita de fraude
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da pessoa com suspeita de fraude</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Data e hora em que foi identificado a suspeita de fraude
        /// </summary>
        /// <value>Data e hora em que foi identificado a suspeita de fraude</value>
        [DataMember(Name="dataHoraSuspeitaFraude", EmitDefaultValue=false)]
        public string DataHoraSuspeitaFraude { get; set; }
    
        /// <summary>
        /// Data e hora em que o cadastro foi realizado no PIER
        /// </summary>
        /// <value>Data e hora em que o cadastro foi realizado no PIER</value>
        [DataMember(Name="dataHoraCriacao", EmitDefaultValue=false)]
        public string DataHoraCriacao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuspeitaFraudeResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdMotivoFraude: ").Append(IdMotivoFraude).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  DataHoraSuspeitaFraude: ").Append(DataHoraSuspeitaFraude).Append("\n");
            sb.Append("  DataHoraCriacao: ").Append(DataHoraCriacao).Append("\n");
            
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
            return this.Equals(obj as SuspeitaFraudeResponse);
        }

        /// <summary>
        /// Returns true if SuspeitaFraudeResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SuspeitaFraudeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuspeitaFraudeResponse other)
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
                    this.IdMotivoFraude == other.IdMotivoFraude ||
                    this.IdMotivoFraude != null &&
                    this.IdMotivoFraude.Equals(other.IdMotivoFraude)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.DataHoraSuspeitaFraude == other.DataHoraSuspeitaFraude ||
                    this.DataHoraSuspeitaFraude != null &&
                    this.DataHoraSuspeitaFraude.Equals(other.DataHoraSuspeitaFraude)
                ) && 
                (
                    this.DataHoraCriacao == other.DataHoraCriacao ||
                    this.DataHoraCriacao != null &&
                    this.DataHoraCriacao.Equals(other.DataHoraCriacao)
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
                
                if (this.IdMotivoFraude != null)
                    hash = hash * 59 + this.IdMotivoFraude.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.DataHoraSuspeitaFraude != null)
                    hash = hash * 59 + this.DataHoraSuspeitaFraude.GetHashCode();
                
                if (this.DataHoraCriacao != null)
                    hash = hash * 59 + this.DataHoraCriacao.GetHashCode();
                
                return hash;
            }
        }

    }
}
