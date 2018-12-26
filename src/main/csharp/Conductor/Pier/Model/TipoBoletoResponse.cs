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
    /// {{{tipo_boleto_response_description}}}
    /// </summary>
    [DataContract]
    public partial class TipoBoletoResponse :  IEquatable<TipoBoletoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoBoletoResponse" /> class.
        /// Initializes a new instance of the <see cref="TipoBoletoResponse" />class.
        /// </summary>
        /// <param name="Id">{{{tipo_boleto_response_id_value}}}.</param>
        /// <param name="Descricao">{{{tipo_boleto_response_descricao_value}}}.</param>
        /// <param name="Banco">{{{tipo_boleto_response_banco_value}}}.</param>
        /// <param name="FaixaNossoNumero">{{{tipo_boleto_response_faixa_nosso_numero_value}}}.</param>
        /// <param name="MinNossoNumero">{{{tipo_boleto_response_min_nosso_numero_value}}}.</param>
        /// <param name="MaxNossoNumero">{{{tipo_boleto_response_max_nosso_numero_value}}}.</param>
        /// <param name="TamNossoNumero">{{{tipo_boleto_response_tam_nosso_numero_value}}}.</param>
        /// <param name="UltimoNossoNumero">{{{tipo_boleto_response_ultimo_nosso_numero_value}}}.</param>

        public TipoBoletoResponse(long? Id = null, string Descricao = null, long? Banco = null, int? FaixaNossoNumero = null, double? MinNossoNumero = null, double? MaxNossoNumero = null, int? TamNossoNumero = null, double? UltimoNossoNumero = null)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.Banco = Banco;
            this.FaixaNossoNumero = FaixaNossoNumero;
            this.MinNossoNumero = MinNossoNumero;
            this.MaxNossoNumero = MaxNossoNumero;
            this.TamNossoNumero = TamNossoNumero;
            this.UltimoNossoNumero = UltimoNossoNumero;
            
        }
        
    
        /// <summary>
        /// {{{tipo_boleto_response_id_value}}}
        /// </summary>
        /// <value>{{{tipo_boleto_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{tipo_boleto_response_descricao_value}}}
        /// </summary>
        /// <value>{{{tipo_boleto_response_descricao_value}}}</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// {{{tipo_boleto_response_banco_value}}}
        /// </summary>
        /// <value>{{{tipo_boleto_response_banco_value}}}</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public long? Banco { get; set; }
    
        /// <summary>
        /// {{{tipo_boleto_response_faixa_nosso_numero_value}}}
        /// </summary>
        /// <value>{{{tipo_boleto_response_faixa_nosso_numero_value}}}</value>
        [DataMember(Name="faixaNossoNumero", EmitDefaultValue=false)]
        public int? FaixaNossoNumero { get; set; }
    
        /// <summary>
        /// {{{tipo_boleto_response_min_nosso_numero_value}}}
        /// </summary>
        /// <value>{{{tipo_boleto_response_min_nosso_numero_value}}}</value>
        [DataMember(Name="minNossoNumero", EmitDefaultValue=false)]
        public double? MinNossoNumero { get; set; }
    
        /// <summary>
        /// {{{tipo_boleto_response_max_nosso_numero_value}}}
        /// </summary>
        /// <value>{{{tipo_boleto_response_max_nosso_numero_value}}}</value>
        [DataMember(Name="maxNossoNumero", EmitDefaultValue=false)]
        public double? MaxNossoNumero { get; set; }
    
        /// <summary>
        /// {{{tipo_boleto_response_tam_nosso_numero_value}}}
        /// </summary>
        /// <value>{{{tipo_boleto_response_tam_nosso_numero_value}}}</value>
        [DataMember(Name="tamNossoNumero", EmitDefaultValue=false)]
        public int? TamNossoNumero { get; set; }
    
        /// <summary>
        /// {{{tipo_boleto_response_ultimo_nosso_numero_value}}}
        /// </summary>
        /// <value>{{{tipo_boleto_response_ultimo_nosso_numero_value}}}</value>
        [DataMember(Name="ultimoNossoNumero", EmitDefaultValue=false)]
        public double? UltimoNossoNumero { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoBoletoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  Banco: ").Append(Banco).Append("\n");
            sb.Append("  FaixaNossoNumero: ").Append(FaixaNossoNumero).Append("\n");
            sb.Append("  MinNossoNumero: ").Append(MinNossoNumero).Append("\n");
            sb.Append("  MaxNossoNumero: ").Append(MaxNossoNumero).Append("\n");
            sb.Append("  TamNossoNumero: ").Append(TamNossoNumero).Append("\n");
            sb.Append("  UltimoNossoNumero: ").Append(UltimoNossoNumero).Append("\n");
            
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
            return this.Equals(obj as TipoBoletoResponse);
        }

        /// <summary>
        /// Returns true if TipoBoletoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoBoletoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoBoletoResponse other)
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
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.Banco == other.Banco ||
                    this.Banco != null &&
                    this.Banco.Equals(other.Banco)
                ) && 
                (
                    this.FaixaNossoNumero == other.FaixaNossoNumero ||
                    this.FaixaNossoNumero != null &&
                    this.FaixaNossoNumero.Equals(other.FaixaNossoNumero)
                ) && 
                (
                    this.MinNossoNumero == other.MinNossoNumero ||
                    this.MinNossoNumero != null &&
                    this.MinNossoNumero.Equals(other.MinNossoNumero)
                ) && 
                (
                    this.MaxNossoNumero == other.MaxNossoNumero ||
                    this.MaxNossoNumero != null &&
                    this.MaxNossoNumero.Equals(other.MaxNossoNumero)
                ) && 
                (
                    this.TamNossoNumero == other.TamNossoNumero ||
                    this.TamNossoNumero != null &&
                    this.TamNossoNumero.Equals(other.TamNossoNumero)
                ) && 
                (
                    this.UltimoNossoNumero == other.UltimoNossoNumero ||
                    this.UltimoNossoNumero != null &&
                    this.UltimoNossoNumero.Equals(other.UltimoNossoNumero)
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
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.Banco != null)
                    hash = hash * 59 + this.Banco.GetHashCode();
                
                if (this.FaixaNossoNumero != null)
                    hash = hash * 59 + this.FaixaNossoNumero.GetHashCode();
                
                if (this.MinNossoNumero != null)
                    hash = hash * 59 + this.MinNossoNumero.GetHashCode();
                
                if (this.MaxNossoNumero != null)
                    hash = hash * 59 + this.MaxNossoNumero.GetHashCode();
                
                if (this.TamNossoNumero != null)
                    hash = hash * 59 + this.TamNossoNumero.GetHashCode();
                
                if (this.UltimoNossoNumero != null)
                    hash = hash * 59 + this.UltimoNossoNumero.GetHashCode();
                
                return hash;
            }
        }

    }
}
