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
    /// Object Card with more information
    /// </summary>
    [DataContract]
    public partial class CartaoDetalheResponse :  IEquatable<CartaoDetalheResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoDetalheResponse" /> class.
        /// Initializes a new instance of the <see cref="CartaoDetalheResponse" />class.
        /// </summary>
        /// <param name="Id">Identification Code of the Card.</param>
        /// <param name="FlagTitular">Show the tiype of the Cardholder, being: (1: Holder, 0: Additional).</param>
        /// <param name="IdPessoa">Identification Code of the Person which the card belongs.</param>
        /// <param name="SequencialCartao">Card Sequel Number.</param>
        /// <param name="IdConta">Identification Code of the Account which the card belongs.</param>
        /// <param name="IdStatus">Identification Code of the Card Status.</param>
        /// <param name="DataStatus">Show the date which the current idStatusCard was applied, when there is.</param>
        /// <param name="IdEstagio">Identification Code of the Stage Printed Card.</param>
        /// <param name="DataEstagio">Show te date which the current idStage of the card applied, when there is.</param>
        /// <param name="NumeroBin">Bin number of the card.</param>
        /// <param name="NumeroCartao">Show the card number.</param>
        /// <param name="NumeroCartaoHash">Hash Card Number.</param>
        /// <param name="NumeroCartaoCriptografado">Encrypted Card Number.</param>
        /// <param name="DataEmissao">Show the issue date of the card.</param>
        /// <param name="DataValidade">Show the Expiration date of the card in the format yyyy-MM, when there is.</param>
        /// <param name="CartaoVirtual">Show the status that informs if the card is virtual, being: (1: True, 0: False).</param>
        /// <param name="ImpressaoAvulsa">When it is active, indicates that the card was printed in the Commercial Origin.</param>
        /// <param name="DataImpressao">Show the date of the card that was printed, in case of printing in a store, or the date which was included in the file for printing in a Graphic.</param>
        /// <param name="NomeArquivoImpressao">Show the name of the file where the card was included for printing, when there is.</param>
        /// <param name="DescricaoTipoCartao">Describe the type of the card.</param>
        /// <param name="IdProduto">Identification Code of the Product which the card belongs.</param>
        /// <param name="NomeImpresso">Show the name printed on the card.</param>
        /// <param name="TipoCartao">Indicate the identifier of the card type.</param>
        /// <param name="CodigoDesbloqueio">Show a specific code to be used as a variable in the process of unlock the card for issuer that want to use this functionality.</param>

        public CartaoDetalheResponse(long? Id = null, int? FlagTitular = null, long? IdPessoa = null, int? SequencialCartao = null, long? IdConta = null, long? IdStatus = null, string DataStatus = null, long? IdEstagio = null, string DataEstagio = null, long? NumeroBin = null, string NumeroCartao = null, long? NumeroCartaoHash = null, string NumeroCartaoCriptografado = null, string DataEmissao = null, string DataValidade = null, int? CartaoVirtual = null, int? ImpressaoAvulsa = null, string DataImpressao = null, string NomeArquivoImpressao = null, string DescricaoTipoCartao = null, long? IdProduto = null, string NomeImpresso = null, long? TipoCartao = null, string CodigoDesbloqueio = null)
        {
            this.Id = Id;
            this.FlagTitular = FlagTitular;
            this.IdPessoa = IdPessoa;
            this.SequencialCartao = SequencialCartao;
            this.IdConta = IdConta;
            this.IdStatus = IdStatus;
            this.DataStatus = DataStatus;
            this.IdEstagio = IdEstagio;
            this.DataEstagio = DataEstagio;
            this.NumeroBin = NumeroBin;
            this.NumeroCartao = NumeroCartao;
            this.NumeroCartaoHash = NumeroCartaoHash;
            this.NumeroCartaoCriptografado = NumeroCartaoCriptografado;
            this.DataEmissao = DataEmissao;
            this.DataValidade = DataValidade;
            this.CartaoVirtual = CartaoVirtual;
            this.ImpressaoAvulsa = ImpressaoAvulsa;
            this.DataImpressao = DataImpressao;
            this.NomeArquivoImpressao = NomeArquivoImpressao;
            this.DescricaoTipoCartao = DescricaoTipoCartao;
            this.IdProduto = IdProduto;
            this.NomeImpresso = NomeImpresso;
            this.TipoCartao = TipoCartao;
            this.CodigoDesbloqueio = CodigoDesbloqueio;
            
        }
        
    
        /// <summary>
        /// Identification Code of the Card
        /// </summary>
        /// <value>Identification Code of the Card</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Show the tiype of the Cardholder, being: (1: Holder, 0: Additional)
        /// </summary>
        /// <value>Show the tiype of the Cardholder, being: (1: Holder, 0: Additional)</value>
        [DataMember(Name="flagTitular", EmitDefaultValue=false)]
        public int? FlagTitular { get; set; }
    
        /// <summary>
        /// Identification Code of the Person which the card belongs
        /// </summary>
        /// <value>Identification Code of the Person which the card belongs</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Card Sequel Number
        /// </summary>
        /// <value>Card Sequel Number</value>
        [DataMember(Name="sequencialCartao", EmitDefaultValue=false)]
        public int? SequencialCartao { get; set; }
    
        /// <summary>
        /// Identification Code of the Account which the card belongs
        /// </summary>
        /// <value>Identification Code of the Account which the card belongs</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identification Code of the Card Status
        /// </summary>
        /// <value>Identification Code of the Card Status</value>
        [DataMember(Name="idStatus", EmitDefaultValue=false)]
        public long? IdStatus { get; set; }
    
        /// <summary>
        /// Show the date which the current idStatusCard was applied, when there is
        /// </summary>
        /// <value>Show the date which the current idStatusCard was applied, when there is</value>
        [DataMember(Name="dataStatus", EmitDefaultValue=false)]
        public string DataStatus { get; set; }
    
        /// <summary>
        /// Identification Code of the Stage Printed Card
        /// </summary>
        /// <value>Identification Code of the Stage Printed Card</value>
        [DataMember(Name="idEstagio", EmitDefaultValue=false)]
        public long? IdEstagio { get; set; }
    
        /// <summary>
        /// Show te date which the current idStage of the card applied, when there is
        /// </summary>
        /// <value>Show te date which the current idStage of the card applied, when there is</value>
        [DataMember(Name="dataEstagio", EmitDefaultValue=false)]
        public string DataEstagio { get; set; }
    
        /// <summary>
        /// Bin number of the card
        /// </summary>
        /// <value>Bin number of the card</value>
        [DataMember(Name="numeroBin", EmitDefaultValue=false)]
        public long? NumeroBin { get; set; }
    
        /// <summary>
        /// Show the card number
        /// </summary>
        /// <value>Show the card number</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// Hash Card Number
        /// </summary>
        /// <value>Hash Card Number</value>
        [DataMember(Name="numeroCartaoHash", EmitDefaultValue=false)]
        public long? NumeroCartaoHash { get; set; }
    
        /// <summary>
        /// Encrypted Card Number
        /// </summary>
        /// <value>Encrypted Card Number</value>
        [DataMember(Name="numeroCartaoCriptografado", EmitDefaultValue=false)]
        public string NumeroCartaoCriptografado { get; set; }
    
        /// <summary>
        /// Show the issue date of the card
        /// </summary>
        /// <value>Show the issue date of the card</value>
        [DataMember(Name="dataEmissao", EmitDefaultValue=false)]
        public string DataEmissao { get; set; }
    
        /// <summary>
        /// Show the Expiration date of the card in the format yyyy-MM, when there is
        /// </summary>
        /// <value>Show the Expiration date of the card in the format yyyy-MM, when there is</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// Show the status that informs if the card is virtual, being: (1: True, 0: False)
        /// </summary>
        /// <value>Show the status that informs if the card is virtual, being: (1: True, 0: False)</value>
        [DataMember(Name="cartaoVirtual", EmitDefaultValue=false)]
        public int? CartaoVirtual { get; set; }
    
        /// <summary>
        /// When it is active, indicates that the card was printed in the Commercial Origin
        /// </summary>
        /// <value>When it is active, indicates that the card was printed in the Commercial Origin</value>
        [DataMember(Name="impressaoAvulsa", EmitDefaultValue=false)]
        public int? ImpressaoAvulsa { get; set; }
    
        /// <summary>
        /// Show the date of the card that was printed, in case of printing in a store, or the date which was included in the file for printing in a Graphic
        /// </summary>
        /// <value>Show the date of the card that was printed, in case of printing in a store, or the date which was included in the file for printing in a Graphic</value>
        [DataMember(Name="dataImpressao", EmitDefaultValue=false)]
        public string DataImpressao { get; set; }
    
        /// <summary>
        /// Show the name of the file where the card was included for printing, when there is
        /// </summary>
        /// <value>Show the name of the file where the card was included for printing, when there is</value>
        [DataMember(Name="nomeArquivoImpressao", EmitDefaultValue=false)]
        public string NomeArquivoImpressao { get; set; }
    
        /// <summary>
        /// Describe the type of the card
        /// </summary>
        /// <value>Describe the type of the card</value>
        [DataMember(Name="descricaoTipoCartao", EmitDefaultValue=false)]
        public string DescricaoTipoCartao { get; set; }
    
        /// <summary>
        /// Identification Code of the Product which the card belongs
        /// </summary>
        /// <value>Identification Code of the Product which the card belongs</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Show the name printed on the card
        /// </summary>
        /// <value>Show the name printed on the card</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// Indicate the identifier of the card type
        /// </summary>
        /// <value>Indicate the identifier of the card type</value>
        [DataMember(Name="tipoCartao", EmitDefaultValue=false)]
        public long? TipoCartao { get; set; }
    
        /// <summary>
        /// Show a specific code to be used as a variable in the process of unlock the card for issuer that want to use this functionality
        /// </summary>
        /// <value>Show a specific code to be used as a variable in the process of unlock the card for issuer that want to use this functionality</value>
        [DataMember(Name="codigoDesbloqueio", EmitDefaultValue=false)]
        public string CodigoDesbloqueio { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoDetalheResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FlagTitular: ").Append(FlagTitular).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  SequencialCartao: ").Append(SequencialCartao).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdStatus: ").Append(IdStatus).Append("\n");
            sb.Append("  DataStatus: ").Append(DataStatus).Append("\n");
            sb.Append("  IdEstagio: ").Append(IdEstagio).Append("\n");
            sb.Append("  DataEstagio: ").Append(DataEstagio).Append("\n");
            sb.Append("  NumeroBin: ").Append(NumeroBin).Append("\n");
            sb.Append("  NumeroCartao: ").Append(NumeroCartao).Append("\n");
            sb.Append("  NumeroCartaoHash: ").Append(NumeroCartaoHash).Append("\n");
            sb.Append("  NumeroCartaoCriptografado: ").Append(NumeroCartaoCriptografado).Append("\n");
            sb.Append("  DataEmissao: ").Append(DataEmissao).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            sb.Append("  CartaoVirtual: ").Append(CartaoVirtual).Append("\n");
            sb.Append("  ImpressaoAvulsa: ").Append(ImpressaoAvulsa).Append("\n");
            sb.Append("  DataImpressao: ").Append(DataImpressao).Append("\n");
            sb.Append("  NomeArquivoImpressao: ").Append(NomeArquivoImpressao).Append("\n");
            sb.Append("  DescricaoTipoCartao: ").Append(DescricaoTipoCartao).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  TipoCartao: ").Append(TipoCartao).Append("\n");
            sb.Append("  CodigoDesbloqueio: ").Append(CodigoDesbloqueio).Append("\n");
            
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
            return this.Equals(obj as CartaoDetalheResponse);
        }

        /// <summary>
        /// Returns true if CartaoDetalheResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoDetalheResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoDetalheResponse other)
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
                    this.FlagTitular == other.FlagTitular ||
                    this.FlagTitular != null &&
                    this.FlagTitular.Equals(other.FlagTitular)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.SequencialCartao == other.SequencialCartao ||
                    this.SequencialCartao != null &&
                    this.SequencialCartao.Equals(other.SequencialCartao)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdStatus == other.IdStatus ||
                    this.IdStatus != null &&
                    this.IdStatus.Equals(other.IdStatus)
                ) && 
                (
                    this.DataStatus == other.DataStatus ||
                    this.DataStatus != null &&
                    this.DataStatus.Equals(other.DataStatus)
                ) && 
                (
                    this.IdEstagio == other.IdEstagio ||
                    this.IdEstagio != null &&
                    this.IdEstagio.Equals(other.IdEstagio)
                ) && 
                (
                    this.DataEstagio == other.DataEstagio ||
                    this.DataEstagio != null &&
                    this.DataEstagio.Equals(other.DataEstagio)
                ) && 
                (
                    this.NumeroBin == other.NumeroBin ||
                    this.NumeroBin != null &&
                    this.NumeroBin.Equals(other.NumeroBin)
                ) && 
                (
                    this.NumeroCartao == other.NumeroCartao ||
                    this.NumeroCartao != null &&
                    this.NumeroCartao.Equals(other.NumeroCartao)
                ) && 
                (
                    this.NumeroCartaoHash == other.NumeroCartaoHash ||
                    this.NumeroCartaoHash != null &&
                    this.NumeroCartaoHash.Equals(other.NumeroCartaoHash)
                ) && 
                (
                    this.NumeroCartaoCriptografado == other.NumeroCartaoCriptografado ||
                    this.NumeroCartaoCriptografado != null &&
                    this.NumeroCartaoCriptografado.Equals(other.NumeroCartaoCriptografado)
                ) && 
                (
                    this.DataEmissao == other.DataEmissao ||
                    this.DataEmissao != null &&
                    this.DataEmissao.Equals(other.DataEmissao)
                ) && 
                (
                    this.DataValidade == other.DataValidade ||
                    this.DataValidade != null &&
                    this.DataValidade.Equals(other.DataValidade)
                ) && 
                (
                    this.CartaoVirtual == other.CartaoVirtual ||
                    this.CartaoVirtual != null &&
                    this.CartaoVirtual.Equals(other.CartaoVirtual)
                ) && 
                (
                    this.ImpressaoAvulsa == other.ImpressaoAvulsa ||
                    this.ImpressaoAvulsa != null &&
                    this.ImpressaoAvulsa.Equals(other.ImpressaoAvulsa)
                ) && 
                (
                    this.DataImpressao == other.DataImpressao ||
                    this.DataImpressao != null &&
                    this.DataImpressao.Equals(other.DataImpressao)
                ) && 
                (
                    this.NomeArquivoImpressao == other.NomeArquivoImpressao ||
                    this.NomeArquivoImpressao != null &&
                    this.NomeArquivoImpressao.Equals(other.NomeArquivoImpressao)
                ) && 
                (
                    this.DescricaoTipoCartao == other.DescricaoTipoCartao ||
                    this.DescricaoTipoCartao != null &&
                    this.DescricaoTipoCartao.Equals(other.DescricaoTipoCartao)
                ) && 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.NomeImpresso == other.NomeImpresso ||
                    this.NomeImpresso != null &&
                    this.NomeImpresso.Equals(other.NomeImpresso)
                ) && 
                (
                    this.TipoCartao == other.TipoCartao ||
                    this.TipoCartao != null &&
                    this.TipoCartao.Equals(other.TipoCartao)
                ) && 
                (
                    this.CodigoDesbloqueio == other.CodigoDesbloqueio ||
                    this.CodigoDesbloqueio != null &&
                    this.CodigoDesbloqueio.Equals(other.CodigoDesbloqueio)
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
                
                if (this.FlagTitular != null)
                    hash = hash * 59 + this.FlagTitular.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.SequencialCartao != null)
                    hash = hash * 59 + this.SequencialCartao.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdStatus != null)
                    hash = hash * 59 + this.IdStatus.GetHashCode();
                
                if (this.DataStatus != null)
                    hash = hash * 59 + this.DataStatus.GetHashCode();
                
                if (this.IdEstagio != null)
                    hash = hash * 59 + this.IdEstagio.GetHashCode();
                
                if (this.DataEstagio != null)
                    hash = hash * 59 + this.DataEstagio.GetHashCode();
                
                if (this.NumeroBin != null)
                    hash = hash * 59 + this.NumeroBin.GetHashCode();
                
                if (this.NumeroCartao != null)
                    hash = hash * 59 + this.NumeroCartao.GetHashCode();
                
                if (this.NumeroCartaoHash != null)
                    hash = hash * 59 + this.NumeroCartaoHash.GetHashCode();
                
                if (this.NumeroCartaoCriptografado != null)
                    hash = hash * 59 + this.NumeroCartaoCriptografado.GetHashCode();
                
                if (this.DataEmissao != null)
                    hash = hash * 59 + this.DataEmissao.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                if (this.CartaoVirtual != null)
                    hash = hash * 59 + this.CartaoVirtual.GetHashCode();
                
                if (this.ImpressaoAvulsa != null)
                    hash = hash * 59 + this.ImpressaoAvulsa.GetHashCode();
                
                if (this.DataImpressao != null)
                    hash = hash * 59 + this.DataImpressao.GetHashCode();
                
                if (this.NomeArquivoImpressao != null)
                    hash = hash * 59 + this.NomeArquivoImpressao.GetHashCode();
                
                if (this.DescricaoTipoCartao != null)
                    hash = hash * 59 + this.DescricaoTipoCartao.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.NomeImpresso != null)
                    hash = hash * 59 + this.NomeImpresso.GetHashCode();
                
                if (this.TipoCartao != null)
                    hash = hash * 59 + this.TipoCartao.GetHashCode();
                
                if (this.CodigoDesbloqueio != null)
                    hash = hash * 59 + this.CodigoDesbloqueio.GetHashCode();
                
                return hash;
            }
        }

    }
}
