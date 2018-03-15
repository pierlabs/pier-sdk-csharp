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
    /// Hist\u00F3rico Pagamento Fatura Atraso
    /// </summary>
    [DataContract]
    public partial class HistoricoAtrasoFaturaResponse :  IEquatable<HistoricoAtrasoFaturaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricoAtrasoFaturaResponse" /> class.
        /// Initializes a new instance of the <see cref="HistoricoAtrasoFaturaResponse" />class.
        /// </summary>
        /// <param name="DataVencimento">Data vencimento fatura..</param>
        /// <param name="DiasPagamentoAposVencimento">Quantidade de dias em atraso..</param>

        public HistoricoAtrasoFaturaResponse(string DataVencimento = null, long? DiasPagamentoAposVencimento = null)
        {
            this.DataVencimento = DataVencimento;
            this.DiasPagamentoAposVencimento = DiasPagamentoAposVencimento;
            
        }
        
    
        /// <summary>
        /// Data vencimento fatura.
        /// </summary>
        /// <value>Data vencimento fatura.</value>
        [DataMember(Name="dataVencimento", EmitDefaultValue=false)]
        public string DataVencimento { get; set; }
    
        /// <summary>
        /// Quantidade de dias em atraso.
        /// </summary>
        /// <value>Quantidade de dias em atraso.</value>
        [DataMember(Name="diasPagamentoAposVencimento", EmitDefaultValue=false)]
        public long? DiasPagamentoAposVencimento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricoAtrasoFaturaResponse {\n");
            sb.Append("  DataVencimento: ").Append(DataVencimento).Append("\n");
            sb.Append("  DiasPagamentoAposVencimento: ").Append(DiasPagamentoAposVencimento).Append("\n");
            
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
            return this.Equals(obj as HistoricoAtrasoFaturaResponse);
        }

        /// <summary>
        /// Returns true if HistoricoAtrasoFaturaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of HistoricoAtrasoFaturaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricoAtrasoFaturaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataVencimento == other.DataVencimento ||
                    this.DataVencimento != null &&
                    this.DataVencimento.Equals(other.DataVencimento)
                ) && 
                (
                    this.DiasPagamentoAposVencimento == other.DiasPagamentoAposVencimento ||
                    this.DiasPagamentoAposVencimento != null &&
                    this.DiasPagamentoAposVencimento.Equals(other.DiasPagamentoAposVencimento)
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
                
                if (this.DataVencimento != null)
                    hash = hash * 59 + this.DataVencimento.GetHashCode();
                
                if (this.DiasPagamentoAposVencimento != null)
                    hash = hash * 59 + this.DiasPagamentoAposVencimento.GetHashCode();
                
                return hash;
            }
        }

    }
}
