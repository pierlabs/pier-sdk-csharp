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
    /// 
    /// </summary>
    [DataContract]
    public partial class AntecipacaoResponse :  IEquatable<AntecipacaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AntecipacaoResponse" /> class.
        /// Initializes a new instance of the <see cref="AntecipacaoResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da antecipa\u00C3\u00A7\u00C3\u00A3o.</param>
        /// <param name="IdConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta.</param>
        /// <param name="IdCompra">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da compra.</param>
        /// <param name="QuantidadeParcelasTotal">Apresenta o numero total de parcelas da compra.</param>
        /// <param name="QuantidadeParcelasAntecipadas">Apresenta o numero de parcelas antecipadas.</param>
        /// <param name="ValorParcela">Apresenta o valor de cada parcela antecipadas.</param>
        /// <param name="ValorDescontoTotal">Apresenta o valor total do desconto.</param>
        /// <param name="ValorTotalComDesconto">Apresenta o valor total com desconto.</param>
        /// <param name="TaxaDesconto">Apresenta a taxa de desconto.</param>

        public AntecipacaoResponse(long? Id = null, long? IdConta = null, long? IdCompra = null, long? QuantidadeParcelasTotal = null, long? QuantidadeParcelasAntecipadas = null, double? ValorParcela = null, double? ValorDescontoTotal = null, double? ValorTotalComDesconto = null, double? TaxaDesconto = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.IdCompra = IdCompra;
            this.QuantidadeParcelasTotal = QuantidadeParcelasTotal;
            this.QuantidadeParcelasAntecipadas = QuantidadeParcelasAntecipadas;
            this.ValorParcela = ValorParcela;
            this.ValorDescontoTotal = ValorDescontoTotal;
            this.ValorTotalComDesconto = ValorTotalComDesconto;
            this.TaxaDesconto = TaxaDesconto;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da antecipa\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da antecipa\u00C3\u00A7\u00C3\u00A3o</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da compra
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da compra</value>
        [DataMember(Name="idCompra", EmitDefaultValue=false)]
        public long? IdCompra { get; set; }
    
        /// <summary>
        /// Apresenta o numero total de parcelas da compra
        /// </summary>
        /// <value>Apresenta o numero total de parcelas da compra</value>
        [DataMember(Name="quantidadeParcelasTotal", EmitDefaultValue=false)]
        public long? QuantidadeParcelasTotal { get; set; }
    
        /// <summary>
        /// Apresenta o numero de parcelas antecipadas
        /// </summary>
        /// <value>Apresenta o numero de parcelas antecipadas</value>
        [DataMember(Name="quantidadeParcelasAntecipadas", EmitDefaultValue=false)]
        public long? QuantidadeParcelasAntecipadas { get; set; }
    
        /// <summary>
        /// Apresenta o valor de cada parcela antecipadas
        /// </summary>
        /// <value>Apresenta o valor de cada parcela antecipadas</value>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public double? ValorParcela { get; set; }
    
        /// <summary>
        /// Apresenta o valor total do desconto
        /// </summary>
        /// <value>Apresenta o valor total do desconto</value>
        [DataMember(Name="valorDescontoTotal", EmitDefaultValue=false)]
        public double? ValorDescontoTotal { get; set; }
    
        /// <summary>
        /// Apresenta o valor total com desconto
        /// </summary>
        /// <value>Apresenta o valor total com desconto</value>
        [DataMember(Name="valorTotalComDesconto", EmitDefaultValue=false)]
        public double? ValorTotalComDesconto { get; set; }
    
        /// <summary>
        /// Apresenta a taxa de desconto
        /// </summary>
        /// <value>Apresenta a taxa de desconto</value>
        [DataMember(Name="taxaDesconto", EmitDefaultValue=false)]
        public double? TaxaDesconto { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AntecipacaoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdCompra: ").Append(IdCompra).Append("\n");
            sb.Append("  QuantidadeParcelasTotal: ").Append(QuantidadeParcelasTotal).Append("\n");
            sb.Append("  QuantidadeParcelasAntecipadas: ").Append(QuantidadeParcelasAntecipadas).Append("\n");
            sb.Append("  ValorParcela: ").Append(ValorParcela).Append("\n");
            sb.Append("  ValorDescontoTotal: ").Append(ValorDescontoTotal).Append("\n");
            sb.Append("  ValorTotalComDesconto: ").Append(ValorTotalComDesconto).Append("\n");
            sb.Append("  TaxaDesconto: ").Append(TaxaDesconto).Append("\n");
            
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
            return this.Equals(obj as AntecipacaoResponse);
        }

        /// <summary>
        /// Returns true if AntecipacaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AntecipacaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntecipacaoResponse other)
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
                    this.IdCompra == other.IdCompra ||
                    this.IdCompra != null &&
                    this.IdCompra.Equals(other.IdCompra)
                ) && 
                (
                    this.QuantidadeParcelasTotal == other.QuantidadeParcelasTotal ||
                    this.QuantidadeParcelasTotal != null &&
                    this.QuantidadeParcelasTotal.Equals(other.QuantidadeParcelasTotal)
                ) && 
                (
                    this.QuantidadeParcelasAntecipadas == other.QuantidadeParcelasAntecipadas ||
                    this.QuantidadeParcelasAntecipadas != null &&
                    this.QuantidadeParcelasAntecipadas.Equals(other.QuantidadeParcelasAntecipadas)
                ) && 
                (
                    this.ValorParcela == other.ValorParcela ||
                    this.ValorParcela != null &&
                    this.ValorParcela.Equals(other.ValorParcela)
                ) && 
                (
                    this.ValorDescontoTotal == other.ValorDescontoTotal ||
                    this.ValorDescontoTotal != null &&
                    this.ValorDescontoTotal.Equals(other.ValorDescontoTotal)
                ) && 
                (
                    this.ValorTotalComDesconto == other.ValorTotalComDesconto ||
                    this.ValorTotalComDesconto != null &&
                    this.ValorTotalComDesconto.Equals(other.ValorTotalComDesconto)
                ) && 
                (
                    this.TaxaDesconto == other.TaxaDesconto ||
                    this.TaxaDesconto != null &&
                    this.TaxaDesconto.Equals(other.TaxaDesconto)
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
                
                if (this.IdCompra != null)
                    hash = hash * 59 + this.IdCompra.GetHashCode();
                
                if (this.QuantidadeParcelasTotal != null)
                    hash = hash * 59 + this.QuantidadeParcelasTotal.GetHashCode();
                
                if (this.QuantidadeParcelasAntecipadas != null)
                    hash = hash * 59 + this.QuantidadeParcelasAntecipadas.GetHashCode();
                
                if (this.ValorParcela != null)
                    hash = hash * 59 + this.ValorParcela.GetHashCode();
                
                if (this.ValorDescontoTotal != null)
                    hash = hash * 59 + this.ValorDescontoTotal.GetHashCode();
                
                if (this.ValorTotalComDesconto != null)
                    hash = hash * 59 + this.ValorTotalComDesconto.GetHashCode();
                
                if (this.TaxaDesconto != null)
                    hash = hash * 59 + this.TaxaDesconto.GetHashCode();
                
                return hash;
            }
        }

    }
}
