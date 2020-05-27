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
    public partial class CdtTipoOperacao :  IEquatable<CdtTipoOperacao>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CdtTipoOperacao" /> class.
        /// Initializes a new instance of the <see cref="CdtTipoOperacao" />class.
        /// </summary>
        /// <param name="CodigoProcessamento">CodigoProcessamento.</param>
        /// <param name="CodigoProcessamentoCancelamento">CodigoProcessamentoCancelamento.</param>
        /// <param name="Descricao">Descricao.</param>
        /// <param name="ExcedentePermitido">ExcedentePermitido.</param>
        /// <param name="FlagCobraJuros">FlagCobraJuros.</param>
        /// <param name="FlagCobraProRata">FlagCobraProRata.</param>
        /// <param name="FlagCobraTarifa">FlagCobraTarifa.</param>
        /// <param name="FlagCredito">FlagCredito.</param>
        /// <param name="FlagCreditoContestavel">FlagCreditoContestavel.</param>
        /// <param name="FlagIOFApartado">FlagIOFApartado.</param>
        /// <param name="FlagManterTaxaJurosNoRotativo">FlagManterTaxaJurosNoRotativo.</param>
        /// <param name="FlagPermitirParcelamento">FlagPermitirParcelamento.</param>
        /// <param name="FlagPosProximoVencimento">FlagPosProximoVencimento.</param>
        /// <param name="FlagTiraTac">FlagTiraTac.</param>
        /// <param name="Id">Id.</param>
        /// <param name="IdEmissor">IdEmissor.</param>
        /// <param name="IdOperacaoOrigem">IdOperacaoOrigem.</param>
        /// <param name="IdTabela">IdTabela.</param>
        /// <param name="IdTabelaJuros">IdTabelaJuros.</param>
        /// <param name="Nome">Nome.</param>
        /// <param name="PercentualTac">PercentualTac.</param>
        /// <param name="PlanoMaximo">PlanoMaximo.</param>
        /// <param name="PlanoMinimo">PlanoMinimo.</param>
        /// <param name="RemuneracaoEmissor">RemuneracaoEmissor.</param>
        /// <param name="Tarifa">Tarifa.</param>
        /// <param name="TaxaJuros">TaxaJuros.</param>
        /// <param name="TipoExcedentePermitido">TipoExcedentePermitido.</param>
        /// <param name="TipoOperacao">TipoOperacao.</param>
        /// <param name="ValorMaximo">ValorMaximo.</param>
        /// <param name="ValorMinimo">ValorMinimo.</param>
        /// <param name="ValorOperacao">ValorOperacao.</param>
        /// <param name="ValorParcela">ValorParcela.</param>
        /// <param name="ValorTAC">ValorTAC.</param>

        public CdtTipoOperacao(string CodigoProcessamento = null, string CodigoProcessamentoCancelamento = null, string Descricao = null, double? ExcedentePermitido = null, bool? FlagCobraJuros = null, bool? FlagCobraProRata = null, bool? FlagCobraTarifa = null, bool? FlagCredito = null, bool? FlagCreditoContestavel = null, bool? FlagIOFApartado = null, bool? FlagManterTaxaJurosNoRotativo = null, bool? FlagPermitirParcelamento = null, int? FlagPosProximoVencimento = null, int? FlagTiraTac = null, long? Id = null, int? IdEmissor = null, long? IdOperacaoOrigem = null, long? IdTabela = null, long? IdTabelaJuros = null, string Nome = null, double? PercentualTac = null, int? PlanoMaximo = null, int? PlanoMinimo = null, double? RemuneracaoEmissor = null, double? Tarifa = null, double? TaxaJuros = null, string TipoExcedentePermitido = null, string TipoOperacao = null, double? ValorMaximo = null, double? ValorMinimo = null, double? ValorOperacao = null, long? ValorParcela = null, double? ValorTAC = null)
        {
            this.CodigoProcessamento = CodigoProcessamento;
            this.CodigoProcessamentoCancelamento = CodigoProcessamentoCancelamento;
            this.Descricao = Descricao;
            this.ExcedentePermitido = ExcedentePermitido;
            this.FlagCobraJuros = FlagCobraJuros;
            this.FlagCobraProRata = FlagCobraProRata;
            this.FlagCobraTarifa = FlagCobraTarifa;
            this.FlagCredito = FlagCredito;
            this.FlagCreditoContestavel = FlagCreditoContestavel;
            this.FlagIOFApartado = FlagIOFApartado;
            this.FlagManterTaxaJurosNoRotativo = FlagManterTaxaJurosNoRotativo;
            this.FlagPermitirParcelamento = FlagPermitirParcelamento;
            this.FlagPosProximoVencimento = FlagPosProximoVencimento;
            this.FlagTiraTac = FlagTiraTac;
            this.Id = Id;
            this.IdEmissor = IdEmissor;
            this.IdOperacaoOrigem = IdOperacaoOrigem;
            this.IdTabela = IdTabela;
            this.IdTabelaJuros = IdTabelaJuros;
            this.Nome = Nome;
            this.PercentualTac = PercentualTac;
            this.PlanoMaximo = PlanoMaximo;
            this.PlanoMinimo = PlanoMinimo;
            this.RemuneracaoEmissor = RemuneracaoEmissor;
            this.Tarifa = Tarifa;
            this.TaxaJuros = TaxaJuros;
            this.TipoExcedentePermitido = TipoExcedentePermitido;
            this.TipoOperacao = TipoOperacao;
            this.ValorMaximo = ValorMaximo;
            this.ValorMinimo = ValorMinimo;
            this.ValorOperacao = ValorOperacao;
            this.ValorParcela = ValorParcela;
            this.ValorTAC = ValorTAC;
            
        }
        
    
        /// <summary>
        /// Gets or Sets CodigoProcessamento
        /// </summary>
        [DataMember(Name="codigoProcessamento", EmitDefaultValue=false)]
        public string CodigoProcessamento { get; set; }
    
        /// <summary>
        /// Gets or Sets CodigoProcessamentoCancelamento
        /// </summary>
        [DataMember(Name="codigoProcessamentoCancelamento", EmitDefaultValue=false)]
        public string CodigoProcessamentoCancelamento { get; set; }
    
        /// <summary>
        /// Gets or Sets Descricao
        /// </summary>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Gets or Sets ExcedentePermitido
        /// </summary>
        [DataMember(Name="excedentePermitido", EmitDefaultValue=false)]
        public double? ExcedentePermitido { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagCobraJuros
        /// </summary>
        [DataMember(Name="flagCobraJuros", EmitDefaultValue=false)]
        public bool? FlagCobraJuros { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagCobraProRata
        /// </summary>
        [DataMember(Name="flagCobraProRata", EmitDefaultValue=false)]
        public bool? FlagCobraProRata { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagCobraTarifa
        /// </summary>
        [DataMember(Name="flagCobraTarifa", EmitDefaultValue=false)]
        public bool? FlagCobraTarifa { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagCredito
        /// </summary>
        [DataMember(Name="flagCredito", EmitDefaultValue=false)]
        public bool? FlagCredito { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagCreditoContestavel
        /// </summary>
        [DataMember(Name="flagCreditoContestavel", EmitDefaultValue=false)]
        public bool? FlagCreditoContestavel { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagIOFApartado
        /// </summary>
        [DataMember(Name="flagIOFApartado", EmitDefaultValue=false)]
        public bool? FlagIOFApartado { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagManterTaxaJurosNoRotativo
        /// </summary>
        [DataMember(Name="flagManterTaxaJurosNoRotativo", EmitDefaultValue=false)]
        public bool? FlagManterTaxaJurosNoRotativo { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagPermitirParcelamento
        /// </summary>
        [DataMember(Name="flagPermitirParcelamento", EmitDefaultValue=false)]
        public bool? FlagPermitirParcelamento { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagPosProximoVencimento
        /// </summary>
        [DataMember(Name="flagPosProximoVencimento", EmitDefaultValue=false)]
        public int? FlagPosProximoVencimento { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagTiraTac
        /// </summary>
        [DataMember(Name="flagTiraTac", EmitDefaultValue=false)]
        public int? FlagTiraTac { get; set; }
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Gets or Sets IdEmissor
        /// </summary>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public int? IdEmissor { get; set; }
    
        /// <summary>
        /// Gets or Sets IdOperacaoOrigem
        /// </summary>
        [DataMember(Name="idOperacaoOrigem", EmitDefaultValue=false)]
        public long? IdOperacaoOrigem { get; set; }
    
        /// <summary>
        /// Gets or Sets IdTabela
        /// </summary>
        [DataMember(Name="idTabela", EmitDefaultValue=false)]
        public long? IdTabela { get; set; }
    
        /// <summary>
        /// Gets or Sets IdTabelaJuros
        /// </summary>
        [DataMember(Name="idTabelaJuros", EmitDefaultValue=false)]
        public long? IdTabelaJuros { get; set; }
    
        /// <summary>
        /// Gets or Sets Nome
        /// </summary>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Gets or Sets PercentualTac
        /// </summary>
        [DataMember(Name="percentualTac", EmitDefaultValue=false)]
        public double? PercentualTac { get; set; }
    
        /// <summary>
        /// Gets or Sets PlanoMaximo
        /// </summary>
        [DataMember(Name="planoMaximo", EmitDefaultValue=false)]
        public int? PlanoMaximo { get; set; }
    
        /// <summary>
        /// Gets or Sets PlanoMinimo
        /// </summary>
        [DataMember(Name="planoMinimo", EmitDefaultValue=false)]
        public int? PlanoMinimo { get; set; }
    
        /// <summary>
        /// Gets or Sets RemuneracaoEmissor
        /// </summary>
        [DataMember(Name="remuneracaoEmissor", EmitDefaultValue=false)]
        public double? RemuneracaoEmissor { get; set; }
    
        /// <summary>
        /// Gets or Sets Tarifa
        /// </summary>
        [DataMember(Name="tarifa", EmitDefaultValue=false)]
        public double? Tarifa { get; set; }
    
        /// <summary>
        /// Gets or Sets TaxaJuros
        /// </summary>
        [DataMember(Name="taxaJuros", EmitDefaultValue=false)]
        public double? TaxaJuros { get; set; }
    
        /// <summary>
        /// Gets or Sets TipoExcedentePermitido
        /// </summary>
        [DataMember(Name="tipoExcedentePermitido", EmitDefaultValue=false)]
        public string TipoExcedentePermitido { get; set; }
    
        /// <summary>
        /// Gets or Sets TipoOperacao
        /// </summary>
        [DataMember(Name="tipoOperacao", EmitDefaultValue=false)]
        public string TipoOperacao { get; set; }
    
        /// <summary>
        /// Gets or Sets ValorMaximo
        /// </summary>
        [DataMember(Name="valorMaximo", EmitDefaultValue=false)]
        public double? ValorMaximo { get; set; }
    
        /// <summary>
        /// Gets or Sets ValorMinimo
        /// </summary>
        [DataMember(Name="valorMinimo", EmitDefaultValue=false)]
        public double? ValorMinimo { get; set; }
    
        /// <summary>
        /// Gets or Sets ValorOperacao
        /// </summary>
        [DataMember(Name="valorOperacao", EmitDefaultValue=false)]
        public double? ValorOperacao { get; set; }
    
        /// <summary>
        /// Gets or Sets ValorParcela
        /// </summary>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public long? ValorParcela { get; set; }
    
        /// <summary>
        /// Gets or Sets ValorTAC
        /// </summary>
        [DataMember(Name="valorTAC", EmitDefaultValue=false)]
        public double? ValorTAC { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CdtTipoOperacao {\n");
            sb.Append("  CodigoProcessamento: ").Append(CodigoProcessamento).Append("\n");
            sb.Append("  CodigoProcessamentoCancelamento: ").Append(CodigoProcessamentoCancelamento).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  ExcedentePermitido: ").Append(ExcedentePermitido).Append("\n");
            sb.Append("  FlagCobraJuros: ").Append(FlagCobraJuros).Append("\n");
            sb.Append("  FlagCobraProRata: ").Append(FlagCobraProRata).Append("\n");
            sb.Append("  FlagCobraTarifa: ").Append(FlagCobraTarifa).Append("\n");
            sb.Append("  FlagCredito: ").Append(FlagCredito).Append("\n");
            sb.Append("  FlagCreditoContestavel: ").Append(FlagCreditoContestavel).Append("\n");
            sb.Append("  FlagIOFApartado: ").Append(FlagIOFApartado).Append("\n");
            sb.Append("  FlagManterTaxaJurosNoRotativo: ").Append(FlagManterTaxaJurosNoRotativo).Append("\n");
            sb.Append("  FlagPermitirParcelamento: ").Append(FlagPermitirParcelamento).Append("\n");
            sb.Append("  FlagPosProximoVencimento: ").Append(FlagPosProximoVencimento).Append("\n");
            sb.Append("  FlagTiraTac: ").Append(FlagTiraTac).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdEmissor: ").Append(IdEmissor).Append("\n");
            sb.Append("  IdOperacaoOrigem: ").Append(IdOperacaoOrigem).Append("\n");
            sb.Append("  IdTabela: ").Append(IdTabela).Append("\n");
            sb.Append("  IdTabelaJuros: ").Append(IdTabelaJuros).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  PercentualTac: ").Append(PercentualTac).Append("\n");
            sb.Append("  PlanoMaximo: ").Append(PlanoMaximo).Append("\n");
            sb.Append("  PlanoMinimo: ").Append(PlanoMinimo).Append("\n");
            sb.Append("  RemuneracaoEmissor: ").Append(RemuneracaoEmissor).Append("\n");
            sb.Append("  Tarifa: ").Append(Tarifa).Append("\n");
            sb.Append("  TaxaJuros: ").Append(TaxaJuros).Append("\n");
            sb.Append("  TipoExcedentePermitido: ").Append(TipoExcedentePermitido).Append("\n");
            sb.Append("  TipoOperacao: ").Append(TipoOperacao).Append("\n");
            sb.Append("  ValorMaximo: ").Append(ValorMaximo).Append("\n");
            sb.Append("  ValorMinimo: ").Append(ValorMinimo).Append("\n");
            sb.Append("  ValorOperacao: ").Append(ValorOperacao).Append("\n");
            sb.Append("  ValorParcela: ").Append(ValorParcela).Append("\n");
            sb.Append("  ValorTAC: ").Append(ValorTAC).Append("\n");
            
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
            return this.Equals(obj as CdtTipoOperacao);
        }

        /// <summary>
        /// Returns true if CdtTipoOperacao instances are equal
        /// </summary>
        /// <param name="other">Instance of CdtTipoOperacao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CdtTipoOperacao other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CodigoProcessamento == other.CodigoProcessamento ||
                    this.CodigoProcessamento != null &&
                    this.CodigoProcessamento.Equals(other.CodigoProcessamento)
                ) && 
                (
                    this.CodigoProcessamentoCancelamento == other.CodigoProcessamentoCancelamento ||
                    this.CodigoProcessamentoCancelamento != null &&
                    this.CodigoProcessamentoCancelamento.Equals(other.CodigoProcessamentoCancelamento)
                ) && 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.ExcedentePermitido == other.ExcedentePermitido ||
                    this.ExcedentePermitido != null &&
                    this.ExcedentePermitido.Equals(other.ExcedentePermitido)
                ) && 
                (
                    this.FlagCobraJuros == other.FlagCobraJuros ||
                    this.FlagCobraJuros != null &&
                    this.FlagCobraJuros.Equals(other.FlagCobraJuros)
                ) && 
                (
                    this.FlagCobraProRata == other.FlagCobraProRata ||
                    this.FlagCobraProRata != null &&
                    this.FlagCobraProRata.Equals(other.FlagCobraProRata)
                ) && 
                (
                    this.FlagCobraTarifa == other.FlagCobraTarifa ||
                    this.FlagCobraTarifa != null &&
                    this.FlagCobraTarifa.Equals(other.FlagCobraTarifa)
                ) && 
                (
                    this.FlagCredito == other.FlagCredito ||
                    this.FlagCredito != null &&
                    this.FlagCredito.Equals(other.FlagCredito)
                ) && 
                (
                    this.FlagCreditoContestavel == other.FlagCreditoContestavel ||
                    this.FlagCreditoContestavel != null &&
                    this.FlagCreditoContestavel.Equals(other.FlagCreditoContestavel)
                ) && 
                (
                    this.FlagIOFApartado == other.FlagIOFApartado ||
                    this.FlagIOFApartado != null &&
                    this.FlagIOFApartado.Equals(other.FlagIOFApartado)
                ) && 
                (
                    this.FlagManterTaxaJurosNoRotativo == other.FlagManterTaxaJurosNoRotativo ||
                    this.FlagManterTaxaJurosNoRotativo != null &&
                    this.FlagManterTaxaJurosNoRotativo.Equals(other.FlagManterTaxaJurosNoRotativo)
                ) && 
                (
                    this.FlagPermitirParcelamento == other.FlagPermitirParcelamento ||
                    this.FlagPermitirParcelamento != null &&
                    this.FlagPermitirParcelamento.Equals(other.FlagPermitirParcelamento)
                ) && 
                (
                    this.FlagPosProximoVencimento == other.FlagPosProximoVencimento ||
                    this.FlagPosProximoVencimento != null &&
                    this.FlagPosProximoVencimento.Equals(other.FlagPosProximoVencimento)
                ) && 
                (
                    this.FlagTiraTac == other.FlagTiraTac ||
                    this.FlagTiraTac != null &&
                    this.FlagTiraTac.Equals(other.FlagTiraTac)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdEmissor == other.IdEmissor ||
                    this.IdEmissor != null &&
                    this.IdEmissor.Equals(other.IdEmissor)
                ) && 
                (
                    this.IdOperacaoOrigem == other.IdOperacaoOrigem ||
                    this.IdOperacaoOrigem != null &&
                    this.IdOperacaoOrigem.Equals(other.IdOperacaoOrigem)
                ) && 
                (
                    this.IdTabela == other.IdTabela ||
                    this.IdTabela != null &&
                    this.IdTabela.Equals(other.IdTabela)
                ) && 
                (
                    this.IdTabelaJuros == other.IdTabelaJuros ||
                    this.IdTabelaJuros != null &&
                    this.IdTabelaJuros.Equals(other.IdTabelaJuros)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.PercentualTac == other.PercentualTac ||
                    this.PercentualTac != null &&
                    this.PercentualTac.Equals(other.PercentualTac)
                ) && 
                (
                    this.PlanoMaximo == other.PlanoMaximo ||
                    this.PlanoMaximo != null &&
                    this.PlanoMaximo.Equals(other.PlanoMaximo)
                ) && 
                (
                    this.PlanoMinimo == other.PlanoMinimo ||
                    this.PlanoMinimo != null &&
                    this.PlanoMinimo.Equals(other.PlanoMinimo)
                ) && 
                (
                    this.RemuneracaoEmissor == other.RemuneracaoEmissor ||
                    this.RemuneracaoEmissor != null &&
                    this.RemuneracaoEmissor.Equals(other.RemuneracaoEmissor)
                ) && 
                (
                    this.Tarifa == other.Tarifa ||
                    this.Tarifa != null &&
                    this.Tarifa.Equals(other.Tarifa)
                ) && 
                (
                    this.TaxaJuros == other.TaxaJuros ||
                    this.TaxaJuros != null &&
                    this.TaxaJuros.Equals(other.TaxaJuros)
                ) && 
                (
                    this.TipoExcedentePermitido == other.TipoExcedentePermitido ||
                    this.TipoExcedentePermitido != null &&
                    this.TipoExcedentePermitido.Equals(other.TipoExcedentePermitido)
                ) && 
                (
                    this.TipoOperacao == other.TipoOperacao ||
                    this.TipoOperacao != null &&
                    this.TipoOperacao.Equals(other.TipoOperacao)
                ) && 
                (
                    this.ValorMaximo == other.ValorMaximo ||
                    this.ValorMaximo != null &&
                    this.ValorMaximo.Equals(other.ValorMaximo)
                ) && 
                (
                    this.ValorMinimo == other.ValorMinimo ||
                    this.ValorMinimo != null &&
                    this.ValorMinimo.Equals(other.ValorMinimo)
                ) && 
                (
                    this.ValorOperacao == other.ValorOperacao ||
                    this.ValorOperacao != null &&
                    this.ValorOperacao.Equals(other.ValorOperacao)
                ) && 
                (
                    this.ValorParcela == other.ValorParcela ||
                    this.ValorParcela != null &&
                    this.ValorParcela.Equals(other.ValorParcela)
                ) && 
                (
                    this.ValorTAC == other.ValorTAC ||
                    this.ValorTAC != null &&
                    this.ValorTAC.Equals(other.ValorTAC)
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
                
                if (this.CodigoProcessamento != null)
                    hash = hash * 59 + this.CodigoProcessamento.GetHashCode();
                
                if (this.CodigoProcessamentoCancelamento != null)
                    hash = hash * 59 + this.CodigoProcessamentoCancelamento.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.ExcedentePermitido != null)
                    hash = hash * 59 + this.ExcedentePermitido.GetHashCode();
                
                if (this.FlagCobraJuros != null)
                    hash = hash * 59 + this.FlagCobraJuros.GetHashCode();
                
                if (this.FlagCobraProRata != null)
                    hash = hash * 59 + this.FlagCobraProRata.GetHashCode();
                
                if (this.FlagCobraTarifa != null)
                    hash = hash * 59 + this.FlagCobraTarifa.GetHashCode();
                
                if (this.FlagCredito != null)
                    hash = hash * 59 + this.FlagCredito.GetHashCode();
                
                if (this.FlagCreditoContestavel != null)
                    hash = hash * 59 + this.FlagCreditoContestavel.GetHashCode();
                
                if (this.FlagIOFApartado != null)
                    hash = hash * 59 + this.FlagIOFApartado.GetHashCode();
                
                if (this.FlagManterTaxaJurosNoRotativo != null)
                    hash = hash * 59 + this.FlagManterTaxaJurosNoRotativo.GetHashCode();
                
                if (this.FlagPermitirParcelamento != null)
                    hash = hash * 59 + this.FlagPermitirParcelamento.GetHashCode();
                
                if (this.FlagPosProximoVencimento != null)
                    hash = hash * 59 + this.FlagPosProximoVencimento.GetHashCode();
                
                if (this.FlagTiraTac != null)
                    hash = hash * 59 + this.FlagTiraTac.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdEmissor != null)
                    hash = hash * 59 + this.IdEmissor.GetHashCode();
                
                if (this.IdOperacaoOrigem != null)
                    hash = hash * 59 + this.IdOperacaoOrigem.GetHashCode();
                
                if (this.IdTabela != null)
                    hash = hash * 59 + this.IdTabela.GetHashCode();
                
                if (this.IdTabelaJuros != null)
                    hash = hash * 59 + this.IdTabelaJuros.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.PercentualTac != null)
                    hash = hash * 59 + this.PercentualTac.GetHashCode();
                
                if (this.PlanoMaximo != null)
                    hash = hash * 59 + this.PlanoMaximo.GetHashCode();
                
                if (this.PlanoMinimo != null)
                    hash = hash * 59 + this.PlanoMinimo.GetHashCode();
                
                if (this.RemuneracaoEmissor != null)
                    hash = hash * 59 + this.RemuneracaoEmissor.GetHashCode();
                
                if (this.Tarifa != null)
                    hash = hash * 59 + this.Tarifa.GetHashCode();
                
                if (this.TaxaJuros != null)
                    hash = hash * 59 + this.TaxaJuros.GetHashCode();
                
                if (this.TipoExcedentePermitido != null)
                    hash = hash * 59 + this.TipoExcedentePermitido.GetHashCode();
                
                if (this.TipoOperacao != null)
                    hash = hash * 59 + this.TipoOperacao.GetHashCode();
                
                if (this.ValorMaximo != null)
                    hash = hash * 59 + this.ValorMaximo.GetHashCode();
                
                if (this.ValorMinimo != null)
                    hash = hash * 59 + this.ValorMinimo.GetHashCode();
                
                if (this.ValorOperacao != null)
                    hash = hash * 59 + this.ValorOperacao.GetHashCode();
                
                if (this.ValorParcela != null)
                    hash = hash * 59 + this.ValorParcela.GetHashCode();
                
                if (this.ValorTAC != null)
                    hash = hash * 59 + this.ValorTAC.GetHashCode();
                
                return hash;
            }
        }

    }
}
