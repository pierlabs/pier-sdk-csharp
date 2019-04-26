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
    /// Representa o objeto de resposta para Benefio Paa Pagamento atrasado
    /// </summary>
    [DataContract]
    public partial class BeneficioPagamentoAtrasoResponse :  IEquatable<BeneficioPagamentoAtrasoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BeneficioPagamentoAtrasoResponse" /> class.
        /// Initializes a new instance of the <see cref="BeneficioPagamentoAtrasoResponse" />class.
        /// </summary>
        /// <param name="DataBeneficio">Data m\u00E1xima para pagamento da fatura em atraso para receber o benef\u00EDcio de isen\u00E7\u00E3o total no pagamento de multa, encargos, mora e IOF.</param>

        public BeneficioPagamentoAtrasoResponse(string DataBeneficio = null)
        {
            this.DataBeneficio = DataBeneficio;
            
        }
        
    
        /// <summary>
        /// Data m\u00E1xima para pagamento da fatura em atraso para receber o benef\u00EDcio de isen\u00E7\u00E3o total no pagamento de multa, encargos, mora e IOF
        /// </summary>
        /// <value>Data m\u00E1xima para pagamento da fatura em atraso para receber o benef\u00EDcio de isen\u00E7\u00E3o total no pagamento de multa, encargos, mora e IOF</value>
        [DataMember(Name="dataBeneficio", EmitDefaultValue=false)]
        public string DataBeneficio { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeneficioPagamentoAtrasoResponse {\n");
            sb.Append("  DataBeneficio: ").Append(DataBeneficio).Append("\n");
            
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
            return this.Equals(obj as BeneficioPagamentoAtrasoResponse);
        }

        /// <summary>
        /// Returns true if BeneficioPagamentoAtrasoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BeneficioPagamentoAtrasoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeneficioPagamentoAtrasoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataBeneficio == other.DataBeneficio ||
                    this.DataBeneficio != null &&
                    this.DataBeneficio.Equals(other.DataBeneficio)
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
                
                if (this.DataBeneficio != null)
                    hash = hash * 59 + this.DataBeneficio.GetHashCode();
                
                return hash;
            }
        }

    }
}
