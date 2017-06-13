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
    /// Objeto de Requisi\u00C3\u00A7\u00C3\u00A3o de Taxa de Antecipa\u00C3\u00A7\u00C3\u00A3o
    /// </summary>
    [DataContract]
    public partial class TaxaAntecipacaoRequest :  IEquatable<TaxaAntecipacaoRequest>
    { 
    
        /// <summary>
        /// C\u00C3\u00B3digo que identifica se um par\u00C3\u00A2metro refere-se a uma transa\u00C3\u00A7\u00C3\u00A3o On-Us ou Off-Us.
        /// </summary>
        /// <value>C\u00C3\u00B3digo que identifica se um par\u00C3\u00A2metro refere-se a uma transa\u00C3\u00A7\u00C3\u00A3o On-Us ou Off-Us.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoTransacaoEnum {
            
            [EnumMember(Value = "ON_US")]
            OnUs,
            
            [EnumMember(Value = "OFF_US")]
            OffUs
        }

    
        /// <summary>
        /// C\u00C3\u00B3digo que identifica se um par\u00C3\u00A2metro refere-se a uma transa\u00C3\u00A7\u00C3\u00A3o On-Us ou Off-Us.
        /// </summary>
        /// <value>C\u00C3\u00B3digo que identifica se um par\u00C3\u00A2metro refere-se a uma transa\u00C3\u00A7\u00C3\u00A3o On-Us ou Off-Us.</value>
        [DataMember(Name="tipoTransacao", EmitDefaultValue=false)]
        public TipoTransacaoEnum? TipoTransacao { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxaAntecipacaoRequest" /> class.
        /// Initializes a new instance of the <see cref="TaxaAntecipacaoRequest" />class.
        /// </summary>
        /// <param name="TipoTransacao">C\u00C3\u00B3digo que identifica se um par\u00C3\u00A2metro refere-se a uma transa\u00C3\u00A7\u00C3\u00A3o On-Us ou Off-Us..</param>
        /// <param name="ValorTaxa">Valor da Taxa de Antecipa\u00C3\u00A7\u00C3\u00A3o..</param>

        public TaxaAntecipacaoRequest(TipoTransacaoEnum? TipoTransacao = null, double? ValorTaxa = null)
        {
            this.TipoTransacao = TipoTransacao;
            this.ValorTaxa = ValorTaxa;
            
        }
        
    
        /// <summary>
        /// Valor da Taxa de Antecipa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Valor da Taxa de Antecipa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="valorTaxa", EmitDefaultValue=false)]
        public double? ValorTaxa { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxaAntecipacaoRequest {\n");
            sb.Append("  TipoTransacao: ").Append(TipoTransacao).Append("\n");
            sb.Append("  ValorTaxa: ").Append(ValorTaxa).Append("\n");
            
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
            return this.Equals(obj as TaxaAntecipacaoRequest);
        }

        /// <summary>
        /// Returns true if TaxaAntecipacaoRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of TaxaAntecipacaoRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxaAntecipacaoRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TipoTransacao == other.TipoTransacao ||
                    this.TipoTransacao != null &&
                    this.TipoTransacao.Equals(other.TipoTransacao)
                ) && 
                (
                    this.ValorTaxa == other.ValorTaxa ||
                    this.ValorTaxa != null &&
                    this.ValorTaxa.Equals(other.ValorTaxa)
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
                
                if (this.TipoTransacao != null)
                    hash = hash * 59 + this.TipoTransacao.GetHashCode();
                
                if (this.ValorTaxa != null)
                    hash = hash * 59 + this.ValorTaxa.GetHashCode();
                
                return hash;
            }
        }

    }
}
