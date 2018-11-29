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
    /// {{{parcela_acordo_response_description}}}
    /// </summary>
    [DataContract]
    public partial class ParcelaAcordoResponse :  IEquatable<ParcelaAcordoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParcelaAcordoResponse" /> class.
        /// Initializes a new instance of the <see cref="ParcelaAcordoResponse" />class.
        /// </summary>
        /// <param name="Id">{{{parcela_acordo_response_id_value}}}.</param>
        /// <param name="IdAcordo">{{{parcela_acordo_response_id_acordo_value}}}.</param>
        /// <param name="NumeroParcela">{{{parcela_acordo_response_numero_parcela_value}}}.</param>
        /// <param name="ValorParcela">{{{parcela_acordo_response_valor_parcela_value}}}.</param>
        /// <param name="VencimentoParcela">{{{parcela_acordo_response_vencimento_parcela_value}}}.</param>
        /// <param name="SaldoParcela">{{{parcela_acordo_response_saldo_parcela_value}}}.</param>
        /// <param name="NossoNumero">{{{parcela_acordo_response_nosso_numero_value}}}.</param>
        /// <param name="IdBoletoParcela">{{{parcela_acordo_response_id_boleto_parcela_value}}}.</param>

        public ParcelaAcordoResponse(long? Id = null, long? IdAcordo = null, int? NumeroParcela = null, double? ValorParcela = null, string VencimentoParcela = null, double? SaldoParcela = null, string NossoNumero = null, long? IdBoletoParcela = null)
        {
            this.Id = Id;
            this.IdAcordo = IdAcordo;
            this.NumeroParcela = NumeroParcela;
            this.ValorParcela = ValorParcela;
            this.VencimentoParcela = VencimentoParcela;
            this.SaldoParcela = SaldoParcela;
            this.NossoNumero = NossoNumero;
            this.IdBoletoParcela = IdBoletoParcela;
            
        }
        
    
        /// <summary>
        /// {{{parcela_acordo_response_id_value}}}
        /// </summary>
        /// <value>{{{parcela_acordo_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{parcela_acordo_response_id_acordo_value}}}
        /// </summary>
        /// <value>{{{parcela_acordo_response_id_acordo_value}}}</value>
        [DataMember(Name="idAcordo", EmitDefaultValue=false)]
        public long? IdAcordo { get; set; }
    
        /// <summary>
        /// {{{parcela_acordo_response_numero_parcela_value}}}
        /// </summary>
        /// <value>{{{parcela_acordo_response_numero_parcela_value}}}</value>
        [DataMember(Name="numeroParcela", EmitDefaultValue=false)]
        public int? NumeroParcela { get; set; }
    
        /// <summary>
        /// {{{parcela_acordo_response_valor_parcela_value}}}
        /// </summary>
        /// <value>{{{parcela_acordo_response_valor_parcela_value}}}</value>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public double? ValorParcela { get; set; }
    
        /// <summary>
        /// {{{parcela_acordo_response_vencimento_parcela_value}}}
        /// </summary>
        /// <value>{{{parcela_acordo_response_vencimento_parcela_value}}}</value>
        [DataMember(Name="vencimentoParcela", EmitDefaultValue=false)]
        public string VencimentoParcela { get; set; }
    
        /// <summary>
        /// {{{parcela_acordo_response_saldo_parcela_value}}}
        /// </summary>
        /// <value>{{{parcela_acordo_response_saldo_parcela_value}}}</value>
        [DataMember(Name="saldoParcela", EmitDefaultValue=false)]
        public double? SaldoParcela { get; set; }
    
        /// <summary>
        /// {{{parcela_acordo_response_nosso_numero_value}}}
        /// </summary>
        /// <value>{{{parcela_acordo_response_nosso_numero_value}}}</value>
        [DataMember(Name="nossoNumero", EmitDefaultValue=false)]
        public string NossoNumero { get; set; }
    
        /// <summary>
        /// {{{parcela_acordo_response_id_boleto_parcela_value}}}
        /// </summary>
        /// <value>{{{parcela_acordo_response_id_boleto_parcela_value}}}</value>
        [DataMember(Name="idBoletoParcela", EmitDefaultValue=false)]
        public long? IdBoletoParcela { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParcelaAcordoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdAcordo: ").Append(IdAcordo).Append("\n");
            sb.Append("  NumeroParcela: ").Append(NumeroParcela).Append("\n");
            sb.Append("  ValorParcela: ").Append(ValorParcela).Append("\n");
            sb.Append("  VencimentoParcela: ").Append(VencimentoParcela).Append("\n");
            sb.Append("  SaldoParcela: ").Append(SaldoParcela).Append("\n");
            sb.Append("  NossoNumero: ").Append(NossoNumero).Append("\n");
            sb.Append("  IdBoletoParcela: ").Append(IdBoletoParcela).Append("\n");
            
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
            return this.Equals(obj as ParcelaAcordoResponse);
        }

        /// <summary>
        /// Returns true if ParcelaAcordoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ParcelaAcordoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParcelaAcordoResponse other)
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
                    this.IdAcordo == other.IdAcordo ||
                    this.IdAcordo != null &&
                    this.IdAcordo.Equals(other.IdAcordo)
                ) && 
                (
                    this.NumeroParcela == other.NumeroParcela ||
                    this.NumeroParcela != null &&
                    this.NumeroParcela.Equals(other.NumeroParcela)
                ) && 
                (
                    this.ValorParcela == other.ValorParcela ||
                    this.ValorParcela != null &&
                    this.ValorParcela.Equals(other.ValorParcela)
                ) && 
                (
                    this.VencimentoParcela == other.VencimentoParcela ||
                    this.VencimentoParcela != null &&
                    this.VencimentoParcela.Equals(other.VencimentoParcela)
                ) && 
                (
                    this.SaldoParcela == other.SaldoParcela ||
                    this.SaldoParcela != null &&
                    this.SaldoParcela.Equals(other.SaldoParcela)
                ) && 
                (
                    this.NossoNumero == other.NossoNumero ||
                    this.NossoNumero != null &&
                    this.NossoNumero.Equals(other.NossoNumero)
                ) && 
                (
                    this.IdBoletoParcela == other.IdBoletoParcela ||
                    this.IdBoletoParcela != null &&
                    this.IdBoletoParcela.Equals(other.IdBoletoParcela)
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
                
                if (this.IdAcordo != null)
                    hash = hash * 59 + this.IdAcordo.GetHashCode();
                
                if (this.NumeroParcela != null)
                    hash = hash * 59 + this.NumeroParcela.GetHashCode();
                
                if (this.ValorParcela != null)
                    hash = hash * 59 + this.ValorParcela.GetHashCode();
                
                if (this.VencimentoParcela != null)
                    hash = hash * 59 + this.VencimentoParcela.GetHashCode();
                
                if (this.SaldoParcela != null)
                    hash = hash * 59 + this.SaldoParcela.GetHashCode();
                
                if (this.NossoNumero != null)
                    hash = hash * 59 + this.NossoNumero.GetHashCode();
                
                if (this.IdBoletoParcela != null)
                    hash = hash * 59 + this.IdBoletoParcela.GetHashCode();
                
                return hash;
            }
        }

    }
}
