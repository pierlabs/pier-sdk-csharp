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
    /// Representa\u00E7\u00E3o do response da proje\u00E7\u00E3o de compras n\u00E3o processadas
    /// </summary>
    [DataContract]
    public partial class ProjecaoCompraNaoProcessadaResponse :  IEquatable<ProjecaoCompraNaoProcessadaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjecaoCompraNaoProcessadaResponse" /> class.
        /// Initializes a new instance of the <see cref="ProjecaoCompraNaoProcessadaResponse" />class.
        /// </summary>
        /// <param name="IdConta">C\u00F3digo de identifica\u00E7\u00E3o da conta.</param>
        /// <param name="DataVencimentoFatura">Data de vencimento padr\u00E3o da proje\u00E7\u00E3o em formato AAAA-MM-DD.</param>
        /// <param name="ValorTotal">Valor total da proje\u00E7\u00E3o.</param>
        /// <param name="DataVencimentoReal">Data de vencimento real da proje\u00E7\u00E3o em formato AAAA-MM-DD.</param>
        /// <param name="DataCorte">Data de corte da proje\u00E7\u00E3o em formato AAAA-MM-DD.</param>

        public ProjecaoCompraNaoProcessadaResponse(long? IdConta = null, string DataVencimentoFatura = null, double? ValorTotal = null, string DataVencimentoReal = null, string DataCorte = null)
        {
            this.IdConta = IdConta;
            this.DataVencimentoFatura = DataVencimentoFatura;
            this.ValorTotal = ValorTotal;
            this.DataVencimentoReal = DataVencimentoReal;
            this.DataCorte = DataCorte;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da conta
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Data de vencimento padr\u00E3o da proje\u00E7\u00E3o em formato AAAA-MM-DD
        /// </summary>
        /// <value>Data de vencimento padr\u00E3o da proje\u00E7\u00E3o em formato AAAA-MM-DD</value>
        [DataMember(Name="dataVencimentoFatura", EmitDefaultValue=false)]
        public string DataVencimentoFatura { get; set; }
    
        /// <summary>
        /// Valor total da proje\u00E7\u00E3o
        /// </summary>
        /// <value>Valor total da proje\u00E7\u00E3o</value>
        [DataMember(Name="valorTotal", EmitDefaultValue=false)]
        public double? ValorTotal { get; set; }
    
        /// <summary>
        /// Data de vencimento real da proje\u00E7\u00E3o em formato AAAA-MM-DD
        /// </summary>
        /// <value>Data de vencimento real da proje\u00E7\u00E3o em formato AAAA-MM-DD</value>
        [DataMember(Name="dataVencimentoReal", EmitDefaultValue=false)]
        public string DataVencimentoReal { get; set; }
    
        /// <summary>
        /// Data de corte da proje\u00E7\u00E3o em formato AAAA-MM-DD
        /// </summary>
        /// <value>Data de corte da proje\u00E7\u00E3o em formato AAAA-MM-DD</value>
        [DataMember(Name="dataCorte", EmitDefaultValue=false)]
        public string DataCorte { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjecaoCompraNaoProcessadaResponse {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  DataVencimentoFatura: ").Append(DataVencimentoFatura).Append("\n");
            sb.Append("  ValorTotal: ").Append(ValorTotal).Append("\n");
            sb.Append("  DataVencimentoReal: ").Append(DataVencimentoReal).Append("\n");
            sb.Append("  DataCorte: ").Append(DataCorte).Append("\n");
            
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
            return this.Equals(obj as ProjecaoCompraNaoProcessadaResponse);
        }

        /// <summary>
        /// Returns true if ProjecaoCompraNaoProcessadaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ProjecaoCompraNaoProcessadaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjecaoCompraNaoProcessadaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.DataVencimentoFatura == other.DataVencimentoFatura ||
                    this.DataVencimentoFatura != null &&
                    this.DataVencimentoFatura.Equals(other.DataVencimentoFatura)
                ) && 
                (
                    this.ValorTotal == other.ValorTotal ||
                    this.ValorTotal != null &&
                    this.ValorTotal.Equals(other.ValorTotal)
                ) && 
                (
                    this.DataVencimentoReal == other.DataVencimentoReal ||
                    this.DataVencimentoReal != null &&
                    this.DataVencimentoReal.Equals(other.DataVencimentoReal)
                ) && 
                (
                    this.DataCorte == other.DataCorte ||
                    this.DataCorte != null &&
                    this.DataCorte.Equals(other.DataCorte)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.DataVencimentoFatura != null)
                    hash = hash * 59 + this.DataVencimentoFatura.GetHashCode();
                
                if (this.ValorTotal != null)
                    hash = hash * 59 + this.ValorTotal.GetHashCode();
                
                if (this.DataVencimentoReal != null)
                    hash = hash * 59 + this.DataVencimentoReal.GetHashCode();
                
                if (this.DataCorte != null)
                    hash = hash * 59 + this.DataCorte.GetHashCode();
                
                return hash;
            }
        }

    }
}
