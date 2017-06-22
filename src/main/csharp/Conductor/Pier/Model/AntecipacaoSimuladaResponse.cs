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
    /// Representa\u00C3\u00A7\u00C3\u00A3o da resposta do recurso Antecipacao Simulada
    /// </summary>
    [DataContract]
    public partial class AntecipacaoSimuladaResponse :  IEquatable<AntecipacaoSimuladaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AntecipacaoSimuladaResponse" /> class.
        /// Initializes a new instance of the <see cref="AntecipacaoSimuladaResponse" />class.
        /// </summary>
        /// <param name="IdAntecipacaoSimulada">C\u00C3\u00B3digo identificador da simula\u00C3\u00A7\u00C3\u00A3o de antecipa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="IdConta">C\u00C3\u00B3digo identificador da conta..</param>
        /// <param name="IdEventoExterno">C\u00C3\u00B3digo identificador do evento..</param>
        /// <param name="IdTipoTransacao">C\u00C3\u00B3digo identificador do tipo do evento..</param>
        /// <param name="QtdeParcelasAntecipaveis">Quantidade de parcelas antecip\u00C3\u00A1veis..</param>
        /// <param name="ValorParcela">Valor da parcela..</param>
        /// <param name="DataHoraSimulacao">Data e hora em que a simula\u00C3\u00A7\u00C3\u00A3o foi feita..</param>
        /// <param name="TaxaAntecipacaoAno">Taxa de antecipa\u00C3\u00A7\u00C3\u00A3o aplicada (ao ano)..</param>
        /// <param name="Detalhes">Detalhes da simula\u00C3\u00A7\u00C3\u00A3o..</param>

        public AntecipacaoSimuladaResponse(long? IdAntecipacaoSimulada = null, long? IdConta = null, long? IdEventoExterno = null, long? IdTipoTransacao = null, int? QtdeParcelasAntecipaveis = null, double? ValorParcela = null, string DataHoraSimulacao = null, double? TaxaAntecipacaoAno = null, List<AntecipacaoSimuladaDetalhesResponse> Detalhes = null)
        {
            this.IdAntecipacaoSimulada = IdAntecipacaoSimulada;
            this.IdConta = IdConta;
            this.IdEventoExterno = IdEventoExterno;
            this.IdTipoTransacao = IdTipoTransacao;
            this.QtdeParcelasAntecipaveis = QtdeParcelasAntecipaveis;
            this.ValorParcela = ValorParcela;
            this.DataHoraSimulacao = DataHoraSimulacao;
            this.TaxaAntecipacaoAno = TaxaAntecipacaoAno;
            this.Detalhes = Detalhes;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador da simula\u00C3\u00A7\u00C3\u00A3o de antecipa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador da simula\u00C3\u00A7\u00C3\u00A3o de antecipa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="idAntecipacaoSimulada", EmitDefaultValue=false)]
        public long? IdAntecipacaoSimulada { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador da conta.
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador da conta.</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador do evento.
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador do evento.</value>
        [DataMember(Name="idEventoExterno", EmitDefaultValue=false)]
        public long? IdEventoExterno { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador do tipo do evento.
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador do tipo do evento.</value>
        [DataMember(Name="idTipoTransacao", EmitDefaultValue=false)]
        public long? IdTipoTransacao { get; set; }
    
        /// <summary>
        /// Quantidade de parcelas antecip\u00C3\u00A1veis.
        /// </summary>
        /// <value>Quantidade de parcelas antecip\u00C3\u00A1veis.</value>
        [DataMember(Name="qtdeParcelasAntecipaveis", EmitDefaultValue=false)]
        public int? QtdeParcelasAntecipaveis { get; set; }
    
        /// <summary>
        /// Valor da parcela.
        /// </summary>
        /// <value>Valor da parcela.</value>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public double? ValorParcela { get; set; }
    
        /// <summary>
        /// Data e hora em que a simula\u00C3\u00A7\u00C3\u00A3o foi feita.
        /// </summary>
        /// <value>Data e hora em que a simula\u00C3\u00A7\u00C3\u00A3o foi feita.</value>
        [DataMember(Name="dataHoraSimulacao", EmitDefaultValue=false)]
        public string DataHoraSimulacao { get; set; }
    
        /// <summary>
        /// Taxa de antecipa\u00C3\u00A7\u00C3\u00A3o aplicada (ao ano).
        /// </summary>
        /// <value>Taxa de antecipa\u00C3\u00A7\u00C3\u00A3o aplicada (ao ano).</value>
        [DataMember(Name="taxaAntecipacaoAno", EmitDefaultValue=false)]
        public double? TaxaAntecipacaoAno { get; set; }
    
        /// <summary>
        /// Detalhes da simula\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Detalhes da simula\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="detalhes", EmitDefaultValue=false)]
        public List<AntecipacaoSimuladaDetalhesResponse> Detalhes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AntecipacaoSimuladaResponse {\n");
            sb.Append("  IdAntecipacaoSimulada: ").Append(IdAntecipacaoSimulada).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdEventoExterno: ").Append(IdEventoExterno).Append("\n");
            sb.Append("  IdTipoTransacao: ").Append(IdTipoTransacao).Append("\n");
            sb.Append("  QtdeParcelasAntecipaveis: ").Append(QtdeParcelasAntecipaveis).Append("\n");
            sb.Append("  ValorParcela: ").Append(ValorParcela).Append("\n");
            sb.Append("  DataHoraSimulacao: ").Append(DataHoraSimulacao).Append("\n");
            sb.Append("  TaxaAntecipacaoAno: ").Append(TaxaAntecipacaoAno).Append("\n");
            sb.Append("  Detalhes: ").Append(Detalhes).Append("\n");
            
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
            return this.Equals(obj as AntecipacaoSimuladaResponse);
        }

        /// <summary>
        /// Returns true if AntecipacaoSimuladaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AntecipacaoSimuladaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntecipacaoSimuladaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdAntecipacaoSimulada == other.IdAntecipacaoSimulada ||
                    this.IdAntecipacaoSimulada != null &&
                    this.IdAntecipacaoSimulada.Equals(other.IdAntecipacaoSimulada)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
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
                    this.QtdeParcelasAntecipaveis == other.QtdeParcelasAntecipaveis ||
                    this.QtdeParcelasAntecipaveis != null &&
                    this.QtdeParcelasAntecipaveis.Equals(other.QtdeParcelasAntecipaveis)
                ) && 
                (
                    this.ValorParcela == other.ValorParcela ||
                    this.ValorParcela != null &&
                    this.ValorParcela.Equals(other.ValorParcela)
                ) && 
                (
                    this.DataHoraSimulacao == other.DataHoraSimulacao ||
                    this.DataHoraSimulacao != null &&
                    this.DataHoraSimulacao.Equals(other.DataHoraSimulacao)
                ) && 
                (
                    this.TaxaAntecipacaoAno == other.TaxaAntecipacaoAno ||
                    this.TaxaAntecipacaoAno != null &&
                    this.TaxaAntecipacaoAno.Equals(other.TaxaAntecipacaoAno)
                ) && 
                (
                    this.Detalhes == other.Detalhes ||
                    this.Detalhes != null &&
                    this.Detalhes.SequenceEqual(other.Detalhes)
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
                
                if (this.IdAntecipacaoSimulada != null)
                    hash = hash * 59 + this.IdAntecipacaoSimulada.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdEventoExterno != null)
                    hash = hash * 59 + this.IdEventoExterno.GetHashCode();
                
                if (this.IdTipoTransacao != null)
                    hash = hash * 59 + this.IdTipoTransacao.GetHashCode();
                
                if (this.QtdeParcelasAntecipaveis != null)
                    hash = hash * 59 + this.QtdeParcelasAntecipaveis.GetHashCode();
                
                if (this.ValorParcela != null)
                    hash = hash * 59 + this.ValorParcela.GetHashCode();
                
                if (this.DataHoraSimulacao != null)
                    hash = hash * 59 + this.DataHoraSimulacao.GetHashCode();
                
                if (this.TaxaAntecipacaoAno != null)
                    hash = hash * 59 + this.TaxaAntecipacaoAno.GetHashCode();
                
                if (this.Detalhes != null)
                    hash = hash * 59 + this.Detalhes.GetHashCode();
                
                return hash;
            }
        }

    }
}
