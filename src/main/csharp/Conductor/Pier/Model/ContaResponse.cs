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
    public partial class ContaResponse :  IEquatable<ContaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaResponse" /> class.
        /// Initializes a new instance of the <see cref="ContaResponse" />class.
        /// </summary>
        /// <param name="Bin">Bin.</param>
        /// <param name="Cartao">Cartao.</param>
        /// <param name="DataCadastramento">DataCadastramento.</param>
        /// <param name="DataUltimoPagamento">DataUltimoPagamento.</param>
        /// <param name="DataVencCobranca">DataVencCobranca.</param>
        /// <param name="DddcelularSMS">DddcelularSMS.</param>
        /// <param name="DescricaoStatus">DescricaoStatus.</param>
        /// <param name="DiasEmAtraso">DiasEmAtraso.</param>
        /// <param name="Emissor">Emissor.</param>
        /// <param name="FlagCancelamento">FlagCancelamento.</param>
        /// <param name="FormaEnvioFatura">FormaEnvioFatura.</param>
        /// <param name="IdBandeira">IdBandeira.</param>
        /// <param name="IdConta">IdConta.</param>
        /// <param name="IdEmissor">IdEmissor.</param>
        /// <param name="IdEndereco">IdEndereco.</param>
        /// <param name="IdFantasiaBasica">IdFantasiaBasica.</param>
        /// <param name="IdOrigemComercial">IdOrigemComercial.</param>
        /// <param name="IdProduto">IdProduto.</param>
        /// <param name="IdProposta">IdProposta.</param>
        /// <param name="MelhorDia">MelhorDia.</param>
        /// <param name="NomeCredor">NomeCredor.</param>
        /// <param name="NomeProduto">NomeProduto.</param>
        /// <param name="NumCelularSMS">NumCelularSMS.</param>
        /// <param name="Pagamentos">Pagamentos.</param>
        /// <param name="PermiteRefinanciamento">PermiteRefinanciamento.</param>
        /// <param name="PessoaFisica">PessoaFisica.</param>
        /// <param name="QuantidadePagamentos">QuantidadePagamentos.</param>
        /// <param name="SaldoLimite">SaldoLimite.</param>
        /// <param name="Status">Status.</param>
        /// <param name="StatusData">StatusData.</param>
        /// <param name="TaxaRefinanciamento">TaxaRefinanciamento.</param>
        /// <param name="Vcto">Vcto.</param>
        /// <param name="Vencimento1">Vencimento1.</param>
        /// <param name="VinculoOrigemUsuario">VinculoOrigemUsuario.</param>

        public ContaResponse(int? Bin = null, ConsultarContaCartaoResponse Cartao = null, string DataCadastramento = null, string DataUltimoPagamento = null, string DataVencCobranca = null, string DddcelularSMS = null, string DescricaoStatus = null, int? DiasEmAtraso = null, string Emissor = null, bool? FlagCancelamento = null, string FormaEnvioFatura = null, int? IdBandeira = null, int? IdConta = null, int? IdEmissor = null, int? IdEndereco = null, int? IdFantasiaBasica = null, int? IdOrigemComercial = null, int? IdProduto = null, int? IdProposta = null, int? MelhorDia = null, string NomeCredor = null, string NomeProduto = null, string NumCelularSMS = null, double? Pagamentos = null, bool? PermiteRefinanciamento = null, PessoaFisicaResponse PessoaFisica = null, int? QuantidadePagamentos = null, SaldoLimiteResponse SaldoLimite = null, int? Status = null, DateTime? StatusData = null, string TaxaRefinanciamento = null, string Vcto = null, int? Vencimento1 = null, bool? VinculoOrigemUsuario = null)
        {
            this.Bin = Bin;
            this.Cartao = Cartao;
            this.DataCadastramento = DataCadastramento;
            this.DataUltimoPagamento = DataUltimoPagamento;
            this.DataVencCobranca = DataVencCobranca;
            this.DddcelularSMS = DddcelularSMS;
            this.DescricaoStatus = DescricaoStatus;
            this.DiasEmAtraso = DiasEmAtraso;
            this.Emissor = Emissor;
            this.FlagCancelamento = FlagCancelamento;
            this.FormaEnvioFatura = FormaEnvioFatura;
            this.IdBandeira = IdBandeira;
            this.IdConta = IdConta;
            this.IdEmissor = IdEmissor;
            this.IdEndereco = IdEndereco;
            this.IdFantasiaBasica = IdFantasiaBasica;
            this.IdOrigemComercial = IdOrigemComercial;
            this.IdProduto = IdProduto;
            this.IdProposta = IdProposta;
            this.MelhorDia = MelhorDia;
            this.NomeCredor = NomeCredor;
            this.NomeProduto = NomeProduto;
            this.NumCelularSMS = NumCelularSMS;
            this.Pagamentos = Pagamentos;
            this.PermiteRefinanciamento = PermiteRefinanciamento;
            this.PessoaFisica = PessoaFisica;
            this.QuantidadePagamentos = QuantidadePagamentos;
            this.SaldoLimite = SaldoLimite;
            this.Status = Status;
            this.StatusData = StatusData;
            this.TaxaRefinanciamento = TaxaRefinanciamento;
            this.Vcto = Vcto;
            this.Vencimento1 = Vencimento1;
            this.VinculoOrigemUsuario = VinculoOrigemUsuario;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Bin
        /// </summary>
        [DataMember(Name="bin", EmitDefaultValue=false)]
        public int? Bin { get; set; }
    
        /// <summary>
        /// Gets or Sets Cartao
        /// </summary>
        [DataMember(Name="cartao", EmitDefaultValue=false)]
        public ConsultarContaCartaoResponse Cartao { get; set; }
    
        /// <summary>
        /// Gets or Sets DataCadastramento
        /// </summary>
        [DataMember(Name="dataCadastramento", EmitDefaultValue=false)]
        public string DataCadastramento { get; set; }
    
        /// <summary>
        /// Gets or Sets DataUltimoPagamento
        /// </summary>
        [DataMember(Name="dataUltimoPagamento", EmitDefaultValue=false)]
        public string DataUltimoPagamento { get; set; }
    
        /// <summary>
        /// Gets or Sets DataVencCobranca
        /// </summary>
        [DataMember(Name="dataVencCobranca", EmitDefaultValue=false)]
        public string DataVencCobranca { get; set; }
    
        /// <summary>
        /// Gets or Sets DddcelularSMS
        /// </summary>
        [DataMember(Name="dddcelularSMS", EmitDefaultValue=false)]
        public string DddcelularSMS { get; set; }
    
        /// <summary>
        /// Gets or Sets DescricaoStatus
        /// </summary>
        [DataMember(Name="descricaoStatus", EmitDefaultValue=false)]
        public string DescricaoStatus { get; set; }
    
        /// <summary>
        /// Gets or Sets DiasEmAtraso
        /// </summary>
        [DataMember(Name="diasEmAtraso", EmitDefaultValue=false)]
        public int? DiasEmAtraso { get; set; }
    
        /// <summary>
        /// Gets or Sets Emissor
        /// </summary>
        [DataMember(Name="emissor", EmitDefaultValue=false)]
        public string Emissor { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagCancelamento
        /// </summary>
        [DataMember(Name="flagCancelamento", EmitDefaultValue=false)]
        public bool? FlagCancelamento { get; set; }
    
        /// <summary>
        /// Gets or Sets FormaEnvioFatura
        /// </summary>
        [DataMember(Name="formaEnvioFatura", EmitDefaultValue=false)]
        public string FormaEnvioFatura { get; set; }
    
        /// <summary>
        /// Gets or Sets IdBandeira
        /// </summary>
        [DataMember(Name="idBandeira", EmitDefaultValue=false)]
        public int? IdBandeira { get; set; }
    
        /// <summary>
        /// Gets or Sets IdConta
        /// </summary>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public int? IdConta { get; set; }
    
        /// <summary>
        /// Gets or Sets IdEmissor
        /// </summary>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public int? IdEmissor { get; set; }
    
        /// <summary>
        /// Gets or Sets IdEndereco
        /// </summary>
        [DataMember(Name="idEndereco", EmitDefaultValue=false)]
        public int? IdEndereco { get; set; }
    
        /// <summary>
        /// Gets or Sets IdFantasiaBasica
        /// </summary>
        [DataMember(Name="idFantasiaBasica", EmitDefaultValue=false)]
        public int? IdFantasiaBasica { get; set; }
    
        /// <summary>
        /// Gets or Sets IdOrigemComercial
        /// </summary>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public int? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// Gets or Sets IdProduto
        /// </summary>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public int? IdProduto { get; set; }
    
        /// <summary>
        /// Gets or Sets IdProposta
        /// </summary>
        [DataMember(Name="idProposta", EmitDefaultValue=false)]
        public int? IdProposta { get; set; }
    
        /// <summary>
        /// Gets or Sets MelhorDia
        /// </summary>
        [DataMember(Name="melhorDia", EmitDefaultValue=false)]
        public int? MelhorDia { get; set; }
    
        /// <summary>
        /// Gets or Sets NomeCredor
        /// </summary>
        [DataMember(Name="nomeCredor", EmitDefaultValue=false)]
        public string NomeCredor { get; set; }
    
        /// <summary>
        /// Gets or Sets NomeProduto
        /// </summary>
        [DataMember(Name="nomeProduto", EmitDefaultValue=false)]
        public string NomeProduto { get; set; }
    
        /// <summary>
        /// Gets or Sets NumCelularSMS
        /// </summary>
        [DataMember(Name="numCelularSMS", EmitDefaultValue=false)]
        public string NumCelularSMS { get; set; }
    
        /// <summary>
        /// Gets or Sets Pagamentos
        /// </summary>
        [DataMember(Name="pagamentos", EmitDefaultValue=false)]
        public double? Pagamentos { get; set; }
    
        /// <summary>
        /// Gets or Sets PermiteRefinanciamento
        /// </summary>
        [DataMember(Name="permiteRefinanciamento", EmitDefaultValue=false)]
        public bool? PermiteRefinanciamento { get; set; }
    
        /// <summary>
        /// Gets or Sets PessoaFisica
        /// </summary>
        [DataMember(Name="pessoaFisica", EmitDefaultValue=false)]
        public PessoaFisicaResponse PessoaFisica { get; set; }
    
        /// <summary>
        /// Gets or Sets QuantidadePagamentos
        /// </summary>
        [DataMember(Name="quantidadePagamentos", EmitDefaultValue=false)]
        public int? QuantidadePagamentos { get; set; }
    
        /// <summary>
        /// Gets or Sets SaldoLimite
        /// </summary>
        [DataMember(Name="saldoLimite", EmitDefaultValue=false)]
        public SaldoLimiteResponse SaldoLimite { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// Gets or Sets StatusData
        /// </summary>
        [DataMember(Name="statusData", EmitDefaultValue=false)]
        public DateTime? StatusData { get; set; }
    
        /// <summary>
        /// Gets or Sets TaxaRefinanciamento
        /// </summary>
        [DataMember(Name="taxaRefinanciamento", EmitDefaultValue=false)]
        public string TaxaRefinanciamento { get; set; }
    
        /// <summary>
        /// Gets or Sets Vcto
        /// </summary>
        [DataMember(Name="vcto", EmitDefaultValue=false)]
        public string Vcto { get; set; }
    
        /// <summary>
        /// Gets or Sets Vencimento1
        /// </summary>
        [DataMember(Name="vencimento1", EmitDefaultValue=false)]
        public int? Vencimento1 { get; set; }
    
        /// <summary>
        /// Gets or Sets VinculoOrigemUsuario
        /// </summary>
        [DataMember(Name="vinculoOrigemUsuario", EmitDefaultValue=false)]
        public bool? VinculoOrigemUsuario { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContaResponse {\n");
            sb.Append("  Bin: ").Append(Bin).Append("\n");
            sb.Append("  Cartao: ").Append(Cartao).Append("\n");
            sb.Append("  DataCadastramento: ").Append(DataCadastramento).Append("\n");
            sb.Append("  DataUltimoPagamento: ").Append(DataUltimoPagamento).Append("\n");
            sb.Append("  DataVencCobranca: ").Append(DataVencCobranca).Append("\n");
            sb.Append("  DddcelularSMS: ").Append(DddcelularSMS).Append("\n");
            sb.Append("  DescricaoStatus: ").Append(DescricaoStatus).Append("\n");
            sb.Append("  DiasEmAtraso: ").Append(DiasEmAtraso).Append("\n");
            sb.Append("  Emissor: ").Append(Emissor).Append("\n");
            sb.Append("  FlagCancelamento: ").Append(FlagCancelamento).Append("\n");
            sb.Append("  FormaEnvioFatura: ").Append(FormaEnvioFatura).Append("\n");
            sb.Append("  IdBandeira: ").Append(IdBandeira).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdEmissor: ").Append(IdEmissor).Append("\n");
            sb.Append("  IdEndereco: ").Append(IdEndereco).Append("\n");
            sb.Append("  IdFantasiaBasica: ").Append(IdFantasiaBasica).Append("\n");
            sb.Append("  IdOrigemComercial: ").Append(IdOrigemComercial).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdProposta: ").Append(IdProposta).Append("\n");
            sb.Append("  MelhorDia: ").Append(MelhorDia).Append("\n");
            sb.Append("  NomeCredor: ").Append(NomeCredor).Append("\n");
            sb.Append("  NomeProduto: ").Append(NomeProduto).Append("\n");
            sb.Append("  NumCelularSMS: ").Append(NumCelularSMS).Append("\n");
            sb.Append("  Pagamentos: ").Append(Pagamentos).Append("\n");
            sb.Append("  PermiteRefinanciamento: ").Append(PermiteRefinanciamento).Append("\n");
            sb.Append("  PessoaFisica: ").Append(PessoaFisica).Append("\n");
            sb.Append("  QuantidadePagamentos: ").Append(QuantidadePagamentos).Append("\n");
            sb.Append("  SaldoLimite: ").Append(SaldoLimite).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusData: ").Append(StatusData).Append("\n");
            sb.Append("  TaxaRefinanciamento: ").Append(TaxaRefinanciamento).Append("\n");
            sb.Append("  Vcto: ").Append(Vcto).Append("\n");
            sb.Append("  Vencimento1: ").Append(Vencimento1).Append("\n");
            sb.Append("  VinculoOrigemUsuario: ").Append(VinculoOrigemUsuario).Append("\n");
            
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
            return this.Equals(obj as ContaResponse);
        }

        /// <summary>
        /// Returns true if ContaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ContaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Bin == other.Bin ||
                    this.Bin != null &&
                    this.Bin.Equals(other.Bin)
                ) && 
                (
                    this.Cartao == other.Cartao ||
                    this.Cartao != null &&
                    this.Cartao.Equals(other.Cartao)
                ) && 
                (
                    this.DataCadastramento == other.DataCadastramento ||
                    this.DataCadastramento != null &&
                    this.DataCadastramento.Equals(other.DataCadastramento)
                ) && 
                (
                    this.DataUltimoPagamento == other.DataUltimoPagamento ||
                    this.DataUltimoPagamento != null &&
                    this.DataUltimoPagamento.Equals(other.DataUltimoPagamento)
                ) && 
                (
                    this.DataVencCobranca == other.DataVencCobranca ||
                    this.DataVencCobranca != null &&
                    this.DataVencCobranca.Equals(other.DataVencCobranca)
                ) && 
                (
                    this.DddcelularSMS == other.DddcelularSMS ||
                    this.DddcelularSMS != null &&
                    this.DddcelularSMS.Equals(other.DddcelularSMS)
                ) && 
                (
                    this.DescricaoStatus == other.DescricaoStatus ||
                    this.DescricaoStatus != null &&
                    this.DescricaoStatus.Equals(other.DescricaoStatus)
                ) && 
                (
                    this.DiasEmAtraso == other.DiasEmAtraso ||
                    this.DiasEmAtraso != null &&
                    this.DiasEmAtraso.Equals(other.DiasEmAtraso)
                ) && 
                (
                    this.Emissor == other.Emissor ||
                    this.Emissor != null &&
                    this.Emissor.Equals(other.Emissor)
                ) && 
                (
                    this.FlagCancelamento == other.FlagCancelamento ||
                    this.FlagCancelamento != null &&
                    this.FlagCancelamento.Equals(other.FlagCancelamento)
                ) && 
                (
                    this.FormaEnvioFatura == other.FormaEnvioFatura ||
                    this.FormaEnvioFatura != null &&
                    this.FormaEnvioFatura.Equals(other.FormaEnvioFatura)
                ) && 
                (
                    this.IdBandeira == other.IdBandeira ||
                    this.IdBandeira != null &&
                    this.IdBandeira.Equals(other.IdBandeira)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdEmissor == other.IdEmissor ||
                    this.IdEmissor != null &&
                    this.IdEmissor.Equals(other.IdEmissor)
                ) && 
                (
                    this.IdEndereco == other.IdEndereco ||
                    this.IdEndereco != null &&
                    this.IdEndereco.Equals(other.IdEndereco)
                ) && 
                (
                    this.IdFantasiaBasica == other.IdFantasiaBasica ||
                    this.IdFantasiaBasica != null &&
                    this.IdFantasiaBasica.Equals(other.IdFantasiaBasica)
                ) && 
                (
                    this.IdOrigemComercial == other.IdOrigemComercial ||
                    this.IdOrigemComercial != null &&
                    this.IdOrigemComercial.Equals(other.IdOrigemComercial)
                ) && 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.IdProposta == other.IdProposta ||
                    this.IdProposta != null &&
                    this.IdProposta.Equals(other.IdProposta)
                ) && 
                (
                    this.MelhorDia == other.MelhorDia ||
                    this.MelhorDia != null &&
                    this.MelhorDia.Equals(other.MelhorDia)
                ) && 
                (
                    this.NomeCredor == other.NomeCredor ||
                    this.NomeCredor != null &&
                    this.NomeCredor.Equals(other.NomeCredor)
                ) && 
                (
                    this.NomeProduto == other.NomeProduto ||
                    this.NomeProduto != null &&
                    this.NomeProduto.Equals(other.NomeProduto)
                ) && 
                (
                    this.NumCelularSMS == other.NumCelularSMS ||
                    this.NumCelularSMS != null &&
                    this.NumCelularSMS.Equals(other.NumCelularSMS)
                ) && 
                (
                    this.Pagamentos == other.Pagamentos ||
                    this.Pagamentos != null &&
                    this.Pagamentos.Equals(other.Pagamentos)
                ) && 
                (
                    this.PermiteRefinanciamento == other.PermiteRefinanciamento ||
                    this.PermiteRefinanciamento != null &&
                    this.PermiteRefinanciamento.Equals(other.PermiteRefinanciamento)
                ) && 
                (
                    this.PessoaFisica == other.PessoaFisica ||
                    this.PessoaFisica != null &&
                    this.PessoaFisica.Equals(other.PessoaFisica)
                ) && 
                (
                    this.QuantidadePagamentos == other.QuantidadePagamentos ||
                    this.QuantidadePagamentos != null &&
                    this.QuantidadePagamentos.Equals(other.QuantidadePagamentos)
                ) && 
                (
                    this.SaldoLimite == other.SaldoLimite ||
                    this.SaldoLimite != null &&
                    this.SaldoLimite.Equals(other.SaldoLimite)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StatusData == other.StatusData ||
                    this.StatusData != null &&
                    this.StatusData.Equals(other.StatusData)
                ) && 
                (
                    this.TaxaRefinanciamento == other.TaxaRefinanciamento ||
                    this.TaxaRefinanciamento != null &&
                    this.TaxaRefinanciamento.Equals(other.TaxaRefinanciamento)
                ) && 
                (
                    this.Vcto == other.Vcto ||
                    this.Vcto != null &&
                    this.Vcto.Equals(other.Vcto)
                ) && 
                (
                    this.Vencimento1 == other.Vencimento1 ||
                    this.Vencimento1 != null &&
                    this.Vencimento1.Equals(other.Vencimento1)
                ) && 
                (
                    this.VinculoOrigemUsuario == other.VinculoOrigemUsuario ||
                    this.VinculoOrigemUsuario != null &&
                    this.VinculoOrigemUsuario.Equals(other.VinculoOrigemUsuario)
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
                
                if (this.Bin != null)
                    hash = hash * 59 + this.Bin.GetHashCode();
                
                if (this.Cartao != null)
                    hash = hash * 59 + this.Cartao.GetHashCode();
                
                if (this.DataCadastramento != null)
                    hash = hash * 59 + this.DataCadastramento.GetHashCode();
                
                if (this.DataUltimoPagamento != null)
                    hash = hash * 59 + this.DataUltimoPagamento.GetHashCode();
                
                if (this.DataVencCobranca != null)
                    hash = hash * 59 + this.DataVencCobranca.GetHashCode();
                
                if (this.DddcelularSMS != null)
                    hash = hash * 59 + this.DddcelularSMS.GetHashCode();
                
                if (this.DescricaoStatus != null)
                    hash = hash * 59 + this.DescricaoStatus.GetHashCode();
                
                if (this.DiasEmAtraso != null)
                    hash = hash * 59 + this.DiasEmAtraso.GetHashCode();
                
                if (this.Emissor != null)
                    hash = hash * 59 + this.Emissor.GetHashCode();
                
                if (this.FlagCancelamento != null)
                    hash = hash * 59 + this.FlagCancelamento.GetHashCode();
                
                if (this.FormaEnvioFatura != null)
                    hash = hash * 59 + this.FormaEnvioFatura.GetHashCode();
                
                if (this.IdBandeira != null)
                    hash = hash * 59 + this.IdBandeira.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdEmissor != null)
                    hash = hash * 59 + this.IdEmissor.GetHashCode();
                
                if (this.IdEndereco != null)
                    hash = hash * 59 + this.IdEndereco.GetHashCode();
                
                if (this.IdFantasiaBasica != null)
                    hash = hash * 59 + this.IdFantasiaBasica.GetHashCode();
                
                if (this.IdOrigemComercial != null)
                    hash = hash * 59 + this.IdOrigemComercial.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.IdProposta != null)
                    hash = hash * 59 + this.IdProposta.GetHashCode();
                
                if (this.MelhorDia != null)
                    hash = hash * 59 + this.MelhorDia.GetHashCode();
                
                if (this.NomeCredor != null)
                    hash = hash * 59 + this.NomeCredor.GetHashCode();
                
                if (this.NomeProduto != null)
                    hash = hash * 59 + this.NomeProduto.GetHashCode();
                
                if (this.NumCelularSMS != null)
                    hash = hash * 59 + this.NumCelularSMS.GetHashCode();
                
                if (this.Pagamentos != null)
                    hash = hash * 59 + this.Pagamentos.GetHashCode();
                
                if (this.PermiteRefinanciamento != null)
                    hash = hash * 59 + this.PermiteRefinanciamento.GetHashCode();
                
                if (this.PessoaFisica != null)
                    hash = hash * 59 + this.PessoaFisica.GetHashCode();
                
                if (this.QuantidadePagamentos != null)
                    hash = hash * 59 + this.QuantidadePagamentos.GetHashCode();
                
                if (this.SaldoLimite != null)
                    hash = hash * 59 + this.SaldoLimite.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.StatusData != null)
                    hash = hash * 59 + this.StatusData.GetHashCode();
                
                if (this.TaxaRefinanciamento != null)
                    hash = hash * 59 + this.TaxaRefinanciamento.GetHashCode();
                
                if (this.Vcto != null)
                    hash = hash * 59 + this.Vcto.GetHashCode();
                
                if (this.Vencimento1 != null)
                    hash = hash * 59 + this.Vencimento1.GetHashCode();
                
                if (this.VinculoOrigemUsuario != null)
                    hash = hash * 59 + this.VinculoOrigemUsuario.GetHashCode();
                
                return hash;
            }
        }

    }
}
