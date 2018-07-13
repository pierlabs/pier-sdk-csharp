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
    /// {{{boleto_request_description}}}
    /// </summary>
    [DataContract]
    public partial class BoletoRequest :  IEquatable<BoletoRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BoletoRequest" /> class.
        /// Initializes a new instance of the <see cref="BoletoRequest" />class.
        /// </summary>
        /// <param name="IdConta">{{{boleto_request_id_conta_value}}} (required).</param>
        /// <param name="TipoBoleto">{{{boleto_request_tipo_boleto_value}}} (required).</param>
        /// <param name="Valor">{{{boleto_request_valor_value}}} (required).</param>
        /// <param name="DataVencimento">{{{boleto_request_data_vencimento_value}}} (required).</param>

        public BoletoRequest(long? IdConta = null, long? TipoBoleto = null, double? Valor = null, string DataVencimento = null)
        {
            // to ensure "IdConta" is required (not null)
            if (IdConta == null)
            {
                throw new InvalidDataException("IdConta is a required property for BoletoRequest and cannot be null");
            }
            else
            {
                this.IdConta = IdConta;
            }
            // to ensure "TipoBoleto" is required (not null)
            if (TipoBoleto == null)
            {
                throw new InvalidDataException("TipoBoleto is a required property for BoletoRequest and cannot be null");
            }
            else
            {
                this.TipoBoleto = TipoBoleto;
            }
            // to ensure "Valor" is required (not null)
            if (Valor == null)
            {
                throw new InvalidDataException("Valor is a required property for BoletoRequest and cannot be null");
            }
            else
            {
                this.Valor = Valor;
            }
            // to ensure "DataVencimento" is required (not null)
            if (DataVencimento == null)
            {
                throw new InvalidDataException("DataVencimento is a required property for BoletoRequest and cannot be null");
            }
            else
            {
                this.DataVencimento = DataVencimento;
            }
            
        }
        
    
        /// <summary>
        /// {{{boleto_request_id_conta_value}}}
        /// </summary>
        /// <value>{{{boleto_request_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{boleto_request_tipo_boleto_value}}}
        /// </summary>
        /// <value>{{{boleto_request_tipo_boleto_value}}}</value>
        [DataMember(Name="tipoBoleto", EmitDefaultValue=false)]
        public long? TipoBoleto { get; set; }
    
        /// <summary>
        /// {{{boleto_request_valor_value}}}
        /// </summary>
        /// <value>{{{boleto_request_valor_value}}}</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// {{{boleto_request_data_vencimento_value}}}
        /// </summary>
        /// <value>{{{boleto_request_data_vencimento_value}}}</value>
        [DataMember(Name="dataVencimento", EmitDefaultValue=false)]
        public string DataVencimento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoletoRequest {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  TipoBoleto: ").Append(TipoBoleto).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  DataVencimento: ").Append(DataVencimento).Append("\n");
            
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
            return this.Equals(obj as BoletoRequest);
        }

        /// <summary>
        /// Returns true if BoletoRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BoletoRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoletoRequest other)
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
                    this.TipoBoleto == other.TipoBoleto ||
                    this.TipoBoleto != null &&
                    this.TipoBoleto.Equals(other.TipoBoleto)
                ) && 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
                ) && 
                (
                    this.DataVencimento == other.DataVencimento ||
                    this.DataVencimento != null &&
                    this.DataVencimento.Equals(other.DataVencimento)
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
                
                if (this.TipoBoleto != null)
                    hash = hash * 59 + this.TipoBoleto.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                if (this.DataVencimento != null)
                    hash = hash * 59 + this.DataVencimento.GetHashCode();
                
                return hash;
            }
        }

    }
}
