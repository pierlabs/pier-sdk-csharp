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
    /// Debt of the client
    /// </summary>
    [DataContract]
    public partial class DividaClienteResponse :  IEquatable<DividaClienteResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DividaClienteResponse" /> class.
        /// Initializes a new instance of the <see cref="DividaClienteResponse" />class.
        /// </summary>
        /// <param name="Id">Identification code of the account (id).</param>
        /// <param name="DataVencimentoFaturaAtraso">Expiration date of the collection.</param>
        /// <param name="QuantidadeDiasAtraso">Quantity of days in delay until the expiration date of the collection.</param>
        /// <param name="DataVencimentoAcordo">Expiration date of the agreement.</param>
        /// <param name="QuantidadeDiasAtrasoCorrigido">Quantity of days in delay until the expiration date of the agreement.</param>
        /// <param name="ValorSaldoDevedor">Value of the debtor balande until the expiration date of the collection.</param>
        /// <param name="TaxaCorrecao">Correction Percentage.</param>
        /// <param name="ValorCorrecao">Value of the collection.</param>
        /// <param name="ValorIOF">Value of the IOF debt.</param>
        /// <param name="ValorSaldoCorrigido">Value of the debtor balance of the debt until the expiration date of the agreement.</param>
        /// <param name="IdStatusConta">Identification code of the account status (id).</param>
        /// <param name="DescricaoStatusConta">Description of the account status.</param>
        /// <param name="IdStatusAcordo">Identification Code of the agreement status (id).</param>
        /// <param name="DescricaoStatusAcordo">Description of the agreement status.</param>
        /// <param name="IdEscritorioCobranca">Identification Code of the collection office.</param>
        /// <param name="NomeEscritorioCobranca">Office name of the collection.</param>
        /// <param name="EmailPessoaConta">Email of the debtor.</param>

        public DividaClienteResponse(long? Id = null, string DataVencimentoFaturaAtraso = null, long? QuantidadeDiasAtraso = null, string DataVencimentoAcordo = null, long? QuantidadeDiasAtrasoCorrigido = null, double? ValorSaldoDevedor = null, double? TaxaCorrecao = null, double? ValorCorrecao = null, double? ValorIOF = null, double? ValorSaldoCorrigido = null, long? IdStatusConta = null, string DescricaoStatusConta = null, long? IdStatusAcordo = null, string DescricaoStatusAcordo = null, long? IdEscritorioCobranca = null, string NomeEscritorioCobranca = null, string EmailPessoaConta = null)
        {
            this.Id = Id;
            this.DataVencimentoFaturaAtraso = DataVencimentoFaturaAtraso;
            this.QuantidadeDiasAtraso = QuantidadeDiasAtraso;
            this.DataVencimentoAcordo = DataVencimentoAcordo;
            this.QuantidadeDiasAtrasoCorrigido = QuantidadeDiasAtrasoCorrigido;
            this.ValorSaldoDevedor = ValorSaldoDevedor;
            this.TaxaCorrecao = TaxaCorrecao;
            this.ValorCorrecao = ValorCorrecao;
            this.ValorIOF = ValorIOF;
            this.ValorSaldoCorrigido = ValorSaldoCorrigido;
            this.IdStatusConta = IdStatusConta;
            this.DescricaoStatusConta = DescricaoStatusConta;
            this.IdStatusAcordo = IdStatusAcordo;
            this.DescricaoStatusAcordo = DescricaoStatusAcordo;
            this.IdEscritorioCobranca = IdEscritorioCobranca;
            this.NomeEscritorioCobranca = NomeEscritorioCobranca;
            this.EmailPessoaConta = EmailPessoaConta;
            
        }
        
    
        /// <summary>
        /// Identification code of the account (id)
        /// </summary>
        /// <value>Identification code of the account (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Expiration date of the collection
        /// </summary>
        /// <value>Expiration date of the collection</value>
        [DataMember(Name="dataVencimentoFaturaAtraso", EmitDefaultValue=false)]
        public string DataVencimentoFaturaAtraso { get; set; }
    
        /// <summary>
        /// Quantity of days in delay until the expiration date of the collection
        /// </summary>
        /// <value>Quantity of days in delay until the expiration date of the collection</value>
        [DataMember(Name="quantidadeDiasAtraso", EmitDefaultValue=false)]
        public long? QuantidadeDiasAtraso { get; set; }
    
        /// <summary>
        /// Expiration date of the agreement
        /// </summary>
        /// <value>Expiration date of the agreement</value>
        [DataMember(Name="dataVencimentoAcordo", EmitDefaultValue=false)]
        public string DataVencimentoAcordo { get; set; }
    
        /// <summary>
        /// Quantity of days in delay until the expiration date of the agreement
        /// </summary>
        /// <value>Quantity of days in delay until the expiration date of the agreement</value>
        [DataMember(Name="quantidadeDiasAtrasoCorrigido", EmitDefaultValue=false)]
        public long? QuantidadeDiasAtrasoCorrigido { get; set; }
    
        /// <summary>
        /// Value of the debtor balande until the expiration date of the collection
        /// </summary>
        /// <value>Value of the debtor balande until the expiration date of the collection</value>
        [DataMember(Name="valorSaldoDevedor", EmitDefaultValue=false)]
        public double? ValorSaldoDevedor { get; set; }
    
        /// <summary>
        /// Correction Percentage
        /// </summary>
        /// <value>Correction Percentage</value>
        [DataMember(Name="taxaCorrecao", EmitDefaultValue=false)]
        public double? TaxaCorrecao { get; set; }
    
        /// <summary>
        /// Value of the collection
        /// </summary>
        /// <value>Value of the collection</value>
        [DataMember(Name="valorCorrecao", EmitDefaultValue=false)]
        public double? ValorCorrecao { get; set; }
    
        /// <summary>
        /// Value of the IOF debt
        /// </summary>
        /// <value>Value of the IOF debt</value>
        [DataMember(Name="valorIOF", EmitDefaultValue=false)]
        public double? ValorIOF { get; set; }
    
        /// <summary>
        /// Value of the debtor balance of the debt until the expiration date of the agreement
        /// </summary>
        /// <value>Value of the debtor balance of the debt until the expiration date of the agreement</value>
        [DataMember(Name="valorSaldoCorrigido", EmitDefaultValue=false)]
        public double? ValorSaldoCorrigido { get; set; }
    
        /// <summary>
        /// Identification code of the account status (id)
        /// </summary>
        /// <value>Identification code of the account status (id)</value>
        [DataMember(Name="idStatusConta", EmitDefaultValue=false)]
        public long? IdStatusConta { get; set; }
    
        /// <summary>
        /// Description of the account status
        /// </summary>
        /// <value>Description of the account status</value>
        [DataMember(Name="descricaoStatusConta", EmitDefaultValue=false)]
        public string DescricaoStatusConta { get; set; }
    
        /// <summary>
        /// Identification Code of the agreement status (id)
        /// </summary>
        /// <value>Identification Code of the agreement status (id)</value>
        [DataMember(Name="idStatusAcordo", EmitDefaultValue=false)]
        public long? IdStatusAcordo { get; set; }
    
        /// <summary>
        /// Description of the agreement status
        /// </summary>
        /// <value>Description of the agreement status</value>
        [DataMember(Name="descricaoStatusAcordo", EmitDefaultValue=false)]
        public string DescricaoStatusAcordo { get; set; }
    
        /// <summary>
        /// Identification Code of the collection office
        /// </summary>
        /// <value>Identification Code of the collection office</value>
        [DataMember(Name="idEscritorioCobranca", EmitDefaultValue=false)]
        public long? IdEscritorioCobranca { get; set; }
    
        /// <summary>
        /// Office name of the collection
        /// </summary>
        /// <value>Office name of the collection</value>
        [DataMember(Name="nomeEscritorioCobranca", EmitDefaultValue=false)]
        public string NomeEscritorioCobranca { get; set; }
    
        /// <summary>
        /// Email of the debtor
        /// </summary>
        /// <value>Email of the debtor</value>
        [DataMember(Name="emailPessoaConta", EmitDefaultValue=false)]
        public string EmailPessoaConta { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DividaClienteResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DataVencimentoFaturaAtraso: ").Append(DataVencimentoFaturaAtraso).Append("\n");
            sb.Append("  QuantidadeDiasAtraso: ").Append(QuantidadeDiasAtraso).Append("\n");
            sb.Append("  DataVencimentoAcordo: ").Append(DataVencimentoAcordo).Append("\n");
            sb.Append("  QuantidadeDiasAtrasoCorrigido: ").Append(QuantidadeDiasAtrasoCorrigido).Append("\n");
            sb.Append("  ValorSaldoDevedor: ").Append(ValorSaldoDevedor).Append("\n");
            sb.Append("  TaxaCorrecao: ").Append(TaxaCorrecao).Append("\n");
            sb.Append("  ValorCorrecao: ").Append(ValorCorrecao).Append("\n");
            sb.Append("  ValorIOF: ").Append(ValorIOF).Append("\n");
            sb.Append("  ValorSaldoCorrigido: ").Append(ValorSaldoCorrigido).Append("\n");
            sb.Append("  IdStatusConta: ").Append(IdStatusConta).Append("\n");
            sb.Append("  DescricaoStatusConta: ").Append(DescricaoStatusConta).Append("\n");
            sb.Append("  IdStatusAcordo: ").Append(IdStatusAcordo).Append("\n");
            sb.Append("  DescricaoStatusAcordo: ").Append(DescricaoStatusAcordo).Append("\n");
            sb.Append("  IdEscritorioCobranca: ").Append(IdEscritorioCobranca).Append("\n");
            sb.Append("  NomeEscritorioCobranca: ").Append(NomeEscritorioCobranca).Append("\n");
            sb.Append("  EmailPessoaConta: ").Append(EmailPessoaConta).Append("\n");
            
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
            return this.Equals(obj as DividaClienteResponse);
        }

        /// <summary>
        /// Returns true if DividaClienteResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DividaClienteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DividaClienteResponse other)
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
                    this.DataVencimentoFaturaAtraso == other.DataVencimentoFaturaAtraso ||
                    this.DataVencimentoFaturaAtraso != null &&
                    this.DataVencimentoFaturaAtraso.Equals(other.DataVencimentoFaturaAtraso)
                ) && 
                (
                    this.QuantidadeDiasAtraso == other.QuantidadeDiasAtraso ||
                    this.QuantidadeDiasAtraso != null &&
                    this.QuantidadeDiasAtraso.Equals(other.QuantidadeDiasAtraso)
                ) && 
                (
                    this.DataVencimentoAcordo == other.DataVencimentoAcordo ||
                    this.DataVencimentoAcordo != null &&
                    this.DataVencimentoAcordo.Equals(other.DataVencimentoAcordo)
                ) && 
                (
                    this.QuantidadeDiasAtrasoCorrigido == other.QuantidadeDiasAtrasoCorrigido ||
                    this.QuantidadeDiasAtrasoCorrigido != null &&
                    this.QuantidadeDiasAtrasoCorrigido.Equals(other.QuantidadeDiasAtrasoCorrigido)
                ) && 
                (
                    this.ValorSaldoDevedor == other.ValorSaldoDevedor ||
                    this.ValorSaldoDevedor != null &&
                    this.ValorSaldoDevedor.Equals(other.ValorSaldoDevedor)
                ) && 
                (
                    this.TaxaCorrecao == other.TaxaCorrecao ||
                    this.TaxaCorrecao != null &&
                    this.TaxaCorrecao.Equals(other.TaxaCorrecao)
                ) && 
                (
                    this.ValorCorrecao == other.ValorCorrecao ||
                    this.ValorCorrecao != null &&
                    this.ValorCorrecao.Equals(other.ValorCorrecao)
                ) && 
                (
                    this.ValorIOF == other.ValorIOF ||
                    this.ValorIOF != null &&
                    this.ValorIOF.Equals(other.ValorIOF)
                ) && 
                (
                    this.ValorSaldoCorrigido == other.ValorSaldoCorrigido ||
                    this.ValorSaldoCorrigido != null &&
                    this.ValorSaldoCorrigido.Equals(other.ValorSaldoCorrigido)
                ) && 
                (
                    this.IdStatusConta == other.IdStatusConta ||
                    this.IdStatusConta != null &&
                    this.IdStatusConta.Equals(other.IdStatusConta)
                ) && 
                (
                    this.DescricaoStatusConta == other.DescricaoStatusConta ||
                    this.DescricaoStatusConta != null &&
                    this.DescricaoStatusConta.Equals(other.DescricaoStatusConta)
                ) && 
                (
                    this.IdStatusAcordo == other.IdStatusAcordo ||
                    this.IdStatusAcordo != null &&
                    this.IdStatusAcordo.Equals(other.IdStatusAcordo)
                ) && 
                (
                    this.DescricaoStatusAcordo == other.DescricaoStatusAcordo ||
                    this.DescricaoStatusAcordo != null &&
                    this.DescricaoStatusAcordo.Equals(other.DescricaoStatusAcordo)
                ) && 
                (
                    this.IdEscritorioCobranca == other.IdEscritorioCobranca ||
                    this.IdEscritorioCobranca != null &&
                    this.IdEscritorioCobranca.Equals(other.IdEscritorioCobranca)
                ) && 
                (
                    this.NomeEscritorioCobranca == other.NomeEscritorioCobranca ||
                    this.NomeEscritorioCobranca != null &&
                    this.NomeEscritorioCobranca.Equals(other.NomeEscritorioCobranca)
                ) && 
                (
                    this.EmailPessoaConta == other.EmailPessoaConta ||
                    this.EmailPessoaConta != null &&
                    this.EmailPessoaConta.Equals(other.EmailPessoaConta)
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
                
                if (this.DataVencimentoFaturaAtraso != null)
                    hash = hash * 59 + this.DataVencimentoFaturaAtraso.GetHashCode();
                
                if (this.QuantidadeDiasAtraso != null)
                    hash = hash * 59 + this.QuantidadeDiasAtraso.GetHashCode();
                
                if (this.DataVencimentoAcordo != null)
                    hash = hash * 59 + this.DataVencimentoAcordo.GetHashCode();
                
                if (this.QuantidadeDiasAtrasoCorrigido != null)
                    hash = hash * 59 + this.QuantidadeDiasAtrasoCorrigido.GetHashCode();
                
                if (this.ValorSaldoDevedor != null)
                    hash = hash * 59 + this.ValorSaldoDevedor.GetHashCode();
                
                if (this.TaxaCorrecao != null)
                    hash = hash * 59 + this.TaxaCorrecao.GetHashCode();
                
                if (this.ValorCorrecao != null)
                    hash = hash * 59 + this.ValorCorrecao.GetHashCode();
                
                if (this.ValorIOF != null)
                    hash = hash * 59 + this.ValorIOF.GetHashCode();
                
                if (this.ValorSaldoCorrigido != null)
                    hash = hash * 59 + this.ValorSaldoCorrigido.GetHashCode();
                
                if (this.IdStatusConta != null)
                    hash = hash * 59 + this.IdStatusConta.GetHashCode();
                
                if (this.DescricaoStatusConta != null)
                    hash = hash * 59 + this.DescricaoStatusConta.GetHashCode();
                
                if (this.IdStatusAcordo != null)
                    hash = hash * 59 + this.IdStatusAcordo.GetHashCode();
                
                if (this.DescricaoStatusAcordo != null)
                    hash = hash * 59 + this.DescricaoStatusAcordo.GetHashCode();
                
                if (this.IdEscritorioCobranca != null)
                    hash = hash * 59 + this.IdEscritorioCobranca.GetHashCode();
                
                if (this.NomeEscritorioCobranca != null)
                    hash = hash * 59 + this.NomeEscritorioCobranca.GetHashCode();
                
                if (this.EmailPessoaConta != null)
                    hash = hash * 59 + this.EmailPessoaConta.GetHashCode();
                
                return hash;
            }
        }

    }
}
