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
    /// Lista Cota\u00E7\u00F5es Dolar
    /// </summary>
    [DataContract]
    public partial class CotacaoDolarResponse :  IEquatable<CotacaoDolarResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CotacaoDolarResponse" /> class.
        /// Initializes a new instance of the <see cref="CotacaoDolarResponse" />class.
        /// </summary>
        /// <param name="DataFechamento">Data de fechamento.</param>
        /// <param name="TaxaPtax">Taxa PTAX.</param>
        /// <param name="TaxaSpread">Taxa de Spreead.</param>
        /// <param name="TaxaCartao">Taxa de convers\u00E3o de Dollar para Real.</param>

        public CotacaoDolarResponse(string DataFechamento = null, double? TaxaPtax = null, double? TaxaSpread = null, double? TaxaCartao = null)
        {
            this.DataFechamento = DataFechamento;
            this.TaxaPtax = TaxaPtax;
            this.TaxaSpread = TaxaSpread;
            this.TaxaCartao = TaxaCartao;
            
        }
        
    
        /// <summary>
        /// Data de fechamento
        /// </summary>
        /// <value>Data de fechamento</value>
        [DataMember(Name="dataFechamento", EmitDefaultValue=false)]
        public string DataFechamento { get; set; }
    
        /// <summary>
        /// Taxa PTAX
        /// </summary>
        /// <value>Taxa PTAX</value>
        [DataMember(Name="taxaPtax", EmitDefaultValue=false)]
        public double? TaxaPtax { get; set; }
    
        /// <summary>
        /// Taxa de Spreead
        /// </summary>
        /// <value>Taxa de Spreead</value>
        [DataMember(Name="taxaSpread", EmitDefaultValue=false)]
        public double? TaxaSpread { get; set; }
    
        /// <summary>
        /// Taxa de convers\u00E3o de Dollar para Real
        /// </summary>
        /// <value>Taxa de convers\u00E3o de Dollar para Real</value>
        [DataMember(Name="taxaCartao", EmitDefaultValue=false)]
        public double? TaxaCartao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CotacaoDolarResponse {\n");
            sb.Append("  DataFechamento: ").Append(DataFechamento).Append("\n");
            sb.Append("  TaxaPtax: ").Append(TaxaPtax).Append("\n");
            sb.Append("  TaxaSpread: ").Append(TaxaSpread).Append("\n");
            sb.Append("  TaxaCartao: ").Append(TaxaCartao).Append("\n");
            
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
            return this.Equals(obj as CotacaoDolarResponse);
        }

        /// <summary>
        /// Returns true if CotacaoDolarResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CotacaoDolarResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CotacaoDolarResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataFechamento == other.DataFechamento ||
                    this.DataFechamento != null &&
                    this.DataFechamento.Equals(other.DataFechamento)
                ) && 
                (
                    this.TaxaPtax == other.TaxaPtax ||
                    this.TaxaPtax != null &&
                    this.TaxaPtax.Equals(other.TaxaPtax)
                ) && 
                (
                    this.TaxaSpread == other.TaxaSpread ||
                    this.TaxaSpread != null &&
                    this.TaxaSpread.Equals(other.TaxaSpread)
                ) && 
                (
                    this.TaxaCartao == other.TaxaCartao ||
                    this.TaxaCartao != null &&
                    this.TaxaCartao.Equals(other.TaxaCartao)
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
                
                if (this.DataFechamento != null)
                    hash = hash * 59 + this.DataFechamento.GetHashCode();
                
                if (this.TaxaPtax != null)
                    hash = hash * 59 + this.TaxaPtax.GetHashCode();
                
                if (this.TaxaSpread != null)
                    hash = hash * 59 + this.TaxaSpread.GetHashCode();
                
                if (this.TaxaCartao != null)
                    hash = hash * 59 + this.TaxaCartao.GetHashCode();
                
                return hash;
            }
        }

    }
}
