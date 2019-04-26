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
    /// Objeto de resposta de uma transfer\u00EAncia de cr\u00E9ditos entre portadores
    /// </summary>
    [DataContract]
    public partial class TransferenciaPortadoresResponse :  IEquatable<TransferenciaPortadoresResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferenciaPortadoresResponse" /> class.
        /// Initializes a new instance of the <see cref="TransferenciaPortadoresResponse" />class.
        /// </summary>
        /// <param name="IdAjusteCredito">C\u00F3digo identificador do ajuste de cr\u00E9dito.</param>
        /// <param name="IdAjusteDebito">C\u00F3digo identificador do ajuste de d\u00E9bito.</param>

        public TransferenciaPortadoresResponse(long? IdAjusteCredito = null, long? IdAjusteDebito = null)
        {
            this.IdAjusteCredito = IdAjusteCredito;
            this.IdAjusteDebito = IdAjusteDebito;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo identificador do ajuste de cr\u00E9dito
        /// </summary>
        /// <value>C\u00F3digo identificador do ajuste de cr\u00E9dito</value>
        [DataMember(Name="idAjusteCredito", EmitDefaultValue=false)]
        public long? IdAjusteCredito { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do ajuste de d\u00E9bito
        /// </summary>
        /// <value>C\u00F3digo identificador do ajuste de d\u00E9bito</value>
        [DataMember(Name="idAjusteDebito", EmitDefaultValue=false)]
        public long? IdAjusteDebito { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferenciaPortadoresResponse {\n");
            sb.Append("  IdAjusteCredito: ").Append(IdAjusteCredito).Append("\n");
            sb.Append("  IdAjusteDebito: ").Append(IdAjusteDebito).Append("\n");
            
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
            return this.Equals(obj as TransferenciaPortadoresResponse);
        }

        /// <summary>
        /// Returns true if TransferenciaPortadoresResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TransferenciaPortadoresResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferenciaPortadoresResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdAjusteCredito == other.IdAjusteCredito ||
                    this.IdAjusteCredito != null &&
                    this.IdAjusteCredito.Equals(other.IdAjusteCredito)
                ) && 
                (
                    this.IdAjusteDebito == other.IdAjusteDebito ||
                    this.IdAjusteDebito != null &&
                    this.IdAjusteDebito.Equals(other.IdAjusteDebito)
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
                
                if (this.IdAjusteCredito != null)
                    hash = hash * 59 + this.IdAjusteCredito.GetHashCode();
                
                if (this.IdAjusteDebito != null)
                    hash = hash * 59 + this.IdAjusteDebito.GetHashCode();
                
                return hash;
            }
        }

    }
}
