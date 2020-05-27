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
    /// Objeto de requisi\u00E7\u00E3o para cria\u00E7\u00E3o de um novo evento externo de compras
    /// </summary>
    [DataContract]
    public partial class EventoExternoCompraPersist :  IEquatable<EventoExternoCompraPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EventoExternoCompraPersist" /> class.
        /// Initializes a new instance of the <see cref="EventoExternoCompraPersist" />class.
        /// </summary>
        /// <param name="IdEstabelecimento">C\u00F3digo do estabelecimento (required).</param>
        /// <param name="IdConta">C\u00F3digo da conta (required).</param>
        /// <param name="IdCartao">C\u00F3digo do cart\u00E3o (required).</param>
        /// <param name="DataCompra">Data da compra (required).</param>
        /// <param name="IdOperacao">C\u00F3digo do tipo de opera\u00E7\u00E3o (required).</param>
        /// <param name="NumeroParcelas">N\u00FAmero de parcelas (required).</param>
        /// <param name="ValorParcela">Valor da parcela (required).</param>
        /// <param name="ValorContrato">Valor contrato (required).</param>
        /// <param name="ValorCompra">Valor da compra (required).</param>
        /// <param name="ValorEncargosTotais">Valor dos encargos totais (required).</param>
        /// <param name="TaxaJuros">Valor da taxa de juros (required).</param>
        /// <param name="ValorIOF">Valor IOF (required).</param>
        /// <param name="ValorTAC">Valor TAC (required).</param>
        /// <param name="Origem">Origem do evento (required).</param>
        /// <param name="Carencia">Quantidade de meses de carencia.</param>
        /// <param name="NomeEstabelecimento">Nome do estabelecimento.</param>

        public EventoExternoCompraPersist(long? IdEstabelecimento = null, long? IdConta = null, long? IdCartao = null, string DataCompra = null, long? IdOperacao = null, int? NumeroParcelas = null, double? ValorParcela = null, double? ValorContrato = null, double? ValorCompra = null, double? ValorEncargosTotais = null, double? TaxaJuros = null, double? ValorIOF = null, double? ValorTAC = null, string Origem = null, int? Carencia = null, string NomeEstabelecimento = null)
        {
            // to ensure "IdEstabelecimento" is required (not null)
            if (IdEstabelecimento == null)
            {
                throw new InvalidDataException("IdEstabelecimento is a required property for EventoExternoCompraPersist and cannot be null");
            }
            else
            {
                this.IdEstabelecimento = IdEstabelecimento;
            }
            // to ensure "IdConta" is required (not null)
            if (IdConta == null)
            {
                throw new InvalidDataException("IdConta is a required property for EventoExternoCompraPersist and cannot be null");
            }
            else
            {
                this.IdConta = IdConta;
            }
            // to ensure "IdCartao" is required (not null)
            if (IdCartao == null)
            {
                throw new InvalidDataException("IdCartao is a required property for EventoExternoCompraPersist and cannot be null");
            }
            else
            {
                this.IdCartao = IdCartao;
            }
            // to ensure "DataCompra" is required (not null)
            if (DataCompra == null)
            {
                throw new InvalidDataException("DataCompra is a required property for EventoExternoCompraPersist and cannot be null");
            }
            else
            {
                this.DataCompra = DataCompra;
            }
            // to ensure "IdOperacao" is required (not null)
            if (IdOperacao == null)
            {
                throw new InvalidDataException("IdOperacao is a required property for EventoExternoCompraPersist and cannot be null");
            }
            else
            {
                this.IdOperacao = IdOperacao;
            }
            // to ensure "NumeroParcelas" is required (not null)
            if (NumeroParcelas == null)
            {
                throw new InvalidDataException("NumeroParcelas is a required property for EventoExternoCompraPersist and cannot be null");
            }
            else
            {
                this.NumeroParcelas = NumeroParcelas;
            }
            // to ensure "ValorParcela" is required (not null)
            if (ValorParcela == null)
            {
                throw new InvalidDataException("ValorParcela is a required property for EventoExternoCompraPersist and cannot be null");
            }
            else
            {
                this.ValorParcela = ValorParcela;
            }
            // to ensure "ValorContrato" is required (not null)
            if (ValorContrato == null)
            {
                throw new InvalidDataException("ValorContrato is a required property for EventoExternoCompraPersist and cannot be null");
            }
            else
            {
                this.ValorContrato = ValorContrato;
            }
            // to ensure "ValorCompra" is required (not null)
            if (ValorCompra == null)
            {
                throw new InvalidDataException("ValorCompra is a required property for EventoExternoCompraPersist and cannot be null");
            }
            else
            {
                this.ValorCompra = ValorCompra;
            }
            // to ensure "ValorEncargosTotais" is required (not null)
            if (ValorEncargosTotais == null)
            {
                throw new InvalidDataException("ValorEncargosTotais is a required property for EventoExternoCompraPersist and cannot be null");
            }
            else
            {
                this.ValorEncargosTotais = ValorEncargosTotais;
            }
            // to ensure "TaxaJuros" is required (not null)
            if (TaxaJuros == null)
            {
                throw new InvalidDataException("TaxaJuros is a required property for EventoExternoCompraPersist and cannot be null");
            }
            else
            {
                this.TaxaJuros = TaxaJuros;
            }
            // to ensure "ValorIOF" is required (not null)
            if (ValorIOF == null)
            {
                throw new InvalidDataException("ValorIOF is a required property for EventoExternoCompraPersist and cannot be null");
            }
            else
            {
                this.ValorIOF = ValorIOF;
            }
            // to ensure "ValorTAC" is required (not null)
            if (ValorTAC == null)
            {
                throw new InvalidDataException("ValorTAC is a required property for EventoExternoCompraPersist and cannot be null");
            }
            else
            {
                this.ValorTAC = ValorTAC;
            }
            // to ensure "Origem" is required (not null)
            if (Origem == null)
            {
                throw new InvalidDataException("Origem is a required property for EventoExternoCompraPersist and cannot be null");
            }
            else
            {
                this.Origem = Origem;
            }
            this.Carencia = Carencia;
            this.NomeEstabelecimento = NomeEstabelecimento;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo do estabelecimento
        /// </summary>
        /// <value>C\u00F3digo do estabelecimento</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// C\u00F3digo da conta
        /// </summary>
        /// <value>C\u00F3digo da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00F3digo do cart\u00E3o
        /// </summary>
        /// <value>C\u00F3digo do cart\u00E3o</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Data da compra
        /// </summary>
        /// <value>Data da compra</value>
        [DataMember(Name="dataCompra", EmitDefaultValue=false)]
        public string DataCompra { get; set; }
    
        /// <summary>
        /// C\u00F3digo do tipo de opera\u00E7\u00E3o
        /// </summary>
        /// <value>C\u00F3digo do tipo de opera\u00E7\u00E3o</value>
        [DataMember(Name="idOperacao", EmitDefaultValue=false)]
        public long? IdOperacao { get; set; }
    
        /// <summary>
        /// N\u00FAmero de parcelas
        /// </summary>
        /// <value>N\u00FAmero de parcelas</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public int? NumeroParcelas { get; set; }
    
        /// <summary>
        /// Valor da parcela
        /// </summary>
        /// <value>Valor da parcela</value>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public double? ValorParcela { get; set; }
    
        /// <summary>
        /// Valor contrato
        /// </summary>
        /// <value>Valor contrato</value>
        [DataMember(Name="valorContrato", EmitDefaultValue=false)]
        public double? ValorContrato { get; set; }
    
        /// <summary>
        /// Valor da compra
        /// </summary>
        /// <value>Valor da compra</value>
        [DataMember(Name="valorCompra", EmitDefaultValue=false)]
        public double? ValorCompra { get; set; }
    
        /// <summary>
        /// Valor dos encargos totais
        /// </summary>
        /// <value>Valor dos encargos totais</value>
        [DataMember(Name="valorEncargosTotais", EmitDefaultValue=false)]
        public double? ValorEncargosTotais { get; set; }
    
        /// <summary>
        /// Valor da taxa de juros
        /// </summary>
        /// <value>Valor da taxa de juros</value>
        [DataMember(Name="taxaJuros", EmitDefaultValue=false)]
        public double? TaxaJuros { get; set; }
    
        /// <summary>
        /// Valor IOF
        /// </summary>
        /// <value>Valor IOF</value>
        [DataMember(Name="valorIOF", EmitDefaultValue=false)]
        public double? ValorIOF { get; set; }
    
        /// <summary>
        /// Valor TAC
        /// </summary>
        /// <value>Valor TAC</value>
        [DataMember(Name="valorTAC", EmitDefaultValue=false)]
        public double? ValorTAC { get; set; }
    
        /// <summary>
        /// Origem do evento
        /// </summary>
        /// <value>Origem do evento</value>
        [DataMember(Name="origem", EmitDefaultValue=false)]
        public string Origem { get; set; }
    
        /// <summary>
        /// Quantidade de meses de carencia
        /// </summary>
        /// <value>Quantidade de meses de carencia</value>
        [DataMember(Name="carencia", EmitDefaultValue=false)]
        public int? Carencia { get; set; }
    
        /// <summary>
        /// Nome do estabelecimento
        /// </summary>
        /// <value>Nome do estabelecimento</value>
        [DataMember(Name="nomeEstabelecimento", EmitDefaultValue=false)]
        public string NomeEstabelecimento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventoExternoCompraPersist {\n");
            sb.Append("  IdEstabelecimento: ").Append(IdEstabelecimento).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  DataCompra: ").Append(DataCompra).Append("\n");
            sb.Append("  IdOperacao: ").Append(IdOperacao).Append("\n");
            sb.Append("  NumeroParcelas: ").Append(NumeroParcelas).Append("\n");
            sb.Append("  ValorParcela: ").Append(ValorParcela).Append("\n");
            sb.Append("  ValorContrato: ").Append(ValorContrato).Append("\n");
            sb.Append("  ValorCompra: ").Append(ValorCompra).Append("\n");
            sb.Append("  ValorEncargosTotais: ").Append(ValorEncargosTotais).Append("\n");
            sb.Append("  TaxaJuros: ").Append(TaxaJuros).Append("\n");
            sb.Append("  ValorIOF: ").Append(ValorIOF).Append("\n");
            sb.Append("  ValorTAC: ").Append(ValorTAC).Append("\n");
            sb.Append("  Origem: ").Append(Origem).Append("\n");
            sb.Append("  Carencia: ").Append(Carencia).Append("\n");
            sb.Append("  NomeEstabelecimento: ").Append(NomeEstabelecimento).Append("\n");
            
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
            return this.Equals(obj as EventoExternoCompraPersist);
        }

        /// <summary>
        /// Returns true if EventoExternoCompraPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of EventoExternoCompraPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventoExternoCompraPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdEstabelecimento == other.IdEstabelecimento ||
                    this.IdEstabelecimento != null &&
                    this.IdEstabelecimento.Equals(other.IdEstabelecimento)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.DataCompra == other.DataCompra ||
                    this.DataCompra != null &&
                    this.DataCompra.Equals(other.DataCompra)
                ) && 
                (
                    this.IdOperacao == other.IdOperacao ||
                    this.IdOperacao != null &&
                    this.IdOperacao.Equals(other.IdOperacao)
                ) && 
                (
                    this.NumeroParcelas == other.NumeroParcelas ||
                    this.NumeroParcelas != null &&
                    this.NumeroParcelas.Equals(other.NumeroParcelas)
                ) && 
                (
                    this.ValorParcela == other.ValorParcela ||
                    this.ValorParcela != null &&
                    this.ValorParcela.Equals(other.ValorParcela)
                ) && 
                (
                    this.ValorContrato == other.ValorContrato ||
                    this.ValorContrato != null &&
                    this.ValorContrato.Equals(other.ValorContrato)
                ) && 
                (
                    this.ValorCompra == other.ValorCompra ||
                    this.ValorCompra != null &&
                    this.ValorCompra.Equals(other.ValorCompra)
                ) && 
                (
                    this.ValorEncargosTotais == other.ValorEncargosTotais ||
                    this.ValorEncargosTotais != null &&
                    this.ValorEncargosTotais.Equals(other.ValorEncargosTotais)
                ) && 
                (
                    this.TaxaJuros == other.TaxaJuros ||
                    this.TaxaJuros != null &&
                    this.TaxaJuros.Equals(other.TaxaJuros)
                ) && 
                (
                    this.ValorIOF == other.ValorIOF ||
                    this.ValorIOF != null &&
                    this.ValorIOF.Equals(other.ValorIOF)
                ) && 
                (
                    this.ValorTAC == other.ValorTAC ||
                    this.ValorTAC != null &&
                    this.ValorTAC.Equals(other.ValorTAC)
                ) && 
                (
                    this.Origem == other.Origem ||
                    this.Origem != null &&
                    this.Origem.Equals(other.Origem)
                ) && 
                (
                    this.Carencia == other.Carencia ||
                    this.Carencia != null &&
                    this.Carencia.Equals(other.Carencia)
                ) && 
                (
                    this.NomeEstabelecimento == other.NomeEstabelecimento ||
                    this.NomeEstabelecimento != null &&
                    this.NomeEstabelecimento.Equals(other.NomeEstabelecimento)
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
                
                if (this.IdEstabelecimento != null)
                    hash = hash * 59 + this.IdEstabelecimento.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.DataCompra != null)
                    hash = hash * 59 + this.DataCompra.GetHashCode();
                
                if (this.IdOperacao != null)
                    hash = hash * 59 + this.IdOperacao.GetHashCode();
                
                if (this.NumeroParcelas != null)
                    hash = hash * 59 + this.NumeroParcelas.GetHashCode();
                
                if (this.ValorParcela != null)
                    hash = hash * 59 + this.ValorParcela.GetHashCode();
                
                if (this.ValorContrato != null)
                    hash = hash * 59 + this.ValorContrato.GetHashCode();
                
                if (this.ValorCompra != null)
                    hash = hash * 59 + this.ValorCompra.GetHashCode();
                
                if (this.ValorEncargosTotais != null)
                    hash = hash * 59 + this.ValorEncargosTotais.GetHashCode();
                
                if (this.TaxaJuros != null)
                    hash = hash * 59 + this.TaxaJuros.GetHashCode();
                
                if (this.ValorIOF != null)
                    hash = hash * 59 + this.ValorIOF.GetHashCode();
                
                if (this.ValorTAC != null)
                    hash = hash * 59 + this.ValorTAC.GetHashCode();
                
                if (this.Origem != null)
                    hash = hash * 59 + this.Origem.GetHashCode();
                
                if (this.Carencia != null)
                    hash = hash * 59 + this.Carencia.GetHashCode();
                
                if (this.NomeEstabelecimento != null)
                    hash = hash * 59 + this.NomeEstabelecimento.GetHashCode();
                
                return hash;
            }
        }

    }
}
