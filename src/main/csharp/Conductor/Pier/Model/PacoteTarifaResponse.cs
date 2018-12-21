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
    /// Representation of an fee package tariff
    /// </summary>
    [DataContract]
    public partial class PacoteTarifaResponse :  IEquatable<PacoteTarifaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PacoteTarifaResponse" /> class.
        /// Initializes a new instance of the <see cref="PacoteTarifaResponse" />class.
        /// </summary>
        /// <param name="Descricao">The description of the fee.</param>
        /// <param name="Id">Fee package id.</param>
        /// <param name="QuantidadeAplicacoes">Application amount.</param>
        /// <param name="QuantidadeBilheteUnico">Unique ticket amount.</param>
        /// <param name="QuantidadeBoleto">Chage ticket amount.</param>
        /// <param name="QuantidadeRecargaCelular">Cellphone recharge amount.</param>
        /// <param name="QuantidadeSaque">Cash out amount.</param>
        /// <param name="QuantidadeTaxaPagamentoConta">Payment tax account amount.</param>
        /// <param name="QuantidadeTransferencia">Transfer amount.</param>
        /// <param name="ValorTarifa">Tax value.</param>

        public PacoteTarifaResponse(string Descricao = null, long? Id = null, int? QuantidadeAplicacoes = null, int? QuantidadeBilheteUnico = null, int? QuantidadeBoleto = null, int? QuantidadeRecargaCelular = null, int? QuantidadeSaque = null, int? QuantidadeTaxaPagamentoConta = null, int? QuantidadeTransferencia = null, double? ValorTarifa = null)
        {
            this.Descricao = Descricao;
            this.Id = Id;
            this.QuantidadeAplicacoes = QuantidadeAplicacoes;
            this.QuantidadeBilheteUnico = QuantidadeBilheteUnico;
            this.QuantidadeBoleto = QuantidadeBoleto;
            this.QuantidadeRecargaCelular = QuantidadeRecargaCelular;
            this.QuantidadeSaque = QuantidadeSaque;
            this.QuantidadeTaxaPagamentoConta = QuantidadeTaxaPagamentoConta;
            this.QuantidadeTransferencia = QuantidadeTransferencia;
            this.ValorTarifa = ValorTarifa;
            
        }
        
    
        /// <summary>
        /// The description of the fee
        /// </summary>
        /// <value>The description of the fee</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Fee package id
        /// </summary>
        /// <value>Fee package id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Application amount
        /// </summary>
        /// <value>Application amount</value>
        [DataMember(Name="quantidadeAplicacoes", EmitDefaultValue=false)]
        public int? QuantidadeAplicacoes { get; set; }
    
        /// <summary>
        /// Unique ticket amount
        /// </summary>
        /// <value>Unique ticket amount</value>
        [DataMember(Name="quantidadeBilheteUnico", EmitDefaultValue=false)]
        public int? QuantidadeBilheteUnico { get; set; }
    
        /// <summary>
        /// Chage ticket amount
        /// </summary>
        /// <value>Chage ticket amount</value>
        [DataMember(Name="quantidadeBoleto", EmitDefaultValue=false)]
        public int? QuantidadeBoleto { get; set; }
    
        /// <summary>
        /// Cellphone recharge amount
        /// </summary>
        /// <value>Cellphone recharge amount</value>
        [DataMember(Name="quantidadeRecargaCelular", EmitDefaultValue=false)]
        public int? QuantidadeRecargaCelular { get; set; }
    
        /// <summary>
        /// Cash out amount
        /// </summary>
        /// <value>Cash out amount</value>
        [DataMember(Name="quantidadeSaque", EmitDefaultValue=false)]
        public int? QuantidadeSaque { get; set; }
    
        /// <summary>
        /// Payment tax account amount
        /// </summary>
        /// <value>Payment tax account amount</value>
        [DataMember(Name="quantidadeTaxaPagamentoConta", EmitDefaultValue=false)]
        public int? QuantidadeTaxaPagamentoConta { get; set; }
    
        /// <summary>
        /// Transfer amount
        /// </summary>
        /// <value>Transfer amount</value>
        [DataMember(Name="quantidadeTransferencia", EmitDefaultValue=false)]
        public int? QuantidadeTransferencia { get; set; }
    
        /// <summary>
        /// Tax value
        /// </summary>
        /// <value>Tax value</value>
        [DataMember(Name="valorTarifa", EmitDefaultValue=false)]
        public double? ValorTarifa { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PacoteTarifaResponse {\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  QuantidadeAplicacoes: ").Append(QuantidadeAplicacoes).Append("\n");
            sb.Append("  QuantidadeBilheteUnico: ").Append(QuantidadeBilheteUnico).Append("\n");
            sb.Append("  QuantidadeBoleto: ").Append(QuantidadeBoleto).Append("\n");
            sb.Append("  QuantidadeRecargaCelular: ").Append(QuantidadeRecargaCelular).Append("\n");
            sb.Append("  QuantidadeSaque: ").Append(QuantidadeSaque).Append("\n");
            sb.Append("  QuantidadeTaxaPagamentoConta: ").Append(QuantidadeTaxaPagamentoConta).Append("\n");
            sb.Append("  QuantidadeTransferencia: ").Append(QuantidadeTransferencia).Append("\n");
            sb.Append("  ValorTarifa: ").Append(ValorTarifa).Append("\n");
            
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
            return this.Equals(obj as PacoteTarifaResponse);
        }

        /// <summary>
        /// Returns true if PacoteTarifaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PacoteTarifaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PacoteTarifaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.QuantidadeAplicacoes == other.QuantidadeAplicacoes ||
                    this.QuantidadeAplicacoes != null &&
                    this.QuantidadeAplicacoes.Equals(other.QuantidadeAplicacoes)
                ) && 
                (
                    this.QuantidadeBilheteUnico == other.QuantidadeBilheteUnico ||
                    this.QuantidadeBilheteUnico != null &&
                    this.QuantidadeBilheteUnico.Equals(other.QuantidadeBilheteUnico)
                ) && 
                (
                    this.QuantidadeBoleto == other.QuantidadeBoleto ||
                    this.QuantidadeBoleto != null &&
                    this.QuantidadeBoleto.Equals(other.QuantidadeBoleto)
                ) && 
                (
                    this.QuantidadeRecargaCelular == other.QuantidadeRecargaCelular ||
                    this.QuantidadeRecargaCelular != null &&
                    this.QuantidadeRecargaCelular.Equals(other.QuantidadeRecargaCelular)
                ) && 
                (
                    this.QuantidadeSaque == other.QuantidadeSaque ||
                    this.QuantidadeSaque != null &&
                    this.QuantidadeSaque.Equals(other.QuantidadeSaque)
                ) && 
                (
                    this.QuantidadeTaxaPagamentoConta == other.QuantidadeTaxaPagamentoConta ||
                    this.QuantidadeTaxaPagamentoConta != null &&
                    this.QuantidadeTaxaPagamentoConta.Equals(other.QuantidadeTaxaPagamentoConta)
                ) && 
                (
                    this.QuantidadeTransferencia == other.QuantidadeTransferencia ||
                    this.QuantidadeTransferencia != null &&
                    this.QuantidadeTransferencia.Equals(other.QuantidadeTransferencia)
                ) && 
                (
                    this.ValorTarifa == other.ValorTarifa ||
                    this.ValorTarifa != null &&
                    this.ValorTarifa.Equals(other.ValorTarifa)
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
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.QuantidadeAplicacoes != null)
                    hash = hash * 59 + this.QuantidadeAplicacoes.GetHashCode();
                
                if (this.QuantidadeBilheteUnico != null)
                    hash = hash * 59 + this.QuantidadeBilheteUnico.GetHashCode();
                
                if (this.QuantidadeBoleto != null)
                    hash = hash * 59 + this.QuantidadeBoleto.GetHashCode();
                
                if (this.QuantidadeRecargaCelular != null)
                    hash = hash * 59 + this.QuantidadeRecargaCelular.GetHashCode();
                
                if (this.QuantidadeSaque != null)
                    hash = hash * 59 + this.QuantidadeSaque.GetHashCode();
                
                if (this.QuantidadeTaxaPagamentoConta != null)
                    hash = hash * 59 + this.QuantidadeTaxaPagamentoConta.GetHashCode();
                
                if (this.QuantidadeTransferencia != null)
                    hash = hash * 59 + this.QuantidadeTransferencia.GetHashCode();
                
                if (this.ValorTarifa != null)
                    hash = hash * 59 + this.ValorTarifa.GetHashCode();
                
                return hash;
            }
        }

    }
}
