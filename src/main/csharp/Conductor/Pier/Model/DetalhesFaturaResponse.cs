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
    /// Object Containing the details of an invoice
    /// </summary>
    [DataContract]
    public partial class DetalhesFaturaResponse :  IEquatable<DetalhesFaturaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DetalhesFaturaResponse" /> class.
        /// Initializes a new instance of the <see cref="DetalhesFaturaResponse" />class.
        /// </summary>
        /// <param name="Fatura">Show the details of the invoice.</param>
        /// <param name="Transacoes">Show the transactions related to the invoice.</param>

        public DetalhesFaturaResponse(FaturaFechadaResponse Fatura = null, List<TransacoesCorrentesResponse> Transacoes = null)
        {
            this.Fatura = Fatura;
            this.Transacoes = Transacoes;
            
        }
        
    
        /// <summary>
        /// Show the details of the invoice
        /// </summary>
        /// <value>Show the details of the invoice</value>
        [DataMember(Name="fatura", EmitDefaultValue=false)]
        public FaturaFechadaResponse Fatura { get; set; }
    
        /// <summary>
        /// Show the transactions related to the invoice
        /// </summary>
        /// <value>Show the transactions related to the invoice</value>
        [DataMember(Name="transacoes", EmitDefaultValue=false)]
        public List<TransacoesCorrentesResponse> Transacoes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetalhesFaturaResponse {\n");
            sb.Append("  Fatura: ").Append(Fatura).Append("\n");
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
            return this.Equals(obj as DetalhesFaturaResponse);
        }

        /// <summary>
        /// Returns true if DetalhesFaturaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DetalhesFaturaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetalhesFaturaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Fatura == other.Fatura ||
                    this.Fatura != null &&
                    this.Fatura.Equals(other.Fatura)
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
                
                if (this.Fatura != null)
                    hash = hash * 59 + this.Fatura.GetHashCode();
                
                if (this.Transacoes != null)
                    hash = hash * 59 + this.Transacoes.GetHashCode();
                
                return hash;
            }
        }

    }
}
