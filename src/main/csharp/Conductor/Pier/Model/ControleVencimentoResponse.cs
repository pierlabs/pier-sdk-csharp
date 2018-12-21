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
    /// Object of the response of the Expirations
    /// </summary>
    [DataContract]
    public partial class ControleVencimentoResponse :  IEquatable<ControleVencimentoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ControleVencimentoResponse" /> class.
        /// Initializes a new instance of the <see cref="ControleVencimentoResponse" />class.
        /// </summary>
        /// <param name="DataVencimento">Indicate the date of expiration of the invoices.</param>
        /// <param name="DataPrevistaCorte">Indicate the date previewed to make the cut of the invoices.</param>
        /// <param name="DataHoraRealizacaoCorte">Indicate the date and the time that was made the Cut of the invoices.</param>
        /// <param name="DataPrevistaFaturamento">Indicate the date previewed to make the billing.</param>
        /// <param name="DataHoraRealizacaoFaturamento">Indicate the date and the time that was made the billing.</param>
        /// <param name="DataRealVencimento">Indicate the useful day that will be considered as the expiration date.</param>

        public ControleVencimentoResponse(string DataVencimento = null, string DataPrevistaCorte = null, string DataHoraRealizacaoCorte = null, string DataPrevistaFaturamento = null, string DataHoraRealizacaoFaturamento = null, string DataRealVencimento = null)
        {
            this.DataVencimento = DataVencimento;
            this.DataPrevistaCorte = DataPrevistaCorte;
            this.DataHoraRealizacaoCorte = DataHoraRealizacaoCorte;
            this.DataPrevistaFaturamento = DataPrevistaFaturamento;
            this.DataHoraRealizacaoFaturamento = DataHoraRealizacaoFaturamento;
            this.DataRealVencimento = DataRealVencimento;
            
        }
        
    
        /// <summary>
        /// Indicate the date of expiration of the invoices
        /// </summary>
        /// <value>Indicate the date of expiration of the invoices</value>
        [DataMember(Name="dataVencimento", EmitDefaultValue=false)]
        public string DataVencimento { get; set; }
    
        /// <summary>
        /// Indicate the date previewed to make the cut of the invoices
        /// </summary>
        /// <value>Indicate the date previewed to make the cut of the invoices</value>
        [DataMember(Name="dataPrevistaCorte", EmitDefaultValue=false)]
        public string DataPrevistaCorte { get; set; }
    
        /// <summary>
        /// Indicate the date and the time that was made the Cut of the invoices
        /// </summary>
        /// <value>Indicate the date and the time that was made the Cut of the invoices</value>
        [DataMember(Name="dataHoraRealizacaoCorte", EmitDefaultValue=false)]
        public string DataHoraRealizacaoCorte { get; set; }
    
        /// <summary>
        /// Indicate the date previewed to make the billing
        /// </summary>
        /// <value>Indicate the date previewed to make the billing</value>
        [DataMember(Name="dataPrevistaFaturamento", EmitDefaultValue=false)]
        public string DataPrevistaFaturamento { get; set; }
    
        /// <summary>
        /// Indicate the date and the time that was made the billing
        /// </summary>
        /// <value>Indicate the date and the time that was made the billing</value>
        [DataMember(Name="dataHoraRealizacaoFaturamento", EmitDefaultValue=false)]
        public string DataHoraRealizacaoFaturamento { get; set; }
    
        /// <summary>
        /// Indicate the useful day that will be considered as the expiration date
        /// </summary>
        /// <value>Indicate the useful day that will be considered as the expiration date</value>
        [DataMember(Name="dataRealVencimento", EmitDefaultValue=false)]
        public string DataRealVencimento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ControleVencimentoResponse {\n");
            sb.Append("  DataVencimento: ").Append(DataVencimento).Append("\n");
            sb.Append("  DataPrevistaCorte: ").Append(DataPrevistaCorte).Append("\n");
            sb.Append("  DataHoraRealizacaoCorte: ").Append(DataHoraRealizacaoCorte).Append("\n");
            sb.Append("  DataPrevistaFaturamento: ").Append(DataPrevistaFaturamento).Append("\n");
            sb.Append("  DataHoraRealizacaoFaturamento: ").Append(DataHoraRealizacaoFaturamento).Append("\n");
            sb.Append("  DataRealVencimento: ").Append(DataRealVencimento).Append("\n");
            
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
            return this.Equals(obj as ControleVencimentoResponse);
        }

        /// <summary>
        /// Returns true if ControleVencimentoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ControleVencimentoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ControleVencimentoResponse other)
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
                    this.DataPrevistaCorte == other.DataPrevistaCorte ||
                    this.DataPrevistaCorte != null &&
                    this.DataPrevistaCorte.Equals(other.DataPrevistaCorte)
                ) && 
                (
                    this.DataHoraRealizacaoCorte == other.DataHoraRealizacaoCorte ||
                    this.DataHoraRealizacaoCorte != null &&
                    this.DataHoraRealizacaoCorte.Equals(other.DataHoraRealizacaoCorte)
                ) && 
                (
                    this.DataPrevistaFaturamento == other.DataPrevistaFaturamento ||
                    this.DataPrevistaFaturamento != null &&
                    this.DataPrevistaFaturamento.Equals(other.DataPrevistaFaturamento)
                ) && 
                (
                    this.DataHoraRealizacaoFaturamento == other.DataHoraRealizacaoFaturamento ||
                    this.DataHoraRealizacaoFaturamento != null &&
                    this.DataHoraRealizacaoFaturamento.Equals(other.DataHoraRealizacaoFaturamento)
                ) && 
                (
                    this.DataRealVencimento == other.DataRealVencimento ||
                    this.DataRealVencimento != null &&
                    this.DataRealVencimento.Equals(other.DataRealVencimento)
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
                
                if (this.DataPrevistaCorte != null)
                    hash = hash * 59 + this.DataPrevistaCorte.GetHashCode();
                
                if (this.DataHoraRealizacaoCorte != null)
                    hash = hash * 59 + this.DataHoraRealizacaoCorte.GetHashCode();
                
                if (this.DataPrevistaFaturamento != null)
                    hash = hash * 59 + this.DataPrevistaFaturamento.GetHashCode();
                
                if (this.DataHoraRealizacaoFaturamento != null)
                    hash = hash * 59 + this.DataHoraRealizacaoFaturamento.GetHashCode();
                
                if (this.DataRealVencimento != null)
                    hash = hash * 59 + this.DataRealVencimento.GetHashCode();
                
                return hash;
            }
        }

    }
}
