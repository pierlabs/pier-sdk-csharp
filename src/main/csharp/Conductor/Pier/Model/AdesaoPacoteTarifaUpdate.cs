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
    /// Objeto que representa uma ades\u00E3o de pacote de tarifa
    /// </summary>
    [DataContract]
    public partial class AdesaoPacoteTarifaUpdate :  IEquatable<AdesaoPacoteTarifaUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdesaoPacoteTarifaUpdate" /> class.
        /// Initializes a new instance of the <see cref="AdesaoPacoteTarifaUpdate" />class.
        /// </summary>
        /// <param name="IdPacoteTarifa">Identificador do pacote de tarifa (required).</param>
        /// <param name="DataDesativacao">Data de desativa\u00E7\u00E3o.</param>
        /// <param name="RecargaCelularUtilizado">Recarga de celular utilizado (required).</param>
        /// <param name="BilheteUnicoUtilizado">Bilhete \u00FAnico utilizado (required).</param>
        /// <param name="PagamentoContaUtilizado">Pagamento conta utilizado (required).</param>
        /// <param name="SaqueUtilizado">Saque utilizado (required).</param>
        /// <param name="TransferenciaUtilizado">Transfer\u00EAncia utilizada (required).</param>
        /// <param name="BoletoUtilizado">Boleto utilizado (required).</param>
        /// <param name="AplicacaoUtilizado">Aplica\u00E7\u00E3o utilizada (required).</param>
        /// <param name="TarifaManutencaoCobrada">Tarifa manuten\u00E7\u00E3o cobrada (required).</param>
        /// <param name="CobraTarifa">Tarifa cobrada (required).</param>

        public AdesaoPacoteTarifaUpdate(long? IdPacoteTarifa = null, string DataDesativacao = null, int? RecargaCelularUtilizado = null, int? BilheteUnicoUtilizado = null, int? PagamentoContaUtilizado = null, int? SaqueUtilizado = null, int? TransferenciaUtilizado = null, int? BoletoUtilizado = null, int? AplicacaoUtilizado = null, bool? TarifaManutencaoCobrada = null, bool? CobraTarifa = null)
        {
            // to ensure "IdPacoteTarifa" is required (not null)
            if (IdPacoteTarifa == null)
            {
                throw new InvalidDataException("IdPacoteTarifa is a required property for AdesaoPacoteTarifaUpdate and cannot be null");
            }
            else
            {
                this.IdPacoteTarifa = IdPacoteTarifa;
            }
            // to ensure "RecargaCelularUtilizado" is required (not null)
            if (RecargaCelularUtilizado == null)
            {
                throw new InvalidDataException("RecargaCelularUtilizado is a required property for AdesaoPacoteTarifaUpdate and cannot be null");
            }
            else
            {
                this.RecargaCelularUtilizado = RecargaCelularUtilizado;
            }
            // to ensure "BilheteUnicoUtilizado" is required (not null)
            if (BilheteUnicoUtilizado == null)
            {
                throw new InvalidDataException("BilheteUnicoUtilizado is a required property for AdesaoPacoteTarifaUpdate and cannot be null");
            }
            else
            {
                this.BilheteUnicoUtilizado = BilheteUnicoUtilizado;
            }
            // to ensure "PagamentoContaUtilizado" is required (not null)
            if (PagamentoContaUtilizado == null)
            {
                throw new InvalidDataException("PagamentoContaUtilizado is a required property for AdesaoPacoteTarifaUpdate and cannot be null");
            }
            else
            {
                this.PagamentoContaUtilizado = PagamentoContaUtilizado;
            }
            // to ensure "SaqueUtilizado" is required (not null)
            if (SaqueUtilizado == null)
            {
                throw new InvalidDataException("SaqueUtilizado is a required property for AdesaoPacoteTarifaUpdate and cannot be null");
            }
            else
            {
                this.SaqueUtilizado = SaqueUtilizado;
            }
            // to ensure "TransferenciaUtilizado" is required (not null)
            if (TransferenciaUtilizado == null)
            {
                throw new InvalidDataException("TransferenciaUtilizado is a required property for AdesaoPacoteTarifaUpdate and cannot be null");
            }
            else
            {
                this.TransferenciaUtilizado = TransferenciaUtilizado;
            }
            // to ensure "BoletoUtilizado" is required (not null)
            if (BoletoUtilizado == null)
            {
                throw new InvalidDataException("BoletoUtilizado is a required property for AdesaoPacoteTarifaUpdate and cannot be null");
            }
            else
            {
                this.BoletoUtilizado = BoletoUtilizado;
            }
            // to ensure "AplicacaoUtilizado" is required (not null)
            if (AplicacaoUtilizado == null)
            {
                throw new InvalidDataException("AplicacaoUtilizado is a required property for AdesaoPacoteTarifaUpdate and cannot be null");
            }
            else
            {
                this.AplicacaoUtilizado = AplicacaoUtilizado;
            }
            // to ensure "TarifaManutencaoCobrada" is required (not null)
            if (TarifaManutencaoCobrada == null)
            {
                throw new InvalidDataException("TarifaManutencaoCobrada is a required property for AdesaoPacoteTarifaUpdate and cannot be null");
            }
            else
            {
                this.TarifaManutencaoCobrada = TarifaManutencaoCobrada;
            }
            // to ensure "CobraTarifa" is required (not null)
            if (CobraTarifa == null)
            {
                throw new InvalidDataException("CobraTarifa is a required property for AdesaoPacoteTarifaUpdate and cannot be null");
            }
            else
            {
                this.CobraTarifa = CobraTarifa;
            }
            this.DataDesativacao = DataDesativacao;
            
        }
        
    
        /// <summary>
        /// Identificador do pacote de tarifa
        /// </summary>
        /// <value>Identificador do pacote de tarifa</value>
        [DataMember(Name="idPacoteTarifa", EmitDefaultValue=false)]
        public long? IdPacoteTarifa { get; set; }
    
        /// <summary>
        /// Data de desativa\u00E7\u00E3o
        /// </summary>
        /// <value>Data de desativa\u00E7\u00E3o</value>
        [DataMember(Name="dataDesativacao", EmitDefaultValue=false)]
        public string DataDesativacao { get; set; }
    
        /// <summary>
        /// Recarga de celular utilizado
        /// </summary>
        /// <value>Recarga de celular utilizado</value>
        [DataMember(Name="recargaCelularUtilizado", EmitDefaultValue=false)]
        public int? RecargaCelularUtilizado { get; set; }
    
        /// <summary>
        /// Bilhete \u00FAnico utilizado
        /// </summary>
        /// <value>Bilhete \u00FAnico utilizado</value>
        [DataMember(Name="bilheteUnicoUtilizado", EmitDefaultValue=false)]
        public int? BilheteUnicoUtilizado { get; set; }
    
        /// <summary>
        /// Pagamento conta utilizado
        /// </summary>
        /// <value>Pagamento conta utilizado</value>
        [DataMember(Name="pagamentoContaUtilizado", EmitDefaultValue=false)]
        public int? PagamentoContaUtilizado { get; set; }
    
        /// <summary>
        /// Saque utilizado
        /// </summary>
        /// <value>Saque utilizado</value>
        [DataMember(Name="saqueUtilizado", EmitDefaultValue=false)]
        public int? SaqueUtilizado { get; set; }
    
        /// <summary>
        /// Transfer\u00EAncia utilizada
        /// </summary>
        /// <value>Transfer\u00EAncia utilizada</value>
        [DataMember(Name="transferenciaUtilizado", EmitDefaultValue=false)]
        public int? TransferenciaUtilizado { get; set; }
    
        /// <summary>
        /// Boleto utilizado
        /// </summary>
        /// <value>Boleto utilizado</value>
        [DataMember(Name="boletoUtilizado", EmitDefaultValue=false)]
        public int? BoletoUtilizado { get; set; }
    
        /// <summary>
        /// Aplica\u00E7\u00E3o utilizada
        /// </summary>
        /// <value>Aplica\u00E7\u00E3o utilizada</value>
        [DataMember(Name="aplicacaoUtilizado", EmitDefaultValue=false)]
        public int? AplicacaoUtilizado { get; set; }
    
        /// <summary>
        /// Tarifa manuten\u00E7\u00E3o cobrada
        /// </summary>
        /// <value>Tarifa manuten\u00E7\u00E3o cobrada</value>
        [DataMember(Name="tarifaManutencaoCobrada", EmitDefaultValue=false)]
        public bool? TarifaManutencaoCobrada { get; set; }
    
        /// <summary>
        /// Tarifa cobrada
        /// </summary>
        /// <value>Tarifa cobrada</value>
        [DataMember(Name="cobraTarifa", EmitDefaultValue=false)]
        public bool? CobraTarifa { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdesaoPacoteTarifaUpdate {\n");
            sb.Append("  IdPacoteTarifa: ").Append(IdPacoteTarifa).Append("\n");
            sb.Append("  DataDesativacao: ").Append(DataDesativacao).Append("\n");
            sb.Append("  RecargaCelularUtilizado: ").Append(RecargaCelularUtilizado).Append("\n");
            sb.Append("  BilheteUnicoUtilizado: ").Append(BilheteUnicoUtilizado).Append("\n");
            sb.Append("  PagamentoContaUtilizado: ").Append(PagamentoContaUtilizado).Append("\n");
            sb.Append("  SaqueUtilizado: ").Append(SaqueUtilizado).Append("\n");
            sb.Append("  TransferenciaUtilizado: ").Append(TransferenciaUtilizado).Append("\n");
            sb.Append("  BoletoUtilizado: ").Append(BoletoUtilizado).Append("\n");
            sb.Append("  AplicacaoUtilizado: ").Append(AplicacaoUtilizado).Append("\n");
            sb.Append("  TarifaManutencaoCobrada: ").Append(TarifaManutencaoCobrada).Append("\n");
            sb.Append("  CobraTarifa: ").Append(CobraTarifa).Append("\n");
            
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
            return this.Equals(obj as AdesaoPacoteTarifaUpdate);
        }

        /// <summary>
        /// Returns true if AdesaoPacoteTarifaUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of AdesaoPacoteTarifaUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdesaoPacoteTarifaUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdPacoteTarifa == other.IdPacoteTarifa ||
                    this.IdPacoteTarifa != null &&
                    this.IdPacoteTarifa.Equals(other.IdPacoteTarifa)
                ) && 
                (
                    this.DataDesativacao == other.DataDesativacao ||
                    this.DataDesativacao != null &&
                    this.DataDesativacao.Equals(other.DataDesativacao)
                ) && 
                (
                    this.RecargaCelularUtilizado == other.RecargaCelularUtilizado ||
                    this.RecargaCelularUtilizado != null &&
                    this.RecargaCelularUtilizado.Equals(other.RecargaCelularUtilizado)
                ) && 
                (
                    this.BilheteUnicoUtilizado == other.BilheteUnicoUtilizado ||
                    this.BilheteUnicoUtilizado != null &&
                    this.BilheteUnicoUtilizado.Equals(other.BilheteUnicoUtilizado)
                ) && 
                (
                    this.PagamentoContaUtilizado == other.PagamentoContaUtilizado ||
                    this.PagamentoContaUtilizado != null &&
                    this.PagamentoContaUtilizado.Equals(other.PagamentoContaUtilizado)
                ) && 
                (
                    this.SaqueUtilizado == other.SaqueUtilizado ||
                    this.SaqueUtilizado != null &&
                    this.SaqueUtilizado.Equals(other.SaqueUtilizado)
                ) && 
                (
                    this.TransferenciaUtilizado == other.TransferenciaUtilizado ||
                    this.TransferenciaUtilizado != null &&
                    this.TransferenciaUtilizado.Equals(other.TransferenciaUtilizado)
                ) && 
                (
                    this.BoletoUtilizado == other.BoletoUtilizado ||
                    this.BoletoUtilizado != null &&
                    this.BoletoUtilizado.Equals(other.BoletoUtilizado)
                ) && 
                (
                    this.AplicacaoUtilizado == other.AplicacaoUtilizado ||
                    this.AplicacaoUtilizado != null &&
                    this.AplicacaoUtilizado.Equals(other.AplicacaoUtilizado)
                ) && 
                (
                    this.TarifaManutencaoCobrada == other.TarifaManutencaoCobrada ||
                    this.TarifaManutencaoCobrada != null &&
                    this.TarifaManutencaoCobrada.Equals(other.TarifaManutencaoCobrada)
                ) && 
                (
                    this.CobraTarifa == other.CobraTarifa ||
                    this.CobraTarifa != null &&
                    this.CobraTarifa.Equals(other.CobraTarifa)
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
                
                if (this.IdPacoteTarifa != null)
                    hash = hash * 59 + this.IdPacoteTarifa.GetHashCode();
                
                if (this.DataDesativacao != null)
                    hash = hash * 59 + this.DataDesativacao.GetHashCode();
                
                if (this.RecargaCelularUtilizado != null)
                    hash = hash * 59 + this.RecargaCelularUtilizado.GetHashCode();
                
                if (this.BilheteUnicoUtilizado != null)
                    hash = hash * 59 + this.BilheteUnicoUtilizado.GetHashCode();
                
                if (this.PagamentoContaUtilizado != null)
                    hash = hash * 59 + this.PagamentoContaUtilizado.GetHashCode();
                
                if (this.SaqueUtilizado != null)
                    hash = hash * 59 + this.SaqueUtilizado.GetHashCode();
                
                if (this.TransferenciaUtilizado != null)
                    hash = hash * 59 + this.TransferenciaUtilizado.GetHashCode();
                
                if (this.BoletoUtilizado != null)
                    hash = hash * 59 + this.BoletoUtilizado.GetHashCode();
                
                if (this.AplicacaoUtilizado != null)
                    hash = hash * 59 + this.AplicacaoUtilizado.GetHashCode();
                
                if (this.TarifaManutencaoCobrada != null)
                    hash = hash * 59 + this.TarifaManutencaoCobrada.GetHashCode();
                
                if (this.CobraTarifa != null)
                    hash = hash * 59 + this.CobraTarifa.GetHashCode();
                
                return hash;
            }
        }

    }
}
