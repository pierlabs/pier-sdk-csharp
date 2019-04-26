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
    /// Representa\u00E7\u00E3o da resposta do recurso Operacao
    /// </summary>
    [DataContract]
    public partial class DetalheOperacaoResponse :  IEquatable<DetalheOperacaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DetalheOperacaoResponse" /> class.
        /// Initializes a new instance of the <see cref="DetalheOperacaoResponse" />class.
        /// </summary>
        /// <param name="IdOperacao">C\u00F3digo que identifica a opera\u00E7\u00E3o.</param>
        /// <param name="CodigoProcessamento">C\u00F3digo de processamento usado em transa\u00E7\u00F5es com o autorizador.</param>
        /// <param name="CodigoProcessamentoCancelamento">C\u00F3digo de processamento usado para cancelar transa\u00E7\u00F5es no autorizador.</param>
        /// <param name="NomeOperacao">Nome da opera\u00E7\u00E3o.</param>
        /// <param name="DescricaoOperacao">Descri\u00E7\u00E3o da opera\u00E7\u00E3o.</param>
        /// <param name="PlanoMinimo">Quantidade m\u00EDnima de meses permitido para opera\u00E7\u00E3o.</param>
        /// <param name="PlanoMaximo">Quantidade M\u00E1ximo de meses permitido para opera\u00E7\u00E3o.</param>
        /// <param name="ValorMinimo">Valor m\u00EDnimo permitido permitido para opera\u00E7\u00E3o.</param>
        /// <param name="ValorMaximo">Valor m\u00E1ximo permitido permitido para opera\u00E7\u00E3o.</param>
        /// <param name="FlagCobraJuros">Flag indicativa para crobran\u00E7a de juros.</param>
        /// <param name="TaxaJuros">Valor do juros a ser cobrado, caso opera\u00E7\u00E3o cobre juros.</param>
        /// <param name="FlagCobraTarifa">Flag indicativa para crobran\u00E7a de tarifas.</param>
        /// <param name="TaxaTarifa">Valor da tarifa a ser cobrado, caso opera\u00E7\u00E3o cobre tarifas.</param>
        /// <param name="ValorTac">Valor da taxa de abertura de conta.</param>
        /// <param name="PercentualTac">Percentual da taxa de abertura de conta.</param>
        /// <param name="ValorOperacao">Valor da opera\u00E7\u00E3o.</param>
        /// <param name="Carencia">Quantidade de meses para car\u00EAncia.</param>
        /// <param name="ExcedentePermitido">Valor excedente permitido para opera\u00E7\u00E3o.</param>
        /// <param name="FlagPermitirParcelamento">Permitir transa\u00E7\u00F5es parceladas.</param>
        /// <param name="FlagManterTaxaJurosNoRotativo">Flag que indica que a opera\u00E7\u00E3o deve utilizar a taxa da compra como taxa do rotativo para transa\u00E7\u00F5es desse tipo opera\u00E7\u00E3o.</param>
        /// <param name="IdEmissor">C\u00F3digo identificador do emissor.</param>
        /// <param name="IdTabela">C\u00F3digo identificador da tabela.</param>
        /// <param name="ValorParcela">Valor da parcela.</param>
        /// <param name="FlagCobraProRata">Flag indicativa de cobrar juros.</param>
        /// <param name="IdTabelaJuros">C\u00F3digo identificador da tabela de juros.</param>
        /// <param name="TipoExcedentePermitido">Tipo excedente permitido.</param>

        public DetalheOperacaoResponse(long? IdOperacao = null, string CodigoProcessamento = null, string CodigoProcessamentoCancelamento = null, string NomeOperacao = null, string DescricaoOperacao = null, int? PlanoMinimo = null, int? PlanoMaximo = null, double? ValorMinimo = null, double? ValorMaximo = null, bool? FlagCobraJuros = null, double? TaxaJuros = null, bool? FlagCobraTarifa = null, double? TaxaTarifa = null, double? ValorTac = null, double? PercentualTac = null, double? ValorOperacao = null, int? Carencia = null, double? ExcedentePermitido = null, bool? FlagPermitirParcelamento = null, bool? FlagManterTaxaJurosNoRotativo = null, int? IdEmissor = null, long? IdTabela = null, long? ValorParcela = null, bool? FlagCobraProRata = null, long? IdTabelaJuros = null, string TipoExcedentePermitido = null)
        {
            this.IdOperacao = IdOperacao;
            this.CodigoProcessamento = CodigoProcessamento;
            this.CodigoProcessamentoCancelamento = CodigoProcessamentoCancelamento;
            this.NomeOperacao = NomeOperacao;
            this.DescricaoOperacao = DescricaoOperacao;
            this.PlanoMinimo = PlanoMinimo;
            this.PlanoMaximo = PlanoMaximo;
            this.ValorMinimo = ValorMinimo;
            this.ValorMaximo = ValorMaximo;
            this.FlagCobraJuros = FlagCobraJuros;
            this.TaxaJuros = TaxaJuros;
            this.FlagCobraTarifa = FlagCobraTarifa;
            this.TaxaTarifa = TaxaTarifa;
            this.ValorTac = ValorTac;
            this.PercentualTac = PercentualTac;
            this.ValorOperacao = ValorOperacao;
            this.Carencia = Carencia;
            this.ExcedentePermitido = ExcedentePermitido;
            this.FlagPermitirParcelamento = FlagPermitirParcelamento;
            this.FlagManterTaxaJurosNoRotativo = FlagManterTaxaJurosNoRotativo;
            this.IdEmissor = IdEmissor;
            this.IdTabela = IdTabela;
            this.ValorParcela = ValorParcela;
            this.FlagCobraProRata = FlagCobraProRata;
            this.IdTabelaJuros = IdTabelaJuros;
            this.TipoExcedentePermitido = TipoExcedentePermitido;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo que identifica a opera\u00E7\u00E3o
        /// </summary>
        /// <value>C\u00F3digo que identifica a opera\u00E7\u00E3o</value>
        [DataMember(Name="idOperacao", EmitDefaultValue=false)]
        public long? IdOperacao { get; set; }
    
        /// <summary>
        /// C\u00F3digo de processamento usado em transa\u00E7\u00F5es com o autorizador
        /// </summary>
        /// <value>C\u00F3digo de processamento usado em transa\u00E7\u00F5es com o autorizador</value>
        [DataMember(Name="codigoProcessamento", EmitDefaultValue=false)]
        public string CodigoProcessamento { get; set; }
    
        /// <summary>
        /// C\u00F3digo de processamento usado para cancelar transa\u00E7\u00F5es no autorizador
        /// </summary>
        /// <value>C\u00F3digo de processamento usado para cancelar transa\u00E7\u00F5es no autorizador</value>
        [DataMember(Name="codigoProcessamentoCancelamento", EmitDefaultValue=false)]
        public string CodigoProcessamentoCancelamento { get; set; }
    
        /// <summary>
        /// Nome da opera\u00E7\u00E3o
        /// </summary>
        /// <value>Nome da opera\u00E7\u00E3o</value>
        [DataMember(Name="nomeOperacao", EmitDefaultValue=false)]
        public string NomeOperacao { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o da opera\u00E7\u00E3o
        /// </summary>
        /// <value>Descri\u00E7\u00E3o da opera\u00E7\u00E3o</value>
        [DataMember(Name="descricaoOperacao", EmitDefaultValue=false)]
        public string DescricaoOperacao { get; set; }
    
        /// <summary>
        /// Quantidade m\u00EDnima de meses permitido para opera\u00E7\u00E3o
        /// </summary>
        /// <value>Quantidade m\u00EDnima de meses permitido para opera\u00E7\u00E3o</value>
        [DataMember(Name="planoMinimo", EmitDefaultValue=false)]
        public int? PlanoMinimo { get; set; }
    
        /// <summary>
        /// Quantidade M\u00E1ximo de meses permitido para opera\u00E7\u00E3o
        /// </summary>
        /// <value>Quantidade M\u00E1ximo de meses permitido para opera\u00E7\u00E3o</value>
        [DataMember(Name="planoMaximo", EmitDefaultValue=false)]
        public int? PlanoMaximo { get; set; }
    
        /// <summary>
        /// Valor m\u00EDnimo permitido permitido para opera\u00E7\u00E3o
        /// </summary>
        /// <value>Valor m\u00EDnimo permitido permitido para opera\u00E7\u00E3o</value>
        [DataMember(Name="valorMinimo", EmitDefaultValue=false)]
        public double? ValorMinimo { get; set; }
    
        /// <summary>
        /// Valor m\u00E1ximo permitido permitido para opera\u00E7\u00E3o
        /// </summary>
        /// <value>Valor m\u00E1ximo permitido permitido para opera\u00E7\u00E3o</value>
        [DataMember(Name="valorMaximo", EmitDefaultValue=false)]
        public double? ValorMaximo { get; set; }
    
        /// <summary>
        /// Flag indicativa para crobran\u00E7a de juros
        /// </summary>
        /// <value>Flag indicativa para crobran\u00E7a de juros</value>
        [DataMember(Name="flagCobraJuros", EmitDefaultValue=false)]
        public bool? FlagCobraJuros { get; set; }
    
        /// <summary>
        /// Valor do juros a ser cobrado, caso opera\u00E7\u00E3o cobre juros
        /// </summary>
        /// <value>Valor do juros a ser cobrado, caso opera\u00E7\u00E3o cobre juros</value>
        [DataMember(Name="taxaJuros", EmitDefaultValue=false)]
        public double? TaxaJuros { get; set; }
    
        /// <summary>
        /// Flag indicativa para crobran\u00E7a de tarifas
        /// </summary>
        /// <value>Flag indicativa para crobran\u00E7a de tarifas</value>
        [DataMember(Name="flagCobraTarifa", EmitDefaultValue=false)]
        public bool? FlagCobraTarifa { get; set; }
    
        /// <summary>
        /// Valor da tarifa a ser cobrado, caso opera\u00E7\u00E3o cobre tarifas
        /// </summary>
        /// <value>Valor da tarifa a ser cobrado, caso opera\u00E7\u00E3o cobre tarifas</value>
        [DataMember(Name="taxaTarifa", EmitDefaultValue=false)]
        public double? TaxaTarifa { get; set; }
    
        /// <summary>
        /// Valor da taxa de abertura de conta
        /// </summary>
        /// <value>Valor da taxa de abertura de conta</value>
        [DataMember(Name="valorTac", EmitDefaultValue=false)]
        public double? ValorTac { get; set; }
    
        /// <summary>
        /// Percentual da taxa de abertura de conta
        /// </summary>
        /// <value>Percentual da taxa de abertura de conta</value>
        [DataMember(Name="percentualTac", EmitDefaultValue=false)]
        public double? PercentualTac { get; set; }
    
        /// <summary>
        /// Valor da opera\u00E7\u00E3o
        /// </summary>
        /// <value>Valor da opera\u00E7\u00E3o</value>
        [DataMember(Name="valorOperacao", EmitDefaultValue=false)]
        public double? ValorOperacao { get; set; }
    
        /// <summary>
        /// Quantidade de meses para car\u00EAncia
        /// </summary>
        /// <value>Quantidade de meses para car\u00EAncia</value>
        [DataMember(Name="carencia", EmitDefaultValue=false)]
        public int? Carencia { get; set; }
    
        /// <summary>
        /// Valor excedente permitido para opera\u00E7\u00E3o
        /// </summary>
        /// <value>Valor excedente permitido para opera\u00E7\u00E3o</value>
        [DataMember(Name="excedentePermitido", EmitDefaultValue=false)]
        public double? ExcedentePermitido { get; set; }
    
        /// <summary>
        /// Permitir transa\u00E7\u00F5es parceladas
        /// </summary>
        /// <value>Permitir transa\u00E7\u00F5es parceladas</value>
        [DataMember(Name="flagPermitirParcelamento", EmitDefaultValue=false)]
        public bool? FlagPermitirParcelamento { get; set; }
    
        /// <summary>
        /// Flag que indica que a opera\u00E7\u00E3o deve utilizar a taxa da compra como taxa do rotativo para transa\u00E7\u00F5es desse tipo opera\u00E7\u00E3o
        /// </summary>
        /// <value>Flag que indica que a opera\u00E7\u00E3o deve utilizar a taxa da compra como taxa do rotativo para transa\u00E7\u00F5es desse tipo opera\u00E7\u00E3o</value>
        [DataMember(Name="flagManterTaxaJurosNoRotativo", EmitDefaultValue=false)]
        public bool? FlagManterTaxaJurosNoRotativo { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do emissor
        /// </summary>
        /// <value>C\u00F3digo identificador do emissor</value>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public int? IdEmissor { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da tabela
        /// </summary>
        /// <value>C\u00F3digo identificador da tabela</value>
        [DataMember(Name="idTabela", EmitDefaultValue=false)]
        public long? IdTabela { get; set; }
    
        /// <summary>
        /// Valor da parcela
        /// </summary>
        /// <value>Valor da parcela</value>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public long? ValorParcela { get; set; }
    
        /// <summary>
        /// Flag indicativa de cobrar juros
        /// </summary>
        /// <value>Flag indicativa de cobrar juros</value>
        [DataMember(Name="flagCobraProRata", EmitDefaultValue=false)]
        public bool? FlagCobraProRata { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da tabela de juros
        /// </summary>
        /// <value>C\u00F3digo identificador da tabela de juros</value>
        [DataMember(Name="idTabelaJuros", EmitDefaultValue=false)]
        public long? IdTabelaJuros { get; set; }
    
        /// <summary>
        /// Tipo excedente permitido
        /// </summary>
        /// <value>Tipo excedente permitido</value>
        [DataMember(Name="tipoExcedentePermitido", EmitDefaultValue=false)]
        public string TipoExcedentePermitido { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetalheOperacaoResponse {\n");
            sb.Append("  IdOperacao: ").Append(IdOperacao).Append("\n");
            sb.Append("  CodigoProcessamento: ").Append(CodigoProcessamento).Append("\n");
            sb.Append("  CodigoProcessamentoCancelamento: ").Append(CodigoProcessamentoCancelamento).Append("\n");
            sb.Append("  NomeOperacao: ").Append(NomeOperacao).Append("\n");
            sb.Append("  DescricaoOperacao: ").Append(DescricaoOperacao).Append("\n");
            sb.Append("  PlanoMinimo: ").Append(PlanoMinimo).Append("\n");
            sb.Append("  PlanoMaximo: ").Append(PlanoMaximo).Append("\n");
            sb.Append("  ValorMinimo: ").Append(ValorMinimo).Append("\n");
            sb.Append("  ValorMaximo: ").Append(ValorMaximo).Append("\n");
            sb.Append("  FlagCobraJuros: ").Append(FlagCobraJuros).Append("\n");
            sb.Append("  TaxaJuros: ").Append(TaxaJuros).Append("\n");
            sb.Append("  FlagCobraTarifa: ").Append(FlagCobraTarifa).Append("\n");
            sb.Append("  TaxaTarifa: ").Append(TaxaTarifa).Append("\n");
            sb.Append("  ValorTac: ").Append(ValorTac).Append("\n");
            sb.Append("  PercentualTac: ").Append(PercentualTac).Append("\n");
            sb.Append("  ValorOperacao: ").Append(ValorOperacao).Append("\n");
            sb.Append("  Carencia: ").Append(Carencia).Append("\n");
            sb.Append("  ExcedentePermitido: ").Append(ExcedentePermitido).Append("\n");
            sb.Append("  FlagPermitirParcelamento: ").Append(FlagPermitirParcelamento).Append("\n");
            sb.Append("  FlagManterTaxaJurosNoRotativo: ").Append(FlagManterTaxaJurosNoRotativo).Append("\n");
            sb.Append("  IdEmissor: ").Append(IdEmissor).Append("\n");
            sb.Append("  IdTabela: ").Append(IdTabela).Append("\n");
            sb.Append("  ValorParcela: ").Append(ValorParcela).Append("\n");
            sb.Append("  FlagCobraProRata: ").Append(FlagCobraProRata).Append("\n");
            sb.Append("  IdTabelaJuros: ").Append(IdTabelaJuros).Append("\n");
            sb.Append("  TipoExcedentePermitido: ").Append(TipoExcedentePermitido).Append("\n");
            
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
            return this.Equals(obj as DetalheOperacaoResponse);
        }

        /// <summary>
        /// Returns true if DetalheOperacaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DetalheOperacaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetalheOperacaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdOperacao == other.IdOperacao ||
                    this.IdOperacao != null &&
                    this.IdOperacao.Equals(other.IdOperacao)
                ) && 
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
                    this.NomeOperacao == other.NomeOperacao ||
                    this.NomeOperacao != null &&
                    this.NomeOperacao.Equals(other.NomeOperacao)
                ) && 
                (
                    this.DescricaoOperacao == other.DescricaoOperacao ||
                    this.DescricaoOperacao != null &&
                    this.DescricaoOperacao.Equals(other.DescricaoOperacao)
                ) && 
                (
                    this.PlanoMinimo == other.PlanoMinimo ||
                    this.PlanoMinimo != null &&
                    this.PlanoMinimo.Equals(other.PlanoMinimo)
                ) && 
                (
                    this.PlanoMaximo == other.PlanoMaximo ||
                    this.PlanoMaximo != null &&
                    this.PlanoMaximo.Equals(other.PlanoMaximo)
                ) && 
                (
                    this.ValorMinimo == other.ValorMinimo ||
                    this.ValorMinimo != null &&
                    this.ValorMinimo.Equals(other.ValorMinimo)
                ) && 
                (
                    this.ValorMaximo == other.ValorMaximo ||
                    this.ValorMaximo != null &&
                    this.ValorMaximo.Equals(other.ValorMaximo)
                ) && 
                (
                    this.FlagCobraJuros == other.FlagCobraJuros ||
                    this.FlagCobraJuros != null &&
                    this.FlagCobraJuros.Equals(other.FlagCobraJuros)
                ) && 
                (
                    this.TaxaJuros == other.TaxaJuros ||
                    this.TaxaJuros != null &&
                    this.TaxaJuros.Equals(other.TaxaJuros)
                ) && 
                (
                    this.FlagCobraTarifa == other.FlagCobraTarifa ||
                    this.FlagCobraTarifa != null &&
                    this.FlagCobraTarifa.Equals(other.FlagCobraTarifa)
                ) && 
                (
                    this.TaxaTarifa == other.TaxaTarifa ||
                    this.TaxaTarifa != null &&
                    this.TaxaTarifa.Equals(other.TaxaTarifa)
                ) && 
                (
                    this.ValorTac == other.ValorTac ||
                    this.ValorTac != null &&
                    this.ValorTac.Equals(other.ValorTac)
                ) && 
                (
                    this.PercentualTac == other.PercentualTac ||
                    this.PercentualTac != null &&
                    this.PercentualTac.Equals(other.PercentualTac)
                ) && 
                (
                    this.ValorOperacao == other.ValorOperacao ||
                    this.ValorOperacao != null &&
                    this.ValorOperacao.Equals(other.ValorOperacao)
                ) && 
                (
                    this.Carencia == other.Carencia ||
                    this.Carencia != null &&
                    this.Carencia.Equals(other.Carencia)
                ) && 
                (
                    this.ExcedentePermitido == other.ExcedentePermitido ||
                    this.ExcedentePermitido != null &&
                    this.ExcedentePermitido.Equals(other.ExcedentePermitido)
                ) && 
                (
                    this.FlagPermitirParcelamento == other.FlagPermitirParcelamento ||
                    this.FlagPermitirParcelamento != null &&
                    this.FlagPermitirParcelamento.Equals(other.FlagPermitirParcelamento)
                ) && 
                (
                    this.FlagManterTaxaJurosNoRotativo == other.FlagManterTaxaJurosNoRotativo ||
                    this.FlagManterTaxaJurosNoRotativo != null &&
                    this.FlagManterTaxaJurosNoRotativo.Equals(other.FlagManterTaxaJurosNoRotativo)
                ) && 
                (
                    this.IdEmissor == other.IdEmissor ||
                    this.IdEmissor != null &&
                    this.IdEmissor.Equals(other.IdEmissor)
                ) && 
                (
                    this.IdTabela == other.IdTabela ||
                    this.IdTabela != null &&
                    this.IdTabela.Equals(other.IdTabela)
                ) && 
                (
                    this.ValorParcela == other.ValorParcela ||
                    this.ValorParcela != null &&
                    this.ValorParcela.Equals(other.ValorParcela)
                ) && 
                (
                    this.FlagCobraProRata == other.FlagCobraProRata ||
                    this.FlagCobraProRata != null &&
                    this.FlagCobraProRata.Equals(other.FlagCobraProRata)
                ) && 
                (
                    this.IdTabelaJuros == other.IdTabelaJuros ||
                    this.IdTabelaJuros != null &&
                    this.IdTabelaJuros.Equals(other.IdTabelaJuros)
                ) && 
                (
                    this.TipoExcedentePermitido == other.TipoExcedentePermitido ||
                    this.TipoExcedentePermitido != null &&
                    this.TipoExcedentePermitido.Equals(other.TipoExcedentePermitido)
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
                
                if (this.IdOperacao != null)
                    hash = hash * 59 + this.IdOperacao.GetHashCode();
                
                if (this.CodigoProcessamento != null)
                    hash = hash * 59 + this.CodigoProcessamento.GetHashCode();
                
                if (this.CodigoProcessamentoCancelamento != null)
                    hash = hash * 59 + this.CodigoProcessamentoCancelamento.GetHashCode();
                
                if (this.NomeOperacao != null)
                    hash = hash * 59 + this.NomeOperacao.GetHashCode();
                
                if (this.DescricaoOperacao != null)
                    hash = hash * 59 + this.DescricaoOperacao.GetHashCode();
                
                if (this.PlanoMinimo != null)
                    hash = hash * 59 + this.PlanoMinimo.GetHashCode();
                
                if (this.PlanoMaximo != null)
                    hash = hash * 59 + this.PlanoMaximo.GetHashCode();
                
                if (this.ValorMinimo != null)
                    hash = hash * 59 + this.ValorMinimo.GetHashCode();
                
                if (this.ValorMaximo != null)
                    hash = hash * 59 + this.ValorMaximo.GetHashCode();
                
                if (this.FlagCobraJuros != null)
                    hash = hash * 59 + this.FlagCobraJuros.GetHashCode();
                
                if (this.TaxaJuros != null)
                    hash = hash * 59 + this.TaxaJuros.GetHashCode();
                
                if (this.FlagCobraTarifa != null)
                    hash = hash * 59 + this.FlagCobraTarifa.GetHashCode();
                
                if (this.TaxaTarifa != null)
                    hash = hash * 59 + this.TaxaTarifa.GetHashCode();
                
                if (this.ValorTac != null)
                    hash = hash * 59 + this.ValorTac.GetHashCode();
                
                if (this.PercentualTac != null)
                    hash = hash * 59 + this.PercentualTac.GetHashCode();
                
                if (this.ValorOperacao != null)
                    hash = hash * 59 + this.ValorOperacao.GetHashCode();
                
                if (this.Carencia != null)
                    hash = hash * 59 + this.Carencia.GetHashCode();
                
                if (this.ExcedentePermitido != null)
                    hash = hash * 59 + this.ExcedentePermitido.GetHashCode();
                
                if (this.FlagPermitirParcelamento != null)
                    hash = hash * 59 + this.FlagPermitirParcelamento.GetHashCode();
                
                if (this.FlagManterTaxaJurosNoRotativo != null)
                    hash = hash * 59 + this.FlagManterTaxaJurosNoRotativo.GetHashCode();
                
                if (this.IdEmissor != null)
                    hash = hash * 59 + this.IdEmissor.GetHashCode();
                
                if (this.IdTabela != null)
                    hash = hash * 59 + this.IdTabela.GetHashCode();
                
                if (this.ValorParcela != null)
                    hash = hash * 59 + this.ValorParcela.GetHashCode();
                
                if (this.FlagCobraProRata != null)
                    hash = hash * 59 + this.FlagCobraProRata.GetHashCode();
                
                if (this.IdTabelaJuros != null)
                    hash = hash * 59 + this.IdTabelaJuros.GetHashCode();
                
                if (this.TipoExcedentePermitido != null)
                    hash = hash * 59 + this.TipoExcedentePermitido.GetHashCode();
                
                return hash;
            }
        }

    }
}
