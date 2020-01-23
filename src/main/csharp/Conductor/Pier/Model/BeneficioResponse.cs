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
    /// Objeto de resposta do benef\u00EDcio
    /// </summary>
    [DataContract]
    public partial class BeneficioResponse :  IEquatable<BeneficioResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BeneficioResponse" /> class.
        /// Initializes a new instance of the <see cref="BeneficioResponse" />class.
        /// </summary>
        /// <param name="Id">Identificador do benef\u00EDcio.</param>
        /// <param name="IdConta">Identificador da conta.</param>
        /// <param name="NumeroBeneficio">N\u00FAmero do benef\u00EDcio.</param>
        /// <param name="MesProvaVida">M\u00EAs de prova de vida do benefici\u00E1rio.</param>
        /// <param name="Status">Status do benef\u00EDcio(1 = ATIVO, 0 = INATIVO).</param>
        /// <param name="TipoBeneficio">Tipo do benef\u00EDcio.</param>

        public BeneficioResponse(long? Id = null, long? IdConta = null, string NumeroBeneficio = null, int? MesProvaVida = null, bool? Status = null, string TipoBeneficio = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.NumeroBeneficio = NumeroBeneficio;
            this.MesProvaVida = MesProvaVida;
            this.Status = Status;
            this.TipoBeneficio = TipoBeneficio;
            
        }
        
    
        /// <summary>
        /// Identificador do benef\u00EDcio
        /// </summary>
        /// <value>Identificador do benef\u00EDcio</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Identificador da conta
        /// </summary>
        /// <value>Identificador da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// N\u00FAmero do benef\u00EDcio
        /// </summary>
        /// <value>N\u00FAmero do benef\u00EDcio</value>
        [DataMember(Name="numeroBeneficio", EmitDefaultValue=false)]
        public string NumeroBeneficio { get; set; }
    
        /// <summary>
        /// M\u00EAs de prova de vida do benefici\u00E1rio
        /// </summary>
        /// <value>M\u00EAs de prova de vida do benefici\u00E1rio</value>
        [DataMember(Name="mesProvaVida", EmitDefaultValue=false)]
        public int? MesProvaVida { get; set; }
    
        /// <summary>
        /// Status do benef\u00EDcio(1 = ATIVO, 0 = INATIVO)
        /// </summary>
        /// <value>Status do benef\u00EDcio(1 = ATIVO, 0 = INATIVO)</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public bool? Status { get; set; }
    
        /// <summary>
        /// Tipo do benef\u00EDcio
        /// </summary>
        /// <value>Tipo do benef\u00EDcio</value>
        [DataMember(Name="tipoBeneficio", EmitDefaultValue=false)]
        public string TipoBeneficio { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeneficioResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  NumeroBeneficio: ").Append(NumeroBeneficio).Append("\n");
            sb.Append("  MesProvaVida: ").Append(MesProvaVida).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TipoBeneficio: ").Append(TipoBeneficio).Append("\n");
            
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
            return this.Equals(obj as BeneficioResponse);
        }

        /// <summary>
        /// Returns true if BeneficioResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BeneficioResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeneficioResponse other)
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
                    this.NumeroBeneficio == other.NumeroBeneficio ||
                    this.NumeroBeneficio != null &&
                    this.NumeroBeneficio.Equals(other.NumeroBeneficio)
                ) && 
                (
                    this.MesProvaVida == other.MesProvaVida ||
                    this.MesProvaVida != null &&
                    this.MesProvaVida.Equals(other.MesProvaVida)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.TipoBeneficio == other.TipoBeneficio ||
                    this.TipoBeneficio != null &&
                    this.TipoBeneficio.Equals(other.TipoBeneficio)
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
                
                if (this.NumeroBeneficio != null)
                    hash = hash * 59 + this.NumeroBeneficio.GetHashCode();
                
                if (this.MesProvaVida != null)
                    hash = hash * 59 + this.MesProvaVida.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.TipoBeneficio != null)
                    hash = hash * 59 + this.TipoBeneficio.GetHashCode();
                
                return hash;
            }
        }

    }
}
