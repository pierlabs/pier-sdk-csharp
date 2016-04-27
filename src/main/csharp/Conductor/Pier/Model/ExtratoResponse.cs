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
    public partial class ExtratoResponse :  IEquatable<ExtratoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtratoResponse" /> class.
        /// Initializes a new instance of the <see cref="ExtratoResponse" />class.
        /// </summary>
        /// <param name="Cartao">Cartao.</param>
        /// <param name="Chip">Chip.</param>
        /// <param name="CidadeUFPais">CidadeUFPais.</param>
        /// <param name="CodigoAutorizacao">CodigoAutorizacao.</param>
        /// <param name="CodigoMoeda">CodigoMoeda.</param>
        /// <param name="CodigoMoedaDestino">CodigoMoedaDestino.</param>
        /// <param name="CotacaoDolar">CotacaoDolar.</param>
        /// <param name="Credito">Credito.</param>
        /// <param name="DataCompra">DataCompra.</param>
        /// <param name="DataCotacaoDolar">DataCotacaoDolar.</param>
        /// <param name="DataEntradaCompra">DataEntradaCompra.</param>
        /// <param name="DataTransacaoUTC">DataTransacaoUTC.</param>
        /// <param name="Debito">Debito.</param>
        /// <param name="DescricaoModoEntrada">DescricaoModoEntrada.</param>
        /// <param name="DescricaoTransacao">DescricaoTransacao.</param>
        /// <param name="EncargosFinanceiros">EncargosFinanceiros.</param>
        /// <param name="Historico">Historico.</param>
        /// <param name="IdEventoExterno">IdEventoExterno.</param>
        /// <param name="IdTipoTransacao">IdTipoTransacao.</param>
        /// <param name="IdTransacao">IdTransacao.</param>
        /// <param name="Mcc">Mcc.</param>
        /// <param name="NomeEstabVisa">NomeEstabVisa.</param>
        /// <param name="NomePlastico">NomePlastico.</param>
        /// <param name="NumeroEstabelecimento">NumeroEstabelecimento.</param>
        /// <param name="Origem">Origem.</param>
        /// <param name="TaxaEmbarque">TaxaEmbarque.</param>
        /// <param name="TipoEvento">TipoEvento.</param>
        /// <param name="ValorDolar">ValorDolar.</param>

        public ExtratoResponse(string Cartao = null, string Chip = null, string CidadeUFPais = null, string CodigoAutorizacao = null, string CodigoMoeda = null, string CodigoMoedaDestino = null, double? CotacaoDolar = null, double? Credito = null, string DataCompra = null, DateTime? DataCotacaoDolar = null, string DataEntradaCompra = null, string DataTransacaoUTC = null, double? Debito = null, string DescricaoModoEntrada = null, string DescricaoTransacao = null, double? EncargosFinanceiros = null, string Historico = null, int? IdEventoExterno = null, int? IdTipoTransacao = null, int? IdTransacao = null, int? Mcc = null, string NomeEstabVisa = null, string NomePlastico = null, int? NumeroEstabelecimento = null, string Origem = null, double? TaxaEmbarque = null, string TipoEvento = null, double? ValorDolar = null)
        {
            this.Cartao = Cartao;
            this.Chip = Chip;
            this.CidadeUFPais = CidadeUFPais;
            this.CodigoAutorizacao = CodigoAutorizacao;
            this.CodigoMoeda = CodigoMoeda;
            this.CodigoMoedaDestino = CodigoMoedaDestino;
            this.CotacaoDolar = CotacaoDolar;
            this.Credito = Credito;
            this.DataCompra = DataCompra;
            this.DataCotacaoDolar = DataCotacaoDolar;
            this.DataEntradaCompra = DataEntradaCompra;
            this.DataTransacaoUTC = DataTransacaoUTC;
            this.Debito = Debito;
            this.DescricaoModoEntrada = DescricaoModoEntrada;
            this.DescricaoTransacao = DescricaoTransacao;
            this.EncargosFinanceiros = EncargosFinanceiros;
            this.Historico = Historico;
            this.IdEventoExterno = IdEventoExterno;
            this.IdTipoTransacao = IdTipoTransacao;
            this.IdTransacao = IdTransacao;
            this.Mcc = Mcc;
            this.NomeEstabVisa = NomeEstabVisa;
            this.NomePlastico = NomePlastico;
            this.NumeroEstabelecimento = NumeroEstabelecimento;
            this.Origem = Origem;
            this.TaxaEmbarque = TaxaEmbarque;
            this.TipoEvento = TipoEvento;
            this.ValorDolar = ValorDolar;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Cartao
        /// </summary>
        [DataMember(Name="cartao", EmitDefaultValue=false)]
        public string Cartao { get; set; }
    
        /// <summary>
        /// Gets or Sets Chip
        /// </summary>
        [DataMember(Name="chip", EmitDefaultValue=false)]
        public string Chip { get; set; }
    
        /// <summary>
        /// Gets or Sets CidadeUFPais
        /// </summary>
        [DataMember(Name="cidadeUFPais", EmitDefaultValue=false)]
        public string CidadeUFPais { get; set; }
    
        /// <summary>
        /// Gets or Sets CodigoAutorizacao
        /// </summary>
        [DataMember(Name="codigoAutorizacao", EmitDefaultValue=false)]
        public string CodigoAutorizacao { get; set; }
    
        /// <summary>
        /// Gets or Sets CodigoMoeda
        /// </summary>
        [DataMember(Name="codigoMoeda", EmitDefaultValue=false)]
        public string CodigoMoeda { get; set; }
    
        /// <summary>
        /// Gets or Sets CodigoMoedaDestino
        /// </summary>
        [DataMember(Name="codigoMoedaDestino", EmitDefaultValue=false)]
        public string CodigoMoedaDestino { get; set; }
    
        /// <summary>
        /// Gets or Sets CotacaoDolar
        /// </summary>
        [DataMember(Name="cotacaoDolar", EmitDefaultValue=false)]
        public double? CotacaoDolar { get; set; }
    
        /// <summary>
        /// Gets or Sets Credito
        /// </summary>
        [DataMember(Name="credito", EmitDefaultValue=false)]
        public double? Credito { get; set; }
    
        /// <summary>
        /// Gets or Sets DataCompra
        /// </summary>
        [DataMember(Name="dataCompra", EmitDefaultValue=false)]
        public string DataCompra { get; set; }
    
        /// <summary>
        /// Gets or Sets DataCotacaoDolar
        /// </summary>
        [DataMember(Name="dataCotacaoDolar", EmitDefaultValue=false)]
        public DateTime? DataCotacaoDolar { get; set; }
    
        /// <summary>
        /// Gets or Sets DataEntradaCompra
        /// </summary>
        [DataMember(Name="dataEntradaCompra", EmitDefaultValue=false)]
        public string DataEntradaCompra { get; set; }
    
        /// <summary>
        /// Gets or Sets DataTransacaoUTC
        /// </summary>
        [DataMember(Name="dataTransacaoUTC", EmitDefaultValue=false)]
        public string DataTransacaoUTC { get; set; }
    
        /// <summary>
        /// Gets or Sets Debito
        /// </summary>
        [DataMember(Name="debito", EmitDefaultValue=false)]
        public double? Debito { get; set; }
    
        /// <summary>
        /// Gets or Sets DescricaoModoEntrada
        /// </summary>
        [DataMember(Name="descricaoModoEntrada", EmitDefaultValue=false)]
        public string DescricaoModoEntrada { get; set; }
    
        /// <summary>
        /// Gets or Sets DescricaoTransacao
        /// </summary>
        [DataMember(Name="descricaoTransacao", EmitDefaultValue=false)]
        public string DescricaoTransacao { get; set; }
    
        /// <summary>
        /// Gets or Sets EncargosFinanceiros
        /// </summary>
        [DataMember(Name="encargosFinanceiros", EmitDefaultValue=false)]
        public double? EncargosFinanceiros { get; set; }
    
        /// <summary>
        /// Gets or Sets Historico
        /// </summary>
        [DataMember(Name="historico", EmitDefaultValue=false)]
        public string Historico { get; set; }
    
        /// <summary>
        /// Gets or Sets IdEventoExterno
        /// </summary>
        [DataMember(Name="idEventoExterno", EmitDefaultValue=false)]
        public int? IdEventoExterno { get; set; }
    
        /// <summary>
        /// Gets or Sets IdTipoTransacao
        /// </summary>
        [DataMember(Name="idTipoTransacao", EmitDefaultValue=false)]
        public int? IdTipoTransacao { get; set; }
    
        /// <summary>
        /// Gets or Sets IdTransacao
        /// </summary>
        [DataMember(Name="idTransacao", EmitDefaultValue=false)]
        public int? IdTransacao { get; set; }
    
        /// <summary>
        /// Gets or Sets Mcc
        /// </summary>
        [DataMember(Name="mcc", EmitDefaultValue=false)]
        public int? Mcc { get; set; }
    
        /// <summary>
        /// Gets or Sets NomeEstabVisa
        /// </summary>
        [DataMember(Name="nomeEstabVisa", EmitDefaultValue=false)]
        public string NomeEstabVisa { get; set; }
    
        /// <summary>
        /// Gets or Sets NomePlastico
        /// </summary>
        [DataMember(Name="nomePlastico", EmitDefaultValue=false)]
        public string NomePlastico { get; set; }
    
        /// <summary>
        /// Gets or Sets NumeroEstabelecimento
        /// </summary>
        [DataMember(Name="numeroEstabelecimento", EmitDefaultValue=false)]
        public int? NumeroEstabelecimento { get; set; }
    
        /// <summary>
        /// Gets or Sets Origem
        /// </summary>
        [DataMember(Name="origem", EmitDefaultValue=false)]
        public string Origem { get; set; }
    
        /// <summary>
        /// Gets or Sets TaxaEmbarque
        /// </summary>
        [DataMember(Name="taxaEmbarque", EmitDefaultValue=false)]
        public double? TaxaEmbarque { get; set; }
    
        /// <summary>
        /// Gets or Sets TipoEvento
        /// </summary>
        [DataMember(Name="tipoEvento", EmitDefaultValue=false)]
        public string TipoEvento { get; set; }
    
        /// <summary>
        /// Gets or Sets ValorDolar
        /// </summary>
        [DataMember(Name="valorDolar", EmitDefaultValue=false)]
        public double? ValorDolar { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtratoResponse {\n");
            sb.Append("  Cartao: ").Append(Cartao).Append("\n");
            sb.Append("  Chip: ").Append(Chip).Append("\n");
            sb.Append("  CidadeUFPais: ").Append(CidadeUFPais).Append("\n");
            sb.Append("  CodigoAutorizacao: ").Append(CodigoAutorizacao).Append("\n");
            sb.Append("  CodigoMoeda: ").Append(CodigoMoeda).Append("\n");
            sb.Append("  CodigoMoedaDestino: ").Append(CodigoMoedaDestino).Append("\n");
            sb.Append("  CotacaoDolar: ").Append(CotacaoDolar).Append("\n");
            sb.Append("  Credito: ").Append(Credito).Append("\n");
            sb.Append("  DataCompra: ").Append(DataCompra).Append("\n");
            sb.Append("  DataCotacaoDolar: ").Append(DataCotacaoDolar).Append("\n");
            sb.Append("  DataEntradaCompra: ").Append(DataEntradaCompra).Append("\n");
            sb.Append("  DataTransacaoUTC: ").Append(DataTransacaoUTC).Append("\n");
            sb.Append("  Debito: ").Append(Debito).Append("\n");
            sb.Append("  DescricaoModoEntrada: ").Append(DescricaoModoEntrada).Append("\n");
            sb.Append("  DescricaoTransacao: ").Append(DescricaoTransacao).Append("\n");
            sb.Append("  EncargosFinanceiros: ").Append(EncargosFinanceiros).Append("\n");
            sb.Append("  Historico: ").Append(Historico).Append("\n");
            sb.Append("  IdEventoExterno: ").Append(IdEventoExterno).Append("\n");
            sb.Append("  IdTipoTransacao: ").Append(IdTipoTransacao).Append("\n");
            sb.Append("  IdTransacao: ").Append(IdTransacao).Append("\n");
            sb.Append("  Mcc: ").Append(Mcc).Append("\n");
            sb.Append("  NomeEstabVisa: ").Append(NomeEstabVisa).Append("\n");
            sb.Append("  NomePlastico: ").Append(NomePlastico).Append("\n");
            sb.Append("  NumeroEstabelecimento: ").Append(NumeroEstabelecimento).Append("\n");
            sb.Append("  Origem: ").Append(Origem).Append("\n");
            sb.Append("  TaxaEmbarque: ").Append(TaxaEmbarque).Append("\n");
            sb.Append("  TipoEvento: ").Append(TipoEvento).Append("\n");
            sb.Append("  ValorDolar: ").Append(ValorDolar).Append("\n");
            
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
            return this.Equals(obj as ExtratoResponse);
        }

        /// <summary>
        /// Returns true if ExtratoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ExtratoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtratoResponse other)
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
                    this.Chip == other.Chip ||
                    this.Chip != null &&
                    this.Chip.Equals(other.Chip)
                ) && 
                (
                    this.CidadeUFPais == other.CidadeUFPais ||
                    this.CidadeUFPais != null &&
                    this.CidadeUFPais.Equals(other.CidadeUFPais)
                ) && 
                (
                    this.CodigoAutorizacao == other.CodigoAutorizacao ||
                    this.CodigoAutorizacao != null &&
                    this.CodigoAutorizacao.Equals(other.CodigoAutorizacao)
                ) && 
                (
                    this.CodigoMoeda == other.CodigoMoeda ||
                    this.CodigoMoeda != null &&
                    this.CodigoMoeda.Equals(other.CodigoMoeda)
                ) && 
                (
                    this.CodigoMoedaDestino == other.CodigoMoedaDestino ||
                    this.CodigoMoedaDestino != null &&
                    this.CodigoMoedaDestino.Equals(other.CodigoMoedaDestino)
                ) && 
                (
                    this.CotacaoDolar == other.CotacaoDolar ||
                    this.CotacaoDolar != null &&
                    this.CotacaoDolar.Equals(other.CotacaoDolar)
                ) && 
                (
                    this.Credito == other.Credito ||
                    this.Credito != null &&
                    this.Credito.Equals(other.Credito)
                ) && 
                (
                    this.DataCompra == other.DataCompra ||
                    this.DataCompra != null &&
                    this.DataCompra.Equals(other.DataCompra)
                ) && 
                (
                    this.DataCotacaoDolar == other.DataCotacaoDolar ||
                    this.DataCotacaoDolar != null &&
                    this.DataCotacaoDolar.Equals(other.DataCotacaoDolar)
                ) && 
                (
                    this.DataEntradaCompra == other.DataEntradaCompra ||
                    this.DataEntradaCompra != null &&
                    this.DataEntradaCompra.Equals(other.DataEntradaCompra)
                ) && 
                (
                    this.DataTransacaoUTC == other.DataTransacaoUTC ||
                    this.DataTransacaoUTC != null &&
                    this.DataTransacaoUTC.Equals(other.DataTransacaoUTC)
                ) && 
                (
                    this.Debito == other.Debito ||
                    this.Debito != null &&
                    this.Debito.Equals(other.Debito)
                ) && 
                (
                    this.DescricaoModoEntrada == other.DescricaoModoEntrada ||
                    this.DescricaoModoEntrada != null &&
                    this.DescricaoModoEntrada.Equals(other.DescricaoModoEntrada)
                ) && 
                (
                    this.DescricaoTransacao == other.DescricaoTransacao ||
                    this.DescricaoTransacao != null &&
                    this.DescricaoTransacao.Equals(other.DescricaoTransacao)
                ) && 
                (
                    this.EncargosFinanceiros == other.EncargosFinanceiros ||
                    this.EncargosFinanceiros != null &&
                    this.EncargosFinanceiros.Equals(other.EncargosFinanceiros)
                ) && 
                (
                    this.Historico == other.Historico ||
                    this.Historico != null &&
                    this.Historico.Equals(other.Historico)
                ) && 
                (
                    this.IdEventoExterno == other.IdEventoExterno ||
                    this.IdEventoExterno != null &&
                    this.IdEventoExterno.Equals(other.IdEventoExterno)
                ) && 
                (
                    this.IdTipoTransacao == other.IdTipoTransacao ||
                    this.IdTipoTransacao != null &&
                    this.IdTipoTransacao.Equals(other.IdTipoTransacao)
                ) && 
                (
                    this.IdTransacao == other.IdTransacao ||
                    this.IdTransacao != null &&
                    this.IdTransacao.Equals(other.IdTransacao)
                ) && 
                (
                    this.Mcc == other.Mcc ||
                    this.Mcc != null &&
                    this.Mcc.Equals(other.Mcc)
                ) && 
                (
                    this.NomeEstabVisa == other.NomeEstabVisa ||
                    this.NomeEstabVisa != null &&
                    this.NomeEstabVisa.Equals(other.NomeEstabVisa)
                ) && 
                (
                    this.NomePlastico == other.NomePlastico ||
                    this.NomePlastico != null &&
                    this.NomePlastico.Equals(other.NomePlastico)
                ) && 
                (
                    this.NumeroEstabelecimento == other.NumeroEstabelecimento ||
                    this.NumeroEstabelecimento != null &&
                    this.NumeroEstabelecimento.Equals(other.NumeroEstabelecimento)
                ) && 
                (
                    this.Origem == other.Origem ||
                    this.Origem != null &&
                    this.Origem.Equals(other.Origem)
                ) && 
                (
                    this.TaxaEmbarque == other.TaxaEmbarque ||
                    this.TaxaEmbarque != null &&
                    this.TaxaEmbarque.Equals(other.TaxaEmbarque)
                ) && 
                (
                    this.TipoEvento == other.TipoEvento ||
                    this.TipoEvento != null &&
                    this.TipoEvento.Equals(other.TipoEvento)
                ) && 
                (
                    this.ValorDolar == other.ValorDolar ||
                    this.ValorDolar != null &&
                    this.ValorDolar.Equals(other.ValorDolar)
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
                
                if (this.Chip != null)
                    hash = hash * 59 + this.Chip.GetHashCode();
                
                if (this.CidadeUFPais != null)
                    hash = hash * 59 + this.CidadeUFPais.GetHashCode();
                
                if (this.CodigoAutorizacao != null)
                    hash = hash * 59 + this.CodigoAutorizacao.GetHashCode();
                
                if (this.CodigoMoeda != null)
                    hash = hash * 59 + this.CodigoMoeda.GetHashCode();
                
                if (this.CodigoMoedaDestino != null)
                    hash = hash * 59 + this.CodigoMoedaDestino.GetHashCode();
                
                if (this.CotacaoDolar != null)
                    hash = hash * 59 + this.CotacaoDolar.GetHashCode();
                
                if (this.Credito != null)
                    hash = hash * 59 + this.Credito.GetHashCode();
                
                if (this.DataCompra != null)
                    hash = hash * 59 + this.DataCompra.GetHashCode();
                
                if (this.DataCotacaoDolar != null)
                    hash = hash * 59 + this.DataCotacaoDolar.GetHashCode();
                
                if (this.DataEntradaCompra != null)
                    hash = hash * 59 + this.DataEntradaCompra.GetHashCode();
                
                if (this.DataTransacaoUTC != null)
                    hash = hash * 59 + this.DataTransacaoUTC.GetHashCode();
                
                if (this.Debito != null)
                    hash = hash * 59 + this.Debito.GetHashCode();
                
                if (this.DescricaoModoEntrada != null)
                    hash = hash * 59 + this.DescricaoModoEntrada.GetHashCode();
                
                if (this.DescricaoTransacao != null)
                    hash = hash * 59 + this.DescricaoTransacao.GetHashCode();
                
                if (this.EncargosFinanceiros != null)
                    hash = hash * 59 + this.EncargosFinanceiros.GetHashCode();
                
                if (this.Historico != null)
                    hash = hash * 59 + this.Historico.GetHashCode();
                
                if (this.IdEventoExterno != null)
                    hash = hash * 59 + this.IdEventoExterno.GetHashCode();
                
                if (this.IdTipoTransacao != null)
                    hash = hash * 59 + this.IdTipoTransacao.GetHashCode();
                
                if (this.IdTransacao != null)
                    hash = hash * 59 + this.IdTransacao.GetHashCode();
                
                if (this.Mcc != null)
                    hash = hash * 59 + this.Mcc.GetHashCode();
                
                if (this.NomeEstabVisa != null)
                    hash = hash * 59 + this.NomeEstabVisa.GetHashCode();
                
                if (this.NomePlastico != null)
                    hash = hash * 59 + this.NomePlastico.GetHashCode();
                
                if (this.NumeroEstabelecimento != null)
                    hash = hash * 59 + this.NumeroEstabelecimento.GetHashCode();
                
                if (this.Origem != null)
                    hash = hash * 59 + this.Origem.GetHashCode();
                
                if (this.TaxaEmbarque != null)
                    hash = hash * 59 + this.TaxaEmbarque.GetHashCode();
                
                if (this.TipoEvento != null)
                    hash = hash * 59 + this.TipoEvento.GetHashCode();
                
                if (this.ValorDolar != null)
                    hash = hash * 59 + this.ValorDolar.GetHashCode();
                
                return hash;
            }
        }

    }
}
