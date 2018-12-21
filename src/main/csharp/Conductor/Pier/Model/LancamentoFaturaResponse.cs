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
    /// Future Invoice
    /// </summary>
    [DataContract]
    public partial class LancamentoFaturaResponse :  IEquatable<LancamentoFaturaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LancamentoFaturaResponse" /> class.
        /// Initializes a new instance of the <see cref="LancamentoFaturaResponse" />class.
        /// </summary>
        /// <param name="IdTransacao">Identification Code of the transaction.</param>
        /// <param name="DescricaoTipoTransacao">Description of the transaction type.</param>
        /// <param name="IdTipoEvento">Identifier Code of the event type.</param>
        /// <param name="DescricaoTipoEvento">Description of the event type.</param>
        /// <param name="IdEvento">Identifier Code of the event.</param>
        /// <param name="IdConta">Identification Code of the Account.</param>
        /// <param name="Complemento">Complementary Description of the event.</param>
        /// <param name="ValorBRL">Value in reais.</param>
        /// <param name="ValorUSD">value in dollar.</param>
        /// <param name="NumeroParcela">Number of the parcels.</param>
        /// <param name="QuantidadeParcelas">Quantity of parcels.</param>
        /// <param name="DataHoraTransacao">Transaction date.</param>
        /// <param name="NomeEstabelecimento">Merchant Name.</param>
        /// <param name="DescricaoEstabelecimento">Merchant Description.</param>
        /// <param name="NomeFantasiaEstabelecimento">Fantasy Name of the Merchant.</param>
        /// <param name="FlagCredito">Flag that indicates if the launch is of credit.</param>
        /// <param name="IdMCC">Identifier Code of the MCC (Merchant Category Codes).</param>
        /// <param name="IdGrupoMCC">Identifier Code of the Group MCC.</param>
        /// <param name="DescricaoGrupoMCC">Description of the group MCC.</param>
        /// <param name="Titular">Indicate if the the cardholder is the holder of the account.</param>
        /// <param name="NomePortador">Printed name on the card.</param>
        /// <param name="NumeroCartaoMascarado">Card number masked.</param>
        /// <param name="FlagSolicitouContestacao">Flag that indicates if the client requested the contest of the transaction.</param>
        /// <param name="ValorTaxaEmbarque">Value of the Boarding taxe.</param>
        /// <param name="DescricaoAbreviada">Description abbreviated of the transaction.</param>

        public LancamentoFaturaResponse(long? IdTransacao = null, string DescricaoTipoTransacao = null, long? IdTipoEvento = null, string DescricaoTipoEvento = null, long? IdEvento = null, long? IdConta = null, string Complemento = null, double? ValorBRL = null, double? ValorUSD = null, int? NumeroParcela = null, int? QuantidadeParcelas = null, string DataHoraTransacao = null, string NomeEstabelecimento = null, string DescricaoEstabelecimento = null, string NomeFantasiaEstabelecimento = null, bool? FlagCredito = null, long? IdMCC = null, long? IdGrupoMCC = null, string DescricaoGrupoMCC = null, bool? Titular = null, string NomePortador = null, string NumeroCartaoMascarado = null, bool? FlagSolicitouContestacao = null, double? ValorTaxaEmbarque = null, string DescricaoAbreviada = null)
        {
            this.IdTransacao = IdTransacao;
            this.DescricaoTipoTransacao = DescricaoTipoTransacao;
            this.IdTipoEvento = IdTipoEvento;
            this.DescricaoTipoEvento = DescricaoTipoEvento;
            this.IdEvento = IdEvento;
            this.IdConta = IdConta;
            this.Complemento = Complemento;
            this.ValorBRL = ValorBRL;
            this.ValorUSD = ValorUSD;
            this.NumeroParcela = NumeroParcela;
            this.QuantidadeParcelas = QuantidadeParcelas;
            this.DataHoraTransacao = DataHoraTransacao;
            this.NomeEstabelecimento = NomeEstabelecimento;
            this.DescricaoEstabelecimento = DescricaoEstabelecimento;
            this.NomeFantasiaEstabelecimento = NomeFantasiaEstabelecimento;
            this.FlagCredito = FlagCredito;
            this.IdMCC = IdMCC;
            this.IdGrupoMCC = IdGrupoMCC;
            this.DescricaoGrupoMCC = DescricaoGrupoMCC;
            this.Titular = Titular;
            this.NomePortador = NomePortador;
            this.NumeroCartaoMascarado = NumeroCartaoMascarado;
            this.FlagSolicitouContestacao = FlagSolicitouContestacao;
            this.ValorTaxaEmbarque = ValorTaxaEmbarque;
            this.DescricaoAbreviada = DescricaoAbreviada;
            
        }
        
    
        /// <summary>
        /// Identification Code of the transaction
        /// </summary>
        /// <value>Identification Code of the transaction</value>
        [DataMember(Name="idTransacao", EmitDefaultValue=false)]
        public long? IdTransacao { get; set; }
    
        /// <summary>
        /// Description of the transaction type
        /// </summary>
        /// <value>Description of the transaction type</value>
        [DataMember(Name="descricaoTipoTransacao", EmitDefaultValue=false)]
        public string DescricaoTipoTransacao { get; set; }
    
        /// <summary>
        /// Identifier Code of the event type
        /// </summary>
        /// <value>Identifier Code of the event type</value>
        [DataMember(Name="idTipoEvento", EmitDefaultValue=false)]
        public long? IdTipoEvento { get; set; }
    
        /// <summary>
        /// Description of the event type
        /// </summary>
        /// <value>Description of the event type</value>
        [DataMember(Name="descricaoTipoEvento", EmitDefaultValue=false)]
        public string DescricaoTipoEvento { get; set; }
    
        /// <summary>
        /// Identifier Code of the event
        /// </summary>
        /// <value>Identifier Code of the event</value>
        [DataMember(Name="idEvento", EmitDefaultValue=false)]
        public long? IdEvento { get; set; }
    
        /// <summary>
        /// Identification Code of the Account
        /// </summary>
        /// <value>Identification Code of the Account</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Complementary Description of the event
        /// </summary>
        /// <value>Complementary Description of the event</value>
        [DataMember(Name="complemento", EmitDefaultValue=false)]
        public string Complemento { get; set; }
    
        /// <summary>
        /// Value in reais
        /// </summary>
        /// <value>Value in reais</value>
        [DataMember(Name="valorBRL", EmitDefaultValue=false)]
        public double? ValorBRL { get; set; }
    
        /// <summary>
        /// value in dollar
        /// </summary>
        /// <value>value in dollar</value>
        [DataMember(Name="valorUSD", EmitDefaultValue=false)]
        public double? ValorUSD { get; set; }
    
        /// <summary>
        /// Number of the parcels
        /// </summary>
        /// <value>Number of the parcels</value>
        [DataMember(Name="numeroParcela", EmitDefaultValue=false)]
        public int? NumeroParcela { get; set; }
    
        /// <summary>
        /// Quantity of parcels
        /// </summary>
        /// <value>Quantity of parcels</value>
        [DataMember(Name="quantidadeParcelas", EmitDefaultValue=false)]
        public int? QuantidadeParcelas { get; set; }
    
        /// <summary>
        /// Transaction date
        /// </summary>
        /// <value>Transaction date</value>
        [DataMember(Name="dataHoraTransacao", EmitDefaultValue=false)]
        public string DataHoraTransacao { get; set; }
    
        /// <summary>
        /// Merchant Name
        /// </summary>
        /// <value>Merchant Name</value>
        [DataMember(Name="nomeEstabelecimento", EmitDefaultValue=false)]
        public string NomeEstabelecimento { get; set; }
    
        /// <summary>
        /// Merchant Description
        /// </summary>
        /// <value>Merchant Description</value>
        [DataMember(Name="descricaoEstabelecimento", EmitDefaultValue=false)]
        public string DescricaoEstabelecimento { get; set; }
    
        /// <summary>
        /// Fantasy Name of the Merchant
        /// </summary>
        /// <value>Fantasy Name of the Merchant</value>
        [DataMember(Name="nomeFantasiaEstabelecimento", EmitDefaultValue=false)]
        public string NomeFantasiaEstabelecimento { get; set; }
    
        /// <summary>
        /// Flag that indicates if the launch is of credit
        /// </summary>
        /// <value>Flag that indicates if the launch is of credit</value>
        [DataMember(Name="flagCredito", EmitDefaultValue=false)]
        public bool? FlagCredito { get; set; }
    
        /// <summary>
        /// Identifier Code of the MCC (Merchant Category Codes)
        /// </summary>
        /// <value>Identifier Code of the MCC (Merchant Category Codes)</value>
        [DataMember(Name="idMCC", EmitDefaultValue=false)]
        public long? IdMCC { get; set; }
    
        /// <summary>
        /// Identifier Code of the Group MCC
        /// </summary>
        /// <value>Identifier Code of the Group MCC</value>
        [DataMember(Name="idGrupoMCC", EmitDefaultValue=false)]
        public long? IdGrupoMCC { get; set; }
    
        /// <summary>
        /// Description of the group MCC
        /// </summary>
        /// <value>Description of the group MCC</value>
        [DataMember(Name="descricaoGrupoMCC", EmitDefaultValue=false)]
        public string DescricaoGrupoMCC { get; set; }
    
        /// <summary>
        /// Indicate if the the cardholder is the holder of the account
        /// </summary>
        /// <value>Indicate if the the cardholder is the holder of the account</value>
        [DataMember(Name="titular", EmitDefaultValue=false)]
        public bool? Titular { get; set; }
    
        /// <summary>
        /// Printed name on the card
        /// </summary>
        /// <value>Printed name on the card</value>
        [DataMember(Name="nomePortador", EmitDefaultValue=false)]
        public string NomePortador { get; set; }
    
        /// <summary>
        /// Card number masked
        /// </summary>
        /// <value>Card number masked</value>
        [DataMember(Name="numeroCartaoMascarado", EmitDefaultValue=false)]
        public string NumeroCartaoMascarado { get; set; }
    
        /// <summary>
        /// Flag that indicates if the client requested the contest of the transaction
        /// </summary>
        /// <value>Flag that indicates if the client requested the contest of the transaction</value>
        [DataMember(Name="flagSolicitouContestacao", EmitDefaultValue=false)]
        public bool? FlagSolicitouContestacao { get; set; }
    
        /// <summary>
        /// Value of the Boarding taxe
        /// </summary>
        /// <value>Value of the Boarding taxe</value>
        [DataMember(Name="valorTaxaEmbarque", EmitDefaultValue=false)]
        public double? ValorTaxaEmbarque { get; set; }
    
        /// <summary>
        /// Description abbreviated of the transaction
        /// </summary>
        /// <value>Description abbreviated of the transaction</value>
        [DataMember(Name="descricaoAbreviada", EmitDefaultValue=false)]
        public string DescricaoAbreviada { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LancamentoFaturaResponse {\n");
            sb.Append("  IdTransacao: ").Append(IdTransacao).Append("\n");
            sb.Append("  DescricaoTipoTransacao: ").Append(DescricaoTipoTransacao).Append("\n");
            sb.Append("  IdTipoEvento: ").Append(IdTipoEvento).Append("\n");
            sb.Append("  DescricaoTipoEvento: ").Append(DescricaoTipoEvento).Append("\n");
            sb.Append("  IdEvento: ").Append(IdEvento).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  Complemento: ").Append(Complemento).Append("\n");
            sb.Append("  ValorBRL: ").Append(ValorBRL).Append("\n");
            sb.Append("  ValorUSD: ").Append(ValorUSD).Append("\n");
            sb.Append("  NumeroParcela: ").Append(NumeroParcela).Append("\n");
            sb.Append("  QuantidadeParcelas: ").Append(QuantidadeParcelas).Append("\n");
            sb.Append("  DataHoraTransacao: ").Append(DataHoraTransacao).Append("\n");
            sb.Append("  NomeEstabelecimento: ").Append(NomeEstabelecimento).Append("\n");
            sb.Append("  DescricaoEstabelecimento: ").Append(DescricaoEstabelecimento).Append("\n");
            sb.Append("  NomeFantasiaEstabelecimento: ").Append(NomeFantasiaEstabelecimento).Append("\n");
            sb.Append("  FlagCredito: ").Append(FlagCredito).Append("\n");
            sb.Append("  IdMCC: ").Append(IdMCC).Append("\n");
            sb.Append("  IdGrupoMCC: ").Append(IdGrupoMCC).Append("\n");
            sb.Append("  DescricaoGrupoMCC: ").Append(DescricaoGrupoMCC).Append("\n");
            sb.Append("  Titular: ").Append(Titular).Append("\n");
            sb.Append("  NomePortador: ").Append(NomePortador).Append("\n");
            sb.Append("  NumeroCartaoMascarado: ").Append(NumeroCartaoMascarado).Append("\n");
            sb.Append("  FlagSolicitouContestacao: ").Append(FlagSolicitouContestacao).Append("\n");
            sb.Append("  ValorTaxaEmbarque: ").Append(ValorTaxaEmbarque).Append("\n");
            sb.Append("  DescricaoAbreviada: ").Append(DescricaoAbreviada).Append("\n");
            
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
            return this.Equals(obj as LancamentoFaturaResponse);
        }

        /// <summary>
        /// Returns true if LancamentoFaturaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of LancamentoFaturaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LancamentoFaturaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdTransacao == other.IdTransacao ||
                    this.IdTransacao != null &&
                    this.IdTransacao.Equals(other.IdTransacao)
                ) && 
                (
                    this.DescricaoTipoTransacao == other.DescricaoTipoTransacao ||
                    this.DescricaoTipoTransacao != null &&
                    this.DescricaoTipoTransacao.Equals(other.DescricaoTipoTransacao)
                ) && 
                (
                    this.IdTipoEvento == other.IdTipoEvento ||
                    this.IdTipoEvento != null &&
                    this.IdTipoEvento.Equals(other.IdTipoEvento)
                ) && 
                (
                    this.DescricaoTipoEvento == other.DescricaoTipoEvento ||
                    this.DescricaoTipoEvento != null &&
                    this.DescricaoTipoEvento.Equals(other.DescricaoTipoEvento)
                ) && 
                (
                    this.IdEvento == other.IdEvento ||
                    this.IdEvento != null &&
                    this.IdEvento.Equals(other.IdEvento)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.Complemento == other.Complemento ||
                    this.Complemento != null &&
                    this.Complemento.Equals(other.Complemento)
                ) && 
                (
                    this.ValorBRL == other.ValorBRL ||
                    this.ValorBRL != null &&
                    this.ValorBRL.Equals(other.ValorBRL)
                ) && 
                (
                    this.ValorUSD == other.ValorUSD ||
                    this.ValorUSD != null &&
                    this.ValorUSD.Equals(other.ValorUSD)
                ) && 
                (
                    this.NumeroParcela == other.NumeroParcela ||
                    this.NumeroParcela != null &&
                    this.NumeroParcela.Equals(other.NumeroParcela)
                ) && 
                (
                    this.QuantidadeParcelas == other.QuantidadeParcelas ||
                    this.QuantidadeParcelas != null &&
                    this.QuantidadeParcelas.Equals(other.QuantidadeParcelas)
                ) && 
                (
                    this.DataHoraTransacao == other.DataHoraTransacao ||
                    this.DataHoraTransacao != null &&
                    this.DataHoraTransacao.Equals(other.DataHoraTransacao)
                ) && 
                (
                    this.NomeEstabelecimento == other.NomeEstabelecimento ||
                    this.NomeEstabelecimento != null &&
                    this.NomeEstabelecimento.Equals(other.NomeEstabelecimento)
                ) && 
                (
                    this.DescricaoEstabelecimento == other.DescricaoEstabelecimento ||
                    this.DescricaoEstabelecimento != null &&
                    this.DescricaoEstabelecimento.Equals(other.DescricaoEstabelecimento)
                ) && 
                (
                    this.NomeFantasiaEstabelecimento == other.NomeFantasiaEstabelecimento ||
                    this.NomeFantasiaEstabelecimento != null &&
                    this.NomeFantasiaEstabelecimento.Equals(other.NomeFantasiaEstabelecimento)
                ) && 
                (
                    this.FlagCredito == other.FlagCredito ||
                    this.FlagCredito != null &&
                    this.FlagCredito.Equals(other.FlagCredito)
                ) && 
                (
                    this.IdMCC == other.IdMCC ||
                    this.IdMCC != null &&
                    this.IdMCC.Equals(other.IdMCC)
                ) && 
                (
                    this.IdGrupoMCC == other.IdGrupoMCC ||
                    this.IdGrupoMCC != null &&
                    this.IdGrupoMCC.Equals(other.IdGrupoMCC)
                ) && 
                (
                    this.DescricaoGrupoMCC == other.DescricaoGrupoMCC ||
                    this.DescricaoGrupoMCC != null &&
                    this.DescricaoGrupoMCC.Equals(other.DescricaoGrupoMCC)
                ) && 
                (
                    this.Titular == other.Titular ||
                    this.Titular != null &&
                    this.Titular.Equals(other.Titular)
                ) && 
                (
                    this.NomePortador == other.NomePortador ||
                    this.NomePortador != null &&
                    this.NomePortador.Equals(other.NomePortador)
                ) && 
                (
                    this.NumeroCartaoMascarado == other.NumeroCartaoMascarado ||
                    this.NumeroCartaoMascarado != null &&
                    this.NumeroCartaoMascarado.Equals(other.NumeroCartaoMascarado)
                ) && 
                (
                    this.FlagSolicitouContestacao == other.FlagSolicitouContestacao ||
                    this.FlagSolicitouContestacao != null &&
                    this.FlagSolicitouContestacao.Equals(other.FlagSolicitouContestacao)
                ) && 
                (
                    this.ValorTaxaEmbarque == other.ValorTaxaEmbarque ||
                    this.ValorTaxaEmbarque != null &&
                    this.ValorTaxaEmbarque.Equals(other.ValorTaxaEmbarque)
                ) && 
                (
                    this.DescricaoAbreviada == other.DescricaoAbreviada ||
                    this.DescricaoAbreviada != null &&
                    this.DescricaoAbreviada.Equals(other.DescricaoAbreviada)
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
                
                if (this.IdTransacao != null)
                    hash = hash * 59 + this.IdTransacao.GetHashCode();
                
                if (this.DescricaoTipoTransacao != null)
                    hash = hash * 59 + this.DescricaoTipoTransacao.GetHashCode();
                
                if (this.IdTipoEvento != null)
                    hash = hash * 59 + this.IdTipoEvento.GetHashCode();
                
                if (this.DescricaoTipoEvento != null)
                    hash = hash * 59 + this.DescricaoTipoEvento.GetHashCode();
                
                if (this.IdEvento != null)
                    hash = hash * 59 + this.IdEvento.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.Complemento != null)
                    hash = hash * 59 + this.Complemento.GetHashCode();
                
                if (this.ValorBRL != null)
                    hash = hash * 59 + this.ValorBRL.GetHashCode();
                
                if (this.ValorUSD != null)
                    hash = hash * 59 + this.ValorUSD.GetHashCode();
                
                if (this.NumeroParcela != null)
                    hash = hash * 59 + this.NumeroParcela.GetHashCode();
                
                if (this.QuantidadeParcelas != null)
                    hash = hash * 59 + this.QuantidadeParcelas.GetHashCode();
                
                if (this.DataHoraTransacao != null)
                    hash = hash * 59 + this.DataHoraTransacao.GetHashCode();
                
                if (this.NomeEstabelecimento != null)
                    hash = hash * 59 + this.NomeEstabelecimento.GetHashCode();
                
                if (this.DescricaoEstabelecimento != null)
                    hash = hash * 59 + this.DescricaoEstabelecimento.GetHashCode();
                
                if (this.NomeFantasiaEstabelecimento != null)
                    hash = hash * 59 + this.NomeFantasiaEstabelecimento.GetHashCode();
                
                if (this.FlagCredito != null)
                    hash = hash * 59 + this.FlagCredito.GetHashCode();
                
                if (this.IdMCC != null)
                    hash = hash * 59 + this.IdMCC.GetHashCode();
                
                if (this.IdGrupoMCC != null)
                    hash = hash * 59 + this.IdGrupoMCC.GetHashCode();
                
                if (this.DescricaoGrupoMCC != null)
                    hash = hash * 59 + this.DescricaoGrupoMCC.GetHashCode();
                
                if (this.Titular != null)
                    hash = hash * 59 + this.Titular.GetHashCode();
                
                if (this.NomePortador != null)
                    hash = hash * 59 + this.NomePortador.GetHashCode();
                
                if (this.NumeroCartaoMascarado != null)
                    hash = hash * 59 + this.NumeroCartaoMascarado.GetHashCode();
                
                if (this.FlagSolicitouContestacao != null)
                    hash = hash * 59 + this.FlagSolicitouContestacao.GetHashCode();
                
                if (this.ValorTaxaEmbarque != null)
                    hash = hash * 59 + this.ValorTaxaEmbarque.GetHashCode();
                
                if (this.DescricaoAbreviada != null)
                    hash = hash * 59 + this.DescricaoAbreviada.GetHashCode();
                
                return hash;
            }
        }

    }
}
