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
    /// Response Parameters of Fraud Risk
    /// </summary>
    [DataContract]
    public partial class RiskFraudResponse :  IEquatable<RiskFraudResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskFraudResponse" /> class.
        /// Initializes a new instance of the <see cref="RiskFraudResponse" />class.
        /// </summary>
        /// <param name="Id">identification Code of the risk of Fraud.</param>
        /// <param name="IdTipoResolucao">Identification Code of the type of resolution attributed to the register.</param>
        /// <param name="DescricaoTipoResolucao">Description of the type of the resolution attributed to the register.</param>
        /// <param name="FlagAltoRisco">When it is active, it indicates that a transaction has a great risk of fraud and all the following transactions will be denied until all the transactions ranked as a risk of fraud be analyzed.</param>
        /// <param name="IdConta">Identification code of the account.</param>
        /// <param name="IdCartao">Identification Code of the Card.</param>
        /// <param name="IdTransacao">Identification Code of the transaction.</param>
        /// <param name="DataTransacao">Date which the transaction ranked as a risk of fraud was made.</param>
        /// <param name="ValorTransacao">Value of the transaction ranked as a risk of fraud.</param>
        /// <param name="NomeEstabelecimento">Value of the transaction ranked as a risk of fraud.</param>

        public RiskFraudResponse(long? Id = null, long? IdTipoResolucao = null, string DescricaoTipoResolucao = null, bool? FlagAltoRisco = null, long? IdConta = null, long? IdCartao = null, long? IdTransacao = null, string DataTransacao = null, double? ValorTransacao = null, string NomeEstabelecimento = null)
        {
            this.Id = Id;
            this.IdTipoResolucao = IdTipoResolucao;
            this.DescricaoTipoResolucao = DescricaoTipoResolucao;
            this.FlagAltoRisco = FlagAltoRisco;
            this.IdConta = IdConta;
            this.IdCartao = IdCartao;
            this.IdTransacao = IdTransacao;
            this.DataTransacao = DataTransacao;
            this.ValorTransacao = ValorTransacao;
            this.NomeEstabelecimento = NomeEstabelecimento;
            
        }
        
    
        /// <summary>
        /// identification Code of the risk of Fraud
        /// </summary>
        /// <value>identification Code of the risk of Fraud</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Identification Code of the type of resolution attributed to the register
        /// </summary>
        /// <value>Identification Code of the type of resolution attributed to the register</value>
        [DataMember(Name="idTipoResolucao", EmitDefaultValue=false)]
        public long? IdTipoResolucao { get; set; }
    
        /// <summary>
        /// Description of the type of the resolution attributed to the register
        /// </summary>
        /// <value>Description of the type of the resolution attributed to the register</value>
        [DataMember(Name="descricaoTipoResolucao", EmitDefaultValue=false)]
        public string DescricaoTipoResolucao { get; set; }
    
        /// <summary>
        /// When it is active, it indicates that a transaction has a great risk of fraud and all the following transactions will be denied until all the transactions ranked as a risk of fraud be analyzed
        /// </summary>
        /// <value>When it is active, it indicates that a transaction has a great risk of fraud and all the following transactions will be denied until all the transactions ranked as a risk of fraud be analyzed</value>
        [DataMember(Name="flagAltoRisco", EmitDefaultValue=false)]
        public bool? FlagAltoRisco { get; set; }
    
        /// <summary>
        /// Identification code of the account
        /// </summary>
        /// <value>Identification code of the account</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identification Code of the Card
        /// </summary>
        /// <value>Identification Code of the Card</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Identification Code of the transaction
        /// </summary>
        /// <value>Identification Code of the transaction</value>
        [DataMember(Name="idTransacao", EmitDefaultValue=false)]
        public long? IdTransacao { get; set; }
    
        /// <summary>
        /// Date which the transaction ranked as a risk of fraud was made
        /// </summary>
        /// <value>Date which the transaction ranked as a risk of fraud was made</value>
        [DataMember(Name="dataTransacao", EmitDefaultValue=false)]
        public string DataTransacao { get; set; }
    
        /// <summary>
        /// Value of the transaction ranked as a risk of fraud
        /// </summary>
        /// <value>Value of the transaction ranked as a risk of fraud</value>
        [DataMember(Name="valorTransacao", EmitDefaultValue=false)]
        public double? ValorTransacao { get; set; }
    
        /// <summary>
        /// Value of the transaction ranked as a risk of fraud
        /// </summary>
        /// <value>Value of the transaction ranked as a risk of fraud</value>
        [DataMember(Name="nomeEstabelecimento", EmitDefaultValue=false)]
        public string NomeEstabelecimento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RiskFraudResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdTipoResolucao: ").Append(IdTipoResolucao).Append("\n");
            sb.Append("  DescricaoTipoResolucao: ").Append(DescricaoTipoResolucao).Append("\n");
            sb.Append("  FlagAltoRisco: ").Append(FlagAltoRisco).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdTransacao: ").Append(IdTransacao).Append("\n");
            sb.Append("  DataTransacao: ").Append(DataTransacao).Append("\n");
            sb.Append("  ValorTransacao: ").Append(ValorTransacao).Append("\n");
            sb.Append("  NomeEstabelecimento: ").Append(NomeEstabelecimento).Append("\n");
            
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
            return this.Equals(obj as RiskFraudResponse);
        }

        /// <summary>
        /// Returns true if RiskFraudResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of RiskFraudResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RiskFraudResponse other)
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
                    this.IdTipoResolucao == other.IdTipoResolucao ||
                    this.IdTipoResolucao != null &&
                    this.IdTipoResolucao.Equals(other.IdTipoResolucao)
                ) && 
                (
                    this.DescricaoTipoResolucao == other.DescricaoTipoResolucao ||
                    this.DescricaoTipoResolucao != null &&
                    this.DescricaoTipoResolucao.Equals(other.DescricaoTipoResolucao)
                ) && 
                (
                    this.FlagAltoRisco == other.FlagAltoRisco ||
                    this.FlagAltoRisco != null &&
                    this.FlagAltoRisco.Equals(other.FlagAltoRisco)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.IdTransacao == other.IdTransacao ||
                    this.IdTransacao != null &&
                    this.IdTransacao.Equals(other.IdTransacao)
                ) && 
                (
                    this.DataTransacao == other.DataTransacao ||
                    this.DataTransacao != null &&
                    this.DataTransacao.Equals(other.DataTransacao)
                ) && 
                (
                    this.ValorTransacao == other.ValorTransacao ||
                    this.ValorTransacao != null &&
                    this.ValorTransacao.Equals(other.ValorTransacao)
                ) && 
                (
                    this.NomeEstabelecimento == other.NomeEstabelecimento ||
                    this.NomeEstabelecimento != null &&
                    this.NomeEstabelecimento.Equals(other.NomeEstabelecimento)
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
                
                if (this.IdTipoResolucao != null)
                    hash = hash * 59 + this.IdTipoResolucao.GetHashCode();
                
                if (this.DescricaoTipoResolucao != null)
                    hash = hash * 59 + this.DescricaoTipoResolucao.GetHashCode();
                
                if (this.FlagAltoRisco != null)
                    hash = hash * 59 + this.FlagAltoRisco.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.IdTransacao != null)
                    hash = hash * 59 + this.IdTransacao.GetHashCode();
                
                if (this.DataTransacao != null)
                    hash = hash * 59 + this.DataTransacao.GetHashCode();
                
                if (this.ValorTransacao != null)
                    hash = hash * 59 + this.ValorTransacao.GetHashCode();
                
                if (this.NomeEstabelecimento != null)
                    hash = hash * 59 + this.NomeEstabelecimento.GetHashCode();
                
                return hash;
            }
        }

    }
}
