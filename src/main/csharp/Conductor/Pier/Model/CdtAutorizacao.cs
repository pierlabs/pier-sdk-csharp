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
    public partial class CdtAutorizacao :  IEquatable<CdtAutorizacao>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CdtAutorizacao" /> class.
        /// Initializes a new instance of the <see cref="CdtAutorizacao" />class.
        /// </summary>
        /// <param name="Cartao">Cartao.</param>
        /// <param name="CodCondicaoPOS">CodCondicaoPOS.</param>
        /// <param name="CodigoAutorizacao">CodigoAutorizacao.</param>
        /// <param name="DataAutorizacao">DataAutorizacao.</param>
        /// <param name="DataLocal">DataLocal.</param>
        /// <param name="EstabelecimentoAutenticado">EstabelecimentoAutenticado.</param>
        /// <param name="FlagParticipaPromocao">FlagParticipaPromocao.</param>
        /// <param name="HoraLocal">HoraLocal.</param>
        /// <param name="Id">Id.</param>
        /// <param name="IdCapacidadeDevice">IdCapacidadeDevice.</param>
        /// <param name="IdCartao">IdCartao.</param>
        /// <param name="IdEmissor">IdEmissor.</param>
        /// <param name="IdOperacao">IdOperacao.</param>
        /// <param name="IdTipoEstabelecimentoPreAutorizacao">IdTipoEstabelecimentoPreAutorizacao.</param>
        /// <param name="IdentificacaoTransacao">IdentificacaoTransacao.</param>
        /// <param name="ModoEntrada">ModoEntrada.</param>
        /// <param name="NsuOrigem">NsuOrigem.</param>
        /// <param name="NumeroEstabelecimento">NumeroEstabelecimento.</param>
        /// <param name="NumeroParcelas">NumeroParcelas.</param>
        /// <param name="Origem">Origem.</param>
        /// <param name="ReferenceNumber">ReferenceNumber.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Terminal">Terminal.</param>
        /// <param name="Valor">Valor.</param>

        public CdtAutorizacao(string Cartao = null, string CodCondicaoPOS = null, string CodigoAutorizacao = null, string DataAutorizacao = null, string DataLocal = null, int? EstabelecimentoAutenticado = null, int? FlagParticipaPromocao = null, string HoraLocal = null, long? Id = null, string IdCapacidadeDevice = null, long? IdCartao = null, long? IdEmissor = null, long? IdOperacao = null, string IdTipoEstabelecimentoPreAutorizacao = null, long? IdentificacaoTransacao = null, string ModoEntrada = null, long? NsuOrigem = null, long? NumeroEstabelecimento = null, int? NumeroParcelas = null, string Origem = null, string ReferenceNumber = null, int? Status = null, string Terminal = null, double? Valor = null)
        {
            this.Cartao = Cartao;
            this.CodCondicaoPOS = CodCondicaoPOS;
            this.CodigoAutorizacao = CodigoAutorizacao;
            this.DataAutorizacao = DataAutorizacao;
            this.DataLocal = DataLocal;
            this.EstabelecimentoAutenticado = EstabelecimentoAutenticado;
            this.FlagParticipaPromocao = FlagParticipaPromocao;
            this.HoraLocal = HoraLocal;
            this.Id = Id;
            this.IdCapacidadeDevice = IdCapacidadeDevice;
            this.IdCartao = IdCartao;
            this.IdEmissor = IdEmissor;
            this.IdOperacao = IdOperacao;
            this.IdTipoEstabelecimentoPreAutorizacao = IdTipoEstabelecimentoPreAutorizacao;
            this.IdentificacaoTransacao = IdentificacaoTransacao;
            this.ModoEntrada = ModoEntrada;
            this.NsuOrigem = NsuOrigem;
            this.NumeroEstabelecimento = NumeroEstabelecimento;
            this.NumeroParcelas = NumeroParcelas;
            this.Origem = Origem;
            this.ReferenceNumber = ReferenceNumber;
            this.Status = Status;
            this.Terminal = Terminal;
            this.Valor = Valor;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Cartao
        /// </summary>
        [DataMember(Name="cartao", EmitDefaultValue=false)]
        public string Cartao { get; set; }
    
        /// <summary>
        /// Gets or Sets CodCondicaoPOS
        /// </summary>
        [DataMember(Name="codCondicaoPOS", EmitDefaultValue=false)]
        public string CodCondicaoPOS { get; set; }
    
        /// <summary>
        /// Gets or Sets CodigoAutorizacao
        /// </summary>
        [DataMember(Name="codigoAutorizacao", EmitDefaultValue=false)]
        public string CodigoAutorizacao { get; set; }
    
        /// <summary>
        /// Gets or Sets DataAutorizacao
        /// </summary>
        [DataMember(Name="dataAutorizacao", EmitDefaultValue=false)]
        public string DataAutorizacao { get; set; }
    
        /// <summary>
        /// Gets or Sets DataLocal
        /// </summary>
        [DataMember(Name="dataLocal", EmitDefaultValue=false)]
        public string DataLocal { get; set; }
    
        /// <summary>
        /// Gets or Sets EstabelecimentoAutenticado
        /// </summary>
        [DataMember(Name="estabelecimentoAutenticado", EmitDefaultValue=false)]
        public int? EstabelecimentoAutenticado { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagParticipaPromocao
        /// </summary>
        [DataMember(Name="flagParticipaPromocao", EmitDefaultValue=false)]
        public int? FlagParticipaPromocao { get; set; }
    
        /// <summary>
        /// Gets or Sets HoraLocal
        /// </summary>
        [DataMember(Name="horaLocal", EmitDefaultValue=false)]
        public string HoraLocal { get; set; }
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Gets or Sets IdCapacidadeDevice
        /// </summary>
        [DataMember(Name="idCapacidadeDevice", EmitDefaultValue=false)]
        public string IdCapacidadeDevice { get; set; }
    
        /// <summary>
        /// Gets or Sets IdCartao
        /// </summary>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Gets or Sets IdEmissor
        /// </summary>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public long? IdEmissor { get; set; }
    
        /// <summary>
        /// Gets or Sets IdOperacao
        /// </summary>
        [DataMember(Name="idOperacao", EmitDefaultValue=false)]
        public long? IdOperacao { get; set; }
    
        /// <summary>
        /// Gets or Sets IdTipoEstabelecimentoPreAutorizacao
        /// </summary>
        [DataMember(Name="idTipoEstabelecimentoPreAutorizacao", EmitDefaultValue=false)]
        public string IdTipoEstabelecimentoPreAutorizacao { get; set; }
    
        /// <summary>
        /// Gets or Sets IdentificacaoTransacao
        /// </summary>
        [DataMember(Name="identificacaoTransacao", EmitDefaultValue=false)]
        public long? IdentificacaoTransacao { get; set; }
    
        /// <summary>
        /// Gets or Sets ModoEntrada
        /// </summary>
        [DataMember(Name="modoEntrada", EmitDefaultValue=false)]
        public string ModoEntrada { get; set; }
    
        /// <summary>
        /// Gets or Sets NsuOrigem
        /// </summary>
        [DataMember(Name="nsuOrigem", EmitDefaultValue=false)]
        public long? NsuOrigem { get; set; }
    
        /// <summary>
        /// Gets or Sets NumeroEstabelecimento
        /// </summary>
        [DataMember(Name="numeroEstabelecimento", EmitDefaultValue=false)]
        public long? NumeroEstabelecimento { get; set; }
    
        /// <summary>
        /// Gets or Sets NumeroParcelas
        /// </summary>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public int? NumeroParcelas { get; set; }
    
        /// <summary>
        /// Gets or Sets Origem
        /// </summary>
        [DataMember(Name="origem", EmitDefaultValue=false)]
        public string Origem { get; set; }
    
        /// <summary>
        /// Gets or Sets ReferenceNumber
        /// </summary>
        [DataMember(Name="referenceNumber", EmitDefaultValue=false)]
        public string ReferenceNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// Gets or Sets Terminal
        /// </summary>
        [DataMember(Name="terminal", EmitDefaultValue=false)]
        public string Terminal { get; set; }
    
        /// <summary>
        /// Gets or Sets Valor
        /// </summary>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CdtAutorizacao {\n");
            sb.Append("  Cartao: ").Append(Cartao).Append("\n");
            sb.Append("  CodCondicaoPOS: ").Append(CodCondicaoPOS).Append("\n");
            sb.Append("  CodigoAutorizacao: ").Append(CodigoAutorizacao).Append("\n");
            sb.Append("  DataAutorizacao: ").Append(DataAutorizacao).Append("\n");
            sb.Append("  DataLocal: ").Append(DataLocal).Append("\n");
            sb.Append("  EstabelecimentoAutenticado: ").Append(EstabelecimentoAutenticado).Append("\n");
            sb.Append("  FlagParticipaPromocao: ").Append(FlagParticipaPromocao).Append("\n");
            sb.Append("  HoraLocal: ").Append(HoraLocal).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdCapacidadeDevice: ").Append(IdCapacidadeDevice).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdEmissor: ").Append(IdEmissor).Append("\n");
            sb.Append("  IdOperacao: ").Append(IdOperacao).Append("\n");
            sb.Append("  IdTipoEstabelecimentoPreAutorizacao: ").Append(IdTipoEstabelecimentoPreAutorizacao).Append("\n");
            sb.Append("  IdentificacaoTransacao: ").Append(IdentificacaoTransacao).Append("\n");
            sb.Append("  ModoEntrada: ").Append(ModoEntrada).Append("\n");
            sb.Append("  NsuOrigem: ").Append(NsuOrigem).Append("\n");
            sb.Append("  NumeroEstabelecimento: ").Append(NumeroEstabelecimento).Append("\n");
            sb.Append("  NumeroParcelas: ").Append(NumeroParcelas).Append("\n");
            sb.Append("  Origem: ").Append(Origem).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Terminal: ").Append(Terminal).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            
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
            return this.Equals(obj as CdtAutorizacao);
        }

        /// <summary>
        /// Returns true if CdtAutorizacao instances are equal
        /// </summary>
        /// <param name="other">Instance of CdtAutorizacao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CdtAutorizacao other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Cartao == other.Cartao ||
                    this.Cartao != null &&
                    this.Cartao.Equals(other.Cartao)
                ) && 
                (
                    this.CodCondicaoPOS == other.CodCondicaoPOS ||
                    this.CodCondicaoPOS != null &&
                    this.CodCondicaoPOS.Equals(other.CodCondicaoPOS)
                ) && 
                (
                    this.CodigoAutorizacao == other.CodigoAutorizacao ||
                    this.CodigoAutorizacao != null &&
                    this.CodigoAutorizacao.Equals(other.CodigoAutorizacao)
                ) && 
                (
                    this.DataAutorizacao == other.DataAutorizacao ||
                    this.DataAutorizacao != null &&
                    this.DataAutorizacao.Equals(other.DataAutorizacao)
                ) && 
                (
                    this.DataLocal == other.DataLocal ||
                    this.DataLocal != null &&
                    this.DataLocal.Equals(other.DataLocal)
                ) && 
                (
                    this.EstabelecimentoAutenticado == other.EstabelecimentoAutenticado ||
                    this.EstabelecimentoAutenticado != null &&
                    this.EstabelecimentoAutenticado.Equals(other.EstabelecimentoAutenticado)
                ) && 
                (
                    this.FlagParticipaPromocao == other.FlagParticipaPromocao ||
                    this.FlagParticipaPromocao != null &&
                    this.FlagParticipaPromocao.Equals(other.FlagParticipaPromocao)
                ) && 
                (
                    this.HoraLocal == other.HoraLocal ||
                    this.HoraLocal != null &&
                    this.HoraLocal.Equals(other.HoraLocal)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdCapacidadeDevice == other.IdCapacidadeDevice ||
                    this.IdCapacidadeDevice != null &&
                    this.IdCapacidadeDevice.Equals(other.IdCapacidadeDevice)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.IdEmissor == other.IdEmissor ||
                    this.IdEmissor != null &&
                    this.IdEmissor.Equals(other.IdEmissor)
                ) && 
                (
                    this.IdOperacao == other.IdOperacao ||
                    this.IdOperacao != null &&
                    this.IdOperacao.Equals(other.IdOperacao)
                ) && 
                (
                    this.IdTipoEstabelecimentoPreAutorizacao == other.IdTipoEstabelecimentoPreAutorizacao ||
                    this.IdTipoEstabelecimentoPreAutorizacao != null &&
                    this.IdTipoEstabelecimentoPreAutorizacao.Equals(other.IdTipoEstabelecimentoPreAutorizacao)
                ) && 
                (
                    this.IdentificacaoTransacao == other.IdentificacaoTransacao ||
                    this.IdentificacaoTransacao != null &&
                    this.IdentificacaoTransacao.Equals(other.IdentificacaoTransacao)
                ) && 
                (
                    this.ModoEntrada == other.ModoEntrada ||
                    this.ModoEntrada != null &&
                    this.ModoEntrada.Equals(other.ModoEntrada)
                ) && 
                (
                    this.NsuOrigem == other.NsuOrigem ||
                    this.NsuOrigem != null &&
                    this.NsuOrigem.Equals(other.NsuOrigem)
                ) && 
                (
                    this.NumeroEstabelecimento == other.NumeroEstabelecimento ||
                    this.NumeroEstabelecimento != null &&
                    this.NumeroEstabelecimento.Equals(other.NumeroEstabelecimento)
                ) && 
                (
                    this.NumeroParcelas == other.NumeroParcelas ||
                    this.NumeroParcelas != null &&
                    this.NumeroParcelas.Equals(other.NumeroParcelas)
                ) && 
                (
                    this.Origem == other.Origem ||
                    this.Origem != null &&
                    this.Origem.Equals(other.Origem)
                ) && 
                (
                    this.ReferenceNumber == other.ReferenceNumber ||
                    this.ReferenceNumber != null &&
                    this.ReferenceNumber.Equals(other.ReferenceNumber)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Terminal == other.Terminal ||
                    this.Terminal != null &&
                    this.Terminal.Equals(other.Terminal)
                ) && 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
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
                
                if (this.Cartao != null)
                    hash = hash * 59 + this.Cartao.GetHashCode();
                
                if (this.CodCondicaoPOS != null)
                    hash = hash * 59 + this.CodCondicaoPOS.GetHashCode();
                
                if (this.CodigoAutorizacao != null)
                    hash = hash * 59 + this.CodigoAutorizacao.GetHashCode();
                
                if (this.DataAutorizacao != null)
                    hash = hash * 59 + this.DataAutorizacao.GetHashCode();
                
                if (this.DataLocal != null)
                    hash = hash * 59 + this.DataLocal.GetHashCode();
                
                if (this.EstabelecimentoAutenticado != null)
                    hash = hash * 59 + this.EstabelecimentoAutenticado.GetHashCode();
                
                if (this.FlagParticipaPromocao != null)
                    hash = hash * 59 + this.FlagParticipaPromocao.GetHashCode();
                
                if (this.HoraLocal != null)
                    hash = hash * 59 + this.HoraLocal.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdCapacidadeDevice != null)
                    hash = hash * 59 + this.IdCapacidadeDevice.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.IdEmissor != null)
                    hash = hash * 59 + this.IdEmissor.GetHashCode();
                
                if (this.IdOperacao != null)
                    hash = hash * 59 + this.IdOperacao.GetHashCode();
                
                if (this.IdTipoEstabelecimentoPreAutorizacao != null)
                    hash = hash * 59 + this.IdTipoEstabelecimentoPreAutorizacao.GetHashCode();
                
                if (this.IdentificacaoTransacao != null)
                    hash = hash * 59 + this.IdentificacaoTransacao.GetHashCode();
                
                if (this.ModoEntrada != null)
                    hash = hash * 59 + this.ModoEntrada.GetHashCode();
                
                if (this.NsuOrigem != null)
                    hash = hash * 59 + this.NsuOrigem.GetHashCode();
                
                if (this.NumeroEstabelecimento != null)
                    hash = hash * 59 + this.NumeroEstabelecimento.GetHashCode();
                
                if (this.NumeroParcelas != null)
                    hash = hash * 59 + this.NumeroParcelas.GetHashCode();
                
                if (this.Origem != null)
                    hash = hash * 59 + this.Origem.GetHashCode();
                
                if (this.ReferenceNumber != null)
                    hash = hash * 59 + this.ReferenceNumber.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Terminal != null)
                    hash = hash * 59 + this.Terminal.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                return hash;
            }
        }

    }
}
