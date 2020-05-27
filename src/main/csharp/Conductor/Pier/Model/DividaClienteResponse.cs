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
    /// D\u00EDvida do cliente
    /// </summary>
    [DataContract]
    public partial class DividaClienteResponse :  IEquatable<DividaClienteResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DividaClienteResponse" /> class.
        /// Initializes a new instance of the <see cref="DividaClienteResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="DataVencimentoFaturaAtraso">Data de vencimento da cobran\u00E7a.</param>
        /// <param name="QuantidadeDiasAtraso">Quantidade de dias em atraso at\u00E9 a data de vencimento da cobran\u00E7a.</param>
        /// <param name="DataVencimentoAcordo">Data de vencimento do acordo.</param>
        /// <param name="QuantidadeDiasAtrasoCorrigido">Quantidade de dias em atraso at\u00E9 a data de vencimento do acordo.</param>
        /// <param name="ValorSaldoDevedor">Valor do saldo devedor at\u00E9 a data de vencimento da cobran\u00E7a.</param>
        /// <param name="TaxaCorrecao">Percentual de corre\u00E7\u00E3o.</param>
        /// <param name="ValorCorrecao">Valor da corre\u00E7\u00E3o.</param>
        /// <param name="ValorIOF">Valor do IOF devido.</param>
        /// <param name="ValorSaldoCorrigido">Valor do saldo devedor corrido da d\u00EDvida at\u00E9 a data de vencimento do acordo.</param>
        /// <param name="IdStatusConta">C\u00F3digo de identifica\u00E7\u00E3o do status da conta (id).</param>
        /// <param name="DescricaoStatusConta">Descri\u00E7\u00E3o do status da conta.</param>
        /// <param name="IdStatusAcordo">C\u00F3digo de identifica\u00E7\u00E3o do status do acordo (id).</param>
        /// <param name="DescricaoStatusAcordo">Descri\u00E7\u00E3o do status do acordo.</param>
        /// <param name="IdEscritorioCobranca">C\u00F3digo de identifica\u00E7\u00E3o do escrit\u00F3rio de cobran\u00E7a.</param>
        /// <param name="NomeEscritorioCobranca">Nome do escrit\u00F3rio de cobran\u00E7a.</param>
        /// <param name="EmailPessoaConta">Email do devedor.</param>
        /// <param name="DataEntradaCreliq">Data de entrada em creliq.</param>

        public DividaClienteResponse(long? Id = null, string DataVencimentoFaturaAtraso = null, long? QuantidadeDiasAtraso = null, string DataVencimentoAcordo = null, long? QuantidadeDiasAtrasoCorrigido = null, double? ValorSaldoDevedor = null, double? TaxaCorrecao = null, double? ValorCorrecao = null, double? ValorIOF = null, double? ValorSaldoCorrigido = null, long? IdStatusConta = null, string DescricaoStatusConta = null, long? IdStatusAcordo = null, string DescricaoStatusAcordo = null, long? IdEscritorioCobranca = null, string NomeEscritorioCobranca = null, string EmailPessoaConta = null, string DataEntradaCreliq = null)
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
            this.DataEntradaCreliq = DataEntradaCreliq;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da conta (id)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Data de vencimento da cobran\u00E7a
        /// </summary>
        /// <value>Data de vencimento da cobran\u00E7a</value>
        [DataMember(Name="dataVencimentoFaturaAtraso", EmitDefaultValue=false)]
        public string DataVencimentoFaturaAtraso { get; set; }
    
        /// <summary>
        /// Quantidade de dias em atraso at\u00E9 a data de vencimento da cobran\u00E7a
        /// </summary>
        /// <value>Quantidade de dias em atraso at\u00E9 a data de vencimento da cobran\u00E7a</value>
        [DataMember(Name="quantidadeDiasAtraso", EmitDefaultValue=false)]
        public long? QuantidadeDiasAtraso { get; set; }
    
        /// <summary>
        /// Data de vencimento do acordo
        /// </summary>
        /// <value>Data de vencimento do acordo</value>
        [DataMember(Name="dataVencimentoAcordo", EmitDefaultValue=false)]
        public string DataVencimentoAcordo { get; set; }
    
        /// <summary>
        /// Quantidade de dias em atraso at\u00E9 a data de vencimento do acordo
        /// </summary>
        /// <value>Quantidade de dias em atraso at\u00E9 a data de vencimento do acordo</value>
        [DataMember(Name="quantidadeDiasAtrasoCorrigido", EmitDefaultValue=false)]
        public long? QuantidadeDiasAtrasoCorrigido { get; set; }
    
        /// <summary>
        /// Valor do saldo devedor at\u00E9 a data de vencimento da cobran\u00E7a
        /// </summary>
        /// <value>Valor do saldo devedor at\u00E9 a data de vencimento da cobran\u00E7a</value>
        [DataMember(Name="valorSaldoDevedor", EmitDefaultValue=false)]
        public double? ValorSaldoDevedor { get; set; }
    
        /// <summary>
        /// Percentual de corre\u00E7\u00E3o
        /// </summary>
        /// <value>Percentual de corre\u00E7\u00E3o</value>
        [DataMember(Name="taxaCorrecao", EmitDefaultValue=false)]
        public double? TaxaCorrecao { get; set; }
    
        /// <summary>
        /// Valor da corre\u00E7\u00E3o
        /// </summary>
        /// <value>Valor da corre\u00E7\u00E3o</value>
        [DataMember(Name="valorCorrecao", EmitDefaultValue=false)]
        public double? ValorCorrecao { get; set; }
    
        /// <summary>
        /// Valor do IOF devido
        /// </summary>
        /// <value>Valor do IOF devido</value>
        [DataMember(Name="valorIOF", EmitDefaultValue=false)]
        public double? ValorIOF { get; set; }
    
        /// <summary>
        /// Valor do saldo devedor corrido da d\u00EDvida at\u00E9 a data de vencimento do acordo
        /// </summary>
        /// <value>Valor do saldo devedor corrido da d\u00EDvida at\u00E9 a data de vencimento do acordo</value>
        [DataMember(Name="valorSaldoCorrigido", EmitDefaultValue=false)]
        public double? ValorSaldoCorrigido { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do status da conta (id)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do status da conta (id)</value>
        [DataMember(Name="idStatusConta", EmitDefaultValue=false)]
        public long? IdStatusConta { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do status da conta
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do status da conta</value>
        [DataMember(Name="descricaoStatusConta", EmitDefaultValue=false)]
        public string DescricaoStatusConta { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do status do acordo (id)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do status do acordo (id)</value>
        [DataMember(Name="idStatusAcordo", EmitDefaultValue=false)]
        public long? IdStatusAcordo { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do status do acordo
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do status do acordo</value>
        [DataMember(Name="descricaoStatusAcordo", EmitDefaultValue=false)]
        public string DescricaoStatusAcordo { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do escrit\u00F3rio de cobran\u00E7a
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do escrit\u00F3rio de cobran\u00E7a</value>
        [DataMember(Name="idEscritorioCobranca", EmitDefaultValue=false)]
        public long? IdEscritorioCobranca { get; set; }
    
        /// <summary>
        /// Nome do escrit\u00F3rio de cobran\u00E7a
        /// </summary>
        /// <value>Nome do escrit\u00F3rio de cobran\u00E7a</value>
        [DataMember(Name="nomeEscritorioCobranca", EmitDefaultValue=false)]
        public string NomeEscritorioCobranca { get; set; }
    
        /// <summary>
        /// Email do devedor
        /// </summary>
        /// <value>Email do devedor</value>
        [DataMember(Name="emailPessoaConta", EmitDefaultValue=false)]
        public string EmailPessoaConta { get; set; }
    
        /// <summary>
        /// Data de entrada em creliq
        /// </summary>
        /// <value>Data de entrada em creliq</value>
        [DataMember(Name="dataEntradaCreliq", EmitDefaultValue=false)]
        public string DataEntradaCreliq { get; set; }
    
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
            sb.Append("  DataEntradaCreliq: ").Append(DataEntradaCreliq).Append("\n");
            
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
                ) && 
                (
                    this.DataEntradaCreliq == other.DataEntradaCreliq ||
                    this.DataEntradaCreliq != null &&
                    this.DataEntradaCreliq.Equals(other.DataEntradaCreliq)
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
                
                if (this.DataEntradaCreliq != null)
                    hash = hash * 59 + this.DataEntradaCreliq.GetHashCode();
                
                return hash;
            }
        }

    }
}
