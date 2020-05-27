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
    /// Objeto de retorno de autoriza\u00E7\u00E3o
    /// </summary>
    [DataContract]
    public partial class AutorizacaoResponse :  IEquatable<AutorizacaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AutorizacaoResponse" /> class.
        /// Initializes a new instance of the <see cref="AutorizacaoResponse" />class.
        /// </summary>
        /// <param name="Id">Identificador da autoriza\u00E7\u00E3o.</param>
        /// <param name="CodigoAutorizacao">C\u00F3digo de autoriza\u00E7\u00E3o.</param>
        /// <param name="NsuOrigem">NSU de origem.</param>
        /// <param name="Cartao">N\u00FAmero do cart\u00E3o.</param>
        /// <param name="NumeroEstabelecimento">N\u00FAmero do estabelecimento.</param>
        /// <param name="DataAutorizacao">Data de autoriza\u00E7\u00E3o.</param>
        /// <param name="Origem">Origem da autoriza\u00E7\u00E3o.</param>
        /// <param name="Valor">Valor da autoriza\u00E7\u00E3o.</param>
        /// <param name="NumeroParcelas">N\u00FAmero de parcelas.</param>
        /// <param name="IdOperacao">C\u00F3digo da opera\u00E7\u00E3o.</param>
        /// <param name="Terminal">Terminal de autoriza\u00E7\u00E3o.</param>
        /// <param name="Status">Status da autoriza\u00E7\u00E3o.</param>
        /// <param name="IdEmissor">C\u00F3digo do emissor.</param>
        /// <param name="FlagParticipaPromocao">Flag de participa\u00E7\u00E3o em promo\u00E7\u00E3o.</param>
        /// <param name="ReferenceNumber">N\u00FAmero de refer\u00EAncia.</param>
        /// <param name="IdentificacaoTransacao">Identifica\u00E7\u00E3o de transa\u00E7\u00E3o.</param>
        /// <param name="ModoEntrada">Modo de entrada.</param>
        /// <param name="CodCondicaoPOS">C\u00F3digo de condi\u00E7\u00E3o POD.</param>
        /// <param name="IdCapacidadeDevice">C\u00F3digo de capacidade de dispositivo.</param>
        /// <param name="IdTipoEstabelecimentoPreAutorizacao">C\u00F3digo do estabelecimento de pr\u00E9 autoriza\u00E7\u00E3o.</param>
        /// <param name="IdCartao">C\u00F3digo de cart\u00E3o.</param>
        /// <param name="DataLocal">Data/Local de autoriza\u00E7\u00E3o.</param>
        /// <param name="HoraLocal">Hora/Local de autoriza\u00E7\u00E3o.</param>
        /// <param name="EstabelecimentoAutenticado">Estabelecimento autenticado.</param>

        public AutorizacaoResponse(long? Id = null, string CodigoAutorizacao = null, long? NsuOrigem = null, string Cartao = null, long? NumeroEstabelecimento = null, string DataAutorizacao = null, string Origem = null, double? Valor = null, int? NumeroParcelas = null, long? IdOperacao = null, string Terminal = null, int? Status = null, long? IdEmissor = null, int? FlagParticipaPromocao = null, string ReferenceNumber = null, long? IdentificacaoTransacao = null, string ModoEntrada = null, string CodCondicaoPOS = null, string IdCapacidadeDevice = null, string IdTipoEstabelecimentoPreAutorizacao = null, long? IdCartao = null, string DataLocal = null, string HoraLocal = null, int? EstabelecimentoAutenticado = null)
        {
            this.Id = Id;
            this.CodigoAutorizacao = CodigoAutorizacao;
            this.NsuOrigem = NsuOrigem;
            this.Cartao = Cartao;
            this.NumeroEstabelecimento = NumeroEstabelecimento;
            this.DataAutorizacao = DataAutorizacao;
            this.Origem = Origem;
            this.Valor = Valor;
            this.NumeroParcelas = NumeroParcelas;
            this.IdOperacao = IdOperacao;
            this.Terminal = Terminal;
            this.Status = Status;
            this.IdEmissor = IdEmissor;
            this.FlagParticipaPromocao = FlagParticipaPromocao;
            this.ReferenceNumber = ReferenceNumber;
            this.IdentificacaoTransacao = IdentificacaoTransacao;
            this.ModoEntrada = ModoEntrada;
            this.CodCondicaoPOS = CodCondicaoPOS;
            this.IdCapacidadeDevice = IdCapacidadeDevice;
            this.IdTipoEstabelecimentoPreAutorizacao = IdTipoEstabelecimentoPreAutorizacao;
            this.IdCartao = IdCartao;
            this.DataLocal = DataLocal;
            this.HoraLocal = HoraLocal;
            this.EstabelecimentoAutenticado = EstabelecimentoAutenticado;
            
        }
        
    
        /// <summary>
        /// Identificador da autoriza\u00E7\u00E3o
        /// </summary>
        /// <value>Identificador da autoriza\u00E7\u00E3o</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00F3digo de autoriza\u00E7\u00E3o
        /// </summary>
        /// <value>C\u00F3digo de autoriza\u00E7\u00E3o</value>
        [DataMember(Name="codigoAutorizacao", EmitDefaultValue=false)]
        public string CodigoAutorizacao { get; set; }
    
        /// <summary>
        /// NSU de origem
        /// </summary>
        /// <value>NSU de origem</value>
        [DataMember(Name="nsuOrigem", EmitDefaultValue=false)]
        public long? NsuOrigem { get; set; }
    
        /// <summary>
        /// N\u00FAmero do cart\u00E3o
        /// </summary>
        /// <value>N\u00FAmero do cart\u00E3o</value>
        [DataMember(Name="cartao", EmitDefaultValue=false)]
        public string Cartao { get; set; }
    
        /// <summary>
        /// N\u00FAmero do estabelecimento
        /// </summary>
        /// <value>N\u00FAmero do estabelecimento</value>
        [DataMember(Name="numeroEstabelecimento", EmitDefaultValue=false)]
        public long? NumeroEstabelecimento { get; set; }
    
        /// <summary>
        /// Data de autoriza\u00E7\u00E3o
        /// </summary>
        /// <value>Data de autoriza\u00E7\u00E3o</value>
        [DataMember(Name="dataAutorizacao", EmitDefaultValue=false)]
        public string DataAutorizacao { get; set; }
    
        /// <summary>
        /// Origem da autoriza\u00E7\u00E3o
        /// </summary>
        /// <value>Origem da autoriza\u00E7\u00E3o</value>
        [DataMember(Name="origem", EmitDefaultValue=false)]
        public string Origem { get; set; }
    
        /// <summary>
        /// Valor da autoriza\u00E7\u00E3o
        /// </summary>
        /// <value>Valor da autoriza\u00E7\u00E3o</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// N\u00FAmero de parcelas
        /// </summary>
        /// <value>N\u00FAmero de parcelas</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public int? NumeroParcelas { get; set; }
    
        /// <summary>
        /// C\u00F3digo da opera\u00E7\u00E3o
        /// </summary>
        /// <value>C\u00F3digo da opera\u00E7\u00E3o</value>
        [DataMember(Name="idOperacao", EmitDefaultValue=false)]
        public long? IdOperacao { get; set; }
    
        /// <summary>
        /// Terminal de autoriza\u00E7\u00E3o
        /// </summary>
        /// <value>Terminal de autoriza\u00E7\u00E3o</value>
        [DataMember(Name="terminal", EmitDefaultValue=false)]
        public string Terminal { get; set; }
    
        /// <summary>
        /// Status da autoriza\u00E7\u00E3o
        /// </summary>
        /// <value>Status da autoriza\u00E7\u00E3o</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// C\u00F3digo do emissor
        /// </summary>
        /// <value>C\u00F3digo do emissor</value>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public long? IdEmissor { get; set; }
    
        /// <summary>
        /// Flag de participa\u00E7\u00E3o em promo\u00E7\u00E3o
        /// </summary>
        /// <value>Flag de participa\u00E7\u00E3o em promo\u00E7\u00E3o</value>
        [DataMember(Name="flagParticipaPromocao", EmitDefaultValue=false)]
        public int? FlagParticipaPromocao { get; set; }
    
        /// <summary>
        /// N\u00FAmero de refer\u00EAncia
        /// </summary>
        /// <value>N\u00FAmero de refer\u00EAncia</value>
        [DataMember(Name="referenceNumber", EmitDefaultValue=false)]
        public string ReferenceNumber { get; set; }
    
        /// <summary>
        /// Identifica\u00E7\u00E3o de transa\u00E7\u00E3o
        /// </summary>
        /// <value>Identifica\u00E7\u00E3o de transa\u00E7\u00E3o</value>
        [DataMember(Name="identificacaoTransacao", EmitDefaultValue=false)]
        public long? IdentificacaoTransacao { get; set; }
    
        /// <summary>
        /// Modo de entrada
        /// </summary>
        /// <value>Modo de entrada</value>
        [DataMember(Name="modoEntrada", EmitDefaultValue=false)]
        public string ModoEntrada { get; set; }
    
        /// <summary>
        /// C\u00F3digo de condi\u00E7\u00E3o POD
        /// </summary>
        /// <value>C\u00F3digo de condi\u00E7\u00E3o POD</value>
        [DataMember(Name="codCondicaoPOS", EmitDefaultValue=false)]
        public string CodCondicaoPOS { get; set; }
    
        /// <summary>
        /// C\u00F3digo de capacidade de dispositivo
        /// </summary>
        /// <value>C\u00F3digo de capacidade de dispositivo</value>
        [DataMember(Name="idCapacidadeDevice", EmitDefaultValue=false)]
        public string IdCapacidadeDevice { get; set; }
    
        /// <summary>
        /// C\u00F3digo do estabelecimento de pr\u00E9 autoriza\u00E7\u00E3o
        /// </summary>
        /// <value>C\u00F3digo do estabelecimento de pr\u00E9 autoriza\u00E7\u00E3o</value>
        [DataMember(Name="idTipoEstabelecimentoPreAutorizacao", EmitDefaultValue=false)]
        public string IdTipoEstabelecimentoPreAutorizacao { get; set; }
    
        /// <summary>
        /// C\u00F3digo de cart\u00E3o
        /// </summary>
        /// <value>C\u00F3digo de cart\u00E3o</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Data/Local de autoriza\u00E7\u00E3o
        /// </summary>
        /// <value>Data/Local de autoriza\u00E7\u00E3o</value>
        [DataMember(Name="dataLocal", EmitDefaultValue=false)]
        public string DataLocal { get; set; }
    
        /// <summary>
        /// Hora/Local de autoriza\u00E7\u00E3o
        /// </summary>
        /// <value>Hora/Local de autoriza\u00E7\u00E3o</value>
        [DataMember(Name="horaLocal", EmitDefaultValue=false)]
        public string HoraLocal { get; set; }
    
        /// <summary>
        /// Estabelecimento autenticado
        /// </summary>
        /// <value>Estabelecimento autenticado</value>
        [DataMember(Name="estabelecimentoAutenticado", EmitDefaultValue=false)]
        public int? EstabelecimentoAutenticado { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutorizacaoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CodigoAutorizacao: ").Append(CodigoAutorizacao).Append("\n");
            sb.Append("  NsuOrigem: ").Append(NsuOrigem).Append("\n");
            sb.Append("  Cartao: ").Append(Cartao).Append("\n");
            sb.Append("  NumeroEstabelecimento: ").Append(NumeroEstabelecimento).Append("\n");
            sb.Append("  DataAutorizacao: ").Append(DataAutorizacao).Append("\n");
            sb.Append("  Origem: ").Append(Origem).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  NumeroParcelas: ").Append(NumeroParcelas).Append("\n");
            sb.Append("  IdOperacao: ").Append(IdOperacao).Append("\n");
            sb.Append("  Terminal: ").Append(Terminal).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IdEmissor: ").Append(IdEmissor).Append("\n");
            sb.Append("  FlagParticipaPromocao: ").Append(FlagParticipaPromocao).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  IdentificacaoTransacao: ").Append(IdentificacaoTransacao).Append("\n");
            sb.Append("  ModoEntrada: ").Append(ModoEntrada).Append("\n");
            sb.Append("  CodCondicaoPOS: ").Append(CodCondicaoPOS).Append("\n");
            sb.Append("  IdCapacidadeDevice: ").Append(IdCapacidadeDevice).Append("\n");
            sb.Append("  IdTipoEstabelecimentoPreAutorizacao: ").Append(IdTipoEstabelecimentoPreAutorizacao).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  DataLocal: ").Append(DataLocal).Append("\n");
            sb.Append("  HoraLocal: ").Append(HoraLocal).Append("\n");
            sb.Append("  EstabelecimentoAutenticado: ").Append(EstabelecimentoAutenticado).Append("\n");
            
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
            return this.Equals(obj as AutorizacaoResponse);
        }

        /// <summary>
        /// Returns true if AutorizacaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AutorizacaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutorizacaoResponse other)
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
                    this.CodigoAutorizacao == other.CodigoAutorizacao ||
                    this.CodigoAutorizacao != null &&
                    this.CodigoAutorizacao.Equals(other.CodigoAutorizacao)
                ) && 
                (
                    this.NsuOrigem == other.NsuOrigem ||
                    this.NsuOrigem != null &&
                    this.NsuOrigem.Equals(other.NsuOrigem)
                ) && 
                (
                    this.Cartao == other.Cartao ||
                    this.Cartao != null &&
                    this.Cartao.Equals(other.Cartao)
                ) && 
                (
                    this.NumeroEstabelecimento == other.NumeroEstabelecimento ||
                    this.NumeroEstabelecimento != null &&
                    this.NumeroEstabelecimento.Equals(other.NumeroEstabelecimento)
                ) && 
                (
                    this.DataAutorizacao == other.DataAutorizacao ||
                    this.DataAutorizacao != null &&
                    this.DataAutorizacao.Equals(other.DataAutorizacao)
                ) && 
                (
                    this.Origem == other.Origem ||
                    this.Origem != null &&
                    this.Origem.Equals(other.Origem)
                ) && 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
                ) && 
                (
                    this.NumeroParcelas == other.NumeroParcelas ||
                    this.NumeroParcelas != null &&
                    this.NumeroParcelas.Equals(other.NumeroParcelas)
                ) && 
                (
                    this.IdOperacao == other.IdOperacao ||
                    this.IdOperacao != null &&
                    this.IdOperacao.Equals(other.IdOperacao)
                ) && 
                (
                    this.Terminal == other.Terminal ||
                    this.Terminal != null &&
                    this.Terminal.Equals(other.Terminal)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.IdEmissor == other.IdEmissor ||
                    this.IdEmissor != null &&
                    this.IdEmissor.Equals(other.IdEmissor)
                ) && 
                (
                    this.FlagParticipaPromocao == other.FlagParticipaPromocao ||
                    this.FlagParticipaPromocao != null &&
                    this.FlagParticipaPromocao.Equals(other.FlagParticipaPromocao)
                ) && 
                (
                    this.ReferenceNumber == other.ReferenceNumber ||
                    this.ReferenceNumber != null &&
                    this.ReferenceNumber.Equals(other.ReferenceNumber)
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
                    this.CodCondicaoPOS == other.CodCondicaoPOS ||
                    this.CodCondicaoPOS != null &&
                    this.CodCondicaoPOS.Equals(other.CodCondicaoPOS)
                ) && 
                (
                    this.IdCapacidadeDevice == other.IdCapacidadeDevice ||
                    this.IdCapacidadeDevice != null &&
                    this.IdCapacidadeDevice.Equals(other.IdCapacidadeDevice)
                ) && 
                (
                    this.IdTipoEstabelecimentoPreAutorizacao == other.IdTipoEstabelecimentoPreAutorizacao ||
                    this.IdTipoEstabelecimentoPreAutorizacao != null &&
                    this.IdTipoEstabelecimentoPreAutorizacao.Equals(other.IdTipoEstabelecimentoPreAutorizacao)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.DataLocal == other.DataLocal ||
                    this.DataLocal != null &&
                    this.DataLocal.Equals(other.DataLocal)
                ) && 
                (
                    this.HoraLocal == other.HoraLocal ||
                    this.HoraLocal != null &&
                    this.HoraLocal.Equals(other.HoraLocal)
                ) && 
                (
                    this.EstabelecimentoAutenticado == other.EstabelecimentoAutenticado ||
                    this.EstabelecimentoAutenticado != null &&
                    this.EstabelecimentoAutenticado.Equals(other.EstabelecimentoAutenticado)
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
                
                if (this.CodigoAutorizacao != null)
                    hash = hash * 59 + this.CodigoAutorizacao.GetHashCode();
                
                if (this.NsuOrigem != null)
                    hash = hash * 59 + this.NsuOrigem.GetHashCode();
                
                if (this.Cartao != null)
                    hash = hash * 59 + this.Cartao.GetHashCode();
                
                if (this.NumeroEstabelecimento != null)
                    hash = hash * 59 + this.NumeroEstabelecimento.GetHashCode();
                
                if (this.DataAutorizacao != null)
                    hash = hash * 59 + this.DataAutorizacao.GetHashCode();
                
                if (this.Origem != null)
                    hash = hash * 59 + this.Origem.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                if (this.NumeroParcelas != null)
                    hash = hash * 59 + this.NumeroParcelas.GetHashCode();
                
                if (this.IdOperacao != null)
                    hash = hash * 59 + this.IdOperacao.GetHashCode();
                
                if (this.Terminal != null)
                    hash = hash * 59 + this.Terminal.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.IdEmissor != null)
                    hash = hash * 59 + this.IdEmissor.GetHashCode();
                
                if (this.FlagParticipaPromocao != null)
                    hash = hash * 59 + this.FlagParticipaPromocao.GetHashCode();
                
                if (this.ReferenceNumber != null)
                    hash = hash * 59 + this.ReferenceNumber.GetHashCode();
                
                if (this.IdentificacaoTransacao != null)
                    hash = hash * 59 + this.IdentificacaoTransacao.GetHashCode();
                
                if (this.ModoEntrada != null)
                    hash = hash * 59 + this.ModoEntrada.GetHashCode();
                
                if (this.CodCondicaoPOS != null)
                    hash = hash * 59 + this.CodCondicaoPOS.GetHashCode();
                
                if (this.IdCapacidadeDevice != null)
                    hash = hash * 59 + this.IdCapacidadeDevice.GetHashCode();
                
                if (this.IdTipoEstabelecimentoPreAutorizacao != null)
                    hash = hash * 59 + this.IdTipoEstabelecimentoPreAutorizacao.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.DataLocal != null)
                    hash = hash * 59 + this.DataLocal.GetHashCode();
                
                if (this.HoraLocal != null)
                    hash = hash * 59 + this.HoraLocal.GetHashCode();
                
                if (this.EstabelecimentoAutenticado != null)
                    hash = hash * 59 + this.EstabelecimentoAutenticado.GetHashCode();
                
                return hash;
            }
        }

    }
}
