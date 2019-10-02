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
    /// 
    /// </summary>
    [DataContract]
    public partial class TipoProdutoPersist :  IEquatable<TipoProdutoPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoProdutoPersist" /> class.
        /// Initializes a new instance of the <see cref="TipoProdutoPersist" />class.
        /// </summary>
        /// <param name="Descricao">Descricao.</param>
        /// <param name="FlagAntecipacao">FlagAntecipacao.</param>
        /// <param name="FlagConsignada">FlagConsignada.</param>
        /// <param name="FlagCreditoBeneficio">FlagCreditoBeneficio.</param>
        /// <param name="FlagPrePago">FlagPrePago.</param>

        public TipoProdutoPersist(string Descricao = null, int? FlagAntecipacao = null, int? FlagConsignada = null, int? FlagCreditoBeneficio = null, int? FlagPrePago = null)
        {
            this.Descricao = Descricao;
            this.FlagAntecipacao = FlagAntecipacao;
            this.FlagConsignada = FlagConsignada;
            this.FlagCreditoBeneficio = FlagCreditoBeneficio;
            this.FlagPrePago = FlagPrePago;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Descricao
        /// </summary>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagAntecipacao
        /// </summary>
        [DataMember(Name="flagAntecipacao", EmitDefaultValue=false)]
        public int? FlagAntecipacao { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagConsignada
        /// </summary>
        [DataMember(Name="flagConsignada", EmitDefaultValue=false)]
        public int? FlagConsignada { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagCreditoBeneficio
        /// </summary>
        [DataMember(Name="flagCreditoBeneficio", EmitDefaultValue=false)]
        public int? FlagCreditoBeneficio { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagPrePago
        /// </summary>
        [DataMember(Name="flagPrePago", EmitDefaultValue=false)]
        public int? FlagPrePago { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoProdutoPersist {\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  FlagAntecipacao: ").Append(FlagAntecipacao).Append("\n");
            sb.Append("  FlagConsignada: ").Append(FlagConsignada).Append("\n");
            sb.Append("  FlagCreditoBeneficio: ").Append(FlagCreditoBeneficio).Append("\n");
            sb.Append("  FlagPrePago: ").Append(FlagPrePago).Append("\n");
            
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
            return this.Equals(obj as TipoProdutoPersist);
        }

        /// <summary>
        /// Returns true if TipoProdutoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoProdutoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoProdutoPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.FlagAntecipacao == other.FlagAntecipacao ||
                    this.FlagAntecipacao != null &&
                    this.FlagAntecipacao.Equals(other.FlagAntecipacao)
                ) && 
                (
                    this.FlagConsignada == other.FlagConsignada ||
                    this.FlagConsignada != null &&
                    this.FlagConsignada.Equals(other.FlagConsignada)
                ) && 
                (
                    this.FlagCreditoBeneficio == other.FlagCreditoBeneficio ||
                    this.FlagCreditoBeneficio != null &&
                    this.FlagCreditoBeneficio.Equals(other.FlagCreditoBeneficio)
                ) && 
                (
                    this.FlagPrePago == other.FlagPrePago ||
                    this.FlagPrePago != null &&
                    this.FlagPrePago.Equals(other.FlagPrePago)
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
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.FlagAntecipacao != null)
                    hash = hash * 59 + this.FlagAntecipacao.GetHashCode();
                
                if (this.FlagConsignada != null)
                    hash = hash * 59 + this.FlagConsignada.GetHashCode();
                
                if (this.FlagCreditoBeneficio != null)
                    hash = hash * 59 + this.FlagCreditoBeneficio.GetHashCode();
                
                if (this.FlagPrePago != null)
                    hash = hash * 59 + this.FlagPrePago.GetHashCode();
                
                return hash;
            }
        }

    }
}
