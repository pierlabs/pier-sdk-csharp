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
    /// Representa\u00E7\u00E3o da resposta do recurso de status CNAB sumarizado
    /// </summary>
    [DataContract]
    public partial class StatusCnabSumarizadoResponse :  IEquatable<StatusCnabSumarizadoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusCnabSumarizadoResponse" /> class.
        /// Initializes a new instance of the <see cref="StatusCnabSumarizadoResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo identificador do status CNAB sumarizado.</param>
        /// <param name="Descricao">Descri\u00E7\u00E3o do status CNAB sumarizado.</param>
        /// <param name="FlagGerado">Flag que indica se foi gerado.</param>
        /// <param name="FlagEnviado">Flag que indica se foi enviado.</param>
        /// <param name="FlagRegistrado">Flag que indica se foi registrado.</param>
        /// <param name="FlagPago">Flag que indica se foi pago.</param>
        /// <param name="FlagRejeitado">Flag que indica se foi rejeitado.</param>
        /// <param name="FlagIgnorado">Flag que indica se foi ignorado.</param>
        /// <param name="FlagSemRange">Flag que indica se n\u00E3o possui range.</param>

        public StatusCnabSumarizadoResponse(long? Id = null, string Descricao = null, bool? FlagGerado = null, bool? FlagEnviado = null, bool? FlagRegistrado = null, bool? FlagPago = null, bool? FlagRejeitado = null, bool? FlagIgnorado = null, bool? FlagSemRange = null)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.FlagGerado = FlagGerado;
            this.FlagEnviado = FlagEnviado;
            this.FlagRegistrado = FlagRegistrado;
            this.FlagPago = FlagPago;
            this.FlagRejeitado = FlagRejeitado;
            this.FlagIgnorado = FlagIgnorado;
            this.FlagSemRange = FlagSemRange;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo identificador do status CNAB sumarizado
        /// </summary>
        /// <value>C\u00F3digo identificador do status CNAB sumarizado</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do status CNAB sumarizado
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do status CNAB sumarizado</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Flag que indica se foi gerado
        /// </summary>
        /// <value>Flag que indica se foi gerado</value>
        [DataMember(Name="flagGerado", EmitDefaultValue=false)]
        public bool? FlagGerado { get; set; }
    
        /// <summary>
        /// Flag que indica se foi enviado
        /// </summary>
        /// <value>Flag que indica se foi enviado</value>
        [DataMember(Name="flagEnviado", EmitDefaultValue=false)]
        public bool? FlagEnviado { get; set; }
    
        /// <summary>
        /// Flag que indica se foi registrado
        /// </summary>
        /// <value>Flag que indica se foi registrado</value>
        [DataMember(Name="flagRegistrado", EmitDefaultValue=false)]
        public bool? FlagRegistrado { get; set; }
    
        /// <summary>
        /// Flag que indica se foi pago
        /// </summary>
        /// <value>Flag que indica se foi pago</value>
        [DataMember(Name="flagPago", EmitDefaultValue=false)]
        public bool? FlagPago { get; set; }
    
        /// <summary>
        /// Flag que indica se foi rejeitado
        /// </summary>
        /// <value>Flag que indica se foi rejeitado</value>
        [DataMember(Name="flagRejeitado", EmitDefaultValue=false)]
        public bool? FlagRejeitado { get; set; }
    
        /// <summary>
        /// Flag que indica se foi ignorado
        /// </summary>
        /// <value>Flag que indica se foi ignorado</value>
        [DataMember(Name="flagIgnorado", EmitDefaultValue=false)]
        public bool? FlagIgnorado { get; set; }
    
        /// <summary>
        /// Flag que indica se n\u00E3o possui range
        /// </summary>
        /// <value>Flag que indica se n\u00E3o possui range</value>
        [DataMember(Name="flagSemRange", EmitDefaultValue=false)]
        public bool? FlagSemRange { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusCnabSumarizadoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  FlagGerado: ").Append(FlagGerado).Append("\n");
            sb.Append("  FlagEnviado: ").Append(FlagEnviado).Append("\n");
            sb.Append("  FlagRegistrado: ").Append(FlagRegistrado).Append("\n");
            sb.Append("  FlagPago: ").Append(FlagPago).Append("\n");
            sb.Append("  FlagRejeitado: ").Append(FlagRejeitado).Append("\n");
            sb.Append("  FlagIgnorado: ").Append(FlagIgnorado).Append("\n");
            sb.Append("  FlagSemRange: ").Append(FlagSemRange).Append("\n");
            
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
            return this.Equals(obj as StatusCnabSumarizadoResponse);
        }

        /// <summary>
        /// Returns true if StatusCnabSumarizadoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of StatusCnabSumarizadoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusCnabSumarizadoResponse other)
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
                ) && 
                (
                    this.FlagGerado == other.FlagGerado ||
                    this.FlagGerado != null &&
                    this.FlagGerado.Equals(other.FlagGerado)
                ) && 
                (
                    this.FlagEnviado == other.FlagEnviado ||
                    this.FlagEnviado != null &&
                    this.FlagEnviado.Equals(other.FlagEnviado)
                ) && 
                (
                    this.FlagRegistrado == other.FlagRegistrado ||
                    this.FlagRegistrado != null &&
                    this.FlagRegistrado.Equals(other.FlagRegistrado)
                ) && 
                (
                    this.FlagPago == other.FlagPago ||
                    this.FlagPago != null &&
                    this.FlagPago.Equals(other.FlagPago)
                ) && 
                (
                    this.FlagRejeitado == other.FlagRejeitado ||
                    this.FlagRejeitado != null &&
                    this.FlagRejeitado.Equals(other.FlagRejeitado)
                ) && 
                (
                    this.FlagIgnorado == other.FlagIgnorado ||
                    this.FlagIgnorado != null &&
                    this.FlagIgnorado.Equals(other.FlagIgnorado)
                ) && 
                (
                    this.FlagSemRange == other.FlagSemRange ||
                    this.FlagSemRange != null &&
                    this.FlagSemRange.Equals(other.FlagSemRange)
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
                
                if (this.FlagGerado != null)
                    hash = hash * 59 + this.FlagGerado.GetHashCode();
                
                if (this.FlagEnviado != null)
                    hash = hash * 59 + this.FlagEnviado.GetHashCode();
                
                if (this.FlagRegistrado != null)
                    hash = hash * 59 + this.FlagRegistrado.GetHashCode();
                
                if (this.FlagPago != null)
                    hash = hash * 59 + this.FlagPago.GetHashCode();
                
                if (this.FlagRejeitado != null)
                    hash = hash * 59 + this.FlagRejeitado.GetHashCode();
                
                if (this.FlagIgnorado != null)
                    hash = hash * 59 + this.FlagIgnorado.GetHashCode();
                
                if (this.FlagSemRange != null)
                    hash = hash * 59 + this.FlagSemRange.GetHashCode();
                
                return hash;
            }
        }

    }
}
