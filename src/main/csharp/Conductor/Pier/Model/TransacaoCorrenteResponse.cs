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
    /// Representa\u00C3\u00A7\u00C3\u00A3o do recurso transacao
    /// </summary>
    [DataContract]
    public partial class TransacaoCorrenteResponse :  IEquatable<TransacaoCorrenteResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransacaoCorrenteResponse" /> class.
        /// Initializes a new instance of the <see cref="TransacaoCorrenteResponse" />class.
        /// </summary>
        /// <param name="UltimaParcelaLancada">UltimaParcelaLancada.</param>
        /// <param name="IdConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id)..</param>
        /// <param name="IdTipoRegistro">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de transacao (id)..</param>
        /// <param name="Ordem">Representa\u00C3\u00A7\u00C3\u00A3o da ordena\u00C3\u00A7\u00C3\u00A3o da transacao (id)..</param>
        /// <param name="IdTransacao">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transacao (id)..</param>
        /// <param name="Descricao">Atributo que representa a descri\u00C3\u00A7\u00C3\u00A3o da transa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="Status">Atributo que representa o c\u00C3\u00B3digo identificador do status da transa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="DescricaoStatus">Atributo que representa a descri\u00C3\u00A7\u00C3\u00A3o do status da transa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="Valor">Atributo que representa o valor da transa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="ValorDolar">Atributo que representa o valor em D\u00C3\u00B3lar da transa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="QuantidadeParcelas">Atributo que representa a quantidade de parcelas da transa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="ValorParcela">Atributo que representa o valor da parcela da transa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="DataEvento">Atributo que representa a data de envio da transa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="Estabelecimento">Atributo que representa o estabelecimento da transa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="FlagCredito">Atributo que identifica se a transa\u00C3\u00A7\u00C3\u00A3o \u00C3\u00A9 um cr\u00C3\u00A9dito ou d\u00C3\u00A9bito..</param>
        /// <param name="TipoEstabelecimento">Atributo que representa o tipo de estabelecimento da transa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="IdGrupoMCC">Atributo que representa o grupo MCC da transa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="FlagSolicitouContestacao">Atributo que identifica se o portador solicitou contesta\u00C3\u00A7\u00C3\u00A3o da transa\u00C3\u00A7\u00C3\u00A3o..</param>

        public TransacaoCorrenteResponse(int? UltimaParcelaLancada = null, long? IdConta = null, long? IdTipoRegistro = null, int? Ordem = null, long? IdTransacao = null, string Descricao = null, int? Status = null, string DescricaoStatus = null, double? Valor = null, double? ValorDolar = null, int? QuantidadeParcelas = null, double? ValorParcela = null, string DataEvento = null, string Estabelecimento = null, int? FlagCredito = null, string TipoEstabelecimento = null, int? IdGrupoMCC = null, int? FlagSolicitouContestacao = null)
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
            
        }
        
    
        /// <summary>
        /// Gets or Sets UltimaParcelaLancada
        /// </summary>
        [DataMember(Name="ultimaParcelaLancada", EmitDefaultValue=false)]
        public int? UltimaParcelaLancada { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de transacao (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de transacao (id).</value>
        [DataMember(Name="idTipoRegistro", EmitDefaultValue=false)]
        public long? IdTipoRegistro { get; set; }
    
        /// <summary>
        /// Representa\u00C3\u00A7\u00C3\u00A3o da ordena\u00C3\u00A7\u00C3\u00A3o da transacao (id).
        /// </summary>
        /// <value>Representa\u00C3\u00A7\u00C3\u00A3o da ordena\u00C3\u00A7\u00C3\u00A3o da transacao (id).</value>
        [DataMember(Name="ordem", EmitDefaultValue=false)]
        public int? Ordem { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transacao (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transacao (id).</value>
        [DataMember(Name="idTransacao", EmitDefaultValue=false)]
        public long? IdTransacao { get; set; }
    
        /// <summary>
        /// Atributo que representa a descri\u00C3\u00A7\u00C3\u00A3o da transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Atributo que representa a descri\u00C3\u00A7\u00C3\u00A3o da transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Atributo que representa o c\u00C3\u00B3digo identificador do status da transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Atributo que representa o c\u00C3\u00B3digo identificador do status da transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// Atributo que representa a descri\u00C3\u00A7\u00C3\u00A3o do status da transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Atributo que representa a descri\u00C3\u00A7\u00C3\u00A3o do status da transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="descricaoStatus", EmitDefaultValue=false)]
        public string DescricaoStatus { get; set; }
    
        /// <summary>
        /// Atributo que representa o valor da transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Atributo que representa o valor da transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// Atributo que representa o valor em D\u00C3\u00B3lar da transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Atributo que representa o valor em D\u00C3\u00B3lar da transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="valorDolar", EmitDefaultValue=false)]
        public double? ValorDolar { get; set; }
    
        /// <summary>
        /// Atributo que representa a quantidade de parcelas da transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Atributo que representa a quantidade de parcelas da transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="quantidadeParcelas", EmitDefaultValue=false)]
        public int? QuantidadeParcelas { get; set; }
    
        /// <summary>
        /// Atributo que representa o valor da parcela da transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Atributo que representa o valor da parcela da transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public double? ValorParcela { get; set; }
    
        /// <summary>
        /// Atributo que representa a data de envio da transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Atributo que representa a data de envio da transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="dataEvento", EmitDefaultValue=false)]
        public string DataEvento { get; set; }
    
        /// <summary>
        /// Atributo que representa o estabelecimento da transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Atributo que representa o estabelecimento da transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="estabelecimento", EmitDefaultValue=false)]
        public string Estabelecimento { get; set; }
    
        /// <summary>
        /// Atributo que identifica se a transa\u00C3\u00A7\u00C3\u00A3o \u00C3\u00A9 um cr\u00C3\u00A9dito ou d\u00C3\u00A9bito.
        /// </summary>
        /// <value>Atributo que identifica se a transa\u00C3\u00A7\u00C3\u00A3o \u00C3\u00A9 um cr\u00C3\u00A9dito ou d\u00C3\u00A9bito.</value>
        [DataMember(Name="flagCredito", EmitDefaultValue=false)]
        public int? FlagCredito { get; set; }
    
        /// <summary>
        /// Atributo que representa o tipo de estabelecimento da transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Atributo que representa o tipo de estabelecimento da transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="tipoEstabelecimento", EmitDefaultValue=false)]
        public string TipoEstabelecimento { get; set; }
    
        /// <summary>
        /// Atributo que representa o grupo MCC da transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Atributo que representa o grupo MCC da transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="idGrupoMCC", EmitDefaultValue=false)]
        public int? IdGrupoMCC { get; set; }
    
        /// <summary>
        /// Atributo que identifica se o portador solicitou contesta\u00C3\u00A7\u00C3\u00A3o da transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Atributo que identifica se o portador solicitou contesta\u00C3\u00A7\u00C3\u00A3o da transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="flagSolicitouContestacao", EmitDefaultValue=false)]
        public int? FlagSolicitouContestacao { get; set; }
    
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
                
                return hash;
            }
        }

    }
}
