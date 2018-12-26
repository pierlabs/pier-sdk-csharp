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
    /// {{{boleto_listar_response_description}}}
    /// </summary>
    [DataContract]
    public partial class BoletoListarResponse :  IEquatable<BoletoListarResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BoletoListarResponse" /> class.
        /// Initializes a new instance of the <see cref="BoletoListarResponse" />class.
        /// </summary>
        /// <param name="Id">{{{boleto_response_id_value}}}.</param>
        /// <param name="IdConta">{{{boleto_response_id_conta_value}}}.</param>
        /// <param name="NossoNumero">{{{boleto_response_nosso_numero_value}}}.</param>
        /// <param name="DataVencimento">{{{boleto_response_data_vencimento_value}}}.</param>
        /// <param name="ValorBoleto">{{{boleto_response_valor_boleto_value}}}.</param>
        /// <param name="IdTipoBoleto">{{{boleto_response_id_tipo_boleto_value}}}.</param>

        public BoletoListarResponse(long? Id = null, long? IdConta = null, string NossoNumero = null, string DataVencimento = null, double? ValorBoleto = null, long? IdTipoBoleto = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.NossoNumero = NossoNumero;
            this.DataVencimento = DataVencimento;
            this.ValorBoleto = ValorBoleto;
            this.IdTipoBoleto = IdTipoBoleto;
            
        }
        
    
        /// <summary>
        /// {{{boleto_response_id_value}}}
        /// </summary>
        /// <value>{{{boleto_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{boleto_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{boleto_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{boleto_response_nosso_numero_value}}}
        /// </summary>
        /// <value>{{{boleto_response_nosso_numero_value}}}</value>
        [DataMember(Name="nossoNumero", EmitDefaultValue=false)]
        public string NossoNumero { get; set; }
    
        /// <summary>
        /// {{{boleto_response_data_vencimento_value}}}
        /// </summary>
        /// <value>{{{boleto_response_data_vencimento_value}}}</value>
        [DataMember(Name="dataVencimento", EmitDefaultValue=false)]
        public string DataVencimento { get; set; }
    
        /// <summary>
        /// {{{boleto_response_valor_boleto_value}}}
        /// </summary>
        /// <value>{{{boleto_response_valor_boleto_value}}}</value>
        [DataMember(Name="valorBoleto", EmitDefaultValue=false)]
        public double? ValorBoleto { get; set; }
    
        /// <summary>
        /// {{{boleto_response_id_tipo_boleto_value}}}
        /// </summary>
        /// <value>{{{boleto_response_id_tipo_boleto_value}}}</value>
        [DataMember(Name="idTipoBoleto", EmitDefaultValue=false)]
        public long? IdTipoBoleto { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoletoListarResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  NossoNumero: ").Append(NossoNumero).Append("\n");
            sb.Append("  DataVencimento: ").Append(DataVencimento).Append("\n");
            sb.Append("  ValorBoleto: ").Append(ValorBoleto).Append("\n");
            sb.Append("  IdTipoBoleto: ").Append(IdTipoBoleto).Append("\n");
            
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
            return this.Equals(obj as BoletoListarResponse);
        }

        /// <summary>
        /// Returns true if BoletoListarResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BoletoListarResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoletoListarResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.NossoNumero == other.NossoNumero ||
                    this.NossoNumero != null &&
                    this.NossoNumero.Equals(other.NossoNumero)
                ) && 
                (
                    this.DataVencimento == other.DataVencimento ||
                    this.DataVencimento != null &&
                    this.DataVencimento.Equals(other.DataVencimento)
                ) && 
                (
                    this.ValorBoleto == other.ValorBoleto ||
                    this.ValorBoleto != null &&
                    this.ValorBoleto.Equals(other.ValorBoleto)
                ) && 
                (
                    this.IdTipoBoleto == other.IdTipoBoleto ||
                    this.IdTipoBoleto != null &&
                    this.IdTipoBoleto.Equals(other.IdTipoBoleto)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.NossoNumero != null)
                    hash = hash * 59 + this.NossoNumero.GetHashCode();
                
                if (this.DataVencimento != null)
                    hash = hash * 59 + this.DataVencimento.GetHashCode();
                
                if (this.ValorBoleto != null)
                    hash = hash * 59 + this.ValorBoleto.GetHashCode();
                
                if (this.IdTipoBoleto != null)
                    hash = hash * 59 + this.IdTipoBoleto.GetHashCode();
                
                return hash;
            }
        }

    }
}
