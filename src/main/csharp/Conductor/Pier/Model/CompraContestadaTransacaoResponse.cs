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
    /// {{{codigo_chargeback_response_description}}}
    /// </summary>
    [DataContract]
    public partial class CompraContestadaTransacaoResponse :  IEquatable<CompraContestadaTransacaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CompraContestadaTransacaoResponse" /> class.
        /// Initializes a new instance of the <see cref="CompraContestadaTransacaoResponse" />class.
        /// </summary>
        /// <param name="AgingCompras">AgingCompras.</param>
        /// <param name="AgingContestacao">AgingContestacao.</param>
        /// <param name="Bandeira">Bandeira.</param>
        /// <param name="CodigoAutorizacao">CodigoAutorizacao.</param>
        /// <param name="CodigoContestacao">CodigoContestacao.</param>
        /// <param name="CodigoEventoCompra">CodigoEventoCompra.</param>
        /// <param name="CodigoMoedaDestino">CodigoMoedaDestino.</param>
        /// <param name="Data2Reapresentacao">Data2Reapresentacao.</param>
        /// <param name="DataAlteracao">DataAlteracao.</param>
        /// <param name="DataContestacao">DataContestacao.</param>
        /// <param name="DataEnvioCB">DataEnvioCB.</param>
        /// <param name="DataTransacao">DataTransacao.</param>
        /// <param name="IdCompraContestada">IdCompraContestada.</param>
        /// <param name="Internacional">Internacional.</param>
        /// <param name="Mcc">Mcc.</param>
        /// <param name="ModoDeEntradaDescricao">ModoDeEntradaDescricao.</param>
        /// <param name="ModoEntrada">ModoEntrada.</param>
        /// <param name="Motivo2Reapresentacao">Motivo2Reapresentacao.</param>
        /// <param name="NomeEstabelecimento">NomeEstabelecimento.</param>
        /// <param name="NumeroControle">NumeroControle.</param>
        /// <param name="RazaoCB">RazaoCB.</param>
        /// <param name="ReferenceNumber">ReferenceNumber.</param>
        /// <param name="ReporteBandeira">ReporteBandeira.</param>
        /// <param name="ResponsavelAbertuda">ResponsavelAbertuda.</param>
        /// <param name="ResponsavelAlteracao">ResponsavelAlteracao.</param>
        /// <param name="StatusContestacao">StatusContestacao.</param>
        /// <param name="Texto2Reapresentacao">Texto2Reapresentacao.</param>
        /// <param name="TipoTransacao">TipoTransacao.</param>
        /// <param name="TransacaoSegura">TransacaoSegura.</param>
        /// <param name="ValorCompra">ValorCompra.</param>
        /// <param name="ValorContrato">ValorContrato.</param>
        /// <param name="ValorDestino">ValorDestino.</param>

        public CompraContestadaTransacaoResponse(long? AgingCompras = null, long? AgingContestacao = null, string Bandeira = null, string CodigoAutorizacao = null, string CodigoContestacao = null, string CodigoEventoCompra = null, string CodigoMoedaDestino = null, string Data2Reapresentacao = null, DateTime? DataAlteracao = null, DateTime? DataContestacao = null, string DataEnvioCB = null, DateTime? DataTransacao = null, long? IdCompraContestada = null, int? Internacional = null, string Mcc = null, string ModoDeEntradaDescricao = null, string ModoEntrada = null, string Motivo2Reapresentacao = null, string NomeEstabelecimento = null, string NumeroControle = null, string RazaoCB = null, string ReferenceNumber = null, string ReporteBandeira = null, string ResponsavelAbertuda = null, string ResponsavelAlteracao = null, string StatusContestacao = null, string Texto2Reapresentacao = null, string TipoTransacao = null, string TransacaoSegura = null, double? ValorCompra = null, double? ValorContrato = null, double? ValorDestino = null)
        {
            this.AgingCompras = AgingCompras;
            this.AgingContestacao = AgingContestacao;
            this.Bandeira = Bandeira;
            this.CodigoAutorizacao = CodigoAutorizacao;
            this.CodigoContestacao = CodigoContestacao;
            this.CodigoEventoCompra = CodigoEventoCompra;
            this.CodigoMoedaDestino = CodigoMoedaDestino;
            this.Data2Reapresentacao = Data2Reapresentacao;
            this.DataAlteracao = DataAlteracao;
            this.DataContestacao = DataContestacao;
            this.DataEnvioCB = DataEnvioCB;
            this.DataTransacao = DataTransacao;
            this.IdCompraContestada = IdCompraContestada;
            this.Internacional = Internacional;
            this.Mcc = Mcc;
            this.ModoDeEntradaDescricao = ModoDeEntradaDescricao;
            this.ModoEntrada = ModoEntrada;
            this.Motivo2Reapresentacao = Motivo2Reapresentacao;
            this.NomeEstabelecimento = NomeEstabelecimento;
            this.NumeroControle = NumeroControle;
            this.RazaoCB = RazaoCB;
            this.ReferenceNumber = ReferenceNumber;
            this.ReporteBandeira = ReporteBandeira;
            this.ResponsavelAbertuda = ResponsavelAbertuda;
            this.ResponsavelAlteracao = ResponsavelAlteracao;
            this.StatusContestacao = StatusContestacao;
            this.Texto2Reapresentacao = Texto2Reapresentacao;
            this.TipoTransacao = TipoTransacao;
            this.TransacaoSegura = TransacaoSegura;
            this.ValorCompra = ValorCompra;
            this.ValorContrato = ValorContrato;
            this.ValorDestino = ValorDestino;
            
        }
        
    
        /// <summary>
        /// Gets or Sets AgingCompras
        /// </summary>
        [DataMember(Name="agingCompras", EmitDefaultValue=false)]
        public long? AgingCompras { get; set; }
    
        /// <summary>
        /// Gets or Sets AgingContestacao
        /// </summary>
        [DataMember(Name="agingContestacao", EmitDefaultValue=false)]
        public long? AgingContestacao { get; set; }
    
        /// <summary>
        /// Gets or Sets Bandeira
        /// </summary>
        [DataMember(Name="bandeira", EmitDefaultValue=false)]
        public string Bandeira { get; set; }
    
        /// <summary>
        /// Gets or Sets CodigoAutorizacao
        /// </summary>
        [DataMember(Name="codigoAutorizacao", EmitDefaultValue=false)]
        public string CodigoAutorizacao { get; set; }
    
        /// <summary>
        /// Gets or Sets CodigoContestacao
        /// </summary>
        [DataMember(Name="codigoContestacao", EmitDefaultValue=false)]
        public string CodigoContestacao { get; set; }
    
        /// <summary>
        /// Gets or Sets CodigoEventoCompra
        /// </summary>
        [DataMember(Name="codigoEventoCompra", EmitDefaultValue=false)]
        public string CodigoEventoCompra { get; set; }
    
        /// <summary>
        /// Gets or Sets CodigoMoedaDestino
        /// </summary>
        [DataMember(Name="codigoMoedaDestino", EmitDefaultValue=false)]
        public string CodigoMoedaDestino { get; set; }
    
        /// <summary>
        /// Gets or Sets Data2Reapresentacao
        /// </summary>
        [DataMember(Name="data2Reapresentacao", EmitDefaultValue=false)]
        public string Data2Reapresentacao { get; set; }
    
        /// <summary>
        /// Gets or Sets DataAlteracao
        /// </summary>
        [DataMember(Name="dataAlteracao", EmitDefaultValue=false)]
        public DateTime? DataAlteracao { get; set; }
    
        /// <summary>
        /// Gets or Sets DataContestacao
        /// </summary>
        [DataMember(Name="dataContestacao", EmitDefaultValue=false)]
        public DateTime? DataContestacao { get; set; }
    
        /// <summary>
        /// Gets or Sets DataEnvioCB
        /// </summary>
        [DataMember(Name="dataEnvioCB", EmitDefaultValue=false)]
        public string DataEnvioCB { get; set; }
    
        /// <summary>
        /// Gets or Sets DataTransacao
        /// </summary>
        [DataMember(Name="dataTransacao", EmitDefaultValue=false)]
        public DateTime? DataTransacao { get; set; }
    
        /// <summary>
        /// Gets or Sets IdCompraContestada
        /// </summary>
        [DataMember(Name="idCompraContestada", EmitDefaultValue=false)]
        public long? IdCompraContestada { get; set; }
    
        /// <summary>
        /// Gets or Sets Internacional
        /// </summary>
        [DataMember(Name="internacional", EmitDefaultValue=false)]
        public int? Internacional { get; set; }
    
        /// <summary>
        /// Gets or Sets Mcc
        /// </summary>
        [DataMember(Name="mcc", EmitDefaultValue=false)]
        public string Mcc { get; set; }
    
        /// <summary>
        /// Gets or Sets ModoDeEntradaDescricao
        /// </summary>
        [DataMember(Name="modoDeEntradaDescricao", EmitDefaultValue=false)]
        public string ModoDeEntradaDescricao { get; set; }
    
        /// <summary>
        /// Gets or Sets ModoEntrada
        /// </summary>
        [DataMember(Name="modoEntrada", EmitDefaultValue=false)]
        public string ModoEntrada { get; set; }
    
        /// <summary>
        /// Gets or Sets Motivo2Reapresentacao
        /// </summary>
        [DataMember(Name="motivo2Reapresentacao", EmitDefaultValue=false)]
        public string Motivo2Reapresentacao { get; set; }
    
        /// <summary>
        /// Gets or Sets NomeEstabelecimento
        /// </summary>
        [DataMember(Name="nomeEstabelecimento", EmitDefaultValue=false)]
        public string NomeEstabelecimento { get; set; }
    
        /// <summary>
        /// Gets or Sets NumeroControle
        /// </summary>
        [DataMember(Name="numeroControle", EmitDefaultValue=false)]
        public string NumeroControle { get; set; }
    
        /// <summary>
        /// Gets or Sets RazaoCB
        /// </summary>
        [DataMember(Name="razaoCB", EmitDefaultValue=false)]
        public string RazaoCB { get; set; }
    
        /// <summary>
        /// Gets or Sets ReferenceNumber
        /// </summary>
        [DataMember(Name="referenceNumber", EmitDefaultValue=false)]
        public string ReferenceNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets ReporteBandeira
        /// </summary>
        [DataMember(Name="reporteBandeira", EmitDefaultValue=false)]
        public string ReporteBandeira { get; set; }
    
        /// <summary>
        /// Gets or Sets ResponsavelAbertuda
        /// </summary>
        [DataMember(Name="responsavelAbertuda", EmitDefaultValue=false)]
        public string ResponsavelAbertuda { get; set; }
    
        /// <summary>
        /// Gets or Sets ResponsavelAlteracao
        /// </summary>
        [DataMember(Name="responsavelAlteracao", EmitDefaultValue=false)]
        public string ResponsavelAlteracao { get; set; }
    
        /// <summary>
        /// Gets or Sets StatusContestacao
        /// </summary>
        [DataMember(Name="statusContestacao", EmitDefaultValue=false)]
        public string StatusContestacao { get; set; }
    
        /// <summary>
        /// Gets or Sets Texto2Reapresentacao
        /// </summary>
        [DataMember(Name="texto2Reapresentacao", EmitDefaultValue=false)]
        public string Texto2Reapresentacao { get; set; }
    
        /// <summary>
        /// Gets or Sets TipoTransacao
        /// </summary>
        [DataMember(Name="tipoTransacao", EmitDefaultValue=false)]
        public string TipoTransacao { get; set; }
    
        /// <summary>
        /// Gets or Sets TransacaoSegura
        /// </summary>
        [DataMember(Name="transacaoSegura", EmitDefaultValue=false)]
        public string TransacaoSegura { get; set; }
    
        /// <summary>
        /// Gets or Sets ValorCompra
        /// </summary>
        [DataMember(Name="valorCompra", EmitDefaultValue=false)]
        public double? ValorCompra { get; set; }
    
        /// <summary>
        /// Gets or Sets ValorContrato
        /// </summary>
        [DataMember(Name="valorContrato", EmitDefaultValue=false)]
        public double? ValorContrato { get; set; }
    
        /// <summary>
        /// Gets or Sets ValorDestino
        /// </summary>
        [DataMember(Name="valorDestino", EmitDefaultValue=false)]
        public double? ValorDestino { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompraContestadaTransacaoResponse {\n");
            sb.Append("  AgingCompras: ").Append(AgingCompras).Append("\n");
            sb.Append("  AgingContestacao: ").Append(AgingContestacao).Append("\n");
            sb.Append("  Bandeira: ").Append(Bandeira).Append("\n");
            sb.Append("  CodigoAutorizacao: ").Append(CodigoAutorizacao).Append("\n");
            sb.Append("  CodigoContestacao: ").Append(CodigoContestacao).Append("\n");
            sb.Append("  CodigoEventoCompra: ").Append(CodigoEventoCompra).Append("\n");
            sb.Append("  CodigoMoedaDestino: ").Append(CodigoMoedaDestino).Append("\n");
            sb.Append("  Data2Reapresentacao: ").Append(Data2Reapresentacao).Append("\n");
            sb.Append("  DataAlteracao: ").Append(DataAlteracao).Append("\n");
            sb.Append("  DataContestacao: ").Append(DataContestacao).Append("\n");
            sb.Append("  DataEnvioCB: ").Append(DataEnvioCB).Append("\n");
            sb.Append("  DataTransacao: ").Append(DataTransacao).Append("\n");
            sb.Append("  IdCompraContestada: ").Append(IdCompraContestada).Append("\n");
            sb.Append("  Internacional: ").Append(Internacional).Append("\n");
            sb.Append("  Mcc: ").Append(Mcc).Append("\n");
            sb.Append("  ModoDeEntradaDescricao: ").Append(ModoDeEntradaDescricao).Append("\n");
            sb.Append("  ModoEntrada: ").Append(ModoEntrada).Append("\n");
            sb.Append("  Motivo2Reapresentacao: ").Append(Motivo2Reapresentacao).Append("\n");
            sb.Append("  NomeEstabelecimento: ").Append(NomeEstabelecimento).Append("\n");
            sb.Append("  NumeroControle: ").Append(NumeroControle).Append("\n");
            sb.Append("  RazaoCB: ").Append(RazaoCB).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  ReporteBandeira: ").Append(ReporteBandeira).Append("\n");
            sb.Append("  ResponsavelAbertuda: ").Append(ResponsavelAbertuda).Append("\n");
            sb.Append("  ResponsavelAlteracao: ").Append(ResponsavelAlteracao).Append("\n");
            sb.Append("  StatusContestacao: ").Append(StatusContestacao).Append("\n");
            sb.Append("  Texto2Reapresentacao: ").Append(Texto2Reapresentacao).Append("\n");
            sb.Append("  TipoTransacao: ").Append(TipoTransacao).Append("\n");
            sb.Append("  TransacaoSegura: ").Append(TransacaoSegura).Append("\n");
            sb.Append("  ValorCompra: ").Append(ValorCompra).Append("\n");
            sb.Append("  ValorContrato: ").Append(ValorContrato).Append("\n");
            sb.Append("  ValorDestino: ").Append(ValorDestino).Append("\n");
            
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
            return this.Equals(obj as CompraContestadaTransacaoResponse);
        }

        /// <summary>
        /// Returns true if CompraContestadaTransacaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CompraContestadaTransacaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompraContestadaTransacaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AgingCompras == other.AgingCompras ||
                    this.AgingCompras != null &&
                    this.AgingCompras.Equals(other.AgingCompras)
                ) && 
                (
                    this.AgingContestacao == other.AgingContestacao ||
                    this.AgingContestacao != null &&
                    this.AgingContestacao.Equals(other.AgingContestacao)
                ) && 
                (
                    this.Bandeira == other.Bandeira ||
                    this.Bandeira != null &&
                    this.Bandeira.Equals(other.Bandeira)
                ) && 
                (
                    this.CodigoAutorizacao == other.CodigoAutorizacao ||
                    this.CodigoAutorizacao != null &&
                    this.CodigoAutorizacao.Equals(other.CodigoAutorizacao)
                ) && 
                (
                    this.CodigoContestacao == other.CodigoContestacao ||
                    this.CodigoContestacao != null &&
                    this.CodigoContestacao.Equals(other.CodigoContestacao)
                ) && 
                (
                    this.CodigoEventoCompra == other.CodigoEventoCompra ||
                    this.CodigoEventoCompra != null &&
                    this.CodigoEventoCompra.Equals(other.CodigoEventoCompra)
                ) && 
                (
                    this.CodigoMoedaDestino == other.CodigoMoedaDestino ||
                    this.CodigoMoedaDestino != null &&
                    this.CodigoMoedaDestino.Equals(other.CodigoMoedaDestino)
                ) && 
                (
                    this.Data2Reapresentacao == other.Data2Reapresentacao ||
                    this.Data2Reapresentacao != null &&
                    this.Data2Reapresentacao.Equals(other.Data2Reapresentacao)
                ) && 
                (
                    this.DataAlteracao == other.DataAlteracao ||
                    this.DataAlteracao != null &&
                    this.DataAlteracao.Equals(other.DataAlteracao)
                ) && 
                (
                    this.DataContestacao == other.DataContestacao ||
                    this.DataContestacao != null &&
                    this.DataContestacao.Equals(other.DataContestacao)
                ) && 
                (
                    this.DataEnvioCB == other.DataEnvioCB ||
                    this.DataEnvioCB != null &&
                    this.DataEnvioCB.Equals(other.DataEnvioCB)
                ) && 
                (
                    this.DataTransacao == other.DataTransacao ||
                    this.DataTransacao != null &&
                    this.DataTransacao.Equals(other.DataTransacao)
                ) && 
                (
                    this.IdCompraContestada == other.IdCompraContestada ||
                    this.IdCompraContestada != null &&
                    this.IdCompraContestada.Equals(other.IdCompraContestada)
                ) && 
                (
                    this.Internacional == other.Internacional ||
                    this.Internacional != null &&
                    this.Internacional.Equals(other.Internacional)
                ) && 
                (
                    this.Mcc == other.Mcc ||
                    this.Mcc != null &&
                    this.Mcc.Equals(other.Mcc)
                ) && 
                (
                    this.ModoDeEntradaDescricao == other.ModoDeEntradaDescricao ||
                    this.ModoDeEntradaDescricao != null &&
                    this.ModoDeEntradaDescricao.Equals(other.ModoDeEntradaDescricao)
                ) && 
                (
                    this.ModoEntrada == other.ModoEntrada ||
                    this.ModoEntrada != null &&
                    this.ModoEntrada.Equals(other.ModoEntrada)
                ) && 
                (
                    this.Motivo2Reapresentacao == other.Motivo2Reapresentacao ||
                    this.Motivo2Reapresentacao != null &&
                    this.Motivo2Reapresentacao.Equals(other.Motivo2Reapresentacao)
                ) && 
                (
                    this.NomeEstabelecimento == other.NomeEstabelecimento ||
                    this.NomeEstabelecimento != null &&
                    this.NomeEstabelecimento.Equals(other.NomeEstabelecimento)
                ) && 
                (
                    this.NumeroControle == other.NumeroControle ||
                    this.NumeroControle != null &&
                    this.NumeroControle.Equals(other.NumeroControle)
                ) && 
                (
                    this.RazaoCB == other.RazaoCB ||
                    this.RazaoCB != null &&
                    this.RazaoCB.Equals(other.RazaoCB)
                ) && 
                (
                    this.ReferenceNumber == other.ReferenceNumber ||
                    this.ReferenceNumber != null &&
                    this.ReferenceNumber.Equals(other.ReferenceNumber)
                ) && 
                (
                    this.ReporteBandeira == other.ReporteBandeira ||
                    this.ReporteBandeira != null &&
                    this.ReporteBandeira.Equals(other.ReporteBandeira)
                ) && 
                (
                    this.ResponsavelAbertuda == other.ResponsavelAbertuda ||
                    this.ResponsavelAbertuda != null &&
                    this.ResponsavelAbertuda.Equals(other.ResponsavelAbertuda)
                ) && 
                (
                    this.ResponsavelAlteracao == other.ResponsavelAlteracao ||
                    this.ResponsavelAlteracao != null &&
                    this.ResponsavelAlteracao.Equals(other.ResponsavelAlteracao)
                ) && 
                (
                    this.StatusContestacao == other.StatusContestacao ||
                    this.StatusContestacao != null &&
                    this.StatusContestacao.Equals(other.StatusContestacao)
                ) && 
                (
                    this.Texto2Reapresentacao == other.Texto2Reapresentacao ||
                    this.Texto2Reapresentacao != null &&
                    this.Texto2Reapresentacao.Equals(other.Texto2Reapresentacao)
                ) && 
                (
                    this.TipoTransacao == other.TipoTransacao ||
                    this.TipoTransacao != null &&
                    this.TipoTransacao.Equals(other.TipoTransacao)
                ) && 
                (
                    this.TransacaoSegura == other.TransacaoSegura ||
                    this.TransacaoSegura != null &&
                    this.TransacaoSegura.Equals(other.TransacaoSegura)
                ) && 
                (
                    this.ValorCompra == other.ValorCompra ||
                    this.ValorCompra != null &&
                    this.ValorCompra.Equals(other.ValorCompra)
                ) && 
                (
                    this.ValorContrato == other.ValorContrato ||
                    this.ValorContrato != null &&
                    this.ValorContrato.Equals(other.ValorContrato)
                ) && 
                (
                    this.ValorDestino == other.ValorDestino ||
                    this.ValorDestino != null &&
                    this.ValorDestino.Equals(other.ValorDestino)
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
                
                if (this.AgingCompras != null)
                    hash = hash * 59 + this.AgingCompras.GetHashCode();
                
                if (this.AgingContestacao != null)
                    hash = hash * 59 + this.AgingContestacao.GetHashCode();
                
                if (this.Bandeira != null)
                    hash = hash * 59 + this.Bandeira.GetHashCode();
                
                if (this.CodigoAutorizacao != null)
                    hash = hash * 59 + this.CodigoAutorizacao.GetHashCode();
                
                if (this.CodigoContestacao != null)
                    hash = hash * 59 + this.CodigoContestacao.GetHashCode();
                
                if (this.CodigoEventoCompra != null)
                    hash = hash * 59 + this.CodigoEventoCompra.GetHashCode();
                
                if (this.CodigoMoedaDestino != null)
                    hash = hash * 59 + this.CodigoMoedaDestino.GetHashCode();
                
                if (this.Data2Reapresentacao != null)
                    hash = hash * 59 + this.Data2Reapresentacao.GetHashCode();
                
                if (this.DataAlteracao != null)
                    hash = hash * 59 + this.DataAlteracao.GetHashCode();
                
                if (this.DataContestacao != null)
                    hash = hash * 59 + this.DataContestacao.GetHashCode();
                
                if (this.DataEnvioCB != null)
                    hash = hash * 59 + this.DataEnvioCB.GetHashCode();
                
                if (this.DataTransacao != null)
                    hash = hash * 59 + this.DataTransacao.GetHashCode();
                
                if (this.IdCompraContestada != null)
                    hash = hash * 59 + this.IdCompraContestada.GetHashCode();
                
                if (this.Internacional != null)
                    hash = hash * 59 + this.Internacional.GetHashCode();
                
                if (this.Mcc != null)
                    hash = hash * 59 + this.Mcc.GetHashCode();
                
                if (this.ModoDeEntradaDescricao != null)
                    hash = hash * 59 + this.ModoDeEntradaDescricao.GetHashCode();
                
                if (this.ModoEntrada != null)
                    hash = hash * 59 + this.ModoEntrada.GetHashCode();
                
                if (this.Motivo2Reapresentacao != null)
                    hash = hash * 59 + this.Motivo2Reapresentacao.GetHashCode();
                
                if (this.NomeEstabelecimento != null)
                    hash = hash * 59 + this.NomeEstabelecimento.GetHashCode();
                
                if (this.NumeroControle != null)
                    hash = hash * 59 + this.NumeroControle.GetHashCode();
                
                if (this.RazaoCB != null)
                    hash = hash * 59 + this.RazaoCB.GetHashCode();
                
                if (this.ReferenceNumber != null)
                    hash = hash * 59 + this.ReferenceNumber.GetHashCode();
                
                if (this.ReporteBandeira != null)
                    hash = hash * 59 + this.ReporteBandeira.GetHashCode();
                
                if (this.ResponsavelAbertuda != null)
                    hash = hash * 59 + this.ResponsavelAbertuda.GetHashCode();
                
                if (this.ResponsavelAlteracao != null)
                    hash = hash * 59 + this.ResponsavelAlteracao.GetHashCode();
                
                if (this.StatusContestacao != null)
                    hash = hash * 59 + this.StatusContestacao.GetHashCode();
                
                if (this.Texto2Reapresentacao != null)
                    hash = hash * 59 + this.Texto2Reapresentacao.GetHashCode();
                
                if (this.TipoTransacao != null)
                    hash = hash * 59 + this.TipoTransacao.GetHashCode();
                
                if (this.TransacaoSegura != null)
                    hash = hash * 59 + this.TransacaoSegura.GetHashCode();
                
                if (this.ValorCompra != null)
                    hash = hash * 59 + this.ValorCompra.GetHashCode();
                
                if (this.ValorContrato != null)
                    hash = hash * 59 + this.ValorContrato.GetHashCode();
                
                if (this.ValorDestino != null)
                    hash = hash * 59 + this.ValorDestino.GetHashCode();
                
                return hash;
            }
        }

    }
}
