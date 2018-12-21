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
    /// Representation of the transaction resource
    /// </summary>
    [DataContract]
    public partial class TransacaoCorrenteResponse :  IEquatable<TransacaoCorrenteResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransacaoCorrenteResponse" /> class.
        /// Initializes a new instance of the <see cref="TransacaoCorrenteResponse" />class.
        /// </summary>
        /// <param name="UltimaParcelaLancada">UltimaParcelaLancada.</param>
        /// <param name="IdConta">Identification Code of the Account (id).</param>
        /// <param name="IdTipoRegistro">Identification code of the transaction type (id).</param>
        /// <param name="Ordem">Representation of the transaction order (id).</param>
        /// <param name="IdTransacao">Identification Code of the transaction (id).</param>
        /// <param name="Descricao">Attribute that represents the description of the transaction.</param>
        /// <param name="Status">Attribute that represents the identifier code of the transaction status.</param>
        /// <param name="DescricaoStatus">Attribute that represent the description of the transaction status.</param>
        /// <param name="Valor">Attribute that represents the value of the transaction.</param>
        /// <param name="ValorDolar">Attribute that represents the value in dollar of the transaction.</param>
        /// <param name="QuantidadeParcelas">Attribute that represents the quantity of parcels of the transaction.</param>
        /// <param name="ValorParcela">Attribute that represents the parcel value of the transaction.</param>
        /// <param name="DataEvento">Attribute that represents the sending date of the transaction.</param>
        /// <param name="Estabelecimento">Attribute that represents the merchant of the transaction.</param>
        /// <param name="FlagCredito">Attribute that identifies if the transaction is a credit one or debit one.</param>
        /// <param name="TipoEstabelecimento">Attribute that represents the type merchant of the transaction.</param>
        /// <param name="IdGrupoMCC">Attribute that represents the MCC group of the transaction.</param>
        /// <param name="FlagSolicitouContestacao">Attribute that identifier if the cardholder requested the contesting of the transaction.</param>
        /// <param name="TipoTransacao">Attribute that identifies if the transaction is a credit one or debit one.</param>

        public TransacaoCorrenteResponse(int? UltimaParcelaLancada = null, long? IdConta = null, long? IdTipoRegistro = null, int? Ordem = null, long? IdTransacao = null, string Descricao = null, int? Status = null, string DescricaoStatus = null, double? Valor = null, double? ValorDolar = null, int? QuantidadeParcelas = null, double? ValorParcela = null, string DataEvento = null, string Estabelecimento = null, int? FlagCredito = null, string TipoEstabelecimento = null, int? IdGrupoMCC = null, int? FlagSolicitouContestacao = null, int? TipoTransacao = null)
        {
            this.UltimaParcelaLancada = UltimaParcelaLancada;
            this.IdConta = IdConta;
            this.IdTipoRegistro = IdTipoRegistro;
            this.Ordem = Ordem;
            this.IdTransacao = IdTransacao;
            this.Descricao = Descricao;
            this.Status = Status;
            this.DescricaoStatus = DescricaoStatus;
            this.Valor = Valor;
            this.ValorDolar = ValorDolar;
            this.QuantidadeParcelas = QuantidadeParcelas;
            this.ValorParcela = ValorParcela;
            this.DataEvento = DataEvento;
            this.Estabelecimento = Estabelecimento;
            this.FlagCredito = FlagCredito;
            this.TipoEstabelecimento = TipoEstabelecimento;
            this.IdGrupoMCC = IdGrupoMCC;
            this.FlagSolicitouContestacao = FlagSolicitouContestacao;
            this.TipoTransacao = TipoTransacao;
            
        }
        
    
        /// <summary>
        /// Gets or Sets UltimaParcelaLancada
        /// </summary>
        [DataMember(Name="ultimaParcelaLancada", EmitDefaultValue=false)]
        public int? UltimaParcelaLancada { get; set; }
    
        /// <summary>
        /// Identification Code of the Account (id)
        /// </summary>
        /// <value>Identification Code of the Account (id)</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identification code of the transaction type (id)
        /// </summary>
        /// <value>Identification code of the transaction type (id)</value>
        [DataMember(Name="idTipoRegistro", EmitDefaultValue=false)]
        public long? IdTipoRegistro { get; set; }
    
        /// <summary>
        /// Representation of the transaction order (id)
        /// </summary>
        /// <value>Representation of the transaction order (id)</value>
        [DataMember(Name="ordem", EmitDefaultValue=false)]
        public int? Ordem { get; set; }
    
        /// <summary>
        /// Identification Code of the transaction (id)
        /// </summary>
        /// <value>Identification Code of the transaction (id)</value>
        [DataMember(Name="idTransacao", EmitDefaultValue=false)]
        public long? IdTransacao { get; set; }
    
        /// <summary>
        /// Attribute that represents the description of the transaction
        /// </summary>
        /// <value>Attribute that represents the description of the transaction</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Attribute that represents the identifier code of the transaction status
        /// </summary>
        /// <value>Attribute that represents the identifier code of the transaction status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// Attribute that represent the description of the transaction status
        /// </summary>
        /// <value>Attribute that represent the description of the transaction status</value>
        [DataMember(Name="descricaoStatus", EmitDefaultValue=false)]
        public string DescricaoStatus { get; set; }
    
        /// <summary>
        /// Attribute that represents the value of the transaction
        /// </summary>
        /// <value>Attribute that represents the value of the transaction</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// Attribute that represents the value in dollar of the transaction
        /// </summary>
        /// <value>Attribute that represents the value in dollar of the transaction</value>
        [DataMember(Name="valorDolar", EmitDefaultValue=false)]
        public double? ValorDolar { get; set; }
    
        /// <summary>
        /// Attribute that represents the quantity of parcels of the transaction
        /// </summary>
        /// <value>Attribute that represents the quantity of parcels of the transaction</value>
        [DataMember(Name="quantidadeParcelas", EmitDefaultValue=false)]
        public int? QuantidadeParcelas { get; set; }
    
        /// <summary>
        /// Attribute that represents the parcel value of the transaction
        /// </summary>
        /// <value>Attribute that represents the parcel value of the transaction</value>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public double? ValorParcela { get; set; }
    
        /// <summary>
        /// Attribute that represents the sending date of the transaction
        /// </summary>
        /// <value>Attribute that represents the sending date of the transaction</value>
        [DataMember(Name="dataEvento", EmitDefaultValue=false)]
        public string DataEvento { get; set; }
    
        /// <summary>
        /// Attribute that represents the merchant of the transaction
        /// </summary>
        /// <value>Attribute that represents the merchant of the transaction</value>
        [DataMember(Name="estabelecimento", EmitDefaultValue=false)]
        public string Estabelecimento { get; set; }
    
        /// <summary>
        /// Attribute that identifies if the transaction is a credit one or debit one
        /// </summary>
        /// <value>Attribute that identifies if the transaction is a credit one or debit one</value>
        [DataMember(Name="flagCredito", EmitDefaultValue=false)]
        public int? FlagCredito { get; set; }
    
        /// <summary>
        /// Attribute that represents the type merchant of the transaction
        /// </summary>
        /// <value>Attribute that represents the type merchant of the transaction</value>
        [DataMember(Name="tipoEstabelecimento", EmitDefaultValue=false)]
        public string TipoEstabelecimento { get; set; }
    
        /// <summary>
        /// Attribute that represents the MCC group of the transaction
        /// </summary>
        /// <value>Attribute that represents the MCC group of the transaction</value>
        [DataMember(Name="idGrupoMCC", EmitDefaultValue=false)]
        public int? IdGrupoMCC { get; set; }
    
        /// <summary>
        /// Attribute that identifier if the cardholder requested the contesting of the transaction
        /// </summary>
        /// <value>Attribute that identifier if the cardholder requested the contesting of the transaction</value>
        [DataMember(Name="flagSolicitouContestacao", EmitDefaultValue=false)]
        public int? FlagSolicitouContestacao { get; set; }
    
        /// <summary>
        /// Attribute that identifies if the transaction is a credit one or debit one
        /// </summary>
        /// <value>Attribute that identifies if the transaction is a credit one or debit one</value>
        [DataMember(Name="tipoTransacao", EmitDefaultValue=false)]
        public int? TipoTransacao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransacaoCorrenteResponse {\n");
            sb.Append("  UltimaParcelaLancada: ").Append(UltimaParcelaLancada).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdTipoRegistro: ").Append(IdTipoRegistro).Append("\n");
            sb.Append("  Ordem: ").Append(Ordem).Append("\n");
            sb.Append("  IdTransacao: ").Append(IdTransacao).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DescricaoStatus: ").Append(DescricaoStatus).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  ValorDolar: ").Append(ValorDolar).Append("\n");
            sb.Append("  QuantidadeParcelas: ").Append(QuantidadeParcelas).Append("\n");
            sb.Append("  ValorParcela: ").Append(ValorParcela).Append("\n");
            sb.Append("  DataEvento: ").Append(DataEvento).Append("\n");
            sb.Append("  Estabelecimento: ").Append(Estabelecimento).Append("\n");
            sb.Append("  FlagCredito: ").Append(FlagCredito).Append("\n");
            sb.Append("  TipoEstabelecimento: ").Append(TipoEstabelecimento).Append("\n");
            sb.Append("  IdGrupoMCC: ").Append(IdGrupoMCC).Append("\n");
            sb.Append("  FlagSolicitouContestacao: ").Append(FlagSolicitouContestacao).Append("\n");
            sb.Append("  TipoTransacao: ").Append(TipoTransacao).Append("\n");
            
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
            return this.Equals(obj as TransacaoCorrenteResponse);
        }

        /// <summary>
        /// Returns true if TransacaoCorrenteResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TransacaoCorrenteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransacaoCorrenteResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UltimaParcelaLancada == other.UltimaParcelaLancada ||
                    this.UltimaParcelaLancada != null &&
                    this.UltimaParcelaLancada.Equals(other.UltimaParcelaLancada)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdTipoRegistro == other.IdTipoRegistro ||
                    this.IdTipoRegistro != null &&
                    this.IdTipoRegistro.Equals(other.IdTipoRegistro)
                ) && 
                (
                    this.Ordem == other.Ordem ||
                    this.Ordem != null &&
                    this.Ordem.Equals(other.Ordem)
                ) && 
                (
                    this.IdTransacao == other.IdTransacao ||
                    this.IdTransacao != null &&
                    this.IdTransacao.Equals(other.IdTransacao)
                ) && 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.DescricaoStatus == other.DescricaoStatus ||
                    this.DescricaoStatus != null &&
                    this.DescricaoStatus.Equals(other.DescricaoStatus)
                ) && 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
                ) && 
                (
                    this.ValorDolar == other.ValorDolar ||
                    this.ValorDolar != null &&
                    this.ValorDolar.Equals(other.ValorDolar)
                ) && 
                (
                    this.QuantidadeParcelas == other.QuantidadeParcelas ||
                    this.QuantidadeParcelas != null &&
                    this.QuantidadeParcelas.Equals(other.QuantidadeParcelas)
                ) && 
                (
                    this.ValorParcela == other.ValorParcela ||
                    this.ValorParcela != null &&
                    this.ValorParcela.Equals(other.ValorParcela)
                ) && 
                (
                    this.DataEvento == other.DataEvento ||
                    this.DataEvento != null &&
                    this.DataEvento.Equals(other.DataEvento)
                ) && 
                (
                    this.Estabelecimento == other.Estabelecimento ||
                    this.Estabelecimento != null &&
                    this.Estabelecimento.Equals(other.Estabelecimento)
                ) && 
                (
                    this.FlagCredito == other.FlagCredito ||
                    this.FlagCredito != null &&
                    this.FlagCredito.Equals(other.FlagCredito)
                ) && 
                (
                    this.TipoEstabelecimento == other.TipoEstabelecimento ||
                    this.TipoEstabelecimento != null &&
                    this.TipoEstabelecimento.Equals(other.TipoEstabelecimento)
                ) && 
                (
                    this.IdGrupoMCC == other.IdGrupoMCC ||
                    this.IdGrupoMCC != null &&
                    this.IdGrupoMCC.Equals(other.IdGrupoMCC)
                ) && 
                (
                    this.FlagSolicitouContestacao == other.FlagSolicitouContestacao ||
                    this.FlagSolicitouContestacao != null &&
                    this.FlagSolicitouContestacao.Equals(other.FlagSolicitouContestacao)
                ) && 
                (
                    this.TipoTransacao == other.TipoTransacao ||
                    this.TipoTransacao != null &&
                    this.TipoTransacao.Equals(other.TipoTransacao)
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
                
                if (this.UltimaParcelaLancada != null)
                    hash = hash * 59 + this.UltimaParcelaLancada.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdTipoRegistro != null)
                    hash = hash * 59 + this.IdTipoRegistro.GetHashCode();
                
                if (this.Ordem != null)
                    hash = hash * 59 + this.Ordem.GetHashCode();
                
                if (this.IdTransacao != null)
                    hash = hash * 59 + this.IdTransacao.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.DescricaoStatus != null)
                    hash = hash * 59 + this.DescricaoStatus.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                if (this.ValorDolar != null)
                    hash = hash * 59 + this.ValorDolar.GetHashCode();
                
                if (this.QuantidadeParcelas != null)
                    hash = hash * 59 + this.QuantidadeParcelas.GetHashCode();
                
                if (this.ValorParcela != null)
                    hash = hash * 59 + this.ValorParcela.GetHashCode();
                
                if (this.DataEvento != null)
                    hash = hash * 59 + this.DataEvento.GetHashCode();
                
                if (this.Estabelecimento != null)
                    hash = hash * 59 + this.Estabelecimento.GetHashCode();
                
                if (this.FlagCredito != null)
                    hash = hash * 59 + this.FlagCredito.GetHashCode();
                
                if (this.TipoEstabelecimento != null)
                    hash = hash * 59 + this.TipoEstabelecimento.GetHashCode();
                
                if (this.IdGrupoMCC != null)
                    hash = hash * 59 + this.IdGrupoMCC.GetHashCode();
                
                if (this.FlagSolicitouContestacao != null)
                    hash = hash * 59 + this.FlagSolicitouContestacao.GetHashCode();
                
                if (this.TipoTransacao != null)
                    hash = hash * 59 + this.TipoTransacao.GetHashCode();
                
                return hash;
            }
        }

    }
}
