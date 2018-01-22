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
    /// Objeto contendo os detalhes de uma fatura consignada
    /// </summary>
    [DataContract]
    public partial class DetalhesFaturaConsignadaResponse :  IEquatable<DetalhesFaturaConsignadaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DetalhesFaturaConsignadaResponse" /> class.
        /// Initializes a new instance of the <see cref="DetalhesFaturaConsignadaResponse" />class.
        /// </summary>
        /// <param name="FaturaConsignadaResponse">Apresenta os detalhes da fatura.</param>
        /// <param name="Transacoes">Apresenta as transa\u00C3\u00A7\u00C3\u00B5es relacionadas a fatura..</param>

        public DetalhesFaturaConsignadaResponse(FaturaConsignadaResponse FaturaConsignadaResponse = null, List<TransacoesCorrentesResponse> Transacoes = null)
        {
            this.FaturaConsignadaResponse = FaturaConsignadaResponse;
            this.Transacoes = Transacoes;
            
        }
        
    
        /// <summary>
        /// Apresenta os detalhes da fatura
        /// </summary>
        /// <value>Apresenta os detalhes da fatura</value>
        [DataMember(Name="faturaConsignadaResponse", EmitDefaultValue=false)]
        public FaturaConsignadaResponse FaturaConsignadaResponse { get; set; }
    
        /// <summary>
        /// Apresenta as transa\u00C3\u00A7\u00C3\u00B5es relacionadas a fatura.
        /// </summary>
        /// <value>Apresenta as transa\u00C3\u00A7\u00C3\u00B5es relacionadas a fatura.</value>
        [DataMember(Name="transacoes", EmitDefaultValue=false)]
        public List<TransacoesCorrentesResponse> Transacoes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetalhesFaturaConsignadaResponse {\n");
            sb.Append("  FaturaConsignadaResponse: ").Append(FaturaConsignadaResponse).Append("\n");
            sb.Append("  Transacoes: ").Append(Transacoes).Append("\n");
            
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
            return this.Equals(obj as DetalhesFaturaConsignadaResponse);
        }

        /// <summary>
        /// Returns true if DetalhesFaturaConsignadaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DetalhesFaturaConsignadaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetalhesFaturaConsignadaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FaturaConsignadaResponse == other.FaturaConsignadaResponse ||
                    this.FaturaConsignadaResponse != null &&
                    this.FaturaConsignadaResponse.Equals(other.FaturaConsignadaResponse)
                ) && 
                (
                    this.Transacoes == other.Transacoes ||
                    this.Transacoes != null &&
                    this.Transacoes.SequenceEqual(other.Transacoes)
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
                
                if (this.FaturaConsignadaResponse != null)
                    hash = hash * 59 + this.FaturaConsignadaResponse.GetHashCode();
                
                if (this.Transacoes != null)
                    hash = hash * 59 + this.Transacoes.GetHashCode();
                
                return hash;
            }
        }

    }
}
